using ConsoleApp2.Enums;

namespace ConsoleApp2.Model.LogicBlockAttributes;

public class LogicBlockAttributeType : BaseEntity
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required LogicBlockAttributeTypes Type { get; set; }

    public List<LogicBlockAttribute> LogicBlockAttributes { get; set; } = [];
}
