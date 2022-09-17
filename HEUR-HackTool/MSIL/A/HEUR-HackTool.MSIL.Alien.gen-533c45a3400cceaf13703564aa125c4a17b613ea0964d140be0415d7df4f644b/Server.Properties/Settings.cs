using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Server.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default => defaultInstance;

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string Ports
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("Ports");
		}
		set
		{
			((SettingsBase)this).set_Item("Ports", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string Filename
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("Filename");
		}
		set
		{
			((SettingsBase)this).set_Item("Filename", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("True")]
	public bool Notification
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("Notification");
		}
		set
		{
			((SettingsBase)this).set_Item("Notification", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string Paste_bin
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("Paste_bin");
		}
		set
		{
			((SettingsBase)this).set_Item("Paste_bin", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string IP
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("IP");
		}
		set
		{
			((SettingsBase)this).set_Item("IP", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("")]
	public string ProductName
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("ProductName");
		}
		set
		{
			((SettingsBase)this).set_Item("ProductName", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string txtDescription
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("txtDescription");
		}
		set
		{
			((SettingsBase)this).set_Item("txtDescription", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("")]
	public string txtCompany
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("txtCompany");
		}
		set
		{
			((SettingsBase)this).set_Item("txtCompany", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string txtCopyright
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("txtCopyright");
		}
		set
		{
			((SettingsBase)this).set_Item("txtCopyright", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string txtTrademarks
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("txtTrademarks");
		}
		set
		{
			((SettingsBase)this).set_Item("txtTrademarks", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string txtOriginalFilename
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("txtOriginalFilename");
		}
		set
		{
			((SettingsBase)this).set_Item("txtOriginalFilename", (object)value);
		}
	}

	[DefaultSettingValue("0.0.0.0")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string txtProductVersion
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("txtProductVersion");
		}
		set
		{
			((SettingsBase)this).set_Item("txtProductVersion", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.0.0.0")]
	public string txtFileVersion
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("txtFileVersion");
		}
		set
		{
			((SettingsBase)this).set_Item("txtFileVersion", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string txtBlocked
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("txtBlocked");
		}
		set
		{
			((SettingsBase)this).set_Item("txtBlocked", (object)value);
		}
	}

	[DefaultSettingValue("Default")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string Group
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("Group");
		}
		set
		{
			((SettingsBase)this).set_Item("Group", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("DcRatMutex_qwqdanchun")]
	public string Mutex
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("Mutex");
		}
		set
		{
			((SettingsBase)this).set_Item("Mutex", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	[UserScopedSetting]
	public bool DingDing
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("DingDing");
		}
		set
		{
			((SettingsBase)this).set_Item("DingDing", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string WebHook
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("WebHook");
		}
		set
		{
			((SettingsBase)this).set_Item("WebHook", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string Secret
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("Secret");
		}
		set
		{
			((SettingsBase)this).set_Item("Secret", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("3128")]
	[DebuggerNonUserCode]
	public decimal ReverseProxyPort
	{
		get
		{
			return (decimal)((SettingsBase)this).get_Item("ReverseProxyPort");
		}
		set
		{
			((SettingsBase)this).set_Item("ReverseProxyPort", (object)value);
		}
	}
}
