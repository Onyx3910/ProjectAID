using UnityEngine;

public interface IGameplayEffect
{
    void ApplyEffect(AttributeSet target);
}

[CreateAssetMenu(fileName = "GameplayEffect", menuName = "Scriptable Objects/GameplayEffect")]
public abstract class GameplayEffect<TValue> : ScriptableObject, IGameplayEffect
{
    public string targetAttributeName;
    public TValue effectValue;
    public EffectType effectType;

    public abstract void ApplyEffect(AttributeSet target);
}

public enum EffectType
{
    // Float
    SetFloat,
    AddFloat,
    SubtractFloat,
    MultiplyFloat,
    DivideFloat,
    
    // String
    SetString,
    AppendString,

    // Bool
    SetBool,
    ToggleBool,
}
