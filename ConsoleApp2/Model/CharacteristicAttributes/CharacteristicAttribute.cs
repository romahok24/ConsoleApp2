namespace ConsoleApp2.Model.CharacteristicAttributes;

public class CharacteristicAttribute : BaseEntity
{
    public required int CharacteristicConfigurationId { get; set; }
    public required int CharacteristicAttributeTypeId { get; set; }

    public required CharacteristicConfiguration CharacteristicConfiguration { get; set; }
    public required CharacteristicAttributeType CharacteristicAttributeType { get; set; }
}
