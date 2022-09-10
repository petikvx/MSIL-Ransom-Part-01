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

namespace GOL.My;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)smethod_0(new MySettings());

	private static bool addedHandler;

	private static object addedHandlerLockObject;

	public static MySettings Default
	{
		get
		{
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Expected O, but got Unknown
			bool flag = !addedHandler;
			smethod_3();
			object object_ = default(object);
			if (smethod_2())
			{
				if (!flag)
				{
					goto IL_00ab;
				}
				object_ = addedHandlerLockObject;
			}
			smethod_9(object_);
			smethod_10(object_);
			try
			{
				bool flag2 = !addedHandler;
				_ = 0;
				if (smethod_2())
				{
					goto IL_007e;
				}
				int num = 3;
				if (!smethod_2())
				{
					goto IL_0053;
				}
				goto IL_0083;
				IL_0053:
				addedHandler = true;
				num = 5;
				if (!smethod_2())
				{
					goto IL_0066;
				}
				goto IL_0083;
				IL_0083:
				switch (num)
				{
				case 1:
				case 3:
					goto IL_0066;
				case 0:
				case 2:
					goto IL_007e;
				case 5:
					goto end_IL_0031;
				}
				goto IL_0053;
				IL_007e:
				if (flag2)
				{
					goto IL_0066;
				}
				goto end_IL_0031;
				IL_0066:
				smethod_11(smethod_5(), (object)(ShutdownEventHandler)delegate
				{
					smethod_3();
					if (!smethod_2())
					{
						goto IL_0010;
					}
					goto IL_0045;
					IL_0010:
					while (true)
					{
						smethod_8(smethod_7());
						if (!smethod_3())
						{
							switch (5)
							{
							case 0:
							case 1:
								goto end_IL_0010;
							case 5:
								goto IL_0053;
							case 4:
								goto IL_0056;
							}
							continue;
						}
						goto IL_0053;
						IL_0053:
						if (true)
						{
							return;
						}
						goto IL_0056;
						continue;
						end_IL_0010:
						break;
					}
					goto IL_0045;
					IL_0056:
					bool flag3 = default(bool);
					if (!flag3)
					{
						return;
					}
					goto IL_0010;
					IL_0045:
					flag3 = smethod_6(smethod_5());
					goto IL_0056;
				});
				goto IL_0053;
				end_IL_0031:;
			}
			finally
			{
				smethod_12(object_);
			}
			goto IL_00ab;
			IL_00ab:
			return defaultInstance;
		}
	}

	static MySettings()
	{
		for (int num = 0; num == 0; num = 1)
		{
			addedHandlerLockObject = smethod_1(new object());
		}
	}

	public MySettings()
	{
		smethod_4(this);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerNonUserCode]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		smethod_3();
		if (!smethod_2())
		{
			goto IL_0010;
		}
		goto IL_0045;
		IL_0010:
		while (true)
		{
			smethod_8(smethod_7());
			if (!smethod_3())
			{
				switch (5)
				{
				case 0:
				case 1:
					goto end_IL_0010;
				case 5:
					goto IL_0053;
				case 4:
					goto IL_0056;
				}
				continue;
			}
			goto IL_0053;
			IL_0053:
			if (true)
			{
				return;
			}
			goto IL_0056;
			continue;
			end_IL_0010:
			break;
		}
		goto IL_0045;
		IL_0056:
		bool flag = default(bool);
		if (flag)
		{
			goto IL_0010;
		}
		return;
		IL_0045:
		flag = smethod_6(smethod_5());
		goto IL_0056;
	}

	internal static object smethod_0(object object_0)
	{
		return SettingsBase.Synchronized((SettingsBase)object_0);
	}

	internal static object smethod_1(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static bool smethod_3()
	{
		return false;
	}

	internal static void smethod_4(object object_0)
	{
		((ApplicationSettingsBase)object_0)._002Ector();
	}

	internal static object smethod_5()
	{
		return Class2.Form0_0;
	}

	internal static bool smethod_6(object object_0)
	{
		return ((WindowsFormsApplicationBase)object_0).get_SaveMySettingsOnExit();
	}

	internal static object smethod_7()
	{
		return MySettingsProperty.Settings;
	}

	internal static void smethod_8(object object_0)
	{
		((ApplicationSettingsBase)object_0).Save();
	}

	internal static void smethod_9(object object_0)
	{
		ObjectFlowControl.CheckForSyncLockOnValueType(object_0);
	}

	internal static void smethod_10(object object_0)
	{
		Monitor.Enter(object_0);
	}

	internal static void smethod_11(object object_0, object object_1)
	{
		((WindowsFormsApplicationBase)object_0).add_Shutdown((ShutdownEventHandler)object_1);
	}

	internal static void smethod_12(object object_0)
	{
		Monitor.Exit(object_0);
	}
}
