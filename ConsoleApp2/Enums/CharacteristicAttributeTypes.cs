namespace ConsoleApp2.Enums;

public enum CharacteristicAttributeTypes
{
    Key = 1,
    ForeignKey = 2,
    MultiplyForeignKey = 3,
    ParentKey = 4,
    MaxLength = 5,
    NumberRange = 6,
    NumericRange = 7,
    Required = 8,
    RequiredIfSelected = 10,
    RequiredIfNotSelected = 11,
    Unique = 12,
    MultiplyUnique = 13,
    Regex = 14,

    DateRange = 15,
    TimeRange = 16,

    OnInput,
    OnChange,
    OnSelect,
    Disabled,
    Hide,
    ScriptFilePath,
}
