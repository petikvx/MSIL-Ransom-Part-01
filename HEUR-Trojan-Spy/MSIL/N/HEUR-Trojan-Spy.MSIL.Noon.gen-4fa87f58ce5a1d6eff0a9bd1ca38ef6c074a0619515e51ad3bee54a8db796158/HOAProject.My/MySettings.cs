using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace HOAProject.My;

[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());

	public static MySettings Default => defaultInstance;

	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[DebuggerNonUserCode]
	[ApplicationScopedSetting]
	[DefaultSettingValue("Data Source=.;Initial Catalog=Project;Integrated Security=True")]
	public string ProjectConnectionString => Conversions.ToString(((ApplicationSettingsBase)this).get_Item("ProjectConnectionString"));
}
