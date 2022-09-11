using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Program.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.3.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings _0001;

	public static Settings Default => _0001;

	static Settings()
	{
		//IL_0014: Incompatible stack heights: 0 vs 1
		//IL_001b: Incompatible stack heights: 0 vs 1
		new Settings();
		SettingsBase.Synchronized((SettingsBase)/*Error near IL_001b: Stack underflow*/);
		_0001 = (Settings)/*Error near IL_0005: Stack underflow*/;
	}
}
