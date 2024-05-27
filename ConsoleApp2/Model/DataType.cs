using ConsoleApp2.Enums;

namespace ConsoleApp2.Model;

public class DataType : BaseEntity
{
    public required string Name { get; set; }
    public required DataTypes Type { get; set; }
    public required string InputType { get; set; }
    public required string Description { get; set; }
    public required string PosgresType { get; set; }

    public List<Characteristic> Characteristics { get; set; } = [];
}
