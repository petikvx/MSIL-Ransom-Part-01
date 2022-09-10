using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace b1ZEe;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class q6RLm : ApplicationSettingsBase
{
	private static q6RLm defaultInstance = (q6RLm)(object)SettingsBase.Synchronized((SettingsBase)(object)new q6RLm());

	public static q6RLm Default => defaultInstance;

	[ApplicationScopedSetting]
	[DefaultSettingValue("User Id=raldz;Password=d74r3j93527;Host=127.0.0.1;Database=db_lccsams;Persist Security Info=True")]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string db_lccsams_connection => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("db_lccsams_connection"));
}
