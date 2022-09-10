using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace DRTSwinA.My;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());

	private static bool addedHandler;

	private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

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

	[UserScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string e
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("e"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("e", (object)value);
		}
	}

	[DefaultSettingValue("k")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string Setting
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("Setting"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("Setting", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string q
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("q"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("q", (object)value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerNonUserCode]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		if (((WindowsFormsApplicationBase)MyProject.Application).get_SaveMySettingsOnExit())
		{
			((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
		}
	}
}
