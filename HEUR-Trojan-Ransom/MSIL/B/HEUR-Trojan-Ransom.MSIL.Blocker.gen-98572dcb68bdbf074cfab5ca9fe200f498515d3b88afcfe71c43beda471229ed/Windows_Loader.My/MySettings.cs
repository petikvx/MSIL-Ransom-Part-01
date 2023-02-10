using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using WindowsLoader;

namespace Windows_Loader.My;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
[CompilerGenerated]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)(object)FunctionStack.RemovePane((SettingsBase)(object)ConditionInvoker.RemovePane());

	public static MySettings Default => defaultInstance;

	[DebuggerNonUserCode]
	public MySettings()
	{
	}
}
