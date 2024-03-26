using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ExperimentalThingsUsingWPF.HelperClasses;

public class EnumBindingSourceExtension : MarkupExtension
{
    public Type EnumType { get; private set; }
    public EnumBindingSourceExtension(Type enumType)
    {
        if (enumType is null || !enumType.IsEnum)
            throw new ArgumentException("EnumType must not be null and should be Enum");
        EnumType = enumType;
    }
    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        return Enum.GetValues(EnumType);
    }
}
