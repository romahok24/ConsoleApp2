﻿using ConsoleApp2.Model.CharacteristicAttributes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static ConsoleApp2.Constants;
using static ConsoleApp2.SystemConfigConstants;

namespace ConsoleApp2.Configuration;

public class CharacteristicAttributeStringConfig : IEntityTypeConfiguration<CharacteristicAttributeString>
{
    public void Configure(EntityTypeBuilder<CharacteristicAttributeString> builder)
    {
        builder.ToTable(SystemConfigTableNames.CHARACTERISTIC_ATTRIBUTE_INT, SchemaNames.SYSTEM_CONFIG_DB_CONTEXT);

        builder
            .Property(x => x.Value)
            .HasColumnName(ColumnNames.VALUE)
            .IsRequired();

        builder
            .HasOne<CharacteristicAttribute>()
            .WithOne()
            .HasForeignKey<CharacteristicAttributeString>(x => x.Id)
            .OnDelete(DeleteBehavior.Cascade);
    }
}