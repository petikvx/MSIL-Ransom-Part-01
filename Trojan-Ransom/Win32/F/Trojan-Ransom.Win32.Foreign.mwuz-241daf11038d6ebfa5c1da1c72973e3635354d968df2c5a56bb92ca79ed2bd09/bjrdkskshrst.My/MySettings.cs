using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using RBkA0En6hx3Ki971At;

namespace bjrdkskshrst.My;

[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)wgkGMHn75q2F7yduQD(new MySettings());

	private static bool addedHandler;

	private static object addedHandlerLockObject = Oxx5lMdUpeYSVh1d9B(new object());

	public static MySettings Default
	{
		get
		{
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			if (!addedHandler)
			{
				_ = 1;
				object object_ = default(object);
				if (!cbEpcV0VZnlhDe4KHi())
				{
					object_ = addedHandlerLockObject;
					iqn6Io8iHGIrdEtyCV(object_);
				}
				j33kgcVrjslCJBAgYp(object_);
				try
				{
					if (!addedHandler)
					{
						QBuMZBtoxKaQPvfHhJ(Vtl02FUvCrDvQ5eskd.pOPaKYRE1, (object)(ShutdownEventHandler)delegate
						{
							if (((WindowsFormsApplicationBase)Vtl02FUvCrDvQ5eskd.pOPaKYRE1).get_SaveMySettingsOnExit())
							{
								zIeuXsjhnbQhAKWHJP(MySettingsProperty.Settings);
							}
						});
						_ = 1;
						if (!cbEpcV0VZnlhDe4KHi())
						{
							if (!cbEpcV0VZnlhDe4KHi())
							{
								switch (2)
								{
								default:
									goto end_IL_0025;
								case 0:
								case 2:
									break;
								case 1:
								case 3:
									goto end_IL_0025;
								}
							}
							addedHandler = true;
						}
					}
					end_IL_0025:;
				}
				finally
				{
					LhiWe1M18yJUCI9Isi(object_);
				}
			}
			return defaultInstance;
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		if (((WindowsFormsApplicationBase)Vtl02FUvCrDvQ5eskd.pOPaKYRE1).get_SaveMySettingsOnExit())
		{
			zIeuXsjhnbQhAKWHJP(MySettingsProperty.Settings);
		}
	}

	internal static object wgkGMHn75q2F7yduQD(object object_0)
	{
		return SettingsBase.Synchronized((SettingsBase)object_0);
	}

	internal static object Oxx5lMdUpeYSVh1d9B(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}

	internal static bool Wapa1McXgFq0q8s7ZS()
	{
		return true;
	}

	internal static bool cbEpcV0VZnlhDe4KHi()
	{
		return false;
	}

	internal static void zIeuXsjhnbQhAKWHJP(object object_0)
	{
		((ApplicationSettingsBase)object_0).Save();
	}

	internal static void iqn6Io8iHGIrdEtyCV(object object_0)
	{
		ObjectFlowControl.CheckForSyncLockOnValueType(object_0);
	}

	internal static void j33kgcVrjslCJBAgYp(object object_0)
	{
		Monitor.Enter(object_0);
	}

	internal static void QBuMZBtoxKaQPvfHhJ(object object_0, object object_1)
	{
		((WindowsFormsApplicationBase)object_0).add_Shutdown((ShutdownEventHandler)object_1);
	}

	internal static void LhiWe1M18yJUCI9Isi(object object_0)
	{
		Monitor.Exit(object_0);
	}
}
