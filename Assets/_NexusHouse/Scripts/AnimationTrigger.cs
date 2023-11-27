using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public Animator wallAnimator;

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            wallAnimator.SetTrigger("MoveDown");
        }
    }
}
