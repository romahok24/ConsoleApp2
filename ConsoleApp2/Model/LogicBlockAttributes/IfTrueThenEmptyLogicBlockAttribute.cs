namespace ConsoleApp2.Model.LogicBlockAttributes;

public class IfTrueThenEmptyLogicBlockAttribute : LogicBlockAttribute
{
    public required int FlagCharacteristicConfigurationId { get; set; }
    public CharacteristicConfiguration FlagCharacteristicConfiguration { get; set; }
}
