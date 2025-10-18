using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "ComputerApp", menuName = "Scriptable Objects/ComputerApp")]
public class ComputerApp : ScriptableObject
{
    public string appName;
    public bool fullscreen;
    public bool draggable;
    public GameObject windowPrefab;
    public Image icon;
}
