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

	private static object addedHandlerLockObject;

	public static MySettings Default
	{
		get
		{
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Expected O, but got Unknown
			object object_ = default(object);
			bool flag2 = default(bool);
			MySettings result = default(MySettings);
			while (true)
			{
				int num = -506475158;
				while (true)
				{
					int num7;
					uint num2;
					switch ((num2 = (uint)num ^ 0x9B8E2099u) % 8u)
					{
					case 7u:
						MySettings.smethod_5(object_);
						num = (int)(num2 * 1878915237) ^ -1214589834;
						continue;
					case 6u:
						num = ((int)num2 * -1430145164) ^ 0x24B09968;
						continue;
					case 4u:
						num = (int)(num2 * 1641939869) ^ -844239440;
						continue;
					case 3u:
						flag2 = !addedHandler;
						num = ((int)num2 * -720797733) ^ 0x69C21518;
						continue;
					case 1u:
						object_ = addedHandlerLockObject;
						num = ((int)num2 * -796242953) ^ 0x527D2A61;
						continue;
					case 0u:
						if (flag2)
						{
							num = (int)(num2 * 1876875746) ^ -1131897521;
							continue;
						}
						goto IL_01f7;
					case 2u:
						break;
					default:
						{
							bool bool_ = false;
							try
							{
								MySettings.smethod_6(object_, ref bool_);
								bool flag = !addedHandler;
								while (true)
								{
									IL_0162:
									int num3 = -2146981574;
									while (true)
									{
										switch ((num2 = (uint)num3 ^ 0x9B8E2099u) % 6u)
										{
										case 5u:
										{
											int num4;
											int num5;
											if (!flag)
											{
												num4 = 925450899;
												num5 = 925450899;
											}
											else
											{
												num4 = 2068375476;
												num5 = 2068375476;
											}
											num3 = num4 ^ ((int)num2 * -1094964307);
											continue;
										}
										case 4u:
											addedHandler = true;
											num3 = ((int)num2 * -1939875532) ^ -1199308044;
											continue;
										case 3u:
											num3 = -1113748022;
											continue;
										case 0u:
											MySettings.smethod_7((WindowsFormsApplicationBase)(object)MyProject.Application, (ShutdownEventHandler)delegate
											{
												bool flag3 = MySettings.smethod_3((WindowsFormsApplicationBase)(object)MyProject.Application);
												while (true)
												{
													int num8 = -1218502303;
													while (true)
													{
														uint num9;
														switch ((num9 = (uint)num8 ^ 0xE0120BADu) % 6u)
														{
														case 5u:
															num8 = -331336776;
															continue;
														case 4u:
															MySettings.smethod_4((ApplicationSettingsBase)(object)MySettingsProperty.Settings);
															num8 = (int)((num9 * 472939108) ^ 0x7D80B068);
															continue;
														case 2u:
														{
															int num10;
															int num11;
															if (!flag3)
															{
																num10 = 1972504814;
																num11 = 1972504814;
															}
															else
															{
																num10 = 1772291881;
																num11 = 1772291881;
															}
															num8 = num10 ^ ((int)num9 * -859839923);
															continue;
														}
														case 1u:
															num8 = (int)((num9 * 226131035) ^ 0x1B135015);
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
											num3 = ((int)num2 * -1597796505) ^ 0x48C31ACF;
											continue;
										default:
											goto end_IL_0138;
										case 2u:
											break;
										case 1u:
											goto end_IL_0138;
										}
										goto IL_0162;
										continue;
										end_IL_0138:
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
										IL_01b9:
										int num6 = -525788401;
										while (true)
										{
											switch ((num2 = (uint)num6 ^ 0x9B8E2099u) % 4u)
											{
											case 3u:
												num6 = ((int)num2 * -1314757197) ^ -1988738019;
												continue;
											case 2u:
												MySettings.smethod_8(object_);
												num6 = (int)((num2 * 1275957970) ^ 0x49C8E6BE);
												continue;
											default:
												goto end_IL_0197;
											case 0u:
												break;
											case 1u:
												goto end_IL_0197;
											}
											goto IL_01b9;
											continue;
											end_IL_0197:
											break;
										}
										break;
									}
								}
							}
							goto IL_0226;
						}
						IL_01f7:
						num7 = -2031168590;
						goto IL_01fc;
						IL_01fc:
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0x9B8E2099u) % 6u)
							{
							case 5u:
								num7 = (int)(num2 * 606478029) ^ -307080178;
								continue;
							case 4u:
								num7 = (int)(num2 * 1483526805) ^ -106753776;
								continue;
							case 3u:
								result = defaultInstance;
								num7 = (int)(num2 * 558492978) ^ -917924395;
								continue;
							case 2u:
								break;
							case 0u:
								goto IL_0226;
							default:
								return result;
							}
							break;
						}
						goto IL_01f7;
						IL_0226:
						num7 = -1186969390;
						goto IL_01fc;
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
			int num = 1320637644;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x24CB0255u) % 3u)
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
				num = ((int)num2 * -1632255395) ^ -1958230844;
			}
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		bool flag = MySettings.smethod_3((WindowsFormsApplicationBase)(object)MyProject.Application);
		while (true)
		{
			int num = -1218502303;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE0120BADu) % 6u)
				{
				case 5u:
					num = -331336776;
					continue;
				case 4u:
					MySettings.smethod_4((ApplicationSettingsBase)(object)MySettingsProperty.Settings);
					num = (int)((num2 * 472939108) ^ 0x7D80B068);
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 1972504814;
						num4 = 1972504814;
					}
					else
					{
						num3 = 1772291881;
						num4 = 1772291881;
					}
					num = num3 ^ ((int)num2 * -859839923);
					continue;
				}
				case 1u:
					num = (int)((num2 * 226131035) ^ 0x1B135015);
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
