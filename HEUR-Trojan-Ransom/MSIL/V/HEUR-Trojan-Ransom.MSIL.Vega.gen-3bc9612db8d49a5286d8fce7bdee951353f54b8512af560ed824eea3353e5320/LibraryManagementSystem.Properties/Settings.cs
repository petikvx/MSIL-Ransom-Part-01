using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace LibraryManagementSystem.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default => defaultInstance;

	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[ApplicationScopedSetting]
	[DefaultSettingValue("Data Source=SERVER11-11\\MSSQLSERVER16;Initial Catalog=LibraryDB;Persist Security Info=True;User ID=sa;Password=Admin@1234")]
	public string LibraryDB => (string)((SettingsBase)this).get_Item("LibraryDB");
}
