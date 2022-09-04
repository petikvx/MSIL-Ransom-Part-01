using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ns4;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
[CompilerGenerated]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings mySettings_0 = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());

	public static MySettings Default => mySettings_0;

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("")]
	public string link
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("link"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("link", (object)value);
		}
	}
}
