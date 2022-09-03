using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
internal sealed class Class6 : ApplicationSettingsBase
{
	private static Class6 defaultInstance = (Class6)(object)SettingsBase.Synchronized((SettingsBase)(object)new Class6());

	private static bool addedHandler;

	private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

	public static Class6 Class6_0
	{
		get
		{
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			if (!addedHandler)
			{
				object obj = addedHandlerLockObject;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				Monitor.Enter(obj);
				try
				{
					if (!addedHandler)
					{
						((WindowsFormsApplicationBase)Class1.Form0_0).add_Shutdown((ShutdownEventHandler)delegate
						{
							if (((WindowsFormsApplicationBase)Class1.Form0_0).get_SaveMySettingsOnExit())
							{
								((ApplicationSettingsBase)Class7.Class6_0).Save();
							}
						});
						addedHandler = true;
					}
				}
				finally
				{
					Monitor.Exit(obj);
				}
			}
			return defaultInstance;
		}
	}

	[DebuggerNonUserCode]
	public Class6()
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerNonUserCode]
	private static void smethod_0(object sender, EventArgs e)
	{
		if (((WindowsFormsApplicationBase)Class1.Form0_0).get_SaveMySettingsOnExit())
		{
			((ApplicationSettingsBase)Class7.Class6_0).Save();
		}
	}
}
