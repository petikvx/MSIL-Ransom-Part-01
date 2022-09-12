using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Ty0a;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class Fs1e : ApplicationSettingsBase
{
	private static Fs1e defaultInstance = (Fs1e)(object)SettingsBase.Synchronized((SettingsBase)(object)new Fs1e());

	public static Fs1e Default => defaultInstance;

	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DefaultSettingValue("Data Source=|DataDirectory|\\Database1.sdf")]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public string Database1ConnectionString => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("Database1ConnectionString"));
}
