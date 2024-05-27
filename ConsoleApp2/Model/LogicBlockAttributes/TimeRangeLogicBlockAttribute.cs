namespace ConsoleApp2.Model.LogicBlockAttributes;

public class TimeRangeLogicBlockAttribute : LogicBlockAttribute
{
    public required int StartTimeCharacteristicId { get; set; }
    public required int EndTimeCharacteristicId { get; set; }

    public CharacteristicConfiguration StartTimeCharacteristic { get; set; }
    public CharacteristicConfiguration EndTimeCharacteristic { get; set; }
}
