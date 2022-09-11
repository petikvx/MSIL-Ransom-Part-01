using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

internal class Class16 : IDisposable
{
	internal class Class17 : SafeHandle
	{
		public override bool IsInvalid => false;

		public Class17(IntPtr intptr_0)
			: base(intptr_0, ownsHandle: false)
		{
		}

		protected override bool ReleaseHandle()
		{
			return true;
		}
	}

	[CompilerGenerated]
	private GDelegate0 gdelegate0_0;

	private const int int_0 = 10;

	private const string string_0 = "WinSCPConsoleMapping";

	private const string string_1 = "WinSCPConsoleEventRequest";

	private const string string_2 = "WinSCPConsoleEventResponse";

	private const string string_3 = "WinSCPConsoleEventCancel";

	private const string string_4 = "WinSCPConsoleJob";

	private const string string_5 = "winscp.exe";

	private Process process_0;

	private readonly object object_0 = new object();

	private readonly Class21 class21_0;

	private readonly GClass16 gclass16_0;

	private EventWaitHandle eventWaitHandle_0;

	private EventWaitHandle eventWaitHandle_1;

	private EventWaitHandle eventWaitHandle_2;

	private SafeFileHandle safeFileHandle_0;

	private string string_6;

	private Thread thread_0;

	private bool bool_0;

	private string string_7;

	private string string_8;

	private readonly List<string> list_0 = new List<string>();

	private AutoResetEvent autoResetEvent_0 = new AutoResetEvent(initialState: false);

	private Class20 class20_0;

	public bool Boolean_0 => process_0.HasExited;

	public int Int32_0 => process_0.ExitCode;

