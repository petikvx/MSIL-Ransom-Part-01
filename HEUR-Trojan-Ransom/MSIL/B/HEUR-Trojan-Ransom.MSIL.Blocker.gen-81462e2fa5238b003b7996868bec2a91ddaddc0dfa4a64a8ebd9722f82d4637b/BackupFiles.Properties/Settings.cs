using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace BackupFiles.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings settings_0 = (Settings)(object)Settings.smethod_0((SettingsBase)(object)new Settings());

	public static Settings Default => settings_0;

	static SettingsBase smethod_0(SettingsBase settingsBase_0)
	{
		return SettingsBase.Synchronized(settingsBase_0);
	}
}
