using Volo.Abp.Settings;

namespace Playground.Settings
{
    public class PlaygroundSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(PlaygroundSettings.MySetting1));
        }
    }
}
