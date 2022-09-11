using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

internal class Class15 : IDisposable
{
	public const int int_0 = 7;

	private IntPtr intptr_0;

	private readonly Class14 class14_0;

	private bool bool_0;

	private readonly IntPtr intptr_1;

	private object object_0;

	private readonly SafeFileHandle safeFileHandle_0;

	private readonly GClass16 gclass16_0;

	public GEnum0 GEnum0_0 => class14_0.genum0_0;

	public Class9 Class9_0 => method_0<Class9>(GEnum0.const_1);

	public Class8 Class8_0 => method_0<Class8>(GEnum0.const_5);

	public Class10 Class10_0 => method_0<Class10>(GEnum0.const_2);

	public Class11 Class11_0 => method_0<Class11>(GEnum0.const_3);

	public Class12 Class12_0 => method_0<Class12>(GEnum0.const_4);

	public Class13 Class13_0 => method_0<Class13>(GEnum0.const_6);

	public static int Int32_0
	{
		get
		{
			Type[] obj = new Type[6]
			{
				typeof(Class9),
				typeof(Class8),
				typeof(Class10),
				typeof(Class11),
				typeof(Class12),
				typeof(Class13)
			};
			int num = 0;
			Type[] array = obj;
			int num10 = default(int);
			Type t = default(Type);
			while (true)
			{
				int num2 = Class8.smethod_0(38);
				int num3 = GEventArgs2.smethod_1(59);
				while (true)
				{
					num3 ^= 0x52;
					while (true)
					{
						int num4 = Class10.smethod_0(86);
						int num5 = -30;
						while (true)
						{
							num5 ^= 0x54;
							while (true)
							{
								int num6 = Class10.smethod_0(85);
								int num7 = -31;
								while (true)
								{
									num7 ^= 0x54;
									while (true)
									{
										int num8 = Class8.smethod_0(48);
										int num9 = GEventArgs2.smethod_0(43);
										while (true)
										{
											switch (num9 ^ 0x56)
											{
											case -82:
												break;
											case -84:
												goto IL_0071;
											default:
												num9 = Class8.smethod_0(48);
												continue;
											case -83:
												goto end_IL_0203;
											case -85:
												while (true)
												{
													num9 = -3;
													num9 = -85;
												}
											}
											goto IL_005c;
											IL_0071:
											switch (num8)
											{
											case -84:
												break;
											case -83:
												goto IL_01df;
											case -82:
												goto IL_01e8;
											default:
												goto IL_0226;
											case -81:
												goto end_IL_022e;
											}
											switch (num7)
											{
											case -76:
												goto IL_00b0;
											case -75:
												goto IL_01d6;
											case -77:
												goto IL_0242;
											case -78:
												goto end_IL_024c;
											}
											num8 = -8;
											goto IL_005c;
											IL_0226:
											num9 = -5;
											num9 = -83;
											break;
											IL_01df:
											num8 = -5;
											goto IL_005c;
											IL_01c9:
											num5 = GEventArgs2.smethod_1(59);
											num6 = -29;
											goto IL_01d6;
											IL_0242:
											num7 = -25;
											goto end_IL_022e;
											IL_00b0:
											switch (num6)
											{
											case -77:
												break;
											case -76:
												goto IL_00d8;
											case -75:
												goto IL_01c9;
											default:
												goto IL_0248;
											case -74:
												goto end_IL_0255;
											}
											num6 = -26;
											goto IL_01d6;
											IL_0248:
											num7 = -26;
											goto end_IL_022e;
											IL_00d8:
											switch (num5)
											{
											case -76:
												goto IL_00fb;
											case -74:
												goto IL_01c2;
											case -77:
												goto IL_0264;
											case -75:
												goto end_IL_0273;
											}
											num6 = -32;
											goto IL_01d6;
											IL_0264:
											num5 = Class8.smethod_0(51);
											goto end_IL_0255;
											IL_00fb:
											switch (num4)
											{
											case -76:
												break;
											case -77:
												goto IL_01aa;
											case -75:
												goto IL_01b9;
											default:
												goto IL_026f;
											case -74:
												goto end_IL_027c;
											}
											switch (num3)
											{
											case -81:
												goto IL_013d;
											case -78:
												goto IL_01a3;
											case -80:
												goto IL_0291;
											case -79:
												goto end_IL_0295;
											}
											num4 = -22;
											goto IL_01c2;
											IL_026f:
											num5 = -31;
											goto end_IL_0255;
											IL_01b9:
											num4 = Class10.smethod_0(83);
											goto IL_01c2;
											IL_01e8:
											num7 = GEventArgs2.smethod_1(59);
											num8 = -7;
											goto IL_005c;
											IL_0291:
											num3 = -30;
											goto end_IL_027c;
											IL_013d:
											switch (num2)
											{
											case -88:
												break;
											case -86:
												goto IL_0177;
											case -85:
												if (num10 != 0)
												{
													goto IL_0180;
												}
												goto IL_0192;
											case -84:
												goto IL_0186;
											case -83:
												num10++;
												goto IL_0192;
											case -87:
												goto IL_019b;
											default:
												goto IL_028b;
												IL_0192:
												if (num10 >= array.Length)
												{
													return Marshal.SizeOf(typeof(Class14)) + num;
												}
												goto IL_019b;
											}
											num = Math.Max(num, Marshal.SizeOf(t));
											num2 = -3;
											goto IL_01a3;
											IL_028b:
											num3 = -29;
											goto end_IL_027c;
											IL_0186:
											num10 = 0;
											num2 = -5;
											goto IL_01a3;
											IL_0180:
											num2 = -7;
											goto IL_01a3;
											IL_019b:
											t = array[num10];
											num2 = -8;
											goto IL_01a3;
											IL_0177:
											num2 = -6;
											goto IL_01a3;
											IL_005c:
											num8 ^= 0x56;
											num9 = Class8.smethod_0(48);
											continue;
											IL_01a3:
											num2 ^= 0x50;
											goto IL_01aa;
											IL_01aa:
											num3 = Class8.smethod_0(41);
											num4 = -17;
											goto IL_01c2;
											IL_01d6:
											num6 ^= 0x55;
											goto IL_01e8;
											IL_01c2:
											num4 ^= 0x59;
											goto IL_01c9;
											continue;
											end_IL_0203:
											break;
										}
										continue;
										end_IL_022e:
										break;
									}
									continue;
									end_IL_024c:
									break;
								}
								continue;
								end_IL_0255:
								break;
							}
							continue;
							end_IL_0273:
							break;
						}
						continue;
						end_IL_027c:
						break;
					}
					continue;
					end_IL_0295:
					break;
				}
			}
		}
	}

