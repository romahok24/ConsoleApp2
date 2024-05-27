using ConsoleApp2.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static ConsoleApp2.Constants;
using static ConsoleApp2.SystemConfigConstants;

namespace ConsoleApp2.Configuration;

public class LogicBlockConfigurationConfig : IEntityTypeConfiguration<LogicBlockConfiguration>
{
    public void Configure(EntityTypeBuilder<LogicBlockConfiguration> builder)
    {
        builder.ToTable(SystemConfigTableNames.LOGIC_BLOCK_CONFIGURATION, SchemaNames.SYSTEM_CONFIG_DB_CONTEXT);

        builder
            .Property(x => x.ParentId)
            .HasColumnName(ColumnNames.PARENT_ID);

        builder
            .Property(x => x.LogicBlockId)
            .HasColumnName(ColumnNames.LOGIC_BLOCK_ID)
            .IsRequired();

        builder
            .Property(x => x.SystemObjectId)
            .HasColumnName(ColumnNames.SYSTEM_OBJECT_ID)
            .IsRequired();

        builder
            .HasOne(x => x.Parent)
            .WithMany(x => x.Childrens)
            .HasForeignKey(x => x.ParentId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(x => x.LogicBlock)
            .WithMany(x => x.LogicBlockConfigurations)
            .HasForeignKey(x => x.LogicBlockId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasOne(x => x.SystemObject)
            .WithMany(x => x.LogicBlockConfigurations)
            .HasForeignKey(x => x.SystemObjectId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasMany(x => x.LogicBlockAttributes)
            .WithOne(x => x.LogicBlockConfiguration)
            .HasForeignKey(x => x.LogicBlockConfigurationId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasMany(x => x.Childrens)
            .WithOne(x => x.Parent)
            .HasForeignKey(x => x.ParentId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasMany(x => x.LogicBlockConfigurationEvents)
            .WithOne(x => x.LogicBlockConfiguration)
            .HasForeignKey(x => x.LogicBlockConfigurationId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
