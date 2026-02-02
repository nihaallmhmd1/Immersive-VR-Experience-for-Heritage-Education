using UnityEngine;
using TMPro;

public class InfoPanelUI : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI descriptionText;

    public void UpdateContent(string title, string description)
    {
        titleText.text = title;
        descriptionText.text = description;
    }

    public void ClosePanel()
    {
        gameObject.SetActive(false);
    }
}
