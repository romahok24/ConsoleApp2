using ConsoleApp2.Enums;

namespace ConsoleApp2.Model;

public class Event : BaseEntity
{
    public required string Name { get; set; }
    public required EventTypes Type { get; set; }

    public List<LogicBlockConfigurationEvent> LogicBlockConfigurationEvents { get; set; } = [];
}
