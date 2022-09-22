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
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
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

	private static extern void smethod_1(string string_4, string string_5, string string_6);

	private static extern void smethod_2();

	private static extern void smethod_3(string string_4);

	private static extern void smethod_4();

	private static extern void smethod_5(string string_4, string string_5);

	private static extern void Main();

	private static extern void smethod_6();

	private static extern bool smethod_7();

	private static extern bool smethod_8();

	private static extern bool smethod_9();

	private static extern string smethod_10();

	private static void smethod_11()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (long)(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
			/*Error: Unexpected end of block*/;
		}
	}

	private static extern void smethod_12(object sender, FileSystemEventArgs e);

	private static extern void smethod_13();

	private static void smethod_14()
	{
		//Discarded unreachable code: IL_001b
		while (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0006: Stack underflow*/)
		{
		}
		checked
		{
			_ = (int)((sbyte[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/];
			_ = 3.2294945286374875E+235;
			/*Error near IL_0012: ldarg 3 (out-of-bounds)*/;
			/*Error near IL_0016: Invalid metadata token*/;
		}
	}

	public static extern bool smethod_15(string string_4);

	public extern Class5();

	unsafe static Class5()
	{
		//Discarded unreachable code: IL_000c
		//IL_0002: Invalid comparison between Unknown and O
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		object obj;
		do
		{
			obj = *(object*)checked((ulong)/*Error near IL_0001: Stack underflow*/);
		}
		while (/*Error near IL_0007: Stack underflow*/ > obj);
		/*Error near IL_0007: Invalid metadata token*/;
	}

	static extern byte[] smethod_16(string string_4);

	static extern RijndaelManaged smethod_17();

	static void smethod_18(SymmetricAlgorithm symmetricAlgorithm_0, int int_0)
	{
		//Discarded unreachable code: IL_0006, IL_000c, IL_0018
		//IL_000f: Expected I4, but got I8
		_ = ((long[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern void smethod_19(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern Encoding smethod_20();

	static extern byte[] smethod_21(Encoding encoding_0, string string_4);

	static extern void smethod_22(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static void smethod_23(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		throw /*Error near IL_0003: Stack underflow*/<< (int)/*Error near IL_0003: Stack underflow*/;
	}

	static extern void smethod_24(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	static void smethod_25(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0)
	{
		//Discarded unreachable code: IL_0003, IL_000c, IL_0018
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unsupported input type for neg.
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected I4, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		_ = /*Error near IL_0001: Stack underflow*/% /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xF8*/;
	}

	static extern byte[] smethod_26(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern byte[] smethod_27(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern ICryptoTransform smethod_28(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static extern byte[] smethod_29(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static extern Encoding smethod_30();

	static extern string smethod_31(Encoding encoding_0, byte[] byte_0);

	static extern void smethod_32(IDisposable idisposable_0);

	static extern RegistryKey smethod_33(RegistryKey registryKey_0, string string_4, RegistryKeyPermissionCheck registryKeyPermissionCheck_0);

	static RegistryKey smethod_34(RegistryKey registryKey_0, string string_4)
	{
		//Discarded unreachable code: IL_000d, IL_0019
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected I4, but got I8
		//IL_0014: Invalid comparison between Unknown and I4
		/*Error near IL_0001: ldarg 3 (out-of-bounds)*/;
		_ = 314196867;
		/*Error near IL_0008: Invalid metadata token*/;
	}

	static extern void smethod_35(RegistryKey registryKey_0, string string_4, object object_0, RegistryValueKind registryValueKind_0);

	static extern object smethod_36(RegistryKey registryKey_0, string string_4);

	static extern Process smethod_37();

	static extern ProcessStartInfo smethod_38();

	static extern void smethod_39(ProcessStartInfo processStartInfo_0, string string_4);

	unsafe static void smethod_40(ProcessStartInfo processStartInfo_0, string string_4)
	{
		while (checked((nint)/*Error near IL_0001: Stack underflow*/) == 0)
		{
		}
		*(_003F*)(nint)/*Error near IL_0008: Stack underflow*/ = /*Error near IL_0008: Stack underflow*/;
		/*Error: Unexpected end of block*/;
	}

	static extern void smethod_41(ProcessStartInfo processStartInfo_0, bool bool_5);

	static extern void smethod_42(ProcessStartInfo processStartInfo_0, bool bool_5);

	static extern void smethod_43(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static extern void smethod_44(ProcessStartInfo processStartInfo_0, bool bool_5);

	static extern void smethod_45(Process process_0, ProcessStartInfo processStartInfo_0);

	static extern bool smethod_46(Process process_0);

	static extern StreamReader smethod_47(Process process_0);

	static extern string smethod_48(TextReader textReader_0);

	static extern bool smethod_49(string string_4, string string_5);

	static extern bool smethod_50(string string_4, string string_5);

	static extern bool smethod_51(StreamReader streamReader_0);

	static extern string smethod_52(string string_4);

	static extern Assembly smethod_53();

	static extern Stream smethod_54(Assembly assembly_0, string string_4);

	static string smethod_55(string string_4, string string_5, string string_6)
	{
		//Discarded unreachable code: IL_0001, IL_000e, IL_0013, IL_001a
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected F4, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Unknown opcode: 0xFA*/;
	}

	static extern FileStream smethod_56(string string_4, FileMode fileMode_0, FileAccess fileAccess_0);

	static void smethod_57(Stream stream_0, Stream stream_1)
	{
		//Discarded unreachable code: IL_0007, IL_000e, IL_0015, IL_001b, IL_0022
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		_ = 8;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static Process smethod_58(string string_4)
	{
		//Discarded unreachable code: IL_0006, IL_000d, IL_0013, IL_001a
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
		}
	}

	static extern string smethod_59(Assembly assembly_0);

	static extern string smethod_60(string string_4, string string_5);

	static extern void smethod_61(string string_4, string string_5, bool bool_5);

	static extern RegistryKey smethod_62(RegistryKey registryKey_0, string string_4, bool bool_5);

	static extern void smethod_63(RegistryKey registryKey_0, string string_4, object object_0);

	static extern void smethod_64(string string_4, FileAttributes fileAttributes_0);

	unsafe static DialogResult smethod_65(string string_4, string string_5, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		//Discarded unreachable code: IL_000d
		nint num = (nint)/*Error near IL_0002: Stack underflow*/;
		*(short*)(nint)/*Error near IL_0005: Stack underflow*/ = (short)num;
		_ = *(sbyte*)(int)checked((uint)/*Error near IL_0006: Stack underflow*/);
		/*Error near IL_0007: stloc 0 (out-of-bounds)*/;
		/*Error near IL_0008: Invalid metadata token*/;
	}

	static extern void smethod_66(RegistryKey registryKey_0);

	static extern WindowsIdentity smethod_67();

	static extern WindowsPrincipal smethod_68(WindowsIdentity windowsIdentity_0);

	static extern bool smethod_69(WindowsPrincipal windowsPrincipal_0, WindowsBuiltInRole windowsBuiltInRole_0);

	static extern Assembly smethod_70();

	static string smethod_71(string string_4)
	{
		//Discarded unreachable code: IL_0008, IL_000d, IL_0010, IL_0015, IL_001a, IL_001f, IL_0024, IL_0031
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected F8, but got O
		/*Error: stloc 1 (out-of-bounds)*/;
		/*Error near IL_0001: ldloca 0 (out-of-bounds)*/;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static bool smethod_72(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0010, IL_001d, IL_0022, IL_0027, IL_002c, IL_0034, IL_0039
		//IL_0002: Expected O, but got I
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected F8, but got O
		//IL_002f: Invalid comparison between Unknown and I
		_ = (nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	unsafe static Rectangle smethod_73(Point point_0)
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0010, IL_0015, IL_001d, IL_0022, IL_002f, IL_003a, IL_003f, IL_0041
		//IL_0005: Expected F8, but got O
		//IL_0018: Invalid comparison between Unknown and I
		//IL_002a: Expected I4, but got I8
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		_ = *(short*)checked((sbyte)/*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: stloc 2 (out-of-bounds)*/;
		*(double*)(nint)/*Error near IL_0005: Stack underflow*/ = (double)point_0;
		/*Error near IL_0005: Unknown opcode: 0xFD*/;
	}

	static extern Bitmap smethod_74(int int_0, int int_1);

	static extern Graphics smethod_75(Image image_0);

	static extern void smethod_76(Graphics graphics_0, Point point_0, Point point_1, Size size_0);

	static extern ImageFormat smethod_77();

	static extern void smethod_78(Image image_0, string string_4, ImageFormat imageFormat_0);

	static extern WebClient smethod_79();

	static extern bool smethod_80(string string_4);

	static extern void smethod_81(string string_4);

	unsafe static void smethod_82(WebClient webClient_0, string string_4, string string_5)
	{
		//IL_0004: Expected native int or pointer, but got O
		/*Error: stloc 2 (out-of-bounds)*/;
		_ = ((short[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/];
		_ = *(ushort*)(*(short*)(*(ulong*)unchecked((nint)null)));
		/*Error near IL_0009: stloc 0 (out-of-bounds)*/;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	static extern void smethod_83(Process process_0);

	static extern string smethod_84(string string_4);

	static extern string[] smethod_85(string string_4, char[] char_0);

	static extern string smethod_86(WebClient webClient_0, string string_4);

	static extern string smethod_87();

	static extern string smethod_88();

	static extern string smethod_89(string[] string_4);

	static extern void smethod_90(int int_0);

	static extern Process[] smethod_91();

	static extern string smethod_92(Process process_0);

	static extern void smethod_93(Process process_0);

	static extern Process smethod_94();

	static extern IntPtr smethod_95(Process process_0);

	static extern ManagementObjectSearcher smethod_96(string string_4);

	static extern ManagementObjectCollection smethod_97(ManagementObjectSearcher managementObjectSearcher_0);

	static extern ManagementObjectEnumerator smethod_98(ManagementObjectCollection managementObjectCollection_0);

	static extern ManagementBaseObject smethod_99(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern object smethod_100(ManagementBaseObject managementBaseObject_0, string string_4);

	static extern string smethod_101(object object_0);

	static extern string smethod_102(string string_4);

	static extern bool smethod_103(string string_4, string string_5);

	static extern string smethod_104(string string_4);

	static extern bool smethod_105(string string_4, string string_5);

	static extern bool smethod_106(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern NetworkInterface[] smethod_107();

	static extern OperationalStatus smethod_108(NetworkInterface networkInterface_0);

	static PhysicalAddress smethod_109(NetworkInterface networkInterface_0)
	{
		//Discarded unreachable code: IL_0013, IL_001b, IL_001e, IL_0022, IL_0028
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Invalid comparison between Unknown and I4
		//IL_0016: Expected I, but got O
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		byte num2;
		do
		{
			checked
			{
				int num = (int)/*Error near IL_0002: Stack underflow*/;
				num2 = (byte)(/*Error near IL_0003: Stack underflow*/ + num);
			}
		}
		while ((int)/*Error near IL_000a: Stack underflow*/ < (int)num2);
		_ = 5;
		/*Error near IL_000e: Invalid metadata token*/;
	}

	static extern string smethod_110(string string_4, char[] char_0);

	static extern FileSystemWatcher smethod_111();

	static extern string smethod_112(Environment.SpecialFolder specialFolder_0);

	static extern void smethod_113(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static void smethod_114(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0)
	{
		//Discarded unreachable code: IL_0016, IL_0017, IL_001d, IL_0025, IL_002b
		//IL_000c: Incompatible stack heights: 0 vs 1
		//IL_0018: Incompatible stack heights: 0 vs 1
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_0026: Invalid comparison between Unknown and I4
		while (true)
		{
			_ = (int)((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			if (true)
			{
			}
		}
	}

	static extern void smethod_115(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static extern void smethod_116(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0);

	static void smethod_117(FileSystemWatcher fileSystemWatcher_1, bool bool_5)
	{
		/*Error: Unexpected end of block*/;
	}

	static extern bool smethod_118(string string_4);

	static extern string[] smethod_119(string string_4, string string_5);

	unsafe static Match smethod_120(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_000f, IL_0015
		//IL_000b: Expected O, but got I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			/*OpCode not supported: DebugBreak*/;
		}
		while (/*Error near IL_0006: Stack underflow*/ <= /*Error near IL_0006: Stack underflow*/);
		IntPtr intPtr = (nint)((Array)(*(ushort*)((short[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/])).LongLength;
		_ = /*Error near IL_000c: Stack underflow*/% (nint)intPtr;
		checked
		{
			_ = (uint)/*Error near IL_000c: ldarg 3 (out-of-bounds)*/;
			/*Error near IL_000e: Unknown opcode: 0xFB*/;
		}
	}

	static extern WebHeaderCollection smethod_121(WebClient webClient_0);

	static extern void smethod_122(WebHeaderCollection webHeaderCollection_0, HttpRequestHeader httpRequestHeader_0, string string_4);
}
