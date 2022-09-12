using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Security;
using Microsoft.VisualBasic.ApplicationServices;
using ns0;

namespace cleanrrs.My;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
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
			if (!bool_0)
			{
				object gparam_ = object_0;
				Class3.smethod_6(gparam_, 'Į', 323);
				bool flag = false;
				try
				{
					Class7.smethod_3(gparam_, ref flag, 'ξ', 'ϊ');
					if (!bool_0)
					{
						Class3.Class5.smethod_3<WindowsFormsApplicationBase, ShutdownEventHandler>((WindowsFormsApplicationBase)(object)MyProject.MyApplication_0, new ShutdownEventHandler(smethod_0), (short)905, 'ϭ');
						bool_0 = true;
					}
				}
				finally
				{
					if (flag)
					{
						Class3.smethod_6(gparam_, 'Ł', 303);
					}
				}
			}
			return mySettings_0;
		}
	}

	[SecuritySafeCritical]
	static MySettings()
	{
		Class3.Class5.Class6.smethod_0();
		mySettings_0 = (MySettings)(object)Class3.Class5.smethod_0<SettingsBase>((SettingsBase)(object)new MySettings(), (short)699, '\u02e8');
		object_0 = Class3.smethod_5(new object(), 709, 'ʒ');
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void smethod_0(object sender, EventArgs e)
	{
		if (Class3.Class5.smethod_1<WindowsFormsApplicationBase>((WindowsFormsApplicationBase)(object)MyProject.MyApplication_0, 629, 543))
		{
			Class3.Class5.smethod_2<ApplicationSettingsBase>((ApplicationSettingsBase)(object)Class9.MySettings_0, 801, 779);
		}
	}
}
