namespace ConsoleApp2.Model.LogicBlockAttributes;

public class LogicBlockAttributeCharacteristicConfiguration : BaseEntity
{
    public required int LogicBlockAttributeId { get; set; }
    public required int CharacteristicConfigurationId { get; set; }

    public LogicBlockAttribute LogicBlockAttribute { get; set; }
    public CharacteristicConfiguration CharacteristicConfiguration { get; set; }
}
