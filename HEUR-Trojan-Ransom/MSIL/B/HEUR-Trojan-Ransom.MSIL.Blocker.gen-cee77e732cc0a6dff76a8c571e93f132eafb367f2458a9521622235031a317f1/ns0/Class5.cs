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

	public static extern string smethod_0(string string_4);

	private static extern void smethod_1();

	private static extern void smethod_2(string string_4, string string_5);

	private static extern void Main();

	private static extern void smethod_3();

	private static bool smethod_4()
	{
		//Discarded unreachable code: IL_0006, IL_000e, IL_0016
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected I4, but got Unknown
		//IL_0011: Invalid comparison between Unknown and I4
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	private static extern bool smethod_5();

	private static extern bool smethod_6();

	private static extern string smethod_7();

	private static void smethod_8()
	{
		//Discarded unreachable code: IL_0006, IL_000d, IL_0012, IL_0019, IL_0025
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected I4, but got F8
		_ = (ushort)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	private static extern void smethod_9(object sender, FileSystemEventArgs e);

	private static extern void smethod_10();

	private static void smethod_11()
	{
		//Discarded unreachable code: IL_0006, IL_000c, IL_0013, IL_001e
		_ = ((Array)/*Error near IL_0002: Stack underflow*/).LongLength;
		_ = 2;
		/*Error near IL_0005: Unknown opcode: 0xF8*/;
	}

	public static extern bool smethod_12(string string_4);

	public extern Class5();

	static extern byte[] smethod_13(string string_4);

	static extern RijndaelManaged smethod_14();

	static extern void smethod_15(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern void smethod_16(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern Encoding smethod_17();

	static extern byte[] smethod_18(Encoding encoding_0, string string_4);

	static void smethod_19(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_000b, IL_0010, IL_0011, IL_0016, IL_001b
		//IL_0001: Invalid comparison between Unknown and F8
		double num;
		do
		{
			num = (double)/*Error near IL_0001: Stack underflow*/;
		}
		while ((double)/*Error near IL_0006: Stack underflow*/ <= num);
		sbyte num2 = checked((sbyte)/*Error near IL_0008: Stack underflow*/);
		_ = ((IntPtr[])/*Error near IL_0009: Stack underflow*/)[num2];
		/*Error near IL_000a: Unknown opcode: 0xFC*/;
	}

	static extern void smethod_20(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	unsafe static void smethod_21(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0)
	{
		//Discarded unreachable code: IL_0009, IL_0012, IL_001a, IL_0026
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		*(IntPtr*)(nint)/*Error near IL_0002: Stack underflow*/ = (IntPtr)7;
		object obj = *(object*)(nint)/*Error near IL_0003: Stack underflow*/;
		checked
		{
			_ = /*Error near IL_0004: Stack underflow*/* obj;
			/*Error near IL_0004: Invalid metadata token*/;
		}
	}

	static extern void smethod_22(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static extern byte[] smethod_23(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern byte[] smethod_24(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern ICryptoTransform smethod_25(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static extern byte[] smethod_26(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	unsafe static Encoding smethod_27()
	{
		//Discarded unreachable code: IL_0010, IL_0015, IL_0021, IL_0026
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected F4, but got Unknown
		//IL_001d: Expected O, but got I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			_003F val = /*Error near IL_0001: Stack underflow*/% /*Error near IL_0001: Stack underflow*/;
			*(float*)(nint)/*Error near IL_0002: Stack underflow*/ = (float)val;
			/*Error near IL_0003: stloc 0 (out-of-bounds)*/;
		}
		while (/*Error near IL_000a: Stack underflow*/ > /*Error near IL_000a: Stack underflow*/|| /*Error near IL_000f: Stack underflow*/<= /*Error near IL_000f: Stack underflow*/);
		/*Error near IL_000f: Unknown opcode: 0xFD*/;
	}

	static extern string smethod_28(Encoding encoding_0, byte[] byte_0);

	static extern void smethod_29(IDisposable idisposable_0);

	static string smethod_30(string string_4)
	{
		throw 1;
	}

	static Assembly smethod_31()
	{
		//Discarded unreachable code: IL_001b, IL_0020
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
			{
				_ = 7;
				/*Error near IL_0008: stloc 2 (out-of-bounds)*/;
				if (/*Error near IL_000e: Stack underflow*/ <= /*Error near IL_000e: Stack underflow*/)
				{
					break;
				}
			}
		}
		_003F val = /*Error near IL_000e: ldloc 2 (out-of-bounds)*/;
		_ = (int)checked((uint)(/*Error near IL_0010: Stack underflow*/ ^ val));
		_ = 7;
		/*Error near IL_0016: Invalid metadata token*/;
	}

	static extern Stream smethod_32(Assembly assembly_0, string string_4);

	static extern string smethod_33(string string_4, string string_5, string string_6);

	static extern FileStream smethod_34(string string_4, FileMode fileMode_0, FileAccess fileAccess_0);

	static extern void smethod_35(Stream stream_0, Stream stream_1);

	static extern Process smethod_36(string string_4);

	static string smethod_37(Assembly assembly_0)
	{
		//Discarded unreachable code: IL_000a, IL_0012, IL_001c, IL_001e, IL_0023, IL_0028, IL_0034, IL_0039
		//IL_0015: Unsupported input type for neg.
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between I4 and Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected F4, but got I4
		//IL_0032: Expected native int or pointer, but got F8
		//IL_0041: Expected O, but got I4
		//IL_0046: Expected I4, but got I8
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		while (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
		{
		}
		/*Error near IL_0005: Invalid metadata token*/;
	}

	static string smethod_38(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0002, IL_0007, IL_000e, IL_0016, IL_001f
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected F4, but got I4
		//IL_001a: Invalid comparison between Unknown and I4
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xF9*/;
		}
	}

	static extern void smethod_39(string string_4, string string_5, bool bool_5);

	unsafe static RegistryKey smethod_40(RegistryKey registryKey_0, string string_4, bool bool_5)
	{
		//Discarded unreachable code: IL_0002, IL_0007, IL_001b, IL_002d, IL_0033
		//IL_000f: Expected O, but got I4
		//IL_0014: Expected I4, but got I8
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Invalid comparison between Unknown and Ref
		_ = *(double*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xFB*/;
	}

	static void smethod_41(RegistryKey registryKey_0, string string_4, object object_0)
	{
		//Discarded unreachable code: IL_0012, IL_0018
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and Ref
		checked
		{
			short num = (short)/*Error near IL_0001: Stack underflow*/;
			_ = (/*Error near IL_0003: Stack underflow*/ + num) ^ 8L;
			/*Error near IL_000d: Invalid metadata token*/;
		}
	}

	static extern void smethod_42(string string_4, FileAttributes fileAttributes_0);

	static extern DialogResult smethod_43(string string_4, string string_5, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0);

	static extern Assembly smethod_44();

	static extern string smethod_45(string string_4);

	unsafe static bool smethod_46(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_000c, IL_000e, IL_0013
		//IL_0002: Expected native int or pointer, but got O
		IntPtr intPtr = *(IntPtr*)(nint)string_4;
		checked
		{
			_ = (nuint)unchecked((uint)((int[])/*Error near IL_0006: Stack underflow*/)[(nint)intPtr]);
			/*Error near IL_0007: Invalid metadata token*/;
		}
	}

	static extern Rectangle smethod_47(Point point_0);

	static extern Bitmap smethod_48(int int_0, int int_1);

	static Graphics smethod_49(Image image_0)
	{
		//IL_0004: Invalid comparison between Unknown and F8
		while (true)
		{
			nuint num;
			checked
			{
				num = unchecked((nuint)((Array)/*Error near IL_0001: Stack underflow*/).LongLength) + (nuint)5u;
			}
			if (!((double)/*Error near IL_0009: Stack underflow*/ <= (double)(nint)num))
			{
				/*Error: Could not find block for branch target IL_0009*/;
			}
		}
	}

	static extern void smethod_50(Graphics graphics_0, Point point_0, Point point_1, Size size_0);

	static ImageFormat smethod_51()
	{
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			byte num = ((byte[])/*Error near IL_0002: Stack underflow*/)[5];
			if ((int)/*Error near IL_0007: Stack underflow*/ >= (int)num)
			{
				int num2 = checked((int)/*Error near IL_0008: Stack underflow*/);
				if (/*Error near IL_0009: Stack underflow*/ + num2 != 0 && (uint)checked((short)/*Error near IL_0011: Stack underflow*/) % 2350175110u == 0)
				{
					break;
				}
			}
		}
		/*Error near IL_001d: stloc 2 (out-of-bounds)*/;
		/*Error near IL_001e: stloc 1 (out-of-bounds)*/;
		/*Error near IL_001f: ldloc 1 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static extern void smethod_52(Image image_0, string string_4, ImageFormat imageFormat_0);

	unsafe static WebClient smethod_53()
	{
		//Discarded unreachable code: IL_000f, IL_0016, IL_001c, IL_001e, IL_0020, IL_0029
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected I4, but got I8
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_002a: Incompatible stack heights: 1 vs 0
		while ((uint)(~/*Error near IL_0001: Stack underflow*/) == 0)
		{
		}
		long num = checked((long)/*Error near IL_0008: Stack underflow*/);
		*(int*)(nint)/*Error near IL_0009: Stack underflow*/ = (int)num;
		*(_003F*)(nint)/*Error near IL_000a: Stack underflow*/ = /*Error near IL_000a: Stack underflow*/;
		/*Error near IL_000a: Invalid metadata token*/;
	}

	unsafe static bool smethod_54(string string_4)
	{
		//Discarded unreachable code: IL_0019, IL_001e, IL_0025
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got I4
		//IL_0005: Expected native int or pointer, but got F8
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I
		uint num2;
		do
		{
			*(object*)(nint)(double)(long)checked((ulong)(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)) = -1;
			checked
			{
				ushort num = (ushort)(/*Error near IL_0007: Stack underflow*/ >> unchecked((int)/*Error near IL_0007: Stack underflow*/));
				num2 = (uint)((sbyte[])/*Error near IL_000c: Stack underflow*/)[unchecked(num + 1)];
			}
		}
		while ((nint)/*Error near IL_0014: Stack underflow*/ <= (nint)(int)(byte)num2);
		/*Error near IL_0014: Invalid metadata token*/;
	}

	static extern void smethod_55(string string_4);

	unsafe static void smethod_56(WebClient webClient_0, string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0008
		((int[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (int)/*Error near IL_0001: Stack underflow*/;
		nuint num = checked((nuint)/*Error near IL_0002: Stack underflow*/);
		*(sbyte*)(nint)/*Error near IL_0003: Stack underflow*/ = (sbyte)num;
		checked
		{
			_ = (byte)/*Error near IL_0005: Stack underflow*/;
			/*Error near IL_0006: ldloc 0 (out-of-bounds)*/;
			/*Error near IL_0007: Unknown opcode: 0xFB*/;
		}
	}

	static extern Process smethod_57();

	static ProcessStartInfo smethod_58()
	{
		//Discarded unreachable code: IL_0007, IL_0014, IL_001a, IL_001f, IL_0024
		//IL_000f: Invalid comparison between Unknown and I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (uint)/*Error near IL_0001: ldloc 3 (out-of-bounds)*/;
			/*Error near IL_0006: Unknown opcode: 0xF8*/;
		}
	}

	static extern void smethod_59(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static extern void smethod_60(ProcessStartInfo processStartInfo_0, string string_4);

	static extern void smethod_61(Process process_0, ProcessStartInfo processStartInfo_0);

	static extern bool smethod_62(Process process_0);

	static extern void smethod_63(Process process_0);

	static extern string smethod_64(string string_4);

	unsafe static string[] smethod_65(string string_4, char[] char_0)
	{
		//Discarded unreachable code: IL_0010
		//IL_0012: Expected I4, but got F8
		while (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/|| /*Error near IL_000a: Stack underflow*/< /*Error near IL_000a: Stack underflow*/)
		{
		}
		checked
		{
			_ = (long)(*unchecked((sbyte*)(int)checked((byte)/*Error near IL_000b: Stack underflow*/)));
			_ = 4;
			/*Error near IL_000f: Unknown opcode: 0xFC*/;
		}
	}

	static extern string smethod_66(WebClient webClient_0, string string_4);

	static extern string smethod_67();

	static extern string smethod_68();

	static extern string smethod_69(string[] string_4);

	static extern void smethod_70(int int_0);

	static extern Process[] smethod_71();

	static string smethod_72(Process process_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			_003F val = ~/*Error near IL_0002: Stack underflow*/;
			if (/*Error near IL_0008: Stack underflow*/ > val)
			{
				/*Error: Could not find block for branch target IL_0008*/;
			}
		}
	}

	static extern void smethod_73(Process process_0);

	static extern Process smethod_74();

	static extern IntPtr smethod_75(Process process_0);

	static ManagementObjectSearcher smethod_76(string string_4)
	{
		//Discarded unreachable code: IL_000c, IL_0011, IL_0017, IL_002d, IL_0033
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0006: stloc 1 (out-of-bounds)*/;
		/*Error near IL_0007: Invalid metadata token*/;
	}

	static extern ManagementObjectCollection smethod_77(ManagementObjectSearcher managementObjectSearcher_0);

	static extern ManagementObjectEnumerator smethod_78(ManagementObjectCollection managementObjectCollection_0);

	static ManagementBaseObject smethod_79(ManagementObjectEnumerator managementObjectEnumerator_0)
	{
		//Discarded unreachable code: IL_0006, IL_000a, IL_0015, IL_001a, IL_0020, IL_002b, IL_0031, IL_0037
		//IL_0009: Expected F4, but got Unknown
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unsupported input type for neg.
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		//IL_002f: Incompatible stack heights: 1 vs 0
		//IL_0032: Invalid comparison between Unknown and I
		((short[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (short)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern object smethod_80(ManagementBaseObject managementBaseObject_0, string string_4);

	unsafe static string smethod_81(object object_0)
	{
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_000a: Invalid comparison between Unknown and I
		while (true)
		{
			int num = *(int*)checked((sbyte)/*Error: ldarg 3 (out-of-bounds)*/);
			if ((int)/*Error near IL_0009: Stack underflow*/ > num)
			{
				nint num2 = (nint)/*Error near IL_000a: Stack underflow*/;
				if ((nint)/*Error near IL_000f: Stack underflow*/ == num2)
				{
					break;
				}
			}
		}
		/*Error near IL_000f: Invalid metadata token*/;
	}

	unsafe static string smethod_82(string string_4)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected I8, but got Unknown
		_003F val;
		do
		{
			val = checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		}
		while ((int)/*Error near IL_0009: Stack underflow*/ < (int)(short)val || /*Error near IL_000f: Stack underflow*/== /*Error near IL_000f: Stack underflow*/|| /*Error near IL_0014: Stack underflow*/<= /*Error near IL_0014: Stack underflow*/);
		_003F val2 = checked(/*Error near IL_0016: Stack underflow*/ * /*Error near IL_0016: Stack underflow*/);
		*(long*)(nint)/*Error near IL_0017: Stack underflow*/ = (long)val2;
		sbyte num = ((sbyte[])/*Error near IL_0018: Stack underflow*/)[/*Error near IL_0018: Stack underflow*/];
		_ = ((short[])/*Error near IL_0019: Stack underflow*/)[num];
		/*Error near IL_0019: stloc 0 (out-of-bounds)*/;
		((double[])/*Error near IL_001b: Stack underflow*/)[/*Error near IL_001b: Stack underflow*/] = (double)/*Error near IL_001b: Stack underflow*/;
		switch (/*Error near IL_0023: Stack underflow*/)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static extern bool smethod_83(string string_4, string string_5);

	static extern string smethod_84(string string_4);

	static extern bool smethod_85(string string_4, string string_5);

	static extern bool smethod_86(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern NetworkInterface[] smethod_87();

	static extern OperationalStatus smethod_88(NetworkInterface networkInterface_0);

	unsafe static PhysicalAddress smethod_89(NetworkInterface networkInterface_0)
	{
		//Discarded unreachable code: IL_0008, IL_000a, IL_0010, IL_001c
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F4, but got Unknown
		_003F val = /*Error near IL_0002: Stack underflow*/>> (int)/*Error near IL_0002: Stack underflow*/;
		*(float*)(nint)/*Error near IL_0003: Stack underflow*/ = (float)val;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static string smethod_90(string string_4, char[] char_0)
	{
		//Discarded unreachable code: IL_0006, IL_0008, IL_000e, IL_0015
		//IL_000c: Incompatible stack heights: 1 vs 0
		//IL_0010: Invalid comparison between Unknown and I4
		while (true)
		{
		}
	}

	static extern FileSystemWatcher smethod_91();

	static extern string smethod_92(Environment.SpecialFolder specialFolder_0);

	static extern void smethod_93(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static extern void smethod_94(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0);

	static extern void smethod_95(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static extern void smethod_96(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0);

	static extern void smethod_97(FileSystemWatcher fileSystemWatcher_1, bool bool_5);

	static extern bool smethod_98(string string_4);

	static string[] smethod_99(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0006
		uint num = ((uint[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		uint num2 = checked(num * num);
		((sbyte[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (sbyte)num2;
		/*Error near IL_0005: Unknown opcode: 0xF8*/;
	}

	static extern Match smethod_100(string string_4, string string_5);

	static extern WebHeaderCollection smethod_101(WebClient webClient_0);

	static extern void smethod_102(WebHeaderCollection webHeaderCollection_0, HttpRequestHeader httpRequestHeader_0, string string_4);
}
