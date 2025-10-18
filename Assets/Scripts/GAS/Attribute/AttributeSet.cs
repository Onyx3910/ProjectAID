using UnityEngine;

public class AttributeSet : MonoBehaviour
{
    public IAttributeInstance[] attributes;

    public void Initialize()
    {
        foreach (var instance in attributes)
        {
            instance.Initialize();
        }
    }

    public IAttributeInstance GetAttribute(string attributeName)
    {
        foreach (var instance in attributes)
        {
            if (instance.GetName() == attributeName)
            {
                return instance;
            }
        }

        return null;
    }
}
