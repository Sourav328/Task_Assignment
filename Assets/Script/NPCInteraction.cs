using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    public Animator npcAnimator;

    public void PlayTalk()
    {
        if (npcAnimator != null)
        {
            npcAnimator.SetTrigger("Talk");
        }
    }
}

