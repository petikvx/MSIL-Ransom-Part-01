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

	private static void smethod_4()
	{
		//Discarded unreachable code: IL_000a, IL_000b
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_003F val = /*Error near IL_0001: Stack underflow*/>> (int)/*Error near IL_0001: Stack underflow*/;
		nint num = checked((nint)((long[])/*Error near IL_0003: Stack underflow*/)[val]);
		_ = ((IntPtr[])/*Error near IL_0005: Stack underflow*/)[num];
		/*Error near IL_0005: Invalid metadata token*/;
	}

	private static extern void smethod_5(string string_4, string string_5);

	private static void Main()
	{
		//Discarded unreachable code: IL_0007, IL_000f
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		_ = 7;
		/*Error near IL_0001: ldloc 3 (out-of-bounds)*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private static extern void smethod_6();

	private static extern bool smethod_7();

	private static extern bool smethod_8();

	private static extern bool smethod_9();

	private static extern string smethod_10();

	private static extern void smethod_11();

	private static extern void smethod_12(object sender, FileSystemEventArgs e);

	private static extern void smethod_13();

	private static void smethod_14()
	{
		//Discarded unreachable code: IL_000a, IL_000f, IL_0018, IL_0023, IL_0029, IL_002b, IL_0039
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unsupported input type for neg.
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		_ = /*Error: ldarg 3 (out-of-bounds)*/>> (int)(ushort)/*Error near IL_0001: ldarg 1 (out-of-bounds)*/;
		/*Error near IL_0005: Invalid metadata token*/;
	}

	public static extern bool smethod_15(string string_4);

	public extern Class5();

	static Class5()
	{
		//Discarded unreachable code: IL_0005, IL_000c, IL_0011, IL_0016, IL_0021, IL_002b, IL_0032
		//IL_0007: Expected F4, but got I8
		//IL_001c: Expected I4, but got I8
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static extern byte[] smethod_16(string string_4);

	static extern RijndaelManaged smethod_17();

	static void smethod_18(SymmetricAlgorithm symmetricAlgorithm_0, int int_0)
	{
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern void smethod_19(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern Encoding smethod_20();

	static extern byte[] smethod_21(Encoding encoding_0, string string_4);

	static extern void smethod_22(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_23(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static void smethod_24(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0)
	{
		byte num = (byte)/*Error near IL_0001: Stack underflow*/;
		((int[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = num;
		/*Error: Unexpected end of block*/;
	}

	static extern void smethod_25(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static extern byte[] smethod_26(SymmetricAlgorithm symmetricAlgorithm_0);

	static byte[] smethod_27(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		switch (/*Error near IL_0005: Stack underflow*/)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static extern ICryptoTransform smethod_28(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static extern byte[] smethod_29(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static Encoding smethod_30()
	{
		//Discarded unreachable code: IL_0007
		/*Error: ldloca 0 (out-of-bounds)*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static string smethod_31(Encoding encoding_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_0005
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_32(IDisposable idisposable_0);

	static extern RegistryKey smethod_33(RegistryKey registryKey_0, string string_4, RegistryKeyPermissionCheck registryKeyPermissionCheck_0);

	static extern RegistryKey smethod_34(RegistryKey registryKey_0, string string_4);

	static extern void smethod_35(RegistryKey registryKey_0, string string_4, object object_0, RegistryValueKind registryValueKind_0);

	static extern object smethod_36(RegistryKey registryKey_0, string string_4);

	static Process smethod_37()
	{
		//Discarded unreachable code: IL_0002, IL_0007, IL_0015, IL_001c
		//IL_000b: Expected F8, but got I4
		//IL_0010: Invalid comparison between Unknown and I4
		/*Error near IL_0001: Unknown opcode: 0xFF*/;
	}

	static extern ProcessStartInfo smethod_38();

	static void smethod_39(ProcessStartInfo processStartInfo_0, string string_4)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and O
		//IL_0018: Expected I, but got O
		_003F val;
		do
		{
			val = checked(/*Error near IL_0002: Stack underflow*/ + /*Error near IL_0002: Stack underflow*/);
		}
		while (/*Error near IL_0007: Stack underflow*/ > val || /*Error near IL_000e: Stack underflow*/< processStartInfo_0);
		((short[])/*Error near IL_000f: Stack underflow*/)[/*Error near IL_000f: Stack underflow*/] = (short)/*Error near IL_000f: Stack underflow*/;
		((IntPtr[])((long[])/*Error near IL_0012: Stack underflow*/)[8])[5] = (IntPtr)processStartInfo_0;
		checked
		{
			_ = (ulong)/*Error near IL_001a: Stack underflow*/;
			/*Error near IL_001a: Invalid metadata token*/;
		}
	}

	static extern void smethod_40(ProcessStartInfo processStartInfo_0, string string_4);

	static extern void smethod_41(ProcessStartInfo processStartInfo_0, bool bool_5);

	static extern void smethod_42(ProcessStartInfo processStartInfo_0, bool bool_5);

	unsafe static void smethod_43(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0)
	{
		//Discarded unreachable code: IL_0003, IL_0008, IL_0010, IL_001d, IL_001e, IL_0023, IL_002b
		//IL_0002: Expected I8, but got F8
		//IL_0014: Expected O, but got I
		//IL_0018: Expected O, but got I
		//IL_0026: Expected O, but got I4
		double num = (double)/*Error near IL_0001: Stack underflow*/;
		*(long*)(nint)/*Error near IL_0002: Stack underflow*/ = (long)num;
		/*Error near IL_0002: Unknown opcode: 0xFF*/;
	}

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

	static extern string smethod_55(string string_4, string string_5, string string_6);

	static extern FileStream smethod_56(string string_4, FileMode fileMode_0, FileAccess fileAccess_0);

	static extern void smethod_57(Stream stream_0, Stream stream_1);

	static extern Process smethod_58(string string_4);

	static extern string smethod_59(Assembly assembly_0);

	static extern string smethod_60(string string_4, string string_5);

	static extern void smethod_61(string string_4, string string_5, bool bool_5);

	static extern RegistryKey smethod_62(RegistryKey registryKey_0, string string_4, bool bool_5);

	static extern void smethod_63(RegistryKey registryKey_0, string string_4, object object_0);

	static extern void smethod_64(string string_4, FileAttributes fileAttributes_0);

	static DialogResult smethod_65(string string_4, string string_5, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		//Discarded unreachable code: IL_0005, IL_000f, IL_0014
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
		}
	}

	static void smethod_66(RegistryKey registryKey_0)
	{
		//Discarded unreachable code: IL_0007, IL_000c
		while (true)
		{
			/*Error: stloc 0 (out-of-bounds)*/;
		}
	}

	static WindowsIdentity smethod_67()
	{
		//Discarded unreachable code: IL_001d, IL_001e, IL_0023, IL_002f, IL_0036
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		sbyte num;
		do
		{
			num = (sbyte)/*Error near IL_0001: Stack underflow*/;
		}
		while ((int)/*Error near IL_0008: Stack underflow*/ > (int)num);
		checked
		{
			_ = (nint)unchecked((uint)checked((short)/*Error near IL_000c: Stack underflow*/));
			/*Error near IL_000d: ldarg 1 (out-of-bounds)*/;
			_ = 4294967295L;
			/*Error near IL_0018: Invalid metadata token*/;
		}
	}

	static extern WindowsPrincipal smethod_68(WindowsIdentity windowsIdentity_0);

	static extern bool smethod_69(WindowsPrincipal windowsPrincipal_0, WindowsBuiltInRole windowsBuiltInRole_0);

	static extern Assembly smethod_70();

	static extern string smethod_71(string string_4);

	static extern bool smethod_72(string string_4, string string_5);

	static Rectangle smethod_73(Point point_0)
	{
		//Discarded unreachable code: IL_0006, IL_000d
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static Bitmap smethod_74(int int_0, int int_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_003F val;
		do
		{
			nint num = checked((nint)/*Error near IL_0001: Stack underflow*/);
			val = /*Error near IL_0002: Stack underflow*// num;
		}
		while (/*Error near IL_0007: Stack underflow*/ > val);
		return (Bitmap)/*Error near IL_0008: Stack underflow*/;
	}

	static extern Graphics smethod_75(Image image_0);

	static void smethod_76(Graphics graphics_0, Point point_0, Point point_1, Size size_0)
	{
		//Discarded unreachable code: IL_0005, IL_000a
		while (true)
		{
		}
	}

	static extern ImageFormat smethod_77();

	static extern void smethod_78(Image image_0, string string_4, ImageFormat imageFormat_0);

	static extern WebClient smethod_79();

	static extern bool smethod_80(string string_4);

	static void smethod_81(string string_4)
	{
		//Discarded unreachable code: IL_0005, IL_000a
		//IL_000c: Expected native int or pointer, but got O
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0004: Unknown opcode: 0xF9*/;
	}

	static extern void smethod_82(WebClient webClient_0, string string_4, string string_5);

	static extern void smethod_83(Process process_0);

	static extern string smethod_84(string string_4);

	static extern string[] smethod_85(string string_4, char[] char_0);

	static string smethod_86(WebClient webClient_0, string string_4)
	{
		//Discarded unreachable code: IL_0005, IL_000c, IL_0012
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static extern string smethod_87();

	static string smethod_88(string[] string_4)
	{
		while ((int)/*Error near IL_0006: Stack underflow*/ == 0)
		{
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static extern void smethod_89(int int_0);

	static extern Process[] smethod_90();

	static extern string smethod_91(Process process_0);

	static extern void smethod_92(Process process_0);

	static extern Process smethod_93();

	unsafe static IntPtr smethod_94(Process process_0)
	{
		//Discarded unreachable code: IL_0018, IL_001e
		//IL_0009: Expected I8, but got I4
		//IL_000c: Invalid comparison between Unknown and I
		//IL_0013: Expected native int or pointer, but got F4
		while (true)
		{
			if (/*Error near IL_0007: Stack underflow*/ > /*Error near IL_0007: Stack underflow*/)
			{
				ushort num = ((ushort[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/];
				*(long*)(nint)/*Error near IL_0009: Stack underflow*/ = (int)num;
				object obj = ((object[])/*Error near IL_000a: Stack underflow*/)[/*Error near IL_000a: Stack underflow*/];
				if ((nint)/*Error near IL_0011: Stack underflow*/ != (nint)(nuint)obj)
				{
					break;
				}
			}
		}
		_ = *(float*)(int)(*(ushort*)(nint)/*Error near IL_0012: Stack underflow*/);
		/*Error near IL_0013: Invalid metadata token*/;
	}

	unsafe static ManagementObjectSearcher smethod_95(string string_4)
	{
		//Discarded unreachable code: IL_000a, IL_0011, IL_001d, IL_0022, IL_0029, IL_002f
		//IL_0005: Incompatible stack heights: 0 vs 1
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected F4, but got I4
		//IL_0024: Incompatible stack heights: 0 vs 1
		while (true)
		{
			/*Error near IL_0001: stloc 0 (out-of-bounds)*/;
			_ = *(uint*)(nint)/*Error near IL_0004: Stack underflow*/;
		}
	}

	unsafe static ManagementObjectCollection smethod_96(ManagementObjectSearcher managementObjectSearcher_0)
	{
		//Discarded unreachable code: IL_0009, IL_000e, IL_0015, IL_001b, IL_0025
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected F4, but got I4
		//IL_0010: Incompatible stack heights: 0 vs 1
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		/*Error: stloc 1 (out-of-bounds)*/;
		int num = *(int*)(nint)(/*Error near IL_0002: Stack underflow*/ << (int)/*Error near IL_0002: Stack underflow*/);
		*(float*)(nint)/*Error near IL_0004: Stack underflow*/ = num;
		/*Error near IL_0004: Invalid metadata token*/;
	}

	static extern ManagementObjectEnumerator smethod_97(ManagementObjectCollection managementObjectCollection_0);

	static extern ManagementBaseObject smethod_98(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern object smethod_99(ManagementBaseObject managementBaseObject_0, string string_4);

	unsafe static string smethod_100(object object_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected I, but got Unknown
		do
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			_003F val = /*Error near IL_0002: Stack underflow*/<< (int)/*Error near IL_0002: Stack underflow*/;
			*(IntPtr*)(nint)/*Error near IL_0004: Stack underflow*/ = (IntPtr)val;
		}
		while (/*Error near IL_0009: Stack underflow*/ >= /*Error near IL_0009: Stack underflow*/);
		/*Error near IL_0009: Invalid metadata token*/;
	}

	static extern string smethod_101(string string_4);

	static extern bool smethod_102(string string_4, string string_5);

	static extern string smethod_103(string string_4);

	static extern bool smethod_104(string string_4, string string_5);

	static extern bool smethod_105(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern NetworkInterface[] smethod_106();

	unsafe static OperationalStatus smethod_107(NetworkInterface networkInterface_0)
	{
		//Discarded unreachable code: IL_0019, IL_001f, IL_0027
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0010: Invalid comparison between Unknown and F8
		//IL_001a: Incompatible stack heights: 0 vs 1
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected F4, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			ushort num = *(ushort*)((sbyte[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			if ((int)/*Error near IL_0007: Stack underflow*/ < (int)num)
			{
				continue;
			}
			if (!((double)/*Error near IL_0012: Stack underflow*/ >= -3.4527636118906203E+216))
			{
				((int[])/*Error near IL_0013: Stack underflow*/)[/*Error near IL_0013: Stack underflow*/] = (int)/*Error near IL_0013: Stack underflow*/;
				continue;
			}
			_003F val = /*Error near IL_001c: Stack underflow*// /*Error near IL_001c: Stack underflow*/;
			if (/*Error near IL_001e: Stack underflow*/ < val)
			{
				break;
			}
		}
		/*Error near IL_001e: Unknown opcode: 0xFF*/;
	}

	static PhysicalAddress smethod_108(NetworkInterface networkInterface_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = (nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error: Unexpected end of block*/;
	}

	static extern string smethod_109(string string_4, char[] char_0);

	static extern FileSystemWatcher smethod_110();

	static extern string smethod_111(Environment.SpecialFolder specialFolder_0);

	static void smethod_112(FileSystemWatcher fileSystemWatcher_1, string string_4)
	{
		//Discarded unreachable code: IL_0004
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = ~/*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0003: Unknown opcode: 0xFA*/;
	}

	static extern void smethod_113(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0);

	static extern void smethod_114(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static extern void smethod_115(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0);

	unsafe static void smethod_116(FileSystemWatcher fileSystemWatcher_1, bool bool_5)
	{
		//Discarded unreachable code: IL_0011, IL_0020, IL_002a, IL_0032, IL_003a
		//IL_0004: Expected O, but got F4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_002d: Incompatible stack heights: 0 vs 1
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			((double[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (double)/*Error near IL_0001: Stack underflow*/;
			float num = *(float*)(int)(byte)/*Error near IL_0002: Stack underflow*/;
			*(object*)(nint)/*Error near IL_0004: Stack underflow*/ = num;
		}
		while ((int)/*Error near IL_0009: Stack underflow*/ != 0);
		short num2 = (short)/*Error near IL_000a: Stack underflow*/;
		_ = /*Error near IL_000c: Stack underflow*/% num2;
		/*Error near IL_000c: Invalid metadata token*/;
	}

	static bool smethod_117(string string_4)
	{
		//Discarded unreachable code: IL_000c, IL_0016, IL_001e, IL_0026, IL_0031
		//IL_0011: Invalid comparison between Unknown and I4
		//IL_0019: Incompatible stack heights: 0 vs 1
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected I8, but got F4
		while (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
		{
		}
		_ = 5;
		/*Error near IL_0007: Invalid metadata token*/;
	}

	static string[] smethod_118(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0007, IL_000f, IL_001a, IL_0021, IL_0028, IL_002d
		//IL_0002: Incompatible stack heights: 0 vs 1
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected I8, but got F4
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			/*Error: ldarg 2 (out-of-bounds)*/;
		}
	}

	static Match smethod_119(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0007, IL_000e, IL_0015, IL_001a
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected I8, but got F4
		//IL_0010: Invalid comparison between Unknown and I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: ldloc 1 (out-of-bounds)*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static extern WebHeaderCollection smethod_120(WebClient webClient_0);

	static extern void smethod_121(WebHeaderCollection webHeaderCollection_0, HttpRequestHeader httpRequestHeader_0, string string_4);
}
