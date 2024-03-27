using ExperimentalThingsUsingWPF.HelperClasses;
using System.ComponentModel;
using ExperimentalThingsUsingWPF.Translations;

namespace ExperimentalThingsUsingWPF.Models;
[TypeConverter(typeof(EnumDescriptionTypeConverter))]
public enum UserType
{
    [LocalizedDescription("Userype1", typeof(Translations.Translations))]
    Type1,
    [LocalizedDescription("UserType2", typeof(Translations.Translations))]
    Type2,
    [LocalizedDescription("UserType3", typeof(Translations.Translations))]
    Type3
}


