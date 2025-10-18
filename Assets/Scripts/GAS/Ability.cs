using UnityEngine;

[CreateAssetMenu(fileName = "Ability", menuName = "Scriptable Objects/Ability")]
public class Ability : ScriptableObject
{
    public string abilityName;
    public IGameplayEffect[] effects;

    public void Activate(AttributeSet target)
    {
        foreach (var effect in effects)
            effect.ApplyEffect(target);
    }
}
