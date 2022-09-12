using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using Microsoft.VisualBasic.CompilerServices;

namespace Dc4d8N;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class Ta61Ef : ApplicationSettingsBase
{
	private static Ta61Ef defaultInstance = (Ta61Ef)(object)SettingsBase.Synchronized((SettingsBase)(object)new Ta61Ef());

	public static Ta61Ef Default => defaultInstance;

	[DefaultSettingValue("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\bin\\Debug\\LMS_DB.accdb")]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[ApplicationScopedSetting]
	public string LMS_DBConnectionString => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("LMS_DBConnectionString"));
}
