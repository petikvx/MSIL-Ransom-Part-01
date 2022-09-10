using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace AgileDotNet.ErrorReporting.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DefaultSettingValue("http://secureteam.net/ErrorReporting.asmx")]
	public string AgileDotNet_ExceptionReporting_SecureTeamWs_ErrorReporting => (string)((SettingsBase)this).get_Item("AgileDotNet_ExceptionReporting_SecureTeamWs_ErrorReporting");
}
