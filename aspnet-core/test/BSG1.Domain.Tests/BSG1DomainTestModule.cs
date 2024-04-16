using Volo.Abp.Modularity;

namespace BSG1;

[DependsOn(
    typeof(BSG1DomainModule),
    typeof(BSG1TestBaseModule)
)]
public class BSG1DomainTestModule : AbpModule
{

}
