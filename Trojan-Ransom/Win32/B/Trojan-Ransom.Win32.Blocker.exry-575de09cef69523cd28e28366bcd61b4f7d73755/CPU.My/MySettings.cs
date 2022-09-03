using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace CPU.My;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance;

	private static bool addedHandler;

	private static object addedHandlerLockObject;

	public static MySettings Default
	{
		get
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			if (!addedHandler)
			{
				object obj = addedHandlerLockObject;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				Monitor.Enter(obj);
				try
				{
					if (!addedHandler)
					{
						((WindowsFormsApplicationBase)MyProject.Application).add_Shutdown((ShutdownEventHandler)delegate
						{
							if (((WindowsFormsApplicationBase)MyProject.Application).get_SaveMySettingsOnExit())
							{
								((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
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

	static MySettings()
	{
		Class2.Tfbc7BhzM3pUR();
		defaultInstance = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());
		addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
	}

	[DebuggerNonUserCode]
	public MySettings()
	{
		Class2.Tfbc7BhzM3pUR();
		((ApplicationSettingsBase)this)._002Ector();
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		if (((WindowsFormsApplicationBase)MyProject.Application).get_SaveMySettingsOnExit())
		{
			((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
		}
	}
}
