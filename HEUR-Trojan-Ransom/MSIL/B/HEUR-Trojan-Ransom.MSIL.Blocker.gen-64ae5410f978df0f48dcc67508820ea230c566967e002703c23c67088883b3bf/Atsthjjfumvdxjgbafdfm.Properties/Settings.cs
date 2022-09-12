using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Atsthjjfumvdxjgbafdfm.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)SelectFacade(new Settings());

	internal static Settings SetFacade;

	public static Settings Default => defaultInstance;

	internal static bool WriteFacade()
	{
		return SetFacade == null;
	}

	internal static Settings PatchFacade()
	{
		return SetFacade;
	}

	internal static object SelectFacade(object object_0)
	{
		return SettingsBase.Synchronized((SettingsBase)object_0);
	}
}
