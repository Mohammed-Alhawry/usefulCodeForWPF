using System.ComponentModel;
using System.Resources;

namespace ExperimentalThingsUsingWPF.HelperClasses;

public class LocalizedDescriptionAttribute : DescriptionAttribute
{
    private ResourceManager _resourceManager;
    private readonly string _resourceKey;

    public LocalizedDescriptionAttribute(string resourceKey, Type resourceType)
    {
        _resourceManager = new ResourceManager(resourceType);
        _resourceKey = resourceKey;
    }

    public override string Description {
        get
        {
            string description = _resourceManager.GetString(_resourceKey);
            return string.IsNullOrWhiteSpace(description) ? $"{_resourceKey}" : description;
        }
    }
}
