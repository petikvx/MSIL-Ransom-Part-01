using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MetroLoader.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.3.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default => defaultInstance;

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string Username
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("Username");
		}
		set
		{
			((SettingsBase)this).set_Item("Username", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string Password
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("Password");
		}
		set
		{
			((SettingsBase)this).set_Item("Password", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	[UserScopedSetting]
	public bool Checked
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("Checked");
		}
		set
		{
			((SettingsBase)this).set_Item("Checked", (object)value);
		}
	}
}
