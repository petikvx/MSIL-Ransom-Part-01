using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Security;
using Microsoft.VisualBasic.ApplicationServices;
using ns0;

namespace prince.My;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings mySettings_0;

	private static bool bool_0;

	private static object object_0;

	public static MySettings Default
	{
		get
		{
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected O, but got Unknown
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			if (!bool_0)
			{
				object gparam_ = object_0;
				Class9.smethod_1(gparam_, 'ʪ', '\u02fa');
				bool flag = false;
				try
				{
					Class3.smethod_6(gparam_, ref flag, 336, 'ŋ');
					if (!bool_0)
					{
						Class9.smethod_2<ShutdownEventHandler, WindowsFormsApplicationBase>((WindowsFormsApplicationBase)(object)MyProject.MyApplication_0, new ShutdownEventHandler(smethod_0), (short)559, 610);
						bool_0 = true;
					}
				}
				finally
				{
					if (flag)
					{
						Class9.smethod_1(gparam_, '&', 'w');
					}
				}
			}
			return (MySettings)(SettingsBase)mySettings_0;
		}
	}

	[SecuritySafeCritical]
	static MySettings()
	{
		Class3.Class5.smethod_2();
		mySettings_0 = (MySettings)(object)Class3.smethod_5<SettingsBase>((SettingsBase)(object)new MySettings(), (short)91, 'k');
		object_0 = Class3.Class5.smethod_3(new object(), 800, 882);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void smethod_0(object sender, EventArgs e)
	{
		if (Class9.smethod_0<WindowsFormsApplicationBase>((WindowsFormsApplicationBase)(object)MyProject.MyApplication_0, 512, 'ɨ'))
		{
			Class3.Class7.smethod_0<ApplicationSettingsBase>((ApplicationSettingsBase)(object)Class9.MySettings_0, 682, 762);
		}
	}
}
