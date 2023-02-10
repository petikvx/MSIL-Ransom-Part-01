using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bbZLupGLqlws;

internal sealed class gIXFdNsbZyee
{
	public struct wKoGDQPibouV
	{
		public uint HfBqsQSlqqaN;

		public uint xwnaKBPkgDXd;

		public uint MKRisLGJeXXhvG;

		public uint GmhClJVmjVcnFO;

		public uint tEQmifVYYZa;

		public IntPtr LyYtKsYCqueqog;

		public uint GBfRQdBtcHEJ;

		public IntPtr zkGLARhRqyy;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string CDngbqWHiuzb;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string dWAKCKXmuzn;
	}

	private static byte[] KIwBWlNJjUyg;

	private static byte[] BzUjuwwrzekbn;

	private static byte[] EwyBaqhXsrEML;

	[NonSerialized]
	internal static GetString _009F;

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "CloseHandle", ExactSpelling = true, SetLastError = true)]
	private static extern bool QVVNOrcmbaT(IntPtr P_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "OpenProcess", ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr eFQExAceJYQoTL(int P_0, bool P_1, uint P_2);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "ReadProcessMemory", ExactSpelling = true, SetLastError = true)]
	private static extern bool gMsUhbvffJOgN(IntPtr hDcZDcnxZpO, IntPtr OGOumuYaeqblu, [Out] byte[] cGfuNoMJJunW, uint IOaAJEcrmcl, ref uint UWqDcZHfpHXan);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "WriteProcessMemory", ExactSpelling = true, SetLastError = true)]
	private static extern bool NunTZvCNtdqn(IntPtr P_0, IntPtr P_1, byte[] P_2, uint P_3, ref uint P_4);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "VirtualProtectEx", ExactSpelling = true, SetLastError = true)]
	private static extern bool pBhMVARtRLurnjo(IntPtr P_0, IntPtr P_1, uint P_2, uint P_3, ref uint P_4);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "Module32Next", ExactSpelling = true, SetLastError = true)]
	private static extern bool MWGpHjAHTfXaC(IntPtr P_0, ref wKoGDQPibouV P_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "Module32First", ExactSpelling = true, SetLastError = true)]
	private static extern bool VSxIpxyMLoVQS(IntPtr P_0, ref wKoGDQPibouV P_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "CreateToolhelp32Snapshot", ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr DcAouaRFZtN(uint P_0, uint P_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "VirtualAllocEx", ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr YffkYUAhBEiroXCO(IntPtr P_0, IntPtr P_1, uint P_2, uint P_3, uint P_4);

	private static byte[] bRqAxCZzvxHkMOi(IntPtr P_0, IntPtr P_1, uint P_2)
	{
		checked
		{
			byte[] array = new byte[(int)(unchecked((ulong)P_2) - 1uL) + 1];
			byte[] cGfuNoMJJunW = array;
			uint UWqDcZHfpHXan = 0u;
			gMsUhbvffJOgN(P_0, P_1, cGfuNoMJJunW, P_2, ref UWqDcZHfpHXan);
			return array;
		}
	}

	private static uint nNRPVJvRfA(IntPtr P_0, uint P_1, string P_2)
	{
		checked
		{
			uint num = BitConverter.ToUInt32(bRqAxCZzvxHkMOi(P_0, (IntPtr)(long)(unchecked((ulong)P_1) + 60uL), 4u), 0);
			uint num2 = BitConverter.ToUInt32(bRqAxCZzvxHkMOi(P_0, (IntPtr)(long)(unchecked((ulong)checked(P_1 + num)) + 120uL), 4u), 0);
			byte[] value = bRqAxCZzvxHkMOi(P_0, (IntPtr)(P_1 + num2), 40u);
			int num3 = BitConverter.ToInt32(value, 24);
			uint num4 = BitConverter.ToUInt32(value, 32) + P_1;
			uint num5 = BitConverter.ToUInt32(value, 28) + P_1;
			uint num6 = BitConverter.ToUInt32(value, 36) + P_1;
			IntPtr intPtr = Marshal.AllocHGlobal(64);
			int num7 = 1;
			int num8 = num3;
			int num9 = num7;
			while (true)
			{
				int num10 = num9;
				int num11 = num8;
				if (num10 > num11)
				{
					break;
				}
				uint num12 = BitConverter.ToUInt32(bRqAxCZzvxHkMOi(P_0, (IntPtr)(long)(num4 + (ulong)((num9 - 1) * 4)), 4u), 0);
				Marshal.Copy(bRqAxCZzvxHkMOi(P_0, (IntPtr)(P_1 + num12), 64u), 0, intPtr, 64);
				string strA = Marshal.PtrToStringAnsi(intPtr);
				uint num13 = (uint)BitConverter.ToInt16(bRqAxCZzvxHkMOi(P_0, (IntPtr)(long)(num6 + (ulong)((num9 - 1) * 2)), 2u), 0);
				uint result = BitConverter.ToUInt32(bRqAxCZzvxHkMOi(P_0, (IntPtr)(long)(num5 + unchecked((ulong)num13) * 4uL), 4u), 0) + P_1;
				if (string.Compare(strA, P_2, ignoreCase: true) != 0)
				{
					num9++;
					continue;
				}
				Marshal.FreeHGlobal(intPtr);
				return result;
			}
			Marshal.FreeHGlobal(intPtr);
			return 0u;
		}
	}

	private static IntPtr dozQfYArbdUxv(string P_0, string P_1)
	{
		checked
		{
			IntPtr intPtr = DcAouaRFZtN(24u, (uint)Process.GetProcessesByName(P_0)[0].Id);
			IntPtr zero = IntPtr.Zero;
			if (intPtr == zero)
			{
				return zero;
			}
			wKoGDQPibouV structure = default(wKoGDQPibouV);
			structure.HfBqsQSlqqaN = (uint)Marshal.SizeOf(structure);
			if (VSxIpxyMLoVQS(intPtr, ref structure))
			{
				do
				{
					if (structure.LyYtKsYCqueqog.ToInt64() <= int.MaxValue && string.Compare(P_1, structure.CDngbqWHiuzb, ignoreCase: true) == 0)
					{
						return structure.LyYtKsYCqueqog;
					}
				}
				while (MWGpHjAHTfXaC(intPtr, ref structure));
			}
			return zero;
		}
	}

	private static int fFVEcoMnJRII(int P_0, int P_1)
	{
		return checked(P_0 - P_1 - 5);
	}

	public static void mJudWhgTJOJ(string P_0)
	{
		byte[] array = new byte[97];
		uint[] array2 = new uint[4];
		byte[][] array3 = new byte[4][];
		uint num = 0u;
		byte[] array4 = new byte[5] { 233, 0, 0, 0, 0 };
		byte[][] array5 = new byte[3][] { KIwBWlNJjUyg, BzUjuwwrzekbn, EwyBaqhXsrEML };
		checked
		{
			uint num2 = (uint)(array5[0].Length + array5[1].Length + array5[2].Length);
			IntPtr intPtr = eFQExAceJYQoTL(56, false, (uint)Process.GetProcessesByName(P_0)[0].Id);
			IntPtr zero = IntPtr.Zero;
			uint num3 = (uint)(int)YffkYUAhBEiroXCO(intPtr, zero, (uint)(unchecked((ulong)num2) + 96uL), 12288u, 64u);
			uint value = (uint)(int)nNRPVJvRfA(intPtr, (uint)(int)dozQfYArbdUxv(P_0, _009F(107399837)), _009F(107399820));
			uint value2 = (uint)(int)nNRPVJvRfA(intPtr, (uint)(int)dozQfYArbdUxv(P_0, _009F(107399837)), _009F(107399771));
			array2[0] = (uint)(int)nNRPVJvRfA(intPtr, (uint)(int)dozQfYArbdUxv(P_0, _009F(107399774)), _009F(107399729));
			array2[1] = (uint)(int)nNRPVJvRfA(intPtr, (uint)(int)dozQfYArbdUxv(P_0, _009F(107399774)), _009F(107399700));
			array2[2] = (uint)(int)nNRPVJvRfA(intPtr, (uint)(int)dozQfYArbdUxv(P_0, _009F(107399774)), _009F(107399711));
			array3[0] = bRqAxCZzvxHkMOi(intPtr, (IntPtr)array2[0], 24u);
			array3[1] = bRqAxCZzvxHkMOi(intPtr, (IntPtr)array2[1], 24u);
			array3[2] = bRqAxCZzvxHkMOi(intPtr, (IntPtr)array2[2], 24u);
			BitConverter.GetBytes(value).CopyTo(array, 0);
			BitConverter.GetBytes(value2).CopyTo(array, 4);
			BitConverter.GetBytes(Process.GetCurrentProcess().Id).CopyTo(array, 8);
			BitConverter.GetBytes(array2[0]).CopyTo(array, 12);
			BitConverter.GetBytes(array2[1]).CopyTo(array, 16);
			BitConverter.GetBytes(array2[2]).CopyTo(array, 20);
			array3[0].CopyTo(array, 24);
			array3[1].CopyTo(array, 48);
			array3[2].CopyTo(array, 72);
			uint num4 = num3;
			IntPtr intPtr2 = intPtr;
			IntPtr intPtr3 = (IntPtr)num4;
			byte[] array6 = array;
			uint num5 = 96u;
			uint num6 = 0u;
			NunTZvCNtdqn(intPtr2, intPtr3, array6, num5, ref num6);
			num4 = (uint)(unchecked((ulong)num4) + 96uL);
			int num7 = 0;
			int num8 = array5.Length - 1;
			int num9 = num7;
			while (true)
			{
				int num10 = num9;
				int num11 = num8;
				if (num10 > num11)
				{
					break;
				}
				IntPtr intPtr4 = intPtr;
				IntPtr intPtr5 = (IntPtr)num4;
				byte[] array7 = array5[num9];
				uint num12 = (uint)array5[num9].Length;
				num6 = 0u;
				NunTZvCNtdqn(intPtr4, intPtr5, array7, num12, ref num6);
				num4 = (uint)(num4 + (ulong)array5[num9].Length);
				num9++;
			}
			IntPtr intPtr6 = intPtr;
			IntPtr intPtr7 = (IntPtr)num3;
			uint num13 = (uint)(unchecked((ulong)num2) + 96uL);
			uint num14 = 16u;
			num6 = 0u;
			pBhMVARtRLurnjo(intPtr6, intPtr7, num13, num14, ref num6);
			num4 = (uint)(unchecked((ulong)num3) + 96uL);
			BitConverter.GetBytes(fFVEcoMnJRII((int)num4, (int)array2[0])).CopyTo(array4, 1);
			pBhMVARtRLurnjo(intPtr, (IntPtr)array2[0], (uint)array4.Length, 64u, ref num);
			IntPtr intPtr8 = intPtr;
			IntPtr intPtr9 = (IntPtr)array2[0];
			byte[] array8 = array4;
			uint num15 = (uint)array4.Length;
			num6 = 0u;
			NunTZvCNtdqn(intPtr8, intPtr9, array8, num15, ref num6);
			IntPtr intPtr10 = intPtr;
			IntPtr intPtr11 = (IntPtr)array2[0];
			uint num16 = (uint)array4.Length;
			uint num17 = num;
			num6 = 0u;
			pBhMVARtRLurnjo(intPtr10, intPtr11, num16, num17, ref num6);
			num4 = (uint)(num4 + (ulong)array5[0].Length);
			BitConverter.GetBytes(fFVEcoMnJRII((int)num4, (int)array2[1])).CopyTo(array4, 1);
			pBhMVARtRLurnjo(intPtr, (IntPtr)array2[1], (uint)array4.Length, 64u, ref num);
			IntPtr intPtr12 = intPtr;
			IntPtr intPtr13 = (IntPtr)array2[1];
			byte[] array9 = array4;
			uint num18 = (uint)array4.Length;
			num6 = 0u;
			NunTZvCNtdqn(intPtr12, intPtr13, array9, num18, ref num6);
			IntPtr intPtr14 = intPtr;
			IntPtr intPtr15 = (IntPtr)array2[1];
			uint num19 = (uint)array4.Length;
			uint num20 = num;
			num6 = 0u;
			pBhMVARtRLurnjo(intPtr14, intPtr15, num19, num20, ref num6);
			num4 = (uint)(num4 + (ulong)array5[1].Length);
			BitConverter.GetBytes(fFVEcoMnJRII((int)num4, (int)array2[2])).CopyTo(array4, 1);
			pBhMVARtRLurnjo(intPtr, (IntPtr)array2[2], (uint)array4.Length, 64u, ref num);
			IntPtr intPtr16 = intPtr;
			IntPtr intPtr17 = (IntPtr)array2[2];
			byte[] array10 = array4;
			uint num21 = (uint)array4.Length;
			num6 = 0u;
			NunTZvCNtdqn(intPtr16, intPtr17, array10, num21, ref num6);
			IntPtr intPtr18 = intPtr;
			IntPtr intPtr19 = (IntPtr)array2[2];
			uint num22 = (uint)array4.Length;
			uint num23 = num;
			num6 = 0u;
			pBhMVARtRLurnjo(intPtr18, intPtr19, num22, num23, ref num6);
			QVVNOrcmbaT(intPtr);
		}
	}

	static gIXFdNsbZyee()
	{
		Strings.CreateGetStringDelegate(typeof(gIXFdNsbZyee));
		KIwBWlNJjUyg = new byte[240]
		{
			85, 139, 236, 131, 236, 20, 86, 199, 69, 248,
			1, 0, 0, 192, 232, 0, 0, 0, 0, 88,
			37, 0, 240, 255, 255, 137, 69, 252, 255, 117,
			24, 255, 117, 20, 255, 117, 16, 255, 117, 12,
			255, 117, 8, 139, 69, 252, 131, 192, 24, 255,
			208, 137, 69, 248, 131, 125, 248, 0, 15, 140,
			168, 0, 0, 0, 255, 117, 8, 139, 69, 252,
			255, 16, 139, 240, 139, 69, 252, 255, 80, 4,
			59, 240, 116, 10, 131, 125, 8, 255, 15, 133,
			138, 0, 0, 0, 131, 101, 244, 0, 235, 7,
			139, 69, 244, 64, 137, 69, 244, 131, 125, 244,
			3, 115, 119, 139, 69, 244, 139, 77, 252, 131,
			124, 129, 12, 0, 116, 101, 139, 69, 244, 139,
			77, 252, 139, 68, 129, 12, 59, 69, 12, 114,
			86, 139, 69, 12, 3, 69, 20, 139, 77, 244,
			139, 85, 252, 57, 68, 138, 12, 115, 68, 139,
			69, 244, 139, 77, 252, 139, 68, 129, 12, 43,
			69, 12, 137, 69, 240, 131, 101, 236, 0, 235,
			7, 139, 69, 236, 64, 137, 69, 236, 131, 125,
			236, 24, 115, 33, 139, 69, 244, 107, 192, 24,
			139, 77, 252, 141, 68, 1, 24, 139, 77, 236,
			3, 77, 240, 139, 85, 16, 139, 117, 236, 138,
			4, 48, 136, 4, 10, 235, 210, 233, 124, 255,
			255, 255, 139, 69, 248, 94, 201, 194, 20, 0
		};
		BzUjuwwrzekbn = new byte[84]
		{
			85, 139, 236, 81, 81, 199, 69, 248, 1, 0,
			0, 192, 232, 0, 0, 0, 0, 88, 37, 0,
			240, 255, 255, 137, 69, 252, 131, 125, 20, 0,
			116, 22, 139, 69, 20, 139, 77, 252, 139, 0,
			59, 65, 8, 117, 9, 199, 69, 248, 34, 0,
			0, 192, 235, 23, 255, 117, 20, 255, 117, 16,
			255, 117, 12, 255, 117, 8, 139, 69, 252, 131,
			192, 48, 255, 208, 137, 69, 248, 139, 69, 248,
			201, 194, 16, 0
		};
		EwyBaqhXsrEML = new byte[405]
		{
			85, 139, 236, 131, 236, 28, 86, 87, 199, 69,
			236, 1, 0, 0, 192, 232, 0, 0, 0, 0,
			88, 37, 0, 240, 255, 255, 137, 69, 240, 255,
			117, 20, 255, 117, 16, 255, 117, 12, 255, 117,
			8, 139, 69, 240, 131, 192, 72, 255, 208, 137,
			69, 236, 131, 125, 236, 0, 15, 140, 78, 1,
			0, 0, 131, 125, 8, 5, 117, 93, 131, 101,
			248, 0, 139, 69, 12, 137, 69, 244, 139, 69,
			244, 131, 56, 0, 116, 70, 139, 69, 244, 137,
			69, 248, 139, 69, 248, 139, 77, 248, 3, 8,
			137, 77, 244, 139, 69, 244, 139, 77, 240, 139,
			64, 68, 59, 65, 8, 117, 37, 139, 69, 244,
			131, 56, 0, 117, 8, 139, 69, 248, 131, 32,
			0, 235, 15, 139, 69, 248, 139, 0, 139, 77,
			244, 3, 1, 139, 77, 248, 137, 1, 139, 69,
			248, 137, 69, 244, 235, 178, 233, 235, 0, 0,
			0, 131, 125, 8, 16, 15, 133, 225, 0, 0,
			0, 139, 69, 12, 137, 69, 252, 131, 101, 232,
			0, 235, 7, 139, 69, 232, 64, 137, 69, 232,
			139, 69, 252, 139, 77, 232, 59, 8, 15, 131,
			192, 0, 0, 0, 139, 69, 232, 193, 224, 4,
			139, 77, 252, 139, 85, 240, 139, 68, 1, 4,
			59, 66, 8, 15, 133, 162, 0, 0, 0, 139,
			69, 232, 193, 224, 4, 139, 77, 252, 198, 68,
			1, 9, 0, 139, 69, 232, 193, 224, 4, 139,
			77, 252, 131, 100, 1, 16, 0, 139, 69, 232,
			193, 224, 4, 51, 201, 139, 85, 252, 102, 137,
			76, 2, 10, 139, 69, 232, 193, 224, 4, 139,
			77, 252, 131, 100, 1, 12, 0, 139, 69, 232,
			193, 224, 4, 139, 77, 252, 198, 68, 1, 8,
			0, 139, 69, 232, 193, 224, 4, 139, 77, 252,
			131, 100, 1, 4, 0, 139, 69, 232, 137, 69,
			228, 235, 7, 139, 69, 228, 64, 137, 69, 228,
			139, 69, 252, 139, 77, 228, 59, 8, 115, 33,
			139, 69, 228, 64, 193, 224, 4, 139, 77, 252,
			141, 116, 1, 4, 139, 69, 228, 193, 224, 4,
			139, 77, 252, 141, 124, 1, 4, 165, 165, 165,
			165, 235, 206, 139, 69, 252, 139, 0, 72, 139,
			77, 252, 137, 1, 139, 69, 232, 72, 137, 69,
			232, 233, 43, 255, 255, 255, 139, 69, 236, 95,
			94, 201, 194, 16, 0
		};
	}
}
