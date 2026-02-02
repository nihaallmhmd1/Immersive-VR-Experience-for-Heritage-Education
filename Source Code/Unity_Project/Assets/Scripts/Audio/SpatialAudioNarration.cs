using UnityEngine;

public class SpatialAudioNarration : MonoBehaviour
{
    private AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.spatialBlend = 1.0f;
        audioSource.playOnAwake = false;
    }

    public void PlayNarration()
    {
        if (!audioSource.isPlaying)
            audioSource.Play();
    }

    public void StopNarration()
    {
        audioSource.Stop();
    }
}
