using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ns24;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.0.0.0")]
internal sealed class Class4 : ApplicationSettingsBase
{
	private static Class4 class4_0 = (Class4)(object)SettingsBase.Synchronized((SettingsBase)(object)new Class4());

	public static Class4 Default => class4_0;

	[ApplicationScopedSetting]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DefaultSettingValue("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\database.mdf;Integrated Security=True;Connect Timeout=30")]
	[DebuggerNonUserCode]
	public string databaseConnectionString => (string)((SettingsBase)this).get_Item("databaseConnectionString");
}
