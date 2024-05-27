namespace ConsoleApp2.Model.LogicBlockAttributes;

public class LogicBlockAttribute : BaseEntity
{
    public required int LogicBlockAttributeTypeId { get; set; }
    public required int LogicBlockConfigurationId { get; set; }

    public LogicBlockAttributeType LogicBlockAttributeType { get; set; }
    public LogicBlockConfiguration LogicBlockConfiguration { get; set; }

    public List<LogicBlockAttributeCharacteristicConfiguration> LogicBlockAttributeCharacteristicConfigurations { get; set; } = [];
}
