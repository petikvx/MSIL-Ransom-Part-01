using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace DomainUtility.Properties;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
[CompilerGenerated]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default => defaultInstance;

	[DefaultSettingValue("14")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public int Hour
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("Hour");
		}
		set
		{
			((SettingsBase)this).set_Item("Hour", (object)value);
		}
	}

	[DefaultSettingValue("59")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public int Min
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("Min");
		}
		set
		{
			((SettingsBase)this).set_Item("Min", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("59")]
	[DebuggerNonUserCode]
	public int Sec
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("Sec");
		}
		set
		{
			((SettingsBase)this).set_Item("Sec", (object)value);
		}
	}
}
