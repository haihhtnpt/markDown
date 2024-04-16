using Volo.Abp.Settings;

namespace BSG1.Settings;

public class BSG1SettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BSG1Settings.MySetting1));
    }
}
