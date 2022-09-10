using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Maxi.My;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
[CompilerGenerated]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());

	private static bool addedHandler;

	private static object addedHandlerLockObject = S3wENLoKx9tbAGYbLZh(new object());

	public static MySettings Default
	{
		get
		{
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected O, but got Unknown
			int num = 2;
			object obj = default(object);
			if (mLs6P8oIBC7x4u41Yjk())
			{
				bool flag = default(bool);
				MySettings result = default(MySettings);
				while (true)
				{
					switch (num)
					{
					case 2:
						flag = !addedHandler;
						_ = 1;
						if (!W2JTIfojP3ZBi7Wgo9d())
						{
							num = 7;
							if (!W2JTIfojP3ZBi7Wgo9d())
							{
								continue;
							}
							goto case 6;
						}
						goto default;
					case 1:
					case 7:
						if (flag)
						{
							goto case 6;
						}
						goto IL_00f7;
					case 6:
						obj = addedHandlerLockObject;
						goto case 3;
					case 3:
						J3iYscoiAItEpMxW28I(obj);
						goto default;
					default:
						EoXx0PoW9Zdta88QE2m(obj);
						break;
					case 5:
						break;
					case 8:
						return result;
					}
					break;
				}
			}
			try
			{
				bool flag = !addedHandler;
				mLs6P8oIBC7x4u41Yjk();
				if (!W2JTIfojP3ZBi7Wgo9d())
				{
					goto IL_00d2;
				}
				goto IL_00d5;
				IL_00d5:
				while (true)
				{
					IL_00d5_2:
					hHHd2JoUsGJpue3xoF7(U9V6teo9tlU92C0cH0E(), (object)(ShutdownEventHandler)delegate
					{
						bool saveMySettingsOnExit = ((WindowsFormsApplicationBase)MyProject.Application).get_SaveMySettingsOnExit();
						_ = 1;
						if (W2JTIfojP3ZBi7Wgo9d() || saveMySettingsOnExit)
						{
							ai16pFovB7rgbZKEyox(npGAIIoHkdhMk7Ntkjm());
						}
					});
					while (true)
					{
						addedHandler = true;
						int num2 = 5;
						if (!mLs6P8oIBC7x4u41Yjk())
						{
							break;
						}
						while (true)
						{
							switch (num2)
							{
							default:
								num2 = 2;
								if (mLs6P8oIBC7x4u41Yjk())
								{
									continue;
								}
								break;
							case 2:
								break;
							case 0:
							case 3:
								goto IL_00d2;
							case 1:
							case 4:
								goto IL_00d5_2;
							case 5:
								goto end_IL_00be;
							}
							break;
						}
						continue;
						end_IL_00be:
						break;
					}
					break;
				}
				goto end_IL_0077;
				IL_00d2:
				if (flag)
				{
					goto IL_00d5;
				}
				end_IL_0077:;
			}
			finally
			{
				Monitor.Exit(obj);
			}
			goto IL_00f7;
			IL_00f7:
			return defaultInstance;
		}
	}

	[DebuggerNonUserCode]
	public MySettings()
	{
		at4QBYoyECEjKaZelEp(this);
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		bool saveMySettingsOnExit = ((WindowsFormsApplicationBase)MyProject.Application).get_SaveMySettingsOnExit();
		_ = 1;
		if (W2JTIfojP3ZBi7Wgo9d() || saveMySettingsOnExit)
		{
			ai16pFovB7rgbZKEyox(npGAIIoHkdhMk7Ntkjm());
		}
	}

	internal static object S3wENLoKx9tbAGYbLZh(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}

	internal static bool mLs6P8oIBC7x4u41Yjk()
	{
		return true;
	}

	internal static bool W2JTIfojP3ZBi7Wgo9d()
	{
		return false;
	}

	internal static void at4QBYoyECEjKaZelEp(object object_0)
	{
		((ApplicationSettingsBase)object_0)._002Ector();
	}

	internal static object npGAIIoHkdhMk7Ntkjm()
	{
		return MySettingsProperty.Settings;
	}

	internal static void ai16pFovB7rgbZKEyox(object object_0)
	{
		((ApplicationSettingsBase)object_0).Save();
	}

	internal static void J3iYscoiAItEpMxW28I(object object_0)
	{
		ObjectFlowControl.CheckForSyncLockOnValueType(object_0);
	}

	internal static void EoXx0PoW9Zdta88QE2m(object object_0)
	{
		Monitor.Enter(object_0);
	}

	internal static object U9V6teo9tlU92C0cH0E()
	{
		return MyProject.Application;
	}

	internal static void hHHd2JoUsGJpue3xoF7(object object_0, object object_1)
	{
		((WindowsFormsApplicationBase)object_0).add_Shutdown((ShutdownEventHandler)object_1);
	}
}
