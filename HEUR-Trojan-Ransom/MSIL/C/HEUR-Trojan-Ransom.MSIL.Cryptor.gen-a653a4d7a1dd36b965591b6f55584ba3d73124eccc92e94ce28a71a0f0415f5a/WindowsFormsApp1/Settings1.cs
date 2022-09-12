using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
[CompilerGenerated]
internal sealed class Settings1 : ApplicationSettingsBase
{
	private static Settings1 defaultInstance = (Settings1)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings1());

	public static Settings1 Default => defaultInstance;

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string EncryptionPassword
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("EncryptionPassword");
		}
		set
		{
			((SettingsBase)this).set_Item("EncryptionPassword", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string pcID
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("pcID");
		}
		set
		{
			((SettingsBase)this).set_Item("pcID", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string Setting
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("Setting");
		}
		set
		{
			((SettingsBase)this).set_Item("Setting", (object)value);
		}
	}
}
