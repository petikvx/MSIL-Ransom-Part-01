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

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("False")]
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

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
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

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("False")]
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
	[UserScopedSetting]
	[DebuggerNonUserCode]
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
}
