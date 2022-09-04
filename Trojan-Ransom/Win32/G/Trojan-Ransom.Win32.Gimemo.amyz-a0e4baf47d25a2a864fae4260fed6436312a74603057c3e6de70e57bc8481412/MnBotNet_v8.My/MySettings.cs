using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace MnBotNet_v8.My;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
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
						((WindowsFormsApplicationBase)Class1.smethod_1()).add_Shutdown((ShutdownEventHandler)delegate
						{
							if (((WindowsFormsApplicationBase)Class1.smethod_1()).get_SaveMySettingsOnExit())
							{
								((ApplicationSettingsBase)Class5.smethod_0()).Save();
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
	[UserScopedSetting]
	[DefaultSettingValue("0")]
	public int brw
	{
		get
		{
			return Conversions.ToInteger(((ApplicationSettingsBase)this).get_Item("brw"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("brw", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("")]
	public string dat1
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("dat1"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("dat1", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string dat2
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("dat2"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("dat2", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string dat3
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("dat3"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("dat3", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string dat4
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("dat4"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("dat4", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int addslvs
	{
		get
		{
			return Conversions.ToInteger(((ApplicationSettingsBase)this).get_Item("addslvs"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("addslvs", (object)value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerNonUserCode]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		if (((WindowsFormsApplicationBase)Class1.smethod_1()).get_SaveMySettingsOnExit())
		{
			((ApplicationSettingsBase)Class5.smethod_0()).Save();
		}
	}
}
