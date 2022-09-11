using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ns1;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings settings_0 = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default => settings_0;

	[UserScopedSetting]
	[DefaultSettingValue("m")]
	[DebuggerNonUserCode]
	public char m
	{
		get
		{
			return (char)((SettingsBase)this).get_Item("m");
		}
		set
		{
			((SettingsBase)this).set_Item("m", (object)value);
		}
	}
}
