using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ns1;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
internal sealed class Class9 : ApplicationSettingsBase
{
	private static Class9 class9_0 = (Class9)(object)SettingsBase.Synchronized((SettingsBase)(object)new Class9());

	public static Class9 Default => class9_0;

	[DefaultSettingValue("True")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public bool Active
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("Active");
		}
		set
		{
			((SettingsBase)this).set_Item("Active", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("fzyjqdwatgyro(rt/yf(yrct#######")]
	public string DNS
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("DNS");
		}
		set
		{
			((SettingsBase)this).set_Item("DNS", (object)value);
		}
	}

	private void method_0(object sender, SettingChangingEventArgs e)
	{
	}

	private void method_1(object sender, CancelEventArgs e)
	{
	}
}
