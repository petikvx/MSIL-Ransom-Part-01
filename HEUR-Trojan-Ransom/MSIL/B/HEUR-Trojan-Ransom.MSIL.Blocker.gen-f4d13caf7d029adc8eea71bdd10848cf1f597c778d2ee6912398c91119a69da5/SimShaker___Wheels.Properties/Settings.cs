using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SimShaker___Wheels.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings settings_0 = (Settings)(object)Settings.smethod_2((SettingsBase)(object)new Settings());

	public static Settings Default => settings_0;

	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	[UserScopedSetting]
	public int Setting
	{
		get
		{
			return (int)Settings.smethod_0((SettingsBase)(object)this, "Setting");
		}
		set
		{
			Settings.smethod_1((SettingsBase)(object)this, "Setting", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("0")]
	public int Setting1
	{
		get
		{
			return (int)Settings.smethod_0((SettingsBase)(object)this, "Setting1");
		}
		set
		{
			Settings.smethod_1((SettingsBase)(object)this, "Setting1", (object)value);
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
