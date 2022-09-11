using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using antlr;

namespace Underline.My;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
[CompilerGenerated]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings mySettings_0 = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)Delegate17.smethod_0());

	private static bool bool_0;

	private static object object_0 = RuntimeHelpers.GetObjectValue(new object());

	public static MySettings MySettings_0
	{
		get
		{
			//IL_0251: Unknown result type (might be due to invalid IL or missing references)
			//IL_025b: Expected O, but got Unknown
			if (!bool_0 || 1 == 0)
			{
				object obj = default(object);
				while (true)
				{
					int num = Form0.smethod_0(112);
					int num2 = -9;
					while (true)
					{
						num2 ^= 0x62;
						while (true)
						{
							int num3 = Class24.smethod_0(57);
							int num4 = -53;
							while (true)
							{
								num4 ^= 0x6A;
								while (true)
								{
									int num5 = Class40.smethod_2(62);
									int num6 = Form0.smethod_0(109);
									while (true)
									{
										switch (num6 ^ 0x6A)
										{
										case -94:
											break;
										case -95:
											goto IL_002d;
										default:
											num6 = Form0.smethod_0(90);
											continue;
										case -96:
											goto end_IL_0144;
										case -97:
											while (true)
											{
												num6 = -11;
												num6 = -97;
											}
										}
										goto IL_0018;
										IL_002d:
										switch (num5)
										{
										case -109:
											break;
										case -108:
											goto IL_0057;
										case -107:
											goto IL_0129;
										default:
											goto IL_0167;
										case -106:
											goto end_IL_016f;
										}
										num5 = Class24.smethod_0(52);
										goto IL_0018;
										IL_0167:
										num6 = -54;
										num6 = -96;
										break;
										IL_0057:
										switch (num4)
										{
										case -98:
											goto IL_0077;
										case -95:
											goto IL_0122;
										case -97:
											goto IL_0189;
										case -96:
											goto end_IL_018d;
										}
										num5 = -8;
										goto IL_0018;
										IL_0189:
										num4 = -11;
										goto end_IL_016f;
										IL_0077:
										switch (num3)
										{
										case -110:
											break;
										case -109:
											goto IL_009f;
										case -108:
											goto IL_0110;
										default:
											goto IL_0183;
										case -107:
											goto end_IL_0196;
										}
										num3 = -2;
										goto IL_0122;
										IL_0183:
										num4 = -54;
										goto end_IL_016f;
										IL_009f:
										switch (num2)
										{
										case -110:
											goto IL_00bf;
										case -107:
											goto IL_0109;
										case -108:
											goto IL_01ab;
										case -109:
											goto end_IL_01af;
										}
										num3 = -8;
										goto IL_0122;
										IL_01ab:
										num2 = -10;
										goto end_IL_0196;
										IL_00bf:
										switch (num)
										{
										case -96:
											break;
										case -95:
											goto IL_00e8;
										case -94:
											goto IL_00f4;
										case -93:
											goto IL_00ff;
										default:
											goto IL_01a5;
										case -92:
											goto end_IL_01b8;
										}
										num = -53;
										goto IL_0109;
										IL_01a5:
										num2 = -15;
										goto end_IL_0196;
										IL_00ff:
										obj = object_0;
										num = -50;
										goto IL_0109;
										IL_00f4:
										num = Form0.smethod_0(101);
										goto IL_0109;
										IL_00e8:
										ObjectFlowControl.CheckForSyncLockOnValueType(obj);
										num = -49;
										goto IL_0109;
										IL_0018:
										num5 ^= 0x6D;
										num6 = Form0.smethod_0(90);
										continue;
										IL_0109:
										num ^= 0x6F;
										goto IL_0110;
										IL_0110:
										num2 = Class24.smethod_0(56);
										num3 = Class40.smethod_2(62);
										goto IL_0122;
										IL_0122:
										num3 ^= 0x6C;
										goto IL_0129;
										IL_0129:
										num4 = Class15.smethod_0(78);
										num5 = -5;
										goto IL_0018;
										continue;
										end_IL_0144:
										break;
									}
									continue;
									end_IL_016f:
									break;
								}
								continue;
								end_IL_018d:
								break;
							}
							continue;
							end_IL_0196:
							break;
						}
						continue;
						end_IL_01af:
						break;
					}
					continue;
					end_IL_01b8:
					break;
				}
				bool lockTaken = false;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					bool flag = default(bool);
					while (true)
					{
						int num7 = Class24.smethod_0(51);
						switch (num7 ^ 0x6A)
						{
						default:
							continue;
						case -100:
							num7 = -15;
							num7 = -101;
							goto case -101;
						case -101:
							flag = !bool_0;
							num7 = -12;
							num7 = -98;
							goto case -98;
						case -99:
							while (true)
							{
								num7 = -9;
								num7 = -99;
							}
						case -98:
							if (flag)
							{
								num7 = -11;
								num7 = -97;
							}
							else if (true)
							{
								goto end_IL_01db;
							}
							break;
						case -97:
							break;
						}
						((WindowsFormsApplicationBase)Delegate3.smethod_0()).add_Shutdown((ShutdownEventHandler)delegate
						{
							if (((WindowsFormsApplicationBase)Delegate3.smethod_0()).get_SaveMySettingsOnExit() || 1 == 0)
							{
								while (true)
								{
									int num9 = 5;
									int num10 = -63;
									while (true)
									{
										num10 ^= 0x62;
										while (true)
										{
											int num11 = 3;
											int num12 = -50;
											while (true)
											{
												num12 ^= 0x6C;
												while (true)
												{
													int num13 = Class24.smethod_0(52);
													int num14 = 3;
													while (true)
													{
														num14 ^= 0x65;
														while (true)
														{
															int num15 = Class24.smethod_0(55);
															int num16 = 22;
															while (true)
															{
																num16 ^= 0x70;
																int num17 = 11;
																int num18 = -20;
																num18 = -100;
																while (true)
																{
																	num17 ^= 0x68;
																	while (true)
																	{
																		num18 = ANTLRPanicException.smethod_0(86);
																		while (true)
																		{
																			switch (num18 ^ 0x70)
																			{
																			case -102:
																				break;
																			default:
																				goto end_IL_003d;
																			case -103:
																				num17 = 11;
																				num18 = -20;
																				num18 = -100;
																				goto end_IL_005e;
																			case -100:
																				goto end_IL_005e;
																			case -101:
																				while (true)
																				{
																					num18 = -21;
																					num18 = -101;
																				}
																			}
																			switch (num17)
																			{
																			case 99:
																				goto IL_007a;
																			case 98:
																				goto IL_01e4;
																			case 100:
																				goto IL_01ee;
																			case 101:
																				goto end_IL_01f2;
																			}
																			num18 = ANTLRPanicException.smethod_0(85);
																			continue;
																			IL_01ee:
																			num17 = 12;
																			goto end_IL_005e;
																			continue;
																			end_IL_003d:
																			break;
																		}
																		continue;
																		end_IL_005e:
																		break;
																	}
																	continue;
																	IL_01ca:
																	num13 ^= 0x67;
																	goto IL_01d1;
																	IL_007a:
																	switch (num16)
																	{
																	case 99:
																		goto IL_009d;
																	case 102:
																		goto IL_01dd;
																	case 100:
																		goto IL_0204;
																	case 101:
																		goto end_IL_0208;
																	}
																	num17 = 10;
																	continue;
																	IL_0204:
																	num16 = 20;
																	break;
																	IL_009d:
																	switch (num15)
																	{
																	case -105:
																		break;
																	case -104:
																		goto IL_00c5;
																	case -106:
																		goto IL_01d1;
																	default:
																		goto IL_01fe;
																	case -103:
																		goto end_IL_021d;
																	}
																	num15 = -25;
																	goto IL_01dd;
																	IL_01fe:
																	num16 = 21;
																	break;
																	IL_00c5:
																	switch (num14)
																	{
																	case 99:
																		goto IL_00e8;
																	case 102:
																		goto IL_01ca;
																	case 101:
																		goto IL_0231;
																	case 100:
																		goto end_IL_0234;
																	}
																	num15 = -26;
																	goto IL_01dd;
																	IL_0231:
																	num14 = 0;
																	goto end_IL_021d;
																	IL_00e8:
																	switch (num13)
																	{
																	case -105:
																		break;
																	case -103:
																		goto IL_0110;
																	case -104:
																		goto IL_01b8;
																	default:
																		goto IL_022c;
																	case -102:
																		goto end_IL_023d;
																	}
																	num13 = -16;
																	goto IL_01ca;
																	IL_022c:
																	num14 = 1;
																	goto end_IL_021d;
																	IL_0110:
																	switch (num12)
																	{
																	case -97:
																		goto IL_0132;
																	case -94:
																		goto IL_01b3;
																	case -95:
																		goto IL_0256;
																	case -96:
																		goto end_IL_025a;
																	}
																	num13 = -1;
																	goto IL_01ca;
																	IL_0256:
																	num12 = -51;
																	goto end_IL_023d;
																	IL_0132:
																	switch (num11)
																	{
																	case 101:
																		break;
																	case 102:
																		goto IL_0154;
																	case 103:
																		goto IL_01a8;
																	default:
																		goto IL_024b;
																	case 104:
																		goto end_IL_0263;
																	}
																	num11 = 0;
																	goto IL_01b3;
																	IL_024b:
																	num12 = Form0.smethod_0(112);
																	goto end_IL_023d;
																	IL_0154:
																	switch (num10)
																	{
																	case -96:
																		goto IL_0171;
																	case -93:
																		goto IL_01a3;
																	case -94:
																		goto IL_0275;
																	case -95:
																		goto end_IL_0278;
																	}
																	num11 = 2;
																	goto IL_01b3;
																	IL_0275:
																	num10 = -64;
																	goto end_IL_0263;
																	IL_0171:
																	switch (num9)
																	{
																	case 104:
																		break;
																	case 105:
																		goto IL_0193;
																	case 106:
																		goto IL_0197;
																	default:
																		goto IL_026b;
																	case 107:
																		return;
																	}
																	num9 = 4;
																	goto IL_01a3;
																	IL_026b:
																	num10 = ANTLRPanicException.smethod_0(99);
																	goto end_IL_0263;
																	IL_0197:
																	((ApplicationSettingsBase)Delegate18.smethod_0()).Save();
																	num9 = 7;
																	goto IL_01a3;
																	IL_0193:
																	num9 = 6;
																	goto IL_01a3;
																	IL_01d1:
																	num14 = 6;
																	num15 = ANTLRPanicException.smethod_0(85);
																	goto IL_01dd;
																	IL_01a3:
																	num9 ^= 0x6F;
																	goto IL_01a8;
																	IL_01a8:
																	num10 = ANTLRPanicException.smethod_0(93);
																	num11 = 13;
																	goto IL_01b3;
																	IL_01e4:
																	num16 = 19;
																	num17 = 13;
																	continue;
																	IL_01dd:
																	num15 ^= 0x70;
																	goto IL_01e4;
																	IL_01b3:
																	num11 ^= 0x65;
																	goto IL_01b8;
																	IL_01b8:
																	num12 = Class40.smethod_2(58);
																	num13 = Class40.smethod_2(54);
																	goto IL_01ca;
																	continue;
																	end_IL_01f2:
																	break;
																}
																continue;
																end_IL_0208:
																break;
															}
															continue;
															end_IL_021d:
															break;
														}
														continue;
														end_IL_0234:
														break;
													}
													continue;
													end_IL_023d:
													break;
												}
												continue;
												end_IL_025a:
												break;
											}
											continue;
											end_IL_0263:
											break;
										}
										continue;
										end_IL_0278:
										break;
									}
								}
							}
						});
						while (true)
						{
							int num8 = Class40.smethod_2(58);
							switch (num8 ^ 0x66)
							{
							default:
								continue;
							case -108:
								while (true)
								{
									num8 = -14;
									num8 = -108;
								}
							case -107:
								num8 = -16;
								num8 = -106;
								break;
							case -106:
								break;
							case -105:
								goto end_IL_025b;
							}
							bool_0 = true;
							num8 = -15;
							num8 = -105;
							break;
							continue;
							end_IL_025b:
							break;
						}
						break;
						continue;
						end_IL_01db:
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
		if ((!((WindowsFormsApplicationBase)Delegate3.smethod_0()).get_SaveMySettingsOnExit()) ? true : false)
		{
			return;
		}
		while (true)
		{
			int num = 5;
			int num2 = -63;
			while (true)
			{
				num2 ^= 0x62;
				while (true)
				{
					int num3 = 3;
					int num4 = -50;
					while (true)
					{
						num4 ^= 0x6C;
						while (true)
						{
							int num5 = Class24.smethod_0(52);
							int num6 = 3;
							while (true)
							{
								num6 ^= 0x65;
								while (true)
								{
									int num7 = Class24.smethod_0(55);
									int num8 = 22;
									while (true)
									{
										num8 ^= 0x70;
										int num9 = 11;
										int num10 = -20;
										num10 = -100;
										while (true)
										{
											num9 ^= 0x68;
											while (true)
											{
												num10 = ANTLRPanicException.smethod_0(86);
												while (true)
												{
													switch (num10 ^ 0x70)
													{
													case -102:
														break;
													default:
														goto end_IL_003d;
													case -103:
														num9 = 11;
														num10 = -20;
														num10 = -100;
														goto end_IL_005e;
													case -100:
														goto end_IL_005e;
													case -101:
														while (true)
														{
															num10 = -21;
															num10 = -101;
														}
													}
													switch (num9)
													{
													case 99:
														goto IL_007a;
													case 98:
														goto IL_01e4;
													case 100:
														goto IL_01ee;
													case 101:
														goto end_IL_01f2;
													}
													num10 = ANTLRPanicException.smethod_0(85);
													continue;
													IL_01ee:
													num9 = 12;
													goto end_IL_005e;
													continue;
													end_IL_003d:
													break;
												}
												continue;
												end_IL_005e:
												break;
											}
											continue;
											IL_01ca:
											num5 ^= 0x67;
											goto IL_01d1;
											IL_007a:
											switch (num8)
											{
											case 99:
												goto IL_009d;
											case 102:
												goto IL_01dd;
											case 100:
												goto IL_0204;
											case 101:
												goto end_IL_0208;
											}
											num9 = 10;
											continue;
											IL_0204:
											num8 = 20;
											break;
											IL_009d:
											switch (num7)
											{
											case -105:
												break;
											case -104:
												goto IL_00c5;
											case -106:
												goto IL_01d1;
											default:
												goto IL_01fe;
											case -103:
												goto end_IL_021d;
											}
											num7 = -25;
											goto IL_01dd;
											IL_01fe:
											num8 = 21;
											break;
											IL_00c5:
											switch (num6)
											{
											case 99:
												goto IL_00e8;
											case 102:
												goto IL_01ca;
											case 101:
												goto IL_0231;
											case 100:
												goto end_IL_0234;
											}
											num7 = -26;
											goto IL_01dd;
											IL_0231:
											num6 = 0;
											goto end_IL_021d;
											IL_00e8:
											switch (num5)
											{
											case -105:
												break;
											case -103:
												goto IL_0110;
											case -104:
												goto IL_01b8;
											default:
												goto IL_022c;
											case -102:
												goto end_IL_023d;
											}
											num5 = -16;
											goto IL_01ca;
											IL_022c:
											num6 = 1;
											goto end_IL_021d;
											IL_0110:
											switch (num4)
											{
											case -97:
												goto IL_0132;
											case -94:
												goto IL_01b3;
											case -95:
												goto IL_0256;
											case -96:
												goto end_IL_025a;
											}
											num5 = -1;
											goto IL_01ca;
											IL_0256:
											num4 = -51;
											goto end_IL_023d;
											IL_0132:
											switch (num3)
											{
											case 101:
												break;
											case 102:
												goto IL_0154;
											case 103:
												goto IL_01a8;
											default:
												goto IL_024b;
											case 104:
												goto end_IL_0263;
											}
											num3 = 0;
											goto IL_01b3;
											IL_024b:
											num4 = Form0.smethod_0(112);
											goto end_IL_023d;
											IL_0154:
											switch (num2)
											{
											case -96:
												goto IL_0171;
											case -93:
												goto IL_01a3;
											case -94:
												goto IL_0275;
											case -95:
												goto end_IL_0278;
											}
											num3 = 2;
											goto IL_01b3;
											IL_0275:
											num2 = -64;
											goto end_IL_0263;
											IL_0171:
											switch (num)
											{
											case 104:
												break;
											case 105:
												goto IL_0193;
											case 106:
												goto IL_0197;
											default:
												goto IL_026b;
											case 107:
												return;
											}
											num = 4;
											goto IL_01a3;
											IL_026b:
											num2 = ANTLRPanicException.smethod_0(99);
											goto end_IL_0263;
											IL_0197:
											((ApplicationSettingsBase)Delegate18.smethod_0()).Save();
											num = 7;
											goto IL_01a3;
											IL_0193:
											num = 6;
											goto IL_01a3;
											IL_01d1:
											num6 = 6;
											num7 = ANTLRPanicException.smethod_0(85);
											goto IL_01dd;
											IL_01a3:
											num ^= 0x6F;
											goto IL_01a8;
											IL_01a8:
											num2 = ANTLRPanicException.smethod_0(93);
											num3 = 13;
											goto IL_01b3;
											IL_01e4:
											num8 = 19;
											num9 = 13;
											continue;
											IL_01dd:
											num7 ^= 0x70;
											goto IL_01e4;
											IL_01b3:
											num3 ^= 0x65;
											goto IL_01b8;
											IL_01b8:
											num4 = Class40.smethod_2(58);
											num5 = Class40.smethod_2(54);
											goto IL_01ca;
											continue;
											end_IL_01f2:
											break;
										}
										continue;
										end_IL_0208:
										break;
									}
									continue;
									end_IL_021d:
									break;
								}
								continue;
								end_IL_0234:
								break;
							}
							continue;
							end_IL_023d:
							break;
						}
						continue;
						end_IL_025a:
						break;
					}
					continue;
					end_IL_0263:
					break;
				}
				continue;
				end_IL_0278:
				break;
			}
		}
	}
}
