using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace lfwb_hrm.Properties;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.4.0.0")]
[CompilerGenerated]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default => defaultInstance;

	[UserScopedSetting]
	[DefaultSettingValue("46.188.0.249")]
	[DebuggerNonUserCode]
	public string ip
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("ip");
		}
		set
		{
			((SettingsBase)this).set_Item("ip", (object)value);
		}
	}

	[DefaultSettingValue("1984")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public int port
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("port");
		}
		set
		{
			((SettingsBase)this).set_Item("port", (object)value);
		}
	}

	[DefaultSettingValue("False")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public bool notifications
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("notifications");
		}
		set
		{
			((SettingsBase)this).set_Item("notifications", (object)value);
		}
	}

	[DefaultSettingValue("True")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public bool sound
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("sound");
		}
		set
		{
			((SettingsBase)this).set_Item("sound", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("False")]
	[DebuggerNonUserCode]
	public bool autorun
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("autorun");
		}
		set
		{
			((SettingsBase)this).set_Item("autorun", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("True")]
	public bool firstrun
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("firstrun");
		}
		set
		{
			((SettingsBase)this).set_Item("firstrun", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("5")]
	public int ServerId
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("ServerId");
		}
		set
		{
			((SettingsBase)this).set_Item("ServerId", (object)value);
		}
	}
}
