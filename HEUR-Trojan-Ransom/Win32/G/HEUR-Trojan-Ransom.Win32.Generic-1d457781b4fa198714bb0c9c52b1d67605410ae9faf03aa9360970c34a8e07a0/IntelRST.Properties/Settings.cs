using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace IntelRST.Properties;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
[CompilerGenerated]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default => defaultInstance;

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string DriveStorage
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("DriveStorage");
		}
		set
		{
			((SettingsBase)this).set_Item("DriveStorage", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string zStorage
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("zStorage");
		}
		set
		{
			((SettingsBase)this).set_Item("zStorage", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string Scout
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("Scout");
		}
		set
		{
			((SettingsBase)this).set_Item("Scout", (object)value);
		}
	}
}
