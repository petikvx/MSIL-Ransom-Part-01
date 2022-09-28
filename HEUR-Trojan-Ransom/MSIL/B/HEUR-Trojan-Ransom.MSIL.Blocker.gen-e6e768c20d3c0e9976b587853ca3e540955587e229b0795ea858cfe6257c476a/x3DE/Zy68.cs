using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace x3DE;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class Zy68 : ApplicationSettingsBase
{
	private static Zy68 defaultInstance = (Zy68)(object)SettingsBase.Synchronized((SettingsBase)(object)new Zy68());

	public static Zy68 Default => defaultInstance;

	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DefaultSettingValue("Data Source=|DataDirectory|\\Database1.sdf")]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public string Database1ConnectionString => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("Database1ConnectionString"));
}
