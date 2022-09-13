using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using ns0;

namespace Client.My;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings mySettings_0;

	public static MySettings Default => (MySettings)(ApplicationSettingsBase)mySettings_0;

	static MySettings()
	{
		Class6.smethod_0();
		mySettings_0 = (MySettings)(object)Attribute0.smethod_0<SettingsBase>((SettingsBase)(object)new MySettings(), (short)90, (short)2);
	}
}
