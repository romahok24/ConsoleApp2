using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2;

public static class ModelBuilderExtensions
{
    public static ModelBuilder ApplyConfigurations<TDbContext>(this ModelBuilder modelBuilder)
        where TDbContext : DbContext
    {
        var contextType = typeof(TDbContext);
        var entityConfigType = typeof(IEntityTypeConfiguration<>);

        var dbSetTypes = contextType
            .GetProperties()
            .Where(p =>
                p.PropertyType.IsGenericType &&
                p.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>))
            .Select(p => p.PropertyType.GenericTypeArguments[0])
            .ToList();

        modelBuilder.ApplyConfigurationsFromAssembly(
            //DependencyInjection.PersistenceAssembly,
            default,
            type => type
                .GetInterfaces()
                .Any(i =>
                    i.IsGenericType &&
                    i.GetGenericTypeDefinition() == entityConfigType &&
                    dbSetTypes.Contains(i.GenericTypeArguments[0])));

        return modelBuilder;
    }
}
