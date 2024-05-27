namespace ConsoleApp2.Model;

public class Characteristic : BaseEntity
{
    public required string Name { get; set; }
    public required int DataTypeId { get; set; }
    public required string Description { get; set; }
    
    public DataType DataType { get; set; }

    public List<CharacteristicConfiguration> CharacteristicConfigurations { get; set; } = [];
}
