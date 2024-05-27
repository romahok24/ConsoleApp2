using ConsoleApp2.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static ConsoleApp2.Constants;
using static ConsoleApp2.SystemConfigConstants;

namespace ConsoleApp2.Configuration;

public class CharacteristicConfig : IEntityTypeConfiguration<Characteristic>
{
    public void Configure(EntityTypeBuilder<Characteristic> builder)
    {
        builder.ToTable(SystemConfigTableNames.CHARACTERISTIC, SchemaNames.SYSTEM_CONFIG_DB_CONTEXT);

        builder
            .Property(x => x.Name)
            .HasMaxLength(SystemConfigConstraints.NAME_MAX_LENGTH)
            .HasColumnName(ColumnNames.NAME)
            .IsRequired();

        builder
            .Property(x => x.DataTypeId)
            .HasColumnName(ColumnNames.DATA_TYPE_ID)
            .IsRequired();

        builder
            .Property(x => x.Description)
            .HasMaxLength(SystemConfigConstraints.DESCRIPTION_MAX_LENGTH)
            .HasColumnName(ColumnNames.DESCRIPTION)
            .IsRequired();

        builder
            .HasOne(x => x.DataType)
            .WithMany(x => x.Characteristics)
            .HasForeignKey(x => x.DataTypeId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasMany(x => x.CharacteristicConfigurations)
            .WithOne(x => x.Characteristic)
            .HasForeignKey(x => x.CharacteristicId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
