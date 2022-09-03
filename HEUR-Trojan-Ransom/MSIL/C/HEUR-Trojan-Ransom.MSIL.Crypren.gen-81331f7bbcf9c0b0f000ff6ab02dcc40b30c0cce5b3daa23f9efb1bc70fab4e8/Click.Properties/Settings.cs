using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Click.Properties;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
[CompilerGenerated]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default => defaultInstance;

	[UserScopedSetting]
	[DefaultSettingValue("b14ca5898m5t4143abce2eb1214n1819")]
	[DebuggerNonUserCode]
	public string PRIVATE_KEY
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("PRIVATE_KEY");
		}
		set
		{
			((SettingsBase)this).set_Item("PRIVATE_KEY", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string start_date
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("start_date");
		}
		set
		{
			((SettingsBase)this).set_Item("start_date", (object)value);
		}
	}

	[DefaultSettingValue("1")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public int COUNTER
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("COUNTER");
		}
		set
		{
			((SettingsBase)this).set_Item("COUNTER", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string lost_date
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("lost_date");
		}
		set
		{
			((SettingsBase)this).set_Item("lost_date", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string due_date
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("due_date");
		}
		set
		{
			((SettingsBase)this).set_Item("due_date", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("False")]
	[DebuggerNonUserCode]
	public bool isDisabled
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("isDisabled");
		}
		set
		{
			((SettingsBase)this).set_Item("isDisabled", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("False")]
	[DebuggerNonUserCode]
	public bool onStartRun
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("onStartRun");
		}
		set
		{
			((SettingsBase)this).set_Item("onStartRun", (object)value);
		}
	}

	[DefaultSettingValue("A")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string secret
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("secret");
		}
		set
		{
			((SettingsBase)this).set_Item("secret", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("A")]
	[DebuggerNonUserCode]
	public string keysecret
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("keysecret");
		}
		set
		{
			((SettingsBase)this).set_Item("keysecret", (object)value);
		}
	}
}
