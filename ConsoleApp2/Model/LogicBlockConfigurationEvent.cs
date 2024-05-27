namespace ConsoleApp2.Model;

public class LogicBlockConfigurationEvent : BaseEntity
{ 
    public required int Order {  get; set; }   
    public required int EventId { get; set; }
    public required int LogicBlockConfigurationId { get; set; }

    public Event Event { get; set; }
    public LogicBlockConfiguration LogicBlockConfiguration {  get; set; }   
}
