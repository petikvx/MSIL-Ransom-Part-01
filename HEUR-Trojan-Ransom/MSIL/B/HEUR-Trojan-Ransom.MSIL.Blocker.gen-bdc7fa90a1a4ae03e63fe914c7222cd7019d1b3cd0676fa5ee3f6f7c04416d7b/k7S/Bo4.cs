using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using Microsoft.VisualBasic.CompilerServices;

namespace k7S;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
internal sealed class Bo4 : ApplicationSettingsBase
{
	private static Bo4 defaultInstance = (Bo4)(object)SettingsBase.Synchronized((SettingsBase)(object)new Bo4());

	public static Bo4 Default => defaultInstance;

	[DefaultSettingValue("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Reepah.accdb;Persist Security Info=True")]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[ApplicationScopedSetting]
	public string ReepahConnectionString => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("ReepahConnectionString"));
}
