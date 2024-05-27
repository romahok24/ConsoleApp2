using ConsoleApp2.Model.LogicBlockAttributes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static ConsoleApp2.Constants;
using static ConsoleApp2.SystemConfigConstants;

namespace ConsoleApp2.Configuration;

public class CustomLogicBlockAttributeConfig : IEntityTypeConfiguration<CustomLogicBlockAttribute>
{
    public void Configure(EntityTypeBuilder<CustomLogicBlockAttribute> builder)
    {
        builder.ToTable(SystemConfigTableNames.CUSTOM_LOGIC_BLOCK_ATTRIBUTE, SchemaNames.SYSTEM_CONFIG_DB_CONTEXT);

        builder
            .Property(x => x.ProcedureSqlCode)
            .HasColumnName(ColumnNames.PROCEDURE_SQL_CODE)
            .IsRequired();

        builder
            .Property(x => x.ProcedureSignature)
            .HasColumnName(ColumnNames.PROCEDURE_SIGNATURE)
            .IsRequired();

        builder
            .HasOne<LogicBlockAttribute>()
            .WithOne()
            .HasForeignKey<CustomLogicBlockAttribute>(x => x.Id)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
