# CW_InputAPI

## Requirements:
- BepInEx LTS (5.4.22)

## For Developers:

Extend CWBaseInput to create new inputs. example: `Inputs/ExampleInput.cs`
```csharp
using InputAPI;
using UnityEngine;

namespace Example.Inputs
{
    internal class ExampleInput : BaseCWInput, IExposedSetting
    {
        public override KeyCode GetDefaultKey()
        {
            return KeyCode.BackQuote;
        }

        public string GetDisplayName()
        {
            return "FooBar";
        }

        public SettingCategory GetSettingCategory()
        {
            return SettingCategory.Controls;
        }

        protected override void OnHeld(Player player)
        {
            // Implementation goes here.
        }

        protected override void OnKeyDown(Player player)
        {
            // Implementation goes here.
        }

        protected override void OnKeyUp(Player player)
        {
            // Implementation goes here.
        }
    }
}
```

And to use it you can simply do this inside of your `Plugin.cs`!
```csharp
[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
[BepInDependency("com.visualerror.inputapi", BepInDependency.DependencyFlags.HardDependency)] // Be sure to have this!!
public class Plugin : BaseUnityPlugin
{
    internal ExampleInput Example = new ExampleInput();
}
```
