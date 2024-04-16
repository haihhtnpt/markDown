using Volo.Abp.Modularity;

namespace BSG1;

public abstract class BSG1ApplicationTestBase<TStartupModule> : BSG1TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
