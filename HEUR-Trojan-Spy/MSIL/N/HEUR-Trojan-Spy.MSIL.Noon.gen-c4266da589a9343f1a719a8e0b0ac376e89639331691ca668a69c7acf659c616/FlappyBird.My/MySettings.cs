using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace FlappyBird.My;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings mySettings_0 = (MySettings)(object)MySettings.smethod_1((SettingsBase)(object)new MySettings());

	private static bool bool_0;

	private static object object_0 = MySettings.smethod_3(MySettings.smethod_2());

	public static MySettings Default
	{
		get
		{
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected O, but got Unknown
			if (!bool_0)
			{
				object object_ = object_0;
				MySettings.smethod_6(object_);
				bool bool_ = false;
				try
				{
					MySettings.smethod_7(object_, ref bool_);
					if (!bool_0)
					{
						MySettings.smethod_8((WindowsFormsApplicationBase)(object)Class1.Form0_0, (ShutdownEventHandler)delegate
						{
							if (MySettings.smethod_4((WindowsFormsApplicationBase)(object)Class1.Form0_0))
							{
								MySettings.smethod_5((ApplicationSettingsBase)(object)Class6.MySettings_0);
							}
						});
						bool_0 = true;
					}
				}
				finally
				{
					if (bool_)
					{
						MySettings.smethod_9(object_);
					}
				}
			}
			return mySettings_0;
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void smethod_0(object sender, EventArgs e)
	{
		if (MySettings.smethod_4((WindowsFormsApplicationBase)(object)Class1.Form0_0))
		{
			MySettings.smethod_5((ApplicationSettingsBase)(object)Class6.MySettings_0);
		}
	}

	static SettingsBase smethod_1(SettingsBase settingsBase_0)
	{
		return SettingsBase.Synchronized(settingsBase_0);
	}

	static object smethod_2()
	{
		return new object();
	}

	static object smethod_3(object object_1)
	{
		return RuntimeHelpers.GetObjectValue(object_1);
	}

	static bool smethod_4(WindowsFormsApplicationBase windowsFormsApplicationBase_0)
	{
		return windowsFormsApplicationBase_0.get_SaveMySettingsOnExit();
	}

	static void smethod_5(ApplicationSettingsBase applicationSettingsBase_0)
	{
		applicationSettingsBase_0.Save();
	}

	static void smethod_6(object object_1)
	{
		ObjectFlowControl.CheckForSyncLockOnValueType(object_1);
	}

	static void smethod_7(object object_1, ref bool bool_1)
	{
		Monitor.Enter(object_1, ref bool_1);
	}

	static void smethod_8(WindowsFormsApplicationBase windowsFormsApplicationBase_0, ShutdownEventHandler shutdownEventHandler_0)
	{
		windowsFormsApplicationBase_0.add_Shutdown(shutdownEventHandler_0);
	}

	static void smethod_9(object object_1)
	{
		Monitor.Exit(object_1);
	}
}
