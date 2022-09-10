using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Fb3;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[CompilerGenerated]
internal sealed class Aa0 : ApplicationSettingsBase
{
	private static Aa0 defaultInstance = (Aa0)(object)SettingsBase.Synchronized((SettingsBase)(object)new Aa0());

	public static Aa0 Default => defaultInstance;

	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DefaultSettingValue("User Id=raldz;Password=d74r3j93527;Host=127.0.0.1;Database=db_lccsams;Persist Security Info=True")]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	public string db_lccsams_connection => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("db_lccsams_connection"));
}
