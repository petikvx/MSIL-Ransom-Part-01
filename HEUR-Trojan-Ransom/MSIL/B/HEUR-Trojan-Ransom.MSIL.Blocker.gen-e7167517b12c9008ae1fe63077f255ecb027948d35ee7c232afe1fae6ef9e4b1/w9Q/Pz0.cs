using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace w9Q;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class Pz0 : ApplicationSettingsBase
{
	private static Pz0 defaultInstance = (Pz0)(object)SettingsBase.Synchronized((SettingsBase)(object)new Pz0());

	public static Pz0 Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DefaultSettingValue("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\apart.mdf;Integrated Security=True")]
	public string apartConnectionString => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("apartConnectionString"));
}
