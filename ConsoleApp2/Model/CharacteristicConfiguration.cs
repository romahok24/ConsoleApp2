using ConsoleApp2.Model.CharacteristicAttributes;

namespace ConsoleApp2.Model;

public class CharacteristicConfiguration : BaseEntity
{
    public required int LogicBlockConfigurationId { get; set; }
    public required int CharacteristicId { get; set; }
    public required int Order { get; set; }

    public Characteristic Characteristic { get; set; }
    public LogicBlockConfiguration LogicBlockConfiguration { get; set; }

    public List<CharacteristicAttribute> CharacteristicAttributes { get; set; }
}