	public event GDelegate0 Event_0
	{
		[CompilerGenerated]
		add
		{
			GDelegate0 gDelegate = gdelegate0_0;
			GDelegate0 value2 = default(GDelegate0);
			while (true)
			{
				GDelegate0 gDelegate2 = gDelegate;
				while (true)
				{
					int num = 9;
					int num2 = GEventArgs2.smethod_0(44);
					while (true)
					{
						num2 ^= 0x59;
						while (true)
						{
							int num3 = Class8.smethod_0(41);
							int num4 = -6;
							while (true)
							{
								num4 ^= 0x4E;
								while (true)
								{
									int num5 = 29;
									int num6 = -32;
									while (true)
									{
										num6 ^= 0x55;
										while (true)
										{
											int num7 = Class10.smethod_0(84);
											int num8 = -2;
											while (true)
											{
												IL_0217:
												num8 ^= 0x4E;
												int num9 = Class8.smethod_0(47);
												while (true)
												{
													switch (num9 ^ 0x51)
													{
													case -85:
														num9 = Class8.smethod_0(48);
														continue;
													default:
														num9 = Class8.smethod_0(47);
														continue;
													case -86:
														break;
													case -87:
														goto IL_0065;
													case -84:
														goto IL_0217;
													}
													break;
												}
												switch (num8)
												{
												case -83:
													goto IL_007b;
												case -82:
													goto IL_0089;
												case -80:
													goto IL_01ff;
												case -81:
													goto end_IL_0217;
												}
												num9 = -8;
												num9 = -87;
												goto IL_0065;
												IL_01d3:
												num4 = Class8.smethod_0(38);
												num5 = 27;
												goto IL_01e0;
												IL_01ff:
												num7 ^= 0x56;
												num8 = GEventArgs2.smethod_1(59);
												num9 = -3;
												num9 = -84;
												continue;
												IL_0089:
												switch (num7)
												{
												case -78:
													goto IL_00ac;
												case -77:
													goto IL_01e7;
												case -76:
													goto IL_01fb;
												case -75:
													goto end_IL_022c;
												}
												num8 = -31;
												continue;
												IL_01fb:
												num7 = -30;
												goto IL_01ff;
												IL_00ac:
												switch (num6)
												{
												case -77:
													goto IL_00cf;
												case -75:
													goto IL_01e0;
												case -78:
													goto IL_023b;
												case -76:
													goto end_IL_024a;
												}
												num7 = -27;
												goto IL_01ff;
												IL_023b:
												num6 = -25;
												goto end_IL_022c;
												IL_00cf:
												switch (num5)
												{
												case 81:
													break;
												case 82:
													goto IL_00f7;
												case 83:
													goto IL_01d3;
												default:
													goto IL_0241;
												case 84:
													goto end_IL_0253;
												}
												num5 = 30;
												goto IL_01e0;
												IL_0241:
												num6 = Class10.smethod_0(85);
												goto end_IL_022c;
												IL_00f7:
												switch (num4)
												{
												case -78:
													goto IL_011a;
												case -76:
													goto IL_01cc;
												case -79:
													goto IL_025d;
												case -77:
													goto end_IL_026c;
												}
												num5 = 28;
												goto IL_01e0;
												IL_025d:
												num4 = Class8.smethod_0(39);
												goto end_IL_0253;
												IL_011a:
												switch (num3)
												{
												case -80:
													break;
												case -78:
													goto IL_0147;
												case -79:
													goto IL_01bf;
												default:
													goto IL_0268;
												case -77:
													goto end_IL_0275;
												}
												num3 = Class8.smethod_0(39);
												goto IL_01cc;
												IL_0268:
												num4 = -3;
												goto end_IL_0253;
												IL_0147:
												switch (num2)
												{
												case -88:
													goto IL_0167;
												case -85:
													goto IL_01ba;
												case -86:
													goto IL_028a;
												case -87:
													goto end_IL_028e;
												}
												num3 = -2;
												goto IL_01cc;
												IL_028a:
												num2 = -13;
												goto end_IL_0275;
												IL_0167:
												switch (num)
												{
												case 86:
													break;
												case 87:
													goto IL_019b;
												case 88:
													goto IL_01a7;
												case 89:
													goto IL_01ab;
												default:
													goto IL_0284;
												case 90:
													return;
												}
												gDelegate = Interlocked.CompareExchange(ref gdelegate0_0, value2, gDelegate2);
												num = 7;
												goto IL_01ba;
												IL_0284:
												num2 = -16;
												goto end_IL_0275;
												IL_01ab:
												value2 = (GDelegate0)Delegate.Combine(gDelegate2, value);
												num = 6;
												goto IL_01ba;
												IL_01a7:
												num = 8;
												goto IL_01ba;
												IL_019b:
												if ((object)gDelegate != gDelegate2)
												{
													goto end_IL_0297;
												}
												num = 10;
												goto IL_01ba;
												IL_0065:
												num8 = GEventArgs2.smethod_1(59);
												num9 = -3;
												num9 = -84;
												continue;
												IL_01e7:
												num6 = Class8.smethod_0(50);
												num7 = GEventArgs2.smethod_1(68);
												goto IL_01ff;
												IL_01ba:
												num ^= 0x50;
												goto IL_01bf;
												IL_01bf:
												num2 = Class55.smethod_1(72);
												num3 = -4;
												goto IL_01cc;
												IL_007b:
												num8 = GEventArgs2.smethod_1(68);
												continue;
												IL_01e0:
												num5 ^= 0x4F;
												goto IL_01e7;
												IL_01cc:
												num3 ^= 0x4F;
												goto IL_01d3;
												continue;
												end_IL_0217:
												break;
											}
											continue;
											end_IL_022c:
											break;
										}
										continue;
										end_IL_024a:
										break;
									}
									continue;
									end_IL_0253:
									break;
								}
								continue;
								end_IL_026c:
								break;
							}
							continue;
							end_IL_0275:
							break;
						}
						continue;
						end_IL_028e:
						break;
					}
					continue;
					end_IL_0297:
					break;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			GDelegate0 gDelegate = gdelegate0_0;
			GDelegate0 value2 = default(GDelegate0);
			while (true)
			{
				GDelegate0 gDelegate2 = gDelegate;
				while (true)
				{
					int num = 2;
					int num2 = -8;
					while (true)
					{
						num2 ^= 0x53;
						while (true)
						{
							int num3 = 7;
							int num4 = 15;
							while (true)
							{
								num4 ^= 0x54;
								while (true)
								{
									int num5 = 2;
									int num6 = -27;
									while (true)
									{
										num6 ^= 0x56;
										while (true)
										{
											int num7 = Class8.smethod_0(48);
											int num8 = 4;
											while (true)
											{
												IL_01ea:
												num8 ^= 0x58;
												int num9 = Class8.smethod_0(58);
												while (true)
												{
													switch (num9 ^ 0x59)
													{
													default:
														num9 = Class8.smethod_0(58);
														continue;
													case -86:
														break;
													case -85:
														goto IL_01df;
													case -84:
														goto IL_01ea;
													case -87:
														while (true)
														{
															num9 = -16;
															num9 = -87;
														}
													}
													break;
												}
												switch (num8)
												{
												case 89:
													goto IL_005f;
												case 90:
													goto IL_01c6;
												case 92:
													goto IL_01cb;
												case 91:
													goto end_IL_01ea;
												}
												num9 = -14;
												num9 = -85;
												goto IL_01df;
												IL_01cb:
												num7 ^= 0x57;
												num8 = 1;
												num9 = -11;
												num9 = -84;
												continue;
												IL_018e:
												num3 ^= 0x52;
												goto IL_019c;
												IL_01c6:
												num8 = 2;
												continue;
												IL_005f:
												switch (num7)
												{
												case -83:
													goto IL_0081;
												case -82:
													goto IL_01ac;
												case -81:
													goto IL_01b7;
												case -80:
													goto end_IL_01ff;
												}
												num8 = 3;
												continue;
												IL_01ac:
												num7 = Class8.smethod_0(57);
												goto IL_01cb;
												IL_0081:
												switch (num6)
												{
												case -78:
													goto IL_00a4;
												case -77:
													goto IL_01a3;
												case -79:
													goto IL_020d;
												case -80:
													goto end_IL_0217;
												}
												num7 = -8;
												goto IL_01cb;
												IL_020d:
												num6 = -25;
												goto end_IL_01ff;
												IL_00a4:
												switch (num5)
												{
												case 80:
													break;
												case 81:
													goto IL_0197;
												case 82:
													goto IL_019c;
												default:
													goto IL_0213;
												case 83:
													goto end_IL_0220;
												}
												switch (num4)
												{
												case 90:
													goto IL_00e5;
												case 91:
													goto IL_018e;
												case 88:
													goto IL_0229;
												case 89:
													goto end_IL_0233;
												}
												num5 = 0;
												goto IL_01a3;
												IL_0213:
												num6 = -26;
												goto end_IL_01ff;
												IL_0197:
												num5 = 3;
												goto IL_01a3;
												IL_01b7:
												num6 = Class10.smethod_0(84);
												num7 = -25;
												goto IL_01cb;
												IL_0229:
												num4 = 12;
												goto end_IL_0220;
												IL_00e5:
												switch (num3)
												{
												case 84:
													break;
												case 85:
													goto IL_010c;
												case 83:
													goto IL_0182;
												default:
													goto IL_022f;
												case 86:
													goto end_IL_023c;
												}
												num3 = 6;
												goto IL_018e;
												IL_022f:
												num4 = 13;
												goto end_IL_0220;
												IL_010c:
												switch (num2)
												{
												case -87:
													goto IL_012b;
												case -85:
													goto IL_017d;
												case -88:
													goto IL_0245;
												case -86:
													goto end_IL_0254;
												}
												num3 = 1;
												goto IL_018e;
												IL_0245:
												num2 = Class8.smethod_0(47);
												goto end_IL_023c;
												IL_012b:
												switch (num)
												{
												case 82:
													break;
												case 83:
													goto IL_0158;
												case 84:
													goto IL_016a;
												case 85:
													goto IL_016e;
												default:
													goto IL_0250;
												case 86:
													return;
												}
												if ((object)gDelegate != gDelegate2)
												{
													goto end_IL_025d;
												}
												num = 1;
												goto IL_017d;
												IL_0250:
												num2 = -7;
												goto end_IL_023c;
												IL_016e:
												value2 = (GDelegate0)Delegate.Remove(gDelegate2, value);
												num = 4;
												goto IL_017d;
												IL_016a:
												num = 3;
												goto IL_017d;
												IL_0158:
												gDelegate = Interlocked.CompareExchange(ref gdelegate0_0, value2, gDelegate2);
												num = 5;
												goto IL_017d;
												IL_019c:
												num4 = 14;
												num5 = 1;
												goto IL_01a3;
												IL_01df:
												num8 = 1;
												num9 = -11;
												num9 = -84;
												continue;
												IL_017d:
												num ^= 0x57;
												goto IL_0182;
												IL_0182:
												num2 = Class8.smethod_0(48);
												num3 = 4;
												goto IL_018e;
												IL_01a3:
												num5 ^= 0x52;
												goto IL_01b7;
												continue;
												end_IL_01ea:
												break;
											}
											continue;
											end_IL_01ff:
											break;
										}
										continue;
										end_IL_0217:
										break;
									}
									continue;
									end_IL_0220:
									break;
								}
								continue;
								end_IL_0233:
								break;
							}
							continue;
							end_IL_023c:
							break;
						}
						continue;
						end_IL_0254:
						break;
					}
					continue;
					end_IL_025d:
					break;
				}
			}
		}
	}

	public static Class16 smethod_0(GClass16 gclass16_1)
	{
		return Delegate60.smethod_0(gclass16_1, bool_0: true, null);
	}

	public static Class16 smethod_1(GClass16 gclass16_1, string string_9)
	{
		return Delegate60.smethod_0(gclass16_1, bool_0: false, string_9);
	}

	private Class16(GClass16 gclass16_1, bool bool_1, string string_9)
	{
		gclass16_0 = gclass16_1;
		string text2 = default(string);
		FileVersionInfo fileVersionInfo = default(FileVersionInfo);
		string text9 = default(string);
		string text8 = default(string);
		while (true)
		{
			int num = Class8.smethod_0(42);
			int num2 = 6;
			while (true)
			{
				IL_00f2:
				num2 ^= 0x55;
				int num3 = Class10.smethod_0(85);
				while (true)
				{
					switch (num3 ^ 0x4F)
					{
					default:
						num3 = Class10.smethod_0(85);
						continue;
					case -82:
						break;
					case -83:
						goto IL_0082;
					case -81:
						goto IL_00f2;
					case -84:
						while (true)
						{
							num3 = -29;
							num3 = -84;
						}
					}
					break;
				}
				switch (num2)
				{
				case 81:
					goto IL_008f;
				case 82:
					goto IL_00db;
				case 83:
					goto IL_00e0;
				case 80:
					goto end_IL_00f2;
				}
				num3 = -30;
				num3 = -83;
				goto IL_0082;
				IL_00e0:
				num ^= 0x4E;
				num2 = 4;
				num3 = -32;
				num3 = -81;
				continue;
				IL_0082:
				num2 = 4;
				num3 = -32;
				num3 = -81;
				continue;
				IL_00db:
				num2 = 7;
				continue;
				IL_008f:
				switch (num)
				{
				default:
					num2 = 5;
					continue;
				case -80:
					class21_0 = Delegate51.smethod_0(gclass16_1);
					num = -4;
					break;
				case -79:
					num = -1;
					break;
				case -78:
					string_8 = string.Empty;
					num = Class8.smethod_0(41);
					break;
				case -77:
				{
					Class6 @class = Delegate61.smethod_0(class21_0);
					try
					{
						string text = Delegate62.smethod_0(this);
						while (true)
						{
							int num4 = Class8.smethod_0(57);
							while (true)
							{
								string text3;
								string text4;
								string text5;
								string text6;
								string text7;
								switch (num4 ^ 0x50)
								{
								case -85:
									text2 = Delegate63.smethod_0(class21_0);
									num4 = -6;
									num4 = -86;
									goto case -86;
								case -86:
									fileVersionInfo = null;
									num4 = -9;
									num4 = -89;
									goto case -89;
								case -89:
									if (text2 != null)
									{
										goto IL_0155;
									}
									if (1 == 0)
									{
										goto case -84;
									}
									goto IL_01cf;
								case -87:
									Delegate45.smethod_0(class21_0, "EXE executable path resolved to {0}", new object[1] { text });
									num4 = -5;
									num4 = -85;
									goto case -85;
								case -88:
									while (true)
									{
										num4 = -8;
										num4 = -88;
									}
								case -84:
									{
										fileVersionInfo = FileVersionInfo.GetVersionInfo(text2);
										goto IL_01cf;
									}
									IL_01cf:
									Delegate64.smethod_0(this, text, fileVersionInfo);
									text3 = ((Delegate65.smethod_0(gclass16_0) || 1 == 0) ? "/ini=nul " : ((string.IsNullOrEmpty(Delegate66.smethod_0(gclass16_0)) ? true : false) ? "" : string.Format(CultureInfo.InvariantCulture, "/ini=\"{0}\" ", new object[1] { Delegate66.smethod_0(gclass16_0) })));
									text4 = null;
									if (!string.IsNullOrEmpty(Delegate67.smethod_0(gclass16_0)) && 0 == 0)
									{
										text4 = string.Format(CultureInfo.InvariantCulture, "/log=\"{0}\" ", new object[1] { Delegate68.smethod_0(Delegate67.smethod_0(gclass16_0)) });
									}
									text5 = (((!bool_1) ? true : false) ? "" : string.Format(CultureInfo.InvariantCulture, "/xmllog=\"{0}\" /xmlgroups /xmllogrequired ", new object[1] { Delegate68.smethod_0(Delegate69.smethod_0(gclass16_0)) }));
									text6 = null;
									if (Delegate70.smethod_0(gclass16_0) > 0)
									{
										text6 = string.Format(CultureInfo.InvariantCulture, "/loglevel={0} ", new object[1] { Delegate70.smethod_0(gclass16_0) });
									}
									text7 = ((fileVersionInfo == null) ? "unk" : string.Format(CultureInfo.InvariantCulture, "{0}{1}{2} ", new object[3] { fileVersionInfo.ProductMajorPart, fileVersionInfo.ProductMinorPart, fileVersionInfo.ProductBuildPart }));
									while (true)
									{
										int num5 = Class8.smethod_0(38);
										while (true)
										{
											switch (num5 ^ 0x52)
											{
											case -80:
												goto IL_034b;
											case -82:
												text9 = string.Format(CultureInfo.InvariantCulture, "/dotnet={0} ", new object[1] { text7 });
												num5 = -1;
												num5 = -83;
												goto case -83;
											case -83:
												text8 = text5 + "/nointeractiveinput " + text9 + text3 + text4 + text6 + Delegate71.smethod_0(gclass16_0);
												num5 = -30;
												num5 = -80;
												goto IL_034b;
											case -84:
												while (true)
												{
													num5 = -2;
													num5 = -84;
												}
											case -81:
												if (string.IsNullOrEmpty(string_9))
												{
													num5 = -29;
													num5 = -79;
												}
												else if (0 == 0)
												{
													text8 = text8 + " " + string_9;
												}
												goto case -79;
											case -79:
												process_0 = new Process();
												while (true)
												{
													int num6 = GEventArgs2.smethod_1(59);
													while (true)
													{
														switch (num6 ^ 0x50)
														{
														case -80:
															goto IL_044b;
														case -78:
															while (true)
															{
																num6 = -30;
																num6 = -78;
															}
														case -76:
															process_0.StartInfo.WorkingDirectory = Path.GetDirectoryName(text);
															num6 = -31;
															num6 = -79;
															goto case -79;
														case -79:
															process_0.StartInfo.Arguments = text8;
															num6 = -29;
															num6 = -77;
															goto case -77;
														case -77:
															process_0.StartInfo.UseShellExecute = false;
															num6 = -27;
															num6 = -75;
															goto case -75;
														case -75:
															process_0.Exited += process_0_Exited;
															num6 = -26;
															num6 = -74;
															return;
														case -74:
															return;
														}
														break;
														IL_044b:
														process_0.StartInfo.FileName = text;
														num6 = Class10.smethod_0(84);
													}
												}
											}
											break;
											IL_034b:
											Delegate73.smethod_0(ref text8, Delegate72.smethod_0(gclass16_0), "/rawconfig");
											num5 = Class8.smethod_0(41);
										}
									}
								}
								break;
								IL_0155:
								num4 = Class8.smethod_0(38);
							}
						}
					}
					finally
					{
						if (@class != null || 1 == 0)
						{
							((IDisposable)@class).Dispose();
						}
					}
				}
				}
				goto IL_00e0;
				continue;
				end_IL_00f2:
				break;
			}
		}
	}

	private static string smethod_2(string string_9)
	{
		return Delegate74.smethod_0(string_9).Replace("!", "!!");
	}

	public void method_0()
	{
		Class6 @class = Delegate61.smethod_0(class21_0);
		try
		{
			lock (object_0)
			{
				if ((process_0 != null || 1 == 0) && !process_0.HasExited && 0 == 0)
				{
					process_0.Kill();
				}
			}
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	public void method_1()
	{
		Class6 @class = Delegate61.smethod_0(class21_0);
		try
		{
			Delegate75.smethod_0(this);
			Delegate76.smethod_0(this);
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	private void method_2()
	{
		Class6 @class = Delegate61.smethod_0(class21_0);
		try
		{
			process_0.StartInfo.Arguments += string.Format(CultureInfo.InvariantCulture, " /console /consoleinstance={0}", new object[1] { string_6 });
			if (!string.IsNullOrEmpty(Delegate77.smethod_0(gclass16_0)) && 0 == 0)
			{
				Delegate45.smethod_0(class21_0, "Will run process as {0}", new object[1] { Delegate77.smethod_0(gclass16_0) });
				while (true)
				{
					int num = 5;
					int num2 = -8;
					while (true)
					{
						num2 ^= 0x54;
						while (true)
						{
							int num3 = 24;
							int num4 = 25;
							while (true)
							{
								num4 ^= 0x4E;
								while (true)
								{
									int num5 = 25;
									int num6 = 8;
									while (true)
									{
										num6 ^= 0x51;
										while (true)
										{
											int num7 = 3;
											int num8 = 3;
											while (true)
											{
												num8 ^= 0x55;
												int num9;
												while (true)
												{
													num9 = Class8.smethod_0(37);
													while (true)
													{
														switch (num9 ^ 0x58)
														{
														case -88:
															break;
														default:
															goto end_IL_00ac;
														case -86:
															num8 = 0;
															num9 = -13;
															num9 = -85;
															goto end_IL_00cd;
														case -85:
															goto end_IL_00cd;
														case -87:
															while (true)
															{
																num9 = -15;
																num9 = -87;
															}
														}
														switch (num8)
														{
														case 84:
															goto IL_00d8;
														case 85:
															goto IL_00e0;
														case 86:
															goto IL_026d;
														case 83:
															goto end_IL_028c;
														}
														num9 = GEventArgs2.smethod_0(44);
														continue;
														IL_00d8:
														num8 = 1;
														goto end_IL_00cd;
														continue;
														end_IL_00ac:
														break;
													}
													continue;
													end_IL_00cd:
													break;
												}
												continue;
												IL_0251:
												num4 = 26;
												num5 = 24;
												goto IL_0259;
												IL_00e0:
												switch (num7)
												{
												case 85:
													goto IL_0102;
												case 86:
													goto IL_0260;
												case 87:
													goto IL_026a;
												case 88:
													goto end_IL_0298;
												}
												num8 = 6;
												continue;
												IL_026a:
												num7 = 1;
												goto IL_026d;
												IL_0102:
												switch (num6)
												{
												case 88:
													goto IL_0124;
												case 89:
													goto IL_0259;
												case 87:
													goto IL_02a0;
												case 86:
													goto end_IL_02a8;
												}
												num7 = 0;
												goto IL_026d;
												IL_02a0:
												num6 = 6;
												goto end_IL_0298;
												IL_0124:
												switch (num5)
												{
												case 83:
													break;
												case 84:
													goto IL_014c;
												case 82:
													goto IL_0251;
												default:
													goto IL_02a5;
												case 85:
													goto end_IL_02b1;
												}
												num5 = 30;
												goto IL_0259;
												IL_02a5:
												num6 = 7;
												goto end_IL_0298;
												IL_014c:
												switch (num4)
												{
												case 84:
													goto IL_016f;
												case 87:
													goto IL_024a;
												case 86:
													goto IL_02c0;
												case 85:
													goto end_IL_02c4;
												}
												num5 = 31;
												goto IL_0259;
												IL_02c0:
												num4 = 24;
												goto end_IL_02b1;
												IL_016f:
												switch (num3)
												{
												case 85:
													break;
												case 87:
													goto IL_0197;
												case 86:
													goto IL_023d;
												default:
													goto IL_02ba;
												case 88:
													goto end_IL_02cd;
												}
												num3 = 26;
												goto IL_024a;
												IL_02ba:
												num4 = 27;
												goto end_IL_02b1;
												IL_0197:
												switch (num2)
												{
												case -86:
													goto IL_01ba;
												case -84:
													goto IL_0236;
												case -87:
													goto IL_02d7;
												case -85:
													goto end_IL_02e0;
												}
												num3 = 25;
												goto IL_024a;
												IL_02d7:
												num2 = -3;
												goto end_IL_02cd;
												IL_01ba:
												switch (num)
												{
												case 89:
													break;
												case 90:
													goto IL_01fd;
												case 91:
													goto IL_0213;
												case 92:
													goto IL_0218;
												default:
													goto IL_02dd;
												case 93:
													goto end_IL_02e9;
												}
												process_0.StartInfo.Password = Delegate78.smethod_0(gclass16_0);
												num = 3;
												goto IL_0236;
												IL_02dd:
												num2 = -1;
												goto end_IL_02cd;
												IL_0218:
												process_0.StartInfo.UserName = Delegate77.smethod_0(gclass16_0);
												num = 0;
												goto IL_0236;
												IL_0213:
												num = 2;
												goto IL_0236;
												IL_01fd:
												process_0.StartInfo.LoadUserProfile = true;
												num = 4;
												goto IL_0236;
												IL_0260:
												num6 = 9;
												num7 = 14;
												goto IL_026d;
												IL_0236:
												num ^= 0x59;
												goto IL_023d;
												IL_023d:
												num2 = Class8.smethod_0(42);
												num3 = 23;
												goto IL_024a;
												IL_026d:
												num7 ^= 0x56;
												num8 = 0;
												num9 = -13;
												num9 = -85;
												continue;
												IL_0259:
												num5 ^= 0x4D;
												goto IL_0260;
												IL_024a:
												num3 ^= 0x4F;
												goto IL_0251;
												continue;
												end_IL_028c:
												break;
											}
											continue;
											end_IL_0298:
											break;
										}
										continue;
										end_IL_02a8:
										break;
									}
									continue;
									end_IL_02b1:
									break;
								}
								continue;
								end_IL_02c4:
								break;
							}
							continue;
							end_IL_02cd:
							break;
						}
						continue;
						end_IL_02e0:
						break;
					}
					continue;
					end_IL_02e9:
					break;
				}
				Delegate79.smethod_0(class21_0, "Granting access to window station");
				try
				{
					IntPtr intptr_ = Delegate80.smethod_0();
					Delegate81.smethod_0(this, intptr_, 983935);
				}
				catch (Exception exception_)
				{
					throw Delegate82.smethod_0(gclass16_0, "Error granting access to window station", exception_);
				}
				Delegate79.smethod_0(class21_0, "Granting access to desktop");
				try
				{
					IntPtr intptr_2 = Delegate84.smethod_0(Delegate83.smethod_0());
					Delegate81.smethod_0(this, intptr_2, 983551);
				}
				catch (Exception exception_2)
				{
					throw Delegate82.smethod_0(gclass16_0, "Error granting access to desktop", exception_2);
				}
			}
			Delegate45.smethod_0(class21_0, "Starting \"{0}\" {1}", new object[2]
			{
				process_0.StartInfo.FileName,
				process_0.StartInfo.Arguments
			});
			process_0.Start();
			Delegate45.smethod_0(class21_0, "Started process {0}", new object[1] { process_0.Id });
			thread_0 = new Thread(method_5);
			thread_0.IsBackground = true;
			thread_0.Start();
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	private void method_3(IntPtr intptr_0, int int_1)
	{
		SafeHandle safeHandle = Delegate85.smethod_0(intptr_0);
		try
		{
			Class19 @class = Delegate86.smethod_0(bool_0: false, ResourceType.WindowObject, safeHandle, AccessControlSections.Access);
			Delegate88.smethod_0(@class, Delegate87.smethod_0(new NTAccount(Delegate77.smethod_0(gclass16_0)), int_1, AccessControlType.Allow));
			Delegate89.smethod_0(@class, safeHandle, AccessControlSections.Access);
		}
		finally
		{
			if (safeHandle != null || 1 == 0)
			{
				((IDisposable)safeHandle).Dispose();
			}
		}
	}

	private void process_0_Exited(object sender, EventArgs e)
	{
		Delegate45.smethod_0(class21_0, "Process {0} exited with exit code {1}", new object[2] { process_0.Id, process_0.ExitCode });
	}

	private bool method_4()
	{
		if (bool_0 || 1 == 0)
		{
			Delegate79.smethod_0(class21_0, "Aborted");
			return true;
		}
		if (process_0.HasExited || 1 == 0)
		{
			Delegate79.smethod_0(class21_0, "Exited");
			return true;
		}
		return false;
	}

	private void method_5()
	{
		Class6 @class = Delegate61.smethod_0(class21_0);
		try
		{
			while ((!Delegate92.smethod_0(this)) ? true : false)
			{
				Delegate52.smethod_0(class21_0, 1, "Waiting for request event");
				if (eventWaitHandle_0.WaitOne(100, exitContext: false) || 1 == 0)
				{
					Delegate52.smethod_0(class21_0, 1, "Got request event");
					Delegate90.smethod_0(this);
				}
				if (Delegate91.smethod_0(class21_0) >= 1)
				{
					Delegate79.smethod_0(class21_0, string.Format(CultureInfo.InvariantCulture, "2nd generation collection count: {0}", new object[1] { GC.CollectionCount(2) }));
					Delegate79.smethod_0(class21_0, string.Format(CultureInfo.InvariantCulture, "Total memory allocated: {0}", new object[1] { GC.GetTotalMemory(forceFullCollection: false) }));
				}
			}
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	private void method_6()
	{
		Class6 @class = Delegate61.smethod_0(class21_0);
		try
		{
			Class15 class2 = Delegate93.smethod_0(this);
			try
			{
				switch (Delegate94.smethod_0(class2))
				{
				default:
					throw new NotImplementedException();
				case GEnum0.const_1:
					Delegate96.smethod_0(this, Delegate95.smethod_0(class2));
					break;
				case GEnum0.const_2:
					Delegate98.smethod_0(this, Delegate97.smethod_0(class2));
					break;
				case GEnum0.const_3:
					Delegate100.smethod_0(this, Delegate99.smethod_0(class2));
					break;
				case GEnum0.const_4:
					Delegate102.smethod_0(this, Delegate101.smethod_0(class2));
					break;
				case GEnum0.const_5:
					Delegate104.smethod_0(this, Delegate103.smethod_0(class2));
					break;
				case GEnum0.const_6:
					Delegate106.smethod_0(this, Delegate105.smethod_0(class2));
					break;
				}
			}
			finally
			{
				if (class2 != null || 1 == 0)
				{
					((IDisposable)class2).Dispose();
				}
			}
			eventWaitHandle_1.Set();
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	private void method_7(Class11 class11_0)
	{
		Class6 @class = Delegate61.smethod_0(class21_0);
		try
		{
			if (class11_0.bool_0 || 1 == 0)
			{
				while (true)
				{
					int num = Class10.smethod_0(85);
					int num2 = 15;
					while (true)
					{
						num2 ^= 0x53;
						while (true)
						{
							int num3 = 30;
							int num4 = 12;
							while (true)
							{
								num4 ^= 0x55;
								while (true)
								{
									int num5 = Class8.smethod_0(58);
									int num6 = -2;
									while (true)
									{
										num6 ^= 0x4E;
										while (true)
										{
											int num7 = GEventArgs2.smethod_0(46);
											int num8 = 20;
											while (true)
											{
												num8 ^= 0x4D;
												while (true)
												{
													int num9 = 9;
													int num10 = Class8.smethod_0(51);
													while (true)
													{
														switch (num10 ^ 0x56)
														{
														case -79:
															break;
														default:
															goto IL_0029;
														case -81:
															goto IL_0037;
														case -80:
															goto end_IL_01e6;
														case -82:
															while (true)
															{
																num10 = -8;
																num10 = -82;
															}
														}
														goto IL_0022;
														IL_0037:
														switch (num9)
														{
														case 80:
															break;
														case 81:
															goto IL_01d1;
														case 82:
															goto IL_01d9;
														default:
															goto IL_020c;
														case 83:
															goto end_IL_0214;
														}
														switch (num8)
														{
														case 86:
															goto IL_0076;
														case 89:
															goto IL_01c8;
														case 88:
															goto IL_0229;
														case 87:
															goto end_IL_022d;
														}
														num9 = 11;
														goto IL_0022;
														IL_020c:
														num10 = -26;
														num10 = -80;
														break;
														IL_01d1:
														num9 = 8;
														goto IL_0022;
														IL_01b4:
														num5 ^= 0x58;
														goto IL_01bb;
														IL_0229:
														num8 = 21;
														goto end_IL_0214;
														IL_0076:
														switch (num7)
														{
														case -83:
															break;
														case -82:
															goto IL_009e;
														case -81:
															goto IL_01bb;
														default:
															goto IL_0223;
														case -80:
															goto end_IL_0236;
														}
														num7 = -12;
														goto IL_01c8;
														IL_0223:
														num8 = 26;
														goto end_IL_0214;
														IL_009e:
														switch (num6)
														{
														case -83:
															goto IL_00c6;
														case -80:
															goto IL_01b4;
														case -82:
															goto IL_0250;
														case -81:
															goto end_IL_0254;
														}
														num7 = GEventArgs2.smethod_0(49);
														goto IL_01c8;
														IL_0250:
														num6 = -32;
														goto end_IL_0236;
														IL_00c6:
														switch (num5)
														{
														case -85:
															break;
														case -84:
															goto IL_01a1;
														case -83:
															goto IL_01b0;
														default:
															goto IL_0245;
														case -82:
															goto end_IL_025d;
														}
														switch (num4)
														{
														case 88:
															goto IL_0108;
														case 89:
															goto IL_019c;
														case 86:
															goto IL_026c;
														case 87:
															goto end_IL_0274;
														}
														num5 = -12;
														goto IL_01b4;
														IL_0245:
														num6 = Class10.smethod_0(85);
														goto end_IL_0236;
														IL_01b0:
														num5 = -11;
														goto IL_01b4;
														IL_01c8:
														num7 ^= 0x59;
														goto IL_01d9;
														IL_026c:
														num4 = 3;
														goto end_IL_025d;
														IL_0108:
														switch (num3)
														{
														case 81:
															break;
														case 82:
															goto IL_0192;
														case 83:
															goto IL_0197;
														default:
															goto IL_0271;
														case 84:
															goto end_IL_027d;
														}
														switch (num2)
														{
														case 91:
															goto IL_0144;
														case 92:
															goto IL_018b;
														case 89:
															goto IL_0286;
														case 90:
															goto end_IL_028e;
														}
														num3 = 28;
														goto IL_019c;
														IL_0271:
														num4 = 2;
														goto end_IL_025d;
														IL_0192:
														num3 = 29;
														goto IL_019c;
														IL_01bb:
														num6 = GEventArgs2.smethod_1(68);
														num7 = -23;
														goto IL_01c8;
														IL_0286:
														num2 = 10;
														goto end_IL_027d;
														IL_0144:
														switch (num)
														{
														case -79:
															break;
														case -78:
															goto IL_0173;
														case -77:
															goto IL_0183;
														default:
															goto IL_028b;
														case -76:
															goto end_IL_0295;
														}
														class11_0.int_2 = class11_0.int_3;
														num = -25;
														goto IL_018b;
														IL_028b:
														num2 = 9;
														goto end_IL_027d;
														IL_0183:
														num = GEventArgs2.smethod_1(59);
														goto IL_018b;
														IL_0173:
														Thread.Sleep((int)class11_0.uint_0);
														num = -30;
														goto IL_018b;
														IL_0029:
														num10 = Class8.smethod_0(57);
														continue;
														IL_018b:
														num ^= 0x53;
														goto IL_0197;
														IL_0197:
														num2 = 8;
														num3 = 27;
														goto IL_019c;
														IL_0022:
														num9 ^= 0x59;
														goto IL_0029;
														IL_019c:
														num3 ^= 0x4F;
														goto IL_01a1;
														IL_01a1:
														num4 = 13;
														num5 = GEventArgs2.smethod_0(49);
														goto IL_01b4;
														IL_01d9:
														num8 = 27;
														num9 = 10;
														goto IL_0022;
														continue;
														end_IL_01e6:
														break;
													}
													continue;
													end_IL_0214:
													break;
												}
												continue;
												end_IL_022d:
												break;
											}
											continue;
											end_IL_0236:
											break;
										}
										continue;
										end_IL_0254:
										break;
									}
									continue;
									end_IL_025d:
									break;
								}
								continue;
								end_IL_0274:
								break;
							}
							continue;
							end_IL_027d:
							break;
						}
						continue;
						end_IL_028e:
						break;
					}
					continue;
					end_IL_0295:
					break;
				}
			}
			else
			{
				class11_0.int_2 = class11_0.int_1;
			}
			Delegate45.smethod_0(class21_0, "Options: [{0}], Timer: [{1}], Timeouting: [{2}], Timeouted: [{3}], Break: [{4}], Result: [{5}]", new object[6] { class11_0.string_0, class11_0.uint_0, class11_0.bool_0, class11_0.int_3, class11_0.int_1, class11_0.int_2 });
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	private void method_8(Class12 class12_0)
	{
		Class6 @class = Delegate61.smethod_0(class21_0);
		try
		{
			Delegate45.smethod_0(class21_0, "Not-supported title event [{0}]", new object[1] { class12_0.string_0 });
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	private void method_9(Class10 class10_0)
	{
		Class6 @class = Delegate61.smethod_0(class21_0);
		try
		{
			while ((!Delegate92.smethod_0(this)) ? true : false)
			{
				lock (list_0)
				{
					if (list_0.Count > 0)
					{
						class10_0.Str = list_0[0];
						while (true)
						{
							int num = 2;
							int num2 = 13;
							while (true)
							{
								num2 ^= 0x58;
								while (true)
								{
									int num3 = Class8.smethod_0(51);
									int num4 = 10;
									while (true)
									{
										num4 ^= 0x53;
										while (true)
										{
											int num5 = Class10.smethod_0(80);
											int num6 = -29;
											while (true)
											{
												num6 ^= 0x4E;
												while (true)
												{
													int num7 = Class8.smethod_0(42);
													int num8 = -14;
													while (true)
													{
														num8 ^= 0x59;
														int num9 = Class8.smethod_0(58);
														int num10 = -30;
														num10 = -75;
														while (true)
														{
															IL_0263:
															num9 ^= 0x54;
															while (true)
															{
																num10 = GEventArgs2.smethod_1(68);
																switch (num10 ^ 0x57)
																{
																case -76:
																	goto end_IL_004e;
																case -77:
																	goto IL_009c;
																case -75:
																	goto IL_0263;
																case -78:
																	while (true)
																	{
																		num10 = -27;
																		num10 = -78;
																	}
																}
																continue;
																end_IL_004e:
																break;
															}
															switch (num9)
															{
															case -89:
																goto IL_00b2;
															case -88:
																goto IL_024b;
															case -87:
																goto IL_0251;
															case -86:
																goto end_IL_0263;
															}
															num10 = -28;
															num10 = -77;
															goto IL_009c;
															IL_0226:
															num4 = 11;
															num5 = -25;
															goto IL_022e;
															IL_0251:
															num8 = Class8.smethod_0(58);
															num9 = Class8.smethod_0(42);
															continue;
															IL_024b:
															num9 = -4;
															continue;
															IL_00b2:
															switch (num8)
															{
															case -86:
																goto IL_00d5;
															case -85:
																goto IL_0242;
															case -87:
																goto IL_026f;
															case -88:
																goto end_IL_0279;
															}
															num9 = -3;
															continue;
															IL_026f:
															num8 = -16;
															break;
															IL_00d5:
															switch (num7)
															{
															case -81:
																break;
															case -80:
																goto IL_00fd;
															case -79:
																goto IL_0235;
															default:
																goto IL_0275;
															case -78:
																goto end_IL_0293;
															}
															num7 = -31;
															goto IL_0242;
															IL_0275:
															num8 = -15;
															break;
															IL_00fd:
															switch (num6)
															{
															case -85:
																goto IL_011f;
															case -83:
																goto IL_022e;
															case -84:
																goto IL_02a8;
															case -86:
																goto end_IL_02ac;
															}
															num7 = -1;
															goto IL_0242;
															IL_02a8:
															num6 = -30;
															goto end_IL_0293;
															IL_011f:
															switch (num5)
															{
															case -89:
																break;
															case -88:
																goto IL_0220;
															case -87:
																goto IL_0226;
															default:
																goto IL_02a2;
															case -86:
																goto end_IL_02b5;
															}
															switch (num4)
															{
															case 88:
																goto IL_0166;
															case 89:
																goto IL_0217;
															case 87:
																goto IL_02c4;
															case 86:
																goto end_IL_02cc;
															}
															num5 = Class10.smethod_0(84);
															goto IL_022e;
															IL_02a2:
															num6 = -28;
															goto end_IL_0293;
															IL_0220:
															num5 = -27;
															goto IL_022e;
															IL_0242:
															num7 ^= 0x4E;
															goto IL_0251;
															IL_02c4:
															num4 = 4;
															goto end_IL_02b5;
															IL_0166:
															switch (num3)
															{
															case -76:
																break;
															case -77:
																goto IL_0205;
															case -75:
																goto IL_0213;
															default:
																goto IL_02c9;
															case -74:
																goto end_IL_02d5;
															}
															switch (num2)
															{
															case 84:
																goto IL_01a4;
															case 85:
																goto IL_0200;
															case 83:
																goto IL_02e4;
															case 82:
																goto end_IL_02ec;
															}
															num3 = -32;
															goto IL_0217;
															IL_02c9:
															num4 = 5;
															goto end_IL_02b5;
															IL_0213:
															num3 = -26;
															goto IL_0217;
															IL_0235:
															num6 = Class10.smethod_0(88);
															num7 = -4;
															goto IL_0242;
															IL_02e4:
															num2 = 11;
															goto end_IL_02d5;
															IL_01a4:
															switch (num)
															{
															case 84:
																break;
															case 85:
																goto IL_01d6;
															case 86:
																goto IL_01e1;
															case 87:
																goto IL_01e5;
															default:
																goto IL_02e9;
															case 88:
																return;
															}
															list_0.RemoveAt(0);
															num = 0;
															goto IL_0200;
															IL_02e9:
															num2 = 10;
															goto end_IL_02d5;
															IL_01e5:
															Delegate107.smethod_0(this, bool_0: false, bool_1: false, class10_0.Str + "\n");
															num = 15;
															goto IL_0200;
															IL_01e1:
															num = 1;
															goto IL_0200;
															IL_01d6:
															class10_0.bool_1 = true;
															num = 3;
															goto IL_0200;
															IL_009c:
															num9 = Class8.smethod_0(58);
															num10 = -30;
															num10 = -75;
															continue;
															IL_0200:
															num ^= 0x57;
															goto IL_0205;
															IL_0205:
															num2 = 12;
															num3 = Class10.smethod_0(88);
															goto IL_0217;
															IL_022e:
															num5 ^= 0x4D;
															goto IL_0235;
															IL_0217:
															num3 ^= 0x53;
															goto IL_0226;
															continue;
															end_IL_0263:
															break;
														}
														continue;
														end_IL_0279:
														break;
													}
													continue;
													end_IL_0293:
													break;
												}
												continue;
												end_IL_02ac:
												break;
											}
											continue;
											end_IL_02b5:
											break;
										}
										continue;
										end_IL_02cc:
										break;
									}
									continue;
									end_IL_02d5:
									break;
								}
								continue;
								end_IL_02ec:
								break;
							}
						}
					}
				}
				autoResetEvent_0.WaitOne(100, exitContext: false);
			}
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	private void method_10(bool bool_1, bool bool_2, string string_9)
	{
		if ((bool_1 || 1 == 0) && (((string_9.Length == 0) ? true : false) || string_9[0] != '\n'))
		{
			string_7 = string_9;
			Delegate45.smethod_0(class21_0, "Buffered from-beginning message [{0}]", new object[1] { string_7 });
			if (gdelegate0_0 != null || 1 == 0)
			{
				Delegate108.smethod_0(gdelegate0_0, this, null);
			}
			return;
		}
		if (!string.IsNullOrEmpty(string_7) && 0 == 0)
		{
			Delegate109.smethod_0(this, string_7, bool_0: false);
			string_7 = null;
		}
		if ((bool_1 || 1 == 0) && string_9.Length > 0 && string_9[0] == '\n')
		{
			Delegate109.smethod_0(this, "\n", bool_0: false);
			while (true)
			{
				int num = Class8.smethod_0(50);
				int num2 = 1;
				while (true)
				{
					num2 ^= 0x55;
					while (true)
					{
						int num3 = 2;
						int num4 = -29;
						while (true)
						{
							num4 ^= 0x56;
							while (true)
							{
								int num5 = 26;
								int num6 = 6;
								while (true)
								{
									num6 ^= 0x52;
									while (true)
									{
										int num7 = GEventArgs2.smethod_0(43);
										int num8 = -21;
										while (true)
										{
											IL_02c1:
											num8 ^= 0x59;
											int num9 = GEventArgs2.smethod_0(40);
											while (true)
											{
												switch (num9 ^ 0x52)
												{
												case -87:
													num9 = Class8.smethod_0(47);
													continue;
												default:
													num9 = GEventArgs2.smethod_0(40);
													continue;
												case -89:
													break;
												case -88:
													goto IL_02b0;
												case -86:
													goto IL_02c1;
												}
												break;
											}
											switch (num8)
											{
											case -81:
												goto IL_0123;
											case -79:
												goto IL_012c;
											case -78:
												goto IL_0296;
											case -80:
												goto end_IL_02c1;
											}
											num9 = -6;
											num9 = -88;
											goto IL_02b0;
											IL_0296:
											num7 ^= 0x52;
											num8 = Class10.smethod_0(82);
											num9 = -8;
											num9 = -86;
											continue;
											IL_0288:
											num5 ^= 0x55;
											goto IL_028f;
											IL_012c:
											switch (num7)
											{
											case -88:
												goto IL_0154;
											case -86:
												goto IL_0162;
											case -87:
												goto IL_028f;
											case -85:
												goto end_IL_02d6;
											}
											num8 = GEventArgs2.smethod_1(52);
											continue;
											IL_0162:
											switch (num6)
											{
											case 81:
												goto IL_0185;
											case 84:
												goto IL_0288;
											case 82:
												goto IL_02ea;
											case 83:
												goto end_IL_02ed;
											}
											num7 = -5;
											goto IL_0296;
											IL_02ea:
											num6 = 0;
											goto end_IL_02d6;
											IL_0185:
											switch (num5)
											{
											case 77:
												break;
											case 79:
												goto IL_01ad;
											case 78:
												goto IL_027d;
											default:
												goto IL_02e5;
											case 80:
												goto end_IL_02f6;
											}
											num5 = 24;
											goto IL_0288;
											IL_02e5:
											num6 = 1;
											goto end_IL_02d6;
											IL_01ad:
											switch (num4)
											{
											case -76:
												goto IL_01cf;
											case -75:
												goto IL_0278;
											case -77:
												goto IL_02ff;
											case -78:
												goto end_IL_030c;
											}
											num5 = 27;
											goto IL_0288;
											IL_02ff:
											num4 = -27;
											goto end_IL_02f6;
											IL_01cf:
											switch (num3)
											{
											case 79:
												break;
											case 80:
												goto IL_026e;
											case 81:
												goto IL_0273;
											default:
												goto IL_0304;
											case 82:
												goto end_IL_0313;
											}
											switch (num2)
											{
											case 83:
												goto IL_020b;
											case 84:
												goto IL_0267;
											case 81:
												goto IL_031a;
											case 82:
												goto end_IL_0320;
											}
											num3 = 28;
											goto IL_0278;
											IL_0304:
											num4 = Class10.smethod_0(84);
											goto end_IL_02f6;
											IL_026e:
											num3 = 29;
											goto IL_0278;
											IL_0123:
											num8 = -10;
											continue;
											IL_031a:
											num2 = 4;
											goto end_IL_0313;
											IL_020b:
											switch (num)
											{
											case -89:
												break;
											case -88:
												goto IL_0233;
											case -87:
												goto IL_0245;
											default:
												goto IL_031e;
											case -86:
												return;
											}
											num = GEventArgs2.smethod_1(52);
											goto IL_0267;
											IL_031e:
											num2 = 7;
											goto end_IL_0313;
											IL_0245:
											Delegate45.smethod_0(class21_0, "Buffered from-beginning message [{0}]", new object[1] { string_7 });
											num = -28;
											goto IL_0267;
											IL_0233:
											string_7 = string_9.Substring(1);
											num = -25;
											goto IL_0267;
											IL_02b0:
											num8 = Class10.smethod_0(82);
											num9 = -8;
											num9 = -86;
											continue;
											IL_0267:
											num ^= 0x4E;
											goto IL_0273;
											IL_0273:
											num2 = 6;
											num3 = 31;
											goto IL_0278;
											IL_028f:
											num6 = 3;
											num7 = -7;
											goto IL_0296;
											IL_0278:
											num3 ^= 0x4D;
											goto IL_027d;
											IL_027d:
											num4 = Class8.smethod_0(53);
											num5 = 5;
											goto IL_0288;
											IL_0154:
											num7 = Class8.smethod_0(48);
											goto IL_0296;
											continue;
											end_IL_02c1:
											break;
										}
										continue;
										end_IL_02d6:
										break;
									}
									continue;
									end_IL_02ed:
									break;
								}
								continue;
								end_IL_02f6:
								break;
							}
							continue;
							end_IL_030c:
							break;
						}
						continue;
						end_IL_0313:
						break;
					}
					continue;
					end_IL_0320:
					break;
				}
			}
		}
		Delegate109.smethod_0(this, string_9, bool_2);
	}

	private void method_11(string string_9, bool bool_1)
	{
		string[] array = (string_8 + string_9).Split(new char[1] { '\n' });
		int num9 = default(int);
		while (true)
		{
			int num = 12;
			int num2 = 31;
			while (true)
			{
				num2 ^= 0x4D;
				while (true)
				{
					int num3 = 29;
					int num4 = Class8.smethod_0(48);
					while (true)
					{
						num4 ^= 0x50;
						while (true)
						{
							int num5 = GEventArgs2.smethod_1(56);
							int num6 = -1;
							while (true)
							{
								num6 ^= 0x50;
								int num7 = Class8.smethod_0(41);
								int num8 = -32;
								num8 = -77;
								while (true)
								{
									IL_0210:
									num7 ^= 0x52;
									num8 = GEventArgs2.smethod_1(68);
									while (true)
									{
										switch (num8 ^ 0x53)
										{
										case -78:
											num8 = Class10.smethod_0(85);
											continue;
										default:
											num8 = GEventArgs2.smethod_1(68);
											continue;
										case -80:
											break;
										case -79:
											goto IL_01ff;
										case -77:
											goto IL_0210;
										}
										break;
									}
									switch (num7)
									{
									case -82:
										goto IL_0080;
									case -81:
										goto IL_0089;
									case -80:
										goto IL_01f0;
									case -79:
										goto end_IL_0210;
									}
									num8 = -30;
									num8 = -79;
									goto IL_01ff;
									IL_01dc:
									num4 = GEventArgs2.smethod_0(43);
									num5 = -19;
									goto IL_01e9;
									IL_01e9:
									num5 ^= 0x59;
									goto IL_01f0;
									IL_0089:
									switch (num6)
									{
									case -84:
										goto IL_00b1;
									case -81:
										goto IL_01e9;
									case -83:
										goto IL_022b;
									case -82:
										goto end_IL_0234;
									}
									num7 = Class8.smethod_0(53);
									continue;
									IL_022b:
									num6 = Class8.smethod_0(41);
									break;
									IL_00b1:
									switch (num5)
									{
									case -79:
										break;
									case -78:
										goto IL_00d9;
									case -77:
										goto IL_01dc;
									default:
										goto IL_0225;
									case -76:
										goto end_IL_024e;
									}
									num5 = -24;
									goto IL_01e9;
									IL_0225:
									num6 = -2;
									break;
									IL_00d9:
									switch (num4)
									{
									case -88:
										goto IL_00fc;
									case -86:
										goto IL_01d5;
									case -89:
										goto IL_025c;
									case -87:
										goto end_IL_0266;
									}
									num5 = -22;
									goto IL_01e9;
									IL_025c:
									num4 = -9;
									goto end_IL_024e;
									IL_00fc:
									switch (num3)
									{
									case 78:
										break;
									case 79:
										goto IL_0124;
									case 80:
										goto IL_01cf;
									default:
										goto IL_0262;
									case 81:
										goto end_IL_026f;
									}
									num3 = 28;
									goto IL_01d5;
									IL_0262:
									num4 = -7;
									goto end_IL_024e;
									IL_0124:
									switch (num2)
									{
									case 80:
										goto IL_0145;
									case 82:
										goto IL_01ca;
									case 79:
										goto IL_027e;
									case 81:
										goto end_IL_0285;
									}
									num3 = 2;
									goto IL_01d5;
									IL_027e:
									num2 = 2;
									goto end_IL_026f;
									IL_0145:
									switch (num)
									{
									case 86:
										break;
									case 88:
										goto IL_016f;
									case 89:
										if (num9 != 0)
										{
											goto IL_0179;
										}
										goto IL_0196;
									case 90:
										goto IL_017d;
									case 87:
										if (gdelegate0_0 == null)
										{
											if (true)
											{
												goto IL_0192;
											}
											goto case 91;
										}
										goto IL_01c7;
									case 91:
										Delegate108.smethod_0(gdelegate0_0, this, Delegate110.smethod_0(array[num9], bool_1));
										goto IL_0192;
									default:
										goto IL_0282;
										IL_0196:
										if (num9 >= array.Length - 1)
										{
											return;
										}
										goto case 87;
										IL_0192:
										num9++;
										goto IL_0196;
									}
									num = 0;
									goto IL_01ca;
									IL_0282:
									num2 = 28;
									goto end_IL_026f;
									IL_017d:
									string_8 = array[^1];
									num = 14;
									goto IL_01ca;
									IL_0179:
									num = 1;
									goto IL_01ca;
									IL_01c7:
									num = 13;
									goto IL_01ca;
									IL_016f:
									num9 = 0;
									num = 15;
									goto IL_01ca;
									IL_01ff:
									num7 = Class8.smethod_0(41);
									num8 = -32;
									num8 = -77;
									continue;
									IL_01ca:
									num ^= 0x56;
									goto IL_01cf;
									IL_01cf:
									num2 = 29;
									num3 = 3;
									goto IL_01d5;
									IL_01f0:
									num6 = Class8.smethod_0(38);
									num7 = -29;
									continue;
									IL_0080:
									num7 = -4;
									continue;
									IL_01d5:
									num3 ^= 0x52;
									goto IL_01dc;
									continue;
									end_IL_0210:
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
						continue;
						end_IL_0266:
						break;
					}
					continue;
					end_IL_026f:
					break;
				}
				continue;
				end_IL_0285:
				break;
			}
		}
	}

	private void method_12(Class9 class9_0)
	{
		Delegate52.smethod_0(class21_0, 1, string.Format(CultureInfo.CurrentCulture, "Print: {0}", new object[1] { class9_0.string_0 }));
		Delegate107.smethod_0(this, class9_0.bool_0, class9_0.bool_1, class9_0.string_0);
	}

	private void method_13(Class8 class8_0)
	{
		Class6 @class = Delegate61.smethod_0(class21_0);
		try
		{
			class8_0.uint_0 = 3u;
			while (true)
			{
				int num = Class8.smethod_0(39);
				int num2 = 7;
				while (true)
				{
					num2 ^= 0x50;
					while (true)
					{
						int num3 = GEventArgs2.smethod_1(52);
						int num4 = 9;
						while (true)
						{
							num4 ^= 0x51;
							while (true)
							{
								int num5 = Class8.smethod_0(51);
								int num6 = Class10.smethod_0(88);
								while (true)
								{
									num6 ^= 0x50;
									while (true)
									{
										int num7 = Class10.smethod_0(88);
										int num8 = 3;
										while (true)
										{
											num8 ^= 0x55;
											int num9 = 25;
											int num10 = -2;
											num10 = -77;
											while (true)
											{
												num9 ^= 0x4F;
												while (true)
												{
													num10 = Class8.smethod_0(41);
													while (true)
													{
														switch (num10 ^ 0x4D)
														{
														case -80:
															break;
														default:
															goto end_IL_003b;
														case -78:
															num9 = 25;
															num10 = -2;
															num10 = -77;
															goto end_IL_005c;
														case -77:
															goto end_IL_005c;
														case -79:
															while (true)
															{
																num10 = -4;
																num10 = -79;
															}
														}
														switch (num9)
														{
														case 84:
															goto IL_0067;
														case 86:
															goto IL_0070;
														case 85:
															goto IL_01ea;
														case 87:
															goto end_IL_01ff;
														}
														num10 = Class8.smethod_0(39);
														continue;
														IL_0067:
														num9 = 27;
														goto end_IL_005c;
														continue;
														end_IL_003b:
														break;
													}
													continue;
													end_IL_005c:
													break;
												}
												continue;
												IL_01bd:
												num4 = 7;
												num5 = -26;
												goto IL_01c4;
												IL_0070:
												switch (num8)
												{
												case 83:
													goto IL_0093;
												case 86:
													goto IL_01e3;
												case 84:
													goto IL_0210;
												case 85:
													goto end_IL_0213;
												}
												num9 = 26;
												continue;
												IL_0210:
												num8 = 1;
												break;
												IL_0093:
												switch (num7)
												{
												case -80:
													break;
												case -81:
													goto IL_01cb;
												case -79:
													goto IL_01da;
												default:
													goto IL_020b;
												case -78:
													goto end_IL_0228;
												}
												switch (num6)
												{
												case -78:
													goto IL_00d5;
												case -75:
													goto IL_01c4;
												case -76:
													goto IL_023c;
												case -77:
													goto end_IL_0240;
												}
												num7 = -6;
												goto IL_01e3;
												IL_020b:
												num8 = 0;
												break;
												IL_01da:
												num7 = Class10.smethod_0(84);
												goto IL_01e3;
												IL_01cb:
												num6 = Class8.smethod_0(53);
												num7 = -25;
												goto IL_01e3;
												IL_023c:
												num6 = -28;
												goto end_IL_0228;
												IL_00d5:
												switch (num5)
												{
												case -87:
													break;
												case -86:
													goto IL_00fd;
												case -88:
													goto IL_01bd;
												default:
													goto IL_0236;
												case -85:
													goto end_IL_0249;
												}
												num5 = -28;
												goto IL_01c4;
												IL_0236:
												num6 = -29;
												goto end_IL_0228;
												IL_00fd:
												switch (num4)
												{
												case 86:
													goto IL_0120;
												case 88:
													goto IL_01b8;
												case 87:
													goto IL_0262;
												case 85:
													goto end_IL_0265;
												}
												num5 = -27;
												goto IL_01c4;
												IL_0262:
												num4 = 6;
												goto end_IL_0249;
												IL_0120:
												switch (num3)
												{
												case -81:
													break;
												case -80:
													goto IL_0148;
												case -82:
													goto IL_01b3;
												default:
													goto IL_025d;
												case -79:
													goto end_IL_026e;
												}
												num3 = GEventArgs2.smethod_0(49);
												goto IL_01b8;
												IL_025d:
												num4 = 4;
												goto end_IL_0249;
												IL_0148:
												switch (num2)
												{
												case 85:
													goto IL_0166;
												case 87:
													goto IL_01ae;
												case 86:
													goto IL_0280;
												case 84:
													goto end_IL_0282;
												}
												num3 = -9;
												goto IL_01b8;
												IL_0280:
												num2 = 6;
												goto end_IL_026e;
												IL_0166:
												switch (num)
												{
												case -79:
													break;
												case -78:
													goto IL_019a;
												case -77:
													goto IL_01ab;
												default:
													goto IL_027c;
												case -76:
													return;
												}
												class8_0.bool_0 = Delegate111.smethod_0(gclass16_0);
												num = -7;
												goto IL_01ae;
												IL_027c:
												num2 = 4;
												goto end_IL_026e;
												IL_01ab:
												num = -2;
												goto IL_01ae;
												IL_019a:
												class8_0.uint_1 = 3u;
												num = Class8.smethod_0(38);
												goto IL_01ae;
												IL_01c4:
												num5 ^= 0x4D;
												goto IL_01cb;
												IL_01ae:
												num ^= 0x4D;
												goto IL_01b3;
												IL_01b3:
												num2 = 5;
												num3 = -24;
												goto IL_01b8;
												IL_01ea:
												num8 = 6;
												num9 = 24;
												continue;
												IL_01e3:
												num7 ^= 0x55;
												goto IL_01ea;
												IL_01b8:
												num3 ^= 0x59;
												goto IL_01bd;
												continue;
												end_IL_01ff:
												break;
											}
											continue;
											end_IL_0213:
											break;
										}
										continue;
										end_IL_0228:
										break;
									}
									continue;
									end_IL_0240:
									break;
								}
								continue;
								end_IL_0249:
								break;
							}
							continue;
							end_IL_0265:
							break;
						}
						continue;
						end_IL_026e:
						break;
					}
					continue;
					end_IL_0282:
					break;
				}
			}
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	private void method_14(Class13 class13_0)
	{
		Class6 @class = Delegate61.smethod_0(class21_0);
		try
		{
			Delegate45.smethod_0(class21_0, "File Name [{0}] - Directory [{1}] - Overall Progress [{2}] - File Progress [{3}] - CPS [{4}]", new object[5] { class13_0.string_0, class13_0.string_1, class13_0.uint_0, class13_0.uint_1, class13_0.uint_2 });
			Class13.Enum0 enum0_ = default(Class13.Enum0);
			GEventArgs1 e = default(GEventArgs1);
			while (true)
			{
				int num = Class10.smethod_0(85);
				int num2 = 28;
				while (true)
				{
					num2 ^= 0x4F;
					while (true)
					{
						int num3 = GEventArgs2.smethod_0(43);
						int num4 = 14;
						while (true)
						{
							num4 ^= 0x58;
							while (true)
							{
								int num5 = 31;
								int num6 = -5;
								while (true)
								{
									num6 ^= 0x4D;
									while (true)
									{
										int num7 = 26;
										int num8 = Class8.smethod_0(48);
										while (true)
										{
											switch (num8 ^ 0x4E)
											{
											case -76:
												break;
											case -79:
												goto IL_0078;
											default:
												num8 = Class8.smethod_0(39);
												continue;
											case -78:
												goto end_IL_01e0;
											case -77:
												while (true)
												{
													num8 = -3;
													num8 = -77;
												}
											}
											goto IL_0063;
											IL_0078:
											switch (num7)
											{
											case 78:
												break;
											case 77:
												goto IL_01bd;
											case 79:
												goto IL_01ce;
											default:
												goto IL_0203;
											case 80:
												goto end_IL_020b;
											}
											switch (num6)
											{
											case -77:
												goto IL_00b7;
											case -74:
												goto IL_01b6;
											case -76:
												goto IL_0220;
											case -75:
												goto end_IL_0229;
											}
											num7 = 25;
											goto IL_0063;
											IL_0203:
											num8 = -4;
											num8 = -78;
											break;
											IL_01ce:
											num7 = 27;
											goto IL_0063;
											IL_01b6:
											num5 ^= 0x4F;
											goto IL_01bd;
											IL_0220:
											num6 = Class8.smethod_0(57);
											goto end_IL_020b;
											IL_00b7:
											switch (num5)
											{
											case 80:
												break;
											case 79:
												goto IL_01a8;
											case 81:
												goto IL_01b2;
											default:
												goto IL_021a;
											case 82:
												goto end_IL_0232;
											}
											switch (num4)
											{
											case 83:
												goto IL_00f8;
											case 86:
												goto IL_01a1;
											case 84:
												goto IL_0242;
											case 85:
												goto end_IL_0246;
											}
											num5 = 0;
											goto IL_01b6;
											IL_021a:
											num6 = -8;
											goto end_IL_020b;
											IL_01b2:
											num5 = 30;
											goto IL_01b6;
											IL_01a1:
											num3 ^= 0x54;
											goto IL_01a8;
											IL_0242:
											num4 = 12;
											goto end_IL_0232;
											IL_00f8:
											switch (num3)
											{
											case -85:
												break;
											case -84:
												goto IL_0122;
											case -83:
												goto IL_0199;
											default:
												goto IL_023c;
											case -82:
												goto end_IL_024f;
											}
											num3 = Class8.smethod_0(39);
											goto IL_01a1;
											IL_023c:
											num4 = 13;
											goto end_IL_0232;
											IL_0122:
											switch (num2)
											{
											case 81:
												goto IL_0142;
											case 83:
												goto IL_0192;
											case 82:
												goto IL_0264;
											case 80:
												goto end_IL_0268;
											}
											num3 = -7;
											goto IL_01a1;
											IL_0264:
											num2 = 29;
											goto end_IL_024f;
											IL_0142:
											switch (num)
											{
											case -82:
												break;
											case -81:
												goto IL_0171;
											case -80:
												goto IL_017d;
											case -79:
												goto IL_018e;
											default:
												goto IL_025e;
											case -78:
												goto IL_0396;
											}
											if (enum0_ != 0)
											{
												num = -29;
												goto IL_0192;
											}
											if (0 == 0)
											{
												goto IL_0289;
											}
											goto IL_0396;
											IL_025e:
											num2 = 31;
											goto end_IL_024f;
											IL_018e:
											num = -32;
											goto IL_0192;
											IL_017d:
											e = Delegate112.smethod_0();
											num = Class8.smethod_0(42);
											goto IL_0192;
											IL_0171:
											enum0_ = class13_0.enum0_0;
											num = -1;
											goto IL_0192;
											IL_01bd:
											num6 = Class8.smethod_0(42);
											num7 = 4;
											goto IL_0063;
											IL_01a8:
											num4 = 11;
											num5 = 29;
											goto IL_01b6;
											IL_0192:
											num ^= 0x51;
											goto IL_0199;
											IL_0199:
											num2 = 30;
											num3 = -6;
											goto IL_01a1;
											IL_0063:
											num7 ^= 0x54;
											num8 = Class8.smethod_0(39);
											continue;
											IL_0396:
											throw new ArgumentOutOfRangeException("Unknown progress operation", (Exception?)null);
											continue;
											end_IL_01e0:
											break;
										}
										continue;
										end_IL_020b:
										break;
									}
									continue;
									end_IL_0229:
									break;
								}
								continue;
								end_IL_0232:
								break;
							}
							continue;
							end_IL_0246:
							break;
						}
						continue;
						end_IL_024f:
						break;
					}
					continue;
					IL_0289:
					Delegate113.smethod_0(e, GEnum2.const_0);
					Class13.Enum1 enum1_ = class13_0.enum1_0;
					if (enum1_ != 0 || 1 == 0)
					{
						if (enum1_ != Class13.Enum1.const_1)
						{
							throw new ArgumentOutOfRangeException("Unknown progress side", (Exception?)null);
						}
						Delegate114.smethod_0(e, GEnum3.const_1);
					}
					else
					{
						Delegate114.smethod_0(e, GEnum3.const_0);
					}
					Delegate115.smethod_0(e, class13_0.string_0);
					while (true)
					{
						int num9 = Class8.smethod_0(38);
						while (true)
						{
							switch (num9 ^ 0x57)
							{
							case -83:
								goto IL_02d1;
							case -84:
								Delegate117.smethod_0(e, (double)class13_0.uint_0 / 100.0);
								num9 = -3;
								num9 = -86;
								goto case -86;
							case -86:
								Delegate118.smethod_0(e, (double)class13_0.uint_1 / 100.0);
								num9 = -2;
								num9 = -87;
								goto case -87;
							case -87:
								Delegate119.smethod_0(e, (int)class13_0.uint_2);
								num9 = -6;
								num9 = -83;
								goto IL_02d1;
							case -85:
								Delegate116.smethod_0(e, class13_0.string_1);
								num9 = -5;
								num9 = -84;
								goto case -84;
							case -82:
								while (true)
								{
									num9 = -7;
									num9 = -82;
								}
							case -81:
								return;
							}
							break;
							IL_02d1:
							Delegate120.smethod_0(gclass16_0, e);
							num9 = GEventArgs2.smethod_0(43);
						}
					}
					continue;
					end_IL_0268:
					break;
				}
			}
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	private void method_15()
	{
		Class6 @class = Delegate61.smethod_0(class21_0);
		try
		{
			int num = 0;
			Random random = new Random();
			int id = Process.GetCurrentProcess().Id;
			do
			{
				if (num <= 10)
				{
					int num2 = random.Next(1000);
					while (true)
					{
						int num3 = 27;
						int num4 = 5;
						while (true)
						{
							num4 ^= 0x59;
							while (true)
							{
								int num5 = Class8.smethod_0(51);
								int num6 = -29;
								while (true)
								{
									num6 ^= 0x4D;
									while (true)
									{
										int num7 = Class8.smethod_0(42);
										int num8 = -31;
										while (true)
										{
											num8 ^= 0x52;
											int num9 = GEventArgs2.smethod_1(68);
											int num10 = -26;
											num10 = -79;
											while (true)
											{
												IL_024c:
												num9 ^= 0x50;
												while (true)
												{
													num10 = Class8.smethod_0(57);
													switch (num10 ^ 0x57)
													{
													case -82:
														goto end_IL_0036;
													case -81:
														goto IL_023b;
													case -79:
														goto IL_024c;
													case -80:
														while (true)
														{
															num10 = -25;
															num10 = -80;
														}
													}
													continue;
													end_IL_0036:
													break;
												}
												switch (num9)
												{
												case -77:
													goto IL_0089;
												case -78:
													goto IL_0226;
												case -76:
													goto IL_0235;
												case -75:
													goto end_IL_024c;
												}
												num10 = -8;
												num10 = -81;
												goto IL_023b;
												IL_0207:
												num6 = Class10.smethod_0(85);
												num7 = -32;
												goto IL_021f;
												IL_0226:
												num8 = GEventArgs2.smethod_1(59);
												num9 = -27;
												continue;
												IL_0235:
												num9 = -28;
												continue;
												IL_0089:
												switch (num8)
												{
												case -78:
													goto IL_00ac;
												case -77:
													goto IL_021f;
												case -79:
													goto IL_0258;
												case -80:
													goto end_IL_0267;
												}
												num9 = -30;
												continue;
												IL_0258:
												num8 = GEventArgs2.smethod_1(68);
												break;
												IL_00ac:
												switch (num7)
												{
												case -81:
													break;
												case -82:
													goto IL_0207;
												case -80:
													goto IL_0216;
												default:
													goto IL_0263;
												case -79:
													goto end_IL_0281;
												}
												switch (num6)
												{
												case -84:
													goto IL_00ed;
												case -82:
													goto IL_0200;
												case -85:
													goto IL_0290;
												case -83:
													goto end_IL_029a;
												}
												num7 = -1;
												goto IL_021f;
												IL_0263:
												num8 = -30;
												break;
												IL_0216:
												num7 = Class10.smethod_0(85);
												goto IL_021f;
												IL_021f:
												num7 ^= 0x51;
												goto IL_0226;
												IL_0290:
												num6 = -26;
												goto end_IL_0281;
												IL_00ed:
												switch (num5)
												{
												case -81:
													break;
												case -80:
													goto IL_011a;
												case -79:
													goto IL_01f9;
												default:
													goto IL_0296;
												case -78:
													goto end_IL_02a3;
												}
												num5 = GEventArgs2.smethod_0(43);
												goto IL_0200;
												IL_0296:
												num6 = -32;
												goto end_IL_0281;
												IL_011a:
												switch (num4)
												{
												case 90:
													goto IL_013d;
												case 92:
													goto IL_01f2;
												case 89:
													goto IL_02b2;
												case 91:
													goto end_IL_02ba;
												}
												num5 = -26;
												goto IL_0200;
												IL_02b2:
												num4 = 0;
												goto end_IL_02a3;
												IL_013d:
												switch (num3)
												{
												case 86:
													break;
												case 87:
													goto IL_01a2;
												case 88:
													goto IL_01c7;
												case 89:
													goto IL_01cd;
												default:
													goto IL_02b7;
												case 90:
													goto IL_0342;
												}
												string_6 = string.Format(CultureInfo.InvariantCulture, "_{0}_{1}_{2}", new object[3]
												{
													id,
													GetHashCode(),
													num2
												});
												num3 = 26;
												goto IL_01f2;
												IL_02b7:
												num4 = 2;
												goto end_IL_02a3;
												IL_01cd:
												if (Delegate121.smethod_0(this, "WinSCPConsoleEventRequest" + string_6, ref eventWaitHandle_0))
												{
													num3 = 23;
													goto IL_01f2;
												}
												goto IL_02cc;
												IL_023b:
												num9 = GEventArgs2.smethod_1(68);
												num10 = -26;
												num10 = -79;
												continue;
												IL_01c7:
												num3 = 21;
												goto IL_01f2;
												IL_01a2:
												Delegate45.smethod_0(class21_0, "Trying event {0}", new object[1] { string_6 });
												num3 = 20;
												goto IL_01f2;
												IL_0200:
												num5 ^= 0x57;
												goto IL_0207;
												IL_01f2:
												num3 ^= 0x4D;
												goto IL_01f9;
												IL_01f9:
												num4 = 3;
												num5 = -27;
												goto IL_0200;
												continue;
												end_IL_024c:
												break;
											}
											continue;
											end_IL_0267:
											break;
										}
										continue;
										end_IL_0281:
										break;
									}
									continue;
									end_IL_029a:
									break;
								}
								continue;
								end_IL_02a3:
								break;
							}
							continue;
							end_IL_02ba:
							break;
						}
						continue;
						IL_0342:
						Delegate45.smethod_0(class21_0, "Event {0} is unique", new object[1] { string_6 });
						eventWaitHandle_1 = Delegate122.smethod_0(this, "WinSCPConsoleEventResponse" + string_6);
						eventWaitHandle_2 = Delegate122.smethod_0(this, "WinSCPConsoleEventCancel" + string_6);
						string text = "WinSCPConsoleMapping" + string_6;
						safeFileHandle_0 = Delegate123.smethod_0(this, text);
						if (Marshal.GetLastWin32Error() != 183)
						{
							if ((!safeFileHandle_0.IsInvalid) ? true : false)
							{
								break;
							}
							throw Delegate57.smethod_0(gclass16_0, string.Format(CultureInfo.InvariantCulture, "Cannot create file mapping {0}", new object[1] { text }));
						}
						throw Delegate57.smethod_0(gclass16_0, string.Format(CultureInfo.InvariantCulture, "File mapping {0} already exists", new object[1] { text }));
						IL_02cc:
						if (0 == 0)
						{
							Delegate45.smethod_0(class21_0, "Event {0} is not unique", new object[1] { string_6 });
							while (true)
							{
								int num11 = Class8.smethod_0(53);
								while (true)
								{
									switch (num11 ^ 0x52)
									{
									case -80:
										eventWaitHandle_0.Close();
										num11 = -4;
										num11 = -82;
										goto case -82;
									case -82:
										eventWaitHandle_0 = null;
										num11 = GEventArgs2.smethod_1(68);
										continue;
									case -79:
										goto end_IL_02c3;
									case -81:
										while (true)
										{
											num11 = -3;
											num11 = -81;
										}
									}
									break;
								}
							}
						}
						goto IL_0342;
						continue;
						end_IL_02c3:
						break;
					}
					num++;
					continue;
				}
				throw Delegate57.smethod_0(gclass16_0, "Cannot find unique name for event object.");
			}
			while (eventWaitHandle_0 == null);
			Class15 class2 = Delegate93.smethod_0(this);
			try
			{
				Delegate124.smethod_0(class2);
			}
			finally
			{
				if (class2 != null || 1 == 0)
				{
					((IDisposable)class2).Dispose();
				}
			}
			if (Delegate125.smethod_0(gclass16_0) || 1 == 0)
			{
				string text2 = "WinSCPConsoleJob" + string_6;
				class20_0 = Delegate126.smethod_0(class21_0, text2);
			}
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	private unsafe SafeFileHandle method_16(string string_9)
	{
		IntPtr intPtr = IntPtr.Zero;
		EventWaitHandleSecurity val = Delegate127.smethod_0(this, (EventWaitHandleRights)983071);
		if (val != null || 1 == 0)
		{
			Struct0 @struct = default(Struct0);
			int num11 = default(int);
			byte[] securityDescriptorBinaryForm = default(byte[]);
			byte* ptr = default(byte*);
			while (true)
			{
				int num = Class10.smethod_0(84);
				int num2 = 13;
				while (true)
				{
					num2 ^= 0x51;
					while (true)
					{
						int num3 = Class55.smethod_1(71);
						int num4 = -9;
						while (true)
						{
							num4 ^= 0x58;
							while (true)
							{
								int num5 = 30;
								int num6 = -32;
								while (true)
								{
									num6 ^= 0x4E;
									while (true)
									{
										int num7 = GEventArgs2.smethod_1(59);
										int num8 = 13;
										while (true)
										{
											num8 ^= 0x56;
											while (true)
											{
												int num9 = Class8.smethod_0(47);
												int num10 = Class10.smethod_0(96);
												while (true)
												{
													switch (num10 ^ 0x58)
													{
													case -74:
														break;
													default:
														goto IL_0032;
													case -77:
														goto IL_0040;
													case -76:
														goto end_IL_024f;
													case -75:
														while (true)
														{
															num10 = -19;
															num10 = -75;
														}
													}
													goto IL_002b;
													IL_0040:
													switch (num9)
													{
													case -84:
														break;
													case -82:
														goto IL_006a;
													case -83:
														goto IL_0242;
													default:
														goto IL_0275;
													case -81:
														goto end_IL_027d;
													}
													num9 = Class8.smethod_0(57);
													goto IL_002b;
													IL_0275:
													num10 = -20;
													num10 = -76;
													break;
													IL_006a:
													switch (num8)
													{
													case 88:
														goto IL_008a;
													case 91:
														goto IL_023b;
													case 90:
														goto IL_0297;
													case 89:
														goto end_IL_029b;
													}
													num9 = -8;
													goto IL_002b;
													IL_0297:
													num8 = 12;
													goto end_IL_027d;
													IL_008a:
													switch (num7)
													{
													case -76:
														break;
													case -77:
														goto IL_0228;
													case -75:
														goto IL_0237;
													default:
														goto IL_0291;
													case -74:
														goto end_IL_02a4;
													}
													switch (num6)
													{
													case -85:
														goto IL_00cc;
													case -82:
														goto IL_0221;
													case -84:
														goto IL_02b9;
													case -83:
														goto end_IL_02bd;
													}
													num7 = -25;
													goto IL_023b;
													IL_0291:
													num8 = 15;
													goto end_IL_027d;
													IL_0237:
													num7 = -31;
													goto IL_023b;
													IL_0228:
													num6 = Class10.smethod_0(88);
													num7 = -30;
													goto IL_023b;
													IL_02b9:
													num6 = -30;
													goto end_IL_02a4;
													IL_00cc:
													switch (num5)
													{
													case 80:
														break;
													case 81:
														goto IL_020e;
													case 82:
														goto IL_0214;
													default:
														goto IL_02b3;
													case 83:
														goto end_IL_02c6;
													}
													switch (num4)
													{
													case -83:
														goto IL_010e;
													case -81:
														goto IL_0205;
													case -82:
														goto IL_02d6;
													case -84:
														goto end_IL_02df;
													}
													num5 = 28;
													goto IL_0221;
													IL_02b3:
													num6 = -29;
													goto end_IL_02a4;
													IL_020e:
													num5 = 31;
													goto IL_0221;
													IL_023b:
													num7 ^= 0x54;
													goto IL_0242;
													IL_02d6:
													num4 = GEventArgs2.smethod_0(49);
													goto end_IL_02c6;
													IL_010e:
													switch (num3)
													{
													case -83:
														break;
													case -84:
														goto IL_01f2;
													case -82:
														goto IL_01fc;
													default:
														goto IL_02d0;
													case -81:
														goto end_IL_02e8;
													}
													switch (num2)
													{
													case 90:
														goto IL_0150;
													case 92:
														goto IL_01eb;
													case 89:
														goto IL_02f7;
													case 91:
														goto end_IL_0300;
													}
													num3 = -11;
													goto IL_0205;
													IL_02d0:
													num4 = -12;
													goto end_IL_02c6;
													IL_01fc:
													num3 = GEventArgs2.smethod_0(46);
													goto IL_0205;
													IL_0221:
													num5 ^= 0x4E;
													goto IL_0228;
													IL_02f7:
													num2 = 8;
													goto end_IL_02e8;
													IL_0150:
													switch (num)
													{
													case -83:
														break;
													case -82:
														goto IL_0188;
													case -81:
														goto IL_0198;
													case -80:
														goto IL_01a5;
													case -79:
														goto IL_01af;
													case -78:
														goto IL_01b5;
													case -77:
														goto IL_01cd;
													case -84:
														goto IL_01dd;
													default:
														goto IL_02fc;
													}
													num11 = 0;
													num = -26;
													goto IL_01eb;
													IL_02fc:
													num2 = 10;
													goto end_IL_02e8;
													IL_01cd:
													num11++;
													goto IL_01d3;
													IL_01b5:
													@struct.uint_0 = (uint)Marshal.SizeOf((object)@struct);
													num = -7;
													goto IL_01eb;
													IL_01af:
													num = -25;
													goto IL_01eb;
													IL_01a5:
													if (num11 == 0)
													{
														goto IL_01d3;
													}
													num = -6;
													goto IL_01eb;
													IL_0032:
													num10 = GEventArgs2.smethod_1(56);
													continue;
													IL_01d3:
													if (num11 >= securityDescriptorBinaryForm.Length)
													{
														goto end_IL_0309;
													}
													goto IL_01dd;
													IL_01dd:
													ptr[num11] = securityDescriptorBinaryForm[num11];
													num = -27;
													goto IL_01eb;
													IL_0198:
													securityDescriptorBinaryForm = ((ObjectSecurity)(object)val).GetSecurityDescriptorBinaryForm();
													num = -8;
													goto IL_01eb;
													IL_0188:
													ptr = stackalloc byte[(int)checked(unchecked((nuint)(uint)securityDescriptorBinaryForm.Length) * (nuint)1u)];
													num = -5;
													goto IL_01eb;
													IL_002b:
													num9 ^= 0x55;
													goto IL_0032;
													IL_01eb:
													num ^= 0x56;
													goto IL_01f2;
													IL_01f2:
													num2 = 11;
													num3 = -10;
													goto IL_0205;
													IL_0242:
													num8 = 14;
													num9 = -6;
													goto IL_002b;
													IL_0205:
													num3 ^= 0x59;
													goto IL_0214;
													IL_0214:
													num4 = GEventArgs2.smethod_0(40);
													num5 = 29;
													goto IL_0221;
													continue;
													end_IL_024f:
													break;
												}
												continue;
												end_IL_027d:
												break;
											}
											continue;
											end_IL_029b:
											break;
										}
										continue;
										end_IL_02a4:
										break;
									}
									continue;
									end_IL_02bd:
									break;
								}
								continue;
								end_IL_02c6:
								break;
							}
							continue;
							end_IL_02df:
							break;
						}
						continue;
						end_IL_02e8:
						break;
					}
					continue;
					end_IL_0300:
					break;
				}
				continue;
				end_IL_0309:
				break;
			}
			@struct.intptr_0 = (IntPtr)ptr;
			intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Struct0)));
			Marshal.StructureToPtr((object)@struct, intPtr, fDeleteOld: false);
		}
		return Delegate128.smethod_0(new SafeFileHandle(new IntPtr(-1), ownsHandle: true), intPtr, Enum3.flag_1, 0, Delegate59.smethod_0(), string_9);
	}

	private Class15 method_17()
	{
		return Delegate129.smethod_0(gclass16_0, safeFileHandle_0);
	}

	private bool method_18(string string_9, out EventWaitHandle eventWaitHandle_3)
	{
		Delegate45.smethod_0(class21_0, "Creating event {0}", new object[1] { string_9 });
		EventWaitHandleSecurity val = Delegate127.smethod_0(this, (EventWaitHandleRights)2031619);
		bool flag = default(bool);
		eventWaitHandle_3 = new EventWaitHandle(false, EventResetMode.AutoReset, string_9, ref flag, val);
		Delegate45.smethod_0(class21_0, "Created event {0} with handle {1} with security {2}, new {3}", new object[4]
		{
			string_9,
			eventWaitHandle_3.SafeWaitHandle.DangerousGetHandle(),
			(val != null) ? ((ObjectSecurity)(object)val).GetSecurityDescriptorSddlForm(AccessControlSections.All) : "none",
			flag
		});
		return flag;
	}

	private EventWaitHandleSecurity method_19(EventWaitHandleRights eventWaitHandleRights_0)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		EventWaitHandleSecurity val = null;
		if (!string.IsNullOrEmpty(Delegate77.smethod_0(gclass16_0)) && 0 == 0)
		{
			val = new EventWaitHandleSecurity();
			IdentityReference identityReference;
			try
			{
				identityReference = new NTAccount(Delegate77.smethod_0(gclass16_0));
			}
			catch (Exception exception_)
			{
				throw Delegate82.smethod_0(gclass16_0, string.Format(CultureInfo.CurrentCulture, "Error resolving account {0}", new object[1] { Delegate77.smethod_0(gclass16_0) }), exception_);
			}
			EventWaitHandleAccessRule val2 = new EventWaitHandleAccessRule(identityReference, eventWaitHandleRights_0, AccessControlType.Allow);
			val.AddAccessRule(val2);
		}
		return val;
	}

	private EventWaitHandle method_20(string string_9)
	{
		EventWaitHandle result = default(EventWaitHandle);
		if (!Delegate121.smethod_0(this, string_9, ref result) && 0 == 0)
		{
			throw Delegate57.smethod_0(gclass16_0, string.Format(CultureInfo.InvariantCulture, "Event {0} already exists", new object[1] { string_9 }));
		}
		return result;
	}

	private void method_21(string string_9)
	{
		if (Delegate130.smethod_0(gclass16_0) || 1 == 0)
		{
			Delegate45.smethod_0(class21_0, "Testing that event {0} is closed", new object[1] { string_9 });
			EventWaitHandle eventWaitHandle = default(EventWaitHandle);
			if (Delegate121.smethod_0(this, string_9, ref eventWaitHandle) || 1 == 0)
			{
				eventWaitHandle.Close();
				return;
			}
			Delegate45.smethod_0(class21_0, "Exception: Event {0} was not closed yet", new object[1] { string_9 });
		}
	}

	private void method_22(string string_9)
	{
		object[] customAttributes = typeof(Class10).GetField("Str")!.GetCustomAttributes(typeof(MarshalAsAttribute), inherit: false);
		if (customAttributes.Length != 1)
		{
			throw new InvalidOperationException("MarshalAs attribute not found for ConsoleInputEventStruct.Str");
		}
		MarshalAsAttribute marshalAsAttribute = (MarshalAsAttribute)customAttributes[0];
		if (marshalAsAttribute.SizeConst <= string_9.Length)
		{
			throw Delegate57.smethod_0(gclass16_0, string.Format(CultureInfo.CurrentCulture, "Input [{0}] is too long ({1} limit)", new object[2] { string_9, marshalAsAttribute.SizeConst }));
		}
		lock (list_0)
		{
			list_0.Add(string_9);
			autoResetEvent_0.Set();
		}
	}

	public void method_23(string string_9)
	{
		Class6 @class = Delegate61.smethod_0(class21_0);
		try
		{
			Delegate131.smethod_0(this, string_9);
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	public void method_24()
	{
		Class6 @class = Delegate61.smethod_0(class21_0);
		try
		{
			Delegate45.smethod_0(class21_0, "Waiting for process to exit ({0} ms)", new object[1] { 2000 });
			if (!process_0.WaitForExit(2000) && 0 == 0)
			{
				Delegate79.smethod_0(class21_0, "Killing process");
				process_0.Kill();
			}
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	public void Dispose()
	{
		Class6 @class = Delegate61.smethod_0(class21_0);
		try
		{
			lock (object_0)
			{
				if (Delegate130.smethod_0(gclass16_0) || 1 == 0)
				{
					Delegate79.smethod_0(class21_0, "Will test that handles are closed");
				}
				bool_0 = true;
				if (thread_0 != null || 1 == 0)
				{
					thread_0.Join();
					thread_0 = null;
				}
				if (process_0 != null || 1 == 0)
				{
					process_0.Dispose();
					process_0 = null;
				}
				if (eventWaitHandle_0 != null || 1 == 0)
				{
					eventWaitHandle_0.Close();
					Delegate132.smethod_0(this, "WinSCPConsoleEventRequest" + string_6);
				}
				if (eventWaitHandle_1 != null || 1 == 0)
				{
					eventWaitHandle_1.Close();
					Delegate132.smethod_0(this, "WinSCPConsoleEventResponse" + string_6);
				}
				if (eventWaitHandle_2 != null || 1 == 0)
				{
					eventWaitHandle_2.Close();
					Delegate132.smethod_0(this, "WinSCPConsoleEventCancel" + string_6);
				}
				if (safeFileHandle_0 != null || 1 == 0)
				{
					safeFileHandle_0.Dispose();
					safeFileHandle_0 = null;
					if (Delegate130.smethod_0(gclass16_0) || 1 == 0)
					{
						Delegate79.smethod_0(class21_0, "Testing that file mapping is closed");
						string text = default(string);
						SafeFileHandle safeFileHandle = default(SafeFileHandle);
						while (true)
						{
							int num = 8;
							int num2 = -51;
							while (true)
							{
								num2 ^= 0x61;
								while (true)
								{
									int num3 = Class8.smethod_0(57);
									int num4 = Class10.smethod_0(98);
									while (true)
									{
										num4 ^= 0x61;
										while (true)
										{
											int num5 = 57;
											int num6 = 59;
											while (true)
											{
												num6 ^= 0x5D;
												while (true)
												{
													int num7 = Class8.smethod_0(41);
													int num8 = -63;
													while (true)
													{
														num8 ^= 0x62;
														int num9 = GEventArgs2.smethod_0(43);
														int num10 = -8;
														num10 = -90;
														while (true)
														{
															IL_0379:
															num9 ^= 0x5E;
															while (true)
															{
																num10 = Class8.smethod_0(48);
																switch (num10 ^ 0x5E)
																{
																case -92:
																	goto end_IL_015e;
																case -93:
																	goto IL_01ac;
																case -90:
																	goto IL_0379;
																case -91:
																	while (true)
																	{
																		num10 = -5;
																		num10 = -91;
																	}
																}
																continue;
																end_IL_015e:
																break;
															}
															switch (num9)
															{
															case -90:
																goto IL_01c2;
															case -89:
																goto IL_0361;
															case -88:
																goto IL_0367;
															case -87:
																goto end_IL_0379;
															}
															num10 = -3;
															num10 = -93;
															goto IL_01ac;
															IL_034b:
															num6 = 56;
															num7 = Class8.smethod_0(38);
															goto IL_0358;
															IL_0330:
															num3 ^= 0x5D;
															goto IL_0337;
															IL_0361:
															num9 = -7;
															continue;
															IL_01c2:
															switch (num8)
															{
															case -96:
																goto IL_01e5;
															case -93:
																goto IL_0358;
															case -95:
																goto IL_038b;
															case -94:
																goto end_IL_038f;
															}
															num9 = -10;
															continue;
															IL_038b:
															num8 = -61;
															break;
															IL_01e5:
															switch (num7)
															{
															case -95:
																break;
															case -94:
																goto IL_020d;
															case -96:
																goto IL_034b;
															default:
																goto IL_0385;
															case -93:
																goto end_IL_03a9;
															}
															num7 = -2;
															goto IL_0358;
															IL_0385:
															num8 = -64;
															break;
															IL_020d:
															switch (num6)
															{
															case 101:
																goto IL_022f;
															case 102:
																goto IL_0344;
															case 99:
																goto IL_03b8;
															case 100:
																goto end_IL_03c2;
															}
															num7 = -1;
															goto IL_0358;
															IL_03b8:
															num6 = 62;
															goto end_IL_03a9;
															IL_022f:
															switch (num5)
															{
															case 95:
																break;
															case 96:
																goto IL_0256;
															case 94:
																goto IL_0337;
															default:
																goto IL_03be;
															case 97:
																goto end_IL_03cb;
															}
															num5 = 6;
															goto IL_0344;
															IL_03be:
															num6 = 57;
															goto end_IL_03a9;
															IL_0256:
															switch (num4)
															{
															case -98:
																goto IL_0278;
															case -96:
																goto IL_0330;
															case -99:
																goto IL_03d5;
															case -97:
																goto end_IL_03df;
															}
															num5 = 7;
															goto IL_0344;
															IL_03d5:
															num4 = -4;
															goto end_IL_03cb;
															IL_0278:
															switch (num3)
															{
															case -93:
																break;
															case -92:
																goto IL_02a0;
															case -94:
																goto IL_0323;
															default:
																goto IL_03db;
															case -91:
																goto end_IL_03e8;
															}
															num3 = -2;
															goto IL_0330;
															IL_03db:
															num4 = -2;
															goto end_IL_03cb;
															IL_02a0:
															switch (num2)
															{
															case -85:
																goto IL_02bf;
															case -84:
																goto IL_031c;
															case -87:
																goto IL_03fc;
															case -86:
																goto end_IL_0406;
															}
															num3 = -1;
															goto IL_0330;
															IL_03fc:
															num2 = -56;
															goto end_IL_03e8;
															IL_02bf:
															switch (num)
															{
															case 87:
																break;
															case 88:
																goto IL_02f8;
															case 89:
																goto IL_02fd;
															case 90:
																goto IL_030a;
															default:
																goto IL_0402;
															case 91:
																goto IL_0418;
															}
															text = "WinSCPConsoleMapping" + string_6;
															num = 6;
															goto IL_031c;
															IL_0418:
															Delegate45.smethod_0(class21_0, "Exception: File mapping {0} was not closed yet", new object[1] { text });
															goto IL_0432;
															IL_0402:
															num2 = -53;
															goto end_IL_03e8;
															IL_030a:
															if (Marshal.GetLastWin32Error() == 183)
															{
																num = 4;
																goto IL_031c;
															}
															goto IL_0432;
															IL_0344:
															num5 ^= 0x59;
															goto IL_034b;
															IL_0432:
															if (!safeFileHandle.IsInvalid && 0 == 0)
															{
																safeFileHandle.Dispose();
															}
															goto end_IL_040f;
															IL_0337:
															num4 = Class8.smethod_0(39);
															num5 = 56;
															goto IL_0344;
															IL_01ac:
															num9 = GEventArgs2.smethod_0(43);
															num10 = -8;
															num10 = -90;
															continue;
															IL_02fd:
															safeFileHandle = Delegate123.smethod_0(this, text);
															num = 5;
															goto IL_031c;
															IL_02f8:
															num = 7;
															goto IL_031c;
															IL_0367:
															num8 = Class9.smethod_0(89);
															num9 = GEventArgs2.smethod_0(46);
															continue;
															IL_031c:
															num ^= 0x5F;
															goto IL_0323;
															IL_0323:
															num2 = Class10.smethod_0(94);
															num3 = -8;
															goto IL_0330;
															IL_0358:
															num7 ^= 0x5F;
															goto IL_0367;
															continue;
															end_IL_0379:
															break;
														}
														continue;
														end_IL_038f:
														break;
													}
													continue;
													end_IL_03a9:
													break;
												}
												continue;
												end_IL_03c2:
												break;
											}
											continue;
											end_IL_03cb:
											break;
										}
										continue;
										end_IL_03df:
										break;
									}
									continue;
									end_IL_03e8:
									break;
								}
								continue;
								end_IL_0406:
								break;
							}
							continue;
							end_IL_040f:
							break;
						}
					}
				}
				if (autoResetEvent_0 != null || 1 == 0)
				{
					autoResetEvent_0.Close();
					autoResetEvent_0 = null;
				}
				if (class20_0 != null || 1 == 0)
				{
					Delegate133.smethod_0(class20_0);
					class20_0 = null;
				}
			}
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	private string method_25()
	{
		Class6 @class = Delegate61.smethod_0(class21_0);
		try
		{
			string text = default(string);
			if (!string.IsNullOrEmpty(Delegate134.smethod_0(gclass16_0)) && 0 == 0)
			{
				text = Delegate134.smethod_0(gclass16_0);
				if (!File.Exists(text) && 0 == 0)
				{
					throw Delegate57.smethod_0(gclass16_0, string.Format(CultureInfo.CurrentCulture, "{0} does not exists.", new object[1] { text }));
				}
			}
			else if (!Delegate136.smethod_0(this, Delegate135.smethod_0(this), ref text) && 0 == 0 && !Delegate136.smethod_0(this, Delegate137.smethod_0(RegistryHive.CurrentUser, Registry.CurrentUser), ref text) && 0 == 0 && !Delegate136.smethod_0(this, Delegate137.smethod_0(RegistryHive.LocalMachine, Registry.LocalMachine), ref text) && 0 == 0 && !Delegate136.smethod_0(this, Delegate138.smethod_0(), ref text) && 0 == 0)
			{
				throw Delegate57.smethod_0(gclass16_0, string.Format(CultureInfo.CurrentCulture, "The {0} executable was not found at location of the assembly ({1}), nor in an installation path. You may use Session.ExecutablePath property to explicitly set path to {0}.", new object[2]
				{
					"winscp.exe",
					Delegate135.smethod_0(this)
				}));
			}
			return text;
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	private static string smethod_3()
	{
		string path = ((IntPtr.Size != 8) ? Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) : Environment.GetEnvironmentVariable("ProgramFiles(x86)"));
		return Path.Combine(path, "WinSCP");
	}

	private static string smethod_4(RegistryHive registryHive_0, RegistryKey registryKey_0)
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		string result;
		if (oSVersion.Version.Major >= 5 && (oSVersion.Version.Major != 5 || oSVersion.Version.Minor > 1))
		{
			result = null;
			UIntPtr uintptr_ = default(UIntPtr);
			Enum8 enum8_ = default(Enum8);
			Enum9 enum9_ = default(Enum9);
			uint uint_ = default(uint);
			IntPtr zero = default(IntPtr);
			while (true)
			{
				int num = 5;
				int num2 = -10;
				while (true)
				{
					num2 ^= 0x57;
					while (true)
					{
						int num3 = 3;
						int num4 = 6;
						while (true)
						{
							num4 ^= 0x5B;
							while (true)
							{
								int num5 = 61;
								int num6 = 59;
								while (true)
								{
									num6 ^= 0x58;
									while (true)
									{
										int num7 = 1;
										int num8 = 60;
										while (true)
										{
											num8 ^= 0x60;
											int num9 = 2;
											int num10 = -7;
											num10 = -93;
											while (true)
											{
												num9 ^= 0x5D;
												while (true)
												{
													num10 = GEventArgs2.smethod_0(43);
													while (true)
													{
														switch (num10 ^ 0x5A)
														{
														case -94:
															break;
														default:
															goto end_IL_0060;
														case -95:
															num9 = 2;
															num10 = -7;
															num10 = -93;
															goto end_IL_0081;
														case -93:
															goto end_IL_0081;
														case -96:
															while (true)
															{
																num10 = -6;
																num10 = -96;
															}
														}
														switch (num9)
														{
														case 95:
															goto IL_009c;
														case 94:
															goto IL_0245;
														case 96:
															goto IL_024f;
														case 97:
															goto end_IL_0253;
														}
														num10 = Class8.smethod_0(47);
														continue;
														IL_024f:
														num9 = 61;
														goto end_IL_0081;
														continue;
														end_IL_0060:
														break;
													}
													continue;
													end_IL_0081:
													break;
												}
												continue;
												IL_023e:
												num7 ^= 0x60;
												goto IL_0245;
												IL_009c:
												switch (num8)
												{
												case 90:
													goto IL_00be;
												case 92:
													goto IL_023e;
												case 91:
													goto IL_0265;
												case 89:
													goto end_IL_0269;
												}
												num9 = 3;
												continue;
												IL_0265:
												num8 = 59;
												break;
												IL_00be:
												switch (num7)
												{
												case 97:
													break;
												case 96:
													goto IL_0232;
												case 98:
													goto IL_023b;
												default:
													goto IL_025f;
												case 99:
													goto end_IL_027d;
												}
												switch (num6)
												{
												case 96:
													goto IL_00ff;
												case 99:
													goto IL_022b;
												case 98:
													goto IL_028c;
												case 97:
													goto end_IL_0290;
												}
												num7 = 0;
												goto IL_023e;
												IL_025f:
												num8 = 57;
												break;
												IL_023b:
												num7 = 2;
												goto IL_023e;
												IL_0245:
												num8 = 58;
												num9 = 60;
												continue;
												IL_028c:
												num6 = 58;
												goto end_IL_027d;
												IL_00ff:
												switch (num5)
												{
												case 92:
													break;
												case 91:
													goto IL_021e;
												case 93:
													goto IL_0227;
												default:
													goto IL_0286;
												case 94:
													goto end_IL_0299;
												}
												switch (num4)
												{
												case 92:
													goto IL_0141;
												case 93:
													goto IL_0217;
												case 91:
													goto IL_02a3;
												case 90:
													goto end_IL_02ab;
												}
												num5 = 58;
												goto IL_022b;
												IL_0286:
												num6 = 57;
												goto end_IL_027d;
												IL_0227:
												num5 = 60;
												goto IL_022b;
												IL_0217:
												num3 ^= 0x63;
												goto IL_021e;
												IL_02a3:
												num4 = 0;
												goto end_IL_0299;
												IL_0141:
												switch (num3)
												{
												case 96:
													break;
												case 97:
													goto IL_0206;
												case 98:
													goto IL_0214;
												default:
													goto IL_02a8;
												case 99:
													goto end_IL_02b4;
												}
												switch (num2)
												{
												case -96:
													goto IL_0182;
												case -95:
													goto IL_01ff;
												case -97:
													goto IL_02bc;
												case -98:
													goto end_IL_02cb;
												}
												num3 = 2;
												goto IL_0217;
												IL_02a8:
												num4 = 1;
												goto end_IL_0299;
												IL_0214:
												num3 = 1;
												goto IL_0217;
												IL_021e:
												num4 = 7;
												num5 = 63;
												goto IL_022b;
												IL_02bc:
												num2 = Class9.smethod_0(93);
												goto end_IL_02b4;
												IL_0182:
												switch (num)
												{
												case 98:
													break;
												case 99:
													goto IL_01d0;
												case 100:
													goto IL_01d5;
												case 101:
													goto IL_01e0;
												case 102:
													goto IL_01ed;
												case 103:
													goto IL_01f5;
												default:
													goto IL_02c7;
												case 104:
													goto end_IL_02d4;
												}
												if (Delegate139.smethod_0(uintptr_, "Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\winscp3_is1", "Inno Setup: App Path", enum8_, ref enum9_, zero, ref uint_) != 0)
												{
													num = 9;
													goto IL_01ff;
												}
												if (0 == 0)
												{
													zero = Marshal.AllocHGlobal((int)uint_);
													if (Delegate139.smethod_0(uintptr_, "Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\winscp3_is1", "Inno Setup: App Path", enum8_, ref enum9_, zero, ref uint_) == 0 && 0 == 0)
													{
														result = Marshal.PtrToStringUni(zero);
													}
												}
												goto end_IL_02d4;
												IL_02c7:
												num2 = -55;
												goto end_IL_02b4;
												IL_01f5:
												enum8_ = (Enum8)131074;
												num = 4;
												goto IL_01ff;
												IL_01ed:
												uint_ = 0u;
												num = 6;
												goto IL_01ff;
												IL_01e0:
												uintptr_ = (UIntPtr)(uint)registryHive_0;
												num = 3;
												goto IL_01ff;
												IL_01d5:
												zero = IntPtr.Zero;
												num = 7;
												goto IL_01ff;
												IL_01d0:
												num = 2;
												goto IL_01ff;
												IL_022b:
												num5 ^= 0x61;
												goto IL_0232;
												IL_0232:
												num6 = 56;
												num7 = 3;
												goto IL_023e;
												IL_01ff:
												num ^= 0x61;
												goto IL_0206;
												IL_0206:
												num2 = GEventArgs2.smethod_0(46);
												num3 = 0;
												goto IL_0217;
												continue;
												end_IL_0253:
												break;
											}
											continue;
											end_IL_0269:
											break;
										}
										continue;
										end_IL_027d:
										break;
									}
									continue;
									end_IL_0290:
									break;
								}
								continue;
								end_IL_0299:
								break;
							}
							continue;
							end_IL_02ab:
							break;
						}
						continue;
						end_IL_02b4:
						break;
					}
					continue;
					end_IL_02cb:
					break;
				}
				continue;
				end_IL_02d4:
				break;
			}
		}
		else
		{
			RegistryKey registryKey = registryKey_0.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\winscp3_is1");
			result = ((registryKey != null) ? ((string)registryKey.GetValue("Inno Setup: App Path")) : null);
		}
		return result;
	}

	private bool method_26(string string_9, out string string_10)
	{
		if (string.IsNullOrEmpty(string_9) || 1 == 0)
		{
			string_10 = null;
		}
		else
		{
			string text = Path.Combine(string_9, "winscp.exe");
			if (File.Exists(text) || 1 == 0)
			{
				while (true)
				{
					int num = 3;
					int num2 = 4;
					while (true)
					{
						num2 ^= 0x60;
						while (true)
						{
							int num3 = 2;
							int num4 = -8;
							while (true)
							{
								num4 ^= 0x5F;
								while (true)
								{
									int num5 = Class8.smethod_0(38);
									int num6 = -49;
									while (true)
									{
										num6 ^= 0x63;
										while (true)
										{
											int num7 = 63;
											int num8 = Class8.smethod_0(57);
											while (true)
											{
												switch (num8 ^ 0x5F)
												{
												case -90:
													break;
												case -91:
													goto IL_004d;
												default:
													num8 = Class8.smethod_0(48);
													continue;
												case -92:
													goto end_IL_01a3;
												case -93:
													while (true)
													{
														num8 = -4;
														num8 = -93;
													}
												}
												goto IL_0038;
												IL_004d:
												switch (num7)
												{
												case 90:
													break;
												case 92:
													goto IL_0072;
												case 91:
													goto IL_0188;
												default:
													goto IL_01c6;
												case 93:
													goto end_IL_01ce;
												}
												num7 = 57;
												goto IL_0038;
												IL_01c6:
												num8 = -5;
												num8 = -92;
												break;
												IL_0072:
												switch (num6)
												{
												case -85:
													goto IL_0092;
												case -84:
													goto IL_0181;
												case -87:
													goto IL_01dd;
												case -86:
													goto end_IL_01ec;
												}
												num7 = 56;
												goto IL_0038;
												IL_01dd:
												num6 = Class10.smethod_0(94);
												goto end_IL_01ce;
												IL_0092:
												switch (num5)
												{
												case -98:
													break;
												case -96:
													goto IL_00ba;
												case -97:
													goto IL_016f;
												default:
													goto IL_01e8;
												case -95:
													goto end_IL_01f5;
												}
												num5 = -62;
												goto IL_0181;
												IL_01e8:
												num6 = -55;
												goto end_IL_01ce;
												IL_00ba:
												switch (num4)
												{
												case -91:
													goto IL_00dd;
												case -89:
													goto IL_016a;
												case -90:
													goto IL_020a;
												case -92:
													goto end_IL_0213;
												}
												num5 = -61;
												goto IL_0181;
												IL_020a:
												num4 = Class8.smethod_0(57);
												goto end_IL_01f5;
												IL_00dd:
												switch (num3)
												{
												case 90:
													break;
												case 91:
													goto IL_0162;
												case 92:
													goto IL_0168;
												default:
													goto IL_0204;
												case 93:
													goto end_IL_021c;
												}
												switch (num2)
												{
												case 98:
													goto IL_0118;
												case 100:
													goto IL_015d;
												case 99:
													goto IL_0228;
												case 97:
													goto end_IL_022a;
												}
												num3 = 3;
												goto IL_016a;
												IL_0204:
												num4 = -5;
												goto end_IL_01f5;
												IL_0168:
												num3 = 4;
												goto IL_016a;
												IL_0181:
												num5 ^= 0x5C;
												goto IL_0188;
												IL_0228:
												num2 = 3;
												goto end_IL_021c;
												IL_0118:
												switch (num)
												{
												case 88:
													break;
												case 89:
													goto IL_013a;
												case 90:
													goto IL_0141;
												default:
													goto IL_0224;
												case 91:
													goto end_IL_0231;
												}
												num = 2;
												goto IL_015d;
												IL_0224:
												num2 = 1;
												goto end_IL_021c;
												IL_0141:
												Delegate45.smethod_0(class21_0, "Executable found in {0}", new object[1] { text });
												num = 1;
												goto IL_015d;
												IL_013a:
												string_10 = text;
												num = 0;
												goto IL_015d;
												IL_0038:
												num7 ^= 0x63;
												num8 = Class8.smethod_0(48);
												continue;
												IL_015d:
												num ^= 0x5A;
												goto IL_0162;
												IL_0162:
												num2 = 2;
												num3 = 5;
												goto IL_016a;
												IL_0188:
												num6 = Class9.smethod_0(93);
												num7 = 62;
												goto IL_0038;
												IL_016a:
												num3 ^= 0x58;
												goto IL_016f;
												IL_016f:
												num4 = Class8.smethod_0(48);
												num5 = Class8.smethod_0(41);
												goto IL_0181;
												continue;
												end_IL_01a3:
												break;
											}
											continue;
											end_IL_01ce:
											break;
										}
										continue;
										end_IL_01ec:
										break;
									}
									continue;
									end_IL_01f5:
									break;
								}
								continue;
								end_IL_0213:
								break;
							}
							continue;
							end_IL_021c:
							break;
						}
						continue;
						end_IL_022a:
						break;
					}
					continue;
					end_IL_0231:
					break;
				}
			}
			else
			{
				string_10 = null;
				Delegate45.smethod_0(class21_0, "Executable not found in {0}", new object[1] { text });
			}
		}
		return string_10 != null;
	}

	private string method_27()
	{
		string text = Delegate63.smethod_0(class21_0);
		string result = null;
		if (!string.IsNullOrEmpty(text) && 0 == 0)
		{
			result = Path.GetDirectoryName(text);
		}
		return result;
	}

	private void method_28(string string_9, FileVersionInfo fileVersionInfo_0)
	{
		Class6 @class = Delegate61.smethod_0(class21_0);
		try
		{
			FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(string_9);
			Delegate45.smethod_0(class21_0, "Version of {0} is {1}, product {2} version is {3}", new object[4] { string_9, versionInfo.FileVersion, versionInfo.ProductName, versionInfo.ProductVersion });
			if (Delegate140.smethod_0(gclass16_0) || 1 == 0)
			{
				Delegate79.smethod_0(class21_0, "Version check disabled (not recommended)");
			}
			else if (fileVersionInfo_0 == null && 0 == 0)
			{
				Delegate79.smethod_0(class21_0, "Assembly version not known, cannot check version");
			}
			else if (fileVersionInfo_0.ProductVersion != versionInfo.ProductVersion || 1 == 0)
			{
				throw Delegate57.smethod_0(gclass16_0, string.Format(CultureInfo.CurrentCulture, "The version of {0} ({1}) does not match version of this assembly {2} ({3}).", string_9, versionInfo.ProductVersion, Delegate63.smethod_0(class21_0), fileVersionInfo_0.ProductVersion));
			}
		}
		finally
		{
			if (@class != null || 1 == 0)
			{
				((IDisposable)@class).Dispose();
			}
		}
	}

	public void method_29()
	{
		string text = Delegate62.smethod_0(this);
		Delegate45.smethod_0(class21_0, "{0} - exists [{1}]", new object[2]
		{
			text,
			File.Exists(text)
		});
	}
}
