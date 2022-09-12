using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using Microsoft.VisualBasic.CompilerServices;

namespace y1Y5;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class j9DP : ApplicationSettingsBase
{
	private static j9DP defaultInstance = (j9DP)(object)SettingsBase.Synchronized((SettingsBase)(object)new j9DP());

	public static j9DP Default => defaultInstance;

	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DefaultSettingValue("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Users.accdb")]
	[ApplicationScopedSetting]
	public string UsersConnectionString => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("UsersConnectionString"));

	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DefaultSettingValue("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"|DataDirectory|\\Cinema 1.accdb\"")]
	[ApplicationScopedSetting]
	public string Cinema_1ConnectionString => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("Cinema_1ConnectionString"));

	[DefaultSettingValue("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"|DataDirectory|\\Cinema 2.accdb\"")]
	[ApplicationScopedSetting]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string Cinema_2ConnectionString => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("Cinema_2ConnectionString"));

	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[ApplicationScopedSetting]
	[DefaultSettingValue("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"|DataDirectory|\\Cinema 3.accdb\"")]
	public string Cinema_3ConnectionString => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("Cinema_3ConnectionString"));

	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DefaultSettingValue("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"|DataDirectory|\\bin\\Debug\\Cinema 3.accdb\"")]
	[ApplicationScopedSetting]
	public string Cinema_3ConnectionString1 => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("Cinema_3ConnectionString1"));

	[DefaultSettingValue("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"|DataDirectory|\\bin\\Debug\\Cinema 4.accdb\"")]
	[ApplicationScopedSetting]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string Cinema_4ConnectionString => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("Cinema_4ConnectionString"));

	[ApplicationScopedSetting]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DefaultSettingValue("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"|DataDirectory|\\Cinema 4.accdb\"")]
	public string Cinema_4ConnectionString1 => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("Cinema_4ConnectionString1"));
}
