using System;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Principal;
using System.Text;
using Microsoft.Win32.SafeHandles;

internal static class Class17
{
	[Flags]
	internal enum Enum3 : uint
	{
		GenericRead = 0x80000000u,
		GenericWrite = 0x40000000u,
		GenericExecute = 0x20000000u,
		GenericAll = 0x10000000u
	}

	[Serializable]
	internal struct Struct5
	{
		internal FileAttributes fileAttributes;

		internal uint ftCreationTimeLow;

		internal uint ftCreationTimeHigh;

		internal uint ftLastAccessTimeLow;

		internal uint ftLastAccessTimeHigh;

		internal uint ftLastWriteTimeLow;

		internal uint ftLastWriteTimeHigh;

		internal int fileSizeHigh;

		internal int fileSizeLow;

		public void method_0(Struct6 struct6_0)
		{
			while (true)
			{
				int num = 747313102;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3277FDB3u) % 5u)
					{
					case 4u:
						ftLastWriteTimeHigh = (uint)struct6_0.filetime_2.dwHighDateTime;
						num = (int)((num2 * 1717493002) ^ 0xC0464D8);
						continue;
					case 2u:
						ftLastAccessTimeHigh = (uint)struct6_0.filetime_1.dwHighDateTime;
						ftLastWriteTimeLow = (uint)struct6_0.filetime_2.dwLowDateTime;
						num = ((int)num2 * -530044087) ^ -1455532370;
						continue;
					case 1u:
						fileAttributes = struct6_0.fileAttributes_0;
						ftCreationTimeLow = (uint)struct6_0.filetime_0.dwLowDateTime;
						ftCreationTimeHigh = (uint)struct6_0.filetime_0.dwHighDateTime;
						ftLastAccessTimeLow = (uint)struct6_0.filetime_1.dwLowDateTime;
						num = (int)(num2 * 1448867695) ^ -528262446;
						continue;
					case 0u:
						break;
					default:
						fileSizeHigh = struct6_0.int_0;
						fileSizeLow = struct6_0.int_1;
						return;
					}
					break;
				}
			}
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct Struct6
	{
		internal FileAttributes fileAttributes_0;

		internal FILETIME filetime_0;

		internal FILETIME filetime_1;

		internal FILETIME filetime_2;

		internal int int_0;

		internal int int_1;

		internal int int_2;

		internal int int_3;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		internal string string_0;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
		internal string string_1;
	}

	internal struct Struct7
	{
		internal uint uint_0;

		internal uint uint_1;

		public Struct7(long long_0)
		{
			uint_0 = (uint)long_0;
			uint_1 = (uint)(long_0 >> 32);
		}

		public long method_0()
		{
			long result = default(long);
			while (true)
			{
				int num = -794664482;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFD6AA3C6u) % 3u)
					{
					case 1u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0003:
					result = (long)(((ulong)uint_1 << 32) + uint_0);
					num = (int)((num2 * 2077539229) ^ 0x1D2A812F);
				}
			}
		}
	}

	internal enum Enum4
	{
		Anonymous,
		Identification,
		Impersonation,
		Delegation
	}

	internal enum Enum5
	{
		Primary = 1,
		Impersonation
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct Struct8
	{
		internal uint uint_0;

		internal uint uint_1;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct Struct9
	{
		internal Struct8 struct8_0;

		internal uint uint_0;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct Struct10
	{
		internal uint uint_0;

		internal Struct9 struct9_0;
	}

	internal const int int_0 = 0;

	internal const int int_1 = 2;

	internal const int int_2 = 3;

	internal const int int_3 = 5;

	internal const int int_4 = 6;

	internal const int int_5 = 8;

	internal const int int_6 = 15;

	internal const int int_7 = 18;

	internal const int int_8 = 21;

	internal const int int_9 = 32;

	internal const int int_10 = 80;

	internal const int int_11 = 87;

	internal const int int_12 = 123;

	internal const int int_13 = 161;

	internal const int int_14 = 183;

	internal const int int_15 = 206;

	internal const int int_16 = 267;

	internal const int int_17 = 995;

	internal const int int_18 = 1008;

	internal const int int_19 = 1300;

	internal const int int_20 = 1307;

	internal const int int_21 = 1308;

	internal const int int_22 = 1313;

	internal const int int_23 = 1314;

	internal const int int_24 = 1347;

	internal const int int_25 = 1350;

	internal const int int_26 = -1;

	internal const int int_27 = 16;

	internal const int int_28 = 256;

	internal const int int_29 = 33554432;

	internal const int int_30 = 1;

	internal const int int_31 = 2;

	internal const int int_32 = 260;

	internal const int int_33 = 32000;

	internal const int int_34 = 14;

	public const int int_35 = 512;

	public const int int_36 = 4096;

	public const int int_37 = 8192;

	private static readonly Version version_0 = new Version(6, 1, 7600);

	internal const uint uint_0 = 0u;

	internal const uint uint_1 = 2u;

	internal static int smethod_0(int int_38)
	{
		int result = default(int);
		while (true)
		{
			int num = 1912738592;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7E0FB035u) % 4u)
				{
				case 2u:
					num = ((int)num2 * -1335865774) ^ -1236236023;
					continue;
				case 1u:
					result = -2147024896 | int_38;
					num = (int)((num2 * 618334730) ^ 0x75A70355);
					continue;
				case 3u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CopyFile(string string_0, string string_1, [MarshalAs(UnmanagedType.Bool)] bool bool_0);

	[DllImport("Kernel32.dll", BestFitMapping = false, CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern bool ReplaceFile(string string_0, string string_1, string string_2, int int_38, IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern Class19 FindFirstFile(string string_0, out Struct6 struct6_0);

	[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool FindNextFile(Class19 class19_0, out Struct6 struct6_0);

	[DllImport("Kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool FindClose(IntPtr intptr_0);

	[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern uint GetFullPathName(string string_0, uint uint_2, StringBuilder stringBuilder_0, IntPtr intptr_0);

	[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool DeleteFile(string string_0);

	[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool RemoveDirectory(string string_0);

	[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CreateDirectory(string string_0, IntPtr intptr_0);

	[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool MoveFile(string string_0, string string_1);

	[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern SafeFileHandle CreateFile(string string_0, Enum3 enum3_0, uint uint_2, IntPtr intptr_0, uint uint_3, uint uint_4, IntPtr intptr_1);

	[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern FileAttributes GetFileAttributes(string string_0);

	[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool SetFileAttributes(string string_0, [MarshalAs(UnmanagedType.U4)] FileAttributes fileAttributes_0);

	internal static long smethod_1(SafeFileHandle safeFileHandle_0, long long_0, SeekOrigin seekOrigin_0)
	{
		int int_ = (int)(long_0 >> 32);
		int num = SetFilePointer(safeFileHandle_0, (int)long_0, ref int_, (int)seekOrigin_0);
		long result = default(long);
		bool flag = default(bool);
		while (true)
		{
			int num2 = 364234705;
			while (true)
			{
				uint num3;
				int num4;
				switch ((num3 = (uint)num2 ^ 0x8B41D3Eu) % 7u)
				{
				case 6u:
					result = (long)(((ulong)(uint)int_ << 32) | (uint)num);
					num2 = 1050589532;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = -425997493;
						num6 = -425997493;
					}
					else
					{
						num5 = -785628022;
						num6 = -785628022;
					}
					num2 = num5 ^ (int)(num3 * 962997511);
					continue;
				}
				case 2u:
					num4 = ((Marshal.GetLastWin32Error() != 0) ? 1 : 0);
					goto IL_0054;
				case 1u:
					if (num == -1)
					{
						num2 = (int)(num3 * 404094373) ^ -1554059921;
						continue;
					}
					num4 = 0;
					goto IL_0054;
				case 0u:
					result = -1L;
					num2 = ((int)num3 * -870456942) ^ 0x3EEE5E14;
					continue;
				case 5u:
					break;
				default:
					{
						return result;
					}
					IL_0054:
					flag = (byte)num4 != 0;
					num2 = 2058066030;
					continue;
				}
				break;
			}
		}
	}

	[DllImport("Kernel32.dll", SetLastError = true)]
	internal static extern int SetFilePointer(SafeFileHandle safeFileHandle_0, int int_38, ref int int_39, int int_40);

	[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern int FormatMessage(int int_38, IntPtr intptr_0, int int_39, int int_40, StringBuilder stringBuilder_0, int int_41, IntPtr intptr_1);

	[DllImport("advapi32.dll", BestFitMapping = false, CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern bool DecryptFile(string string_0, int int_38);

	[DllImport("advapi32.dll", BestFitMapping = false, CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern bool EncryptFile(string string_0);

	public static string smethod_2(int int_38)
	{
		StringBuilder stringBuilder = new StringBuilder(512);
		string result = default(string);
		int num3 = default(int);
		while (true)
		{
			int num = -1151990824;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC5656E68u) % 9u)
				{
				case 8u:
					result = $"Unknown error: {int_38}";
					num = (int)(num2 * 1402656633) ^ -387676474;
					continue;
				case 6u:
					num3 = FormatMessage(12800, IntPtr.Zero, int_38, 0, stringBuilder, stringBuilder.Capacity, IntPtr.Zero);
					num = ((int)num2 * -906419913) ^ 0x6D42E9CC;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (num3 == 0)
					{
						num4 = -1944306201;
						num5 = -1944306201;
					}
					else
					{
						num4 = -622916126;
						num5 = -622916126;
					}
					num = num4 ^ ((int)num2 * -1552573696);
					continue;
				}
				case 4u:
					num = (int)((num2 * 1176519869) ^ 0x1B227B28);
					continue;
				case 3u:
					num = -469709758;
					continue;
				case 1u:
					result = stringBuilder.ToString();
					num = ((int)num2 * -1273151790) ^ -1099892207;
					continue;
				case 0u:
					num = ((int)num2 * -1555297249) ^ 0x574501DF;
					continue;
				case 7u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	[DllImport("Kernel32.dll", SetLastError = true)]
	internal unsafe static extern bool SetFileTime(SafeFileHandle safeFileHandle_0, Struct7* pStruct7_0, Struct7* pStruct7_1, Struct7* pStruct7_2);

	[DllImport("Kernel32.dll", BestFitMapping = false, CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern bool GetFileAttributesEx(string string_0, int int_38, ref Struct5 struct5_0);

	[DllImport("Kernel32.dll", ExactSpelling = true)]
	private static extern int SetErrorMode(int int_38);

	[DllImport("Kernel32.dll", SetLastError = true)]
	private static extern bool SetThreadErrorMode(int int_38, out int int_39);

	internal static int smethod_3(int int_38)
	{
		int result = default(int);
		int int_39 = default(int);
		while (true)
		{
			int num = 1218226801;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x69EE005Eu) % 7u)
				{
				case 6u:
					result = SetErrorMode(int_38);
					num = (int)((num2 * 74094182) ^ 0x368052FD);
					continue;
				case 5u:
					result = int_39;
					num = (int)((num2 * 1608878761) ^ 0x6F56387B);
					continue;
				case 3u:
					num = ((int)num2 * -1914182405) ^ -1877572210;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (Environment.OSVersion.Version < version_0)
					{
						num3 = -735107577;
						num4 = -735107577;
					}
					else
					{
						num3 = -769874018;
						num4 = -769874018;
					}
					num = num3 ^ ((int)num2 * -1153598873);
					continue;
				}
				case 0u:
					SetThreadErrorMode(int_38, out int_39);
					num = 1183635346;
					continue;
				case 2u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	internal static extern uint GetNamedSecurityInfoW(string string_0, uint uint_2, uint uint_3, out IntPtr intptr_0, out IntPtr intptr_1, out IntPtr intptr_2, out IntPtr intptr_3, out IntPtr intptr_4);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	internal static extern uint SetNamedSecurityInfoW(string string_0, uint uint_2, uint uint_3, byte[] byte_0, byte[] byte_1, byte[] byte_2, byte[] byte_3);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	internal static extern uint SetSecurityInfo(SafeHandle safeHandle_0, uint uint_2, uint uint_3, byte[] byte_0, byte[] byte_1, byte[] byte_2, byte[] byte_3);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	internal static extern uint GetSecurityDescriptorLength(IntPtr intptr_0);

	[DllImport("Kernel32.dll", SetLastError = true)]
	internal static extern IntPtr LocalFree(IntPtr intptr_0);

	[DllImport("Kernel32.dll", BestFitMapping = false, CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern bool SetCurrentDirectory(string string_0);

	[DllImport("Kernel32.dll", SetLastError = true)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal static extern bool CloseHandle(IntPtr intptr_0);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal static extern bool AdjustTokenPrivileges([In] Class20 class20_0, [In] bool bool_0, [In] ref Struct10 struct10_0, [In] uint uint_2, [In][Out] ref Struct10 struct10_1, [In][Out] ref uint uint_3);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal static extern bool RevertToSelf();

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal static extern bool LookupPrivilegeValueW([In] string string_0, [In] string string_1, [In][Out] ref Struct8 struct8_0);

	[DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal static extern IntPtr GetCurrentProcess();

	[DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal static extern IntPtr GetCurrentThread();

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal static extern bool OpenProcessToken([In] IntPtr intptr_0, [In] TokenAccessLevels tokenAccessLevels_0, [In][Out] ref Class20 class20_0);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal static extern bool OpenThreadToken([In] IntPtr intptr_0, [In] TokenAccessLevels tokenAccessLevels_0, [In] bool bool_0, [In][Out] ref Class20 class20_0);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal static extern bool DuplicateTokenEx([In] Class20 class20_0, [In] TokenAccessLevels tokenAccessLevels_0, [In] IntPtr intptr_0, [In] Enum4 enum4_0, [In] Enum5 enum5_0, [In][Out] ref Class20 class20_1);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal static extern bool SetThreadToken([In] IntPtr intptr_0, [In] Class20 class20_0);
}
