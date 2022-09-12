using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using Microsoft.VisualBasic.CompilerServices;

namespace x9YC;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
internal sealed class Sd05 : ApplicationSettingsBase
{
	private static Sd05 defaultInstance = (Sd05)(object)SettingsBase.Synchronized((SettingsBase)(object)new Sd05());

	public static Sd05 Default => defaultInstance;

	[ApplicationScopedSetting]
	[DefaultSettingValue("Data Source=DESKTOP-LFV0TRS;Initial Catalog=library;Persist Security Info=True;User ID=student;Password=student")]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string libraryConnectionString => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("libraryConnectionString"));
}
