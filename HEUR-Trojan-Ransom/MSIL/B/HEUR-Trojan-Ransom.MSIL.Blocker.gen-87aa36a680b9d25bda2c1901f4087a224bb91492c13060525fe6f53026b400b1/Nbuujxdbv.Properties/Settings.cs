using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Nbuujxdbv.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	private static Settings InstantiateContext;

	public static Settings Default => defaultInstance;

	internal static bool RemoveContext()
	{
		return InstantiateContext == null;
	}

	internal static Settings SearchContext()
	{
		return InstantiateContext;
	}
}
