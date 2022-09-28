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

	private static void smethod_1()
	{
		//Discarded unreachable code: IL_0005, IL_000b, IL_0010, IL_0014, IL_001c, IL_0023, IL_0028, IL_002d, IL_002e, IL_0033, IL_0036, IL_003d
		//IL_0007: Expected O, but got I
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_002d: Incompatible stack heights: 0 vs 1
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	private static extern bool smethod_2();

	private static extern bool smethod_3();

	private static bool smethod_4()
	{
		//IL_0001: Invalid comparison between Unknown and I4
		//IL_0008: Expected O, but got I4
		sbyte num;
		do
		{
			num = checked((sbyte)/*Error near IL_0001: Stack underflow*/);
		}
		while ((int)/*Error near IL_0006: Stack underflow*/ <= (int)num);
		byte num2 = (byte)/*Error near IL_0007: Stack underflow*/;
		((object[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = num2;
		/*Error: Unexpected end of block*/;
	}

	private static string smethod_5()
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_0014
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected F8, but got Unknown
		while (true)
		{
		}
	}

	private static void smethod_6()
	{
		/*Error near IL_0003: stloc 0 (out-of-bounds)*/;
		_ = (float)(long)(0L - checked((ulong)/*Error near IL_0006: Stack underflow*/));
		/*Error: Unexpected end of block*/;
	}

	private static extern void smethod_7(object sender, FileSystemEventArgs e);

	public extern Class5();

	static extern byte[] smethod_8(string string_4);

	static extern RijndaelManaged smethod_9();

	static extern void smethod_10(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern void smethod_11(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	unsafe static Encoding smethod_12()
	{
		//IL_0002: Expected I8, but got I
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected I4, but got Unknown
		nint num = (nint)/*Error near IL_0001: Stack underflow*/;
		*(long*)(nint)/*Error near IL_0002: Stack underflow*/ = num;
		*(_003F*)(nint)/*Error near IL_0003: Stack underflow*/ = /*Error near IL_0003: Stack underflow*/;
		((long[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (long)/*Error near IL_0004: Stack underflow*/;
		_003F val = /*Error near IL_0007: Stack underflow*/<< (int)/*Error near IL_0007: Stack underflow*/;
		((sbyte[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (sbyte)(int)val;
		*(_003F*)(nint)/*Error near IL_0009: Stack underflow*/ = /*Error near IL_0009: Stack underflow*/;
		_ = 0;
		/*Error: Unexpected end of block*/;
	}

	static byte[] smethod_13(Encoding encoding_0, string string_4)
	{
		//Discarded unreachable code: IL_0008, IL_0013, IL_001a, IL_0021, IL_002a, IL_002f, IL_0034
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		short num = checked((short)/*Error near IL_0002: Stack underflow*/);
		_ = ((uint[])/*Error near IL_0003: Stack underflow*/)[num];
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static extern void smethod_14(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_15(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_16(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	static extern void smethod_17(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static extern byte[] smethod_18(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern byte[] smethod_19(SymmetricAlgorithm symmetricAlgorithm_0);

	static ICryptoTransform smethod_20(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1)
	{
		//Discarded unreachable code: IL_0009
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0002: Stack underflow*/^ -1;
		/*Error near IL_0002: stloc 0 (out-of-bounds)*/;
		/*Error near IL_0004: Invalid metadata token*/;
	}

	static byte[] smethod_21(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1)
	{
		//IL_0002: Expected F4, but got I4
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		uint num = ((uint[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		((float[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (int)num;
		_ = /*Error near IL_0003: Stack underflow*/>> (int)/*Error near IL_0003: Stack underflow*/;
		/*Error: Unexpected end of block*/;
	}

	static extern Encoding smethod_22();

	static string smethod_23(Encoding encoding_0, byte[] byte_0)
	{
		//IL_0002: Invalid comparison between Unknown and O
		while (true)
		{
			if (/*Error near IL_0007: Stack underflow*/ < encoding_0)
			{
				/*Error: Could not find block for branch target IL_0007*/;
			}
		}
	}

	static extern void smethod_24(IDisposable idisposable_0);

	static extern string smethod_25(string string_4);

	static extern Assembly smethod_26();

	static extern string smethod_27(Assembly assembly_0);

	static extern string smethod_28(string string_4, string string_5);

	static extern void smethod_29(string string_4, string string_5, bool bool_5);

	static extern RegistryKey smethod_30(RegistryKey registryKey_0, string string_4, bool bool_5);

	static extern void smethod_31(RegistryKey registryKey_0, string string_4, object object_0);

	static extern DialogResult smethod_32(string string_4, string string_5, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0);

	static extern Rectangle smethod_33(Point point_0);

	unsafe static Bitmap smethod_34(int int_0, int int_1)
	{
		//Discarded unreachable code: IL_001b, IL_0020, IL_0022
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got I4
		do
		{
			*(_003F*)(nint)/*Error near IL_0002: Stack underflow*/ = /*Error near IL_0002: Stack underflow*/;
		}
		while (/*Error near IL_0009: Stack underflow*/ < /*Error near IL_0009: Stack underflow*/);
		double num = (double)/*Error near IL_000a: Stack underflow*/;
		checked
		{
			_ = /*Error near IL_000b: Stack underflow*/- num;
			/*Error near IL_000d: stloc 0 (out-of-bounds)*/;
			((double[])/*Error near IL_0010: Stack underflow*/)[/*Error near IL_0010: Stack underflow*/] = (double)/*Error near IL_0010: Stack underflow*/;
			int num2 = (int)(*unchecked((float*)(nint)/*Error near IL_0012: Stack underflow*/));
			_003F val = /*Error near IL_0014: Stack underflow*/- num2;
			ushort num3 = (ushort)(/*Error near IL_0015: Stack underflow*/ * val);
			_003F val2 = unchecked(/*Error near IL_0018: Stack underflow*/ / num3);
			_ = /*Error near IL_0019: Stack underflow*/* val2;
			/*Error near IL_001a: Unknown opcode: 0xFB*/;
		}
	}

	static extern Graphics smethod_35(Image image_0);

	static extern void smethod_36(Graphics graphics_0, Point point_0, Point point_1, Size size_0);

	static extern ImageFormat smethod_37();

	static extern void smethod_38(Image image_0, string string_4, ImageFormat imageFormat_0);

	unsafe static WebClient smethod_39()
	{
		//Discarded unreachable code: IL_0009, IL_0018
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		_ = ((uint[])/*Error near IL_0003: Stack underflow*/)[2];
		/*Error near IL_0004: Invalid metadata token*/;
	}

	static bool smethod_40(string string_4)
	{
		while (true)
		{
		}
	}

	static void smethod_41(string string_4)
	{
		//Discarded unreachable code: IL_000e, IL_0011, IL_0017, IL_0020, IL_0021, IL_0026, IL_002a, IL_0034
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected I4, but got Unknown
		//IL_0029: Expected F4, but got I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected native int or pointer, but got O
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		while (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/)
		{
		}
		checked
		{
			_ = (byte)((uint[])/*Error near IL_0008: Stack underflow*/)[8];
			/*Error near IL_0009: Invalid metadata token*/;
		}
	}

	static extern void smethod_42(WebClient webClient_0, string string_4, string string_5);

	static extern Process smethod_43();

	static extern ProcessStartInfo smethod_44();

	static extern void smethod_45(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static extern void smethod_46(ProcessStartInfo processStartInfo_0, string string_4);

	unsafe static void smethod_47(Process process_0, ProcessStartInfo processStartInfo_0)
	{
		//Discarded unreachable code: IL_000a, IL_0012, IL_0022, IL_0024, IL_0026, IL_002c, IL_0033, IL_0039, IL_0041
		//IL_0007: Expected F4, but got I4
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002e: Invalid comparison between Unknown and O
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected I, but got Unknown
		int num = checked((int)/*Error: Stack underflow*/);
		*(sbyte*)(nint)/*Error near IL_0003: Stack underflow*/ = (sbyte)num;
		_003F val = /*Error near IL_0003: Stack underflow*/;
		sbyte num2 = *(sbyte*)(int)((byte[])/*Error near IL_0005: Stack underflow*/)[val];
		((float[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/] = num2;
		_ = *(uint*)(nint)/*Error near IL_0008: Stack underflow*/;
		/*Error near IL_0009: Unknown opcode: 0xFC*/;
	}

	static bool smethod_48(Process process_0)
	{
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_49(Process process_0);

	unsafe static string smethod_50(string string_4)
	{
		//Discarded unreachable code: IL_0019
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected native int or pointer, but got O
		//IL_0005: Invalid comparison between Unknown and F4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		_003F val;
		do
		{
			val = checked(/*Error near IL_0002: Stack underflow*/ + /*Error near IL_0002: Stack underflow*/);
		}
		while ((float)(/*Error near IL_0003: Stack underflow*/ * val) < *(float*)unchecked((nint)null));
		_003F val2 = ~/*Error near IL_000c: Stack underflow*/;
		checked
		{
			_003F val3 = /*Error near IL_0011: Stack underflow*/- val2;
			_003F val4 = /*Error near IL_0012: Stack underflow*/* val3;
			_ = /*Error near IL_0014: Stack underflow*/^ val4;
			/*Error near IL_0014: Invalid metadata token*/;
		}
	}

	static extern string[] smethod_51(string string_4, char[] char_0);

	unsafe static string smethod_52(WebClient webClient_0, string string_4)
	{
		//Discarded unreachable code: IL_000f, IL_0017
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0009: Expected I4, but got F4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		_003F val = /*Error near IL_0005: Stack underflow*/% /*Error near IL_0005: Stack underflow*/;
		*(_003F*)(nint)/*Error near IL_0007: Stack underflow*/ = val;
		float num = *(float*)(nint)/*Error near IL_0008: Stack underflow*/;
		((sbyte[])/*Error near IL_0009: Stack underflow*/)[/*Error near IL_0009: Stack underflow*/] = (sbyte)(int)num;
		_ = ((int[])/*Error near IL_000a: Stack underflow*/)[/*Error near IL_000a: Stack underflow*/];
		/*Error near IL_000a: Invalid metadata token*/;
	}

	unsafe static string smethod_53()
	{
		//Discarded unreachable code: IL_0003, IL_000c, IL_000d
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nuint)unchecked((int)(*(byte*)(nint)/*Error near IL_0001: Stack underflow*/));
			/*Error near IL_0002: Unknown opcode: 0xFF*/;
		}
	}

	static extern string smethod_54();

	static string smethod_55(string[] string_4)
	{
		//Discarded unreachable code: IL_0005
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_56(int int_0);

	static extern Process[] smethod_57();

	static extern string smethod_58(Process process_0);

	static extern void smethod_59(Process process_0);

	static extern Process smethod_60();

	static extern IntPtr smethod_61(Process process_0);

	static extern ManagementObjectSearcher smethod_62(string string_4);

	static extern ManagementObjectCollection smethod_63(ManagementObjectSearcher managementObjectSearcher_0);

	static ManagementObjectEnumerator smethod_64(ManagementObjectCollection managementObjectCollection_0)
	{
		//Discarded unreachable code: IL_0005, IL_0010, IL_0015, IL_001f, IL_0026, IL_002c
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and F8
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static extern ManagementBaseObject smethod_65(ManagementObjectEnumerator managementObjectEnumerator_0);

	static object smethod_66(ManagementBaseObject managementBaseObject_0, string string_4)
	{
		while (/*Error near IL_0005: Stack underflow*/ == /*Error near IL_0005: Stack underflow*/|| /*Error near IL_000a: Stack underflow*/>= /*Error near IL_000a: Stack underflow*/)
		{
		}
		checked
		{
			_ = (uint)/*Error near IL_000b: Stack underflow*/;
			/*Error near IL_000d: Invalid metadata token*/;
		}
	}

	static extern string smethod_67(object object_0);

	static extern string smethod_68(string string_4);

	static bool smethod_69(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0017, IL_001d, IL_0024, IL_002c, IL_002e, IL_0036, IL_003f, IL_0041
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: Invalid metadata token*/;
	}

	unsafe static string smethod_70(string string_4)
	{
		//Discarded unreachable code: IL_000a, IL_0012, IL_0014, IL_001c, IL_0025, IL_0027, IL_002d
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Incompatible stack heights: 0 vs 1
		if (/*Error near IL_0003: Stack underflow*/ == /*Error near IL_0003: Stack underflow*/)
		{
			_003F val = /*Error near IL_0004: Stack underflow*// /*Error near IL_0004: Stack underflow*/;
			_ = /*Error near IL_0005: Stack underflow*/>> (int)val;
			/*Error near IL_0005: Invalid metadata token*/;
		}
		_ = *(short*)(nint)/*Error near IL_0034: Stack underflow*/;
		/*Error near IL_0034: Invalid metadata token*/;
	}

	static bool smethod_71(string string_4, string string_5)
	{
		/*Error: Invalid metadata token*/;
	}

	static extern bool smethod_72(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern NetworkInterface[] smethod_73();

	static OperationalStatus smethod_74(NetworkInterface networkInterface_0)
	{
		//Discarded unreachable code: IL_000c, IL_0011, IL_0020
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected O, but got Unknown
		//IL_0008: Expected O, but got I8
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected native int or pointer, but got O
		_003F val = checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		((object[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (object)val;
		_ = (nint)(uint)checked((int)/*Error near IL_0003: Stack underflow*/);
		/*Error near IL_0007: Invalid metadata token*/;
	}

	static extern PhysicalAddress smethod_75(NetworkInterface networkInterface_0);

	static extern string smethod_76(string string_4, string string_5, string string_6);

	static extern string smethod_77(string string_4, char[] char_0);

	static extern FileSystemWatcher smethod_78();

	static extern string smethod_79(Environment.SpecialFolder specialFolder_0);

	static void smethod_80(FileSystemWatcher fileSystemWatcher_1, string string_4)
	{
		//Discarded unreachable code: IL_0005, IL_0008, IL_000f, IL_0011, IL_0013, IL_0020, IL_0025
		//IL_0006: Invalid comparison between Unknown and I4
		//IL_0012: Incompatible stack heights: 0 vs 1
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_81(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0);

	static void smethod_82(FileSystemWatcher fileSystemWatcher_1, string string_4)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Invalid comparison between Unknown and I4
		while (true)
		{
			_003F val = /*Error: ldloc 3 (out-of-bounds)*/;
			/*Error near IL_0001: ldloc 0 (out-of-bounds)*/;
			/*Error near IL_0002: stloc 0 (out-of-bounds)*/;
			_003F val2 = /*Error near IL_0004: Stack underflow*/+ val;
			/*OpCode not supported: Ckfinite*/;
			short num = checked((short)val2);
			if ((int)/*Error near IL_000b: Stack underflow*/ < (int)num)
			{
				/*Error: Could not find block for branch target IL_000b*/;
			}
		}
	}

	static extern void smethod_83(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0);

	static extern void smethod_84(FileSystemWatcher fileSystemWatcher_1, bool bool_5);

	unsafe static bool smethod_85(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0012, IL_001a, IL_001f, IL_0025
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		while (((int[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] != 0 || /*Error near IL_000b: Stack underflow*/!= /*Error near IL_000b: Stack underflow*/)
		{
		}
		_ = *(byte*)(nint)/*Error near IL_000d: Stack underflow*/;
		/*Error near IL_000d: Invalid metadata token*/;
	}
}
