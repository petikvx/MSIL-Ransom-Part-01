using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
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
			int num = 8;
			int num2 = -1;
			while (true)
			{
				num2 ^= 0x31;
				while (true)
				{
					int num3 = Class24.smethod_0(47);
					int num4 = 13;
					while (true)
					{
						num4 ^= 0x39;
						while (true)
						{
							int num5 = 9;
							int num6 = 13;
							while (true)
							{
								num6 ^= 0x3A;
								int num7 = Class40.smethod_2(61);
								int num8 = -4;
								num8 = -46;
								while (true)
								{
									IL_01e3:
									num7 ^= 0x2E;
									num8 = Class24.smethod_0(57);
									while (true)
									{
										switch (num8 ^ 0x2E)
										{
										case -48:
											num8 = Class24.smethod_0(52);
											continue;
										default:
											num8 = Class24.smethod_0(57);
											continue;
										case -47:
											break;
										case -49:
											goto IL_0065;
										case -46:
											goto IL_01e3;
										}
										break;
									}
									switch (num7)
									{
									case -47:
										goto IL_007b;
									case -46:
										goto IL_0083;
									case -48:
										goto IL_01db;
									case -45:
										goto end_IL_01e3;
									}
									num8 = -31;
									num8 = -49;
									goto IL_0065;
									IL_01ce:
									num4 = 10;
									num5 = 8;
									goto IL_01d4;
									IL_01d4:
									num5 ^= 0x3B;
									goto IL_01db;
									IL_0083:
									switch (num6)
									{
									case 54:
										goto IL_00a6;
									case 55:
										goto IL_01d4;
									case 52:
										goto IL_01f8;
									case 53:
										goto end_IL_0202;
									}
									num7 = -2;
									continue;
									IL_01f8:
									num6 = 14;
									break;
									IL_00a6:
									switch (num5)
									{
									case 48:
										break;
									case 50:
										goto IL_00ce;
									case 49:
										goto IL_01ce;
									default:
										goto IL_01fe;
									case 51:
										goto end_IL_021c;
									}
									num5 = 11;
									goto IL_01d4;
									IL_01fe:
									num6 = 15;
									break;
									IL_00ce:
									switch (num4)
									{
									case 51:
										goto IL_00f0;
									case 52:
										goto IL_01c9;
									case 50:
										goto IL_0226;
									case 49:
										goto end_IL_022d;
									}
									num5 = 10;
									goto IL_01d4;
									IL_0226:
									num4 = 11;
									goto end_IL_021c;
									IL_00f0:
									switch (num3)
									{
									case -55:
										break;
									case -53:
										goto IL_0116;
									case -54:
										goto IL_01b9;
									default:
										goto IL_022b;
									case -52:
										goto end_IL_0234;
									}
									num3 = -11;
									goto IL_01c9;
									IL_022b:
									num4 = 8;
									goto end_IL_021c;
									IL_0116:
									switch (num2)
									{
									case -52:
										goto IL_0137;
									case -50:
										goto IL_01b4;
									case -51:
										goto IL_0246;
									case -53:
										goto end_IL_024e;
									}
									num3 = -10;
									goto IL_01c9;
									IL_0246:
									num2 = Class40.smethod_2(61);
									goto end_IL_0234;
									IL_0137:
									switch (num)
									{
									case 58:
										break;
									case 59:
										goto IL_0172;
									case 60:
										goto IL_017e;
									case 61:
										goto IL_018a;
									case 62:
										goto IL_018f;
									case 63:
										goto IL_019b;
									case 64:
										goto IL_01a7;
									case 65:
										goto IL_01ac;
									case 66:
										goto IL_01b1;
									default:
										goto IL_0241;
									case 67:
										return;
									}
									num = 12;
									goto IL_01b4;
									IL_0241:
									num2 = -6;
									goto end_IL_0234;
									IL_01b1:
									num = 9;
									goto IL_01b4;
									IL_01ac:
									num = 116;
									goto IL_01b4;
									IL_01a7:
									num = 11;
									goto IL_01b4;
									IL_019b:
									((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
									num = 119;
									goto IL_01b4;
									IL_018f:
									((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit(true);
									num = 13;
									goto IL_01b4;
									IL_018a:
									num = 10;
									goto IL_01b4;
									IL_017e:
									((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
									num = 117;
									goto IL_01b4;
									IL_0172:
									((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
									num = 118;
									goto IL_01b4;
									IL_0065:
									num7 = Class40.smethod_2(61);
									num8 = -4;
									num8 = -46;
									continue;
									IL_01b4:
									num ^= 0x37;
									goto IL_01b9;
									IL_01b9:
									num2 = Class40.smethod_2(54);
									num3 = Class24.smethod_0(56);
									goto IL_01c9;
									IL_01db:
									num6 = 12;
									num7 = -3;
									continue;
									IL_007b:
									num7 = -1;
									continue;
									IL_01c9:
									num3 ^= 0x3C;
									goto IL_01ce;
									continue;
									end_IL_01e3:
									break;
								}
								continue;
								end_IL_0202:
								break;
							}
							continue;
							end_IL_021c:
							break;
						}
						continue;
						end_IL_022d:
						break;
					}
					continue;
					end_IL_0234:
					break;
				}
				continue;
				end_IL_024e:
				break;
			}
		}
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		while (true)
		{
			int num = Class40.smethod_2(54);
			int num2 = -28;
			while (true)
			{
				num2 ^= 0x2F;
				while (true)
				{
					int num3 = Class48.smethod_2(69);
					int num4 = Class15.smethod_0(67);
					while (true)
					{
						num4 ^= 0x48;
						int num5 = Class24.smethod_0(56);
						int num6 = -13;
						num6 = -71;
						while (true)
						{
							IL_0139:
							num5 ^= 0x44;
							num6 = Class24.smethod_0(53);
							while (true)
							{
								switch (num6 ^ 0x4A)
								{
								default:
									num6 = Class24.smethod_0(53);
									continue;
								case -72:
									break;
								case -73:
									goto IL_0054;
								case -71:
									goto IL_0139;
								case -74:
									while (true)
									{
										num6 = -4;
										num6 = -74;
									}
								}
								break;
							}
							switch (num5)
							{
							case -76:
								goto IL_006a;
							case -75:
								goto IL_0122;
							case -74:
								goto IL_0135;
							case -73:
								goto end_IL_0139;
							}
							num6 = -3;
							num6 = -73;
							goto IL_0054;
							IL_010d:
							num2 = Class24.smethod_0(72);
							num3 = -4;
							goto IL_011d;
							IL_011d:
							num3 ^= 0x3C;
							goto IL_0122;
							IL_0135:
							num5 = -14;
							continue;
							IL_006a:
							switch (num4)
							{
							case -64:
								goto IL_008c;
							case -62:
								goto IL_011d;
							case -65:
								goto IL_014e;
							case -63:
								goto end_IL_0156;
							}
							num5 = -15;
							continue;
							IL_014e:
							num4 = -9;
							break;
							IL_008c:
							switch (num3)
							{
							case -67:
								break;
							case -66:
								goto IL_010d;
							case -65:
								goto IL_011a;
							default:
								goto IL_0153;
							case -64:
								goto end_IL_016e;
							}
							switch (num2)
							{
							case -54:
								goto IL_00c8;
							case -53:
								goto IL_0108;
							case -56:
								goto IL_0180;
							case -55:
								goto end_IL_018d;
							}
							num3 = -126;
							goto IL_011d;
							IL_0153:
							num4 = -119;
							break;
							IL_011a:
							num3 = -125;
							goto IL_011d;
							IL_0122:
							num4 = Class48.smethod_2(63);
							num5 = Class40.smethod_2(58);
							continue;
							IL_0180:
							num2 = Class48.smethod_2(70);
							goto end_IL_016e;
							IL_00c8:
							switch (num)
							{
							case -56:
								break;
							case -55:
								goto IL_00f0;
							case -54:
								goto IL_0105;
							default:
								goto IL_018a;
							case -53:
								return;
							}
							num = Class24.smethod_0(57);
							goto IL_0108;
							IL_018a:
							num2 = -26;
							goto end_IL_016e;
							IL_0105:
							num = -2;
							goto IL_0108;
							IL_00f0:
							((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)Delegate5.smethod_0(Delegate4.smethod_0()));
							num = -4;
							goto IL_0108;
							IL_0054:
							num5 = Class24.smethod_0(56);
							num6 = -13;
							num6 = -71;
							continue;
							IL_0108:
							num ^= 0x34;
							goto IL_010d;
							continue;
							end_IL_0139:
							break;
						}
						continue;
						end_IL_0156:
						break;
					}
					continue;
					end_IL_016e:
					break;
				}
				continue;
				end_IL_018d:
				break;
			}
		}
	}

	internal static int smethod_0(int int_0)
	{
		return int_0 switch
		{
			106 => -48, 
			109 => -56, 
			111 => -58, 
			112 => -52, 
			94 => -64, 
			95 => -59, 
			97 => -60, 
			100 => -57, 
			101 => -51, 
			90 => -53, 
			_ => -1, 
		};
	}
}
