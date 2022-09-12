using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
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

	private static extern void Main();

	private static extern void smethod_2();

	private static extern bool smethod_3();

	private static extern bool smethod_4();

	private static bool smethod_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		/*Error: Unexpected end of block*/;
	}

	private static extern string smethod_6();

	private static extern void smethod_7();

	private static void smethod_8()
	{
		//Discarded unreachable code: IL_0007, IL_000a, IL_0010, IL_0016
		((int[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = 4;
		/*Error near IL_0006: Unknown opcode: 0xFD*/;
	}

	public static extern bool smethod_9(string string_4);

	public extern Class5();

	static extern byte[] smethod_10(string string_4);

	unsafe static RijndaelManaged smethod_11()
	{
		//Discarded unreachable code: IL_001c, IL_0024
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Invalid comparison between Unknown and I
		//IL_000e: Expected O, but got I4
		//IL_0016: Expected I4, but got Unknown
		while (true)
		{
			((int[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = 4;
			nint num;
			checked
			{
				num = (nint)unchecked(/*Error near IL_0004: Stack underflow*/ + 2);
			}
			if ((nint)/*Error near IL_000b: Stack underflow*/ >= num)
			{
				double num2 = (double)/*Error near IL_000c: Stack underflow*/;
				((object[])/*Error near IL_000e: Stack underflow*/)[/*Error near IL_000e: Stack underflow*/] = (short)num2;
				if (/*Error near IL_0013: Stack underflow*/ == /*Error near IL_0013: Stack underflow*/)
				{
					break;
				}
			}
		}
		_003F val = /*Error near IL_0013: ldarg 0 (out-of-bounds)*/;
		*(short*)(nint)/*Error near IL_0016: Stack underflow*/ = (short)(int)val;
		_ = null;
		/*Error near IL_0017: Invalid metadata token*/;
	}

	static extern void smethod_12(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	unsafe static void smethod_13(SymmetricAlgorithm symmetricAlgorithm_0, int int_0)
	{
		//IL_0003: Expected I8, but got I4
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected I4, but got Unknown
		do
		{
			((long[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (long)/*Error near IL_0001: Stack underflow*/;
			((long[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = 8L;
		}
		while (/*Error near IL_0008: Stack underflow*/ <= /*Error near IL_0008: Stack underflow*/|| (int)/*Error near IL_0008: ldloca 0 (out-of-bounds)*/ <= (int)(*(byte*)5uL));
		_003F val = /*Error near IL_001b: Stack underflow*/% /*Error near IL_001b: Stack underflow*/;
		((sbyte[])/*Error near IL_001c: Stack underflow*/)[/*Error near IL_001c: Stack underflow*/] = (sbyte)(int)val;
	}

	static extern Encoding smethod_14();

	static extern byte[] smethod_15(Encoding encoding_0, string string_4);

	static extern void smethod_16(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_17(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_18(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	static void smethod_19(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_003F val2;
		do
		{
			_003F val = /*Error: ldloc 0 (out-of-bounds)*/;
			val2 = checked(/*Error near IL_0002: Stack underflow*/ * val);
		}
		while (/*Error near IL_0007: Stack underflow*/ > val2);
		throw /*Error near IL_0008: Stack underflow*/;
	}

	static extern byte[] smethod_20(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern byte[] smethod_21(SymmetricAlgorithm symmetricAlgorithm_0);

	static ICryptoTransform smethod_22(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1)
	{
		//Discarded unreachable code: IL_0007
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static extern byte[] smethod_23(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static extern Encoding smethod_24();

	static extern string smethod_25(Encoding encoding_0, byte[] byte_0);

	static extern void smethod_26(IDisposable idisposable_0);

	static string smethod_27(string string_4)
	{
		switch (/*Error near IL_0005: Stack underflow*/)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static WebClient smethod_28()
	{
		//Discarded unreachable code: IL_0005, IL_000f, IL_0015, IL_001d, IL_002a, IL_0034, IL_0039
		//IL_0007: Expected I8, but got I4
		//IL_000a: Expected I4, but got O
		//IL_0010: Invalid comparison between Unknown and I
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_002d: Expected I8, but got I4
		//IL_002f: Invalid comparison between Unknown and I4
		/*Error: Invalid metadata token*/;
	}

	static string smethod_29(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0008, IL_0015, IL_001a, IL_002b
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected native int or pointer, but got F4
		//IL_0024: Expected O, but got I4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		/*OpCode not supported: Ckfinite*/;
		ulong num = checked((ulong)/*Error near IL_0002: Stack underflow*/);
		_ = /*Error near IL_0003: Stack underflow*// num;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static extern void smethod_30(WebClient webClient_0, string string_4, string string_5);

	static void smethod_31(Component component_0)
	{
		/*Error: Invalid metadata token*/;
	}

	static extern Process smethod_32();

	static extern ProcessStartInfo smethod_33();

	static extern void smethod_34(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static void smethod_35(ProcessStartInfo processStartInfo_0, string string_4)
	{
		while ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
		}
		/*Error near IL_0005: Invalid metadata token*/;
	}

	static extern string smethod_36(string string_4, string string_5, string string_6);

	static extern void smethod_37(ProcessStartInfo processStartInfo_0, string string_4);

	static extern void smethod_38(Process process_0, ProcessStartInfo processStartInfo_0);

	static bool smethod_39(Process process_0)
	{
		//Discarded unreachable code: IL_0013, IL_001b
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		//IL_0005: Invalid comparison between Unknown and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected F8, but got Unknown
		short num2;
		do
		{
			_003F val = /*Error near IL_0001: Stack underflow*/% /*Error near IL_0001: Stack underflow*/;
			((sbyte[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (sbyte)(int)val;
			double num = (double)/*Error near IL_0003: Stack underflow*/;
			num2 = ((short[])/*Error near IL_0004: Stack underflow*/)[num];
		}
		while ((int)/*Error near IL_000a: Stack underflow*/ >= (int)num2 || checked(/*Error near IL_000b: Stack underflow*/ + /*Error near IL_000b: Stack underflow*/) != 0);
		_003F val2 = /*Error near IL_0010: Stack underflow*/;
		_ = ((object[])/*Error near IL_0012: Stack underflow*/)[val2];
		/*Error near IL_0012: Unknown opcode: 0xFC*/;
	}

	static void smethod_40(int int_0)
	{
		//Discarded unreachable code: IL_000f, IL_0015, IL_0021, IL_0026
		//IL_0018: Expected F4, but got I
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Incompatible stack heights: 0 vs 1
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		while (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
		}
		_ = (int)/*Error near IL_0006: Stack underflow*/;
		_ = 4;
		/*Error near IL_000a: Invalid metadata token*/;
	}

	static extern void smethod_41(string string_4);

	static extern string smethod_42(string string_4);

	unsafe static Assembly smethod_43()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected F8, but got I8
		//IL_0012: Expected native int or pointer, but got O
		_003F val;
		do
		{
			int num = ((int[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			val = /*Error near IL_0002: Stack underflow*/% num;
		}
		while (/*Error near IL_0007: Stack underflow*/ <= val);
		long num2 = checked((long)/*Error near IL_0008: Stack underflow*/);
		*(double*)(nint)/*Error near IL_0009: Stack underflow*/ = num2;
		nuint num3 = checked((nuint)/*Error near IL_000c: Stack underflow*/);
		_ = (nint)((IntPtr[])/*Error near IL_0011: Stack underflow*/)[num3] / *(long*)unchecked((nint)null);
		/*Error: Unexpected end of block*/;
	}

	static string smethod_44(Assembly assembly_0)
	{
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_45(string string_4, string string_5, bool bool_5);

	static extern RegistryKey smethod_46(RegistryKey registryKey_0, string string_4, bool bool_5);

	static extern void smethod_47(RegistryKey registryKey_0, string string_4, object object_0);

	static extern Rectangle smethod_48(Point point_0);

	static extern Bitmap smethod_49(int int_0, int int_1);

	static extern Graphics smethod_50(Image image_0);

	static void smethod_51(Graphics graphics_0, Point point_0, Point point_1, Size size_0)
	{
		//Discarded unreachable code: IL_0010, IL_0018, IL_001d, IL_0022, IL_002d, IL_0033
		while (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0006: Stack underflow*/|| /*Error near IL_000b: Stack underflow*/!= /*Error near IL_000b: Stack underflow*/)
		{
		}
		/*Error near IL_000b: Invalid metadata token*/;
	}

	static extern ImageFormat smethod_52();

	static extern void smethod_53(Image image_0, string string_4, ImageFormat imageFormat_0);

	static extern bool smethod_54(string string_4);

	static extern void smethod_55(Process process_0);

	static extern string[] smethod_56(string string_4, char[] char_0);

	static extern string smethod_57(WebClient webClient_0, string string_4);

	static extern string smethod_58();

	static extern string smethod_59();

	static extern string smethod_60(string[] string_4);

	static void smethod_61(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0008, IL_000d, IL_0018, IL_001f
		//IL_0012: Expected native int or pointer, but got O
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected I8, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		int num = checked((int)/*Error: ldloc 0 (out-of-bounds)*/);
		_ = ((short[])/*Error near IL_0003: Stack underflow*/)[num];
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static extern Process[] smethod_62();

	static extern string smethod_63(Process process_0);

	static extern void smethod_64(Process process_0);

	static extern Process smethod_65();

	static extern IntPtr smethod_66(Process process_0);

	static extern ManagementObjectSearcher smethod_67(string string_4);

	static ManagementObjectCollection smethod_68(ManagementObjectSearcher managementObjectSearcher_0)
	{
		//Discarded unreachable code: IL_000b, IL_0010, IL_0011, IL_0012, IL_0019
		while (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
		{
		}
		_ = (ulong)/*Error near IL_0006: Stack underflow*/;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static ManagementObjectEnumerator smethod_69(ManagementObjectCollection managementObjectCollection_0)
	{
		//Discarded unreachable code: IL_0005, IL_000a
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected I4, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static ManagementBaseObject smethod_70(ManagementObjectEnumerator managementObjectEnumerator_0)
	{
		//IL_0003: Expected F8, but got I4
		do
		{
			ushort num = checked((ushort)/*Error near IL_0002: Stack underflow*/);
			((double[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (int)num;
		}
		while (checked((short)/*Error near IL_0005: Stack underflow*/) != 0);
		throw (uint)/*Error near IL_000d: Stack underflow*/;
	}

	static extern object smethod_71(ManagementBaseObject managementBaseObject_0, string string_4);

	static extern string smethod_72(object object_0);

	static string smethod_73(string string_4)
	{
		//Discarded unreachable code: IL_0007, IL_0010
		//IL_0003: Expected O, but got F4
		//IL_000b: Invalid comparison between Unknown and I8
		string_4 = (string)((float[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		checked
		{
			_ = (nint)(long)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0006: Unknown opcode: 0xFF*/;
		}
	}

	static extern bool smethod_74(string string_4, string string_5);

	static extern string smethod_75(string string_4);

	static extern bool smethod_76(string string_4, string string_5);

	static extern bool smethod_77(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern NetworkInterface[] smethod_78();

	unsafe static OperationalStatus smethod_79(NetworkInterface networkInterface_0)
	{
		//Discarded unreachable code: IL_0009, IL_0012, IL_001a, IL_001f, IL_0029, IL_002c
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got I
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected I4, but got Unknown
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		_ = *(int*)(nint)/*Error near IL_0004: Stack underflow*/;
		/*Error near IL_0004: Invalid metadata token*/;
	}

	static extern PhysicalAddress smethod_80(NetworkInterface networkInterface_0);

	static extern string smethod_81(string string_4, char[] char_0);

	static extern string smethod_82(Environment.SpecialFolder specialFolder_0);

	static extern bool smethod_83(string string_4);

	static extern string[] smethod_84(string string_4, string string_5);

	unsafe static Match smethod_85(string string_4, string string_5)
	{
		//IL_0003: Expected native int or pointer, but got O
		//IL_0005: Invalid comparison between Unknown and I8
		long num2;
		do
		{
			int num = *(int*)unchecked((nint)null);
			num2 = ((long[])/*Error near IL_0005: Stack underflow*/)[num];
		}
		while ((long)/*Error near IL_000a: Stack underflow*/ >= num2);
		string_4 = (string)/*Error near IL_000c: Stack underflow*/;
		switch (/*Error near IL_0011: Stack underflow*/)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static extern WebHeaderCollection smethod_86(WebClient webClient_0);

	unsafe static void smethod_87(WebHeaderCollection webHeaderCollection_0, HttpRequestHeader httpRequestHeader_0, string string_4)
	{
		//Discarded unreachable code: IL_0009, IL_0010, IL_001b, IL_002b, IL_0030
		//IL_0003: Expected I4, but got Unknown
		//IL_0026: Invalid comparison between Unknown and I4
		_003F val = /*Error near IL_0001: Stack underflow*/;
		*(int*)(nint)/*Error near IL_0003: Stack underflow*/ = (int)val;
		checked
		{
			_ = (short)/*Error near IL_0004: Stack underflow*/;
			/*Error near IL_0004: Invalid metadata token*/;
		}
	}
}
