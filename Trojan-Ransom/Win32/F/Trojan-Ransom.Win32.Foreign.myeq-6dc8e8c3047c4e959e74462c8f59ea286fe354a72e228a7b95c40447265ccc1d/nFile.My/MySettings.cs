using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace nFile.My;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
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
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Expected O, but got Unknown
			fMuFsGg6NIh6IUSTu7();
			if (Pv4ts17xf7X21vZerl())
			{
				goto IL_0093;
			}
			goto IL_00a9;
			IL_00a9:
			object obj = addedHandlerLockObject;
			ObjectFlowControl.CheckForSyncLockOnValueType(obj);
			goto IL_009d;
			IL_009d:
			Monitor.Enter(obj);
			goto IL_0018;
			IL_0018:
			try
			{
				if (!addedHandler)
				{
					((WindowsFormsApplicationBase)MyProject.Application).add_Shutdown((ShutdownEventHandler)delegate
					{
						if (YQXRtaWsgGHvNXKXm1(MyProject.Application))
						{
							((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
						}
					});
					_ = 1;
					if (!fMuFsGg6NIh6IUSTu7())
					{
						addedHandler = true;
					}
				}
			}
			finally
			{
				IwEHSLpZ5ZfYeXTgBO(obj);
			}
			goto IL_007f;
			IL_007f:
			MySettings result = defaultInstance;
			int num = 6;
			if (Pv4ts17xf7X21vZerl())
			{
				while (true)
				{
					switch (num)
					{
					case 4:
						break;
					default:
						num = 4;
						if (!fMuFsGg6NIh6IUSTu7())
						{
							continue;
						}
						goto IL_00a9;
					case 0:
					case 2:
						goto IL_0093;
					case 5:
						goto IL_009d;
					case 1:
					case 3:
						goto IL_00a9;
					case 6:
						return result;
					}
					break;
				}
				goto IL_0018;
			}
			goto IL_009d;
			IL_0093:
			if (addedHandler)
			{
				goto IL_007f;
			}
			goto IL_00a9;
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		if (YQXRtaWsgGHvNXKXm1(MyProject.Application))
		{
			((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
		}
	}

	internal static bool Pv4ts17xf7X21vZerl()
	{
		return true;
	}

	internal static bool fMuFsGg6NIh6IUSTu7()
	{
		return false;
	}

	internal static bool YQXRtaWsgGHvNXKXm1(object object_0)
	{
		return ((WindowsFormsApplicationBase)object_0).get_SaveMySettingsOnExit();
	}

	internal static void IwEHSLpZ5ZfYeXTgBO(object object_0)
	{
		Monitor.Exit(object_0);
	}
}
