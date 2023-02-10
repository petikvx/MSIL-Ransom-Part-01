using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace t1L;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class j8B : ApplicationSettingsBase
{
	private static j8B defaultInstance = (j8B)(object)SettingsBase.Synchronized((SettingsBase)(object)new j8B());

	public static j8B Default => defaultInstance;

	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DefaultSettingValue("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\hms_Database.accdb")]
	public string hms_DatabaseConnectionString => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("hms_DatabaseConnectionString"));
}
