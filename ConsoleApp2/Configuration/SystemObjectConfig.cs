using ConsoleApp2.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static ConsoleApp2.SystemConfigConstants;
using static ConsoleApp2.Constants;

namespace ConsoleApp2.Configuration;

public class SystemObjectConfig : IEntityTypeConfiguration<SystemObject>
{
    public void Configure(EntityTypeBuilder<SystemObject> builder)
    {
        builder.ToTable(SystemConfigTableNames.SYSTEM_OBJECT, SchemaNames.SYSTEM_CONFIG_DB_CONTEXT);

        builder
            .HasIndex(x => x.Code)
            .IsUnique();

        builder
            .Property(x => x.Code)
            .HasMaxLength(SystemConfigConstraints.CODE_MAX_LENGTH)
            .HasColumnName(ColumnNames.CODE);

        builder
            .Property(x => x.Name)
            .HasMaxLength(SystemConfigConstraints.NAME_MAX_LENGTH)
            .HasColumnName(ColumnNames.NAME);

        builder
            .HasMany(x => x.LogicBlockConfigurations)
            .WithOne(x => x.SystemObject)
            .HasForeignKey(x => x.SystemObjectId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
