using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using Microsoft.VisualBasic.CompilerServices;

namespace o1KZx9;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
internal sealed class Yg89Py : ApplicationSettingsBase
{
	private static Yg89Py defaultInstance = (Yg89Py)(object)SettingsBase.Synchronized((SettingsBase)(object)new Yg89Py());

	public static Yg89Py Default
	{
		get
		{
			object obj = defaultInstance;
			return (Yg89Py)obj;
		}
	}

	[DefaultSettingValue("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Fast_food_management.mdb;Persist Security Info=True")]
	[ApplicationScopedSetting]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string Fast_food_managementConnectionString
	{
		get
		{
			object obj = Conversions.ToString(((ApplicationSettingsBase)this).get_Item("Fast_food_managementConnectionString"));
			return obj as string;
		}
	}

	[ApplicationScopedSetting]
	[DefaultSettingValue("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\DBForFoodManagement.mdb;Persist Security Info=True")]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string DBForFoodManagementConnectionString
	{
		get
		{
			object obj = Conversions.ToString(((ApplicationSettingsBase)this).get_Item("DBForFoodManagementConnectionString"));
			return (string)obj;
		}
	}
}
