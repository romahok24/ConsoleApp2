using ConsoleApp2.Model.LogicBlockAttributes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static ConsoleApp2.Constants;
using static ConsoleApp2.SystemConfigConstants;

namespace ConsoleApp2.Configuration;

public class DateRangeLogicBlockAttributeConfig : IEntityTypeConfiguration<DateRangeLogicBlockAttribute>
{
    public void Configure(EntityTypeBuilder<DateRangeLogicBlockAttribute> builder)
    {
        builder.ToTable(SystemConfigTableNames.DATE_RANGE_LOGIC_BLOCK_ATTRIBUTE, SchemaNames.SYSTEM_CONFIG_DB_CONTEXT);

        builder
            .Property(x => x.StartDateCharacteristicId)
            .HasColumnName(ColumnNames.START_DATE_CHARACTERISTIC_ID)
            .IsRequired();

        builder
            .Property(x => x.EndDateCharacteristicId)
            .HasColumnName(ColumnNames.END_DATE_CHARACTERISTIC_ID)
            .IsRequired();

        builder
            .HasOne(x => x.StartDateCharacteristic)
            .WithMany()
            .HasForeignKey(x => x.StartDateCharacteristicId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(x => x.EndDateCharacteristic)
            .WithMany()
            .HasForeignKey(x => x.EndDateCharacteristicId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne<LogicBlockAttribute>()
            .WithOne()
            .HasForeignKey<DateRangeLogicBlockAttribute>(x => x.Id)
            .OnDelete(DeleteBehavior.Cascade);
    }
}