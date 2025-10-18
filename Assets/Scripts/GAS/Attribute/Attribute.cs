using UnityEngine;

public interface IAttribute
{
    string AttributeName { get; }
    object GetValue();
}

public interface IAttribute<TValue> : IAttribute
{
    new TValue GetValue();
}

[CreateAssetMenu(fileName = "Attribute", menuName = "Scriptable Objects/Attribute")]
public abstract class Attribute<TValue> : ScriptableObject, IAttribute<TValue>
{
    public string attributeName;
    public TValue value;

    public string AttributeName => attributeName;
    public object GetValue() => value;
    TValue IAttribute<TValue>.GetValue() => value;
}

// Float Attribute
[CreateAssetMenu(fileName = "FloatAttribute", menuName = "Scriptable Objects/Attribute/Float")]
public class FloatAttribute : Attribute<float>
{
}

// Bool Attribute
[CreateAssetMenu(fileName = "BoolAttribute", menuName = "Scriptable Objects/Attribute/Bool")]
public class BoolAttribute : Attribute<bool>
{
}

// String Attribute
[CreateAssetMenu(fileName = "StringAttribute", menuName = "Scriptable Objects/Attribute/String")]
public class StringAttribute : Attribute<string>
{
}
