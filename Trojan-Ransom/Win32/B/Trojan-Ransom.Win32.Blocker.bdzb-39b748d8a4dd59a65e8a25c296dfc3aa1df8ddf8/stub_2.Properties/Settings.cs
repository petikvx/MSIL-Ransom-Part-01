using System.CodeDom.Compiler;
using System.Configuration;
using ns0;

namespace stub_2.Properties;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings settings_0 = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default
	{
		get
		{
			Settings result = settings_0;
			GClass3.smethod_3();
			return result;
		}
	}

	public Settings()
	{
		Class5.smethod_11();
	}
}
