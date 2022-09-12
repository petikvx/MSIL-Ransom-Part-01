using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Psmvvft.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	private static Settings EnableStub;

	public static Settings Default => defaultInstance;

	internal static bool NewStub()
	{
		return EnableStub == null;
	}

	internal static Settings CloneStub()
	{
		return EnableStub;
	}
}
