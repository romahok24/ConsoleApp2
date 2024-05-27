using ConsoleApp2.Model;
using ConsoleApp2.Model.CharacteristicAttributes;
using ConsoleApp2.Model.LogicBlockAttributes;
using Microsoft.EntityFrameworkCore;
using static ConsoleApp2.Constants;

namespace ConsoleApp2;

public class SystemConfigDbContext(DbContextOptions<SystemConfigDbContext> options)
    : DbContext(options)//, ISystemConfigDbContext, IObjectAccessDbContext
{
    // Конфигурация объектов
    public DbSet<Characteristic> Characteristics => Set<Characteristic>();
    public DbSet<CharacteristicConfiguration> CharacteristicConfigurations => Set<CharacteristicConfiguration>();
    public DbSet<DataType> DataTypes => Set<DataType>();
    public DbSet<Event> Events => Set<Event>();
    public DbSet<LogicBlock> LogicBlocks => Set<LogicBlock>();
    public DbSet<LogicBlockConfiguration> LogicBlockConfigurations => Set<LogicBlockConfiguration>();
    public DbSet<LogicBlockConfigurationEvent> LogicBlockConfigurationEvents => Set<LogicBlockConfigurationEvent>();
    public DbSet<SystemObject> SystemObjects => Set<SystemObject>();

    // Атрибуты характеристик
    public DbSet<CharacteristicAttribute> CharacteristicAttributes => Set<CharacteristicAttribute>();
    public DbSet<CharacteristicAttributeBoolean> CharacteristicAttributeBooleans => Set<CharacteristicAttributeBoolean>();
    public DbSet<CharacteristicAttributeInt> CharacteristicAttributeInts => Set<CharacteristicAttributeInt>();
    public DbSet<CharacteristicAttributeKeyRange> CharacteristicAttributeKeyRanges => Set<CharacteristicAttributeKeyRange>();
    public DbSet<CharacteristicAttributeNumericRange> CharacteristicAttributeNumericRanges => Set<CharacteristicAttributeNumericRange>();
    public DbSet<CharacteristicAttributeString> CharacteristicAttributeStrings => Set<CharacteristicAttributeString>();
    public DbSet<CharacteristicAttributeType> CharacteristicAttributeTypes => Set<CharacteristicAttributeType>();

    // Логические блоки атрибутов
    public DbSet<LogicBlockAttribute> LogicBlockAttributes => Set<LogicBlockAttribute>();
    public DbSet<BooleanLogicBlockAttribute> BooleanLogicBlockAttributes => Set<BooleanLogicBlockAttribute>();
    public DbSet<CustomLogicBlockAttribute> CustomLogicBlockAttributes => Set<CustomLogicBlockAttribute>();
    public DbSet<DateRangeLogicBlockAttribute> DateRangeLogicBlockAttributes => Set<DateRangeLogicBlockAttribute>();
    public DbSet<IfTrueThenEmptyLogicBlockAttribute> IfTrueThenEmptyLogicBlockAttributes => Set<IfTrueThenEmptyLogicBlockAttribute>();
    public DbSet<LogicBlockAttributeCharacteristicConfiguration> LogicBlockAttributeCharacteristicConfigurations => Set<LogicBlockAttributeCharacteristicConfiguration>();
    public DbSet<LogicBlockAttributeType> LogicBlockAttributeTypes => Set<LogicBlockAttributeType>();
    public DbSet<StringLogicBlockAttribute> StringLogicBlockAttributes => Set<StringLogicBlockAttribute>();
    public DbSet<TimeRangeLogicBlockAttribute> TimeRangeLogicBlockAttributes => Set<TimeRangeLogicBlockAttribute>();


    // Управление доступ к объектам
    //public DbSet<AccessType> AccessTypes => Set<AccessType>();
    //public DbSet<GroupRole> GroupRoles => Set<GroupRole>();
    //public DbSet<ObjectConfigurationType> ObjectConfigurationsTypes => Set<ObjectConfigurationType>();
    //public DbSet<Role> Roles => Set<Role>();
    //public DbSet<UserRole> UserRoles => Set<UserRole>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurations<SystemConfigDbContext>();

        modelBuilder.HasDefaultSchema(SchemaNames.SYSTEM_CONFIG_DB_CONTEXT);

        base.OnModelCreating(modelBuilder);
    }
}
