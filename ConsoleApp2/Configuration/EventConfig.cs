using ConsoleApp2.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static ConsoleApp2.Constants;
using static ConsoleApp2.SystemConfigConstants;

namespace ConsoleApp2.Configuration;

public class EventConfig : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        builder.ToTable(SystemConfigTableNames.EVENT, SchemaNames.SYSTEM_CONFIG_DB_CONTEXT);

        builder
            .HasIndex(x => x.Name)
            .IsUnique();

        builder
            .Property(x => x.Name)
            .HasMaxLength(SystemConfigConstraints.NAME_MAX_LENGTH)
            .HasColumnName(ColumnNames.NAME);

        builder
            .Property(x => x.Type)
            .HasColumnName(ColumnNames.TYPE);

        builder
            .HasMany(x => x.LogicBlockConfigurationEvents)
            .WithOne(x => x.Event)
            .HasForeignKey(x => x.EventId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
