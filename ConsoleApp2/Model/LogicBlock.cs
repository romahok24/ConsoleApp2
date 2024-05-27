namespace ConsoleApp2.Model;

public class LogicBlock : BaseEntity
{
    public required string Code { get; set; }
    public required string Name { get; set; }
    public required string TableName { get; set; }

    public List<LogicBlockConfiguration> LogicBlockConfigurations { get; set; } = [];
}
