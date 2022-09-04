using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace stub.My;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings mySettings_0;

	private static bool ojwoerkAp;

	private static object object_0;

	public static MySettings Default
	{
		get
		{
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			if (!ojwoerkAp)
			{
				object obj = object_0;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				Monitor.Enter(obj);
				try
				{
					if (!ojwoerkAp)
					{
						((WindowsFormsApplicationBase)Class1.Form0_0).add_Shutdown((ShutdownEventHandler)delegate
						{
							if (((WindowsFormsApplicationBase)Class1.Form0_0).get_SaveMySettingsOnExit())
							{
								((ApplicationSettingsBase)Class6.MySettings_0).Save();
							}
						});
						ojwoerkAp = true;
					}
				}
				finally
				{
					Monitor.Exit(obj);
				}
			}
			return mySettings_0;
		}
	}

	static MySettings()
	{
		mySettings_0 = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());
		object_0 = RuntimeHelpers.GetObjectValue(new object());
	}

	[DebuggerNonUserCode]
	public MySettings()
	{
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void smethod_0(object sender, EventArgs e)
	{
		if (((WindowsFormsApplicationBase)Class1.Form0_0).get_SaveMySettingsOnExit())
		{
			((ApplicationSettingsBase)Class6.MySettings_0).Save();
		}
	}
}
