using ConsoleApp2.Model.CharacteristicAttributes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static ConsoleApp2.Constants;
using static ConsoleApp2.SystemConfigConstants;

namespace ConsoleApp2.Configuration;

public class CharacteristicAttributeNumericRangeConfig : IEntityTypeConfiguration<CharacteristicAttributeNumericRange>
{
    public void Configure(EntityTypeBuilder<CharacteristicAttributeNumericRange> builder)
    {
        builder.ToTable(SystemConfigTableNames.CHARACTERISTIC_ATTRIBUTE_NUMERIC_RANGE, SchemaNames.SYSTEM_CONFIG_DB_CONTEXT);

        builder
            .Property(x => x.Precision)
            .HasColumnName(ColumnNames.PRECISION)
            .IsRequired();

        builder
            .Property(x => x.Scale)
            .HasColumnName(ColumnNames.SCALE)
            .IsRequired();

        builder
            .HasOne<CharacteristicAttribute>()
            .WithOne()
            .HasForeignKey<CharacteristicAttributeNumericRange>(x => x.Id)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
