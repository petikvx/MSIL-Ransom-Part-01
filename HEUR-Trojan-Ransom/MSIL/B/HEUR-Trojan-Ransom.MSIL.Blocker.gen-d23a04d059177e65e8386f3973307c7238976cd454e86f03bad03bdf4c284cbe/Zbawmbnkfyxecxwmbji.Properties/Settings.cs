using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Zbawmbnkfyxecxwmbji.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	private static Settings CancelThread;

	public static Settings Default => defaultInstance;

	internal static bool ValidateThread()
	{
		return CancelThread == null;
	}

	internal static Settings GetThread()
	{
		return CancelThread;
	}
}
