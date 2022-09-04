using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using ns2;
using ns3;

namespace FinalIhope.My;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings mySettings_0 = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());

	private static bool bool_0;

	private static object object_0 = RuntimeHelpers.GetObjectValue(new object());

	public unsafe static MySettings Default
	{
		get
		{
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected O, but got Unknown
			void* ptr = stackalloc byte[2];
			((byte*)ptr)[1] = ((!bool_0) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[1] != 0)
			{
				object obj = object_0;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				*(sbyte*)ptr = 0;
				try
				{
					Monitor.Enter(obj, ref *(bool*)ptr);
					((byte*)ptr)[1] = ((!bool_0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[1] != 0)
					{
						((WindowsFormsApplicationBase)Class1.smethod_0()).add_Shutdown((ShutdownEventHandler)delegate
						{
							if (((WindowsFormsApplicationBase)Class1.smethod_0()).get_SaveMySettingsOnExit())
							{
								((ApplicationSettingsBase)Class6.smethod_0()).Save();
							}
						});
						bool_0 = true;
					}
				}
				finally
				{
					((byte*)ptr)[1] = *(byte*)ptr;
					if (((byte*)ptr)[1] != 0)
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerNonUserCode]
	private static void smethod_0(object sender, EventArgs e)
	{
		if (((WindowsFormsApplicationBase)Class1.smethod_0()).get_SaveMySettingsOnExit())
		{
			((ApplicationSettingsBase)Class6.smethod_0()).Save();
		}
	}
}
