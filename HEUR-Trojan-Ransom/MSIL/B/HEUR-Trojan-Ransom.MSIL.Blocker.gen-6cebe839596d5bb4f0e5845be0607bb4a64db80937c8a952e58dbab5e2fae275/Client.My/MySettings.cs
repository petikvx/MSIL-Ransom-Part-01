using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;

namespace Client.My;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings mySettings_0;

	public static MySettings Default => (MySettings)(ApplicationSettingsBase)mySettings_0;

	static MySettings()
	{
		MyApplication.smethod_0();
		mySettings_0 = (MySettings)(object)MyApplication.smethod_1<SettingsBase>((SettingsBase)(object)new MySettings(), 182, 222);
	}
}
