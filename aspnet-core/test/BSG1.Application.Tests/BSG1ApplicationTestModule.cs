using Volo.Abp.Modularity;

namespace BSG1;

[DependsOn(
    typeof(BSG1ApplicationModule),
    typeof(BSG1DomainTestModule)
)]
public class BSG1ApplicationTestModule : AbpModule
{

}
