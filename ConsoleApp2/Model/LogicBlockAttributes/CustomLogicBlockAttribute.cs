namespace ConsoleApp2.Model.LogicBlockAttributes;

public class CustomLogicBlockAttribute : LogicBlockAttribute
{
    public required string ProcedureSqlCode { get; set; }
    public required string ProcedureSignature { get; set; }
}
