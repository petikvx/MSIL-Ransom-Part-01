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

	private static extern string smethod_1();

	private static extern void Main();

	private static void smethod_2()
	{
		//Discarded unreachable code: IL_0003, IL_0008, IL_000d, IL_0014, IL_0023, IL_002d, IL_0035
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		//IL_001c: Expected F8, but got I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got I4
		int num = (int)/*Error near IL_0001: Stack underflow*/;
		_ = /*Error near IL_0002: Stack underflow*/& num;
		/*Error near IL_0002: Unknown opcode: 0xFB*/;
	}

	private static extern bool smethod_3();

	private static extern bool smethod_4();

	private static extern bool smethod_5();

	private static extern string smethod_6();

	private static extern void smethod_7();

	private static extern void smethod_8(object sender, FileSystemEventArgs e);

	private static extern void smethod_9();

	private static void smethod_10()
	{
		//Discarded unreachable code: IL_0006, IL_0010, IL_0015
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected I4, but got Unknown
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	public static extern bool smethod_11(string string_4);

	public Class5()
	{
		//Discarded unreachable code: IL_0005, IL_000c, IL_0011, IL_0020
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		/*Error: Invalid metadata token*/;
	}

	static extern byte[] smethod_12(string string_4);

	static extern RijndaelManaged smethod_13();

	static void smethod_14(SymmetricAlgorithm symmetricAlgorithm_0, int int_0)
	{
		//Discarded unreachable code: IL_000a, IL_0011
		//IL_000c: Invalid comparison between Unknown and I4
		while (/*Error near IL_0005: Stack underflow*/ == /*Error near IL_0005: Stack underflow*/)
		{
		}
		/*Error near IL_0005: Invalid metadata token*/;
	}

	static extern void smethod_15(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	unsafe static Encoding smethod_16()
	{
		return *(Encoding*)(nint)/*Error: ldarg 1 (out-of-bounds)*/;
	}

	unsafe static byte[] smethod_17(Encoding encoding_0, string string_4)
	{
		//Discarded unreachable code: IL_0016, IL_0025, IL_002f, IL_003a, IL_0040, IL_0048
		//IL_0003: Expected F4, but got I4
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected F4, but got I8
		//IL_0020: Incompatible stack heights: 0 vs 2
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Incompatible stack heights: 0 vs 1
		//IL_003b: Invalid comparison between Unknown and I
		while (true)
		{
			sbyte num = (sbyte)/*Error near IL_0001: Stack underflow*/;
			*(float*)(nint)/*Error near IL_0003: Stack underflow*/ = num;
			float num2 = (float)/*Error near IL_0004: Stack underflow*/;
			long num3 = /*Error near IL_0005: Stack underflow*/>> (int)num2;
			if (((long[])/*Error near IL_0008: Stack underflow*/)[num3] != 0L)
			{
				_003F val = /*Error near IL_000e: Stack underflow*/<< (int)/*Error near IL_000e: Stack underflow*/;
				if (/*Error near IL_0014: Stack underflow*/ > val)
				{
					break;
				}
			}
		}
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0015: Unknown opcode: 0xFB*/;
	}

	unsafe static void smethod_18(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
	{
		//IL_0006: Incompatible stack heights: 0 vs 2
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			_ = (byte)/*Error near IL_0001: Stack underflow*/;
			_ = 8;
			if (checked((nint)/*Error near IL_0004: ldloc 2 (out-of-bounds)*/) != 0)
			{
				/*Error near IL_000b: stloc 0 (out-of-bounds)*/;
				short num = *(short*)checked((sbyte)/*Error near IL_000d: Stack underflow*/);
				_003F val = checked(/*Error near IL_0010: Stack underflow*/ - num);
				if (/*Error near IL_0015: Stack underflow*/ != val)
				{
					break;
				}
			}
		}
		/*Error: Unexpected end of block*/;
	}

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

	static extern WebClient smethod_30();

	static extern string smethod_31(string string_4, string string_5);

	static void smethod_32(WebClient webClient_0, string string_4, string string_5)
	{
		//Discarded unreachable code: IL_001f, IL_0024, IL_0036, IL_003b
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Incompatible stack heights: 0 vs 1
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ != 0)
			{
				_003F val = /*Error near IL_0007: Stack underflow*/>> (int)/*Error near IL_0007: Stack underflow*/;
				_ = /*Error near IL_000a: Stack underflow*/^ val;
				if ("" == null)
				{
					break;
				}
			}
		}
		checked
		{
			_ = (short)unchecked((nint)/*Error near IL_0018: Stack underflow*/);
			/*Error near IL_001a: Invalid metadata token*/;
		}
	}

	static extern void smethod_33(Component component_0);

	static extern Process smethod_34();

	unsafe static ProcessStartInfo smethod_35()
	{
		do
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		}
		while (/*Error near IL_0006: Stack underflow*/ <= /*Error near IL_0006: Stack underflow*/);
		_ = ((long[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/];
		/*Error near IL_0007: Invalid metadata token*/;
	}

	static extern void smethod_36(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static void smethod_37(ProcessStartInfo processStartInfo_0, string string_4)
	{
		//Discarded unreachable code: IL_000c, IL_0013, IL_0019, IL_001f, IL_0022
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0027: Invalid comparison between Unknown and I8
		while (true)
		{
			ushort num = ((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			if ((int)/*Error near IL_0007: Stack underflow*/ < (int)num)
			{
			}
		}
	}

	static extern string smethod_38(string string_4, string string_5, string string_6);

	unsafe static void smethod_39(ProcessStartInfo processStartInfo_0, string string_4)
	{
		checked
		{
			_ = (long)(*unchecked((ushort*)checked((long)/*Error near IL_0002: Stack underflow*/)));
			/*Error: Unexpected end of block*/;
		}
	}

	static extern void smethod_40(Process process_0, ProcessStartInfo processStartInfo_0);

	unsafe static bool smethod_41(Process process_0)
	{
		//Discarded unreachable code: IL_0007, IL_000c, IL_0018, IL_001e, IL_0025
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		float num = *(float*)(nint)/*Error near IL_0001: Stack underflow*/;
		_ = /*Error near IL_0002: Stack underflow*/>> (int)num;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static extern void smethod_42(int int_0);

	static extern void smethod_43(string string_4);

	static extern string smethod_44(string string_4);

	static extern Assembly smethod_45();

	static extern string smethod_46(Assembly assembly_0);

	static extern void smethod_47(string string_4, string string_5, bool bool_5);

	static extern RegistryKey smethod_48(RegistryKey registryKey_0, string string_4, bool bool_5);

	static extern void smethod_49(RegistryKey registryKey_0, string string_4, object object_0);

	static extern DialogResult smethod_50(string string_4, string string_5, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0);

	static Rectangle smethod_51(Point point_0)
	{
		//Discarded unreachable code: IL_000d, IL_0012, IL_001b
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Incompatible stack heights: 0 vs 1
		while ((int)/*Error near IL_0005: Stack underflow*/ != 0)
		{
		}
		if (/*Error near IL_0006: Stack underflow*/ / /*Error near IL_0006: Stack underflow*/!= 0)
		{
			/*Error near IL_0008: Invalid metadata token*/;
		}
		_ = (float)/*Error near IL_0015: Stack underflow*/;
		/*Error near IL_0016: Invalid metadata token*/;
	}

	unsafe static Bitmap smethod_52(int int_0, int int_1)
	{
		//Discarded unreachable code: IL_001c
		//IL_0002: Expected O, but got I4
		//IL_0004: Invalid comparison between Unknown and F8
		//IL_000a: Invalid comparison between Unknown and I
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected I4, but got I8
		while (true)
		{
			uint num = (uint)/*Error near IL_0001: Stack underflow*/;
			((object[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = num;
			double num2 = *(double*)(nint)/*Error near IL_0003: Stack underflow*/;
			if ((double)/*Error near IL_0009: Stack underflow*/ != num2)
			{
				continue;
			}
			nint num3 = checked((nint)/*Error near IL_000a: Stack underflow*/);
			if ((nint)/*Error near IL_000f: Stack underflow*/ != num3)
			{
				_003F val = checked(/*Error near IL_0011: Stack underflow*/ * /*Error near IL_0011: Stack underflow*/);
				if ((/*Error near IL_0012: Stack underflow*/ ^ val) == 0)
				{
					break;
				}
			}
		}
		/*Error near IL_0017: Invalid metadata token*/;
	}

	static Graphics smethod_53(Image image_0)
	{
		//IL_0002: Expected O, but got F8
		//IL_0008: Expected I4, but got I8
		switch (((Array)(double)/*Error near IL_0001: Stack underflow*/).LongLength)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static extern void smethod_54(Graphics graphics_0, Point point_0, Point point_1, Size size_0);

	static extern ImageFormat smethod_55();

	static extern void smethod_56(Image image_0, string string_4, ImageFormat imageFormat_0);

	static extern bool smethod_57(string string_4);

	static void smethod_58(Process process_0)
	{
		//Discarded unreachable code: IL_0001, IL_000c, IL_0012, IL_0018, IL_0020
		//IL_0012: Unsupported input type for neg.
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got F8
		/*Error: Unknown opcode: 0xFD*/;
	}

	static string[] smethod_59(string string_4, char[] char_0)
	{
		//Discarded unreachable code: IL_0001, IL_0009, IL_0011, IL_0016, IL_001c
		//IL_0022: Expected I4, but got Unknown
		/*Error: Unknown opcode: 0xFC*/;
	}

	static extern string smethod_60(WebClient webClient_0, string string_4);

	static extern string smethod_61();

	static extern string smethod_62();

	static extern string smethod_63(string[] string_4);

	unsafe static void smethod_64(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0012, IL_0017, IL_001c
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		while (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/|| /*Error near IL_000a: Stack underflow*/== /*Error near IL_000a: Stack underflow*/)
		{
		}
		*(_003F*)(nint)/*Error near IL_000b: Stack underflow*/ = /*Error near IL_000b: Stack underflow*/;
		byte num = *(byte*)(nint)/*Error near IL_000c: Stack underflow*/;
		checked
		{
			_ = /*Error near IL_000d: Stack underflow*/+ num;
			/*Error near IL_000d: Invalid metadata token*/;
		}
	}

	static extern Process[] smethod_65();

	static string smethod_66(Process process_0)
	{
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
			{
				/*Error: Could not find block for branch target IL_0005*/;
			}
		}
	}

	static void smethod_67(Process process_0)
	{
		/*Error: Invalid metadata token*/;
	}

	static extern Process smethod_68();

	static extern IntPtr smethod_69(Process process_0);

	static extern ManagementObjectSearcher smethod_70(string string_4);

	static ManagementObjectCollection smethod_71(ManagementObjectSearcher managementObjectSearcher_0)
	{
		//Discarded unreachable code: IL_000a, IL_000f, IL_0014
		//IL_0017: Expected O, but got I4
		while (true)
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ != 0)
			{
			}
		}
	}

	static ManagementObjectEnumerator smethod_72(ManagementObjectCollection managementObjectCollection_0)
	{
		//Discarded unreachable code: IL_000b, IL_0010, IL_0018, IL_001a, IL_001f, IL_0025
		//IL_0013: Invalid comparison between Unknown and I4
		checked
		{
			_ = (int)/*Error near IL_0001: Stack underflow*/;
			/*OpCode not supported: DebugBreak*/;
			/*Error near IL_0006: Invalid metadata token*/;
		}
	}

	static extern ManagementBaseObject smethod_73(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern object smethod_74(ManagementBaseObject managementBaseObject_0, string string_4);

	static extern string smethod_75(object object_0);

	static extern string smethod_76(string string_4);

	static extern bool smethod_77(string string_4, string string_5);

	static extern string smethod_78(string string_4);

	static bool smethod_79(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0016, IL_001c
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		sbyte num;
		do
		{
			((sbyte[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (sbyte)/*Error near IL_0001: Stack underflow*/;
			checked
			{
				num = (sbyte)unchecked((int)checked((ushort)(byte)/*Error near IL_0002: Stack underflow*/));
			}
		}
		while ((long)(/*Error near IL_0006: Stack underflow*/ | num) != 0L || (int)/*Error near IL_0011: Stack underflow*/ != 0);
		/*Error near IL_0011: Invalid metadata token*/;
	}

	unsafe static bool smethod_80(ManagementObjectEnumerator managementObjectEnumerator_0)
	{
		//Discarded unreachable code: IL_0011, IL_0017, IL_0021, IL_0029, IL_002e, IL_0038, IL_0042
		//IL_0004: Expected O, but got I4
		//IL_000d: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected I4, but got Unknown
		//IL_0042: Unsupported input type for neg.
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			int num = ((int[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			((int[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = num;
			byte num2 = (byte)/*Error near IL_0003: Stack underflow*/;
			*(object*)(nint)/*Error near IL_0004: Stack underflow*/ = num2;
		}
		while (/*Error near IL_0009: Stack underflow*/ > /*Error near IL_0009: Stack underflow*/);
		_ = (sbyte)/*Error near IL_000a: Stack underflow*/;
		/*Error near IL_000b: ldloc 1 (out-of-bounds)*/;
		/*Error near IL_000c: Invalid metadata token*/;
	}

	static extern NetworkInterface[] smethod_81();

	static OperationalStatus smethod_82(NetworkInterface networkInterface_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0002: Stack underflow*/- 4;
		/*Error: Unexpected end of block*/;
	}

	static extern PhysicalAddress smethod_83(NetworkInterface networkInterface_0);

	static string smethod_84(string string_4, char[] char_0)
	{
		//Discarded unreachable code: IL_0005
		/*Error: Invalid metadata token*/;
	}

	static extern FileSystemWatcher smethod_85();

	static extern string smethod_86(Environment.SpecialFolder specialFolder_0);

	static extern void smethod_87(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static extern void smethod_88(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0);

	static extern void smethod_89(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static void smethod_90(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0)
	{
		//IL_0001: Invalid comparison between Unknown and I8
		long num;
		do
		{
			num = checked((long)/*Error near IL_0001: Stack underflow*/);
		}
		while ((long)/*Error near IL_0006: Stack underflow*/ > num);
		((sbyte[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/] = (sbyte)/*Error near IL_0007: Stack underflow*/;
		/*Error near IL_0007: ldloc 3 (out-of-bounds)*/;
		_ = -1;
		checked
		{
			_ = (nuint)/*Error near IL_0009: ldloc 3 (out-of-bounds)*/;
			/*Error near IL_000b: Invalid metadata token*/;
		}
	}

	static extern void smethod_91(FileSystemWatcher fileSystemWatcher_1, bool bool_5);

	static extern bool smethod_92(string string_4, string string_5);

	static extern bool smethod_93(string string_4);

	static string[] smethod_94(string string_4, string string_5)
	{
		return (string[])/*OpCode not supported: Nop*/;
	}

	static extern Match smethod_95(string string_4, string string_5);

	static WebHeaderCollection smethod_96(WebClient webClient_0)
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0011
		_ = (ulong)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern void smethod_97(WebHeaderCollection webHeaderCollection_0, HttpRequestHeader httpRequestHeader_0, string string_4);
}
