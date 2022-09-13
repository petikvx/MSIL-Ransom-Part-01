using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Main;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
internal sealed class Settings1 : ApplicationSettingsBase
{
	private static Settings1 defaultInstance = (Settings1)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings1());

	public static Settings1 Default => defaultInstance;

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string pcid
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("pcid");
		}
		set
		{
			((SettingsBase)this).set_Item("pcid", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	public int sent
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("sent");
		}
		set
		{
			((SettingsBase)this).set_Item("sent", (object)value);
		}
	}
}
