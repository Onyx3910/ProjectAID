using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class DesktopIcon : MonoBehaviour
{
    public Image iconImage;
    public TextMeshProUGUI label; // Needs to be child object
    private ComputerApp application;
    private DesktopController manager;

    public void Initialize(ComputerApp appData, DesktopController computerManager)
    {
        application = appData;
        manager = computerManager;
        iconImage = application.icon;
        label.text = application.appName;
    }

    public void OnClick()
    {
        manager.LaunchApp(application);
    }
}