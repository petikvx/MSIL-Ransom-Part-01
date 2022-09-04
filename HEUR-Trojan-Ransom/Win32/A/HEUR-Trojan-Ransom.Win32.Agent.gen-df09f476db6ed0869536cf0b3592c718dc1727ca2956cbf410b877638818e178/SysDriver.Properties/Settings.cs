using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace SysDriver.Properties;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
[CompilerGenerated]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance;

	public static Settings Default => defaultInstance;

	public Settings()
	{
		Class51.smethod_0();
		((ApplicationSettingsBase)this)._002Ector();
	}

	static Settings()
	{
		Class51.smethod_0();
		defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());
	}
}
