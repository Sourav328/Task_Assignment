using UnityEngine;

public class NPCController : MonoBehaviour
{
    public Animator animator;
    public AudioController audioController;

    private bool isTalking = false;

    void Update()
    {
        if (audioController != null)
        {
            if (audioController.IsPlaying)
            {
                if (!isTalking)
                {
                    animator.SetTrigger("Talk");
                    isTalking = true;
                }
            }
            else if (isTalking)
            {
                animator.SetTrigger("Idle"); // You must set this trigger in Animator
                isTalking = false;
            }
        }
    }
}

