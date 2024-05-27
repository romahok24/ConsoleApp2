using ConsoleApp2.Model.LogicBlockAttributes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static ConsoleApp2.Constants;
using static ConsoleApp2.SystemConfigConstants;

namespace ConsoleApp2.Configuration;

public class LogicBlockAttributeConfig : IEntityTypeConfiguration<LogicBlockAttribute>
{
    public void Configure(EntityTypeBuilder<LogicBlockAttribute> builder)
    {
        builder.ToTable(SystemConfigTableNames.LOGIC_BLOCK_ATTRIBUTE, SchemaNames.SYSTEM_CONFIG_DB_CONTEXT);

        builder
            .Property(x => x.LogicBlockAttributeTypeId)
            .HasColumnName(ColumnNames.LOGIC_BLOCK_ATTRIBUTE_TYPE_ID)
            .IsRequired();

        builder
            .Property(x => x.LogicBlockConfigurationId)
            .HasColumnName(ColumnNames.LOGIC_BLOCK_CONFIGURATION_ID)
            .IsRequired();

        builder
            .HasOne(x => x.LogicBlockAttributeType)
            .WithMany(x => x.LogicBlockAttributes)
            .HasForeignKey(x => x.LogicBlockAttributeTypeId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasOne(x => x.LogicBlockConfiguration)
            .WithMany(x => x.LogicBlockAttributes)
            .HasForeignKey(x => x.LogicBlockConfigurationId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasMany(x => x.LogicBlockAttributeCharacteristicConfigurations)
            .WithOne(x => x.LogicBlockAttribute)
            .HasForeignKey(x => x.LogicBlockAttributeId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
