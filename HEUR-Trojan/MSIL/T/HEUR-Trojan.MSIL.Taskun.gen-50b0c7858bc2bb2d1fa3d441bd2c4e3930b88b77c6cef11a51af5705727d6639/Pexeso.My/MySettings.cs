using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Pexeso.My;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[CompilerGenerated]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());

	private static bool addedHandler;

	private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

	public static MySettings Default
	{
		get
		{
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected O, but got Unknown
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

	[DebuggerNonUserCode]
	[DefaultSettingValue("Player1;Player2;Player3;Player4;Player5;Player6;Player7;Player8;Player9;Player10")]
	[UserScopedSetting]
	public string L1
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("L1"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("L1", (object)value);
		}
	}

	[DefaultSettingValue("Player1;Player2;Player3;Player4;Player5;Player6;Player7;Player8;Player9;Player10")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string L3
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("L3"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("L3", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Player1;Player2;Player3;Player4;Player5;Player6;Player7;Player8;Player9;Player10")]
	public string L5
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("L5"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("L5", (object)value);
		}
	}

	[DefaultSettingValue("00:15;00:20;00:25;00:30;00:35;00:40;00:45;00:50;00:55;01:00")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string L2
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("L2"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("L2", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("01:10;01:15;01:20;01:25;01:30;01:35;01:40;01:45;01:50;01:55")]
	public string L4
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("L4"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("L4", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("02:00;02:10;02:20;02:30;02:40;02:50;03:00;04:10;04:20;04:30")]
	public string L6
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("L6"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("L6", (object)value);
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
