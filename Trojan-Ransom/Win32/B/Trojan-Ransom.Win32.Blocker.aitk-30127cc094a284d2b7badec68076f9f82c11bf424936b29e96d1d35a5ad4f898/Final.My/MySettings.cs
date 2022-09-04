using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace Final.My;

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
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			if (!bool_0)
			{
				object obj = object_0;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				Monitor.Enter(obj);
				try
				{
					if (!bool_0)
					{
						((WindowsFormsApplicationBase)MyProject.MyApplication_0).add_Shutdown(new ShutdownEventHandler(smethod_0));
						bool_0 = true;
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void smethod_0(object sender, EventArgs e)
	{
		if (((WindowsFormsApplicationBase)MyProject.MyApplication_0).get_SaveMySettingsOnExit())
		{
			((ApplicationSettingsBase)Class6.MySettings_0).Save();
		}
	}
}
