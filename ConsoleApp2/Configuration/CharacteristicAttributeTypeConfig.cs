using ConsoleApp2.Model.CharacteristicAttributes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static ConsoleApp2.Constants;
using static ConsoleApp2.SystemConfigConstants;

namespace ConsoleApp2.Configuration;

public class CharacteristicAttributeTypeConfig : IEntityTypeConfiguration<CharacteristicAttributeType>
{
    public void Configure(EntityTypeBuilder<CharacteristicAttributeType> builder)
    {
        builder.ToTable(SystemConfigTableNames.CHARACTERISTIC_ATTRIBUTE_TYPE, SchemaNames.SYSTEM_CONFIG_DB_CONTEXT);

        builder
            .Property(x => x.Name)
            .HasMaxLength(SystemConfigConstraints.NAME_MAX_LENGTH)
            .HasColumnName(ColumnNames.NAME)
            .IsRequired();

        builder
            .Property(x => x.Description)
            .HasMaxLength(SystemConfigConstraints.DESCRIPTION_MAX_LENGTH)
            .HasColumnName(ColumnNames.DESCRIPTION)
            .IsRequired();

        builder
            .Property(x => x.Type)
            .HasColumnName(ColumnNames.TYPE)
            .IsRequired();

        builder
            .HasMany(x => x.Attributes)
            .WithOne(x => x.CharacteristicAttributeType)
            .HasForeignKey(x => x.CharacteristicAttributeTypeId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
