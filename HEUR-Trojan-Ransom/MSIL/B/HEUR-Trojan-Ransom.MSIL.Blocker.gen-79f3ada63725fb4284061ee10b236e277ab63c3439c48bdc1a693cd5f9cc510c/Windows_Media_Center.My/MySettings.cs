using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using B8a70nfPcJ9DoGa12G;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Xvc5U9juJtLRxdMpm8;

namespace Windows_Media_Center.My;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance;

	private static bool addedHandler;

	private static object addedHandlerLockObject;

	public static MySettings Default
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//Discarded unreachable code: IL_0002, IL_0033, IL_00de
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Expected O, but got Unknown
			while (false)
			{
				_ = ((object[])null)[0];
			}
			o5Is8TGBWwZlFLSaj7d();
			int num;
			if (!KtEGcEGXBqyTioigxpk())
			{
				num = 4;
			}
			else
			{
				num = 5;
				if (!o5Is8TGBWwZlFLSaj7d())
				{
					goto IL_0077;
				}
			}
			goto IL_0040;
			IL_0040:
			object obj = default(object);
			bool lockTaken = default(bool);
			while (true)
			{
				switch (num)
				{
				case 1:
					LAFfs3G9XrNtsKiyIuc(obj);
					break;
				case 2:
					obj = addedHandlerLockObject;
					num = 1;
					continue;
				case 0:
				case 4:
					if (!addedHandler)
					{
						num = 2;
						continue;
					}
					goto IL_014c;
				case 6:
					{
						try
						{
							Monitor.Enter(obj, ref lockTaken);
							_ = 1;
							int num2 = (KtEGcEGXBqyTioigxpk() ? 3 : 2);
							while (true)
							{
								switch (num2)
								{
								case 0:
								case 2:
									if (!addedHandler)
									{
										break;
									}
									goto end_IL_00eb;
								case 4:
									addedHandler = true;
									goto end_IL_00eb;
								}
								vuvKIUGO4AvGgQvtLFH(eNtEvJGayUNy11bdTAM(), (object)(ShutdownEventHandler)delegate
								{
									//Discarded unreachable code: IL_0002
									while (false)
									{
										_ = ((object[])null)[0];
									}
									if (hudJLxGHsGeLwmfpTRj(eNtEvJGayUNy11bdTAM()))
									{
										B0Ws0KGIHrIYmXmbZnq(q4xXGJG7gaO5naCtL5K());
									}
								});
								num2 = 4;
								continue;
								end_IL_00eb:
								break;
							}
						}
						finally
						{
							if (lockTaken)
							{
								eNNWTrGWeIcIeWx9JPW(obj);
							}
						}
						goto IL_014c;
					}
					IL_014c:
					return defaultInstance;
				}
				break;
			}
			goto IL_0077;
			IL_0077:
			lockTaken = false;
			num = 6;
			if (KtEGcEGXBqyTioigxpk())
			{
			}
			goto IL_0040;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MySettings()
	{
		//Discarded unreachable code: IL_0002, IL_0071
		while (false)
		{
			_ = ((object[])null)[0];
		}
		o5Is8TGBWwZlFLSaj7d();
		int num;
		if (!KtEGcEGXBqyTioigxpk())
		{
			num = 4;
		}
		else
		{
			num = 2;
			if (false)
			{
				goto IL_003f;
			}
		}
		goto IL_007e;
		IL_007e:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				a154EcGo5wXXIwDNjom();
				goto case 1;
			case 3:
				break;
			case 1:
			case 2:
				defaultInstance = (MySettings)jJhiofGLKaRhttIobDU(new MySettings());
				break;
			default:
				goto IL_009b;
			case 5:
				return;
			}
			break;
			IL_009b:
			num = 3;
			if (!o5Is8TGBWwZlFLSaj7d())
			{
				return;
			}
		}
		goto IL_003f;
		IL_003f:
		addedHandlerLockObject = NpFewUG39B9SQVyJCUx(new object());
		num = 5;
		goto IL_007e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MySettings()
	{
		//Discarded unreachable code: IL_0002
		while (false)
		{
			_ = ((object[])null)[0];
		}
		a154EcGo5wXXIwDNjom();
		aNRmmuG6JDLcne041jF(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerNonUserCode]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0002
		while (false)
		{
			_ = ((object[])null)[0];
		}
		if (hudJLxGHsGeLwmfpTRj(eNtEvJGayUNy11bdTAM()))
		{
			B0Ws0KGIHrIYmXmbZnq(q4xXGJG7gaO5naCtL5K());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void a154EcGo5wXXIwDNjom()
	{
		//Discarded unreachable code: IL_0002
		while (false)
		{
			_ = ((object[])null)[0];
		}
		OGo1ZL8D0rpYTyrF8W.YQ2vTpjz4AREP();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object jJhiofGLKaRhttIobDU(object P_0)
	{
		//Discarded unreachable code: IL_0002
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return SettingsBase.Synchronized((SettingsBase)P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object NpFewUG39B9SQVyJCUx(object P_0)
	{
		//Discarded unreachable code: IL_0002
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return RuntimeHelpers.GetObjectValue(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool o5Is8TGBWwZlFLSaj7d()
	{
		//Discarded unreachable code: IL_0002
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool KtEGcEGXBqyTioigxpk()
	{
		//Discarded unreachable code: IL_0002
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void aNRmmuG6JDLcne041jF(object P_0)
	{
		//Discarded unreachable code: IL_0002
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ApplicationSettingsBase)P_0)._002Ector();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object eNtEvJGayUNy11bdTAM()
	{
		//Discarded unreachable code: IL_0002
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return nJOkOiI03Joq9eJ9vx.FeqDFiQRm;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool hudJLxGHsGeLwmfpTRj(object P_0)
	{
		//Discarded unreachable code: IL_0002
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return ((WindowsFormsApplicationBase)P_0).get_SaveMySettingsOnExit();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object q4xXGJG7gaO5naCtL5K()
	{
		//Discarded unreachable code: IL_0002
		while (false)
		{
			_ = ((object[])null)[0];
		}
		return MySettingsProperty.Settings;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void B0Ws0KGIHrIYmXmbZnq(object P_0)
	{
		//Discarded unreachable code: IL_0002
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((ApplicationSettingsBase)P_0).Save();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LAFfs3G9XrNtsKiyIuc(object P_0)
	{
		//Discarded unreachable code: IL_0002
		while (false)
		{
			_ = ((object[])null)[0];
		}
		ObjectFlowControl.CheckForSyncLockOnValueType(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void vuvKIUGO4AvGgQvtLFH(object P_0, object P_1)
	{
		//Discarded unreachable code: IL_0002
		while (false)
		{
			_ = ((object[])null)[0];
		}
		((WindowsFormsApplicationBase)P_0).add_Shutdown((ShutdownEventHandler)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void eNNWTrGWeIcIeWx9JPW(object P_0)
	{
		//Discarded unreachable code: IL_0002
		while (false)
		{
			_ = ((object[])null)[0];
		}
		Monitor.Exit(P_0);
	}
}
