using System.Threading.Tasks;
using Kandooz.InteractionSystem.Animations;
using Kandooz.InteractionSystem.Interactions;
using UnityEngine;

namespace Kandooz.InteractionSystem.Core
{
    public enum InteractionSystemType
    {
        TransformBased,
        PhysicsBased
    }

    public class CameraRig : MonoBehaviour
    {
        [SerializeField] private Transform offsetObject;
        [SerializeField] private Transform leftHand;
        [SerializeField] private Transform rightHand;
        [SerializeField] private InteractionSystemType interactionSystemType;
        [SerializeField] private HandPoseData poseData;
        [SerializeField] private Config config;
        [SerializeField] private float playerHeight;
        [SerializeField] private bool initializeLayers;
        [SerializeField] private Camera mainCamera;

        private HandPoseController leftPoseController, rightPoseController;
        public HandPoseController LeftHandPrefab => poseData.LeftHandPrefab;
        public HandPoseController RightHandPrefab => poseData.RightHandPrefab;
        public Config Config => config;

        private void Awake()
        {
            ResetPosition();
            
            switch (interactionSystemType)
            {
                case InteractionSystemType.TransformBased:

                    break;
                case InteractionSystemType.PhysicsBased:
                    InitializePhysicsBasedHands();
                    break;
            }
            if(!initializeLayers)return; 
                
            ChangeLayerRecursive(transform, config.PlayerLayer);
            ChangeLayerRecursive(leftHand, config.LeftHandLayer);
            ChangeLayerRecursive(rightHand, config.RightHandLayer);
        }

        static void ChangeLayerRecursive(Transform transform, int layer)
        {

            transform.gameObject.layer = layer;
            for (int i = 0; i < transform.childCount; i++)
            {
                ChangeLayerRecursive(transform.GetChild(i), layer);
            }
        }

        private void InitializePhysicsBasedHands()
        {
            InitializeHands();
        }

        private void InitializeHands()
        {
            rightPoseController = InitializeHand(RightHandPrefab, rightHand, HandIdentifier.Right);
            leftPoseController = InitializeHand(LeftHandPrefab, leftHand, HandIdentifier.Left);
            InitializePhysics(rightPoseController.gameObject, rightHand);
            InitializePhysics(leftPoseController.gameObject, leftHand);
        }

        private static void InitializePhysics(GameObject hand, Transform target)
        {
            // TODO: the values should be moved to the config file 

            var rb = hand.GetComponent<Rigidbody>();
            if (rb == null) rb = hand.AddComponent<Rigidbody>();
            rb.mass = 40;
            rb.drag = 5;
            rb.angularDrag = 1;
            var follower = hand.AddComponent<PhysicsHandFollwer>();
            follower.Target = target;
        }

        private HandPoseController InitializeHand(HandPoseController handPrefab, Transform handPivot, HandIdentifier handIdentifier)
        {
            var poseController = handPivot.GetComponentInChildren<HandPoseController>();
            if (poseController != null) return poseController;

            poseController = Instantiate(handPrefab, handPivot);
            poseController.transform.localPosition = Vector3.zero;
            poseController.transform.localRotation = Quaternion.identity;
            var hand = poseController.gameObject;
            var handController = hand.AddComponent<Hand>();
            handController.HandIdentifier = handIdentifier;
            handController.Config = config;
            hand.AddComponent<TriggerInteractor>();
            return poseController;
        }

        public async void ResetPosition()
        {
            var cameraPosition = mainCamera.transform.localPosition;
            cameraPosition.y = 0;
            offsetObject.transform.localPosition = -cameraPosition;
            await Task.Delay(200);  
            var yRotation = mainCamera.transform.localRotation.eulerAngles.y;
            var angles = offsetObject.localRotation.eulerAngles;
            angles.y = -yRotation;
            offsetObject.localRotation = Quaternion.Euler(angles);
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.Joystick1Button0))
            {
                ResetPosition();
            }
        }
    }
}