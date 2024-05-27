namespace ConsoleApp2.Model.CharacteristicAttributes;

public class CharacteristicAttributeNumericRange : CharacteristicAttribute
{
    public required int Precision { get; set; }
    public required int Scale { get; set; }
}
