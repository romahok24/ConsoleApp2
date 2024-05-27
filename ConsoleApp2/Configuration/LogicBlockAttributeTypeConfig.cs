using ConsoleApp2.Model.LogicBlockAttributes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static ConsoleApp2.Constants;
using static ConsoleApp2.SystemConfigConstants;

namespace ConsoleApp2.Configuration;

public class LogicBlockAttributeTypeConfig : IEntityTypeConfiguration<LogicBlockAttributeType>
{
    public void Configure(EntityTypeBuilder<LogicBlockAttributeType> builder)
    {
        builder.ToTable(SystemConfigTableNames.LOGIC_BLOCK_ATTRIBUTE_TYPE, SchemaNames.SYSTEM_CONFIG_DB_CONTEXT);

        builder
            .Property(x => x.Name)
            .HasMaxLength(SystemConfigConstraints.NAME_MAX_LENGTH)
            .HasColumnName(ColumnNames.NAME)
            .IsRequired();

        builder
            .Property(x => x.Description)
            .HasMaxLength(SystemConfigConstraints.DESCRIPTION_MAX_LENGTH)
            .HasColumnName(ColumnNames.DESCRIPTION)
            .IsRequired();

        builder
            .Property(x => x.Type)
            .HasColumnName(ColumnNames.TYPE)
            .IsRequired();

        builder
            .HasMany(x => x.LogicBlockAttributes)
            .WithOne(x => x.LogicBlockAttributeType)
            .HasForeignKey(x => x.LogicBlockAttributeTypeId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
