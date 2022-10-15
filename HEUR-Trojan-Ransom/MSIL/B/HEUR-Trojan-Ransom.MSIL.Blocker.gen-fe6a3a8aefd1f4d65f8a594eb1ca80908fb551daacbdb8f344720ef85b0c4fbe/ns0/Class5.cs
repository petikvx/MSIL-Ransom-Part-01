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

	private static void smethod_1()
	{
		//Discarded unreachable code: IL_000a, IL_0017, IL_001c, IL_0021
		//IL_0012: Expected O, but got I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		while (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
		}
		/*Error near IL_0005: Invalid metadata token*/;
	}

	private static extern void smethod_2(string string_4, string string_5);

	private static void Main()
	{
		//Discarded unreachable code: IL_0005, IL_000f, IL_0014, IL_001f
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	private static extern void smethod_3();

	private static extern bool smethod_4();

	private static extern bool smethod_5();

	private static extern bool smethod_6();

	private static string smethod_7()
	{
		//Discarded unreachable code: IL_0004, IL_0009
		_ = ((byte[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/];
		_ = 1;
		/*Error near IL_0003: Unknown opcode: 0xF8*/;
	}

	private unsafe static void smethod_8()
	{
		//IL_000a: Expected I8, but got I4
		while (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
		{
		}
		int num = *(int*)(int)((ushort[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/];
		*(long*)(nint)/*Error near IL_000a: Stack underflow*/ = num;
		/*Error near IL_000c: Invalid metadata token*/;
	}

	private static void smethod_9(object sender, FileSystemEventArgs e)
	{
		//Discarded unreachable code: IL_0006, IL_000e, IL_0017, IL_0021, IL_0029, IL_002a, IL_0032, IL_003d
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected F4, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected I4, but got F4
		//IL_002d: Incompatible stack heights: 0 vs 1
		//IL_003e: Invalid comparison between Unknown and I4
		/*Error near IL_0001: Invalid metadata token*/;
	}

	public extern Class5();

	static extern byte[] smethod_10(string string_4);

	static extern RijndaelManaged smethod_11();

	static extern void smethod_12(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern void smethod_13(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern Encoding smethod_14();

	static extern byte[] smethod_15(Encoding encoding_0, string string_4);

	static extern void smethod_16(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_17(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_18(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	static extern void smethod_19(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static byte[] smethod_20(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_000f, IL_001a
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected F8, but got Unknown
		while (true)
		{
		}
	}

	static byte[] smethod_21(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		while (true)
		{
		}
	}

	static extern ICryptoTransform smethod_22(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static extern byte[] smethod_23(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static extern Encoding smethod_24();

	unsafe static string smethod_25(Encoding encoding_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_000c, IL_0011, IL_0016, IL_0018, IL_0028, IL_0029, IL_002b, IL_0032
		//IL_0004: Expected F8, but got Ref
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		*(double*)(int)((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (nint)(&encoding_0);
		/*Error near IL_0004: stloc 2 (out-of-bounds)*/;
		/*Error near IL_0007: Invalid metadata token*/;
	}

	unsafe static void smethod_26(IDisposable idisposable_0)
	{
		//Discarded unreachable code: IL_0004, IL_0014, IL_0015, IL_0017, IL_001e
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		_ = *(object*)(nint)/*Error near IL_0001: Stack underflow*/;
		_ = 90;
		/*Error near IL_0003: Unknown opcode: 0xFA*/;
	}

	static extern string smethod_27(string string_4);

	static extern Assembly smethod_28();

	static extern Stream smethod_29(Assembly assembly_0, string string_4);

	static string smethod_30(string string_4, string string_5, string string_6)
	{
		//Discarded unreachable code: IL_0017
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			_003F val = checked(/*Error near IL_0001: Stack underflow*/ - /*Error near IL_0001: Stack underflow*/);
			_ = /*Error near IL_0003: Stack underflow*/* val;
			_ = 14;
			/*Error near IL_0005: stloc 0 (out-of-bounds)*/;
		}
		while ((int)/*Error near IL_000d: Stack underflow*/ != 0 || /*Error near IL_0012: Stack underflow*/< /*Error near IL_0012: Stack underflow*/);
		/*Error near IL_0012: Invalid metadata token*/;
	}

	static FileStream smethod_31(string string_4, FileMode fileMode_0, FileAccess fileAccess_0)
	{
		//Discarded unreachable code: IL_0001, IL_0007, IL_000e, IL_0014, IL_0019, IL_002f, IL_0037
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Incompatible stack heights: 0 vs 1
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Unknown opcode: 0xFB*/;
	}

	static extern void smethod_32(Stream stream_0, Stream stream_1);

	static extern Process smethod_33(string string_4);

	static extern string smethod_34(Assembly assembly_0);

	static string smethod_35(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0006, IL_000c, IL_0012
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static void smethod_36(string string_4, string string_5, bool bool_5)
	{
		//Discarded unreachable code: IL_0005, IL_001e
		//IL_0011: Expected I4, but got F8
		//IL_0018: Expected F8, but got I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static extern RegistryKey smethod_37(RegistryKey registryKey_0, string string_4, bool bool_5);

	static extern void smethod_38(RegistryKey registryKey_0, string string_4, object object_0);

	static extern Assembly smethod_39();

	static string smethod_40(string string_4)
	{
		//Discarded unreachable code: IL_0009
		//IL_000c: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (sbyte)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloca 0 (out-of-bounds)*/;
			/*Error near IL_0004: Invalid metadata token*/;
		}
	}

	static extern bool smethod_41(string string_4, string string_5);

	static Rectangle smethod_42(Point point_0)
	{
		//Discarded unreachable code: IL_0005, IL_000c, IL_0011, IL_0018, IL_0020, IL_0021
		while (true)
		{
		}
	}

	static extern Bitmap smethod_43(int int_0, int int_1);

	static Graphics smethod_44(Image image_0)
	{
		((object[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (object)/*Error near IL_0001: Stack underflow*/;
		_ = (sbyte)/*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static void smethod_45(Graphics graphics_0, Point point_0, Point point_1, Size size_0)
	{
		//Discarded unreachable code: IL_0005, IL_0006
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
		}
	}

	static ImageFormat smethod_46()
	{
		//Discarded unreachable code: IL_0001, IL_0008, IL_000e
		/*Error: Unknown opcode: 0xFC*/;
	}

	static extern void smethod_47(Image image_0, string string_4, ImageFormat imageFormat_0);

	static extern WebClient smethod_48();

	static extern bool smethod_49(string string_4);

	static extern void smethod_50(string string_4);

	unsafe static void smethod_51(WebClient webClient_0, string string_4, string string_5)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected I4, but got Unknown
		_003F val = /*Error: ldloca 0 (out-of-bounds)*/;
		int num = ((int[])/*Error near IL_0005: Stack underflow*/)[val];
		_003F val2 = checked(/*Error near IL_0007: Stack underflow*/ * num);
		*(short*)(nint)/*Error near IL_0010: Stack underflow*/ = (short)(val2 * -1811257165);
		/*Error: Unexpected end of block*/;
	}

	static extern Process smethod_52();

	static ProcessStartInfo smethod_53()
	{
		//Discarded unreachable code: IL_000b, IL_000f, IL_0028, IL_002d
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			/*Error: stloc 2 (out-of-bounds)*/;
		}
		while ((int)/*Error near IL_0006: Stack underflow*/ != 0);
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static extern void smethod_54(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	unsafe static void smethod_55(ProcessStartInfo processStartInfo_0, string string_4)
	{
		//Discarded unreachable code: IL_0005, IL_000e, IL_0013, IL_0018
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		_003F val = ~/*Error near IL_0001: Stack underflow*/;
		/*OpCode not supported: DebugBreak*/;
		_ = *(float*)checked((sbyte)val);
		/*Error near IL_0004: Unknown opcode: 0xF9*/;
	}

	static extern void smethod_56(Process process_0, ProcessStartInfo processStartInfo_0);

	static extern bool smethod_57(Process process_0);

	static extern void smethod_58(Process process_0);

	static extern string smethod_59(string string_4);

	static string[] smethod_60(string string_4, char[] char_0)
	{
		//Discarded unreachable code: IL_0006
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern string smethod_61(WebClient webClient_0, string string_4);

	static extern string smethod_62();

	static extern string smethod_63(string[] string_4);

	unsafe static void smethod_64(int int_0)
	{
		//IL_0004: Expected I8, but got I
		nint num = checked((nint)/*Error near IL_0003: Stack underflow*/);
		*(long*)(nint)/*Error near IL_0004: Stack underflow*/ = num;
		_ = (double)/*Error near IL_0005: Stack underflow*/;
		/*Error near IL_0005: Invalid metadata token*/;
	}

	static Process[] smethod_65()
	{
		//Discarded unreachable code: IL_000a, IL_0012, IL_001a, IL_0020, IL_0025, IL_002a
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and F4
		_003F val = /*Error near IL_0006: Stack underflow*/* "";
		_ = ((byte[])/*Error near IL_0007: Stack underflow*/)[val];
		/*Error near IL_0009: Unknown opcode: 0xFD*/;
	}

	static extern string smethod_66(Process process_0);

	static extern void smethod_67(Process process_0);

	unsafe static Process smethod_68()
	{
		//Discarded unreachable code: IL_0007
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		checked
		{
			_ = /*Error near IL_0002: Stack underflow*/- /*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	static IntPtr smethod_69(Process process_0)
	{
		//Discarded unreachable code: IL_000d, IL_0013, IL_0018
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			/*OpCode not supported: Ckfinite*/;
			/*Error near IL_0002: stloc 3 (out-of-bounds)*/;
		}
		while (/*Error near IL_0008: Stack underflow*/ == /*Error near IL_0008: Stack underflow*/);
		/*Error near IL_0008: Invalid metadata token*/;
	}

	static extern ManagementObjectSearcher smethod_70(string string_4);

	static extern ManagementObjectCollection smethod_71(ManagementObjectSearcher managementObjectSearcher_0);

	static ManagementObjectEnumerator smethod_72(ManagementObjectCollection managementObjectCollection_0)
	{
		//Discarded unreachable code: IL_0003, IL_000a, IL_0010, IL_001c, IL_0021, IL_0029, IL_002e
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0002: Unknown opcode: 0xF8*/;
	}

	static extern ManagementBaseObject smethod_73(ManagementObjectEnumerator managementObjectEnumerator_0);

	unsafe static object smethod_74(ManagementBaseObject managementBaseObject_0, string string_4)
	{
		//Discarded unreachable code: IL_000d, IL_0012, IL_0017, IL_001f, IL_0024
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_001a: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		while ((int)/*Error near IL_0007: Stack underflow*/ <= 7)
		{
		}
		_ = *(object*)(nint)/*Error near IL_0008: Stack underflow*/;
		/*Error near IL_0008: Invalid metadata token*/;
	}

	static extern string smethod_75(object object_0);

	static extern string smethod_76(string string_4);

	static extern bool smethod_77(string string_4, string string_5);

	static string smethod_78(string string_4)
	{
		//Discarded unreachable code: IL_0001, IL_0007, IL_0008
		/*Error: Unknown opcode: 0xF9*/;
	}

	static extern bool smethod_79(string string_4, string string_5);

	static extern bool smethod_80(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern NetworkInterface[] smethod_81();

	static extern OperationalStatus smethod_82(NetworkInterface networkInterface_0);

	static extern PhysicalAddress smethod_83(NetworkInterface networkInterface_0);

	static extern string smethod_84(string string_4, char[] char_0);

	static extern FileSystemWatcher smethod_85();

	unsafe static string smethod_86(Environment.SpecialFolder specialFolder_0)
	{
		//Discarded unreachable code: IL_0014
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got I8
		//IL_001a: Expected O, but got I4
		while (true)
		{
			_003F val = checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
			if (/*Error near IL_0006: Stack underflow*/ != val)
			{
				ulong num = checked((ulong)(~/*Error near IL_0008: Stack underflow*/));
				*(object*)(nint)/*Error near IL_000a: Stack underflow*/ = num;
				if (/*Error near IL_000f: Stack underflow*/ > /*Error near IL_000f: Stack underflow*/)
				{
				}
			}
		}
	}

	unsafe static void smethod_87(FileSystemWatcher fileSystemWatcher_1, string string_4)
	{
		_ = *(object*)((short[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error: Unexpected end of block*/;
	}

	static extern void smethod_88(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0);

	static extern void smethod_89(FileSystemWatcher fileSystemWatcher_1, string string_4);

	unsafe static void smethod_90(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0)
	{
		//IL_0003: Invalid comparison between F8 and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		while (*(double*)(nint)/*Error near IL_0001: Stack underflow*/ >= 7.0)
		{
		}
		IntPtr intPtr = (nint)((Array)/*Error near IL_000a: Stack underflow*/).LongLength;
		/*OpCode not supported: Ckfinite*/;
		/*Error near IL_000e: ldloca 0 (out-of-bounds)*/;
		/*Error near IL_0010: Invalid metadata token*/;
	}

	static extern void smethod_91(FileSystemWatcher fileSystemWatcher_1, bool bool_5);
}
