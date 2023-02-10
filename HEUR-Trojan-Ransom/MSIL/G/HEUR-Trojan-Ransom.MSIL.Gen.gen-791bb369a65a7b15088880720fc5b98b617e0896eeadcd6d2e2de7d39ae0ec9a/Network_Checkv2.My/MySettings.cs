using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Network_Checkv2.My;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.4.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());

	private static bool addedHandler;

	private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

	public static MySettings Default
	{
		get
		{
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected O, but got Unknown
			if (!addedHandler)
			{
				object obj = addedHandlerLockObject;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				bool lockTaken = false;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
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
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
			}
			return defaultInstance;
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0.0.0.0")]
	public string oldIPAddress
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("oldIPAddress"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("oldIPAddress", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool logEventsEnabled
	{
		get
		{
			return Conversions.ToBoolean(((ApplicationSettingsBase)this).get_Item("logEventsEnabled"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("logEventsEnabled", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("500")]
	public int pingTimeout
	{
		get
		{
			return Conversions.ToInteger(((ApplicationSettingsBase)this).get_Item("pingTimeout"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("pingTimeout", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("bbc.co.uk")]
	public string pingURL
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("pingURL"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("pingURL", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("google.co.uk")]
	public string pingAlternativeURL
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("pingAlternativeURL"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("pingAlternativeURL", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("sapphire1.synology.me")]
	public string ddns_URL
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("ddns_URL"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("ddns_URL", (object)value);
		}
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
