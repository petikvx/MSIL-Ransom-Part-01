using System.CodeDom.Compiler;
using System.Configuration;

namespace KamelAmenThaabet.Properties;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings settings_0 = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default => settings_0;

	[UserScopedSetting]
	[DefaultSettingValue("we")]
	public string Setting1
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("Setting1");
		}
		set
		{
			((SettingsBase)this).set_Item("Setting1", (object)value);
		}
	}
}
