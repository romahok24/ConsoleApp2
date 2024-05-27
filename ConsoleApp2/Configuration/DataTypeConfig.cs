using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static ConsoleApp2.Constants;
using static ConsoleApp2.SystemConfigConstants;
using ConsoleApp2.Model;

namespace ConsoleApp2.Configuration;

public class DataTypeConfig : IEntityTypeConfiguration<DataType>
{
    public void Configure(EntityTypeBuilder<DataType> builder)
    {
        builder.ToTable(SystemConfigTableNames.DATA_TYPE, SchemaNames.SYSTEM_CONFIG_DB_CONTEXT);

        builder
            .Property(x => x.Name)
            .HasMaxLength(SystemConfigConstraints.NAME_MAX_LENGTH)
            .HasColumnName(ColumnNames.NAME)
            .IsRequired();

        builder
            .Property(x => x.Type)
            .HasColumnName(ColumnNames.TYPE)
            .IsRequired();

        builder
            .Property(x => x.InputType)
            .HasMaxLength(SystemConfigConstraints.INPUT_TYPE_MAX_LENGTH)
            .HasColumnName(ColumnNames.INPUT_TYPE)
            .IsRequired();

        builder
            .Property(x => x.Description)
            .HasMaxLength(SystemConfigConstraints.DESCRIPTION_MAX_LENGTH)
            .HasColumnName(ColumnNames.DESCRIPTION)
            .IsRequired();

        builder
            .Property(x => x.PosgresType)
            .HasMaxLength(SystemConfigConstraints.POSGRES_TYPE_MAX_LENGTH)
            .HasColumnName(ColumnNames.POSGRES_TYPE)
            .IsRequired();

        builder
            .HasMany(x => x.Characteristics)
            .WithOne(x => x.DataType)
            .HasForeignKey(x => x.DataTypeId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
