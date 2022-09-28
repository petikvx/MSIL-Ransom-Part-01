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

	public static string smethod_0(string string_4)
	{
		//Discarded unreachable code: IL_0022, IL_002c
		//IL_0002: Invalid comparison between Unknown and I
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between I4 and F8
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Incompatible stack heights: 0 vs 1
		//IL_0032: Invalid comparison between Unknown and I4
		while (true)
		{
			nint num = (nint)/*Error near IL_0001: Stack underflow*/;
			if ((nint)/*Error near IL_0007: Stack underflow*/ > num)
			{
				continue;
			}
			_003F val = /*Error near IL_0009: Stack underflow*/- /*Error near IL_0009: Stack underflow*/;
			if (/*Error near IL_000b: Stack underflow*/ > val)
			{
				if (!((double)(int)checked((uint)/*Error near IL_000d: Stack underflow*/) >= 2.9134572707604338E+125))
				{
					break;
				}
				continue;
			}
			sbyte num2 = ((sbyte[])/*Error near IL_0032: Stack underflow*/)[/*Error near IL_0032: Stack underflow*/];
			if ((int)/*Error near IL_0037: Stack underflow*/ > (int)num2)
			{
				/*Error: Could not find block for branch target IL_0037*/;
			}
		}
		/*Error near IL_001d: Invalid metadata token*/;
	}

	private static extern void Main();

	private static extern void smethod_1();

	private static extern bool smethod_2();

	private static bool smethod_3()
	{
		//Discarded unreachable code: IL_0011, IL_001f, IL_0025
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Incompatible stack heights: 0 vs 1
		//IL_001a: Expected native int or pointer, but got F8
		while (true)
		{
			_ = (long)/*Error near IL_0001: Stack underflow*/ + checked(3 + /*Error near IL_0002: ldarg 3 (out-of-bounds)*/);
			_ = 1596595988;
			/*Error near IL_000b: stloc 1 (out-of-bounds)*/;
		}
	}

	private static extern bool smethod_4();

	private static string smethod_5()
	{
		//Discarded unreachable code: IL_0003
		//IL_0006: Expected O, but got F8
		long num = checked((long)/*Error near IL_0001: Stack underflow*/);
		_ = ((int[])/*Error near IL_0002: Stack underflow*/)[num];
		/*Error near IL_0002: Unknown opcode: 0xF9*/;
	}

	private static extern void smethod_6();

	private static void smethod_7(object sender, FileSystemEventArgs e)
	{
		//Discarded unreachable code: IL_000a
		//IL_000f: Expected O, but got Unknown
		while (true)
		{
		}
	}

	private static extern void smethod_8();

	private static extern void smethod_9();

	public static extern bool smethod_10(string string_4);

	private static extern void smethod_11();

	public extern Class5();

	static Class5()
	{
		//Discarded unreachable code: IL_0006, IL_000d, IL_0013, IL_001a
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern byte[] smethod_12(string string_4);

	unsafe static RijndaelManaged smethod_13()
	{
		//Discarded unreachable code: IL_0011, IL_0018, IL_001d, IL_0027
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got I4
		while (/*Error near IL_0006: Stack underflow*/ < /*Error near IL_0006: Stack underflow*/|| /*Error near IL_000b: Stack underflow*/>= /*Error near IL_000b: Stack underflow*/)
		{
		}
		*(_003F*)(nint)/*Error near IL_000c: Stack underflow*/ = /*Error near IL_000c: Stack underflow*/;
		/*Error near IL_000c: Invalid metadata token*/;
	}

	static extern void smethod_14(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern void smethod_15(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern Encoding smethod_16();

	static extern byte[] smethod_17(Encoding encoding_0, string string_4);

	static extern void smethod_18(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_19(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_20(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	static extern void smethod_21(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static extern byte[] smethod_22(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern byte[] smethod_23(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern ICryptoTransform smethod_24(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static extern byte[] smethod_25(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static extern Encoding smethod_26();

	static extern string smethod_27(Encoding encoding_0, byte[] byte_0);

	static extern void smethod_28(IDisposable idisposable_0);

	static extern string smethod_29(string string_4);

	static extern Assembly smethod_30();

	static extern string smethod_31(Assembly assembly_0);

	static extern string smethod_32(string string_4, string string_5);

	static extern void smethod_33(string string_4, string string_5, bool bool_5);

	static RegistryKey smethod_34(RegistryKey registryKey_0, string string_4, bool bool_5)
	{
		//Discarded unreachable code: IL_0008, IL_0009, IL_0010, IL_0015, IL_001d, IL_002b, IL_0030, IL_0035
		//IL_000b: Expected I8, but got I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unsupported input type for neg.
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected native int or pointer, but got O
		checked
		{
			_ = (uint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	static extern void smethod_35(RegistryKey registryKey_0, string string_4, object object_0);

	static extern DialogResult smethod_36(string string_4, string string_5, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0);

	static RegistryKey smethod_37(RegistryKey registryKey_0, string string_4)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected I4, but got I8
		switch ((ulong)(double)(~(/*Error near IL_0003: Stack underflow*/ / 2)))
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static extern void smethod_38(RegistryKey registryKey_0);

	static Rectangle smethod_39(Point point_0)
	{
		//Discarded unreachable code: IL_0010, IL_0016, IL_0017
		//IL_0006: Invalid comparison between Unknown and I4
		//IL_0012: Expected O, but got I8
		//IL_0018: Invalid comparison between Unknown and I4
		uint num2;
		do
		{
			((double[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (double)/*Error near IL_0002: Stack underflow*/;
			long num = checked((long)(ulong)/*Error near IL_0003: Stack underflow*/);
			num2 = ((uint[])/*Error near IL_0005: Stack underflow*/)[num];
		}
		while ((int)/*Error near IL_000b: Stack underflow*/ >= (int)num2);
		/*Error near IL_000b: Invalid metadata token*/;
	}

	static extern Bitmap smethod_40(int int_0, int int_1);

	static Graphics smethod_41(Image image_0)
	{
		while (true)
		{
		}
	}

	unsafe static void smethod_42(Graphics graphics_0, Point point_0, Point point_1, Size size_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected I8, but got Unknown
		//IL_0015: Invalid comparison between Unknown and O
		//IL_001b: Invalid comparison between Unknown and O
		while (true)
		{
			checked
			{
				_ = (long)unchecked(/*Error near IL_0003: Stack underflow*/ - size_0);
				/*Error near IL_0004: stloc 3 (out-of-bounds)*/;
			}
			_003F val = /*Error near IL_0006: Stack underflow*/% /*Error near IL_0006: Stack underflow*/;
			((long[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (long)val;
			if (/*Error near IL_000e: Stack underflow*/ > /*Error near IL_000e: Stack underflow*/)
			{
				*(_003F*)(nint)/*Error near IL_0013: Stack underflow*/ = /*Error near IL_0013: Stack underflow*/;
				if (/*Error near IL_001a: Stack underflow*/ <= point_0 && /*Error near IL_0020: Stack underflow*/<= size_0)
				{
					/*Error: Could not find block for branch target IL_0020*/;
				}
			}
		}
	}

	static extern ImageFormat smethod_43();

	static extern void smethod_44(Image image_0, string string_4, ImageFormat imageFormat_0);

	static WebClient smethod_45()
	{
		_003F val;
		do
		{
			val = /*Error: ldarg 1 (out-of-bounds)*/;
		}
		while (/*Error near IL_0006: Stack underflow*/ <= val || /*Error near IL_000b: Stack underflow*/< /*Error near IL_000b: Stack underflow*/);
		checked
		{
			_ = (uint)/*Error near IL_000c: Stack underflow*/;
			/*Error near IL_000c: ldloc 1 (out-of-bounds)*/;
			/*Error: Unexpected end of block*/;
		}
	}

	static extern bool smethod_46(string string_4);

	static extern void smethod_47(string string_4);

	static void smethod_48(WebClient webClient_0, string string_4, string string_5)
	{
		//Discarded unreachable code: IL_000a
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nint)(/*Error near IL_0002: Stack underflow*/ >> unchecked((int)/*Error near IL_0002: Stack underflow*/));
			/*Error near IL_0003: ldloc 0 (out-of-bounds)*/;
			/*Error near IL_0005: Invalid metadata token*/;
		}
	}

	static extern Process smethod_49();

	static extern ProcessStartInfo smethod_50();

	static extern void smethod_51(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	unsafe static void smethod_52(ProcessStartInfo processStartInfo_0, string string_4)
	{
		//IL_0001: Ignored invalid 'unaligned' prefix
		_ = *(float*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unexpected end of body*/;
	}

	static extern void smethod_53(Process process_0, ProcessStartInfo processStartInfo_0);

	static extern bool smethod_54(Process process_0);

	static void smethod_55(Process process_0)
	{
		//Discarded unreachable code: IL_0005, IL_000d, IL_0012, IL_001c, IL_0021
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
		}
	}

	static extern string smethod_56(string string_4);

	static extern string[] smethod_57(string string_4, char[] char_0);

	static extern string smethod_58(WebClient webClient_0, string string_4);

	static extern string smethod_59();

	static extern string smethod_60();

	static extern string smethod_61(string[] string_4);

	static extern void smethod_62(int int_0);

	static extern Process[] smethod_63();

	static extern string smethod_64(Process process_0);

	static void smethod_65(Process process_0)
	{
		//Discarded unreachable code: IL_0009, IL_0015
		while (true)
		{
			_ = (double)process_0;
			/*Error near IL_0003: stloc 1 (out-of-bounds)*/;
		}
	}

	static extern Process smethod_66();

	static extern IntPtr smethod_67(Process process_0);

	static ManagementObjectSearcher smethod_68(string string_4)
	{
		//Discarded unreachable code: IL_0005, IL_000b, IL_001e, IL_0027, IL_0029, IL_002f, IL_003b
		//IL_0006: Invalid comparison between Unknown and I4
		//IL_001a: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected F8, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected native int or pointer, but got F8
		while (true)
		{
		}
	}

	static ManagementObjectCollection smethod_69(ManagementObjectSearcher managementObjectSearcher_0)
	{
		//Discarded unreachable code: IL_0005, IL_000e, IL_0010, IL_0016
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected F8, but got I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static extern ManagementObjectEnumerator smethod_70(ManagementObjectCollection managementObjectCollection_0);

	static extern ManagementBaseObject smethod_71(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern object smethod_72(ManagementBaseObject managementBaseObject_0, string string_4);

	static extern string smethod_73(object object_0);

	static string smethod_74(string string_4)
	{
		((int[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (int)/*Error near IL_0001: Stack underflow*/;
		switch (/*Error near IL_0006: Stack underflow*/)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static extern bool smethod_75(string string_4, string string_5);

	static extern string smethod_76(string string_4);

	static extern bool smethod_77(string string_4, string string_5);

	static extern bool smethod_78(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern NetworkInterface[] smethod_79();

	static extern OperationalStatus smethod_80(NetworkInterface networkInterface_0);

	static extern PhysicalAddress smethod_81(NetworkInterface networkInterface_0);

	static extern string smethod_82(string string_4, string string_5, string string_6);

	static extern string smethod_83(string string_4, char[] char_0);

	static extern FileSystemWatcher smethod_84();

	static extern string smethod_85(Environment.SpecialFolder specialFolder_0);

	static extern void smethod_86(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static extern void smethod_87(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0);

	static extern void smethod_88(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static void smethod_89(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0)
	{
		//Discarded unreachable code: IL_0007, IL_000e, IL_0016, IL_0018, IL_001e, IL_0024, IL_002f, IL_0036
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected I4, but got I8
		//IL_0019: Invalid comparison between Unknown and I
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0031: Expected F4, but got I4
		while (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
		{
		}
		_ = /*Error near IL_0006: Stack underflow*/& /*Error near IL_0006: Stack underflow*/;
		/*Error near IL_0006: Unknown opcode: 0xF9*/;
	}

	static extern void smethod_90(FileSystemWatcher fileSystemWatcher_1, bool bool_5);

	static extern bool smethod_91(string string_4, string string_5);

	static extern bool smethod_92(string string_4);

	static extern string[] smethod_93(string string_4, string string_5);

	static extern Match smethod_94(string string_4, string string_5);

	static extern WebHeaderCollection smethod_95(WebClient webClient_0);

	static void smethod_96(WebHeaderCollection webHeaderCollection_0, HttpRequestHeader httpRequestHeader_0, string string_4)
	{
		//Discarded unreachable code: IL_0006, IL_000c, IL_0013, IL_0018
		//IL_000e: Incompatible stack heights: 0 vs 1
		_ = ((Array)/*Error near IL_0001: Stack underflow*/).LongLength;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static byte[] smethod_97(string string_4)
	{
		//Discarded unreachable code: IL_0005, IL_000b
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
		}
	}

	static extern Encoding smethod_98();

	static extern int smethod_99(string string_4, string string_5);

	static extern string smethod_100(string string_4, int int_0, int int_1);

	static extern string smethod_101(string string_4, int int_0, string string_5);

	static void smethod_102(string string_4, byte[] byte_0)
	{
		_ = ((byte[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/];
		/*Error near IL_0002: Invalid metadata token*/;
	}
}
