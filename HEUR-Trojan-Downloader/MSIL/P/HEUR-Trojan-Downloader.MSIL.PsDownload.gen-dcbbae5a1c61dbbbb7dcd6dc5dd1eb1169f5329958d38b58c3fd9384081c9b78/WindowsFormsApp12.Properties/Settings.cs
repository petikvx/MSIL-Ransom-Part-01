using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp12.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings settings_0 = (Settings)DeleteItem(new Settings());

	private static Settings ExcludeItem;

	public Settings()
	{
		if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_8cca8faf24b940e59b2f8f934cadddc3 != 0)
		{
			switch (0)
			{
			}
		}
	}

	public static Settings smethod_0()
	{
		Settings result = settings_0;
		if (_003CModule_003E_007B89a366a7_002D2270_002D4665_002D8440_002Dcb5a27ea74fd_007D.m_8cca8faf24b940e59b2f8f934cadddc3 == 0)
		{
			switch (0)
			{
			}
		}
		return result;
	}

	internal static bool EnableItem()
	{
		return ExcludeItem == null;
	}

	internal static Settings VisitItem()
	{
		return ExcludeItem;
	}

	internal static object DeleteItem(object object_0)
	{
		return SettingsBase.Synchronized((SettingsBase)object_0);
	}
}
