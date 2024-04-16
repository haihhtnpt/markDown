using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace BSG1;

[Dependency(ReplaceServices = true)]
public class BSG1BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BSG1";
}
