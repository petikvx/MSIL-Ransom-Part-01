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

	private unsafe static void smethod_0()
	{
		//Discarded unreachable code: IL_0010, IL_0018, IL_0027, IL_0032
		//IL_0013: Invalid comparison between Unknown and I
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected I4, but got Unknown
		checked
		{
			while (true)
			{
				uint num = (uint)/*Error near IL_0001: Stack underflow*/;
				((IntPtr[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = unchecked((IntPtr)(int)num);
				if (/*Error near IL_0007: Stack underflow*/ <= /*Error near IL_0007: Stack underflow*/)
				{
					short num2 = (short)(*unchecked((nint*)(nint)/*Error near IL_0009: Stack underflow*/));
					((short[])/*Error near IL_000b: Stack underflow*/)[/*Error near IL_000b: Stack underflow*/] = num2;
				}
			}
		}
	}

	private static extern void smethod_1(string string_4, string string_5, bool bool_5);

	public static extern string smethod_2(string string_4);

	private static extern string smethod_3();

	private static extern void Main();

	private static extern string smethod_4();

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_5);

	private unsafe static bool smethod_5()
	{
		//Discarded unreachable code: IL_000b
		_ = (float)/*Error near IL_0001: Stack underflow*/;
		_ = *(byte*)(int)(checked((uint)/*Error near IL_0001: ldloc 0 (out-of-bounds)*/) * 4);
		/*Error near IL_0006: Invalid metadata token*/;
	}

	private static void smethod_6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		_003F val;
		do
		{
			val = /*Error near IL_0001: Stack underflow*/% /*Error near IL_0001: Stack underflow*/;
		}
		while (/*Error near IL_0007: Stack underflow*/ >= val || /*Error near IL_000e: Stack underflow*/<= /*Error near IL_000e: Stack underflow*/);
		ushort num = ((ushort[])/*Error near IL_000f: Stack underflow*/)[/*Error near IL_000f: Stack underflow*/];
		checked
		{
			sbyte num2 = (sbyte)(/*Error near IL_0010: Stack underflow*/ + num);
			_ = (ulong)/*Error near IL_0011: ldloc 0 (out-of-bounds)*/;
			/*Error near IL_0013: stloc 0 (out-of-bounds)*/;
			_ = ((short[])/*Error near IL_0016: Stack underflow*/)[num2];
			/*Error near IL_0017: ldloc 0 (out-of-bounds)*/;
			/*Error: Unexpected end of block*/;
		}
	}

	private static void smethod_7(object sender, FileSystemEventArgs e)
	{
		//Discarded unreachable code: IL_000a
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected I4, but got Unknown
		_003F val;
		do
		{
			val = checked(/*Error near IL_0003: Stack underflow*/ * null);
		}
		while (/*Error near IL_0008: Stack underflow*/ < val);
		/*Error near IL_0008: stloc 3 (out-of-bounds)*/;
		/*Error near IL_0009: Unknown opcode: 0xFF*/;
	}

	private static extern void smethod_8();

	private static void smethod_9()
	{
		//Discarded unreachable code: IL_0006, IL_000c
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		_ = 1323573201;
		/*Error near IL_0005: Unknown opcode: 0xF8*/;
	}

	public static extern bool smethod_10(string string_4);

	public extern Class5();

	static extern string smethod_11(string string_4);

	static Assembly smethod_12()
	{
		_ = (sbyte)/*Error near IL_0001: Stack underflow*/;
		throw null;
	}

	static Stream smethod_13(Assembly assembly_0, string string_4)
	{
		//Discarded unreachable code: IL_0006, IL_000f, IL_0019
		_ = ((sbyte[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern string smethod_14(string string_4, string string_5, string string_6);

	static extern FileStream smethod_15(string string_4, FileMode fileMode_0, FileAccess fileAccess_0);

	static extern void smethod_16(Stream stream_0, Stream stream_1);

	static extern void smethod_17(Stream stream_0);

	static void smethod_18(IDisposable idisposable_0)
	{
		//Discarded unreachable code: IL_0004, IL_0009, IL_0013, IL_0019, IL_001e, IL_0028, IL_0031, IL_003d
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		checked
		{
			_ = (byte)(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			/*Error near IL_0003: Unknown opcode: 0xFC*/;
		}
	}

	static extern Process smethod_19();

	unsafe static ProcessStartInfo smethod_20(Process process_0)
	{
		//Discarded unreachable code: IL_002c, IL_002f
		//IL_0004: Invalid comparison between Unknown and I4
		while (true)
		{
			/*Error: stloc 0 (out-of-bounds)*/;
			short num = *(short*)(*(sbyte*)(nint)/*Error near IL_0002: Stack underflow*/);
			ushort num2 = ((ushort[])/*Error near IL_0004: Stack underflow*/)[num];
			if ((int)/*Error near IL_0009: Stack underflow*/ != num2)
			{
				continue;
			}
			((object[])/*Error near IL_000a: Stack underflow*/)[/*Error near IL_000a: Stack underflow*/] = (object)/*Error near IL_000a: Stack underflow*/;
			if (((IntPtr[])(-60))[(object)null] == (IntPtr)0)
			{
				((object[])/*Error near IL_0017: Stack underflow*/)[/*Error near IL_0017: Stack underflow*/] = (object)/*Error near IL_0017: Stack underflow*/;
				if ((nint)(int)/*Error near IL_0018: Stack underflow*/ == 0)
				{
					break;
				}
			}
		}
		_ = unchecked((nuint)"");
		/*Error near IL_0027: Invalid metadata token*/;
	}

	static extern void smethod_21(ProcessStartInfo processStartInfo_0, string string_4);

	static extern void smethod_22(ProcessStartInfo processStartInfo_0, bool bool_5);

	static extern void smethod_23(ProcessStartInfo processStartInfo_0, string string_4);

	static extern bool smethod_24(Process process_0);

	static Process smethod_25(string string_4)
	{
		//Discarded unreachable code: IL_0021, IL_002a, IL_0034, IL_0037
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got I4
		//IL_0025: Expected O, but got I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if ((byte)(/*Error near IL_0002: Stack underflow*/ / /*Error near IL_0002: Stack underflow*/) != 0)
			{
				_003F val = /*Error near IL_0011: Stack underflow*// 884554843;
				_003F val2 = /*Error near IL_0013: Stack underflow*/>> (int)val;
				if (/*Error near IL_0019: Stack underflow*/ > val2)
				{
					break;
				}
			}
		}
		ushort num = checked((ushort)/*Error near IL_001a: Stack underflow*/);
		_ = /*Error near IL_001b: Stack underflow*/* num;
		/*Error near IL_001c: Invalid metadata token*/;
	}

	static byte[] smethod_26(string string_4)
	{
		//Discarded unreachable code: IL_000a, IL_0013, IL_001d, IL_0020, IL_0033
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got I4
		//IL_000e: Expected O, but got I4
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I8
		ushort num = checked((ushort)(object)string_4);
		_ = /*Error near IL_0004: Stack underflow*/* num;
		/*Error near IL_0005: Invalid metadata token*/;
	}

	static RijndaelManaged smethod_27()
	{
		//Discarded unreachable code: IL_0005, IL_0006, IL_0019, IL_0020, IL_0026, IL_002d
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I8
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I8
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_28(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static void smethod_29(SymmetricAlgorithm symmetricAlgorithm_0, int int_0)
	{
		//Discarded unreachable code: IL_0011, IL_0018
		while (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/)
		{
		}
		/*Error near IL_000c: Invalid metadata token*/;
	}

	static extern Encoding smethod_30();

	static extern byte[] smethod_31(Encoding encoding_0, string string_4);

	static extern void smethod_32(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_33(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static void smethod_34(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0)
	{
		//Discarded unreachable code: IL_0005, IL_000c, IL_0011
		//IL_0007: Invalid comparison between Unknown and I4
		while (true)
		{
		}
	}

	static extern void smethod_35(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static extern byte[] smethod_36(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern byte[] smethod_37(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern ICryptoTransform smethod_38(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static extern byte[] smethod_39(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static Encoding smethod_40()
	{
		//Discarded unreachable code: IL_0006, IL_0009, IL_000e, IL_0013, IL_001b, IL_001d, IL_0023, IL_0024
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Incompatible stack heights: 0 vs 1
		//IL_0023: Incompatible stack heights: 0 vs 1
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static string smethod_41(Encoding encoding_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_0007, IL_0009, IL_000f, IL_0010, IL_001d
		//IL_000f: Incompatible stack heights: 0 vs 1
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
		}
	}

	static extern WebClient smethod_42();

	static extern string smethod_43(string string_4, string string_5);

	static extern void smethod_44(WebClient webClient_0, string string_4, string string_5);

	static void smethod_45(Component component_0)
	{
		/*Error: Invalid metadata token*/;
	}

	static extern ProcessStartInfo smethod_46();

	static extern void smethod_47(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static extern void smethod_48(ProcessStartInfo processStartInfo_0, string string_4);

	static extern void smethod_49(Process process_0, ProcessStartInfo processStartInfo_0);

	static void smethod_50(int int_0)
	{
		/*Error: Unexpected end of block*/;
	}

	static extern void smethod_51(string string_4);

	static extern string smethod_52(string string_4);

	static Rectangle smethod_53(Point point_0)
	{
		//Discarded unreachable code: IL_0006, IL_000d
		short num = checked((short)/*Error near IL_0003: Stack underflow*/);
		((short[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = num;
		/*Error near IL_0005: Unknown opcode: 0xFD*/;
	}

	static extern Bitmap smethod_54(int int_0, int int_1);

	static extern Graphics smethod_55(Image image_0);

	static void smethod_56(Graphics graphics_0, Point point_0, Point point_1, Size size_0)
	{
		//Discarded unreachable code: IL_000e, IL_0013, IL_001a, IL_001f, IL_0024
		//IL_0006: Expected I4, but got Unknown
		while (true)
		{
			_003F val = /*Error near IL_0002: ldloc 1 (out-of-bounds)*/;
			((int[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/] = (int)val;
			/*OpCode not supported: DebugBreak*/;
		}
	}

	static extern ImageFormat smethod_57();

	static extern void smethod_58(Image image_0, string string_4, ImageFormat imageFormat_0);

	static extern bool smethod_59(string string_4);

	static extern void smethod_60(Process process_0);

	static extern string smethod_61(Assembly assembly_0);

	static extern void smethod_62(string string_4, string string_5, bool bool_5);

	static extern RegistryKey smethod_63(RegistryKey registryKey_0, string string_4, bool bool_5);

	static extern void smethod_64(RegistryKey registryKey_0, string string_4, object object_0);

	static extern Assembly smethod_65();

	static extern string smethod_66(string string_4);

	static extern bool smethod_67(string string_4, string string_5);

	static extern string[] smethod_68(string string_4, char[] char_0);

	static string smethod_69(WebClient webClient_0, string string_4)
	{
		//IL_0001: Invalid comparison between Unknown and I4
		uint num;
		do
		{
			num = (uint)/*Error near IL_0001: Stack underflow*/;
		}
		while ((int)/*Error near IL_0006: Stack underflow*/ < (int)num);
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static extern string smethod_70();

	static extern string smethod_71(string[] string_4);

	static extern void smethod_72(string string_4, string string_5);

	static extern NetworkInterface[] smethod_73();

	static extern OperationalStatus smethod_74(NetworkInterface networkInterface_0);

	static extern PhysicalAddress smethod_75(NetworkInterface networkInterface_0);

	static extern string smethod_76(object object_0);

	static string smethod_77(string string_4, char[] char_0)
	{
		//Discarded unreachable code: IL_0011, IL_001c
		//IL_0004: Invalid comparison between Unknown and F8
		while (true)
		{
			((int[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (int)/*Error near IL_0001: Stack underflow*/;
			double num = ((double[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/];
			if ((double)/*Error near IL_0009: Stack underflow*/ >= num)
			{
			}
		}
	}

	static Process smethod_78()
	{
		//Discarded unreachable code: IL_0007, IL_000c, IL_0012
		//IL_000e: Expected O, but got F4
		/*Error near IL_0001: ldarg 2 (out-of-bounds)*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static IntPtr smethod_79(Process process_0)
	{
		//Discarded unreachable code: IL_0005, IL_000f, IL_0014, IL_0019, IL_001b
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static FileSystemWatcher smethod_80()
	{
		//Discarded unreachable code: IL_0005, IL_0007, IL_000e, IL_0010, IL_0016, IL_001c, IL_001e, IL_002e
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	unsafe static string smethod_81(Environment.SpecialFolder specialFolder_0)
	{
		//Discarded unreachable code: IL_0008, IL_000a, IL_001a, IL_0020, IL_0028, IL_002e
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		/*Error: ldloc 3 (out-of-bounds)*/;
		_ = *(IntPtr*)(nint)/*Error near IL_0001: ldarg 1 (out-of-bounds)*/;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static extern void smethod_82(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static void smethod_83(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0)
	{
		//Discarded unreachable code: IL_0007, IL_000c, IL_0014, IL_001a, IL_001f, IL_0024, IL_002a
		checked
		{
			_ = (long)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	static void smethod_84(FileSystemWatcher fileSystemWatcher_1, string string_4)
	{
		/*Error: ldarg 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static extern void smethod_85(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0);

	static extern void smethod_86(FileSystemWatcher fileSystemWatcher_1, bool bool_5);

	static extern bool smethod_87(string string_4);

	static extern string[] smethod_88(string string_4, string string_5);

	static extern bool smethod_89(string string_4, string string_5);

	static extern Match smethod_90(string string_4, string string_5);

	static extern WebHeaderCollection smethod_91(WebClient webClient_0);

	static extern void smethod_92(WebHeaderCollection webHeaderCollection_0, HttpRequestHeader httpRequestHeader_0, string string_4);
}
