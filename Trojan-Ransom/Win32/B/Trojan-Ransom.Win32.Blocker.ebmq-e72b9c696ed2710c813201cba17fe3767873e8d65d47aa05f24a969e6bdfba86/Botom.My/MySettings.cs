using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using nLQv3ubX3DSfu4BQ1f;

namespace Botom.My;

[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)zhqZUl6ch15etYWCeRF(new MySettings());

	private static bool addedHandler;

	private static object addedHandlerLockObject = c8p6mH6ZegujclddjM5(new object());

	public static MySettings Default
	{
		get
		{
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			_ = 0;
			object object_ = default(object);
			if (Rbt9Le6eMwJ9MQsS1Q2())
			{
				if (addedHandler)
				{
					goto IL_0061;
				}
				object_ = addedHandlerLockObject;
				wKmT6g6JYtPcn1eHlEW(object_);
			}
			NhXhYs6IRFPyQRbYUMV(object_);
			try
			{
				if (!addedHandler)
				{
					c3697s6dIbHEnXP3udn(CmLmvR6ocWgxFvMXTSN(), (object)(ShutdownEventHandler)delegate
					{
						if (((WindowsFormsApplicationBase)CmLmvR6ocWgxFvMXTSN()).get_SaveMySettingsOnExit())
						{
							OdU5s76OIiRn4LtSIHk(Kp3oIE6plmLO08qGSCc());
						}
					});
					csljVC6HjnfOsLXNriy();
					if (Rbt9Le6eMwJ9MQsS1Q2())
					{
						addedHandler = true;
					}
				}
			}
			finally
			{
				KeWenc6gCQY4c4Kq9yF(object_);
			}
			goto IL_0061;
			IL_0061:
			return defaultInstance;
		}
	}

	public MySettings()
	{
		p7M9W46vv5v13dfr8rO(this);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerNonUserCode]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		if (((WindowsFormsApplicationBase)CmLmvR6ocWgxFvMXTSN()).get_SaveMySettingsOnExit())
		{
			OdU5s76OIiRn4LtSIHk(Kp3oIE6plmLO08qGSCc());
		}
	}

	internal static object zhqZUl6ch15etYWCeRF(object object_0)
	{
		return SettingsBase.Synchronized((SettingsBase)object_0);
	}

	internal static object c8p6mH6ZegujclddjM5(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}

	internal static bool Rbt9Le6eMwJ9MQsS1Q2()
	{
		return true;
	}

	internal static bool csljVC6HjnfOsLXNriy()
	{
		return false;
	}

	internal static void p7M9W46vv5v13dfr8rO(object object_0)
	{
		((ApplicationSettingsBase)object_0)._002Ector();
	}

	internal static object CmLmvR6ocWgxFvMXTSN()
	{
		return i2e7bM2YvUOxUiJcWX.PQ6FVMEjI;
	}

	internal static object Kp3oIE6plmLO08qGSCc()
	{
		return MySettingsProperty.Settings;
	}

	internal static void OdU5s76OIiRn4LtSIHk(object object_0)
	{
		((ApplicationSettingsBase)object_0).Save();
	}

	internal static void wKmT6g6JYtPcn1eHlEW(object object_0)
	{
		ObjectFlowControl.CheckForSyncLockOnValueType(object_0);
	}

	internal static void NhXhYs6IRFPyQRbYUMV(object object_0)
	{
		Monitor.Enter(object_0);
	}

	internal static void c3697s6dIbHEnXP3udn(object object_0, object object_1)
	{
		((WindowsFormsApplicationBase)object_0).add_Shutdown((ShutdownEventHandler)object_1);
	}

	internal static void KeWenc6gCQY4c4Kq9yF(object object_0)
	{
		Monitor.Exit(object_0);
	}
}
