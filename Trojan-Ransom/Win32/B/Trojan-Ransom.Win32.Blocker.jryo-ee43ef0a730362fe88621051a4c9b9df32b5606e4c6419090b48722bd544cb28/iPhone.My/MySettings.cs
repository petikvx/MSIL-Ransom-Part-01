using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace iPhone.My;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings mySettings_0 = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());

	public static MySettings Default => mySettings_0;

	[DefaultSettingValue("invoke")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string Setting
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("Setting"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("Setting", (object)value);
		}
	}

	[DefaultSettingValue("load")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string Setting1
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("Setting1"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("Setting1", (object)value);
		}
	}

	[DefaultSettingValue("entrypoint")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string Setting2
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("Setting2"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("Setting2", (object)value);
		}
	}

	[DebuggerNonUserCode]
	public MySettings()
	{
	}
}
