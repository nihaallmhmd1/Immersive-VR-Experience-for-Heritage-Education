using UnityEngine;

public class HotspotInteraction : MonoBehaviour
{
    public GameObject infoPanel;
    public AudioSource narrationAudio;

    void Start()
    {
        infoPanel.SetActive(false);
    }

    public void ActivateHotspot()
    {
        infoPanel.SetActive(true);

        if (!narrationAudio.isPlaying)
            narrationAudio.Play();
    }

    public void DeactivateHotspot()
    {
        infoPanel.SetActive(false);
        narrationAudio.Stop();
    }
}
