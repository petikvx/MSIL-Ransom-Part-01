using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace TSSAssistant.My;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[CompilerGenerated]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings mySettings_0 = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)Delegate18.smethod_0());

	private static bool bool_0;

	private static object object_0 = RuntimeHelpers.GetObjectValue(new object());

	public static MySettings MySettings_0
	{
		get
		{
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_018c: Expected O, but got Unknown
			if ((bool_0 ? 1 : 0) == Class45.smethod_0(0) || 1 == 0)
			{
				object obj = default(object);
				while (true)
				{
					int num = Class45.smethod_0(37);
					while (true)
					{
						switch (num ^ Class45.smethod_0(82))
						{
						case 22:
							num = 14;
							continue;
						case 21:
							num = 12;
							continue;
						case 20:
							obj = object_0;
							num = 10;
							continue;
						case 19:
							ObjectFlowControl.CheckForSyncLockOnValueType(obj);
							num = 15;
							continue;
						case 23:
							goto end_IL_0066;
						}
						break;
					}
					continue;
					end_IL_0066:
					break;
				}
				bool lockTaken = (byte)Class45.smethod_0(0) != 0;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					bool flag = default(bool);
					while (true)
					{
						int num2 = Class45.smethod_0(17);
						int num3 = -13;
						while (true)
						{
							num3 ^= Class45.smethod_0(87);
							while (true)
							{
								int num4 = Class33.smethod_1(16);
								while (true)
								{
									switch (num4 ^ Class45.smethod_0(44))
									{
									case -17:
										break;
									case -19:
										goto IL_00fb;
									case -18:
										num4 = -6;
										continue;
									default:
										goto end_IL_0113;
									case -16:
										goto end_IL_0139;
									}
									switch (num3)
									{
									case -27:
										goto IL_00a5;
									case -24:
										goto IL_00ef;
									case -25:
										goto IL_014f;
									case -26:
										goto end_IL_0153;
									}
									num4 = -7;
									continue;
									IL_00ef:
									num2 ^= Class45.smethod_0(69);
									goto IL_00fb;
									IL_014f:
									num3 = -4;
									goto end_IL_0139;
									IL_00a5:
									switch (num2)
									{
									case 23:
										break;
									case 24:
										if (flag)
										{
											goto IL_00d1;
										}
										if (true)
										{
											goto end_IL_0161;
										}
										goto case 27;
									case 25:
										goto IL_00d6;
									case 26:
										goto IL_00dc;
									default:
										goto IL_0144;
									case 27:
										((WindowsFormsApplicationBase)Delegate4.smethod_0()).add_Shutdown((ShutdownEventHandler)delegate
										{
											if (((WindowsFormsApplicationBase)Delegate4.smethod_0()).get_SaveMySettingsOnExit() || 1 == 0)
											{
												while (true)
												{
													int num6 = Class45.smethod_0(53);
													int num7 = -15;
													while (true)
													{
														num7 ^= Class45.smethod_0(84);
														while (true)
														{
															int num8 = Class45.smethod_0(15);
															while (true)
															{
																switch (num8 ^ Class45.smethod_0(69))
																{
																case 24:
																	num8 = 11;
																	continue;
																case 23:
																	break;
																case 22:
																	goto IL_0031;
																default:
																	goto end_IL_008c;
																case 25:
																	goto end_IL_00af;
																}
																goto IL_001f;
																IL_0031:
																switch (num7)
																{
																case -26:
																	goto IL_004e;
																case -23:
																	goto IL_0080;
																case -24:
																	goto IL_00c3;
																case -25:
																	goto end_IL_00c6;
																}
																num8 = 4;
																continue;
																IL_00c3:
																num7 = -16;
																goto end_IL_00af;
																IL_004e:
																switch (num6)
																{
																case 26:
																	break;
																case 27:
																	goto IL_0078;
																case 28:
																	goto IL_007d;
																default:
																	goto IL_00b9;
																case 29:
																	return;
																}
																((ApplicationSettingsBase)Delegate19.smethod_0()).Save();
																num6 = 10;
																goto IL_0080;
																IL_00b9:
																num7 = Class40.smethod_1(12);
																goto end_IL_00af;
																IL_007d:
																num6 = 11;
																goto IL_0080;
																IL_0078:
																num6 = 13;
																goto IL_0080;
																IL_001f:
																num7 = Class33.smethod_1(29);
																num8 = Class45.smethod_0(17);
																continue;
																IL_0080:
																num6 ^= Class45.smethod_0(88);
																goto IL_001f;
																continue;
																end_IL_008c:
																break;
															}
															continue;
															end_IL_00af:
															break;
														}
														continue;
														end_IL_00c6:
														break;
													}
												}
											}
										});
										while (true)
										{
											IL_01cc:
											int num5 = Class45.smethod_0(11);
											while (true)
											{
												switch (num5 ^ Class45.smethod_0(90))
												{
												case 28:
													bool_0 = (byte)Class45.smethod_0(1) != 0;
													num5 = 3;
													continue;
												case 27:
													num5 = 5;
													continue;
												case 26:
													num5 = 2;
													continue;
												case 29:
													goto end_IL_01a6;
												}
												goto IL_01cc;
												continue;
												end_IL_01a6:
												break;
											}
											break;
										}
										goto end_IL_0161;
									}
									num2 = 4;
									goto IL_00ef;
									IL_0144:
									num3 = Class33.smethod_1(22);
									goto end_IL_0139;
									IL_00dc:
									flag = (bool_0 ? 1 : 0) == Class45.smethod_0(0);
									num2 = 11;
									goto IL_00ef;
									IL_00d6:
									num2 = 9;
									goto IL_00ef;
									IL_00d1:
									num2 = 8;
									goto IL_00ef;
									IL_00fb:
									num3 = Class33.smethod_1(29);
									num4 = Class33.smethod_1(21);
									continue;
									end_IL_0113:
									break;
								}
								continue;
								end_IL_0139:
								break;
							}
							continue;
							end_IL_0153:
							break;
						}
						continue;
						end_IL_0161:
						break;
					}
				}
				finally
				{
					if (lockTaken || 1 == 0)
					{
						Monitor.Exit(obj);
					}
				}
			}
			return mySettings_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerNonUserCode]
	private static void smethod_0(object sender, EventArgs e)
	{
		if ((!((WindowsFormsApplicationBase)Delegate4.smethod_0()).get_SaveMySettingsOnExit()) ? true : false)
		{
			return;
		}
		while (true)
		{
			int num = Class45.smethod_0(53);
			int num2 = -15;
			while (true)
			{
				num2 ^= Class45.smethod_0(84);
				while (true)
				{
					int num3 = Class45.smethod_0(15);
					while (true)
					{
						switch (num3 ^ Class45.smethod_0(69))
						{
						case 24:
							num3 = 11;
							continue;
						case 23:
							break;
						case 22:
							goto IL_0031;
						default:
							goto end_IL_008c;
						case 25:
							goto end_IL_00af;
						}
						goto IL_001f;
						IL_0031:
						switch (num2)
						{
						case -26:
							goto IL_004e;
						case -23:
							goto IL_0080;
						case -24:
							goto IL_00c3;
						case -25:
							goto end_IL_00c6;
						}
						num3 = 4;
						continue;
						IL_00c3:
						num2 = -16;
						goto end_IL_00af;
						IL_004e:
						switch (num)
						{
						case 26:
							break;
						case 27:
							goto IL_0078;
						case 28:
							goto IL_007d;
						default:
							goto IL_00b9;
						case 29:
							return;
						}
						((ApplicationSettingsBase)Delegate19.smethod_0()).Save();
						num = 10;
						goto IL_0080;
						IL_00b9:
						num2 = Class40.smethod_1(12);
						goto end_IL_00af;
						IL_007d:
						num = 11;
						goto IL_0080;
						IL_0078:
						num = 13;
						goto IL_0080;
						IL_001f:
						num2 = Class33.smethod_1(29);
						num3 = Class45.smethod_0(17);
						continue;
						IL_0080:
						num ^= Class45.smethod_0(88);
						goto IL_001f;
						continue;
						end_IL_008c:
						break;
					}
					continue;
					end_IL_00af:
					break;
				}
				continue;
				end_IL_00c6:
				break;
			}
		}
	}
}
