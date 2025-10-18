public interface IAttributeInstance
{
    void Initialize();
    void Modify(object value);
    string GetName();
    object GetValue();
}

public interface IAttributeInstance<TValue> : IAttributeInstance
{
    void Modify(TValue value);
    new TValue GetValue();
}

[System.Serializable]
public abstract class AttributeInstance<TValue> : IAttributeInstance<TValue>
{
    public IAttribute<TValue> attribute;
    public TValue currentValue;

    public void Initialize()
    {
        currentValue = attribute.GetValue();
    }

    public abstract void Modify(TValue value);

    public void Modify(object value)
    {
        if (value is TValue tValue)
            Modify(tValue);
    }

    public string GetName() => attribute.AttributeName;

    public object GetValue() => currentValue;
    TValue IAttributeInstance<TValue>.GetValue() => currentValue;
}

[System.Serializable]
public class FloatAttributeInstance : AttributeInstance<float>
{
    public override void Modify(float value)
    {
        currentValue += value;
    }
}

[System.Serializable]
public class BoolAttributeInstance : AttributeInstance<bool>
{
    public override void Modify(bool value)
    {
        currentValue = value;
    }
}

[System.Serializable]
public class StringAttributeInstance : AttributeInstance<string>
{
    public override void Modify(string value)
    {
        currentValue = value;
    }
}
