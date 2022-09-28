using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace r8T1;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class r7SN : ApplicationSettingsBase
{
	private static r7SN defaultInstance = (r7SN)(object)SettingsBase.Synchronized((SettingsBase)(object)new r7SN());

	public static r7SN Default => defaultInstance;

	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DefaultSettingValue("Data Source=|DataDirectory|\\Database1.sdf")]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public string Database1ConnectionString => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("Database1ConnectionString"));
}
