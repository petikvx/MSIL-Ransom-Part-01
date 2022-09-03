using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Stubich.My;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
[CompilerGenerated]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance;

	private static bool addedHandler;

	private static object addedHandlerLockObject;

	public static MySettings Default
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
						((WindowsFormsApplicationBase)Class2.Form0_0).add_Shutdown((ShutdownEventHandler)delegate
						{
							if (((WindowsFormsApplicationBase)Class2.Form0_0).get_SaveMySettingsOnExit())
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
		Class7.wu3uG8qzm2R30();
		defaultInstance = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());
		addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
	}

	[DebuggerNonUserCode]
	public MySettings()
	{
		Class7.wu3uG8qzm2R30();
		((ApplicationSettingsBase)this)._002Ector();
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerNonUserCode]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		if (((WindowsFormsApplicationBase)Class2.Form0_0).get_SaveMySettingsOnExit())
		{
			((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
		}
	}
}
