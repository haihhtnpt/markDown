using BSG1.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace BSG1.Permissions;

public class BSG1PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BSG1Permissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BSG1Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BSG1Resource>(name);
    }
}
