using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ns0;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")]
[CompilerGenerated]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings settings_0 = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default => settings_0;

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1000")]
	public int Setting
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("Setting");
		}
		set
		{
			((SettingsBase)this).set_Item("Setting", (object)value);
		}
	}
}
