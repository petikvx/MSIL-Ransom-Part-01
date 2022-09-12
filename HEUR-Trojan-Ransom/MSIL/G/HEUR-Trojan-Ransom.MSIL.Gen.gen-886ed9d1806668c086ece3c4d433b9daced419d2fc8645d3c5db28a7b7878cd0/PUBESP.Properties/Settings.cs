using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ns49;

namespace PUBESP.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance;

	internal static Settings settings_0;

	public static Settings Default => null;

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string Key
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string Username
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	static Settings()
	{
		Class25.smethod_22();
		smethod_2();
		Delegate11.smethod_0(Delegate11.delegate11_0);
		Delegate11.smethod_0(Delegate11.delegate11_2);
		defaultInstance = (Settings)(object)Delegate279.smethod_0((SettingsBase)(object)new Settings(), Delegate279.delegate279_0);
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static Settings smethod_1()
	{
		return null;
	}

	internal static void smethod_2()
	{
	}
}
