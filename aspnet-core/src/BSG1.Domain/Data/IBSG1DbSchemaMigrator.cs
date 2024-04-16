using System.Threading.Tasks;

namespace BSG1.Data;

public interface IBSG1DbSchemaMigrator
{
    Task MigrateAsync();
}
