using BSG1.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BSG1.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BSG1Controller : AbpControllerBase
{
    protected BSG1Controller()
    {
        LocalizationResource = typeof(BSG1Resource);
    }
}
