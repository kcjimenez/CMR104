using System;
using UnityEngine;
using UnityEngine.Events;

namespace Kandooz.InteractionSystem.Interactions
{
    public class LeverInteractable : ConstrainedInteractableBase
    {
        [SerializeField] private bool limited;
        [SerializeField] private float limit = 30;
        [SerializeField] private UnityEvent onAngleChanged;
        [SerializeField] private UnityEvent onOpen;
        [SerializeField] private UnityEvent onClose;
        [SerializeField] private UnityEvent onMiddle;

        [SerializeField] private Animator wallAnimator; // Reference to the wall's Animator component

        private float oldNormalizedAngle;
        private float currentNormalizedAngle;

        private void Start()
        {
            oldNormalizedAngle = currentNormalizedAngle = 0;
        }

        protected override void Activate() { }
        protected override void StartHover() { }
        protected override void EndHover() { }

        private void Update()
        {
            if (!IsSelected) return;
            var angle = CalculateAngle();
            RotateLever(angle);
            InvokeEvents();
        }

        private void RotateLever(float angle)
        {
            if (limited)
            {
                if (angle > limit / 2)
                {
                    angle = limit / 2;
                }

                if (angle < -limit / 2)
                {
                    angle = -limit / 2;
                }
            }

            interactableObject.transform.localRotation = Quaternion.Euler(angle, 0, 0);
            currentNormalizedAngle = angle / (limit / 2);
        }

        private void InvokeEvents()
        {
            if (Math.Abs(currentNormalizedAngle - oldNormalizedAngle) > .1f)
            {
                onAngleChanged.Invoke();
                oldNormalizedAngle = currentNormalizedAngle;

                if (currentNormalizedAngle > .9f)
                {
                    onOpen.Invoke();
                }

                if (currentNormalizedAngle < -.9f)
                {
                    onClose.Invoke();

                    // Trigger the wall 
                    if (wallAnimator != null)
                    {
                        wallAnimator.SetTrigger("MoveDown");
                        Debug.Log("Wall animation triggered");
                    }
                    else
                    {
                        Debug.LogError("Wall Animator is null!");
                    }
                }

                if (currentNormalizedAngle < .1f && currentNormalizedAngle > -.1f)
                {
                    onMiddle.Invoke();
                }
            }
        }

        private float CalculateAngle()
        {
            var direction = CurrentInteractor.transform.position - transform.position;
            direction = Vector3.ProjectOnPlane(direction, -transform.right).normalized;
            var angle = -Vector3.SignedAngle(direction, transform.up, transform.right);
            return angle;
        }
    }
}
