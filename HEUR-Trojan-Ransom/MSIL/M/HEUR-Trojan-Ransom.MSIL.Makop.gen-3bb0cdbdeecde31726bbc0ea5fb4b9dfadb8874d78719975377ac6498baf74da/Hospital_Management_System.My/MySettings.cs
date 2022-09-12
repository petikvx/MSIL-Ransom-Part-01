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

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)(object)MySettings.smethod_0((SettingsBase)(object)new MySettings());

	private static bool addedHandler;

	private static object addedHandlerLockObject;

	public static MySettings Default
	{
		get
		{
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Expected O, but got Unknown
			bool flag2 = default(bool);
			object object_ = default(object);
			MySettings result = default(MySettings);
			while (true)
			{
				int num = 1750315964;
				while (true)
				{
					int num6;
					uint num2;
					switch ((num2 = (uint)num ^ 0x443ABE82u) % 5u)
					{
					case 4u:
						flag2 = !addedHandler;
						num = ((int)num2 * -504990652) ^ -2110824035;
						continue;
					case 2u:
						if (flag2)
						{
							num = (int)(num2 * 632633280) ^ -2039380875;
							continue;
						}
						goto IL_019b;
					case 0u:
						object_ = addedHandlerLockObject;
						MySettings.smethod_5(object_);
						num = ((int)num2 * -1241775549) ^ 0x76938A5D;
						continue;
					case 3u:
						break;
					default:
						{
							MySettings.smethod_6(object_);
							try
							{
								bool flag = !addedHandler;
								while (true)
								{
									IL_013a:
									int num3 = 1532288543;
									while (true)
									{
										switch ((num2 = (uint)num3 ^ 0x443ABE82u) % 7u)
										{
										case 6u:
											MySettings.smethod_7((WindowsFormsApplicationBase)(object)MyProject.Application, (ShutdownEventHandler)delegate
											{
												bool flag3 = default(bool);
												while (true)
												{
													int num7 = -1960877676;
													while (true)
													{
														uint num8;
														switch ((num8 = (uint)num7 ^ 0x9B932057u) % 6u)
														{
														case 5u:
															flag3 = MySettings.smethod_3((WindowsFormsApplicationBase)(object)MyProject.Application);
															num7 = (int)(num8 * 280031407) ^ -1182906716;
															continue;
														case 4u:
															num7 = (int)(num8 * 1004499892) ^ -1325633152;
															continue;
														case 2u:
														{
															int num9;
															int num10;
															if (!flag3)
															{
																num9 = -56884382;
																num10 = -56884382;
															}
															else
															{
																num9 = -1215098362;
																num10 = -1215098362;
															}
															num7 = num9 ^ ((int)num8 * -1400855265);
															continue;
														}
														case 1u:
															MySettings.smethod_4((ApplicationSettingsBase)(object)MySettingsProperty.Settings);
															num7 = ((int)num8 * -2141490186) ^ -1820579891;
															continue;
														default:
															return;
														case 0u:
															break;
														case 3u:
															return;
														}
														break;
													}
												}
											});
											num3 = ((int)num2 * -83373698) ^ 0x4C3AB018;
											continue;
										case 5u:
											num3 = (int)((num2 * 267959572) ^ 0xA95FDB4);
											continue;
										case 4u:
											addedHandler = true;
											num3 = (int)((num2 * 1412094841) ^ 0x3F859EA6);
											continue;
										case 3u:
											num3 = (int)(num2 * 962520123) ^ -1188102394;
											continue;
										case 1u:
										{
											int num4;
											int num5;
											if (flag)
											{
												num4 = 849321695;
												num5 = 849321695;
											}
											else
											{
												num4 = 870965353;
												num5 = 870965353;
											}
											num3 = num4 ^ (int)(num2 * 75456917);
											continue;
										}
										default:
											goto end_IL_010c;
										case 2u:
											break;
										case 0u:
											goto end_IL_010c;
										}
										goto IL_013a;
										continue;
										end_IL_010c:
										break;
									}
									break;
								}
							}
							finally
							{
								MySettings.smethod_8(object_);
							}
							goto IL_014a;
						}
						IL_019b:
						num6 = 1420038939;
						goto IL_0175;
						IL_0175:
						while (true)
						{
							switch ((num2 = (uint)num6 ^ 0x443ABE82u) % 5u)
							{
							case 2u:
								break;
							case 1u:
								num6 = ((int)num2 * -538132308) ^ -413429920;
								continue;
							case 0u:
								result = defaultInstance;
								num6 = (int)(num2 * 407503840) ^ -1344532177;
								continue;
							case 4u:
								goto IL_019b;
							default:
								return result;
							}
							break;
						}
						goto IL_014a;
						IL_014a:
						num6 = 72633187;
						goto IL_0175;
					}
					break;
				}
			}
		}
	}

	static MySettings()
	{
		while (true)
		{
			int num = 63213147;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6C4A13DDu) % 3u)
				{
				case 1u:
					goto IL_0016;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0016:
				addedHandlerLockObject = MySettings.smethod_2(MySettings.smethod_1());
				num = ((int)num2 * -392592620) ^ 0x26B54974;
			}
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		bool flag = default(bool);
		while (true)
		{
			int num = -1960877676;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9B932057u) % 6u)
				{
				case 5u:
					flag = MySettings.smethod_3((WindowsFormsApplicationBase)(object)MyProject.Application);
					num = (int)(num2 * 280031407) ^ -1182906716;
					continue;
				case 4u:
					num = (int)(num2 * 1004499892) ^ -1325633152;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = -56884382;
						num4 = -56884382;
					}
					else
					{
						num3 = -1215098362;
						num4 = -1215098362;
					}
					num = num3 ^ ((int)num2 * -1400855265);
					continue;
				}
				case 1u:
					MySettings.smethod_4((ApplicationSettingsBase)(object)MySettingsProperty.Settings);
					num = ((int)num2 * -2141490186) ^ -1820579891;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
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

	static void smethod_6(object object_0)
	{
		Monitor.Enter(object_0);
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
