using System;
using System.Runtime.InteropServices;

internal class Class20 : IDisposable
{
	private IntPtr intptr_0;

	private Class21 class21_0;

	public Class20(Class21 class21_1, string string_0)
	{
		class21_0 = class21_1;
		intptr_0 = Delegate141.smethod_0(IntPtr.Zero, string_0);
		if (intptr_0 == IntPtr.Zero || 1 == 0)
		{
			Delegate45.smethod_0(class21_0, "Cannot create job ({0})", new object[1] { Delegate142.smethod_0() });
			return;
		}
		Delegate79.smethod_0(class21_0, "Job created");
		IntPtr intPtr = default(IntPtr);
		int num10 = default(int);
		Struct1 struct1_ = default(Struct1);
		Struct3 @struct = default(Struct3);
		while (true)
		{
			int num = Class10.smethod_0(85);
			int num2 = -32;
			while (true)
			{
				num2 ^= 0x55;
				while (true)
				{
					int num3 = Class8.smethod_0(41);
					int num4 = Class10.smethod_0(80);
					while (true)
					{
						num4 ^= 0x58;
						while (true)
						{
							int num5 = Class8.smethod_0(57);
							int num6 = -6;
							while (true)
							{
								num6 ^= 0x50;
								while (true)
								{
									int num7 = 7;
									int num8 = 2;
									while (true)
									{
										num8 ^= 0x56;
										int num9 = Class8.smethod_0(47);
										while (true)
										{
											switch (num9 ^ 0x4F)
											{
											case -76:
												break;
											default:
												num9 = Class8.smethod_0(47);
												continue;
											case -78:
												num8 = 4;
												num9 = -6;
												num9 = -75;
												goto end_IL_0098;
											case -75:
												goto end_IL_0098;
											case -77:
												while (true)
												{
													num9 = -4;
													num9 = -77;
												}
											}
											switch (num8)
											{
											case 82:
												goto IL_00cb;
											case 83:
												goto IL_02b7;
											case 84:
												goto IL_02bc;
											case 81:
												goto end_IL_02ce;
											}
											num9 = Class8.smethod_0(41);
											continue;
											IL_02b7:
											num8 = 5;
											break;
											continue;
											end_IL_0098:
											break;
										}
										continue;
										IL_02a9:
										num6 = Class8.smethod_0(57);
										num7 = 5;
										goto IL_02bc;
										IL_00cb:
										switch (num7)
										{
										case 80:
											goto IL_00ed;
										case 81:
											goto IL_00f5;
										case 82:
											goto IL_02a9;
										case 83:
											goto end_IL_02e3;
										}
										num8 = 7;
										continue;
										IL_00f5:
										switch (num6)
										{
										case -87:
											goto IL_0117;
										case -86:
											goto IL_02a2;
										case -89:
											goto IL_02eb;
										case -88:
											goto end_IL_02fa;
										}
										num7 = 4;
										goto IL_02bc;
										IL_02eb:
										num6 = -9;
										goto end_IL_02e3;
										IL_0117:
										switch (num5)
										{
										case -85:
											break;
										case -84:
											goto IL_028f;
										case -83:
											goto IL_0295;
										default:
											goto IL_02f1;
										case -82:
											goto end_IL_0303;
										}
										switch (num4)
										{
										case -79:
											goto IL_0158;
										case -78:
											goto IL_0286;
										case -81:
											goto IL_0312;
										case -80:
											goto end_IL_031c;
										}
										num5 = -1;
										goto IL_02a2;
										IL_02f1:
										num6 = GEventArgs2.smethod_0(43);
										goto end_IL_02e3;
										IL_028f:
										num5 = -2;
										goto IL_02a2;
										IL_0295:
										num4 = GEventArgs2.smethod_1(52);
										num5 = -4;
										goto IL_02a2;
										IL_0312:
										num4 = -9;
										goto end_IL_0303;
										IL_0158:
										switch (num3)
										{
										case -88:
											break;
										case -87:
											goto IL_0273;
										case -86:
											goto IL_0279;
										default:
											goto IL_0318;
										case -85:
											goto end_IL_0325;
										}
										switch (num2)
										{
										case -78:
											goto IL_019f;
										case -75:
											goto IL_026a;
										case -77:
											goto IL_0344;
										case -76:
											goto end_IL_0348;
										}
										num3 = Class8.smethod_0(39);
										goto IL_0286;
										IL_0318:
										num4 = -24;
										goto end_IL_0303;
										IL_0273:
										num3 = -4;
										goto IL_0286;
										IL_02a2:
										num5 ^= 0x52;
										goto IL_02a9;
										IL_0344:
										num2 = -26;
										goto end_IL_0325;
										IL_019f:
										switch (num)
										{
										case -87:
											break;
										case -86:
											goto IL_01f0;
										case -85:
											goto IL_01fd;
										case -84:
											goto IL_020b;
										case -83:
											goto IL_021e;
										case -82:
											goto IL_0224;
										case -81:
											goto IL_0237;
										case -80:
											goto IL_0244;
										case -79:
											goto IL_025a;
										default:
											goto IL_0339;
										case -78:
											goto IL_0370;
										}
										if (Delegate143.smethod_0(intptr_0, Enum2.const_4, intPtr, (uint)num10))
										{
											num = -4;
											goto IL_026a;
										}
										if (true)
										{
											Delegate45.smethod_0(class21_0, "Cannot set job to kill all processes ({0})", new object[1] { Delegate142.smethod_0() });
											return;
										}
										goto IL_0370;
										IL_0339:
										num2 = Class10.smethod_0(85);
										goto end_IL_0325;
										IL_025a:
										struct1_.uint_0 = 8192u;
										num = -32;
										goto IL_026a;
										IL_0244:
										num10 = Marshal.SizeOf(typeof(Struct3));
										num = -28;
										goto IL_026a;
										IL_0237:
										struct1_ = default(Struct1);
										num = -1;
										goto IL_026a;
										IL_0224:
										@struct = default(Struct3);
										num = Class10.smethod_0(88);
										goto IL_026a;
										IL_021e:
										num = -29;
										goto IL_026a;
										IL_020b:
										Marshal.StructureToPtr((object)@struct, intPtr, fDeleteOld: false);
										num = -25;
										goto IL_026a;
										IL_01fd:
										@struct.struct1_0 = struct1_;
										num = -2;
										goto IL_026a;
										IL_01f0:
										intPtr = Marshal.AllocHGlobal(num10);
										num = -30;
										goto IL_026a;
										IL_0286:
										num3 ^= 0x55;
										goto IL_0295;
										IL_00ed:
										num7 = 6;
										goto IL_02bc;
										IL_026a:
										num ^= 0x4E;
										goto IL_0279;
										IL_0279:
										num2 = Class8.smethod_0(51);
										num3 = -2;
										goto IL_0286;
										IL_02bc:
										num7 ^= 0x56;
										num8 = 4;
										num9 = -6;
										num9 = -75;
										continue;
										IL_0370:
										Delegate79.smethod_0(class21_0, "Job set to kill all processes");
										return;
										continue;
										end_IL_02ce:
										break;
									}
									continue;
									end_IL_02e3:
									break;
								}
								continue;
								end_IL_02fa:
								break;
							}
							continue;
							end_IL_0303:
							break;
						}
						continue;
						end_IL_031c:
						break;
					}
					continue;
					end_IL_0325:
					break;
				}
				continue;
				end_IL_0348:
				break;
			}
		}
	}

