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
using System.Security.Principal;
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

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_5);

	private static extern void smethod_0();

	private static extern void smethod_1(string string_4, string string_5, bool bool_5);

	public static extern string smethod_2(string string_4);

	private static extern void smethod_3(string string_4, string string_5, string string_6);

	private static extern void smethod_4();

	private static extern void smethod_5(string string_4);

	private static extern void Main();

	private unsafe static bool smethod_6()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		_003F val;
		do
		{
			uint num = ((uint[])(*(long*)(*(sbyte*)(long)/*Error near IL_0001: Stack underflow*/)))[3.639798258909968E-13];
			val = checked(/*Error near IL_0011: Stack underflow*/ * num);
		}
		while (/*Error near IL_0016: Stack underflow*/ < val);
		_ = 1.3072809821636831E+234;
		/*Error: Unexpected end of block*/;
	}

	private static extern string smethod_7();

	private static extern void smethod_8();

	private static extern void smethod_9(object sender, FileSystemEventArgs e);

	private static void smethod_10()
	{
		//Discarded unreachable code: IL_000a
		//IL_0006: Expected I8, but got F4
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected F8, but got Unknown
		((long[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/] = 0L;
		/*Error near IL_0006: stloc 3 (out-of-bounds)*/;
		_ = /*Error near IL_0009: Stack underflow*/% /*Error near IL_0009: Stack underflow*/;
		/*Error near IL_0009: Unknown opcode: 0xFF*/;
	}

	private static extern void smethod_11();

	public static extern bool smethod_12(string string_4);

	public extern Class5();

	static extern string smethod_13(string string_4);

	static extern Assembly smethod_14();

	static extern Stream smethod_15(Assembly assembly_0, string string_4);

	static extern string smethod_16(string string_4, string string_5, string string_6);

	static FileStream smethod_17(string string_4, FileMode fileMode_0, FileAccess fileAccess_0)
	{
		//Discarded unreachable code: IL_0002
		/*Error near IL_0001: Unknown opcode: 0xF8*/;
	}

	static extern void smethod_18(Stream stream_0, Stream stream_1);

	static extern void smethod_19(Stream stream_0);

	static extern void smethod_20(IDisposable idisposable_0);

	static extern Process smethod_21();

	static extern ProcessStartInfo smethod_22(Process process_0);

	static extern void smethod_23(ProcessStartInfo processStartInfo_0, string string_4);

	static extern void smethod_24(ProcessStartInfo processStartInfo_0, bool bool_5);

	static extern void smethod_25(ProcessStartInfo processStartInfo_0, string string_4);

	static extern bool smethod_26(Process process_0);

	static extern Process smethod_27(string string_4);

	static extern byte[] smethod_28(string string_4);

	unsafe static RijndaelManaged smethod_29()
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			((IntPtr[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (IntPtr)/*Error near IL_0002: Stack underflow*/;
			*(_003F*)(nint)/*Error near IL_0003: Stack underflow*/ = /*Error near IL_0003: Stack underflow*/;
			byte num = *(byte*)(nint)/*Error near IL_0004: Stack underflow*/;
			uint num2;
			checked
			{
				num2 = (uint)unchecked((nuint)(/*Error near IL_0005: Stack underflow*/ & num));
			}
			*(IntPtr*)(nint)checked(/*Error near IL_0008: Stack underflow*/ * num2) = (IntPtr)6;
			((IntPtr[])/*Error near IL_000c: Stack underflow*/)[/*Error near IL_000c: Stack underflow*/] = (IntPtr)/*Error near IL_000c: Stack underflow*/;
		}
		while (/*Error near IL_0011: Stack underflow*/ >= /*Error near IL_0011: Stack underflow*/);
		switch (checked((nint)/*Error near IL_0013: Stack underflow*/))
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static extern void smethod_30(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern void smethod_31(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	unsafe static Encoding smethod_32()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected I4, but got F4
		//IL_0013: Invalid comparison between Unknown and I4
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/)
			{
				*(_003F*)(nint)/*Error near IL_0006: Stack underflow*/ = /*Error near IL_0006: Stack underflow*/;
				ushort num = ((ushort[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/];
				ushort num2 = checked((ushort)(/*Error near IL_0008: Stack underflow*/ ^ num));
				((IntPtr[])/*Error near IL_000a: Stack underflow*/)[/*Error near IL_000a: Stack underflow*/] = (IntPtr)(int)num2;
				_003F val2;
				checked
				{
					_003F val = /*Error near IL_000b: Stack underflow*/+ /*Error near IL_000b: Stack underflow*/;
					val2 = /*Error near IL_000c: Stack underflow*/- val;
				}
				_ = ((object[])/*Error near IL_000e: Stack underflow*/)[(int)val2];
				/*Error near IL_000e: stloc 1 (out-of-bounds)*/;
				float num3 = *(float*)(nint)/*Error near IL_0011: Stack underflow*/;
				((short[])/*Error near IL_0012: Stack underflow*/)[/*Error near IL_0012: Stack underflow*/] = (short)(int)num3;
				int num4 = (int)/*Error near IL_0013: Stack underflow*/;
				if ((int)/*Error near IL_0018: Stack underflow*/ <= num4)
				{
					break;
				}
			}
		}
		checked
		{
			throw (ulong)unchecked((uint)/*Error near IL_0019: ldloca 0 (out-of-bounds)*/);
		}
	}

	static extern byte[] smethod_33(Encoding encoding_0, string string_4);

	static void smethod_34(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_0001, IL_0006, IL_000c
		/*Error: Unknown opcode: 0xFF*/;
	}

	static extern void smethod_35(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_36(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	unsafe static void smethod_37(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0)
	{
		//IL_0004: Expected F8, but got I4
		ushort num = ((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		int num2;
		checked
		{
			num2 = unchecked((int)num) + unchecked((int)num);
		}
		*(double*)(nint)/*Error near IL_0004: Stack underflow*/ = num2;
		/*Error near IL_0004: Invalid metadata token*/;
	}

	static extern byte[] smethod_38(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern byte[] smethod_39(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern ICryptoTransform smethod_40(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static extern byte[] smethod_41(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static extern Encoding smethod_42();

	static extern string smethod_43(Encoding encoding_0, byte[] byte_0);

	static extern RegistryKey smethod_44(RegistryKey registryKey_0, string string_4, RegistryKeyPermissionCheck registryKeyPermissionCheck_0);

	static RegistryKey smethod_45(RegistryKey registryKey_0, string string_4)
	{
		//Discarded unreachable code: IL_0017, IL_001e, IL_0024, IL_0027, IL_002c
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got F4
		_ = -checked((short)(/*Error near IL_0003: Stack underflow*/ | /*Error near IL_0003: Stack underflow*/));
		_ = (sbyte)0;
		/*Error near IL_0012: Invalid metadata token*/;
	}

	static void smethod_46(RegistryKey registryKey_0, string string_4, object object_0, RegistryValueKind registryValueKind_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0002: Stack underflow*// /*Error near IL_0002: Stack underflow*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static object smethod_47(RegistryKey registryKey_0, string string_4)
	{
		return (object)/*Error near IL_0001: Stack underflow*/;
	}

	static extern ProcessStartInfo smethod_48();

	static extern void smethod_49(ProcessStartInfo processStartInfo_0, string string_4);

	static extern void smethod_50(ProcessStartInfo processStartInfo_0, bool bool_5);

	static extern void smethod_51(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static extern void smethod_52(ProcessStartInfo processStartInfo_0, bool bool_5);

	static extern void smethod_53(Process process_0, ProcessStartInfo processStartInfo_0);

	static StreamReader smethod_54(Process process_0)
	{
		//Discarded unreachable code: IL_0011, IL_0016, IL_001c, IL_0023, IL_0025, IL_002d, IL_0036
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected I4, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected I8, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unsupported input type for neg.
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/)
			{
				sbyte num = checked((sbyte)/*Error near IL_0006: Stack underflow*/);
				if ((int)/*Error near IL_000c: Stack underflow*/ != num)
				{
					break;
				}
			}
		}
		/*Error near IL_000c: Invalid metadata token*/;
	}

	static extern string smethod_55(TextReader textReader_0);

	static bool smethod_56(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_000e, IL_0015, IL_0021, IL_0027, IL_002f, IL_0036
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Expected I8, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unsupported input type for neg.
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected F8, but got Unknown
		//IL_0022: Invalid comparison between Unknown and I4
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_0038: Expected I4, but got I8
		((sbyte[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (sbyte)/*Error near IL_0002: Stack underflow*/;
		nint num = checked((nint)/*Error near IL_0003: Stack underflow*/);
		_003F val = /*Error near IL_0004: Stack underflow*/* num;
		((long[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (long)val;
		_ = -(/*Error near IL_0008: Stack underflow*/ / /*Error near IL_0008: Stack underflow*/);
		/*Error near IL_0009: Invalid metadata token*/;
	}

	unsafe static bool smethod_57(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_000d, IL_0013, IL_001b
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected F8, but got Unknown
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_0016: Invalid comparison between Unknown and I4
		_003F val = /*Error near IL_0002: Stack underflow*/<< (int)/*Error near IL_0002: Stack underflow*/;
		((double[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (double)val;
		*(string**)(nint)/*Error near IL_0007: Stack underflow*/ = &string_4;
		checked
		{
			_ = (ushort)/*Error near IL_0008: Stack underflow*/;
			/*Error near IL_0008: Invalid metadata token*/;
		}
	}

	static extern bool smethod_58(StreamReader streamReader_0);

	static extern string smethod_59(Assembly assembly_0);

	static extern string smethod_60(string string_4, string string_5);

	static extern void smethod_61(string string_4, string string_5, bool bool_5);

	static RegistryKey smethod_62(RegistryKey registryKey_0, string string_4, bool bool_5)
	{
		//Discarded unreachable code: IL_0007, IL_000d, IL_0014
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected I4, but got Unknown
		checked
		{
			_ = (short)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	static extern void smethod_63(RegistryKey registryKey_0, string string_4, object object_0);

	static extern WindowsIdentity smethod_64();

	static extern WindowsPrincipal smethod_65(WindowsIdentity windowsIdentity_0);

	static extern bool smethod_66(WindowsPrincipal windowsPrincipal_0, WindowsBuiltInRole windowsBuiltInRole_0);

	static extern Assembly smethod_67();

	static extern string smethod_68(string string_4);

	static extern bool smethod_69(string string_4, string string_5);

	unsafe static WebClient smethod_70()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected I8, but got I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected F4, but got Unknown
		//IL_003d: Unsupported input type for neg.
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			_003F val = /*Error: ldarg 3 (out-of-bounds)*/;
			_003F val2 = /*Error near IL_0002: Stack underflow*/<< (int)val;
			long num = ((long[])/*Error near IL_0004: Stack underflow*/)[val2];
			if (/*Error near IL_0005: Stack underflow*/ - num <= /*Error near IL_0005: ldloc 1 (out-of-bounds)*/)
			{
				continue;
			}
			_003F val3 = /*Error near IL_000b: ldarga 0 (out-of-bounds)*/;
			byte num2 = (byte)0;
			((int[])/*Error near IL_0014: Stack underflow*/)[val3] = num2;
			int num3 = checked((int)/*Error near IL_0016: Stack underflow*/);
			if ((int)/*Error near IL_001b: Stack underflow*/ == num3)
			{
				continue;
			}
			*(_003F*)(nint)/*Error near IL_001c: Stack underflow*/ = /*Error near IL_001c: Stack underflow*/;
			object obj = *(object*)(nint)/*Error near IL_001d: Stack underflow*/;
			_003F val4 = /*Error near IL_001f: Stack underflow*/& obj;
			_003F val5 = /*Error near IL_001f: ldarg 0 (out-of-bounds)*/;
			/*OpCode not supported: DebugBreak*/;
			uint num4;
			checked
			{
				num4 = (uint)(/*Error near IL_0028: Stack underflow*/ << unchecked(val4 * val5));
			}
			((long[])/*Error near IL_002b: Stack underflow*/)[/*Error near IL_002b: Stack underflow*/] = (int)num4;
			_003F val6 = /*Error near IL_002e: Stack underflow*/* null;
			((float[])/*Error near IL_0032: Stack underflow*/)[/*Error near IL_0032: Stack underflow*/] = (float)val6;
			if (/*Error near IL_0038: Stack underflow*/ > /*Error near IL_0038: Stack underflow*/&& /*Error near IL_003d: Stack underflow*/!= /*Error near IL_003d: Stack underflow*/)
			{
				_003F val7 = 0 - /*Error near IL_003e: Stack underflow*/;
				if (/*Error near IL_0043: Stack underflow*/ <= val7)
				{
					/*Error: Could not find block for branch target IL_0043*/;
				}
			}
		}
	}

	static extern Rectangle smethod_71(Point point_0);

	static extern Bitmap smethod_72(int int_0, int int_1);

	unsafe static Graphics smethod_73(Image image_0)
	{
		//Discarded unreachable code: IL_0009, IL_000e, IL_0021, IL_0028, IL_0034
		//IL_0002: Expected native int or pointer, but got F4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Incompatible stack heights: 0 vs 1
		ushort num = *(ushort*)(nint)(float)(int)(byte)/*Error near IL_0001: Stack underflow*/;
		((IntPtr[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (IntPtr)(int)num;
		/*Error near IL_0004: Invalid metadata token*/;
	}

	unsafe static void smethod_74(Graphics graphics_0, Point point_0, Point point_1, Size size_0)
	{
		//IL_0003: Expected O, but got I8
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		long num = (long)/*Error near IL_0002: Stack underflow*/;
		((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = num;
		/*Error: Unexpected end of block*/;
	}

	static extern ImageFormat smethod_75();

	static extern void smethod_76(Image image_0, string string_4, ImageFormat imageFormat_0);

	static extern bool smethod_77(string string_4);

	static extern void smethod_78(string string_4);

	static void smethod_79(WebClient webClient_0, string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_000c, IL_0019, IL_0028, IL_0033
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got I4
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_80(Process process_0);

	static extern string smethod_81(string string_4);

	static extern string[] smethod_82(string string_4, char[] char_0);

	static string smethod_83(WebClient webClient_0, string string_4)
	{
		//Discarded unreachable code: IL_0001, IL_0008
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Unknown opcode: 0xFC*/;
	}

	static extern string smethod_84();

	static string smethod_85(string[] string_4)
	{
		switch (((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/])
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static void smethod_86(int int_0)
	{
		//Discarded unreachable code: IL_0008, IL_000f, IL_0016
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I8
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		((long[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (long)/*Error near IL_0001: Stack underflow*/;
		_ = /*Error near IL_0002: Stack underflow*/- /*Error near IL_0002: Stack underflow*/;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	unsafe static Process smethod_87()
	{
		throw ((double[])6)[1 / (int)(*(ushort*)4)];
	}

	static extern IntPtr smethod_88(Process process_0);

	static extern NetworkInterface[] smethod_89();

	static extern OperationalStatus smethod_90(NetworkInterface networkInterface_0);

	static extern PhysicalAddress smethod_91(NetworkInterface networkInterface_0);

	static extern string smethod_92(object object_0);

	static extern string smethod_93(string string_4, char[] char_0);

	static extern FileSystemWatcher smethod_94();

	static extern string smethod_95(Environment.SpecialFolder specialFolder_0);

	static extern void smethod_96(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static void smethod_97(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		while (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/)
		{
		}
		uint num = checked((uint)(object)null);
		_ = (byte)(/*Error near IL_0008: Stack underflow*/ | num);
		/*Error: Unexpected end of block*/;
	}

	static extern void smethod_98(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static extern void smethod_99(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0);

	static extern void smethod_100(FileSystemWatcher fileSystemWatcher_1, bool bool_5);

	static extern bool smethod_101(string string_4);

	static extern string[] smethod_102(string string_4, string string_5);

	static bool smethod_103(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0009, IL_0010, IL_0015, IL_0021
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected I8, but got F8
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0002: Stack underflow*/+ 1;
		/*Error near IL_0004: Invalid metadata token*/;
	}

	static Match smethod_104(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0012, IL_0017, IL_001f, IL_0028
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		checked
		{
			_ = (byte)(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			_ = -26;
			/*Error near IL_000b: stloc 0 (out-of-bounds)*/;
			/*Error near IL_000d: Invalid metadata token*/;
		}
	}

	static extern WebHeaderCollection smethod_105(WebClient webClient_0);

	static extern void smethod_106(WebHeaderCollection webHeaderCollection_0, HttpRequestHeader httpRequestHeader_0, string string_4);
}
