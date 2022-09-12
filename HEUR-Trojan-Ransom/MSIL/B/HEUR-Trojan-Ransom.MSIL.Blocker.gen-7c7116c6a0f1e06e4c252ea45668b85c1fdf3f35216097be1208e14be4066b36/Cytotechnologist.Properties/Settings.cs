using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Cytotechnologist.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)Settings.smethod_0((SettingsBase)(object)new Settings());

	public static Settings Default => defaultInstance;

	static SettingsBase smethod_0(SettingsBase settingsBase_0)
	{
		return SettingsBase.Synchronized(settingsBase_0);
	}
}
