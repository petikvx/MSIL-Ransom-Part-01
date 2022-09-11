using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace VirusTest.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.7.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default => defaultInstance;

	[UserScopedSetting]
	[DefaultSettingValue("__invalid__")]
	[DebuggerNonUserCode]
	public string PW
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("PW");
		}
		set
		{
			((SettingsBase)this).set_Item("PW", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool AS
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("AS");
		}
		set
		{
			((SettingsBase)this).set_Item("AS", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("True")]
	[DebuggerNonUserCode]
	public bool ALLOWED
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("ALLOWED");
		}
		set
		{
			((SettingsBase)this).set_Item("ALLOWED", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	public int COUNT
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("COUNT");
		}
		set
		{
			((SettingsBase)this).set_Item("COUNT", (object)value);
		}
	}
}
