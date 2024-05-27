using ConsoleApp2.Model.LogicBlockAttributes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static ConsoleApp2.Constants;
using static ConsoleApp2.SystemConfigConstants;

namespace ConsoleApp2.Configuration;

public class BooleanLogicBlockAttributeConfig : IEntityTypeConfiguration<BooleanLogicBlockAttribute>
{
    public void Configure(EntityTypeBuilder<BooleanLogicBlockAttribute> builder)
    {
        builder.ToTable(SystemConfigTableNames.BOOLEAN_LOGIC_BLOCK_ATTRIBUTE, SchemaNames.SYSTEM_CONFIG_DB_CONTEXT);

        builder
            .Property(x => x.Value)
            .HasColumnName(ColumnNames.VALUE)
            .IsRequired();

        builder
            .HasOne<LogicBlockAttribute>()
            .WithOne()
            .HasForeignKey<BooleanLogicBlockAttribute>(x => x.Id)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
