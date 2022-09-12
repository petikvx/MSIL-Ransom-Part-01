using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Coache.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default => defaultInstance;

	[DefaultSettingValue("Data Source=localhost\\SQLEXPRESS;Initial Catalog=GD1C2012;User ID=gd;Password=gd2012")]
	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string GD1C2012ConnectionString => (string)((SettingsBase)this).get_Item("GD1C2012ConnectionString");
}
