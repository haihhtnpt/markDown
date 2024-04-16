using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace BSG1.Data;

/* This is used if database provider does't define
 * IBSG1DbSchemaMigrator implementation.
 */
public class NullBSG1DbSchemaMigrator : IBSG1DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
