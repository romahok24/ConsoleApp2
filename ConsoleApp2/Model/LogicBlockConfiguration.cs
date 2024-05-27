using ConsoleApp2.Model.LogicBlockAttributes;

namespace ConsoleApp2.Model;

public class LogicBlockConfiguration : BaseEntity
{
    public int? ParentId { get; set; }
    public required int LogicBlockId {  get; set; }
    public required int SystemObjectId {  get; set; }


    public required LogicBlockConfiguration Parent {  get; set; }
    public required LogicBlock LogicBlock {  get; set; }
    public required SystemObject SystemObject {  get; set; }

    public List<LogicBlockAttribute> LogicBlockAttributes { get; set; } = [];
    public List<CharacteristicConfiguration> CharacteristicConfigurations { get; set; } = [];
    public List<LogicBlockConfigurationEvent> LogicBlockConfigurationEvents { get; set; } = [];

    public List<LogicBlockConfiguration> Childrens { get; set; } = [];
}
