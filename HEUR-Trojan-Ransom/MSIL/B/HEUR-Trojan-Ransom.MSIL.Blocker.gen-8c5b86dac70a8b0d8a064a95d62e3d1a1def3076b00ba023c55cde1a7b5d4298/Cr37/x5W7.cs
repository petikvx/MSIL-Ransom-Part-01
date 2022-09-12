using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Cr37;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class x5W7 : ApplicationSettingsBase
{
	private static x5W7 defaultInstance = (x5W7)(object)SettingsBase.Synchronized((SettingsBase)(object)new x5W7());

	public static x5W7 Default => defaultInstance;

	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DefaultSettingValue("Data Source=|DataDirectory|\\Database1.sdf")]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public string Database1ConnectionString => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("Database1ConnectionString"));
}
