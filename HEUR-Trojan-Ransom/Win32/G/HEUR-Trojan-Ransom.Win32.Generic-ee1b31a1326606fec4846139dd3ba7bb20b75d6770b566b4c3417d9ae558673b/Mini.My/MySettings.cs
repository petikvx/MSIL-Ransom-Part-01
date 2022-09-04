using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using m6lLYQjWFtDlHcqEYv;

namespace Mini.My;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
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
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected O, but got Unknown
			bool flag;
			if (flag = !addedHandler)
			{
				CTCB6Ow3K1eONEK5iI8();
				object obj = default(object);
				if (!MHSkdbwdHMmhYEOEmyO())
				{
					obj = addedHandlerLockObject;
				}
				wk2bV5wnayC8g5PSwvM(obj);
				R029sIwr1RJ96jLCBH5(obj);
				try
				{
					flag = !addedHandler;
					MHSkdbwdHMmhYEOEmyO();
					if (!CTCB6Ow3K1eONEK5iI8())
					{
						goto IL_0060;
					}
					if (flag)
					{
						qBrW4Lw6cY4vNDi7nfh(n1LId7KWCl2k85cPuQ.ifnDTyv8q, (object)(ShutdownEventHandler)delegate
						{
							_ = 0;
							if (!CTCB6Ow3K1eONEK5iI8())
							{
								if (MHSkdbwdHMmhYEOEmyO())
								{
								}
								switch (2)
								{
								case 0:
								case 3:
									break;
								case 1:
								case 2:
									goto IL_0042;
								default:
									goto IL_0045;
								case 5:
									return;
								}
							}
							bool flag2 = zCdSMCw0y7K8kShUsHE(RJEEBqwaYJ6LiWX7WLs());
							goto IL_0042;
							IL_0042:
							if (!flag2)
							{
								return;
							}
							goto IL_0045;
							IL_0045:
							mvFDtCwI1kdfnwcqcdr(g4TxPgwY6ghaD8eqZd7());
						});
						goto IL_0060;
					}
					goto end_IL_002e;
					IL_0060:
					addedHandler = true;
					end_IL_002e:;
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
	public MySettings()
	{
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		_ = 0;
		if (!CTCB6Ow3K1eONEK5iI8())
		{
			if (MHSkdbwdHMmhYEOEmyO())
			{
			}
			switch (2)
			{
			case 0:
			case 3:
				break;
			case 1:
			case 2:
				goto IL_0042;
			default:
				goto IL_0045;
			case 5:
				return;
			}
		}
		bool flag = zCdSMCw0y7K8kShUsHE(RJEEBqwaYJ6LiWX7WLs());
		goto IL_0042;
		IL_0042:
		if (!flag)
		{
			return;
		}
		goto IL_0045;
		IL_0045:
		mvFDtCwI1kdfnwcqcdr(g4TxPgwY6ghaD8eqZd7());
	}

	internal static bool CTCB6Ow3K1eONEK5iI8()
	{
		return true;
	}

	internal static bool MHSkdbwdHMmhYEOEmyO()
	{
		return false;
	}

	internal static object RJEEBqwaYJ6LiWX7WLs()
	{
		return n1LId7KWCl2k85cPuQ.ifnDTyv8q;
	}

	internal static bool zCdSMCw0y7K8kShUsHE(object object_0)
	{
		return ((WindowsFormsApplicationBase)object_0).get_SaveMySettingsOnExit();
	}

	internal static object g4TxPgwY6ghaD8eqZd7()
	{
		return MySettingsProperty.Settings;
	}

	internal static void mvFDtCwI1kdfnwcqcdr(object object_0)
	{
		((ApplicationSettingsBase)object_0).Save();
	}

	internal static void wk2bV5wnayC8g5PSwvM(object object_0)
	{
		ObjectFlowControl.CheckForSyncLockOnValueType(object_0);
	}

	internal static void R029sIwr1RJ96jLCBH5(object object_0)
	{
		Monitor.Enter(object_0);
	}

	internal static void qBrW4Lw6cY4vNDi7nfh(object object_0, object object_1)
	{
		((WindowsFormsApplicationBase)object_0).add_Shutdown((ShutdownEventHandler)object_1);
	}
}
