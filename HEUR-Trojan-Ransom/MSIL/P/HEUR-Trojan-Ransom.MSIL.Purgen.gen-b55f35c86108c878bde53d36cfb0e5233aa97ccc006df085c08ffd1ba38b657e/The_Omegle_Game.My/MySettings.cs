using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace The_Omegle_Game.My;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings mySettings_0 = (MySettings)(object)MySettings.smethod_0((SettingsBase)(object)new MySettings());

	public static MySettings Default => mySettings_0;

	static SettingsBase smethod_0(SettingsBase settingsBase_0)
	{
		return SettingsBase.Synchronized(settingsBase_0);
	}
}