	public Class15(GClass16 gclass16_1, SafeFileHandle safeFileHandle_1)
	{
		gclass16_0 = gclass16_1;
		while (true)
		{
			int num = 25;
			int num2 = 2;
			while (true)
			{
				num2 ^= 0x56;
				while (true)
				{
					int num3 = Class8.smethod_0(39);
					int num4 = -26;
					while (true)
					{
						num4 ^= 0x54;
						while (true)
						{
							int num5 = 11;
							int num6 = -22;
							while (true)
							{
								num6 ^= 0x58;
								while (true)
								{
									int num7 = 25;
									int num8 = -6;
									while (true)
									{
										IL_0286:
										num8 ^= 0x4F;
										int num9 = GEventArgs2.smethod_0(40);
										while (true)
										{
											switch (num9 ^ 0x58)
											{
											default:
												num9 = GEventArgs2.smethod_0(40);
												continue;
											case -83:
												break;
											case -84:
												goto IL_0060;
											case -82:
												goto IL_0286;
											case -85:
												while (true)
												{
													num9 = -13;
													num9 = -85;
												}
											}
											break;
										}
										switch (num8)
										{
										case -78:
											goto IL_0076;
										case -76:
											goto IL_007f;
										case -75:
											goto IL_026e;
										case -77:
											goto end_IL_0286;
										}
										num9 = -12;
										num9 = -84;
										goto IL_0060;
										IL_025c:
										num6 = Class10.smethod_0(82);
										num7 = 4;
										goto IL_026e;
										IL_026e:
										num7 ^= 0x54;
										num8 = Class8.smethod_0(47);
										num9 = -10;
										num9 = -82;
										continue;
										IL_007f:
										switch (num7)
										{
										case 77:
											goto IL_00a7;
										case 78:
											goto IL_025c;
										case 79:
											goto IL_026a;
										case 80:
											goto end_IL_029b;
										}
										num8 = Class8.smethod_0(38);
										continue;
										IL_026a:
										num7 = 27;
										goto IL_026e;
										IL_00a7:
										switch (num6)
										{
										case -80:
											goto IL_00ca;
										case -78:
											goto IL_0255;
										case -79:
											goto IL_02ab;
										case -81:
											goto end_IL_02b4;
										}
										num7 = 26;
										goto IL_026e;
										IL_02ab:
										num6 = GEventArgs2.smethod_1(52);
										goto end_IL_029b;
										IL_00ca:
										switch (num5)
										{
										case 89:
											break;
										case 91:
											goto IL_00f2;
										case 90:
											goto IL_0249;
										default:
											goto IL_02a5;
										case 92:
											goto end_IL_02bd;
										}
										num5 = 9;
										goto IL_0255;
										IL_02a5:
										num6 = -9;
										goto end_IL_029b;
										IL_00f2:
										switch (num4)
										{
										case -79:
											goto IL_0114;
										case -78:
											goto IL_0244;
										case -80:
											goto IL_02c7;
										case -81:
											goto end_IL_02cf;
										}
										num5 = 10;
										goto IL_0255;
										IL_02c7:
										num4 = -28;
										goto end_IL_02bd;
										IL_0114:
										switch (num3)
										{
										case -82:
											break;
										case -81:
											goto IL_013a;
										case -80:
											goto IL_023f;
										default:
											goto IL_02cc;
										case -79:
											goto end_IL_02d6;
										}
										num3 = -2;
										goto IL_0244;
										IL_02cc:
										num4 = -5;
										goto end_IL_02bd;
										IL_013a:
										switch (num2)
										{
										case 82:
											goto IL_0160;
										case 84:
											goto IL_023a;
										case 83:
											goto IL_02e7;
										case 81:
											goto end_IL_02e9;
										}
										num3 = GEventArgs2.smethod_1(59);
										goto IL_0244;
										IL_02e7:
										num2 = 5;
										goto end_IL_02d6;
										IL_0160:
										switch (num)
										{
										case 77:
											break;
										case 78:
											goto IL_01ab;
										case 79:
											goto IL_01c5;
										case 80:
											goto IL_01d1;
										case 81:
											goto IL_01d5;
										case 82:
											goto IL_01f4;
										case 83:
											goto IL_0218;
										default:
											goto IL_02e3;
										case 84:
											return;
										}
										Delegate52.smethod_0(Delegate51.smethod_0(gclass16_0), 1, "Acquired communication structure");
										num = 5;
										goto IL_023a;
										IL_02e3:
										num2 = 7;
										goto end_IL_02d6;
										IL_0218:
										intptr_1 = new IntPtr(intptr_0.ToInt64() + 12L);
										num = 4;
										goto IL_023a;
										IL_01f4:
										class14_0 = (Class14)Marshal.PtrToStructure(intptr_0, typeof(Class14));
										num = 2;
										goto IL_023a;
										IL_01d5:
										intptr_0 = Delegate53.smethod_0(safeFileHandle_0, GEnum1.flag_3, 0u, 0u, UIntPtr.Zero);
										num = 27;
										goto IL_023a;
										IL_01d1:
										num = 6;
										goto IL_023a;
										IL_01c5:
										safeFileHandle_0 = safeFileHandle_1;
										num = 24;
										goto IL_023a;
										IL_01ab:
										Delegate52.smethod_0(Delegate51.smethod_0(gclass16_0), 1, "Acquiring communication structure");
										num = 7;
										goto IL_023a;
										IL_0060:
										num8 = Class8.smethod_0(47);
										num9 = -10;
										num9 = -82;
										continue;
										IL_023a:
										num ^= 0x56;
										goto IL_023f;
										IL_023f:
										num2 = 4;
										num3 = -31;
										goto IL_0244;
										IL_0255:
										num5 ^= 0x50;
										goto IL_025c;
										IL_0076:
										num8 = -3;
										continue;
										IL_0244:
										num3 ^= 0x50;
										goto IL_0249;
										IL_0249:
										num4 = Class10.smethod_0(88);
										num5 = 12;
										goto IL_0255;
										continue;
										end_IL_0286:
										break;
									}
									continue;
									end_IL_029b:
									break;
								}
								continue;
								end_IL_02b4:
								break;
							}
							continue;
							end_IL_02bd:
							break;
						}
						continue;
						end_IL_02cf:
						break;
					}
					continue;
					end_IL_02d6:
					break;
				}
				continue;
				end_IL_02e9:
				break;
			}
		}
	}

