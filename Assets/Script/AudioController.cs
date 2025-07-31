using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;
    public bool IsPlaying => audioSource != null && audioSource.isPlaying;

    public void PlayAudio()
    {
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
