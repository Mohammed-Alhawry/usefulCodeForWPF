using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalThingsUsingWPF.HelperClasses;

public class EnumDescriptionTypeConverter : EnumConverter
{
    public EnumDescriptionTypeConverter(Type type) : base(type)
    {

    }

    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
        if (destinationType == typeof(string))
        {
            if (value is not null)
            {
                FieldInfo fieldInfo = value.GetType().GetField(value.ToString());
                if (fieldInfo is not null)
                {
                    var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
                    if (attributes.Length > 0 && !string.IsNullOrEmpty(attributes[0].Description))
                        return attributes[0].Description;
                    else
                        return value.ToString();

                }
            }
        }

        return base.ConvertTo(context, culture, value, destinationType);
    }
}
