using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

internal class Class21 : IDisposable
{
	private StreamWriter streamWriter_0;

	private string string_0;

	private readonly Dictionary<int, int> dictionary_0 = new Dictionary<int, int>();

	private readonly object object_0 = new object();

	private readonly GClass1 gclass1_0 = Delegate167.smethod_0();

	private List<PerformanceCounter> list_0 = new List<PerformanceCounter>();

	private int int_0;

	public string String_0
	{
		get
		{
			return string_0;
		}
		set
		{
			Delegate147.smethod_0(this, value);
		}
	}

	public int Int32_0
	{
		get
		{
			return int_0;
		}
		set
		{
			Delegate148.smethod_0(this, value);
		}
	}

	public bool Boolean_0
	{
		get
		{
			if (streamWriter_0 != null || 1 == 0)
			{
				return streamWriter_0.BaseStream.CanWrite;
			}
			return false;
		}
	}

	public string method_0()
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string codeBase = default(string);
		string text = default(string);
		string location = default(string);
		while (true)
		{
			int num = Class8.smethod_0(51);
			int num2 = 3;
			while (true)
			{
				num2 ^= 0x55;
				while (true)
				{
					int num3 = 12;
					int num4 = 2;
					while (true)
					{
						num4 ^= 0x57;
						while (true)
						{
							int num5 = 11;
							int num6 = 25;
							while (true)
							{
								num6 ^= 0x4E;
								while (true)
								{
									int num7 = 15;
									int num8 = 27;
									while (true)
									{
										num8 ^= 0x4F;
										int num9 = 3;
										int num10 = -12;
										num10 = -83;
										while (true)
										{
											IL_0215:
											num9 ^= 0x52;
											while (true)
											{
												num10 = Class8.smethod_0(58);
												switch (num10 ^ 0x59)
												{
												case -86:
													goto end_IL_000c;
												case -84:
													goto IL_020a;
												case -83:
													goto IL_0215;
												case -85:
													while (true)
													{
														num10 = -14;
														num10 = -85;
													}
												}
												continue;
												end_IL_000c:
												break;
											}
											switch (num9)
											{
											case 79:
												goto IL_005f;
											case 81:
												goto IL_0068;
											case 80:
												goto IL_0201;
											case 82:
												goto end_IL_0215;
											}
											num10 = -11;
											num10 = -84;
											goto IL_020a;
											IL_0201:
											num8 = 28;
											num9 = 0;
											continue;
											IL_01ec:
											num5 ^= 0x59;
											goto IL_01f3;
											IL_0068:
											switch (num8)
											{
											case 83:
												goto IL_008a;
											case 84:
												goto IL_01fa;
											case 81:
												goto IL_0221;
											case 82:
												goto end_IL_022b;
											}
											num9 = 2;
											continue;
											IL_0221:
											num8 = 30;
											break;
											IL_008a:
											switch (num7)
											{
											case 90:
												break;
											case 91:
												goto IL_00b2;
											case 89:
												goto IL_01f3;
											default:
												goto IL_0227;
											case 92:
												goto end_IL_023f;
											}
											num7 = 14;
											goto IL_01fa;
											IL_0227:
											num8 = 29;
											break;
											IL_00b2:
											switch (num6)
											{
											case 85:
												goto IL_00d5;
											case 87:
												goto IL_01ec;
											case 84:
												goto IL_0249;
											case 86:
												goto end_IL_0253;
											}
											num7 = 13;
											goto IL_01fa;
											IL_0249:
											num6 = 26;
											goto end_IL_023f;
											IL_00d5:
											switch (num5)
											{
											case 80:
												break;
											case 82:
												goto IL_00fd;
											case 81:
												goto IL_01e5;
											default:
												goto IL_024f;
											case 83:
												goto end_IL_025c;
											}
											num5 = 9;
											goto IL_01ec;
											IL_024f:
											num6 = 24;
											goto end_IL_023f;
											IL_00fd:
											switch (num4)
											{
											case 84:
												goto IL_011f;
											case 85:
												goto IL_01de;
											case 82:
												goto IL_0266;
											case 83:
												goto end_IL_026e;
											}
											num5 = 8;
											goto IL_01ec;
											IL_0266:
											num4 = 5;
											goto end_IL_025c;
											IL_011f:
											switch (num3)
											{
											case 83:
												break;
											case 85:
												goto IL_0147;
											case 84:
												goto IL_01d7;
											default:
												goto IL_026b;
											case 86:
												goto end_IL_0277;
											}
											num3 = 10;
											goto IL_01de;
											IL_026b:
											num4 = 4;
											goto end_IL_025c;
											IL_0147:
											switch (num2)
											{
											case 83:
												goto IL_0167;
											case 86:
												goto IL_01d0;
											case 84:
												goto IL_0285;
											case 85:
												goto end_IL_0288;
											}
											num3 = 13;
											goto IL_01de;
											IL_0285:
											num2 = 1;
											goto end_IL_0277;
											IL_0167:
											switch (num)
											{
											case -80:
												if (codeBase.StartsWith("file:///", StringComparison.OrdinalIgnoreCase))
												{
													goto IL_019f;
												}
												if (1 == 0)
												{
													goto case -75;
												}
												goto IL_02bf;
											case -79:
												break;
											case -78:
												goto IL_01b7;
											case -77:
												goto IL_01bd;
											case -76:
												goto IL_01c5;
											default:
												goto IL_0280;
											case -75:
												{
													text = codeBase.Substring("file:///".Length).Replace('/', '\\');
													goto IL_02bf;
												}
												IL_02bf:
												if (text == null || !File.Exists(text) || 1 == 0)
												{
													if (File.Exists(location) || 1 == 0)
													{
														text = location;
													}
													else
													{
														Delegate149.smethod_0(this, string.Format(CultureInfo.CurrentCulture, "Cannot locate path of assembly [{0}] neither from its code base [{1}], nor from its location [{2}]", new object[3] { executingAssembly, codeBase, location }));
														text = null;
													}
												}
												return text;
											}
											codeBase = executingAssembly.CodeBase;
											num = GEventArgs2.smethod_1(59);
											goto IL_01d0;
											IL_0280:
											num2 = 0;
											goto end_IL_0277;
											IL_01c5:
											location = executingAssembly.Location;
											num = -28;
											goto IL_01d0;
											IL_01bd:
											text = null;
											num = -27;
											goto IL_01d0;
											IL_01b7:
											num = -26;
											goto IL_01d0;
											IL_020a:
											num9 = 3;
											num10 = -12;
											num10 = -83;
											continue;
											IL_019f:
											num = -31;
											goto IL_01d0;
											IL_01d0:
											num ^= 0x54;
											goto IL_01d7;
											IL_01d7:
											num2 = 6;
											num3 = 15;
											goto IL_01de;
											IL_01f3:
											num6 = 27;
											num7 = 8;
											goto IL_01fa;
											IL_005f:
											num9 = 29;
											continue;
											IL_01de:
											num3 ^= 0x59;
											goto IL_01e5;
											IL_01e5:
											num4 = 3;
											num5 = 10;
											goto IL_01ec;
											IL_01fa:
											num7 ^= 0x54;
											goto IL_0201;
											continue;
											end_IL_0215:
											break;
										}
										continue;
										end_IL_022b:
										break;
									}
									continue;
									end_IL_023f:
									break;
								}
								continue;
								end_IL_0253:
								break;
							}
							continue;
							end_IL_025c:
							break;
						}
						continue;
						end_IL_026e:
						break;
					}
					continue;
					end_IL_0277:
					break;
				}
				continue;
				end_IL_0288:
				break;
			}
		}
	}

	private void method_1()
	{
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		try
		{
			PerformanceCounterCategory[] categories = PerformanceCounterCategory.GetCategories();
			string text = default(string);
			int num11 = default(int);
			foreach (PerformanceCounterCategory val in categories)
			{
				if ((!(val.get_CategoryName() == "Processor")) ? true : false)
				{
					continue;
				}
				string[] instanceNames = val.GetInstanceNames();
				while (true)
				{
					int num = GEventArgs2.smethod_1(68);
					int num2 = Class8.smethod_0(39);
					while (true)
					{
						num2 ^= 0x52;
						while (true)
						{
							int num3 = 5;
							int num4 = -32;
							while (true)
							{
								num4 ^= 0x50;
								while (true)
								{
									int num5 = Class10.smethod_0(83);
									int num6 = 6;
									while (true)
									{
										num6 ^= 0x56;
										while (true)
										{
											int num7 = 5;
											int num8 = 0;
											while (true)
											{
												num8 ^= 0x59;
												while (true)
												{
													int num9 = 5;
													int num10 = Class10.smethod_0(88);
													while (true)
													{
														switch (num10 ^ 0x51)
														{
														case -76:
															break;
														default:
															goto IL_0040;
														case -78:
															goto IL_004e;
														case -79:
															goto end_IL_0232;
														case -77:
															while (true)
															{
																num10 = -30;
																num10 = -77;
															}
														}
														goto IL_0039;
														IL_004e:
														switch (num9)
														{
														case 85:
															break;
														case 86:
															goto IL_0072;
														case 87:
															goto IL_0226;
														default:
															goto IL_0258;
														case 88:
															goto end_IL_0260;
														}
														num9 = 6;
														goto IL_0039;
														IL_0258:
														num10 = -32;
														num10 = -79;
														break;
														IL_0072:
														switch (num8)
														{
														case 88:
															goto IL_0091;
														case 89:
															goto IL_021f;
														case 86:
															goto IL_026e;
														case 87:
															goto end_IL_0278;
														}
														num9 = 4;
														goto IL_0039;
														IL_026e:
														num8 = 15;
														goto end_IL_0260;
														IL_0091:
														switch (num7)
														{
														case 85:
															break;
														case 86:
															goto IL_0213;
														case 87:
															goto IL_0218;
														default:
															goto IL_0274;
														case 88:
															goto end_IL_0281;
														}
														switch (num6)
														{
														case 79:
															goto IL_00d2;
														case 80:
															goto IL_020a;
														case 77:
															goto IL_0289;
														case 78:
															goto end_IL_0293;
														}
														num7 = 7;
														goto IL_021f;
														IL_0274:
														num8 = 14;
														goto end_IL_0260;
														IL_0213:
														num7 = 6;
														goto IL_021f;
														IL_0218:
														num6 = 25;
														num7 = 8;
														goto IL_021f;
														IL_0289:
														num6 = 27;
														goto end_IL_0281;
														IL_00d2:
														switch (num5)
														{
														case -77:
															break;
														case -75:
															goto IL_00fa;
														case -76:
															goto IL_01fd;
														default:
															goto IL_028f;
														case -74:
															goto end_IL_029c;
														}
														num5 = -22;
														goto IL_020a;
														IL_028f:
														num6 = 24;
														goto end_IL_0281;
														IL_00fa:
														switch (num4)
														{
														case -82:
															goto IL_011d;
														case -80:
															goto IL_01f6;
														case -83:
															goto IL_02aa;
														case -81:
															goto end_IL_02b9;
														}
														num5 = -19;
														goto IL_020a;
														IL_02aa:
														num4 = -3;
														goto end_IL_029c;
														IL_011d:
														switch (num3)
														{
														case 83:
															break;
														case 84:
															goto IL_0144;
														case 85:
															goto IL_01ea;
														default:
															goto IL_02b0;
														case 86:
															goto end_IL_02c2;
														}
														num3 = 2;
														goto IL_01f6;
														IL_02b0:
														num4 = Class8.smethod_0(39);
														goto end_IL_029c;
														IL_0144:
														switch (num2)
														{
														case -85:
															goto IL_0166;
														case -83:
															goto IL_01e3;
														case -86:
															goto IL_02cb;
														case -84:
															goto end_IL_02d5;
														}
														num3 = 4;
														goto IL_01f6;
														IL_02cb:
														num2 = -8;
														goto end_IL_02c2;
														IL_0166:
														switch (num)
														{
														case -80:
															break;
														case -79:
															goto IL_01ab;
														case -78:
															goto IL_01b5;
														case -77:
															goto IL_01be;
														case -76:
															goto IL_01c4;
														case -81:
															goto IL_01d4;
														default:
															goto IL_02d1;
														}
														Delegate150.smethod_0(this, new PerformanceCounter(val.get_CategoryName(), "% Processor Time", text));
														num = -27;
														goto IL_01e3;
														IL_02d1:
														num2 = -2;
														goto end_IL_02c2;
														IL_01c4:
														num11++;
														goto IL_01ca;
														IL_01be:
														num = -30;
														goto IL_01e3;
														IL_01b5:
														num11 = 0;
														num = -32;
														goto IL_01e3;
														IL_01ab:
														if (num11 == 0)
														{
															goto IL_01ca;
														}
														num = -2;
														goto IL_01e3;
														IL_0040:
														num10 = GEventArgs2.smethod_1(68);
														continue;
														IL_01ca:
														if (num11 >= instanceNames.Length)
														{
															goto end_IL_02de;
														}
														goto IL_01d4;
														IL_01d4:
														text = instanceNames[num11];
														num = Class10.smethod_0(85);
														goto IL_01e3;
														IL_0039:
														num9 ^= 0x53;
														goto IL_0040;
														IL_01e3:
														num ^= 0x51;
														goto IL_01ea;
														IL_01ea:
														num2 = Class8.smethod_0(57);
														num3 = 7;
														goto IL_01f6;
														IL_021f:
														num7 ^= 0x50;
														goto IL_0226;
														IL_020a:
														num5 ^= 0x59;
														goto IL_0218;
														IL_01f6:
														num3 ^= 0x51;
														goto IL_01fd;
														IL_01fd:
														num4 = Class8.smethod_0(42);
														num5 = -17;
														goto IL_020a;
														IL_0226:
														num8 = 1;
														num9 = 11;
														goto IL_0039;
														continue;
														end_IL_0232:
														break;
													}
													continue;
													end_IL_0260:
													break;
												}
												continue;
												end_IL_0278:
												break;
											}
											continue;
											end_IL_0281:
											break;
										}
										continue;
										end_IL_0293:
										break;
									}
									continue;
									end_IL_029c:
									break;
								}
								continue;
								end_IL_02b9:
								break;
							}
							continue;
							end_IL_02c2:
							break;
						}
						continue;
						end_IL_02d5:
						break;
					}
					continue;
					end_IL_02de:
					break;
				}
			}
			Delegate150.smethod_0(this, new PerformanceCounter("Memory", "Available KBytes"));
		}
		catch (UnauthorizedAccessException)
		{
			Delegate149.smethod_0(this, "Not authorized to get counters");
		}
		catch (Exception ex2)
		{
			Delegate151.smethod_0(this, "Error getting counters: {0}", new object[1] { ex2 });
		}
	}

	private void method_2(PerformanceCounter performanceCounter_0)
	{
		performanceCounter_0.NextValue();
		list_0.Add(performanceCounter_0);
	}

	public void method_3(string string_1)
	{
		lock (object_0)
		{
			if (Delegate152.smethod_0(this) || 1 == 0)
			{
				Delegate153.smethod_0(this, string_1);
			}
		}
	}

	public void method_4(string string_1, params object[] object_1)
	{
		lock (object_0)
		{
			if (Delegate152.smethod_0(this) || 1 == 0)
			{
				Delegate153.smethod_0(this, string.Format(CultureInfo.CurrentCulture, string_1, object_1));
			}
		}
	}

	public void method_5(int int_1, string string_1)
	{
		if (Delegate154.smethod_0(this) >= int_1)
		{
			Delegate149.smethod_0(this, string_1);
		}
	}

	private static int smethod_0()
	{
		return Thread.CurrentThread.ManagedThreadId;
	}

	public void method_6()
	{
		lock (object_0)
		{
			int key = Delegate155.smethod_0();
			if (!dictionary_0.TryGetValue(key, out var value) && 0 == 0)
			{
				value = 0;
			}
			dictionary_0[key] = value + 1;
		}
	}

	public void method_7()
	{
		lock (object_0)
		{
			int key = Delegate155.smethod_0();
			dictionary_0[key]--;
		}
	}

	public void Dispose()
	{
		lock (object_0)
		{
			if (Delegate152.smethod_0(this) || 1 == 0)
			{
				Delegate156.smethod_0(this);
				while (true)
				{
					int num = Class8.smethod_0(39);
					int num2 = -26;
					while (true)
					{
						num2 ^= 0x4D;
						while (true)
						{
							int num3 = 3;
							int num4 = GEventArgs2.smethod_1(68);
							while (true)
							{
								IL_0146:
								num4 ^= 0x57;
								int num5 = Class10.smethod_0(85);
								while (true)
								{
									switch (num5 ^ 0x51)
									{
									default:
										num5 = Class10.smethod_0(85);
										continue;
									case -80:
										break;
									case -78:
										goto IL_0135;
									case -77:
										goto IL_0146;
									case -79:
										while (true)
										{
											num5 = -32;
											num5 = -79;
										}
									}
									break;
								}
								switch (num4)
								{
								case -79:
									goto IL_007c;
								case -78:
									goto IL_0115;
								case -76:
									goto IL_011b;
								case -77:
									goto end_IL_0146;
								}
								num5 = -29;
								num5 = -78;
								goto IL_0135;
								IL_011b:
								num3 ^= 0x58;
								num4 = Class8.smethod_0(50);
								num5 = -30;
								num5 = -77;
								continue;
								IL_009f:
								num3 = 1;
								goto IL_011b;
								IL_0115:
								num4 = -27;
								continue;
								IL_007c:
								switch (num3)
								{
								case 89:
									goto IL_009f;
								case 91:
									goto IL_00a4;
								case 90:
									goto IL_0108;
								case 92:
									goto end_IL_015b;
								}
								num4 = -28;
								continue;
								IL_00a4:
								switch (num2)
								{
								case -86:
									goto IL_00c2;
								case -85:
									goto IL_0103;
								case -88:
									goto IL_0169;
								case -87:
									goto end_IL_0176;
								}
								num3 = 2;
								goto IL_011b;
								IL_0169:
								num2 = Class10.smethod_0(88);
								goto end_IL_015b;
								IL_00c2:
								switch (num)
								{
								case -87:
									break;
								case -86:
									goto IL_00f0;
								case -85:
									goto IL_00fa;
								default:
									goto IL_0173;
								case -84:
									goto end_IL_017d;
								}
								streamWriter_0.Dispose();
								num = -8;
								goto IL_0103;
								IL_0173:
								num2 = -28;
								goto end_IL_015b;
								IL_00fa:
								Delegate157.smethod_0(this);
								num = -3;
								goto IL_0103;
								IL_00f0:
								num = Class8.smethod_0(42);
								goto IL_0103;
								IL_0135:
								num4 = Class8.smethod_0(50);
								num5 = -30;
								num5 = -77;
								continue;
								IL_0103:
								num ^= 0x54;
								goto IL_0108;
								IL_0108:
								num2 = Class8.smethod_0(51);
								num3 = 4;
								goto IL_011b;
								continue;
								end_IL_0146:
								break;
							}
							continue;
							end_IL_015b:
							break;
						}
						continue;
						end_IL_0176:
						break;
					}
					continue;
					end_IL_017d:
					break;
				}
				streamWriter_0 = null;
			}
			using List<PerformanceCounter>.Enumerator enumerator = list_0.GetEnumerator();
			while (enumerator.MoveNext() ? true : false)
			{
				((Component)(object)enumerator.Current).Dispose();
			}
		}
	}

	public void method_8()
	{
		if (((!Delegate152.smethod_0(this)) ? true : false) || Delegate154.smethod_0(this) < 1)
		{
			return;
		}
		try
		{
			using List<PerformanceCounter>.Enumerator enumerator = list_0.GetEnumerator();
			while (enumerator.MoveNext() ? true : false)
			{
				PerformanceCounter current = enumerator.Current;
				Delegate151.smethod_0(this, "{0}{1}{2} = [{3}]", new object[4]
				{
					current.get_CounterName(),
					(string.IsNullOrEmpty(current.get_InstanceName()) ? true : false) ? string.Empty : "/",
					current.get_InstanceName(),
					current.NextValue()
				});
			}
		}
		catch (Exception ex)
		{
			Delegate151.smethod_0(this, "Error reading counters: {0}", new object[1] { ex });
		}
	}

	public void method_9()
	{
		if (((!Delegate152.smethod_0(this)) ? true : false) || Delegate154.smethod_0(this) < 1)
		{
			return;
		}
		try
		{
			Process[] processes = Process.GetProcesses();
			int num11 = default(int);
			Process process = default(Process);
			while (true)
			{
				int num = Class10.smethod_0(85);
				int num2 = 14;
				while (true)
				{
					num2 ^= 0x56;
					while (true)
					{
						int num3 = 23;
						int num4 = 7;
						while (true)
						{
							num4 ^= 0x55;
							while (true)
							{
								int num5 = Class8.smethod_0(51);
								int num6 = -29;
								while (true)
								{
									num6 ^= 0x51;
									while (true)
									{
										int num7 = 4;
										int num8 = 0;
										while (true)
										{
											num8 ^= 0x51;
											int num9 = 30;
											int num10 = -24;
											num10 = -80;
											while (true)
											{
												IL_026f:
												num9 ^= 0x4F;
												while (true)
												{
													num10 = GEventArgs2.smethod_0(46);
													while (true)
													{
														switch (num10 ^ 0x58)
														{
														case -82:
															num10 = GEventArgs2.smethod_0(49);
															continue;
														case -81:
															goto end_IL_0053;
														case -83:
															goto IL_0080;
														case -80:
															goto IL_026f;
														}
														break;
													}
													continue;
													end_IL_0053:
													break;
												}
												switch (num9)
												{
												case 81:
													goto IL_0091;
												case 80:
													goto IL_0262;
												case 82:
													goto IL_026b;
												case 83:
													goto end_IL_026f;
												}
												num10 = -11;
												num10 = -83;
												goto IL_0080;
												IL_0236:
												num4 = 4;
												num5 = -28;
												goto IL_0248;
												IL_0262:
												num8 = 1;
												num9 = 28;
												continue;
												IL_026b:
												num9 = 29;
												continue;
												IL_0091:
												switch (num8)
												{
												case 80:
													goto IL_00b4;
												case 81:
													goto IL_025b;
												case 79:
													goto IL_027b;
												case 78:
													goto end_IL_0285;
												}
												num9 = 31;
												continue;
												IL_027b:
												num8 = 30;
												break;
												IL_00b4:
												switch (num7)
												{
												case 81:
													break;
												case 82:
													goto IL_00db;
												case 83:
													goto IL_024f;
												default:
													goto IL_0281;
												case 84:
													goto end_IL_029a;
												}
												num7 = 7;
												goto IL_025b;
												IL_0281:
												num8 = 31;
												break;
												IL_00db:
												switch (num6)
												{
												case -80:
													goto IL_00fd;
												case -78:
													goto IL_0248;
												case -79:
													goto IL_02a8;
												case -81:
													goto end_IL_02ac;
												}
												num7 = 5;
												goto IL_025b;
												IL_02a8:
												num6 = -32;
												goto end_IL_029a;
												IL_00fd:
												switch (num5)
												{
												case -88:
													break;
												case -87:
													goto IL_0236;
												case -86:
													goto IL_023f;
												default:
													goto IL_02a2;
												case -85:
													goto end_IL_02b5;
												}
												switch (num4)
												{
												case 81:
													goto IL_013f;
												case 82:
													goto IL_022f;
												case 79:
													goto IL_02c4;
												case 80:
													goto end_IL_02cd;
												}
												num5 = -26;
												goto IL_0248;
												IL_02a2:
												num6 = -2;
												goto end_IL_029a;
												IL_023f:
												num5 = Class10.smethod_0(88);
												goto IL_0248;
												IL_025b:
												num7 ^= 0x56;
												goto IL_0262;
												IL_02c4:
												num4 = 26;
												goto end_IL_02b5;
												IL_013f:
												switch (num3)
												{
												case 77:
													break;
												case 79:
													goto IL_0167;
												case 78:
													goto IL_0229;
												default:
													goto IL_02ca;
												case 80:
													goto end_IL_02d6;
												}
												num3 = 21;
												goto IL_022f;
												IL_02ca:
												num4 = 5;
												goto end_IL_02b5;
												IL_0167:
												switch (num2)
												{
												case 86:
													goto IL_018a;
												case 88:
													goto IL_0222;
												case 87:
													goto IL_02e4;
												case 85:
													goto end_IL_02e7;
												}
												num3 = 22;
												goto IL_022f;
												IL_02e4:
												num2 = 1;
												goto end_IL_02d6;
												IL_018a:
												switch (num)
												{
												case -84:
													if (num11 == 0)
													{
														goto IL_0211;
													}
													num = -4;
													goto IL_0222;
												case -82:
													num = Class8.smethod_0(39);
													goto IL_0222;
												case -81:
													Delegate151.smethod_0(this, "{0}:{1} - {2} - {3}", new object[4]
													{
														process.Id,
														process.ProcessName,
														Delegate158.smethod_0(process),
														Delegate159.smethod_0(process)
													});
													num = -32;
													goto IL_0222;
												case -80:
													num11 = 0;
													num = -3;
													goto IL_0222;
												case -79:
													num11++;
													goto IL_0211;
												case -83:
													{
														process = processes[num11];
														num = -2;
														goto IL_0222;
													}
													IL_0211:
													if (num11 >= processes.Length)
													{
														return;
													}
													goto case -83;
												}
												num2 = 3;
												goto end_IL_02d6;
												IL_0080:
												num9 = 30;
												num10 = -24;
												num10 = -80;
												continue;
												IL_0222:
												num ^= 0x51;
												goto IL_0229;
												IL_0229:
												num2 = 0;
												num3 = 8;
												goto IL_022f;
												IL_0248:
												num5 ^= 0x4F;
												goto IL_024f;
												IL_024f:
												num6 = Class10.smethod_0(85);
												num7 = 2;
												goto IL_025b;
												IL_022f:
												num3 ^= 0x58;
												goto IL_0236;
												continue;
												end_IL_026f:
												break;
											}
											continue;
											end_IL_0285:
											break;
										}
										continue;
										end_IL_029a:
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
							end_IL_02cd:
							break;
						}
						continue;
						end_IL_02d6:
						break;
					}
					continue;
					end_IL_02e7:
					break;
				}
			}
		}
		catch (Exception ex)
		{
			Delegate151.smethod_0(this, "Error logging processes: {0}", new object[1] { ex });
		}
	}

	private static object smethod_1(Process process_0)
	{
		try
		{
			return process_0.StartTime;
		}
		catch
		{
			return "???";
		}
	}

	private static object smethod_2(Process process_0)
	{
		try
		{
			return process_0.TotalProcessorTime;
		}
		catch
		{
			return "???";
		}
	}

	public Class6 method_10()
	{
		return Delegate160.smethod_0(this);
	}

	public Class6 method_11()
	{
		return Delegate161.smethod_0(this, gclass1_0);
	}

	private int method_12()
	{
		if (!dictionary_0.TryGetValue(Delegate155.smethod_0(), out var value) && 0 == 0)
		{
			return 0;
		}
		return value;
	}

	private void method_13(string string_1)
	{
		int num = Delegate162.smethod_0(this);
		string value = string.Format(CultureInfo.InvariantCulture, "[{0:yyyy-MM-dd HH:mm:ss.fffZ}] [{1:x4}] {2}{3}", DateTime.Now, Thread.CurrentThread.ManagedThreadId, (num > 0) ? new string(' ', num * 2) : string.Empty, string_1);
		streamWriter_0.WriteLine(value);
	}

	private void method_14(string string_1)
	{
		lock (object_0)
		{
			if ((!(string_0 != string_1)) ? true : false)
			{
				return;
			}
			Delegate163.smethod_0(this);
			string_0 = string_1;
			if (string.IsNullOrEmpty(string_0) ? true : false)
			{
				return;
			}
			streamWriter_0 = File.CreateText(string_0);
			while (true)
			{
				int num = 12;
				int num2 = -2;
				while (true)
				{
					num2 ^= 0x4F;
					while (true)
					{
						int num3 = 2;
						int num4 = -27;
						while (true)
						{
							num4 ^= 0x57;
							while (true)
							{
								int num5 = 29;
								int num6 = -5;
								while (true)
								{
									num6 ^= 0x56;
									while (true)
									{
										int num7 = 1;
										int num8 = -2;
										while (true)
										{
											num8 ^= 0x53;
											int num9 = Class8.smethod_0(41);
											while (true)
											{
												switch (num9 ^ 0x51)
												{
												case -84:
													break;
												default:
													num9 = Class8.smethod_0(41);
													continue;
												case -83:
													num8 = Class8.smethod_0(39);
													num9 = -1;
													num9 = -82;
													goto end_IL_008b;
												case -82:
													goto end_IL_008b;
												case -85:
													while (true)
													{
														num9 = -6;
														num9 = -85;
													}
												}
												switch (num8)
												{
												case -86:
													goto IL_00ae;
												case -84:
													goto IL_00b7;
												case -83:
													goto IL_021b;
												case -85:
													goto end_IL_0244;
												}
												num9 = Class8.smethod_0(38);
												continue;
												IL_00ae:
												num8 = -7;
												break;
												continue;
												end_IL_008b:
												break;
											}
											continue;
											IL_01fa:
											num4 = Class8.smethod_0(51);
											num5 = 27;
											goto IL_0207;
											IL_00b7:
											switch (num7)
											{
											case 78:
												goto IL_00df;
											case 79:
												goto IL_00e7;
											case 80:
												goto IL_020e;
											case 81:
												goto end_IL_0259;
											}
											num8 = GEventArgs2.smethod_0(43);
											continue;
											IL_00e7:
											switch (num6)
											{
											case -86:
												goto IL_010a;
											case -83:
												goto IL_0207;
											case -85:
												goto IL_0268;
											case -84:
												goto end_IL_0271;
											}
											num7 = 30;
											goto IL_021b;
											IL_0268:
											num6 = Class8.smethod_0(41);
											goto end_IL_0259;
											IL_010a:
											switch (num5)
											{
											case 81:
												break;
											case 82:
												goto IL_0132;
											case 83:
												goto IL_01fa;
											default:
												goto IL_0262;
											case 84:
												goto end_IL_027a;
											}
											num5 = 30;
											goto IL_0207;
											IL_0262:
											num6 = -6;
											goto end_IL_0259;
											IL_0132:
											switch (num4)
											{
											case -80:
												goto IL_0155;
											case -78:
												goto IL_01f5;
											case -81:
												goto IL_0284;
											case -79:
												goto end_IL_0293;
											}
											num5 = 28;
											goto IL_0207;
											IL_0284:
											num4 = GEventArgs2.smethod_0(43);
											goto end_IL_027a;
											IL_0155:
											switch (num3)
											{
											case 82:
												break;
											case 81:
												goto IL_01e7;
											case 83:
												goto IL_01f3;
											default:
												goto IL_028f;
											case 84:
												goto end_IL_029c;
											}
											switch (num2)
											{
											case -81:
												goto IL_0190;
											case -79:
												goto IL_01e2;
											case -82:
												goto IL_02a4;
											case -80:
												goto end_IL_02b1;
											}
											num3 = 1;
											goto IL_01f5;
											IL_028f:
											num4 = -26;
											goto end_IL_027a;
											IL_01f3:
											num3 = 3;
											goto IL_01f5;
											IL_0207:
											num5 ^= 0x4F;
											goto IL_020e;
											IL_02a4:
											num2 = -31;
											goto end_IL_029c;
											IL_0190:
											switch (num)
											{
											case 89:
												break;
											case 90:
												goto IL_01b7;
											case 91:
												goto IL_01c2;
											case 92:
												goto IL_01d3;
											default:
												goto IL_02a9;
											case 93:
												Delegate165.smethod_0(this);
												return;
											}
											num = 9;
											goto IL_01e2;
											IL_02a9:
											num2 = Class8.smethod_0(39);
											goto end_IL_029c;
											IL_01d3:
											streamWriter_0.AutoFlush = true;
											num = 10;
											goto IL_01e2;
											IL_01c2:
											if (int_0 >= 1)
											{
												num = 13;
												goto IL_01e2;
											}
											return;
											IL_020e:
											num6 = Class8.smethod_0(38);
											num7 = 31;
											goto IL_021b;
											IL_01b7:
											Delegate164.smethod_0(this);
											num = 11;
											goto IL_01e2;
											IL_021b:
											num7 ^= 0x4E;
											num8 = Class8.smethod_0(39);
											num9 = -1;
											num9 = -82;
											continue;
											IL_01e2:
											num ^= 0x50;
											goto IL_01e7;
											IL_01e7:
											num2 = GEventArgs2.smethod_1(59);
											num3 = 4;
											goto IL_01f5;
											IL_00df:
											num7 = 0;
											goto IL_021b;
											IL_01f5:
											num3 ^= 0x50;
											goto IL_01fa;
											continue;
											end_IL_0244:
											break;
										}
										continue;
										end_IL_0259:
										break;
									}
									continue;
									end_IL_0271:
									break;
								}
								continue;
								end_IL_027a:
								break;
							}
							continue;
							end_IL_0293:
							break;
						}
						continue;
						end_IL_029c:
						break;
					}
					continue;
					end_IL_02b1:
					break;
				}
			}
		}
	}

	private void method_15()
	{
		string text = Delegate166.smethod_0(this);
		FileVersionInfo fileVersionInfo = ((string.IsNullOrEmpty(text) ? true : false) ? null : FileVersionInfo.GetVersionInfo(text));
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Delegate151.smethod_0(this, "Executing Assembly: {0}; Path: {1}; Location: {2}; Product: {3}", new object[4]
		{
			executingAssembly,
			text,
			executingAssembly.Location,
			(fileVersionInfo != null) ? fileVersionInfo.ProductVersion : "unknown"
		});
		while (true)
		{
			int num = 1;
			int num2 = 9;
			while (true)
			{
				num2 ^= 0x50;
				while (true)
				{
					int num3 = Class8.smethod_0(50);
					int num4 = 18;
					while (true)
					{
						num4 ^= 0x4E;
						while (true)
						{
							int num5 = Class8.smethod_0(48);
							int num6 = 30;
							while (true)
							{
								num6 ^= 0x4D;
								while (true)
								{
									int num7 = 2;
									int num8 = -12;
									while (true)
									{
										IL_0339:
										num8 ^= 0x58;
										int num9 = Class8.smethod_0(57);
										while (true)
										{
											switch (num9 ^ 0x50)
											{
											default:
												num9 = Class8.smethod_0(57);
												continue;
											case -87:
												break;
											case -88:
												goto IL_00b3;
											case -86:
												goto IL_0339;
											case -89:
												while (true)
												{
													num9 = -9;
													num9 = -89;
												}
											}
											break;
										}
										switch (num8)
										{
										case -86:
											goto IL_00c9;
										case -85:
											goto IL_00d7;
										case -84:
											goto IL_0321;
										case -87:
											goto end_IL_0339;
										}
										num9 = -8;
										num9 = -88;
										goto IL_00b3;
										IL_02ff:
										num4 = 20;
										num5 = Class8.smethod_0(51);
										goto IL_030c;
										IL_031a:
										num6 = 31;
										num7 = 5;
										goto IL_0321;
										IL_00d7:
										switch (num7)
										{
										case 82:
											goto IL_00fa;
										case 83:
											goto IL_0315;
										case 84:
											goto IL_031a;
										case 85:
											goto end_IL_034e;
										}
										num8 = -15;
										continue;
										IL_0315:
										num7 = 3;
										goto IL_0321;
										IL_00fa:
										switch (num6)
										{
										case 82:
											goto IL_011c;
										case 83:
											goto IL_030c;
										case 81:
											goto IL_0357;
										case 80:
											goto end_IL_0361;
										}
										num7 = 4;
										goto IL_0321;
										IL_0357:
										num6 = 28;
										goto end_IL_034e;
										IL_011c:
										switch (num5)
										{
										case -83:
											break;
										case -82:
											goto IL_02f9;
										case -81:
											goto IL_02ff;
										default:
											goto IL_035d;
										case -80:
											goto end_IL_036a;
										}
										switch (num4)
										{
										case 90:
											goto IL_015e;
										case 92:
											goto IL_02f0;
										case 91:
											goto IL_037f;
										case 89:
											goto end_IL_0383;
										}
										num5 = -8;
										goto IL_030c;
										IL_035d:
										num6 = 29;
										goto end_IL_034e;
										IL_02f9:
										num5 = -7;
										goto IL_030c;
										IL_0321:
										num7 ^= 0x50;
										num8 = Class8.smethod_0(58);
										num9 = -6;
										num9 = -86;
										continue;
										IL_037f:
										num4 = 21;
										goto end_IL_036a;
										IL_015e:
										switch (num3)
										{
										case -88:
											break;
										case -87:
											goto IL_02e3;
										case -86:
											goto IL_02e9;
										default:
											goto IL_0379;
										case -85:
											goto end_IL_038c;
										}
										switch (num2)
										{
										case 88:
											goto IL_01a0;
										case 89:
											goto IL_02dc;
										case 86:
											goto IL_039b;
										case 87:
											goto end_IL_03a3;
										}
										num3 = -28;
										goto IL_02f0;
										IL_0379:
										num4 = 23;
										goto end_IL_036a;
										IL_02e3:
										num3 = -25;
										goto IL_02f0;
										IL_00c9:
										num8 = GEventArgs2.smethod_0(44);
										continue;
										IL_039b:
										num2 = 6;
										goto end_IL_038c;
										IL_01a0:
										switch (num)
										{
										case 83:
											break;
										case 84:
											goto IL_01ee;
										case 85:
											goto IL_020e;
										case 86:
											goto IL_024c;
										case 87:
											goto IL_0269;
										case 88:
											goto IL_026d;
										case 89:
											goto IL_02c0;
										default:
											goto IL_03a0;
										case 90:
											return;
										}
										Delegate151.smethod_0(this, "Entry Assembly: {0}", new object[1] { Assembly.GetEntryAssembly() });
										num = 4;
										goto IL_02dc;
										IL_03a0:
										num2 = 7;
										goto end_IL_038c;
										IL_02c0:
										Delegate151.smethod_0(this, "Runtime: {0}", new object[1] { Environment.Version });
										num = 10;
										goto IL_02dc;
										IL_026d:
										Delegate151.smethod_0(this, "Console encoding: Input: {0} ({1}); Output: {2} ({3})", new object[4]
										{
											Console.InputEncoding.EncodingName,
											Console.InputEncoding.CodePage,
											Console.OutputEncoding.EncodingName,
											Console.OutputEncoding.CodePage
										});
										num = 6;
										goto IL_02dc;
										IL_0269:
										num = 5;
										goto IL_02dc;
										IL_024c:
										Delegate151.smethod_0(this, "Operating system: {0}", new object[1] { Environment.OSVersion });
										num = 7;
										goto IL_02dc;
										IL_020e:
										Delegate151.smethod_0(this, "User: {0}@{1}@{2}; Interactive: {3}", new object[4]
										{
											Environment.UserName,
											Environment.UserDomainName,
											Environment.MachineName,
											Environment.UserInteractive
										});
										num = 11;
										goto IL_02dc;
										IL_01ee:
										Delegate151.smethod_0(this, "Working directory: {0}", new object[1] { Environment.CurrentDirectory });
										num = 8;
										goto IL_02dc;
										IL_00b3:
										num8 = Class8.smethod_0(58);
										num9 = -6;
										num9 = -86;
										continue;
										IL_02dc:
										num ^= 0x52;
										goto IL_02e9;
										IL_02e9:
										num2 = 8;
										num3 = -27;
										goto IL_02f0;
										IL_030c:
										num5 ^= 0x57;
										goto IL_031a;
										IL_02f0:
										num3 ^= 0x4E;
										goto IL_02ff;
										continue;
										end_IL_0339:
										break;
									}
									continue;
									end_IL_034e:
									break;
								}
								continue;
								end_IL_0361:
								break;
							}
							continue;
							end_IL_036a:
							break;
						}
						continue;
						end_IL_0383:
						break;
					}
					continue;
					end_IL_038c:
					break;
				}
				continue;
				end_IL_03a3:
				break;
			}
		}
	}

	public static string smethod_3()
	{
		return new Win32Exception(Marshal.GetLastWin32Error()).Message;
	}

	private void method_16(int int_1)
	{
		if (int_1 < 0 || int_1 > 2)
		{
			throw new ArgumentOutOfRangeException(string.Format(CultureInfo.CurrentCulture, "Logging level has to be in range 0-2"));
		}
		int_0 = int_1;
	}
}