	~Class20()
	{
		Delegate144.smethod_0(this);
	}

	public void Dispose()
	{
		Delegate144.smethod_0(this);
		GC.SuppressFinalize(this);
	}

	private void method_0()
	{
		Delegate145.smethod_0(this);
	}

	public void method_1()
	{
		Delegate79.smethod_0(class21_0, "Closing job");
		while (true)
		{
			int num = Class8.smethod_0(47);
			int num2 = 9;
			while (true)
			{
				num2 ^= 0x51;
				while (true)
				{
					int num3 = Class10.smethod_0(88);
					int num4 = -5;
					while (true)
					{
						num4 ^= 0x56;
						while (true)
						{
							int num5 = Class8.smethod_0(50);
							int num6 = 3;
							while (true)
							{
								num6 ^= 0x55;
								while (true)
								{
									int num7 = 25;
									int num8 = -2;
									while (true)
									{
										IL_01f2:
										num8 ^= 0x53;
										int num9 = Class8.smethod_0(42);
										while (true)
										{
											switch (num9 ^ 0x4E)
											{
											case -81:
												num9 = Class10.smethod_0(85);
												continue;
											default:
												num9 = Class8.smethod_0(42);
												continue;
											case -80:
												break;
											case -82:
												goto IL_006e;
											case -79:
												goto IL_01f2;
											}
											break;
										}
										switch (num8)
										{
										case -86:
											goto IL_0083;
										case -84:
											goto IL_01d6;
										case -83:
											goto IL_01db;
										case -85:
											goto end_IL_01f2;
										}
										num9 = -32;
										num9 = -82;
										goto IL_006e;
										IL_01b4:
										num4 = Class8.smethod_0(48);
										num5 = -28;
										goto IL_01c0;
										IL_01db:
										num7 ^= 0x4F;
										num8 = Class8.smethod_0(57);
										num9 = -1;
										num9 = -79;
										continue;
										IL_01d6:
										num8 = -1;
										continue;
										IL_0083:
										switch (num7)
										{
										case 86:
											goto IL_00ab;
										case 85:
											goto IL_01c7;
										case 87:
											goto IL_01d0;
										case 88:
											goto end_IL_0207;
										}
										num8 = GEventArgs2.smethod_0(43);
										continue;
										IL_01d0:
										num7 = 24;
										goto IL_01db;
										IL_00ab:
										switch (num6)
										{
										case 85:
											goto IL_00ce;
										case 86:
											goto IL_01c0;
										case 83:
											goto IL_0211;
										case 84:
											goto end_IL_0219;
										}
										num7 = 26;
										goto IL_01db;
										IL_0211:
										num6 = 6;
										goto end_IL_0207;
										IL_00ce:
										switch (num5)
										{
										case -81:
											break;
										case -80:
											goto IL_00f6;
										case -79:
											goto IL_01b4;
										default:
											goto IL_0216;
										case -78:
											goto end_IL_0222;
										}
										num5 = -7;
										goto IL_01c0;
										IL_0216:
										num6 = 1;
										goto end_IL_0207;
										IL_00f6:
										switch (num4)
										{
										case -84:
											goto IL_011d;
										case -83:
											goto IL_01af;
										case -86:
											goto IL_0230;
										case -85:
											goto end_IL_023d;
										}
										num5 = Class8.smethod_0(51);
										goto IL_01c0;
										IL_0230:
										num4 = -4;
										goto end_IL_0222;
										IL_011d:
										switch (num3)
										{
										case -88:
											break;
										case -86:
											goto IL_0140;
										case -87:
											goto IL_01aa;
										default:
											goto IL_0235;
										case -85:
											goto end_IL_0244;
										}
										num3 = -25;
										goto IL_01af;
										IL_0235:
										num4 = Class8.smethod_0(41);
										goto end_IL_0222;
										IL_0140:
										switch (num2)
										{
										case 85:
											goto IL_0163;
										case 88:
											goto IL_01a5;
										case 86:
											goto IL_0255;
										case 87:
											goto end_IL_0257;
										}
										num3 = Class8.smethod_0(50);
										goto IL_01af;
										IL_0255:
										num2 = 7;
										goto end_IL_0244;
										IL_0163:
										switch (num)
										{
										case -85:
											break;
										case -84:
											goto IL_0192;
										case -83:
											goto IL_0197;
										default:
											goto IL_0251;
										case -82:
											return;
										}
										Delegate146.smethod_0(intptr_0);
										num = -3;
										goto IL_01a5;
										IL_0251:
										num2 = 6;
										goto end_IL_0244;
										IL_0197:
										intptr_0 = IntPtr.Zero;
										num = -2;
										goto IL_01a5;
										IL_0192:
										num = -4;
										goto IL_01a5;
										IL_006e:
										num8 = Class8.smethod_0(57);
										num9 = -1;
										num9 = -79;
										continue;
										IL_01a5:
										num ^= 0x50;
										goto IL_01aa;
										IL_01aa:
										num2 = 4;
										num3 = -28;
										goto IL_01af;
										IL_01c7:
										num6 = 0;
										num7 = 23;
										goto IL_01db;
										IL_01c0:
										num5 ^= 0x56;
										goto IL_01c7;
										IL_01af:
										num3 ^= 0x4F;
										goto IL_01b4;
										continue;
										end_IL_01f2:
										break;
									}
									continue;
									end_IL_0207:
									break;
								}
								continue;
								end_IL_0219:
								break;
							}
							continue;
							end_IL_0222:
							break;
						}
						continue;
						end_IL_023d:
						break;
					}
					continue;
					end_IL_0244:
					break;
				}
				continue;
				end_IL_0257:
				break;
			}
		}
	}
}
