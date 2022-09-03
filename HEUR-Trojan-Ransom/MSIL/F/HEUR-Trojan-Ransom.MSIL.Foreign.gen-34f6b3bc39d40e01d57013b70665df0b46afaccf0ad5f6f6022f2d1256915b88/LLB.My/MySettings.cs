using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace LLB.My;

[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings mySettings_0 = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());

	private static bool bool_0;

	private static object object_0 = RuntimeHelpers.GetObjectValue(new object());

	public static MySettings Default
	{
		get
		{
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected O, but got Unknown
			if (!bool_0)
			{
				object obj = object_0;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				bool lockTaken = false;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					if (!bool_0)
					{
						((WindowsFormsApplicationBase)Class1.smethod_1()).add_Shutdown((ShutdownEventHandler)delegate
						{
							if (((WindowsFormsApplicationBase)Class1.smethod_1()).get_SaveMySettingsOnExit())
							{
								((ApplicationSettingsBase)Class7.smethod_0()).Save();
							}
						});
						bool_0 = true;
					}
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
			}
			return mySettings_0;
		}
	}

	[DebuggerNonUserCode]
	public MySettings()
	{
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void smethod_0(object sender, EventArgs e)
	{
		if (((WindowsFormsApplicationBase)Class1.smethod_1()).get_SaveMySettingsOnExit())
		{
			((ApplicationSettingsBase)Class7.smethod_0()).Save();
		}
	}
}