	~Class15()
	{
		Delegate54.smethod_0(this);
	}

	public void Dispose()
	{
		if (intptr_0 != IntPtr.Zero || 1 == 0)
		{
			if (bool_0 || 1 == 0)
			{
				Marshal.StructureToPtr((object)class14_0, intptr_0, fDeleteOld: false);
			}
			if (object_0 != null || 1 == 0)
			{
				while (true)
				{
					int num = 10;
					int num2 = GEventArgs2.smethod_1(59);
					while (true)
					{
						num2 ^= 0x4D;
						while (true)
						{
							int num3 = 24;
							int num4 = -25;
							while (true)
							{
								num4 ^= 0x54;
								while (true)
								{
									int num5 = Class10.smethod_0(82);
									int num6 = 0;
									while (true)
									{
										num6 ^= 0x53;
										while (true)
										{
											int num7 = Class8.smethod_0(53);
											int num8 = GEventArgs2.smethod_1(59);
											while (true)
											{
												num8 ^= 0x52;
												while (true)
												{
													int num9 = Class8.smethod_0(47);
													int num10 = GEventArgs2.smethod_1(59);
													while (true)
													{
														switch (num10 ^ 0x4F)
														{
														case -81:
															break;
														default:
															goto IL_0058;
														case -84:
															goto IL_0066;
														case -83:
															goto end_IL_0207;
														case -82:
															while (true)
															{
																num10 = -31;
																num10 = -82;
															}
														}
														goto IL_0051;
														IL_0066:
														switch (num9)
														{
														case -77:
															break;
														case -76:
															goto IL_008b;
														case -75:
															goto IL_01f0;
														default:
															goto IL_022d;
														case -74:
															goto end_IL_0235;
														}
														num9 = -4;
														goto IL_0051;
														IL_022d:
														num10 = -30;
														num10 = -83;
														break;
														IL_008b:
														switch (num8)
														{
														case -79:
															goto IL_00ab;
														case -78:
															goto IL_01e9;
														case -80:
															goto IL_0249;
														case -81:
															goto end_IL_0253;
														}
														num9 = -6;
														goto IL_0051;
														IL_0249:
														num8 = -30;
														goto end_IL_0235;
														IL_00ab:
														switch (num7)
														{
														case -77:
															break;
														case -76:
															goto IL_01dc;
														case -75:
															goto IL_01e5;
														default:
															goto IL_024f;
														case -74:
															goto end_IL_025c;
														}
														switch (num6)
														{
														case 81:
															goto IL_00ed;
														case 83:
															goto IL_01d5;
														case 80:
															goto IL_0270;
														case 82:
															goto end_IL_0278;
														}
														num7 = -27;
														goto IL_01e9;
														IL_024f:
														num8 = -3;
														goto end_IL_0235;
														IL_01e5:
														num7 = -28;
														goto IL_01e9;
														IL_01d5:
														num5 ^= 0x59;
														goto IL_01dc;
														IL_0270:
														num6 = 3;
														goto end_IL_025c;
														IL_00ed:
														switch (num5)
														{
														case -79:
															break;
														case -80:
															goto IL_01c3;
														case -78:
															goto IL_01d1;
														default:
															goto IL_0275;
														case -77:
															goto end_IL_0281;
														}
														switch (num4)
														{
														case -78:
															goto IL_012e;
														case -77:
															goto IL_01be;
														case -80:
															goto IL_028f;
														case -79:
															goto end_IL_029c;
														}
														num5 = -23;
														goto IL_01d5;
														IL_0275:
														num6 = 1;
														goto end_IL_025c;
														IL_01d1:
														num5 = -21;
														goto IL_01d5;
														IL_01dc:
														num6 = 2;
														num7 = -25;
														goto IL_01e9;
														IL_028f:
														num4 = Class10.smethod_0(84);
														goto end_IL_0281;
														IL_012e:
														switch (num3)
														{
														case 78:
															break;
														case 79:
															goto IL_0151;
														case 80:
															goto IL_01b4;
														default:
															goto IL_0299;
														case 81:
															goto end_IL_02a3;
														}
														num3 = 25;
														goto IL_01be;
														IL_0299:
														num4 = -27;
														goto end_IL_0281;
														IL_0151:
														switch (num2)
														{
														case -84:
															goto IL_016e;
														case -83:
															goto IL_01af;
														case -85:
															goto IL_02ab;
														case -86:
															goto end_IL_02b3;
														}
														num3 = 7;
														goto IL_01be;
														IL_02ab:
														num2 = -26;
														goto end_IL_02a3;
														IL_016e:
														switch (num)
														{
														case 86:
															break;
														case 87:
															goto IL_0190;
														case 88:
															goto IL_01a1;
														default:
															goto IL_02b0;
														case 89:
															goto IL_02c7;
														}
														num = 4;
														goto IL_01af;
														IL_02c7:
														Marshal.StructureToPtr(object_0, intptr_1, fDeleteOld: false);
														goto end_IL_02ba;
														IL_02b0:
														num2 = -25;
														goto end_IL_02a3;
														IL_01a1:
														if (Delegate55.smethod_0(this) == GEnum0.const_1)
														{
															goto end_IL_02ba;
														}
														num = 5;
														goto IL_01af;
														IL_0051:
														num9 ^= 0x4F;
														goto IL_0058;
														IL_0190:
														if (Delegate55.smethod_0(this) == GEnum0.const_4)
														{
															goto end_IL_02ba;
														}
														num = 11;
														goto IL_01af;
														IL_0058:
														num10 = GEventArgs2.smethod_1(68);
														continue;
														IL_01c3:
														num4 = Class8.smethod_0(50);
														num5 = -22;
														goto IL_01d5;
														IL_01af:
														num ^= 0x52;
														goto IL_01b4;
														IL_01b4:
														num2 = Class10.smethod_0(85);
														num3 = 6;
														goto IL_01be;
														IL_01e9:
														num7 ^= 0x51;
														goto IL_01f0;
														IL_01f0:
														num8 = GEventArgs2.smethod_1(68);
														num9 = Class8.smethod_0(57);
														goto IL_0051;
														IL_01be:
														num3 ^= 0x57;
														goto IL_01c3;
														continue;
														end_IL_0207:
														break;
													}
													continue;
													end_IL_0235:
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
										end_IL_0278:
										break;
									}
									continue;
									end_IL_0281:
									break;
								}
								continue;
								end_IL_029c:
								break;
							}
							continue;
							end_IL_02a3:
							break;
						}
						continue;
						end_IL_02b3:
						break;
					}
					continue;
					end_IL_02ba:
					break;
				}
			}
			Delegate52.smethod_0(Delegate51.smethod_0(gclass16_0), 1, "Releasing communication structure");
			if (!Delegate56.smethod_0(intptr_0) && 0 == 0)
			{
				throw Delegate57.smethod_0(gclass16_0, "Cannot release file mapping");
			}
			Delegate52.smethod_0(Delegate51.smethod_0(gclass16_0), 1, "Released communication structure");
			intptr_0 = IntPtr.Zero;
		}
		GC.SuppressFinalize(this);
	}

	private T method_0<T>(GEnum0 genum0_0)
	{
		Delegate58.smethod_0(this);
		if (genum0_0 != Delegate55.smethod_0(this))
		{
			throw new InvalidOperationException("Payload type does not match with event");
		}
		if (object_0 == null && 0 == 0)
		{
			object_0 = Marshal.PtrToStructure(intptr_1, typeof(T));
		}
		return (T)object_0;
	}

	private void method_1()
	{
		if (intptr_0 == IntPtr.Zero || 1 == 0)
		{
			throw new InvalidOperationException("Object is disposed");
		}
	}

	public void method_2()
	{
		bool_0 = true;
		while (true)
		{
			int num = 1;
			int num2 = -30;
			while (true)
			{
				num2 ^= 0x51;
				int num3 = Class10.smethod_0(84);
				int num4 = -30;
				num4 = -77;
				while (true)
				{
					num3 ^= 0x4F;
					num4 = Class10.smethod_0(85);
					while (true)
					{
						switch (num4 ^ 0x51)
						{
						case -80:
							break;
						default:
							num4 = Class10.smethod_0(85);
							continue;
						case -78:
							num3 = Class10.smethod_0(84);
							num4 = -30;
							num4 = -77;
							goto end_IL_0037;
						case -77:
							goto end_IL_0037;
						case -79:
							while (true)
							{
								num4 = -32;
								num4 = -79;
							}
						}
						switch (num3)
						{
						case -87:
							goto IL_0057;
						case -85:
							goto IL_0064;
						case -86:
							goto IL_00dd;
						case -84:
							goto end_IL_00f8;
						}
						num4 = GEventArgs2.smethod_1(68);
						continue;
						IL_0057:
						num3 = Class8.smethod_0(50);
						break;
						continue;
						end_IL_0037:
						break;
					}
					continue;
					IL_00d8:
					num ^= 0x50;
					goto IL_00dd;
					IL_0064:
					switch (num2)
					{
					case -78:
						goto IL_0082;
					case -77:
						goto IL_00d8;
					case -80:
						goto IL_010a;
					case -79:
						goto end_IL_0117;
					}
					num3 = -27;
					continue;
					IL_010a:
					num2 = Class10.smethod_0(85);
					break;
					IL_0082:
					switch (num)
					{
					case 79:
						break;
					case 80:
						goto IL_00b1;
					case 81:
						goto IL_00b5;
					case 82:
						goto IL_00ca;
					default:
						goto IL_0114;
					case 83:
						return;
					}
					class14_0.int_0 = 7;
					num = 2;
					goto IL_00d8;
					IL_0114:
					num2 = -32;
					break;
					IL_00ca:
					class14_0.genum0_0 = GEnum0.const_0;
					num = 3;
					goto IL_00d8;
					IL_00b5:
					class14_0.uint_0 = (uint)Delegate59.smethod_0();
					num = 31;
					goto IL_00d8;
					IL_00b1:
					num = 0;
					goto IL_00d8;
					IL_00dd:
					num2 = GEventArgs2.smethod_1(68);
					num3 = -29;
					continue;
					end_IL_00f8:
					break;
				}
				continue;
				end_IL_0117:
				break;
			}
		}
	}
}
