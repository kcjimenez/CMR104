using Kandooz.InteractionSystem.Interactions;
using UnityEditor;
using UnityEngine;

namespace Kandooz.InteractionSystem.Core
{
    public class GameObjectMenuHelpers : Editor
    {
        [MenuItem("GameObject/Kandooz/MakeGrabable", priority = 0)]
        public static void MakeInteractable()
        {
            var obj = Selection.activeGameObject;
            if (obj == null)
                obj = new GameObject("grabable object");

            if (obj.GetComponent<Grabable>()) return;
            //obj.AddComponent<Rigidbody>();
            obj.AddComponent<Grabable>();
            Selection.activeGameObject = obj;
        }

        [MenuItem("GameObject/Kandooz/MakeThrowable", priority = 1)]
        public static void MakeThrowable()
        {
            var obj = Selection.activeGameObject;
            if (obj == null)
                obj = new GameObject("grabable object");

            if (obj.GetComponent<Throwable>()) return;
            obj.AddComponent<Rigidbody>().isKinematic = true;
            obj.AddComponent<Grabable>();
            obj.AddComponent<Throwable>();
            Selection.activeGameObject = obj;
        }

        [MenuItem("GameObject/Kandooz/MakeLever", priority = 4)]
        public static void MakeLever()
        {
            Transform parent;
            var knob = Selection.activeGameObject;
            if(knob.GetComponent<LeverInteractable>())return;
            if (knob)
            {
                parent = new GameObject(knob.name).transform;
                knob.transform.parent = parent.transform;
            }
            else
            {
                parent = new GameObject("Lever").transform;
                var stick = GameObject.CreatePrimitive(PrimitiveType.Capsule).transform;
                stick.parent = parent;
                stick.localScale = new Vector3(.1f, .2f, .1f);
                stick.localPosition = new Vector3(0, .2f, 0);
                knob = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                knob.name = "knob";
                knob.transform.parent = parent;
                knob.transform.localScale =Vector3.one * .15f;
                knob.transform.localPosition = new Vector3(0, .45f, 0);


            }


            if (parent.GetComponent<LeverInteractable>()) return;
            var lever = parent.gameObject.AddComponent<LeverInteractable>();
            Selection.activeGameObject = parent.gameObject;
        }

        [MenuItem("GameObject/Kandooz/MakeDrawer", priority = 3)]
        public static void MakeLinearallyCOnstrainedInteractable()
        {
        }

        [MenuItem("GameObject/Kandooz/Button", priority = 9)]
        public static void MakeButton()
        {
            var buttonObject = GameObject.CreatePrimitive(PrimitiveType.Cylinder).transform;
            var buttonBody = GameObject.CreatePrimitive(PrimitiveType.Cube).transform;
            buttonObject.GetComponent<MeshRenderer>().material.color = Color.red;
            buttonBody.name = "Button";
            var trigger = buttonBody.gameObject.AddComponent<BoxCollider>();
            trigger.center = Vector3.up * .2f;
            trigger.isTrigger = true;
            buttonObject.transform.parent = buttonBody.transform;
            buttonObject.localScale = new Vector3(.5f, .25f, .5f);
            buttonObject.localPosition = Vector3.up * .5f;
            var button = buttonBody.gameObject.AddComponent<VRButton>();
            button.Button = buttonObject.transform;
            buttonBody.localScale = Vector3.one / 10;
        }
    }
}