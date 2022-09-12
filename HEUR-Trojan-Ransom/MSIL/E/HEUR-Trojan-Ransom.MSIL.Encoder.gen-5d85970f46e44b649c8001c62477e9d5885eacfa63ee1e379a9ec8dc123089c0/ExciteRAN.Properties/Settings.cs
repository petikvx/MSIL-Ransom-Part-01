using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace ExciteRAN.Properties;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
[CompilerGenerated]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = DiskSet.ResolveFile(FunctionManager.SaveNetwork((SettingsBase)(object)DirectoryService.SaveNetwork()));

	public static Settings Default => defaultInstance;
}
