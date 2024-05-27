using ConsoleApp2.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static ConsoleApp2.Constants;
using static ConsoleApp2.SystemConfigConstants;

namespace ConsoleApp2.Configuration;

public class LogicBlockConfig : IEntityTypeConfiguration<LogicBlock>
{
    public void Configure(EntityTypeBuilder<LogicBlock> builder)
    {
        builder.ToTable(SystemConfigTableNames.LOGIC_BLOCK, SchemaNames.SYSTEM_CONFIG_DB_CONTEXT);

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
            .Property(x => x.TableName)
            .HasMaxLength(SystemConfigConstraints.TABLE_NAME_MAX_LENGTH)
            .HasColumnName(ColumnNames.TABLE);

        builder
            .HasMany(x => x.LogicBlockConfigurations)
            .WithOne(x => x.LogicBlock)
            .HasForeignKey(x => x.LogicBlockId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
