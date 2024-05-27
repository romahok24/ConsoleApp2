using ConsoleApp2.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static ConsoleApp2.Constants;
using static ConsoleApp2.SystemConfigConstants;

namespace ConsoleApp2.Configuration;

public class CharacteristicConfigurationConfig : IEntityTypeConfiguration<CharacteristicConfiguration>
{
    public void Configure(EntityTypeBuilder<CharacteristicConfiguration> builder)
    {
        builder.ToTable(SystemConfigTableNames.CHARACTERISTIC_CONFIGURATION, SchemaNames.SYSTEM_CONFIG_DB_CONTEXT);

        builder
            .Property(x => x.LogicBlockConfigurationId)
            .HasColumnName(ColumnNames.LOGIC_BLOCK_CONFIGURATION_ID)
            .IsRequired();

        builder
            .Property(x => x.CharacteristicId)
            .HasColumnName(ColumnNames.CHARACTERISTIC_ID)
            .IsRequired();

        builder
            .Property(x => x.Order)
            .HasColumnName(ColumnNames.ORDER)
            .IsRequired();

        builder
            .HasOne(x => x.Characteristic)
            .WithMany(x => x.CharacteristicConfigurations)
            .HasForeignKey(x => x.CharacteristicId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasOne(x => x.LogicBlockConfiguration)
            .WithMany(x => x.CharacteristicConfigurations)
            .HasForeignKey(x => x.LogicBlockConfigurationId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasMany(x => x.CharacteristicAttributes)
            .WithOne(x => x.CharacteristicConfiguration)
            .HasForeignKey(x => x.CharacteristicConfigurationId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
