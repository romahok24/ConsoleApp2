using ConsoleApp2.Enums;

namespace ConsoleApp2.Model.CharacteristicAttributes;

public class CharacteristicAttributeType : BaseEntity
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required CharacteristicAttributeTypes Type { get; set; }

    public List<CharacteristicAttribute> Attributes { get; set; } = [];
}
