using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ns2;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings settings_0 = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default => settings_0;

	[DefaultSettingValue("10")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public int Times
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("Times");
		}
		set
		{
			((SettingsBase)this).set_Item("Times", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1000")]
	public int Value
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("Value");
		}
		set
		{
			((SettingsBase)this).set_Item("Value", (object)value);
		}
	}
}
