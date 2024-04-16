using Volo.Abp.Modularity;

namespace BSG1;

/* Inherit from this class for your domain layer tests. */
public abstract class BSG1DomainTestBase<TStartupModule> : BSG1TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
