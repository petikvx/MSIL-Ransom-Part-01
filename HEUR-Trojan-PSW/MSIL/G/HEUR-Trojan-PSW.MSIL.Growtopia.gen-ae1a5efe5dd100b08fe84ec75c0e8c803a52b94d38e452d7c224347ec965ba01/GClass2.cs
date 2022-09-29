using System;
using System.Runtime.InteropServices;

public static class GClass2
{
	public struct GStruct0
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_0;

		public int int_0;

		public GStruct0(string string_1, int int_1)
		{
			string_0 = string_1;
			int_0 = int_1;
		}
	}

	public struct GStruct1 : IDisposable
	{
		public int int_0;

		public int int_1;

		public IntPtr intptr_0;

		public int int_2;

		public IntPtr intptr_1;

		public int int_3;

		public IntPtr intptr_2;

		public int int_4;

		public IntPtr intptr_3;

		public int int_5;

		public int int_6;

		public long long_0;

		public int int_7;

		public GStruct1(byte[] byte_0, byte[] byte_1, byte[] byte_2)
		{
			while (true)
			{
				uint num = 1096227012u;
				this = default(GStruct1);
				while (true)
				{
					if (595596816 + num != 0)
					{
						num *= 714243679;
					}
					while (true)
					{
						IL_02dc:
						num /= 1381838826u;
						int_1 = GClass2.int_1;
						while (true)
						{
							num /= 860046906u;
							Type type_ = Delegate118.smethod_0(typeof(GStruct1).TypeHandle);
							num = 542004528u >> (int)num;
							int_0 = Delegate126.smethod_0(type_);
							num ^= 0x3F9A5417u;
							if (2036810495 <= num)
							{
								break;
							}
							bool num2 = byte_0 == null;
							num = 0x406F25ACu | num;
							bool flag = num2;
							num = 752970162 * num;
							if (!flag)
							{
								num = 414018307u % num;
								if (num >= 650600180)
								{
									break;
								}
								num = 0x78745BF2u ^ num;
								if (1458653431u % num == 0)
								{
									goto end_IL_0368;
								}
								int_2 = byte_0.Length;
								num = 1153827504 - num;
								num <<= 11;
								int num3 = int_2;
								num = 1808809259 + num;
								IntPtr intPtr = Delegate15.smethod_0(num3);
								num ^= 0x34F55C71u;
								intptr_0 = intPtr;
								num %= 484923349u;
								num %= 434111271u;
								int num4 = (int)num + -41418592;
								num -= 503336581;
								IntPtr intPtr2 = intptr_0;
								num += 1707495422;
								Delegate73.smethod_0(byte_0, num4, intPtr2, int_2);
								if (1134448557 << (int)num == 0)
								{
									break;
								}
								num += 1956194395;
								num += 3654603130u;
							}
							num %= 916330174u;
							num >>= 2;
							flag = byte_1 == null;
							num = 0x4CF04728u & num;
							if (!flag)
							{
								num = (uint)(1851010406 << (int)num);
								num |= 0x2FDD05FEu;
								if (589123234 > num)
								{
									goto end_IL_0368;
								}
								int num5 = byte_1.Length;
								num ^= 0x40493584u;
								int_3 = num5;
								num += 1366444488;
								IntPtr intPtr3 = Delegate15.smethod_0(int_3);
								num = 1577194865u / num;
								intptr_1 = intPtr3;
								num ^= 0x61962AD1u;
								if (334764168 == num)
								{
									goto end_IL_0368;
								}
								num = 951016941u % num;
								int num6 = (int)num + -951016941;
								num &= 0x48E52E0Bu;
								num >>= 27;
								IntPtr intPtr4 = intptr_1;
								num >>= 24;
								num = 0u;
								int num7 = int_3;
								num = 1335454131u;
								Delegate73.smethod_0(byte_1, num6, intPtr4, num7);
								num = 2422122283u;
								num = 147866376u;
							}
							num = 158931141 * num;
							flag = byte_2 == null;
							num = 969959532 * num;
							bool num8 = flag;
							num = 0x84267D5u | num;
							if (!num8)
							{
								if (1654861451 == num)
								{
									break;
								}
								if (150212781 == num)
								{
									goto IL_02dc;
								}
								IntPtr intPtr5 = (nint)byte_2.LongLength;
								num -= 1619748779;
								int num9 = (int)(nint)intPtr5;
								num = 2122654651u / num;
								int_4 = num9;
								num = 1105333561 - num;
								int num10 = int_4;
								num = 1204898456u % num;
								IntPtr intPtr6 = Delegate15.smethod_0(num10);
								num = 1329474480u % num;
								intptr_2 = intPtr6;
								num = 1963610524 + num;
								if (2057258148u / num == 0)
								{
									goto end_IL_0368;
								}
								num -= 635590608;
								int num11 = (int)num + -1363150735;
								num &= 0x76283E75u;
								IntPtr intPtr7 = intptr_2;
								num = 0x7BC101C1u ^ num;
								num ^= 0x79B070B2u;
								Delegate73.smethod_0(byte_2, num11, intPtr7, int_4);
								if (num * 1273522419 == 0)
								{
									break;
								}
								if (num / 866603874u == 0)
								{
									continue;
								}
								num = 1735672343u >> (int)num;
								num = 1570506185u / num;
								int num12 = byte_2.Length;
								num /= 1017458251u;
								int_5 = num12;
								num = 1048777851 + num;
								int num13 = int_5;
								num = 1892440493 * num;
								IntPtr intPtr8 = Delegate15.smethod_0(num13);
								num >>= 4;
								intptr_3 = intPtr8;
								num += 214199470;
								num += 2130610598;
							}
							if (num < 951674525)
							{
								break;
							}
							return;
						}
						break;
					}
					continue;
					end_IL_0368:
					break;
				}
			}
		}

		public void Dispose()
		{
			while (true)
			{
				uint num = 433813973u;
				while (true)
				{
					IntPtr intPtr = intptr_0;
					IntPtr zero = IntPtr.Zero;
					num = 1700690382 * num;
					bool num2 = (Delegate137.smethod_0(intPtr, zero) ? 1u : 0u) == (num ^ 0x5067B666);
					num = 679812375u / num;
					bool flag = num2;
					num = 1037441291 - num;
					bool num3 = flag;
					num = 526481144 + num;
					if (!num3)
					{
						num *= 1917743586;
						if (num > 1892292037)
						{
							break;
						}
						goto IL_011a;
					}
					goto IL_0162;
					IL_011a:
					IntPtr intPtr2 = intptr_0;
					num = 739144279u % num;
					Delegate116.smethod_0(intPtr2);
					goto IL_012d;
					IL_0162:
					IntPtr intPtr3 = intptr_2;
					num = 894647273 + num;
					IntPtr zero2 = IntPtr.Zero;
					num %= 482417833u;
					bool num4 = Delegate137.smethod_0(intPtr3, zero2);
					num -= 303902274;
					bool num5 = (num4 ? 1u : 0u) == (num ^ 0xF0A80E5Du);
					num <<= 27;
					flag = num5;
					num = 72704921u;
					if (!flag)
					{
						Delegate116.smethod_0(intptr_2);
						if (1372533937 < num)
						{
							break;
						}
						num += 0;
					}
					num += 1558135937;
					if (num == 668419473)
					{
						continue;
					}
					num %= 228733837u;
					IntPtr intPtr4 = intptr_1;
					num = 0x3FD36909u & num;
					bool num6 = Delegate137.smethod_0(intPtr4, IntPtr.Zero);
					int num7 = (int)num + -29436169;
					num = 0x1BC609D7u ^ num;
					flag = (num6 ? 1 : 0) == num7;
					num <<= 15;
					bool num8 = flag;
					num += 1771201338;
					if (!num8)
					{
						num = 0x7F8D2258u | num;
						if (num < 1525175759)
						{
							break;
						}
						Delegate116.smethod_0(intptr_1);
						num ^= 0x58C0040u;
					}
					num = 0x280108EDu & num;
					IntPtr intPtr5 = intptr_3;
					num = 1792299668 * num;
					IntPtr zero3 = IntPtr.Zero;
					num = 1173186996 - num;
					bool num9 = Delegate137.smethod_0(intPtr5, zero3);
					num = 1555373578u % num;
					flag = (num9 ? 1u : 0u) == (num ^ 0x185C18E2);
					num >>= 17;
					if (!flag)
					{
						num = 1174798717u / num;
						num = 1884046573u >> (int)num;
						IntPtr intPtr6 = intptr_3;
						num ^= 0x7796760u;
						Delegate116.smethod_0(intPtr6);
						num = 132782136u % num;
						if (1382220777 + num == 0)
						{
							goto IL_012d;
						}
						num ^= 0x72A57Eu;
					}
					if (1866420981 != num)
					{
						return;
					}
					goto IL_011a;
					IL_012d:
					num = 2015369801u % num;
					num += 1555841568;
					goto IL_0162;
				}
			}
		}
	}

	public struct GStruct2
	{
		public int int_0;

		public int int_1;

		public int int_2;
	}

	public struct GStruct3
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_0;

		public IntPtr intptr_0;

		public int int_0;

		public GStruct3(string string_1)
		{
			string_0 = string_1;
			intptr_0 = IntPtr.Zero;
			int_0 = 0;
		}
	}

	public const uint uint_0 = 0u;

	public const uint uint_1 = 8u;

	public const uint uint_2 = 4u;

	public static readonly byte[] byte_0 = Delegate54.smethod_0(1296188491);

	public static readonly string string_0 = "ObjectLength";

	public static readonly string string_1 = "ChainingModeGCM";

	public static readonly string string_2 = "AuthTagLength";

	public static readonly string string_3 = "ChainingMode";

	public static readonly string string_4 = "KeyDataBlob";

	public static readonly string string_5 = "AES";

	public static readonly string string_6 = "Microsoft Primitive Provider";

	public static readonly int int_0 = 1;

	public static readonly int int_1 = 1;

	public static readonly uint uint_3 = 3221266434u;

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptOpenAlgorithmProvider(out IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] string string_7, [MarshalAs(UnmanagedType.LPWStr)] string string_8, uint uint_4);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptCloseAlgorithmProvider(IntPtr BC72CAEE, uint uint_4);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptGetProperty(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] string string_7, byte[] byte_1, int int_2, ref int int_3, uint uint_4);

	[DllImport("bcrypt.dll")]
	internal static extern uint BCryptSetProperty(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] string string_7, byte[] byte_1, int int_2, int int_3);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptImportKey(IntPtr intptr_0, IntPtr intptr_1, [MarshalAs(UnmanagedType.LPWStr)] string string_7, out IntPtr DF950611, IntPtr intptr_2, int int_2, byte[] byte_1, int int_3, uint uint_4);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptDestroyKey(IntPtr intptr_0);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptEncrypt(IntPtr intptr_0, byte[] byte_1, int int_2, ref GStruct1 gstruct1_0, byte[] byte_2, int int_3, byte[] byte_3, int int_4, ref int int_5, uint uint_4);

	[DllImport("bcrypt.dll")]
	internal static extern uint BCryptDecrypt(IntPtr intptr_0, byte[] byte_1, int int_2, ref GStruct1 gstruct1_0, byte[] byte_2, int int_3, byte[] byte_3, int E699A6DF, ref int int_4, int D45CA301);
}
