using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using eJnHnFFEpEmlCQmkVB;

namespace Eddy.My;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
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
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected O, but got Unknown
			if (!addedHandler)
			{
				WAn2cJ3esBioXLmDwUM();
				object object_ = default(object);
				if (!V9jIJ43v7rGrnukTEX4())
				{
					object_ = addedHandlerLockObject;
				}
				PqiUbV3FjasaIiMO2ld(object_);
				D3Fogb3Jsh0qnNyeha5(object_);
				try
				{
					if (!addedHandler)
					{
						oix46b3t1ooZ5TZqTOk(gE6xmR3rcYEeMrvB62u(), (object)(ShutdownEventHandler)delegate
						{
							if (tTtNJL3EYPuWrlNT1iy(gE6xmR3rcYEeMrvB62u()))
							{
								XQLRoN3CLVoXrCyk519(uSWSCB323sCTpiSeeU9());
							}
						});
						_ = 0;
						if (WAn2cJ3esBioXLmDwUM())
						{
							if (V9jIJ43v7rGrnukTEX4())
							{
							}
							switch (2)
							{
							case 0:
							case 2:
								addedHandler = true;
								break;
							case 1:
							case 3:
								break;
							}
						}
					}
				}
				finally
				{
					qV7Uw23YmcQAtTD8Npo(object_);
				}
			}
			return defaultInstance;
		}
	}

	static MySettings()
	{
		V9jIJ43v7rGrnukTEX4();
		if (WAn2cJ3esBioXLmDwUM())
		{
			C14Xkk3OKn2rn4LDglp();
		}
		defaultInstance = (MySettings)RsQHlS3ZmH5UJN38TFw(new MySettings());
		addedHandlerLockObject = Agbo253dTxOOKKmkbYk(new object());
	}

	public MySettings()
	{
		C14Xkk3OKn2rn4LDglp();
		HyAwKT3RMbCFturnD8I(this);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerNonUserCode]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		if (tTtNJL3EYPuWrlNT1iy(gE6xmR3rcYEeMrvB62u()))
		{
			XQLRoN3CLVoXrCyk519(uSWSCB323sCTpiSeeU9());
		}
	}

	internal static void C14Xkk3OKn2rn4LDglp()
	{
		eWK97ZHZd8El3E8K9m.FwXDxNafX7Lru();
	}

	internal static object RsQHlS3ZmH5UJN38TFw(object object_0)
	{
		return SettingsBase.Synchronized((SettingsBase)object_0);
	}

	internal static object Agbo253dTxOOKKmkbYk(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}

	internal static bool WAn2cJ3esBioXLmDwUM()
	{
		return true;
	}

	internal static bool V9jIJ43v7rGrnukTEX4()
	{
		return false;
	}

	internal static void HyAwKT3RMbCFturnD8I(object object_0)
	{
		((ApplicationSettingsBase)object_0)._002Ector();
	}

	internal static object gE6xmR3rcYEeMrvB62u()
	{
		return MyProject.Application;
	}

	internal static bool tTtNJL3EYPuWrlNT1iy(object object_0)
	{
		return ((WindowsFormsApplicationBase)object_0).get_SaveMySettingsOnExit();
	}

	internal static object uSWSCB323sCTpiSeeU9()
	{
		return MySettingsProperty.Settings;
	}

	internal static void XQLRoN3CLVoXrCyk519(object object_0)
	{
		((ApplicationSettingsBase)object_0).Save();
	}

	internal static void PqiUbV3FjasaIiMO2ld(object object_0)
	{
		ObjectFlowControl.CheckForSyncLockOnValueType(object_0);
	}

	internal static void D3Fogb3Jsh0qnNyeha5(object object_0)
	{
		Monitor.Enter(object_0);
	}

	internal static void oix46b3t1ooZ5TZqTOk(object object_0, object object_1)
	{
		((WindowsFormsApplicationBase)object_0).add_Shutdown((ShutdownEventHandler)object_1);
	}

	internal static void qV7Uw23YmcQAtTD8Npo(object object_0)
	{
		Monitor.Exit(object_0);
	}
}
