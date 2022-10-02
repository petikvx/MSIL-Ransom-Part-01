using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using Microsoft.VisualBasic.CompilerServices;

namespace p3L;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class Ak5 : ApplicationSettingsBase
{
	private static Ak5 defaultInstance = (Ak5)(object)SettingsBase.Synchronized((SettingsBase)(object)new Ak5());

	public static Ak5 Default => defaultInstance;

	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DefaultSettingValue("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True")]
	[ApplicationScopedSetting]
	public string Database1ConnectionString => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("Database1ConnectionString"));
}
