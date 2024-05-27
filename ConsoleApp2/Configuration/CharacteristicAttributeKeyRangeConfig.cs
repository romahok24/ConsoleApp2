using ConsoleApp2.Model.CharacteristicAttributes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static ConsoleApp2.Constants;
using static ConsoleApp2.SystemConfigConstants;

namespace ConsoleApp2.Configuration;

public class CharacteristicAttributeKeyRangeConfig : IEntityTypeConfiguration<CharacteristicAttributeKeyRange>
{
    public void Configure(EntityTypeBuilder<CharacteristicAttributeKeyRange> builder)
    {
        builder.ToTable(SystemConfigTableNames.CHARACTERISTIC_ATTRIBUTE_KEY_RANGE, SchemaNames.SYSTEM_CONFIG_DB_CONTEXT);

        builder
            .Property(x => x.From)
            .HasColumnName(ColumnNames.FROM)
            .IsRequired();

        builder
            .Property(x => x.To)
            .HasColumnName(ColumnNames.TO)
            .IsRequired();

        builder
            .HasOne<CharacteristicAttribute>()
            .WithOne()
            .HasForeignKey<CharacteristicAttributeKeyRange>(x => x.Id)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
