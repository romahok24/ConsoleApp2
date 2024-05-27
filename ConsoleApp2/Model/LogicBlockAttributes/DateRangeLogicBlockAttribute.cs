namespace ConsoleApp2.Model.LogicBlockAttributes;

public class DateRangeLogicBlockAttribute : LogicBlockAttribute
{
    public required int StartDateCharacteristicId { get; set; }
    public required int EndDateCharacteristicId { get; set; }

    public CharacteristicConfiguration StartDateCharacteristic {  get; set; }
    public CharacteristicConfiguration EndDateCharacteristic { get; set; }
}
