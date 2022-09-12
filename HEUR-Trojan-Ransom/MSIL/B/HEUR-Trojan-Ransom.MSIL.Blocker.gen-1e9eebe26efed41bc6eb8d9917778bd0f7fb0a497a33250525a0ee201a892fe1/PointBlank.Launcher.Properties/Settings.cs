using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace PointBlank.Launcher.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.6.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings _G60C6pCbyRvWbWFI9Z3cTzob9Tw = (Settings)(object)Settings.smethod_2((SettingsBase)(object)new Settings());

	public static Settings Default => _G60C6pCbyRvWbWFI9Z3cTzob9Tw;

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string Username
	{
		get
		{
			return (string)Settings.smethod_0((SettingsBase)(object)this, _003CModule_003E.smethod_4<string>(3905820627u));
		}
		set
		{
			Settings.smethod_1((SettingsBase)(object)this, _003CModule_003E.smethod_2<string>(1056362451u), (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	[UserScopedSetting]
	public bool remember
	{
		get
		{
			return (bool)Settings.smethod_0((SettingsBase)(object)this, _003CModule_003E.smethod_2<string>(2482092736u));
		}
		set
		{
			Settings.smethod_1((SettingsBase)(object)this, _003CModule_003E.smethod_3<string>(1109674926u), (object)value);
		}
	}

	static object smethod_0(SettingsBase settingsBase_0, string string_0)
	{
		return settingsBase_0.get_Item(string_0);
	}

	static void smethod_1(SettingsBase settingsBase_0, string string_0, object object_0)
	{
		settingsBase_0.set_Item(string_0, object_0);
	}

	static SettingsBase smethod_2(SettingsBase settingsBase_0)
	{
		return SettingsBase.Synchronized(settingsBase_0);
	}
}
