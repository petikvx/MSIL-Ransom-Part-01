using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Windows.My;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
[CompilerGenerated]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());

	public static MySettings Default => defaultInstance;

	[DebuggerNonUserCode]
	public MySettings()
	{
	}
}
