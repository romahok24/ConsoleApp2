using ConsoleApp2.Model.LogicBlockAttributes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static ConsoleApp2.Constants;
using static ConsoleApp2.SystemConfigConstants;

namespace ConsoleApp2.Configuration;

public class LogicBlockAttributeCharacteristicConfigurationConfig : IEntityTypeConfiguration<LogicBlockAttributeCharacteristicConfiguration>
{
    public void Configure(EntityTypeBuilder<LogicBlockAttributeCharacteristicConfiguration> builder)
    {
        builder.ToTable(SystemConfigTableNames.LOGIC_BLOCK_ATTRIBUTE_CHARACTERISTIC_CONFIGURATION, SchemaNames.SYSTEM_CONFIG_DB_CONTEXT);

        builder
            .Property(x => x.LogicBlockAttributeId)
            .HasColumnName(ColumnNames.LOGIC_BLOCK_ATTRIBUTE_ID)
            .IsRequired();

        builder
            .Property(x => x.CharacteristicConfigurationId)
            .HasColumnName(ColumnNames.CHARACTERISTIC_CONFIGURATION_ID)
            .IsRequired();

        builder
            .HasOne(x => x.LogicBlockAttribute)
            .WithMany(x => x.LogicBlockAttributeCharacteristicConfigurations)
            .HasForeignKey(x => x.LogicBlockAttributeId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasOne(x => x.CharacteristicConfiguration)
            .WithMany()
            .HasForeignKey(x => x.CharacteristicConfigurationId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
