using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace PackageIO.My;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)smethod_0(new MySettings());

	public static MySettings Default => defaultInstance;

	[DebuggerNonUserCode]
	public MySettings()
	{
		smethod_3(this);
	}

	internal static object smethod_0(object object_0)
	{
		return SettingsBase.Synchronized((SettingsBase)object_0);
	}

	internal static bool smethod_1()
	{
		return true;
	}

	internal static bool smethod_2()
	{
		return false;
	}

	internal static void smethod_3(object object_0)
	{
		((ApplicationSettingsBase)object_0)._002Ector();
	}
}
