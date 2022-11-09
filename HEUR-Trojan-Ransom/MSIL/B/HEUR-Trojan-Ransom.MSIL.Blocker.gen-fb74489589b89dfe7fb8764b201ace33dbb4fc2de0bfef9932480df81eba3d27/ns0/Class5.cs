using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
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

	public static string string_2;

	public static string string_3;

	private static FileSystemWatcher fileSystemWatcher_0;

	private static extern void smethod_0();

	private static extern void smethod_1(string string_4, string string_5, bool bool_5);

	public static extern string smethod_2(string string_4);

	private static extern string smethod_3();

	private static extern void Main();

	private static extern string smethod_4();

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_5);

	private static extern bool smethod_5();

	private static extern void smethod_6();

	private static void smethod_7(object sender, FileSystemEventArgs e)
	{
		throw checked((short)/*Error near IL_0001: Stack underflow*/);
	}

	private static extern void smethod_8();

	private static extern void smethod_9();

	public unsafe static bool smethod_10(string string_4)
	{
		//Discarded unreachable code: IL_001e
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected I8, but got Unknown
		long num = *(long*)(nint)/*Error near IL_0001: Stack underflow*/;
		checked
		{
			_003F val = /*Error near IL_000a: Stack underflow*/+ ((double)unchecked((ulong)num) << int.MinValue);
			((long[])/*Error near IL_000b: Stack underflow*/)[/*Error near IL_000b: Stack underflow*/] = unchecked((long)val);
			_ = (ushort)unchecked((uint)(*(short*)4));
			_ = -1750066281380562441L;
			/*Error near IL_0019: Invalid metadata token*/;
		}
	}

	public extern Class5();

	static extern string smethod_11(string string_4);

	static extern Assembly smethod_12();

	static extern Stream smethod_13(Assembly assembly_0, string string_4);

	static string smethod_14(string string_4, string string_5, string string_6)
	{
		//Discarded unreachable code: IL_0018, IL_0019, IL_0023, IL_0028, IL_002d, IL_0032, IL_0037, IL_003c
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_001e: Expected I4, but got F8
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			_003F val = /*Error: ldloc 0 (out-of-bounds)*/;
			ushort num = ((ushort[])/*Error near IL_0006: Stack underflow*/)[val];
			byte num2 = ((byte[])/*Error near IL_0008: Stack underflow*/)[num];
			if ((int)/*Error near IL_000d: Stack underflow*/ > (int)num2 && /*Error near IL_0013: Stack underflow*/<= /*Error near IL_0013: Stack underflow*/)
			{
			}
		}
	}

	static FileStream smethod_15(string string_4, FileMode fileMode_0, FileAccess fileAccess_0)
	{
		//Discarded unreachable code: IL_0014
		while (/*Error near IL_0005: Stack underflow*/ != /*Error near IL_0005: Stack underflow*/|| /*Error near IL_000a: Stack underflow*/>= /*Error near IL_000a: Stack underflow*/|| (int)/*Error near IL_000f: Stack underflow*/ != 0)
		{
		}
		/*Error near IL_000f: Invalid metadata token*/;
	}

	static extern void smethod_16(Stream stream_0, Stream stream_1);

	static extern void smethod_17(Stream stream_0);

	static extern void smethod_18(IDisposable idisposable_0);

	unsafe static Process smethod_19()
	{
		//IL_0011: Invalid comparison between Unknown and I4
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
			{
				continue;
			}
			_003F val = /*Error near IL_0005: ldarg 0 (out-of-bounds)*/;
			if (/*Error near IL_000b: Stack underflow*/ < val)
			{
				_ = (sbyte)checked((nuint)/*Error near IL_000c: Stack underflow*/);
				/*Error near IL_000e: stloc 0 (out-of-bounds)*/;
				byte num = checked((byte)/*Error near IL_0011: Stack underflow*/);
				if ((int)/*Error near IL_0016: Stack underflow*/ == num)
				{
					break;
				}
			}
		}
		*(sbyte*)(nint)/*Error near IL_0018: Stack underflow*/ = 5;
		switch (((short[])/*Error near IL_0019: Stack underflow*/)[/*Error near IL_0019: Stack underflow*/])
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static extern ProcessStartInfo smethod_20(Process process_0);

	static extern void smethod_21(ProcessStartInfo processStartInfo_0, string string_4);

	static extern void smethod_22(ProcessStartInfo processStartInfo_0, bool bool_5);

	static extern void smethod_23(ProcessStartInfo processStartInfo_0, string string_4);

	static extern bool smethod_24(Process process_0);

	static extern Process smethod_25(string string_4);

	static byte[] smethod_26(string string_4)
	{
		//Discarded unreachable code: IL_000f, IL_0010
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nint)/*Error near IL_0001: Stack underflow*/;
			_ = 4.44096365680254E-267;
			/*Error near IL_000a: Invalid metadata token*/;
		}
	}

	static RijndaelManaged smethod_27()
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_0011
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_28(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern void smethod_29(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern Encoding smethod_30();

	static extern byte[] smethod_31(Encoding encoding_0, string string_4);

	static void smethod_32(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_000e, IL_0014, IL_001a, IL_001f, IL_002b, IL_0030
		//IL_0002: Expected F8, but got I4
		//IL_0027: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			ushort num = ((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			((double[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (int)num;
		}
		while (/*Error near IL_0007: Stack underflow*/ >= /*Error near IL_0007: Stack underflow*/);
		_ = ((int[])/*Error near IL_0009: Stack underflow*/)[/*Error near IL_0009: Stack underflow*/];
		/*Error near IL_0009: Invalid metadata token*/;
	}

	static extern void smethod_33(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_34(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	static extern void smethod_35(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static byte[] smethod_36(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		//Discarded unreachable code: IL_0005, IL_000b, IL_0011
		/*Error: Invalid metadata token*/;
	}

	static extern byte[] smethod_37(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern ICryptoTransform smethod_38(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static extern byte[] smethod_39(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static extern Encoding smethod_40();

	static extern string smethod_41(Encoding encoding_0, byte[] byte_0);

	static extern WebClient smethod_42();

	static extern string smethod_43(string string_4, string string_5);

	static void smethod_44(WebClient webClient_0, string string_4, string string_5)
	{
		//Discarded unreachable code: IL_000c, IL_0013, IL_0014, IL_0019, IL_0034
		//IL_0002: Expected I, but got I8
		//IL_001b: Expected F8, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between F8 and I
		//IL_002f: Incompatible stack heights: 0 vs 2
		do
		{
			long num = checked((long)/*Error near IL_0001: Stack underflow*/);
			((IntPtr[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (nint)num;
		}
		while ((int)/*Error near IL_0007: Stack underflow*/ == 0);
		/*Error near IL_0007: Invalid metadata token*/;
	}

	static extern void smethod_45(Component component_0);

	static ProcessStartInfo smethod_46()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_47(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static extern void smethod_48(ProcessStartInfo processStartInfo_0, string string_4);

	static extern void smethod_49(Process process_0, ProcessStartInfo processStartInfo_0);

	static extern void smethod_50(int int_0);

	static extern void smethod_51(string string_4);

	static extern string smethod_52(string string_4);

	static Rectangle smethod_53(Point point_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_003F val = /*Error: ldloc 0 (out-of-bounds)*/;
		_ = /*Error near IL_0003: Stack underflow*/| val;
		_ = -2.2648374421560603E+283;
		/*Error: Unexpected end of block*/;
	}

	static extern Bitmap smethod_54(int int_0, int int_1);

	static extern Graphics smethod_55(Image image_0);

	static void smethod_56(Graphics graphics_0, Point point_0, Point point_1, Size size_0)
	{
		//Discarded unreachable code: IL_0005, IL_000c
		//IL_0007: Expected I4, but got Unknown
		/*Error: Invalid metadata token*/;
	}

	static extern ImageFormat smethod_57();

	static extern void smethod_58(Image image_0, string string_4, ImageFormat imageFormat_0);

	static extern bool smethod_59(string string_4);

	static extern void smethod_60(Process process_0);

	static extern string smethod_61(Assembly assembly_0);

	static extern void smethod_62(string string_4, string string_5, bool bool_5);

	static extern RegistryKey smethod_63(RegistryKey registryKey_0, string string_4, bool bool_5);

	static void smethod_64(RegistryKey registryKey_0, string string_4, object object_0)
	{
		//Discarded unreachable code: IL_0006, IL_000c, IL_0011
		uint num = (uint)/*Error near IL_0002: Stack underflow*/;
		_ = ((object[])/*Error near IL_0005: Stack underflow*/)[num];
		/*Error near IL_0005: Unknown opcode: 0xFA*/;
	}

	static extern Assembly smethod_65();

	static extern string smethod_66(string string_4);

	static extern bool smethod_67(string string_4, string string_5);

	static extern string[] smethod_68(string string_4, char[] char_0);

	static extern string smethod_69(WebClient webClient_0, string string_4);

	static extern string smethod_70();

	static extern string smethod_71(string[] string_4);

	static extern void smethod_72(string string_4, string string_5);

	static NetworkInterface[] smethod_73()
	{
		//Discarded unreachable code: IL_0007, IL_000e
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Incompatible stack heights: 0 vs 1
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			while (true)
			{
				ushort num = (ushort)/*Error near IL_0001: Stack underflow*/;
				_ = /*Error near IL_0002: Stack underflow*/* num;
			}
		}
	}

	static extern OperationalStatus smethod_74(NetworkInterface networkInterface_0);

	static extern PhysicalAddress smethod_75(NetworkInterface networkInterface_0);

	static extern string smethod_76(object object_0);

	static string smethod_77(string string_4, char[] char_0)
	{
		//Discarded unreachable code: IL_000e, IL_0024, IL_0029
		//IL_0003: Incompatible stack heights: 0 vs 1
		do
		{
			checked
			{
				_ = (ulong)/*Error near IL_0001: Stack underflow*/;
			}
		}
		while (4 <= (nint)char_0);
		/*Error near IL_0009: Invalid metadata token*/;
	}

	static extern Process smethod_78();

	static extern IntPtr smethod_79(Process process_0);

	static extern FileSystemWatcher smethod_80();

	static string smethod_81(Environment.SpecialFolder specialFolder_0)
	{
		/*Error near IL_0002: stloc 2 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	unsafe static void smethod_82(FileSystemWatcher fileSystemWatcher_1, string string_4)
	{
		_ = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
	}

	static extern void smethod_83(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0);

	unsafe static void smethod_84(FileSystemWatcher fileSystemWatcher_1, string string_4)
	{
		//Discarded unreachable code: IL_0010, IL_0015, IL_001b, IL_0030
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_000b: Expected F4, but got I4
		//IL_0028: Expected I4, but got I8
		uint num;
		do
		{
			num = checked((uint)/*Error near IL_0002: Stack underflow*/);
		}
		while ((int)/*Error near IL_0007: Stack underflow*/ == (int)num);
		int num2 = *(int*)(nint)/*Error near IL_0007: ldloc 0 (out-of-bounds)*/;
		*(float*)(nint)/*Error near IL_000b: Stack underflow*/ = num2;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	static extern void smethod_85(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0);

	static extern void smethod_86(FileSystemWatcher fileSystemWatcher_1, bool bool_5);

	static extern bool smethod_87(string string_4);

	static extern string[] smethod_88(string string_4, string string_5);

	static extern bool smethod_89(string string_4, string string_5);

	static Match smethod_90(string string_4, string string_5)
	{
		/*Error: Invalid metadata token*/;
	}

	static extern WebHeaderCollection smethod_91(WebClient webClient_0);

	static extern void smethod_92(WebHeaderCollection webHeaderCollection_0, HttpRequestHeader httpRequestHeader_0, string string_4);
}
