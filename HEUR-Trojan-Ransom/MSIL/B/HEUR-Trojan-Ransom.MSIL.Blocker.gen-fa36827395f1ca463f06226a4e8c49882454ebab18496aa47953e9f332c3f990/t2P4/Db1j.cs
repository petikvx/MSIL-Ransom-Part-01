using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using Microsoft.VisualBasic.CompilerServices;

namespace t2P4;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class Db1j : ApplicationSettingsBase
{
	private static Db1j defaultInstance = (Db1j)(object)SettingsBase.Synchronized((SettingsBase)(object)new Db1j());

	public static Db1j Default => defaultInstance;

	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DefaultSettingValue("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\Database.accdb")]
	[ApplicationScopedSetting]
	public string DatabaseConnectionString => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("DatabaseConnectionString"));

	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DefaultSettingValue("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Database.accdb")]
	[ApplicationScopedSetting]
	public string DatabaseConnectionString1 => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("DatabaseConnectionString1"));
}
