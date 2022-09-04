using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace YoshistrCrypto.Properties;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
[CompilerGenerated]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default => defaultInstance;

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("")]
	public string pass
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("pass");
		}
		set
		{
			((SettingsBase)this).set_Item("pass", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("C:\\Documents and Settings\\Administrator\\桌面\\server.exe")]
	public string LoadR
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("LoadR");
		}
		set
		{
			((SettingsBase)this).set_Item("LoadR", (object)value);
		}
	}
}
