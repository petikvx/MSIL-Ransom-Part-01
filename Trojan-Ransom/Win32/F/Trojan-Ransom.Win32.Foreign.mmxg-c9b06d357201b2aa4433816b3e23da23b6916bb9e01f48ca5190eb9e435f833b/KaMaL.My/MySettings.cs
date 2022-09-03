using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using ns0;

namespace KaMaL.My;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings mySettings_0 = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());

	public static MySettings Default
	{
		get
		{
			MySettings result = mySettings_0;
			Class5.smethod_12();
			return result;
		}
	}

	public MySettings()
	{
		Class3.Class4.smethod_7();
	}
}
