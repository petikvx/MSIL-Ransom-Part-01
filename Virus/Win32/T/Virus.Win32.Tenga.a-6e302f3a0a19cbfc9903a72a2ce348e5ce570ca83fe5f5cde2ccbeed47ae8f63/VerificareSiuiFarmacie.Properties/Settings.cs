using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace VerificareSiuiFarmacie.Properties;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
[CompilerGenerated]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default => defaultInstance;

	[DefaultSettingValue("ddd")]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public string CaleComunicatie => (string)((SettingsBase)this).get_Item("CaleComunicatie");

	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[ApplicationScopedSetting]
	[DefaultSettingValue("http://balsiui/svapntws/services/SiuiInsuredWS")]
	[DebuggerNonUserCode]
	public string VerificareSiuiFarmacie_SIUIInsuredWS_SiuiInsuredWSService => (string)((SettingsBase)this).get_Item("VerificareSiuiFarmacie_SIUIInsuredWS_SiuiInsuredWSService");

	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DefaultSettingValue("https://www.siui.ro/svapntws/services/SiuiWS")]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public string ServerCNAS_SiuiWS_SiuiWSService => (string)((SettingsBase)this).get_Item("ServerCNAS_SiuiWS_SiuiWSService");

	[DebuggerNonUserCode]
	[DefaultSettingValue("https://sipe.siui.ro/svapntws/services/EPrescriptionWS")]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[ApplicationScopedSetting]
	public string ServerCNAS_EPrescriptionWS_EPrescriptionWSService => (string)((SettingsBase)this).get_Item("ServerCNAS_EPrescriptionWS_EPrescriptionWSService");
}
