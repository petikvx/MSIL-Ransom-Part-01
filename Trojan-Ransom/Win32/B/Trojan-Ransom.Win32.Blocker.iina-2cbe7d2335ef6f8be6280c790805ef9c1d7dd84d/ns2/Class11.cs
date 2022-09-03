using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ns2;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
internal sealed class Class11 : ApplicationSettingsBase
{
	private static Class11 class11_0 = (Class11)(object)SettingsBase.Synchronized((SettingsBase)(object)new Class11());

	public static Class11 Default => class11_0;

	[DefaultSettingValue("scourgebooter.no-ip.info")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
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

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
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
}
