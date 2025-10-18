using UnityEngine;

[CreateAssetMenu(fileName = "EmailData", menuName = "Scriptable Objects/EmailData")]
public class EmailData : ScriptableObject
{
    public string sender;
    public string[] CCList;
    public string subject;
    [TextArea] public string body;
}
