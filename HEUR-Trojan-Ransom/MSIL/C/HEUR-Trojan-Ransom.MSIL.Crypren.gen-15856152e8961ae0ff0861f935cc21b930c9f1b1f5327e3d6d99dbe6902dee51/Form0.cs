using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal class Form0 : WindowsFormsApplicationBase
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerHidden]
	[STAThread]
	internal static void Main(string[] args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.get_UseCompatibleTextRendering());
		}
		finally
		{
		}
		((WindowsFormsApplicationBase)Delegate3.smethod_0()).Run(args);
	}

	[DebuggerStepThrough]
	public Form0()
		: base((AuthenticationMode)0)
	{
		while (true)
		{
			int num = 12;
			int num2 = -12;
			while (true)
			{
				num2 ^= 0x27;
				while (true)
				{
					int num3 = 0;
					int num4 = -6;
					while (true)
					{
						num4 ^= 0x28;
						while (true)
						{
							int num5 = Class8.smethod_0(38);
							int num6 = 22;
							while (true)
							{
								num6 ^= 0x27;
								while (true)
								{
									int num7 = GEventArgs2.smethod_0(40);
									int num8 = -16;
									while (true)
									{
										num8 ^= 0x2B;
										int num9 = Class8.smethod_0(48);
										while (true)
										{
											switch (num9 ^ 0x2B)
											{
											case -47:
												break;
											default:
												num9 = Class8.smethod_0(48);
												continue;
											case -48:
												num8 = GEventArgs2.smethod_0(44);
												num9 = -7;
												num9 = -46;
												goto end_IL_003a;
											case -46:
												goto end_IL_003a;
											case -49:
												while (true)
												{
													num9 = -28;
													num9 = -49;
												}
											}
											switch (num8)
											{
											case -40:
												goto IL_0073;
											case -39:
												goto IL_007c;
											case -37:
												goto IL_020c;
											case -38:
												goto end_IL_0224;
											}
											num9 = Class8.smethod_0(47);
											continue;
											IL_0073:
											num8 = -13;
											break;
											continue;
											end_IL_003a:
											break;
										}
										continue;
										IL_01ec:
										num4 = GEventArgs2.smethod_0(43);
										num5 = -2;
										goto IL_01f8;
										IL_007c:
										switch (num7)
										{
										case -46:
											goto IL_009f;
										case -47:
											goto IL_01ff;
										case -45:
											goto IL_0208;
										case -44:
											goto end_IL_0239;
										}
										num8 = -15;
										continue;
										IL_0208:
										num7 = -12;
										goto IL_020c;
										IL_009f:
										switch (num6)
										{
										case 47:
											goto IL_00c7;
										case 49:
											goto IL_01f8;
										case 48:
											goto IL_024e;
										case 46:
											goto end_IL_0252;
										}
										num7 = GEventArgs2.smethod_0(49);
										goto IL_020c;
										IL_024e:
										num6 = 23;
										goto end_IL_0239;
										IL_00c7:
										switch (num5)
										{
										case -49:
											break;
										case -48:
											goto IL_00ef;
										case -47:
											goto IL_01ec;
										default:
											goto IL_0248;
										case -46:
											goto end_IL_025b;
										}
										num5 = -29;
										goto IL_01f8;
										IL_0248:
										num6 = 9;
										goto end_IL_0239;
										IL_00ef:
										switch (num4)
										{
										case -48:
											goto IL_0116;
										case -46:
											goto IL_01e7;
										case -49:
											goto IL_026a;
										case -47:
											goto end_IL_0272;
										}
										num5 = Class8.smethod_0(41);
										goto IL_01f8;
										IL_026a:
										num4 = -25;
										goto end_IL_025b;
										IL_0116:
										switch (num3)
										{
										case 46:
											break;
										case 48:
											goto IL_013c;
										case 47:
											goto IL_01dd;
										default:
											goto IL_026f;
										case 49:
											goto end_IL_0279;
										}
										num3 = 30;
										goto IL_01e7;
										IL_026f:
										num4 = -7;
										goto end_IL_025b;
										IL_013c:
										switch (num2)
										{
										case -46:
											goto IL_015d;
										case -45:
											goto IL_01d8;
										case -47:
											goto IL_0280;
										case -48:
											goto end_IL_028d;
										}
										num3 = 31;
										goto IL_01e7;
										IL_0280:
										num2 = -10;
										goto end_IL_0279;
										IL_015d:
										switch (num)
										{
										case 39:
											break;
										case 40:
											goto IL_0198;
										case 41:
											goto IL_019d;
										case 42:
											goto IL_01a9;
										case 43:
											goto IL_01ad;
										case 44:
											goto IL_01b2;
										case 45:
											goto IL_01be;
										case 46:
											goto IL_01c9;
										case 47:
											goto IL_01ce;
										default:
											goto IL_0285;
										case 48:
											return;
										}
										num = 10;
										goto IL_01d8;
										IL_0285:
										num2 = GEventArgs2.smethod_0(46);
										goto end_IL_0279;
										IL_01ce:
										((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
										num = 13;
										goto IL_01d8;
										IL_01c9:
										num = 9;
										goto IL_01d8;
										IL_01be:
										((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit(true);
										num = 2;
										goto IL_01d8;
										IL_01b2:
										((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
										num = 15;
										goto IL_01d8;
										IL_01ad:
										num = 14;
										goto IL_01d8;
										IL_01a9:
										num = 8;
										goto IL_01d8;
										IL_019d:
										((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
										num = 11;
										goto IL_01d8;
										IL_0198:
										num = 21;
										goto IL_01d8;
										IL_01ff:
										num6 = 8;
										num7 = -13;
										goto IL_020c;
										IL_01d8:
										num ^= 0x25;
										goto IL_01dd;
										IL_01dd:
										num2 = GEventArgs2.smethod_0(40);
										num3 = 1;
										goto IL_01e7;
										IL_020c:
										num7 ^= 0x27;
										num8 = GEventArgs2.smethod_0(44);
										num9 = -7;
										num9 = -46;
										continue;
										IL_01f8:
										num5 ^= 0x2C;
										goto IL_01ff;
										IL_01e7:
										num3 ^= 0x30;
										goto IL_01ec;
										continue;
										end_IL_0224:
										break;
									}
									continue;
									end_IL_0239:
									break;
								}
								continue;
								end_IL_0252:
								break;
							}
							continue;
							end_IL_025b:
							break;
						}
						continue;
						end_IL_0272:
						break;
					}
					continue;
					end_IL_0279:
					break;
				}
				continue;
				end_IL_028d:
				break;
			}
		}
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		while (true)
		{
			int num = Class8.smethod_0(42);
			int num2 = 6;
			while (true)
			{
				num2 ^= 0x32;
				while (true)
				{
					int num3 = 6;
					int num4 = 6;
					while (true)
					{
						num4 ^= 0x3A;
						while (true)
						{
							int num5 = 9;
							int num6 = 3;
							while (true)
							{
								num6 ^= 0x34;
								while (true)
								{
									int num7 = Class8.smethod_0(57);
									int num8 = 8;
									while (true)
									{
										num8 ^= 0x33;
										while (true)
										{
											int num9 = Class8.smethod_0(58);
											int num10 = GEventArgs2.smethod_1(52);
											while (true)
											{
												switch (num10 ^ 0x38)
												{
												case -47:
													break;
												default:
													goto IL_000d;
												case -50:
													goto IL_001b;
												case -49:
													goto end_IL_01af;
												case -48:
													while (true)
													{
														num10 = -24;
														num10 = -48;
													}
												}
												goto IL_0006;
												IL_001b:
												switch (num9)
												{
												case -58:
													break;
												case -57:
													goto IL_0194;
												case -56:
													goto IL_01a1;
												default:
													goto IL_01d5;
												case -55:
													goto end_IL_01dd;
												}
												switch (num8)
												{
												case 58:
													goto IL_005a;
												case 59:
													goto IL_018d;
												case 57:
													goto IL_01f1;
												case 56:
													goto end_IL_01fb;
												}
												num9 = -14;
												goto IL_0006;
												IL_01d5:
												num10 = -9;
												num10 = -49;
												break;
												IL_01a1:
												num9 = Class8.smethod_0(41);
												goto IL_0006;
												IL_0194:
												num8 = 9;
												num9 = -4;
												goto IL_0006;
												IL_01f1:
												num8 = 10;
												goto end_IL_01dd;
												IL_005a:
												switch (num7)
												{
												case -49:
													break;
												case -50:
													goto IL_0180;
												case -48:
													goto IL_0189;
												default:
													goto IL_01f7;
												case -47:
													goto end_IL_0204;
												}
												switch (num6)
												{
												case 52:
													goto IL_00a1;
												case 55:
													goto IL_0179;
												case 53:
													goto IL_0217;
												case 54:
													goto end_IL_021a;
												}
												num7 = GEventArgs2.smethod_0(43);
												goto IL_018d;
												IL_01f7:
												num8 = 11;
												goto end_IL_01dd;
												IL_0189:
												num7 = -26;
												goto IL_018d;
												IL_0180:
												num6 = 0;
												num7 = -25;
												goto IL_018d;
												IL_0217:
												num6 = 1;
												goto end_IL_0204;
												IL_00a1:
												switch (num5)
												{
												case 48:
													break;
												case 49:
													goto IL_016d;
												case 50:
													goto IL_0175;
												default:
													goto IL_0212;
												case 51:
													goto end_IL_0223;
												}
												switch (num4)
												{
												case 59:
													goto IL_00e1;
												case 60:
													goto IL_0168;
												case 57:
													goto IL_022c;
												case 58:
													goto end_IL_0232;
												}
												num5 = 8;
												goto IL_0179;
												IL_0212:
												num6 = 2;
												goto end_IL_0204;
												IL_0175:
												num5 = 11;
												goto IL_0179;
												IL_018d:
												num7 ^= 0x36;
												goto IL_0194;
												IL_022c:
												num4 = 3;
												goto end_IL_0223;
												IL_00e1:
												switch (num3)
												{
												case 53:
													break;
												case 52:
													goto IL_0160;
												case 54:
													goto IL_0166;
												default:
													goto IL_0230;
												case 55:
													goto end_IL_0239;
												}
												switch (num2)
												{
												case 49:
													goto IL_011c;
												case 52:
													goto IL_015b;
												case 51:
													goto IL_0243;
												case 50:
													goto end_IL_0245;
												}
												num3 = 7;
												goto IL_0168;
												IL_0230:
												num4 = 0;
												goto end_IL_0223;
												IL_0166:
												num3 = 5;
												goto IL_0168;
												IL_0179:
												num5 ^= 0x39;
												goto IL_0180;
												IL_0243:
												num2 = 1;
												goto end_IL_0239;
												IL_011c:
												switch (num)
												{
												case -54:
													break;
												case -53:
													goto IL_0144;
												case -52:
													goto IL_0148;
												default:
													goto IL_023f;
												case -51:
													return;
												}
												num = GEventArgs2.smethod_0(43);
												goto IL_015b;
												IL_023f:
												num2 = 0;
												goto end_IL_0239;
												IL_0148:
												((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)Delegate5.smethod_0(Delegate4.smethod_0()));
												num = -7;
												goto IL_015b;
												IL_0144:
												num = -1;
												goto IL_015b;
												IL_000d:
												num10 = GEventArgs2.smethod_0(49);
												continue;
												IL_015b:
												num ^= 0x32;
												goto IL_0160;
												IL_0160:
												num2 = 3;
												num3 = 4;
												goto IL_0168;
												IL_0006:
												num9 ^= 0x35;
												goto IL_000d;
												IL_0168:
												num3 ^= 0x33;
												goto IL_016d;
												IL_016d:
												num4 = 1;
												num5 = 10;
												goto IL_0179;
												continue;
												end_IL_01af:
												break;
											}
											continue;
											end_IL_01dd:
											break;
										}
										continue;
										end_IL_01fb:
										break;
									}
									continue;
									end_IL_0204:
									break;
								}
								continue;
								end_IL_021a:
								break;
							}
							continue;
							end_IL_0223:
							break;
						}
						continue;
						end_IL_0232:
						break;
					}
					continue;
					end_IL_0239:
					break;
				}
				continue;
				end_IL_0245:
				break;
			}
		}
	}
}
