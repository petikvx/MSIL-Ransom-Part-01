using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Explorer.Properties;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
[CompilerGenerated]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default => defaultInstance;

	[DefaultSettingValue("non")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string messageok
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("messageok");
		}
		set
		{
			((SettingsBase)this).set_Item("messageok", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("non")]
	[DebuggerNonUserCode]
	public string imageadd
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("imageadd");
		}
		set
		{
			((SettingsBase)this).set_Item("imageadd", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("non")]
	public string messageuser
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("messageuser");
		}
		set
		{
			((SettingsBase)this).set_Item("messageuser", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("non")]
	public string imageuser
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("imageuser");
		}
		set
		{
			((SettingsBase)this).set_Item("imageuser", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("non")]
	[UserScopedSetting]
	public string runuser
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("runuser");
		}
		set
		{
			((SettingsBase)this).set_Item("runuser", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("null")]
	public string accessimage
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("accessimage");
		}
		set
		{
			((SettingsBase)this).set_Item("accessimage", (object)value);
		}
	}

	private void SettingChangingEventHandler(object sender, SettingChangingEventArgs e)
	{
	}

	private void SettingsSavingEventHandler(object sender, CancelEventArgs e)
	{
	}
}
