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
using ns1;

namespace MicrosoftWindows.My;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[CompilerGenerated]
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
						((WindowsFormsApplicationBase)Class1.Application).add_Shutdown((ShutdownEventHandler)delegate
						{
							if (((WindowsFormsApplicationBase)Class1.Application).get_SaveMySettingsOnExit())
							{
								((ApplicationSettingsBase)Class7.Settings).Save();
							}
						});
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

	[DefaultSettingValue("True")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public bool runonce
	{
		get
		{
			return Conversions.ToBoolean(((ApplicationSettingsBase)this).get_Item("runonce"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("runonce", (object)value);
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
		if (((WindowsFormsApplicationBase)Class1.Application).get_SaveMySettingsOnExit())
		{
			((ApplicationSettingsBase)Class7.Settings).Save();
		}
	}
}
