using UnityEngine;

public class DesktopController : MonoBehaviour
{
    [Header("Desktop Regions")]
    public Transform desktopArea; // UI panel to contain windows
    public Transform iconContainer; // Where app icons are placed

    [Header("Functionality Prefabs")]
    public GameObject appIconPrefab;

    [Header("Settings")]
    public ComputerApp[] installedApps;

    private void Start()
    {
        PopulateDesktop();
    }

    private void PopulateDesktop()
    {
        foreach (var app in installedApps)
        {
            var icon = Instantiate(appIconPrefab, iconContainer);
            var iconScript = icon.GetComponent<DesktopIcon>();
            iconScript.Initialize(app, this);
        }
    }

    public void LaunchApp(ComputerApp app)
    {
        GameObject window = Instantiate(app.windowPrefab, desktopArea);
        window.name = app.appName;

        var appWindow = window.GetComponent<ComputerAppWindow>();
        if (appWindow != null)
            appWindow.SetTitle(app.appName);
    }
}
