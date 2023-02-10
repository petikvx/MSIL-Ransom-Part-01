using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Qp9w;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class b7KH : ApplicationSettingsBase
{
	private static b7KH defaultInstance = (b7KH)(object)SettingsBase.Synchronized((SettingsBase)(object)new b7KH());

	public static b7KH Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DefaultSettingValue("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\hms_Database.accdb")]
	public string hms_DatabaseConnectionString => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("hms_DatabaseConnectionString"));
}
