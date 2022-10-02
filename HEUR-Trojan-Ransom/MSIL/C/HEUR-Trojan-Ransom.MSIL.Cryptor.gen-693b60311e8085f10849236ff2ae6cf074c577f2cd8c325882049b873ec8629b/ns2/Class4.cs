using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ns2;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
internal sealed class Class4 : ApplicationSettingsBase
{
	private static Class4 class4_0 = (Class4)(object)SettingsBase.Synchronized((SettingsBase)(object)new Class4());

	public static Class4 Default => class4_0;

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string pcid
	{
		get
		{
			return (string)((SettingsBase)this).get_Item(GClass211.smethod_0("tŠɫ\u0365"));
		}
		set
		{
			((SettingsBase)this).set_Item(GClass211.smethod_0("tŠɫ\u0365"), (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int sent
	{
		get
		{
			return (int)((SettingsBase)this).get_Item(GClass211.smethod_0("wŦɬ\u0375"));
		}
		set
		{
			((SettingsBase)this).set_Item(GClass211.smethod_0("wŦɬ\u0375"), (object)value);
		}
	}
}
