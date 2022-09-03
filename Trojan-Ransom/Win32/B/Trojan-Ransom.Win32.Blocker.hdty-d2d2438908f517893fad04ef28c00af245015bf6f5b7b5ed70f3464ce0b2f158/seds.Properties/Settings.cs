using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;
using ___codefort;

namespace seds.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance;

	public static Settings Default => defaultInstance;

	static Settings()
	{
		Class3.smethod_0();
		defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());
	}
}
