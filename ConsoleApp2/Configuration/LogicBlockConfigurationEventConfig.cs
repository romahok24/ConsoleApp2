using ConsoleApp2.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static ConsoleApp2.Constants;
using static ConsoleApp2.SystemConfigConstants;

namespace ConsoleApp2.Configuration;

public class LogicBlockConfigurationEventConfig : IEntityTypeConfiguration<LogicBlockConfigurationEvent>
{
    public void Configure(EntityTypeBuilder<LogicBlockConfigurationEvent> builder)
    {
        builder.ToTable(SystemConfigTableNames.LOGIC_BLOCK_CONFIGURATION_EVENT, SchemaNames.SYSTEM_CONFIG_DB_CONTEXT);

        builder
            .Property(x => x.Order)
            .HasColumnName(ColumnNames.ORDER)
            .IsRequired();

        builder
            .Property(x => x.EventId)
            .HasColumnName(ColumnNames.EVENT_ID)
            .IsRequired();

        builder
            .Property(x => x.LogicBlockConfigurationId)
            .HasColumnName(ColumnNames.LOGIC_BLOCK_CONFIGURATION_ID)
            .IsRequired();

        builder
            .HasOne(x => x.Event)
            .WithMany(x => x.LogicBlockConfigurationEvents)
            .HasForeignKey(x => x.EventId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasOne(x => x.LogicBlockConfiguration)
            .WithMany(x => x.LogicBlockConfigurationEvents)
            .HasForeignKey(x => x.LogicBlockConfigurationId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
