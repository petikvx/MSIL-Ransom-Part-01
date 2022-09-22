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

	private static extern void Main();

	private static extern void smethod_1();

	private static bool smethod_2()
	{
		_ = 1681162960465491927L;
		/*Error near IL_0009: Invalid metadata token*/;
	}

	private static extern bool smethod_3();

	private static extern bool smethod_4();

	private static extern string smethod_5();

	private static extern void smethod_6();

	private static extern void smethod_7(object sender, FileSystemEventArgs e);

	public unsafe Class5()
	{
		//Discarded unreachable code: IL_0008, IL_000f, IL_0013, IL_001f
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between I and F4
		//IL_0020: Incompatible stack heights: 1 vs 0
		short num = (short)/*Error: ldloc 1 (out-of-bounds)*/;
		_ = null;
		/*Error near IL_0003: stloc 0 (out-of-bounds)*/;
		_ = *(byte*)num;
		/*Error near IL_0007: Unknown opcode: 0xFD*/;
	}

	static extern byte[] smethod_8(string string_4);

	static extern RijndaelManaged smethod_9();

	static extern void smethod_10(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static void smethod_11(SymmetricAlgorithm symmetricAlgorithm_0, int int_0)
	{
		//Discarded unreachable code: IL_0005
		/*Error: Invalid metadata token*/;
	}

	static extern Encoding smethod_12();

	static extern byte[] smethod_13(Encoding encoding_0, string string_4);

	static extern void smethod_14(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_15(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_16(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	static extern void smethod_17(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static extern byte[] smethod_18(SymmetricAlgorithm symmetricAlgorithm_0);

	static byte[] smethod_19(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		//Discarded unreachable code: IL_000b, IL_0010
		while (true)
		{
			/*Error: stloc 1 (out-of-bounds)*/;
		}
	}

	static ICryptoTransform smethod_20(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1)
	{
		do
		{
			((IntPtr[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (IntPtr)/*Error near IL_0002: Stack underflow*/;
		}
		while (/*Error near IL_0008: Stack underflow*/ > /*Error near IL_0008: Stack underflow*/|| /*Error near IL_000d: Stack underflow*/< /*Error near IL_000d: Stack underflow*/);
		/*Error near IL_000d: Invalid metadata token*/;
	}

	static extern byte[] smethod_21(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static extern Encoding smethod_22();

	static extern string smethod_23(Encoding encoding_0, byte[] byte_0);

	static extern void smethod_24(IDisposable idisposable_0);

	static extern string smethod_25(string string_4);

	static extern Assembly smethod_26();

	static extern string smethod_27(Assembly assembly_0);

	static extern string smethod_28(string string_4, string string_5);

	static extern void smethod_29(string string_4, string string_5, bool bool_5);

	static extern RegistryKey smethod_30(RegistryKey registryKey_0, string string_4, bool bool_5);

	static extern void smethod_31(RegistryKey registryKey_0, string string_4, object object_0);

	static extern void smethod_32(string string_4, FileAttributes fileAttributes_0);

	static DialogResult smethod_33(string string_4, string string_5, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		//Discarded unreachable code: IL_000d, IL_0014, IL_001c
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got I4
		//IL_0008: Unsupported input type for neg.
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		int num = checked((int)/*Error near IL_0001: Stack underflow*/);
		string_4 = (string)(byte)checked(/*Error near IL_0004: Stack underflow*/ - num);
		_ = 0 - /*Error near IL_0009: Stack underflow*/;
		/*Error near IL_000c: Unknown opcode: 0xFD*/;
	}

	static extern Rectangle smethod_34(Point point_0);

	unsafe static Bitmap smethod_35(int int_0, int int_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected native int or pointer, but got O
		_003F val = /*Error near IL_0001: Stack underflow*// /*Error near IL_0001: Stack underflow*/;
		_ = *(double*)(nint)((object[])/*Error near IL_0002: Stack underflow*/)[val];
		/*Error near IL_0005: Invalid metadata token*/;
	}

	static extern Graphics smethod_36(Image image_0);

	static void smethod_37(Graphics graphics_0, Point point_0, Point point_1, Size size_0)
	{
		//IL_0001: Invalid comparison between Unknown and I
		nuint num;
		do
		{
			num = checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
		while ((nint)/*Error near IL_0006: Stack underflow*/ == (nint)num);
		checked
		{
			_ = (int)/*Error near IL_0007: Stack underflow*/;
		}
	}

	static extern ImageFormat smethod_38();

	static void smethod_39(Image image_0, string string_4, ImageFormat imageFormat_0)
	{
		/*Error: Invalid metadata token*/;
	}

	static extern WebClient smethod_40();

	static extern bool smethod_41(string string_4);

	static void smethod_42(string string_4)
	{
		//Discarded unreachable code: IL_0008
		/*Error near IL_0001: ldloca 0 (out-of-bounds)*/;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static extern void smethod_43(WebClient webClient_0, string string_4, string string_5);

	static extern Process smethod_44();

	static extern ProcessStartInfo smethod_45();

	static void smethod_46(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0)
	{
		//Discarded unreachable code: IL_0007, IL_000c, IL_0013, IL_0014, IL_0019, IL_0023, IL_002a
		//IL_001d: Expected O, but got I4
		//IL_001e: Invalid comparison between Unknown and I
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		_ = ((IntPtr[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static void smethod_47(ProcessStartInfo processStartInfo_0, string string_4)
	{
		//Discarded unreachable code: IL_0005, IL_000f, IL_0016
		//IL_0009: Expected O, but got I4
		//IL_000a: Invalid comparison between Unknown and I
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_48(Process process_0, ProcessStartInfo processStartInfo_0);

	static extern bool smethod_49(Process process_0);

	static extern void smethod_50(Process process_0);

	static extern string smethod_51(string string_4);

	static extern string[] smethod_52(string string_4, char[] char_0);

	static extern string smethod_53(WebClient webClient_0, string string_4);

	static extern string smethod_54();

	static extern string smethod_55();

	static string smethod_56(string[] string_4)
	{
		//Discarded unreachable code: IL_0006, IL_0007, IL_000d, IL_0012, IL_0018, IL_0021
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		((double[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (double)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static void smethod_57(int int_0)
	{
		//Discarded unreachable code: IL_0005, IL_000c
		/*Error: Invalid metadata token*/;
	}

	static Process[] smethod_58()
	{
		//Discarded unreachable code: IL_0006, IL_000f, IL_0019, IL_001e, IL_002b, IL_0032
		//IL_000d: Expected F8, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I8
		//IL_0027: Expected O, but got I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		_ = 3;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern string smethod_59(Process process_0);

	static extern void smethod_60(Process process_0);

	unsafe static Process smethod_61()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected I8, but got Unknown
		do
		{
			int num = *(int*)(nint)/*Error near IL_0001: Stack underflow*/;
			_003F val = /*Error near IL_0002: Stack underflow*// num;
			((long[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (long)val;
			/*OpCode not supported: DebugBreak*/;
		}
		while (/*Error near IL_0009: Stack underflow*/ > /*Error near IL_0009: Stack underflow*/|| /*Error near IL_000e: Stack underflow*/> /*Error near IL_000e: Stack underflow*/|| /*Error near IL_0013: Stack underflow*/!= /*Error near IL_0013: Stack underflow*/);
		/*Error near IL_0014: Invalid metadata token*/;
	}

	static extern IntPtr smethod_62(Process process_0);

	static extern ManagementObjectSearcher smethod_63(string string_4);

	static ManagementObjectCollection smethod_64(ManagementObjectSearcher managementObjectSearcher_0)
	{
		//Discarded unreachable code: IL_000b, IL_000c, IL_0012, IL_0017
		while (true)
		{
			_003F val = /*Error: ldarg 2 (out-of-bounds)*/;
			if (/*Error near IL_0006: Stack underflow*/ < val)
			{
			}
		}
	}

	static extern ManagementObjectEnumerator smethod_65(ManagementObjectCollection managementObjectCollection_0);

	static extern ManagementBaseObject smethod_66(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern object smethod_67(ManagementBaseObject managementBaseObject_0, string string_4);

	static extern string smethod_68(object object_0);

	static extern string smethod_69(string string_4);

	static extern bool smethod_70(string string_4, string string_5);

	static extern string smethod_71(string string_4);

	static bool smethod_72(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0006, IL_0014, IL_001b, IL_0020, IL_0027
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		_ = 5;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern bool smethod_73(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern NetworkInterface[] smethod_74();

	static OperationalStatus smethod_75(NetworkInterface networkInterface_0)
	{
		while (true)
		{
			((long[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (long)/*Error near IL_0003: Stack underflow*/;
			if (/*Error near IL_0008: Stack underflow*/ <= /*Error near IL_0008: Stack underflow*/)
			{
				/*Error: Could not find block for branch target IL_0008*/;
			}
		}
	}

	static extern PhysicalAddress smethod_76(NetworkInterface networkInterface_0);

	static extern string smethod_77(string string_4, string string_5, string string_6);

	static extern string smethod_78(string string_4, char[] char_0);

	static extern FileSystemWatcher smethod_79();

	static extern string smethod_80(Environment.SpecialFolder specialFolder_0);

	unsafe static void smethod_81(FileSystemWatcher fileSystemWatcher_1, string string_4)
	{
		//Discarded unreachable code: IL_001a, IL_0027, IL_0030, IL_0037, IL_003a
		//IL_0005: Expected F8, but got I4
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected I4, but got Unknown
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_0032: Invalid comparison between Unknown and I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected F8, but got Unknown
		//IL_003f: Invalid comparison between Unknown and I8
		ushort num = ((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		*(double*)(nint)/*Error near IL_0005: Stack underflow*/ = num - 2;
		nuint num2 = checked((nuint)(6 & 5f));
		byte num3 = *(byte*)(nint)(/*Error near IL_000f: Stack underflow*/ ^ num2);
		/*OpCode not supported: Ckfinite*/;
		_003F val = /*Error near IL_0014: Stack underflow*/| num3;
		((int[])/*Error near IL_0015: Stack underflow*/)[/*Error near IL_0015: Stack underflow*/] = (int)val;
		/*Error near IL_0015: Invalid metadata token*/;
	}

	static extern void smethod_82(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0);

	static void smethod_83(FileSystemWatcher fileSystemWatcher_1, string string_4)
	{
		//Discarded unreachable code: IL_000f, IL_0019
		//IL_0007: Invalid comparison between Unknown and I
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected F8, but got Unknown
		//IL_0014: Invalid comparison between Unknown and I8
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
			{
				nint num = checked((nint)/*Error near IL_0007: Stack underflow*/);
				if ((nint)/*Error near IL_000c: Stack underflow*/ <= num)
				{
					break;
				}
			}
		}
		_ = ((float[])/*Error near IL_000e: Stack underflow*/)[/*Error near IL_000e: Stack underflow*/];
		/*Error near IL_000e: Unknown opcode: 0xFD*/;
	}

	static extern void smethod_84(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0);

	unsafe static void smethod_85(FileSystemWatcher fileSystemWatcher_1, bool bool_5)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		long num = checked((long)/*Error near IL_0001: Stack underflow*/);
		_ = /*Error near IL_0002: Stack underflow*/% num;
		_ = *(short*)(nint)/*Error near IL_0003: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0005: Invalid metadata token*/;
	}

	static extern bool smethod_86(string string_4, string string_5);
}
