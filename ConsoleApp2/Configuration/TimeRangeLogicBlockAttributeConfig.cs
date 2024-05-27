using ConsoleApp2.Model.LogicBlockAttributes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static ConsoleApp2.Constants;
using static ConsoleApp2.SystemConfigConstants;

namespace ConsoleApp2.Configuration;

public class TimeRangeLogicBlockAttributeConfig : IEntityTypeConfiguration<TimeRangeLogicBlockAttribute>
{
    public void Configure(EntityTypeBuilder<TimeRangeLogicBlockAttribute> builder)
    {
        builder.ToTable(SystemConfigTableNames.TIME_RANGE_LOGIC_BLOCK_ATTRIBUTE, SchemaNames.SYSTEM_CONFIG_DB_CONTEXT);

        builder
            .Property(x => x.StartTimeCharacteristicId)
            .HasColumnName(ColumnNames.START_TIME_CHARACTERISTIC_ID)
            .IsRequired();

        builder
            .Property(x => x.EndTimeCharacteristicId)
            .HasColumnName(ColumnNames.END_TIME_CHARACTERISTIC_ID)
            .IsRequired();

        builder
            .HasOne(x => x.StartTimeCharacteristic)
            .WithMany()
            .HasForeignKey(x => x.StartTimeCharacteristicId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(x => x.EndTimeCharacteristic)
            .WithMany()
            .HasForeignKey(x => x.EndTimeCharacteristicId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne<LogicBlockAttribute>()
            .WithOne()
            .HasForeignKey<TimeRangeLogicBlockAttribute>(x => x.Id)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
