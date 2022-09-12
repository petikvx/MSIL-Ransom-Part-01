using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Hospital_Management_System.My;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.0.0.0")]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)(object)MySettings.smethod_0((SettingsBase)(object)new MySettings());

	private static bool addedHandler;

	private static object addedHandlerLockObject = MySettings.smethod_2(MySettings.smethod_1());

	public static MySettings Default
	{
		get
		{
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected O, but got Unknown
			object object_ = default(object);
			bool flag2 = default(bool);
			bool flag = default(bool);
			MySettings result = default(MySettings);
			while (true)
			{
				int num = 1173579142;
				while (true)
				{
					int num7;
					uint num2;
					switch ((num2 = (uint)num ^ 0x2E7162FCu) % 5u)
					{
					case 4u:
						object_ = addedHandlerLockObject;
						num = ((int)num2 * -510483824) ^ 0x629FFF5C;
						continue;
					case 2u:
						if (flag2)
						{
							num = (int)(num2 * 1033880179) ^ -560691408;
							continue;
						}
						goto IL_01eb;
					case 1u:
						flag2 = !addedHandler;
						num = (int)(num2 * 517577221) ^ -1872448305;
						continue;
					case 3u:
						break;
					default:
						{
							MySettings.smethod_5(object_);
							bool bool_ = false;
							try
							{
								MySettings.smethod_6(object_, ref bool_);
								while (true)
								{
									IL_0166:
									int num3 = 8063756;
									while (true)
									{
										switch ((num2 = (uint)num3 ^ 0x2E7162FCu) % 9u)
										{
										case 8u:
											num3 = 2107073303;
											continue;
										case 5u:
											num3 = ((int)num2 * -1009521398) ^ -1784489007;
											continue;
										case 4u:
										{
											int num4;
											int num5;
											if (flag)
											{
												num4 = -488935466;
												num5 = -488935466;
											}
											else
											{
												num4 = -1019050365;
												num5 = -1019050365;
											}
											num3 = num4 ^ ((int)num2 * -1346635223);
											continue;
										}
										case 3u:
											MySettings.smethod_7((WindowsFormsApplicationBase)(object)MyProject.Application, (ShutdownEventHandler)delegate
											{
												if (MySettings.smethod_3((WindowsFormsApplicationBase)(object)MyProject.Application))
												{
													goto IL_000c;
												}
												goto IL_005e;
												IL_005e:
												int num8 = -1067610649;
												goto IL_0039;
												IL_0039:
												while (true)
												{
													uint num9;
													switch ((num9 = (uint)num8 ^ 0x82836EAAu) % 5u)
													{
													case 4u:
														break;
													case 3u:
														num8 = ((int)num9 * -256160424) ^ -1807812177;
														continue;
													case 1u:
														MySettings.smethod_4((ApplicationSettingsBase)(object)MySettingsProperty.Settings);
														num8 = (int)(num9 * 1176323171) ^ -969577065;
														continue;
													default:
														return;
													case 0u:
														goto IL_005e;
													case 2u:
														return;
													}
													break;
												}
												goto IL_000c;
												IL_000c:
												num8 = -606483306;
												goto IL_0039;
											});
											num3 = (int)(num2 * 1319610553) ^ -1362915246;
											continue;
										case 2u:
											num3 = ((int)num2 * -465243079) ^ 0x3745C372;
											continue;
										case 1u:
											flag = !addedHandler;
											num3 = ((int)num2 * -869866177) ^ -1860386606;
											continue;
										case 0u:
											addedHandler = true;
											num3 = ((int)num2 * -638548245) ^ -937088297;
											continue;
										default:
											goto end_IL_012f;
										case 7u:
											break;
										case 6u:
											goto end_IL_012f;
										}
										goto IL_0166;
										continue;
										end_IL_012f:
										break;
									}
									break;
								}
							}
							finally
							{
								if (bool_)
								{
									while (true)
									{
										IL_01a6:
										int num6 = 1104209203;
										while (true)
										{
											switch ((num2 = (uint)num6 ^ 0x2E7162FCu) % 3u)
											{
											case 2u:
												goto IL_0174;
											default:
												goto end_IL_0188;
											case 0u:
												break;
											case 1u:
												goto end_IL_0188;
											}
											goto IL_01a6;
											IL_0174:
											MySettings.smethod_8(object_);
											num6 = (int)((num2 * 1033887935) ^ 0x48371826);
											continue;
											end_IL_0188:
											break;
										}
										break;
									}
								}
							}
							goto IL_01ae;
						}
						IL_01eb:
						num7 = 923630881;
						goto IL_01c9;
						IL_01c9:
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x2E7162FCu) % 4u)
							{
							case 3u:
								break;
							case 1u:
								result = defaultInstance;
								num7 = ((int)num2 * -1773397644) ^ -778808000;
								continue;
							case 2u:
								goto IL_01eb;
							default:
								return result;
							}
							break;
						}
						goto IL_01ae;
						IL_01ae:
						num7 = 1027039742;
						goto IL_01c9;
					}
					break;
				}
			}
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		if (MySettings.smethod_3((WindowsFormsApplicationBase)(object)MyProject.Application))
		{
			goto IL_000c;
		}
		goto IL_005e;
		IL_005e:
		int num = -1067610649;
		goto IL_0039;
		IL_0039:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x82836EAAu) % 5u)
			{
			case 4u:
				break;
			case 3u:
				num = ((int)num2 * -256160424) ^ -1807812177;
				continue;
			case 1u:
				MySettings.smethod_4((ApplicationSettingsBase)(object)MySettingsProperty.Settings);
				num = (int)(num2 * 1176323171) ^ -969577065;
				continue;
			default:
				return;
			case 0u:
				goto IL_005e;
			case 2u:
				return;
			}
			break;
		}
		goto IL_000c;
		IL_000c:
		num = -606483306;
		goto IL_0039;
	}

	static SettingsBase smethod_0(SettingsBase settingsBase_0)
	{
		return SettingsBase.Synchronized(settingsBase_0);
	}

	static object smethod_1()
	{
		return new object();
	}

	static object smethod_2(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}

	static bool smethod_3(WindowsFormsApplicationBase windowsFormsApplicationBase_0)
	{
		return windowsFormsApplicationBase_0.get_SaveMySettingsOnExit();
	}

	static void smethod_4(ApplicationSettingsBase applicationSettingsBase_0)
	{
		applicationSettingsBase_0.Save();
	}

	static void smethod_5(object object_0)
	{
		ObjectFlowControl.CheckForSyncLockOnValueType(object_0);
	}

	static void smethod_6(object object_0, ref bool bool_0)
	{
		Monitor.Enter(object_0, ref bool_0);
	}

	static void smethod_7(WindowsFormsApplicationBase windowsFormsApplicationBase_0, ShutdownEventHandler shutdownEventHandler_0)
	{
		windowsFormsApplicationBase_0.add_Shutdown(shutdownEventHandler_0);
	}

	static void smethod_8(object object_0)
	{
		Monitor.Exit(object_0);
	}
}
