using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace LivePortfolio;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.5.0.0")]
[CompilerGenerated]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());

	public static MySettings Default => defaultInstance;

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("PEODTXYELUPWZAOC")]
	public string AlphaAPIKey
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("AlphaAPIKey"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("AlphaAPIKey", (object)value);
		}
	}
}
