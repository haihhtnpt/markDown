using System;
using System.Collections.Generic;
using System.Text;
using BSG1.Localization;
using Volo.Abp.Application.Services;

namespace BSG1;

/* Inherit your application services from this class.
 */
public abstract class BSG1AppService : ApplicationService
{
    protected BSG1AppService()
    {
        LocalizationResource = typeof(BSG1Resource);
    }
}
