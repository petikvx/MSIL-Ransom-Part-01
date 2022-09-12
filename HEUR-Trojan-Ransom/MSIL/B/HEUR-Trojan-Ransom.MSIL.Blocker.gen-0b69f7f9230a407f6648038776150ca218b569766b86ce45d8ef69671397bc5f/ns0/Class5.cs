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

	private static extern void Main();

	private static extern void smethod_4();

	private static extern bool smethod_5();

	private static extern bool smethod_6();

	private static extern bool smethod_7();

	private static extern string smethod_8();

	private static extern void smethod_9();

	private static extern void smethod_10(object sender, FileSystemEventArgs e);

	private static extern void smethod_11();

	private static extern void smethod_12();

	public static extern bool smethod_13(string string_4);

	private unsafe static void smethod_14()
	{
		//Discarded unreachable code: IL_000d, IL_0012, IL_001a
		//IL_0015: Incompatible stack heights: 0 vs 1
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		byte num = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
		_ = ((ushort[])/*Error near IL_0002: Stack underflow*/)[num];
		_ = (ushort)(*(long*)(nint)/*Error near IL_0002: ldloc 1 (out-of-bounds)*/);
		_ = 5;
		/*Error near IL_0008: Invalid metadata token*/;
	}

	public extern Class5();

	static extern byte[] smethod_15(string string_4);

	static extern RijndaelManaged smethod_16();

	static extern void smethod_17(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern void smethod_18(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern Encoding smethod_19();

	unsafe static byte[] smethod_20(Encoding encoding_0, string string_4)
	{
		//Discarded unreachable code: IL_0022, IL_002b
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		while ((sbyte)/*Error near IL_0001: Stack underflow*/ <= -1421955880)
		{
		}
		checked
		{
			_ = (int)(-7.909837401403552E+28);
			/*Error near IL_0015: stloc 2 (out-of-bounds)*/;
			/*Error near IL_0016: stloc 3 (out-of-bounds)*/;
		}
		sbyte num = (sbyte)/*Error near IL_0018: Stack underflow*/;
		_ = *(short*)(int)checked((ushort)((double[])/*Error near IL_0019: Stack underflow*/)[num]);
		/*Error near IL_001c: ldarg 2 (out-of-bounds)*/;
		/*Error near IL_001d: Invalid metadata token*/;
	}

	static extern void smethod_21(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static void smethod_22(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_0017, IL_0018, IL_001d, IL_0023
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected I4, but got O
		_003F val;
		checked
		{
			ushort num = (ushort)unchecked(checked((long)unchecked((uint)checked((int)unchecked((ulong)(long)null)))) / /*Error near IL_0004: ldloca 0 (out-of-bounds)*/);
			val = unchecked(/*Error near IL_000a: Stack underflow*/ % num) * 7;
		}
		_ = /*Error near IL_000d: Stack underflow*/% val;
		_ = ((int[])(object)symmetricAlgorithm_0)[8];
		/*Error near IL_0012: Invalid metadata token*/;
	}

	static extern void smethod_23(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	static extern void smethod_24(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static extern byte[] smethod_25(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern byte[] smethod_26(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern ICryptoTransform smethod_27(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static extern byte[] smethod_28(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static extern Encoding smethod_29();

	static extern string smethod_30(Encoding encoding_0, byte[] byte_0);

	static extern void smethod_31(IDisposable idisposable_0);

	static extern RegistryKey smethod_32(RegistryKey registryKey_0, string string_4, RegistryKeyPermissionCheck registryKeyPermissionCheck_0);

	static extern RegistryKey smethod_33(RegistryKey registryKey_0, string string_4);

	static extern void smethod_34(RegistryKey registryKey_0, string string_4, object object_0, RegistryValueKind registryValueKind_0);

	static object smethod_35(RegistryKey registryKey_0, string string_4)
	{
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern Process smethod_36();

	static extern ProcessStartInfo smethod_37();

	static extern void smethod_38(ProcessStartInfo processStartInfo_0, string string_4);

	static extern void smethod_39(ProcessStartInfo processStartInfo_0, string string_4);

	static extern void smethod_40(ProcessStartInfo processStartInfo_0, bool bool_5);

	unsafe static void smethod_41(ProcessStartInfo processStartInfo_0, bool bool_5)
	{
		//Discarded unreachable code: IL_0006
		_ = *(double*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern void smethod_42(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static extern void smethod_43(ProcessStartInfo processStartInfo_0, bool bool_5);

	static extern void smethod_44(Process process_0, ProcessStartInfo processStartInfo_0);

	static bool smethod_45(Process process_0)
	{
		//Discarded unreachable code: IL_0006
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern StreamReader smethod_46(Process process_0);

	static extern string smethod_47(TextReader textReader_0);

	static extern bool smethod_48(string string_4, string string_5);

	static extern bool smethod_49(string string_4, string string_5);

	static extern bool smethod_50(StreamReader streamReader_0);

	static extern string smethod_51(string string_4);

	static extern Assembly smethod_52();

	static extern string smethod_53(Assembly assembly_0);

	static string smethod_54(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0005, IL_000d, IL_001a, IL_0020, IL_0025
		while (true)
		{
		}
	}

	static void smethod_55(string string_4, string string_5, bool bool_5)
	{
		//Discarded unreachable code: IL_0003, IL_000d
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Unknown opcode: 0xF8*/;
		}
	}

	static RegistryKey smethod_56(RegistryKey registryKey_0, string string_4, bool bool_5)
	{
		while (/*Error near IL_0006: Stack underflow*/ == /*Error near IL_0006: Stack underflow*/)
		{
		}
		registryKey_0 = (RegistryKey)/*Error near IL_0008: Stack underflow*/;
		/*Error: Unexpected end of block*/;
	}

	static extern void smethod_57(RegistryKey registryKey_0, string string_4, object object_0);

	static extern void smethod_58(string string_4, FileAttributes fileAttributes_0);

	static DialogResult smethod_59(string string_4, string string_5, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		//Discarded unreachable code: IL_0005, IL_000b
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_60(RegistryKey registryKey_0);

	static extern WindowsIdentity smethod_61();

	static extern WindowsPrincipal smethod_62(WindowsIdentity windowsIdentity_0);

	static extern bool smethod_63(WindowsPrincipal windowsPrincipal_0, WindowsBuiltInRole windowsBuiltInRole_0);

	static extern Rectangle smethod_64(Point point_0);

	static extern Bitmap smethod_65(int int_0, int int_1);

	static extern Graphics smethod_66(Image image_0);

	static void smethod_67(Graphics graphics_0, Point point_0, Point point_1, Size size_0)
	{
		//Discarded unreachable code: IL_0005, IL_0017, IL_001e, IL_0027, IL_002c, IL_002e, IL_0033, IL_0038, IL_003d
		//IL_0012: Invalid comparison between I4 and F8
		//IL_0019: Invalid comparison between Unknown and I8
		//IL_0022: Invalid comparison between I4 and Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static ImageFormat smethod_68()
	{
		//Discarded unreachable code: IL_0014, IL_0016, IL_001b
		//IL_000a: Invalid comparison between I4 and Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		while (/*Error near IL_0006: Stack underflow*/ <= /*Error near IL_0006: Stack underflow*/|| (byte)(short)/*Error near IL_0007: Stack underflow*/ == (int)/*Error near IL_0009: ldloc 1 (out-of-bounds)*/)
		{
		}
		/*Error near IL_000f: Invalid metadata token*/;
	}

	static extern void smethod_69(Image image_0, string string_4, ImageFormat imageFormat_0);

	unsafe static WebClient smethod_70()
	{
		//Discarded unreachable code: IL_0007, IL_000c, IL_0011, IL_0016, IL_001f
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Incompatible stack heights: 0 vs 1
		if ((int)/*Error near IL_0002: Stack underflow*/ != 0)
		{
			/*Error near IL_0002: Invalid metadata token*/;
		}
		checked
		{
			_ = (ushort)(*unchecked((uint*)(nint)/*Error near IL_0018: Stack underflow*/));
			/*Error near IL_001a: Invalid metadata token*/;
		}
	}

	static extern bool smethod_71(string string_4);

	static extern void smethod_72(string string_4);

	static extern void smethod_73(WebClient webClient_0, string string_4, string string_5);

	unsafe static void smethod_74(Process process_0)
	{
		//IL_0002: Expected native int or pointer, but got O
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		byte num;
		do
		{
			num = *(byte*)(nint)(*(object*)(nint)/*Error near IL_0002: Stack underflow*/);
		}
		while ((int)/*Error near IL_0009: Stack underflow*/ < (int)num);
		float num2 = *(float*)7;
		_ = /*Error near IL_000c: Stack underflow*/^ num2;
		/*Error near IL_000c: stloc 0 (out-of-bounds)*/;
		/*Error near IL_000f: Invalid metadata token*/;
	}

	static string smethod_75(string string_4)
	{
		//Discarded unreachable code: IL_0005, IL_000c, IL_0010, IL_0016, IL_001b, IL_001d, IL_002c
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected I4, but got F8
		//IL_0016: Incompatible stack heights: 0 vs 1
		//IL_001b: Incompatible stack heights: 1 vs 0
		while (true)
		{
		}
	}

	static extern string[] smethod_76(string string_4, char[] char_0);

	unsafe static string smethod_77(WebClient webClient_0, string string_4)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Incompatible stack heights: 0 vs 1
		//IL_000a: Expected I8, but got F8
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		double num2;
		checked
		{
			if (/*Error near IL_0002: Stack underflow*/ != /*Error near IL_0002: Stack underflow*/)
			{
				ulong num = (ulong)/*Error near IL_0003: Stack underflow*/;
				_003F val = /*Error near IL_0004: Stack underflow*/>> unchecked((int)num);
				_ = null;
				/*Error near IL_0005: stloc 2 (out-of-bounds)*/;
				_ = (long)val;
			}
			num2 = (double)/*Error near IL_0009: Stack underflow*/;
		}
		*(long*)(nint)/*Error near IL_000a: Stack underflow*/ = (long)num2;
		_ = ~/*Error near IL_000c: Stack underflow*/;
		/*Error: Unexpected end of block*/;
	}

	static extern string smethod_78();

	static extern string smethod_79();

	static extern string smethod_80(string[] string_4);

	static void smethod_81(int int_0)
	{
		//Discarded unreachable code: IL_001e, IL_0028, IL_002e, IL_0034
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0013: Invalid comparison between Unknown and I
		//IL_0013: Incompatible stack heights: 0 vs 1
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
			{
				_ = ((Array)checked(/*Error near IL_0006: Stack underflow*/ + /*Error near IL_0006: Stack underflow*/)).LongLength;
				if ((nint)/*Error near IL_0007: ldloca 0 (out-of-bounds)*/ != (nint)6)
				{
					break;
				}
			}
		}
		_ = 2;
		/*Error near IL_0019: Invalid metadata token*/;
	}

	static extern Process[] smethod_82();

	static string smethod_83(Process process_0)
	{
		//Discarded unreachable code: IL_0006, IL_000e
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern void smethod_84(Process process_0);

	static extern Process smethod_85();

	static extern IntPtr smethod_86(Process process_0);

	static extern ManagementObjectSearcher smethod_87(string string_4);

	static extern ManagementObjectCollection smethod_88(ManagementObjectSearcher managementObjectSearcher_0);

	static ManagementObjectEnumerator smethod_89(ManagementObjectCollection managementObjectCollection_0)
	{
		//Discarded unreachable code: IL_0006
		while (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
		{
		}
		/*Error near IL_0005: Unknown opcode: 0xFF*/;
	}

	static extern ManagementBaseObject smethod_90(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern object smethod_91(ManagementBaseObject managementBaseObject_0, string string_4);

	static extern string smethod_92(object object_0);

	static extern string smethod_93(string string_4);

	static bool smethod_94(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_000d, IL_0012, IL_001c, IL_0023, IL_002b, IL_0031, IL_0038
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected F8, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		_003F val;
		do
		{
			val = /*Error near IL_0003: Stack underflow*/% /*Error near IL_0003: Stack underflow*/;
		}
		while ((int)/*Error near IL_0009: Stack underflow*/ < (int)(byte)val);
		checked
		{
			_ = (ushort)(/*Error near IL_000a: Stack underflow*/ + /*Error near IL_000a: Stack underflow*/);
			_ = 5;
			/*Error near IL_000c: Unknown opcode: 0xFD*/;
		}
	}

	static string smethod_95(string string_4)
	{
		//Discarded unreachable code: IL_000c, IL_0014, IL_001a, IL_0021, IL_002a
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected I8, but got I4
		while (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
		}
		/*Error near IL_0007: Invalid metadata token*/;
	}

	static bool smethod_96(string string_4, string string_5)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		while (true)
		{
			if (checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/) <= (int)checked((byte)(object)string_4))
			{
				/*Error: Could not find block for branch target IL_0009*/;
			}
		}
	}

	static bool smethod_97(ManagementObjectEnumerator managementObjectEnumerator_0)
	{
		//Discarded unreachable code: IL_0007, IL_000d, IL_0016
		//IL_0002: Incompatible stack heights: 0 vs 1
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			((long[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (long)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: ldloc 1 (out-of-bounds)*/;
		}
	}

	static extern NetworkInterface[] smethod_98();

	static extern OperationalStatus smethod_99(NetworkInterface networkInterface_0);

	static extern PhysicalAddress smethod_100(NetworkInterface networkInterface_0);

	static string smethod_101(string string_4, string string_5, string string_6)
	{
		//Discarded unreachable code: IL_0005, IL_0008, IL_000d, IL_0014, IL_0019, IL_0024, IL_002b, IL_0030, IL_0032, IL_0037
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	unsafe static string smethod_102(string string_4, char[] char_0)
	{
		//Discarded unreachable code: IL_0009, IL_0010, IL_0015, IL_0017, IL_001c, IL_0026, IL_002e
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected I, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		*(_003F*)(nint)/*Error near IL_0002: Stack underflow*/ = /*Error near IL_0002: Stack underflow*/;
		checked
		{
			_ = /*Error near IL_0004: Stack underflow*/* 7;
			/*Error near IL_0004: Invalid metadata token*/;
		}
	}

	static extern FileSystemWatcher smethod_103();

	static extern string smethod_104(Environment.SpecialFolder specialFolder_0);

	static extern void smethod_105(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static extern void smethod_106(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0);

	static void smethod_107(FileSystemWatcher fileSystemWatcher_1, string string_4)
	{
		//Discarded unreachable code: IL_0002, IL_0006, IL_0010, IL_0012, IL_0017, IL_001f, IL_0022, IL_0026
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Incompatible stack heights: 0 vs 1
		//IL_0024: Incompatible stack heights: 0 vs 2
		/*Error near IL_0001: Unknown opcode: 0xFF*/;
	}

	static extern void smethod_108(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0);

	static extern void smethod_109(FileSystemWatcher fileSystemWatcher_1, bool bool_5);

	static bool smethod_110(string string_4, string string_5)
	{
		return (byte)(int)/*OpCode not supported: Nop*/ != 0;
	}

	static extern bool smethod_111(string string_4);

	static extern string[] smethod_112(string string_4, string string_5);

	static extern Match smethod_113(string string_4, string string_5);

	static extern WebHeaderCollection smethod_114(WebClient webClient_0);

	static extern void smethod_115(WebHeaderCollection webHeaderCollection_0, HttpRequestHeader httpRequestHeader_0, string string_4);

	static extern byte[] smethod_116(string string_4);

	static extern Encoding smethod_117();

	static extern int smethod_118(string string_4, string string_5);

	static extern string smethod_119(string string_4, int int_0, int int_1);

	static extern string smethod_120(string string_4, int int_0, string string_5);

	static void smethod_121(string string_4, byte[] byte_0)
	{
		//Discarded unreachable code: IL_001b, IL_0022, IL_0023, IL_002b, IL_0030
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_0032: Expected native int or pointer, but got O
		//IL_0033: Expected native int or pointer, but got F4
		ushort num;
		do
		{
			_003F val = checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
			num = ((ushort[])/*Error near IL_0002: Stack underflow*/)[val];
		}
		while ((int)/*Error near IL_0007: Stack underflow*/ > (int)num);
		ushort num2 = ((ushort[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/];
		((long[])/*Error near IL_0013: Stack underflow*/)[num2] = -7445264533515712808L;
		/*OpCode not supported: Ckfinite*/;
		/*Error near IL_0016: Invalid metadata token*/;
	}
}
