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

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string string_4);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_5);

	public static extern string smethod_0(string string_4);

	private static extern string smethod_1();

	private unsafe static void Main()
	{
		//Discarded unreachable code: IL_0008, IL_000d, IL_0017, IL_0020, IL_0025, IL_002b
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected I, but got Unknown
		//IL_001b: Expected F4, but got I
		_003F val = /*Error near IL_0002: Stack underflow*/^ /*Error near IL_0002: Stack underflow*/;
		*(IntPtr*)(nint)/*Error near IL_0003: Stack underflow*/ = (IntPtr)val;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	private static extern void smethod_2();

	private static bool smethod_3()
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0012, IL_0018, IL_0020, IL_0026, IL_002b, IL_0031, IL_0036, IL_003c
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: Invalid metadata token*/;
	}

	private static extern bool smethod_4();

	private static extern bool smethod_5();

	private static extern string smethod_6();

	private static extern void smethod_7();

	private static extern void smethod_8();

	public static extern bool smethod_9(string string_4);

	public extern Class5();

	static byte[] smethod_10(string string_4)
	{
		//Discarded unreachable code: IL_000a, IL_0010, IL_0020
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		while ((int)/*Error near IL_0005: Stack underflow*/ != 0)
		{
		}
		/*Error near IL_0005: Invalid metadata token*/;
	}

	static RijndaelManaged smethod_11()
	{
		//Discarded unreachable code: IL_000c, IL_0011, IL_0017, IL_001e, IL_001f, IL_0031, IL_0036, IL_0037
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected I, but got I8
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and F8
		//IL_0034: Incompatible stack heights: 1 vs 0
		while (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
		{
		}
		ushort num = checked((ushort)/*Error near IL_0006: Stack underflow*/);
		_ = /*Error near IL_0007: Stack underflow*/+ num;
		/*Error near IL_0007: Invalid metadata token*/;
	}

	static extern void smethod_12(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern void smethod_13(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern Encoding smethod_14();

	static byte[] smethod_15(Encoding encoding_0, string string_4)
	{
		//Discarded unreachable code: IL_000f, IL_0020, IL_0026, IL_002b, IL_0030, IL_0035, IL_003a, IL_003f
		//IL_0010: Unsupported input type for neg.
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Incompatible stack heights: 0 vs 1
		_ = 4294967295L;
		/*Error near IL_000a: Invalid metadata token*/;
	}

	static extern void smethod_16(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_17(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_18(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	static extern void smethod_19(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	unsafe static byte[] smethod_20(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		while (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
		{
		}
		_ = (int)/*Error near IL_0006: Stack underflow*/;
		/*Error near IL_0006: stloc 1 (out-of-bounds)*/;
		_ = *(float*)(int)checked((ushort)(*unchecked((double*)(nint)/*Error near IL_0009: Stack underflow*/)));
		/*Error: Unexpected end of block*/;
	}

	static extern byte[] smethod_21(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern ICryptoTransform smethod_22(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static extern byte[] smethod_23(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static extern Encoding smethod_24();

	static extern string smethod_25(Encoding encoding_0, byte[] byte_0);

	unsafe static void smethod_26(IDisposable idisposable_0)
	{
		//Discarded unreachable code: IL_000f
		while (true)
		{
			((object[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (object)/*Error near IL_0001: Stack underflow*/;
			*(_003F*)(nint)/*Error near IL_0002: Stack underflow*/ = /*Error near IL_0002: Stack underflow*/;
			if (/*Error near IL_0008: Stack underflow*/ == /*Error near IL_0008: Stack underflow*/)
			{
				((sbyte[])/*Error near IL_0009: Stack underflow*/)[/*Error near IL_0009: Stack underflow*/] = (sbyte)/*Error near IL_0009: Stack underflow*/;
			}
		}
	}

	static string smethod_27(string string_4)
	{
		//Discarded unreachable code: IL_0005, IL_0006
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static extern WebClient smethod_28();

	static extern string smethod_29(string string_4, string string_5);

	static void smethod_30(WebClient webClient_0, string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0019
		//IL_0014: Incompatible stack heights: 0 vs 1
		while (true)
		{
			((object[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (object)/*Error near IL_0001: Stack underflow*/;
			if (/*Error near IL_0006: Stack underflow*/ != /*Error near IL_0006: Stack underflow*/&& (int)/*Error near IL_000b: Stack underflow*/ == 0 && /*Error near IL_0011: Stack underflow*/< /*Error near IL_0011: Stack underflow*/)
			{
				_ = 7;
			}
		}
	}

	static extern void smethod_31(Component component_0);

	static extern Process smethod_32();

	static extern ProcessStartInfo smethod_33();

	static extern void smethod_34(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static extern void smethod_35(ProcessStartInfo processStartInfo_0, string string_4);

	static extern string smethod_36(string string_4, string string_5, string string_6);

	static void smethod_37(ProcessStartInfo processStartInfo_0, string string_4)
	{
		//IL_0003: Expected F8, but got Unknown
		_003F val = /*Error: ldloca 0 (out-of-bounds)*/;
		((double[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (double)val;
		_ = ((ushort[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/];
	}

	unsafe static void smethod_38(Process process_0, ProcessStartInfo processStartInfo_0)
	{
		//Discarded unreachable code: IL_000d, IL_0017
		nint num;
		checked
		{
			num = (nint)(*unchecked((uint*)checked((ulong)unchecked((nint)/*Error near IL_0001: Stack underflow*/))));
		}
		((int[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/] = (int)num;
		_ = ((ushort[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/];
		/*Error near IL_0008: Invalid metadata token*/;
	}

	static bool smethod_39(Process process_0)
	{
		//Discarded unreachable code: IL_0005, IL_000e, IL_0014
		//IL_0009: Incompatible stack heights: 0 vs 2
		/*Error: Invalid metadata token*/;
	}

	unsafe static void smethod_40(int int_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		_003F val;
		checked
		{
			int num = (int)/*Error near IL_0001: Stack underflow*/;
			val = /*Error near IL_0002: Stack underflow*/* num;
		}
		_ = *(double*)(*(ushort*)(nint)checked(/*Error near IL_0004: Stack underflow*/ - val));
		/*Error: Unexpected end of block*/;
	}

	static void smethod_41(string string_4)
	{
		//Discarded unreachable code: IL_0008, IL_000e, IL_0014
		checked
		{
			_ = (long)unchecked((ushort)/*Error near IL_0001: Stack underflow*/);
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	static extern string smethod_42(string string_4);

	static Assembly smethod_43()
	{
		//Discarded unreachable code: IL_0008
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		/*Error: stloc 3 (out-of-bounds)*/;
		/*OpCode not supported: Ckfinite*/;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static extern string smethod_44(Assembly assembly_0);

	unsafe static void smethod_45(string string_4, string string_5, bool bool_5)
	{
		do
		{
			ushort num = (ushort)/*Error near IL_0001: Stack underflow*/;
			*(int*)(nint)/*Error near IL_0002: Stack underflow*/ = num;
		}
		while (/*Error near IL_0007: Stack underflow*/ != /*Error near IL_0007: Stack underflow*/);
		((sbyte[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (sbyte)/*Error near IL_0008: Stack underflow*/;
	}

	static extern RegistryKey smethod_46(RegistryKey registryKey_0, string string_4, bool bool_5);

	static void smethod_47(RegistryKey registryKey_0, string string_4, object object_0)
	{
		/*OpCode not supported: DebugBreak*/;
	}

	static void smethod_48(string string_4, FileAttributes fileAttributes_0)
	{
		//Discarded unreachable code: IL_0005, IL_0014, IL_001a, IL_001f
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected F4, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected F8, but got I4
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static extern Rectangle smethod_49(Point point_0);

	static extern Bitmap smethod_50(int int_0, int int_1);

	static extern Graphics smethod_51(Image image_0);

	static extern void smethod_52(Graphics graphics_0, Point point_0, Point point_1, Size size_0);

	static ImageFormat smethod_53()
	{
		//Discarded unreachable code: IL_0006, IL_0016, IL_001b, IL_0020, IL_0025, IL_002e
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static void smethod_54(Image image_0, string string_4, ImageFormat imageFormat_0)
	{
		//Discarded unreachable code: IL_0006, IL_000c, IL_0011, IL_001a
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = ~/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern bool smethod_55(string string_4);

	static extern void smethod_56(Process process_0);

	static extern string[] smethod_57(string string_4, char[] char_0);

	static string smethod_58(WebClient webClient_0, string string_4)
	{
		//Discarded unreachable code: IL_0006, IL_001b
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (long)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	unsafe static string smethod_59()
	{
		//Discarded unreachable code: IL_0011, IL_0023, IL_0028, IL_002d, IL_0038, IL_0040
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected F4, but got I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Incompatible stack heights: 0 vs 1
		while (/*Error near IL_0003: Stack underflow*/ <= /*Error near IL_0003: Stack underflow*/)
		{
			_003F val = checked(/*Error near IL_0004: Stack underflow*/ - /*Error near IL_0004: Stack underflow*/);
			if (/*Error near IL_0009: Stack underflow*/ < val)
			{
				*(_003F*)(nint)/*Error near IL_000b: Stack underflow*/ = /*Error near IL_000b: Stack underflow*/;
				_ = -1;
				/*Error near IL_000c: Invalid metadata token*/;
			}
		}
		if (/*Error near IL_0032: Stack underflow*/ < /*Error near IL_0032: Stack underflow*/)
		{
			/*Error near IL_0033: Invalid metadata token*/;
		}
		/*Error: Unexpected end of block*/;
	}

	static extern string smethod_60();

	static extern string smethod_61(string[] string_4);

	static extern void smethod_62(string string_4, string string_5);

	static extern Process[] smethod_63();

	unsafe static string smethod_64(Process process_0)
	{
		//Discarded unreachable code: IL_0012
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		while (*(IntPtr*)(nint)/*Error near IL_0001: Stack underflow*/ == (IntPtr)0)
		{
		}
		*(_003F*)(nint)/*Error near IL_0008: Stack underflow*/ = /*Error near IL_0008: Stack underflow*/;
		nuint num;
		checked
		{
			num = (nuint)unchecked((int)checked((uint)unchecked((int)(byte)/*Error near IL_000a: Stack underflow*/)));
		}
		_ = *(object*)(nint)(/*Error near IL_000e: Stack underflow*/ + num);
		/*Error near IL_0011: Unknown opcode: 0xFD*/;
	}

	static extern void smethod_65(Process process_0);

	static extern Process smethod_66();

	static extern IntPtr smethod_67(Process process_0);

	static extern ManagementObjectSearcher smethod_68(string string_4);

	static extern ManagementObjectCollection smethod_69(ManagementObjectSearcher managementObjectSearcher_0);

	static extern ManagementObjectEnumerator smethod_70(ManagementObjectCollection managementObjectCollection_0);

	static extern ManagementBaseObject smethod_71(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern object smethod_72(ManagementBaseObject managementBaseObject_0, string string_4);

	static extern string smethod_73(object object_0);

	static extern string smethod_74(string string_4);

	static bool smethod_75(string string_4, string string_5)
	{
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern string smethod_76(string string_4);

	static extern bool smethod_77(string string_4, string string_5);

	static extern bool smethod_78(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern NetworkInterface[] smethod_79();

	static extern OperationalStatus smethod_80(NetworkInterface networkInterface_0);

	unsafe static PhysicalAddress smethod_81(NetworkInterface networkInterface_0)
	{
		do
		{
			/*Error: stloc 3 (out-of-bounds)*/;
		}
		while (/*Error near IL_0007: Stack underflow*/ >= /*Error near IL_0007: Stack underflow*/);
		_ = *(IntPtr*)(nint)/*Error near IL_0008: Stack underflow*/;
		_ = (double)(int)(*(ushort*)(-4));
		/*Error: Unexpected end of block*/;
	}

	static string smethod_82(string string_4, char[] char_0)
	{
		//Discarded unreachable code: IL_0015, IL_001a, IL_0022
		//IL_0006: Invalid comparison between Unknown and I4
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
			{
				uint num = checked((uint)/*Error near IL_0006: Stack underflow*/);
				if ((int)/*Error near IL_000b: Stack underflow*/ <= (int)num && (int)/*Error near IL_0010: Stack underflow*/ != 0)
				{
					break;
				}
			}
		}
		/*Error near IL_0010: Invalid metadata token*/;
	}

	static extern string smethod_83(Environment.SpecialFolder specialFolder_0);

	static extern bool smethod_84(string string_4);

	static extern string[] smethod_85(string string_4, string string_5);

	unsafe static Match smethod_86(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_000e, IL_0013
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected I4, but got Unknown
		ushort num;
		do
		{
			num = *(ushort*)(nint)/*Error near IL_0002: Stack underflow*/;
		}
		while ((int)/*Error near IL_0007: Stack underflow*/ <= (int)num);
		_ = ((sbyte[])/*Error near IL_0009: Stack underflow*/)[/*Error near IL_0009: Stack underflow*/];
		/*Error near IL_0009: Invalid metadata token*/;
	}

	static extern WebHeaderCollection smethod_87(WebClient webClient_0);

	static extern void smethod_88(WebHeaderCollection webHeaderCollection_0, HttpRequestHeader httpRequestHeader_0, string string_4);
}
