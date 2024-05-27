using ConsoleApp2.Model.CharacteristicAttributes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static ConsoleApp2.Constants;
using static ConsoleApp2.SystemConfigConstants;

namespace ConsoleApp2.Configuration;

public class CharacteristicAttributeConfig : IEntityTypeConfiguration<CharacteristicAttribute>
{
    public void Configure(EntityTypeBuilder<CharacteristicAttribute> builder)
    {
        builder.ToTable(SystemConfigTableNames.CHARACTERISTIC_ATTRIBUTE, SchemaNames.SYSTEM_CONFIG_DB_CONTEXT);

        builder
            .Property(x => x.CharacteristicConfigurationId)
            .HasColumnName(ColumnNames.CHARACTERISTIC_CONFIGURATION_ID)
            .IsRequired();

        builder
            .Property(x => x.CharacteristicAttributeTypeId)
            .HasColumnName(ColumnNames.CHARACTERISTIC_ATTRIBUTE_TYPE_ID)
            .IsRequired();

        builder
            .HasOne(x => x.CharacteristicConfiguration)
            .WithMany(x => x.CharacteristicAttributes)
            .HasForeignKey(x => x.CharacteristicConfigurationId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasOne(x => x.CharacteristicAttributeType)
            .WithMany(x => x.Attributes)
            .HasForeignKey(x => x.CharacteristicAttributeTypeId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}