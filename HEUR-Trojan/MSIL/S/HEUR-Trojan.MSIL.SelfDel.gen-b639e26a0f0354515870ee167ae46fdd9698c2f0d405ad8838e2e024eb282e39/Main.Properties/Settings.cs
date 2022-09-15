using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Main.Properties;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
[CompilerGenerated]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings settings_0;

	public static Settings Settings_0 => settings_0;

	static Settings()
	{
		if (DateTime.Now > new DateTime(636769994944035277L))
		{
			throw new Exception();
		}
		settings_0 = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());
	}
}
