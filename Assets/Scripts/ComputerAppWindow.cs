using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ComputerAppWindow : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public Button closeButton;
    public RectTransform windowTransform;

    public void SetTitle(string title)
    {
        if (titleText)
        {
            titleText.text = title;
        }
    }

    void Start()
    {
        if (closeButton)
        {
            closeButton.onClick.AddListener(() => Destroy(gameObject));
        }
    }
}
