using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace EmployeeData.My;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)(object)MySettings.smethod_0((SettingsBase)(object)new MySettings());

	private static bool addedHandler;

	private static object addedHandlerLockObject = MySettings.smethod_2(MySettings.smethod_1());

	public static MySettings Default
	{
		get
		{
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected O, but got Unknown
			if (!addedHandler)
			{
				object object_ = addedHandlerLockObject;
				MySettings.smethod_5(object_);
				bool bool_ = false;
				try
				{
					MySettings.smethod_6(object_, ref bool_);
					if (!addedHandler)
					{
						MySettings.smethod_7((WindowsFormsApplicationBase)(object)MyProject.Application, (ShutdownEventHandler)delegate
						{
							if (MySettings.smethod_3((WindowsFormsApplicationBase)(object)MyProject.Application))
							{
								MySettings.smethod_4((ApplicationSettingsBase)(object)MySettingsProperty.Settings);
							}
						});
						addedHandler = true;
					}
				}
				finally
				{
					if (bool_)
					{
						MySettings.smethod_8(object_);
					}
				}
			}
			return defaultInstance;
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		if (MySettings.smethod_3((WindowsFormsApplicationBase)(object)MyProject.Application))
		{
			MySettings.smethod_4((ApplicationSettingsBase)(object)MySettingsProperty.Settings);
		}
	}

	static SettingsBase smethod_0(SettingsBase settingsBase_0)
	{
		return SettingsBase.Synchronized(settingsBase_0);
	}

	static object smethod_1()
	{
		return new object();
	}

	static object smethod_2(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}

	static bool smethod_3(WindowsFormsApplicationBase windowsFormsApplicationBase_0)
	{
		return windowsFormsApplicationBase_0.get_SaveMySettingsOnExit();
	}

	static void smethod_4(ApplicationSettingsBase applicationSettingsBase_0)
	{
		applicationSettingsBase_0.Save();
	}

	static void smethod_5(object object_0)
	{
		ObjectFlowControl.CheckForSyncLockOnValueType(object_0);
	}

	static void smethod_6(object object_0, ref bool bool_0)
	{
		Monitor.Enter(object_0, ref bool_0);
	}

	static void smethod_7(WindowsFormsApplicationBase windowsFormsApplicationBase_0, ShutdownEventHandler shutdownEventHandler_0)
	{
		windowsFormsApplicationBase_0.add_Shutdown(shutdownEventHandler_0);
	}

	static void smethod_8(object object_0)
	{
		Monitor.Exit(object_0);
	}
}
