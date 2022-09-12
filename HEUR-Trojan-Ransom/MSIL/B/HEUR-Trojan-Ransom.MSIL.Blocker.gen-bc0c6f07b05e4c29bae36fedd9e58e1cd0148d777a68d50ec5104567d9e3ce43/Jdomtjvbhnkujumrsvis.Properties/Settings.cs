using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Jdomtjvbhnkujumrsvis.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings settings_0 = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	internal static Settings RestartExpression;

	public static Settings smethod_0()
	{
		return settings_0;
	}

	internal static bool SetupExpression()
	{
		return RestartExpression == null;
	}

	internal static Settings DefineExpression()
	{
		return RestartExpression;
	}
}
