using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace j1Y;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class Zs6 : ApplicationSettingsBase
{
	private static Zs6 defaultInstance = (Zs6)(object)SettingsBase.Synchronized((SettingsBase)(object)new Zs6());

	public static Zs6 Default => defaultInstance;

	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DefaultSettingValue("Data Source=|DataDirectory|\\Database1.sdf")]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public string Database1ConnectionString => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("Database1ConnectionString"));
}
