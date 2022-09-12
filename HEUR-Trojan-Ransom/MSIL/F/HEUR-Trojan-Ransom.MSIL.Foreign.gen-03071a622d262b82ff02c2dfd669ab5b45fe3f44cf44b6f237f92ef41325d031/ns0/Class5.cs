using System;
using System.Collections.Generic;
using System.ComponentModel;
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

	private static string smethod_0()
	{
		//Discarded unreachable code: IL_0006
		checked
		{
			_ = (ushort)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	public static extern string smethod_1(string string_4);

	private static extern void Main();

	private static extern void smethod_2();

	private static extern bool smethod_3();

	private static bool smethod_4()
	{
		//Discarded unreachable code: IL_0010, IL_0027
		//IL_0005: Expected I4, but got O
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected I4, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		_003F val = /*Error near IL_0002: Stack underflow*/;
		((short[])/*Error near IL_0005: Stack underflow*/)[val] = (short)(int)null;
		_ = 1.8090417E+33f;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private unsafe static bool smethod_5()
	{
		//Discarded unreachable code: IL_000d
		long num = *(nint*)(nint)/*Error near IL_0001: Stack underflow*/;
		float num2 = ((float[])/*Error near IL_0005: Stack underflow*/)[num - -1];
		((float[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/] = num2;
		/*Error near IL_0008: Invalid metadata token*/;
	}

	private static extern string smethod_6();

	private static extern void smethod_7();

	private static extern void smethod_8(object sender, FileSystemEventArgs e);

	private static extern void smethod_9();

	private static extern void smethod_10();

	public static extern bool smethod_11(string string_4);

	public extern Class5();

	static extern string smethod_12(string string_4);

	static extern WebClient smethod_13();

	static string smethod_14(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0007, IL_0012
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got I
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static void smethod_15(WebClient webClient_0, string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0010
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected native int or pointer, but got F4
		while (5 != 4)
		{
		}
		((short[])/*Error near IL_0009: Stack underflow*/)[/*Error near IL_0009: Stack underflow*/] = (short)/*Error near IL_0009: Stack underflow*/;
		checked
		{
			_ = (sbyte)unchecked((int)checked((byte)/*Error near IL_000a: Stack underflow*/));
			/*Error near IL_000b: Invalid metadata token*/;
		}
	}

	static void smethod_16(Component component_0)
	{
		//Discarded unreachable code: IL_0007, IL_000d, IL_0013, IL_001b, IL_0023
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_000f: Expected F4, but got I4
		//IL_0012: Expected F4, but got I4
		checked
		{
			_ = (nint)/*Error: ldloc 1 (out-of-bounds)*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	static extern Process smethod_17();

	static extern ProcessStartInfo smethod_18();

	static extern void smethod_19(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static extern void smethod_20(ProcessStartInfo processStartInfo_0, string string_4);

	static extern string smethod_21(string string_4, string string_5, string string_6);

	unsafe static void smethod_22(ProcessStartInfo processStartInfo_0, string string_4)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
			{
				checked
				{
					ulong num = (ulong)/*Error near IL_0006: Stack underflow*/;
					_ = (long)unchecked((int)checked((byte)((uint[])/*Error near IL_0007: Stack underflow*/)[num]));
					/*Error near IL_0009: stloc 0 (out-of-bounds)*/;
				}
				float num2 = *(float*)(int)(uint)/*Error near IL_000e: Stack underflow*/;
				if ((((object[])(/*Error near IL_0012: Stack underflow*/ + num2))[checked(-1f - null)] & 1) != 0 && (int)/*Error near IL_002b: Stack underflow*/ == 0)
				{
					break;
				}
			}
		}
		_ = ((double[])/*Error near IL_002d: Stack underflow*/)[/*Error near IL_002d: Stack underflow*/];
		/*Error near IL_002d: stloc 3 (out-of-bounds)*/;
		checked
		{
			_ = (ulong)/*Error near IL_002f: Stack underflow*/;
			/*Error: Unexpected end of block*/;
		}
	}

	static void smethod_23(Process process_0, ProcessStartInfo processStartInfo_0)
	{
		//Discarded unreachable code: IL_001f, IL_0024
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		_003F val;
		do
		{
			val = checked((float)/*Error near IL_0001: Stack underflow*/ - null);
		}
		while ((((object[])/*Error near IL_0005: Stack underflow*/)[val] & 1) == 0 || (int)/*Error near IL_0014: Stack underflow*/ != 0);
		_ = ((double[])/*Error near IL_0016: Stack underflow*/)[/*Error near IL_0016: Stack underflow*/];
		/*Error near IL_0016: stloc 3 (out-of-bounds)*/;
		checked
		{
			_ = (ulong)/*Error near IL_0018: Stack underflow*/;
			/*Error near IL_0019: stloc 1 (out-of-bounds)*/;
			/*Error near IL_001a: Invalid metadata token*/;
		}
	}

	static bool smethod_24(Process process_0)
	{
		//Discarded unreachable code: IL_000b, IL_0010, IL_0018
		_ = ((double[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/];
		/*Error near IL_0002: stloc 3 (out-of-bounds)*/;
		checked
		{
			_ = (ulong)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0005: stloc 1 (out-of-bounds)*/;
			/*Error near IL_0006: Invalid metadata token*/;
		}
	}

	unsafe static void smethod_25(int int_0)
	{
		//Discarded unreachable code: IL_000a
		IntPtr intPtr = (nint)((Array)/*Error near IL_0002: Stack underflow*/).LongLength;
		((sbyte[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (sbyte)(nint)intPtr;
		*(_003F*)(nint)/*Error near IL_0005: Stack underflow*/ = /*Error near IL_0005: Stack underflow*/;
		/*Error near IL_0005: Invalid metadata token*/;
	}

	static extern void smethod_26(string string_4);

	static extern string smethod_27(string string_4);

	static extern byte[] smethod_28(string string_4);

	unsafe static RijndaelManaged smethod_29()
	{
		//Discarded unreachable code: IL_000d, IL_000e
		//IL_0003: Expected O, but got I
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		_003F val;
		do
		{
			nint num;
			checked
			{
				num = (nint)(*unchecked((int*)(nint)/*Error near IL_0001: Stack underflow*/));
			}
			*(object*)(nint)/*Error near IL_0003: Stack underflow*/ = num;
			val = /*Error near IL_0004: Stack underflow*// /*Error near IL_0004: Stack underflow*/;
		}
		while (/*Error near IL_0009: Stack underflow*/ <= val);
		checked
		{
			_ = /*Error near IL_000a: Stack underflow*/* /*Error near IL_000a: Stack underflow*/;
			/*Error near IL_000c: Unknown opcode: 0xFF*/;
		}
	}

	static extern void smethod_30(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern void smethod_31(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static Encoding smethod_32()
	{
		//Discarded unreachable code: IL_0009, IL_000e, IL_001d, IL_0023
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		_ = /*Error near IL_0001: Stack underflow*/% /*Error near IL_0001: Stack underflow*/% /*Error near IL_0001: ldarg 0 (out-of-bounds)*/;
		/*Error near IL_0004: Invalid metadata token*/;
	}

	unsafe static byte[] smethod_33(Encoding encoding_0, string string_4)
	{
		//IL_0007: Invalid comparison between Unknown and I4
		while (/*Error near IL_0005: Stack underflow*/ != /*Error near IL_0005: Stack underflow*/|| (int)/*Error near IL_000c: Stack underflow*/ > -1)
		{
		}
		ushort num = checked((ushort)/*Error near IL_000d: Stack underflow*/);
		*(IntPtr*)(nint)/*Error near IL_000e: Stack underflow*/ = (IntPtr)(int)num;
		return (byte[])/*OpCode not supported: Nop*/;
	}

	static extern void smethod_34(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_35(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_36(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	static extern void smethod_37(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static extern byte[] smethod_38(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern byte[] smethod_39(SymmetricAlgorithm symmetricAlgorithm_0);

	static ICryptoTransform smethod_40(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1)
	{
		/*OpCode not supported: DebugBreak*/;
		checked
		{
			_ = (long)/*Error near IL_0002: Stack underflow*/;
			/*Error: Unexpected end of block*/;
		}
	}

	static extern byte[] smethod_41(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static extern Encoding smethod_42();

	unsafe static string smethod_43(Encoding encoding_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_0014
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got F8
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I
		byte num = *(byte*)((short)/*Error near IL_0001: Stack underflow*/ * 2);
		_ = /*Error near IL_0006: Stack underflow*/| num;
		_ = 5.812083641638195E+265;
		/*Error near IL_000f: Invalid metadata token*/;
	}

	static extern void smethod_44(IDisposable idisposable_0);

	static extern Assembly smethod_45();

	static extern string smethod_46(Assembly assembly_0);

	static void smethod_47(string string_4, string string_5, bool bool_5)
	{
		//Discarded unreachable code: IL_0006, IL_000f, IL_0016, IL_001c, IL_0021
		//IL_0011: Invalid comparison between Unknown and I4
		//IL_0027: Invalid comparison between Unknown and I8
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern RegistryKey smethod_48(RegistryKey registryKey_0, string string_4, bool bool_5);

	static void smethod_49(RegistryKey registryKey_0, string string_4, object object_0)
	{
		//Discarded unreachable code: IL_0004, IL_000c, IL_0012, IL_001b, IL_0020, IL_0025, IL_002d
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nuint)unchecked((nint)checked((nuint)(uint)/*Error near IL_0001: Stack underflow*/));
			/*Error near IL_0003: Unknown opcode: 0xFD*/;
		}
	}

	static void smethod_50(string string_4, FileAttributes fileAttributes_0)
	{
		/*Error: Invalid metadata token*/;
	}

	static RegistryKey smethod_51(RegistryKey registryKey_0, string string_4)
	{
		return (RegistryKey)/*OpCode not supported: Nop*/;
	}

	static extern void smethod_52(RegistryKey registryKey_0);

	static Rectangle smethod_53(Point point_0)
	{
		//Discarded unreachable code: IL_0008, IL_000d, IL_0010, IL_0015, IL_0022
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		((float[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (float)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: stloc 0 (out-of-bounds)*/;
		_ = (long)/*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	unsafe static Bitmap smethod_54(int int_0, int int_1)
	{
		//Discarded unreachable code: IL_001c
		//IL_0011: Expected I8, but got I4
		while ((int)/*Error near IL_0005: Stack underflow*/ == 0 || *(long*)(nint)/*Error near IL_0009: Stack underflow*/ == 0L)
		{
		}
		((short[])/*Error near IL_000f: Stack underflow*/)[/*Error near IL_000f: Stack underflow*/] = (short)/*Error near IL_000f: Stack underflow*/;
		short num = ((short[])/*Error near IL_0010: Stack underflow*/)[/*Error near IL_0010: Stack underflow*/];
		*(long*)(nint)/*Error near IL_0011: Stack underflow*/ = num;
		checked
		{
			_ = (nint)/*Error near IL_0012: Stack underflow*/;
			_ = 4.7649935E+22f;
			/*Error near IL_0017: Invalid metadata token*/;
		}
	}

	static extern Graphics smethod_55(Image image_0);

	static extern void smethod_56(Graphics graphics_0, Point point_0, Point point_1, Size size_0);

	static extern ImageFormat smethod_57();

	static extern void smethod_58(Image image_0, string string_4, ImageFormat imageFormat_0);

	static extern bool smethod_59(string string_4);

	unsafe static void smethod_60(Process process_0)
	{
		//Discarded unreachable code: IL_000e, IL_001e, IL_002a, IL_002f
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected I4, but got Unknown
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected native int or pointer, but got F8
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Incompatible stack heights: 0 vs 1
		_003F val2;
		do
		{
			ushort num = *(ushort*)(nint)/*Error near IL_0001: Stack underflow*/;
			_003F val = /*Error near IL_0002: Stack underflow*// num;
			*(sbyte*)(nint)/*Error near IL_0003: Stack underflow*/ = (sbyte)(int)val;
			val2 = checked(/*Error near IL_0005: Stack underflow*/ - /*Error near IL_0005: Stack underflow*/);
		}
		while (/*Error near IL_000a: Stack underflow*/ <= val2);
		_ = *(int*)(nint)(*(double*)null);
		/*Error near IL_000d: Unknown opcode: 0xFB*/;
	}

	static extern string[] smethod_61(string string_4, char[] char_0);

	static extern string smethod_62(WebClient webClient_0, string string_4);

	static extern string smethod_63();

	static extern string smethod_64();

	static extern string smethod_65(string[] string_4);

	static void smethod_66(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0007
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static Process[] smethod_67()
	{
		//Discarded unreachable code: IL_000b
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected I4, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			((short[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (short)/*Error near IL_0001: Stack underflow*/;
		}
		while (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0006: Stack underflow*/);
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static extern string smethod_68(Process process_0);

	static extern void smethod_69(Process process_0);

	static extern Process smethod_70();

	static extern IntPtr smethod_71(Process process_0);

	static extern ManagementObjectSearcher smethod_72(string string_4);

	unsafe static ManagementObjectCollection smethod_73(ManagementObjectSearcher managementObjectSearcher_0)
	{
		//IL_000b: Expected F8, but got I8
		while (true)
		{
			*(double*)checked((sbyte)/*Error near IL_0001: Stack underflow*/) = -6.490255289197191E+18;
			if (/*Error near IL_0012: Stack underflow*/ > /*Error near IL_0012: Stack underflow*/)
			{
				/*Error: Could not find block for branch target IL_0012*/;
			}
		}
	}

	static extern ManagementObjectEnumerator smethod_74(ManagementObjectCollection managementObjectCollection_0);

	static extern ManagementBaseObject smethod_75(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern object smethod_76(ManagementBaseObject managementBaseObject_0, string string_4);

	static extern string smethod_77(object object_0);

	static extern string smethod_78(string string_4);

	static extern bool smethod_79(string string_4, string string_5);

	static extern string smethod_80(string string_4);

	static extern bool smethod_81(string string_4, string string_5);

	static extern bool smethod_82(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern NetworkInterface[] smethod_83();

	static OperationalStatus smethod_84(NetworkInterface networkInterface_0)
	{
		//Discarded unreachable code: IL_0005, IL_000c, IL_0011, IL_0016
		while (true)
		{
		}
	}

	static extern PhysicalAddress smethod_85(NetworkInterface networkInterface_0);

	static extern string smethod_86(string string_4, char[] char_0);

	unsafe static FileSystemWatcher smethod_87()
	{
		//Discarded unreachable code: IL_0002, IL_0009, IL_0011
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xFF*/;
	}

	static extern string smethod_88(Environment.SpecialFolder specialFolder_0);

	static extern void smethod_89(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static void smethod_90(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0)
	{
		while (true)
		{
		}
	}

	static extern void smethod_91(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static extern void smethod_92(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0);

	static extern void smethod_93(FileSystemWatcher fileSystemWatcher_1, bool bool_5);

	static extern bool smethod_94(string string_4, string string_5);

	static extern bool smethod_95(string string_4);

	static string[] smethod_96(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0009, IL_001c, IL_002b, IL_0034
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		_003F val = /*Error near IL_0001: Stack underflow*/| /*Error near IL_0001: Stack underflow*/;
		((object[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (object)val;
		/*Error near IL_0004: Invalid metadata token*/;
	}

	static extern Match smethod_97(string string_4, string string_5);

	static extern WebHeaderCollection smethod_98(WebClient webClient_0);

	static extern void smethod_99(WebHeaderCollection webHeaderCollection_0, HttpRequestHeader httpRequestHeader_0, string string_4);
}
