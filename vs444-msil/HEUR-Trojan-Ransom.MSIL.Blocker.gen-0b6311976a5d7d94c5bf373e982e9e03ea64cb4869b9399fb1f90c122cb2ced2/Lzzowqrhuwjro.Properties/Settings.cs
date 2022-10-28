using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;
using AMD.Containers;

namespace Lzzowqrhuwjro.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings settings_0;

	internal static Settings StartExporter;

	public Settings()
	{
		CreatorStrategyContainer.PopCollection();
		((ApplicationSettingsBase)this)._002Ector();
		if (_003CModule_003E_007Beaae710d_002De3d8_002D46b8_002Db6da_002Dd6c3c29ddccd_007D.m_287f5b13f2364f39b884cf32871ff3e9 == 0)
		{
			switch (0)
			{
			}
		}
	}

	static Settings()
	{
		DisableExporter();
		settings_0 = (Settings)SetupExporter(new Settings());
	}

	public static Settings smethod_0()
	{
		return settings_0;
	}

	internal static bool CloneExporter()
	{
		return StartExporter == null;
	}

	internal static Settings LogoutExporter()
	{
		return StartExporter;
	}

	internal static void DisableExporter()
	{
		CreatorStrategyContainer.PopCollection();
	}

	internal static object SetupExporter(object object_0)
	{
		return SettingsBase.Synchronized((SettingsBase)object_0);
	}
}
