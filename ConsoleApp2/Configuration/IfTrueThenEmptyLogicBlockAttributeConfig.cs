using ConsoleApp2.Model.LogicBlockAttributes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static ConsoleApp2.Constants;
using static ConsoleApp2.SystemConfigConstants;

namespace ConsoleApp2.Configuration;

public class IfTrueThenEmptyLogicBlockAttributeConfig : IEntityTypeConfiguration<IfTrueThenEmptyLogicBlockAttribute>
{
    public void Configure(EntityTypeBuilder<IfTrueThenEmptyLogicBlockAttribute> builder)
    {
        builder.ToTable(SystemConfigTableNames.IF_TRUE_THEN_EMPTY_LOGIC_BLOCK_ATTRIBUTE, SchemaNames.SYSTEM_CONFIG_DB_CONTEXT);

        builder
            .Property(x => x.FlagCharacteristicConfigurationId)
            .HasColumnName(ColumnNames.FLAG_CHARACTERISTIC_CONFIGURATION_ID)
            .IsRequired();

        builder
            .HasOne(x => x.FlagCharacteristicConfiguration)
            .WithMany()
            .HasForeignKey(x => x.FlagCharacteristicConfigurationId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne<LogicBlockAttribute>()
            .WithOne()
            .HasForeignKey<IfTrueThenEmptyLogicBlockAttribute>(x => x.Id)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
