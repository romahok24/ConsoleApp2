namespace ConsoleApp2.Model;

public class SystemObject : BaseEntity
{
    public required string Name { get; set; }
    public required string Code { get; set; }

    public List<LogicBlockConfiguration> LogicBlockConfigurations { get; set; } = [];
}
