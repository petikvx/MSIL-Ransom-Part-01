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
using System.Runtime.CompilerServices;
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

	private unsafe static void smethod_1()
	{
		//Discarded unreachable code: IL_0037
		//IL_0003: Invalid comparison between Unknown and F8
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		while (true)
		{
			double num = ((double[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/];
			if ((double)/*Error near IL_0008: Stack underflow*/ <= num)
			{
				continue;
			}
			long num2 = checked((long)/*Error near IL_0008: ldarg 0 (out-of-bounds)*/);
			((short[])/*Error near IL_000d: Stack underflow*/)[/*Error near IL_000d: Stack underflow*/] = (short)(ushort)num2;
			if ((int)/*Error near IL_0014: Stack underflow*/ != 0)
			{
				continue;
			}
			double num3 = *(double*)7;
			if ((nint)((IntPtr[])/*Error near IL_0017: Stack underflow*/)[num3] < checked((int)/*Error near IL_0017: ldloc 2 (out-of-bounds)*/) && /*Error near IL_0023: Stack underflow*/> /*Error near IL_0023: Stack underflow*/)
			{
				/*Error near IL_0023: stloc 0 (out-of-bounds)*/;
				if (/*Error near IL_002a: Stack underflow*/ < /*Error near IL_002a: Stack underflow*/)
				{
					break;
				}
			}
		}
		_ = /*Error near IL_002a: ldarg 3 (out-of-bounds)*// (ushort)8;
		/*Error near IL_0032: Invalid metadata token*/;
	}

	private static bool smethod_2()
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0011, IL_001e, IL_001f, IL_0024, IL_002b
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected I8, but got I4
		/*Error near IL_0001: Invalid metadata token*/;
	}

	private static extern bool smethod_3();

	private static bool smethod_4()
	{
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		while ((int)/*Error near IL_0007: Stack underflow*/ < 1)
		{
		}
		_ = /*Error near IL_0008: Stack underflow*// /*Error near IL_0008: Stack underflow*/;
		/*Error: Unexpected end of block*/;
	}

	private static extern string smethod_5();

	private static void smethod_6()
	{
		//Discarded unreachable code: IL_001a, IL_0020
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			/*Error: stloc 2 (out-of-bounds)*/;
			_003F val = /*Error near IL_0001: ldloc 0 (out-of-bounds)*/;
			if (/*Error near IL_0009: Stack underflow*/ < val)
			{
				_003F val2 = /*Error near IL_000a: Stack underflow*/| /*Error near IL_000a: Stack underflow*/;
				_003F val3 = /*Error near IL_000d: Stack underflow*/| val2;
				/*OpCode not supported: DebugBreak*/;
				if (/*Error near IL_0015: Stack underflow*/ <= val3)
				{
					break;
				}
			}
		}
		/*Error near IL_0015: Invalid metadata token*/;
	}

	private static extern void smethod_7(object sender, FileSystemEventArgs e);

	private static void smethod_8()
	{
		//Discarded unreachable code: IL_0005, IL_000b, IL_0013, IL_0025, IL_002e, IL_0033
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected F4, but got Unknown
		/*Error: Invalid metadata token*/;
	}

	private static extern void smethod_9();

	public unsafe static bool smethod_10(string string_4)
	{
		//Discarded unreachable code: IL_0015, IL_001c, IL_0025, IL_002a, IL_0030, IL_0035
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_000c: Expected I4, but got F8
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		int num;
		do
		{
			num = *(int*)((sbyte[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		}
		while ((int)/*Error near IL_0007: Stack underflow*/ < num);
		/*Error near IL_0008: stloc 0 (out-of-bounds)*/;
		double num2 = *(double*)(nint)/*Error near IL_000b: Stack underflow*/;
		*(short*)(nint)/*Error near IL_000c: Stack underflow*/ = (short)(int)num2;
		_ = (ref *(_003F*)/*Error near IL_0010: Stack underflow*/) - (ref *(_003F*)(&string_4));
		/*Error near IL_0010: Invalid metadata token*/;
	}

	public extern Class5();

	static extern byte[] smethod_11(string string_4);

	static RijndaelManaged smethod_12()
	{
		//Discarded unreachable code: IL_0002, IL_0007, IL_000d
		/*Error near IL_0001: Unknown opcode: 0xFA*/;
	}

	static extern void smethod_13(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern void smethod_14(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern Encoding smethod_15();

	static extern byte[] smethod_16(Encoding encoding_0, string string_4);

	static void smethod_17(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_0009
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected I4, but got Unknown
		//IL_0004: Incompatible stack heights: 0 vs 1
		while (true)
		{
			_003F val = /*Error near IL_0002: Stack underflow*/% 3;
			((short[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (short)(int)val;
			_ = ((float[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/];
		}
	}

	unsafe static void smethod_18(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_000a, IL_0014, IL_0015
		//IL_0002: Expected I8, but got I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			*(long*)(nint)/*Error near IL_0002: Stack underflow*/ = 4L;
		}
	}

	static extern void smethod_19(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	static extern void smethod_20(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	unsafe static byte[] smethod_21(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		//Discarded unreachable code: IL_0013, IL_001c
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_0017: Invalid comparison between Unknown and I4
		float num;
		do
		{
			num = *(float*)(nint)/*Error near IL_0002: Stack underflow*/;
		}
		while ((int)/*Error near IL_0009: Stack underflow*/ > (int)(sbyte)num);
		/*Error near IL_000e: Invalid metadata token*/;
	}

	static byte[] smethod_22(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		while (true)
		{
		}
	}

	static extern ICryptoTransform smethod_23(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static extern byte[] smethod_24(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static extern Encoding smethod_25();

	static extern string smethod_26(Encoding encoding_0, byte[] byte_0);

	unsafe static void smethod_27(IDisposable idisposable_0)
	{
		//Discarded unreachable code: IL_000d
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		ushort num;
		do
		{
			_003F val = checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
			num = *(ushort*)(int)checked((byte)unchecked((uint)((short[])/*Error near IL_0005: Stack underflow*/)[val]));
		}
		while ((int)/*Error near IL_000c: Stack underflow*/ <= (int)num);
		/*Error near IL_000c: Unknown opcode: 0xFB*/;
	}

	static extern string smethod_28(string string_4);

	static extern Assembly smethod_29();

	static string smethod_30(Assembly assembly_0)
	{
		//Discarded unreachable code: IL_0015, IL_001b, IL_0021
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I
		_ = /*Error near IL_0003: Stack underflow*/<< (int)/*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0003: ldarg 2 (out-of-bounds)*/;
		_ = (ulong)checked((long)(object)assembly_0) % 18446744071935474449uL;
		_ = 3;
		/*Error near IL_0010: Invalid metadata token*/;
	}

	static extern string smethod_31(string string_4, string string_5);

	static extern void smethod_32(string string_4, string string_5, bool bool_5);

	static extern RegistryKey smethod_33(RegistryKey registryKey_0, string string_4, bool bool_5);

	static void smethod_34(RegistryKey registryKey_0, string string_4, object object_0)
	{
		switch (4)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static extern void smethod_35(string string_4, FileAttributes fileAttributes_0);

	unsafe static RegistryKey smethod_36(RegistryKey registryKey_0, string string_4)
	{
		//Discarded unreachable code: IL_0006, IL_0010, IL_001b, IL_0022, IL_0028, IL_0029, IL_0035, IL_003c
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and F4
		//IL_001d: Expected I4, but got O
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_0031: Expected O, but got I4
		//IL_0037: Expected F8, but got I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected I8, but got Unknown
		_ = *(IntPtr*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern void smethod_37(RegistryKey registryKey_0);

	static extern Rectangle smethod_38(Point point_0);

	unsafe static Bitmap smethod_39(int int_0, int int_1)
	{
		//Discarded unreachable code: IL_0009
		//IL_0005: Expected O, but got F4
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		_ = (float)(*(int*)(short)/*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0004: Invalid metadata token*/;
	}

	static extern Graphics smethod_40(Image image_0);

	static extern void smethod_41(Graphics graphics_0, Point point_0, Point point_1, Size size_0);

	static extern ImageFormat smethod_42();

	static void smethod_43(Image image_0, string string_4, ImageFormat imageFormat_0)
	{
		/*Error: ldloc 2 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static extern WebClient smethod_44();

	static extern bool smethod_45(string string_4);

	static void smethod_46(string string_4)
	{
		//Discarded unreachable code: IL_0001, IL_0009, IL_0011, IL_001a, IL_0021
		//IL_000c: Incompatible stack heights: 0 vs 1
		//IL_001c: Invalid comparison between Unknown and I
		/*Error: Unknown opcode: 0xF8*/;
	}

	static extern void smethod_47(WebClient webClient_0, string string_4, string string_5);

	static extern Process smethod_48();

	static extern ProcessStartInfo smethod_49();

	static void smethod_50(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0)
	{
		//Discarded unreachable code: IL_000c
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_ = ((short[])(/*Error near IL_0002: Stack underflow*/ >> 2))[/*Error near IL_0004: ldloca 0 (out-of-bounds)*/];
		/*Error near IL_0007: Invalid metadata token*/;
	}

	static extern void smethod_51(ProcessStartInfo processStartInfo_0, string string_4);

	static void smethod_52(Process process_0, ProcessStartInfo processStartInfo_0)
	{
		while ((int)/*Error near IL_0006: Stack underflow*/ != 0)
		{
		}
		_ = ((byte[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/];
		/*Error: Unexpected end of block*/;
	}

	static bool smethod_53(Process process_0)
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0022, IL_0027, IL_0028
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		((float[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (float)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern void smethod_54(Process process_0);

	static extern string smethod_55(string string_4);

	static extern string[] smethod_56(string string_4, char[] char_0);

	static extern string smethod_57(WebClient webClient_0, string string_4);

	static string smethod_58()
	{
		//Discarded unreachable code: IL_0021, IL_0027
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected F4, but got Unknown
		//IL_0019: Incompatible stack heights: 0 vs 1
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		while (true)
		{
			_003F val = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
			if (/*Error near IL_0004: Stack underflow*/ < val)
			{
				break;
			}
			_003F val2 = checked(/*Error near IL_0005: Stack underflow*/ * /*Error near IL_0005: Stack underflow*/);
			((float[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/] = (float)val2;
			_003F val3 = /*Error near IL_0006: Stack underflow*/;
			if (/*Error near IL_000c: Stack underflow*/ >= val3)
			{
				nuint num = checked((nuint)/*Error near IL_0010: Stack underflow*/);
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)/*Error near IL_0014: Stack underflow*/, (nint)/*Error near IL_0014: Stack underflow*/, num >> (int)null);
				if ((int)/*Error near IL_0019: Stack underflow*/ != 0)
				{
					/*Error near IL_0019: ldloc 0 (out-of-bounds)*/;
					break;
				}
			}
		}
		_ = (ulong)checked(/*Error near IL_001b: Stack underflow*/ - /*Error near IL_001b: Stack underflow*/);
		/*Error near IL_001c: Invalid metadata token*/;
	}

	static extern string smethod_59(string[] string_4);

	static extern void smethod_60(int int_0);

	static extern Process[] smethod_61();

	static extern string smethod_62(Process process_0);

	static extern void smethod_63(Process process_0);

	static extern Process smethod_64();

	static extern IntPtr smethod_65(Process process_0);

	static extern ManagementObjectSearcher smethod_66(string string_4);

	static ManagementObjectCollection smethod_67(ManagementObjectSearcher managementObjectSearcher_0)
	{
		//Discarded unreachable code: IL_0015, IL_0021, IL_0022
		//IL_0005: Invalid comparison between Unknown and F4
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected I8, but got I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unsupported input type for neg.
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		while ((float)/*Error near IL_000a: Stack underflow*/ >= 708.77f)
		{
		}
		checked
		{
			uint num = (uint)(long)/*Error near IL_000b: Stack underflow*/;
			_ = /*Error near IL_000e: Stack underflow*/* num;
			/*Error near IL_000f: stloc 3 (out-of-bounds)*/;
			/*Error near IL_0010: Invalid metadata token*/;
		}
	}

	static extern ManagementObjectEnumerator smethod_68(ManagementObjectCollection managementObjectCollection_0);

	static ManagementBaseObject smethod_69(ManagementObjectEnumerator managementObjectEnumerator_0)
	{
		//Discarded unreachable code: IL_0014, IL_001a
		checked
		{
			_ = (sbyte)unchecked((uint)/*Error near IL_0002: Stack underflow*/);
			_ = 47157;
			_ = 1.5480584E-18f;
			/*Error near IL_000f: Invalid metadata token*/;
		}
	}

	static extern object smethod_70(ManagementBaseObject managementBaseObject_0, string string_4);

	static extern string smethod_71(object object_0);

	static extern string smethod_72(string string_4);

	static extern bool smethod_73(string string_4, string string_5);

	static extern string smethod_74(string string_4);

	unsafe static bool smethod_75(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_000b
		_ = *(uint*)checked((nint)/*Error near IL_0002: Stack underflow*/);
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static extern bool smethod_76(ManagementObjectEnumerator managementObjectEnumerator_0);

	static NetworkInterface[] smethod_77()
	{
		//Discarded unreachable code: IL_0006
		//IL_0001: Incompatible stack heights: 0 vs 1
		while (true)
		{
			/*Error: Stack underflow*/;
		}
	}

	static extern OperationalStatus smethod_78(NetworkInterface networkInterface_0);

	static extern PhysicalAddress smethod_79(NetworkInterface networkInterface_0);

	static extern string smethod_80(string string_4, string string_5, string string_6);

	static extern string smethod_81(string string_4, char[] char_0);

	unsafe static FileSystemWatcher smethod_82()
	{
		//Discarded unreachable code: IL_000e, IL_001b
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected I, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			_003F val = checked(/*Error near IL_0002: Stack underflow*/ + /*Error near IL_0002: Stack underflow*/);
			*(IntPtr*)(nint)/*Error near IL_0003: Stack underflow*/ = (IntPtr)val;
		}
		while ((nint)checked((nuint)/*Error near IL_0004: Stack underflow*/) > (nint)8);
		_ = (int)/*Error near IL_000d: Stack underflow*/;
		/*Error near IL_000d: Unknown opcode: 0xF8*/;
	}

	static extern string smethod_83(Environment.SpecialFolder specialFolder_0);

	static extern void smethod_84(FileSystemWatcher fileSystemWatcher_1, string string_4);

	unsafe static void smethod_85(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0)
	{
		//Discarded unreachable code: IL_0011, IL_0015, IL_001a
		short num = *(byte*)(nint)/*Error near IL_0003: Stack underflow*/;
		_ = ((short[])/*Error near IL_0006: Stack underflow*/)[num];
		sbyte num2 = *(sbyte*)7;
		*(int*)num2 = num2;
		/*Error near IL_000c: Invalid metadata token*/;
	}

	static extern void smethod_86(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static extern void smethod_87(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0);

	unsafe static void smethod_88(FileSystemWatcher fileSystemWatcher_1, bool bool_5)
	{
		//Discarded unreachable code: IL_000f
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected I4, but got I8
		//IL_0009: Expected native int or pointer, but got O
		//IL_000a: Expected native int or pointer, but got F4
		//IL_000d: Expected native int or pointer, but got F8
		_003F val = /*Error near IL_0001: Stack underflow*/& /*Error near IL_0001: Stack underflow*/;
		_ = /*Error near IL_0002: Stack underflow*// val;
		/*Error near IL_0002: stloc 0 (out-of-bounds)*/;
		long num = checked((long)(float)(sbyte)/*Error near IL_0004: Stack underflow*/);
		((short[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (short)num;
		_ = *(int*)(nint)(*(float*)unchecked((nint)null));
		/*Error near IL_000b: stloc 0 (out-of-bounds)*/;
		_ = *(uint*)(nint)(double)/*Error near IL_000d: Stack underflow*/;
		/*Error near IL_000e: Unknown opcode: 0xFB*/;
	}

	static extern bool smethod_89(string string_4, string string_5);

	static extern bool smethod_90(string string_4);

	static extern string[] smethod_91(string string_4, string string_5);

	static extern Match smethod_92(string string_4, string string_5);

	static WebHeaderCollection smethod_93(WebClient webClient_0)
	{
		//Discarded unreachable code: IL_000b, IL_0011, IL_002f
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		((int[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (int)/*Error near IL_0001: Stack underflow*/;
		_ = (nuint)/*Error near IL_0002: Stack underflow*/;
		_ = 0;
		_ = 6;
		_ = 2;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static extern void smethod_94(WebHeaderCollection webHeaderCollection_0, HttpRequestHeader httpRequestHeader_0, string string_4);
}
