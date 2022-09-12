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

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string string_4);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_5);

	public static extern string smethod_0(string string_4);

	private static extern string smethod_1();

	private static extern void smethod_2();

	private static void smethod_3(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_001b
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		while (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/|| /*Error near IL_000b: Stack underflow*/> /*Error near IL_000b: Stack underflow*/|| checked((nuint)(/*Error near IL_000c: Stack underflow*/ & /*Error near IL_000c: Stack underflow*/)) != 0 || (int)/*Error near IL_0019: Stack underflow*/ < 7)
		{
		}
		/*Error near IL_0019: ldloc 2 (out-of-bounds)*/;
		/*Error near IL_001a: Unknown opcode: 0xFC*/;
	}

	private static extern void Main();

	private static extern void smethod_4();

	private static extern bool smethod_5();

	private static bool smethod_6()
	{
		//Discarded unreachable code: IL_0005
		/*Error: Invalid metadata token*/;
	}

	private static extern bool smethod_7();

	private static extern string smethod_8();

	public extern Class5();

	unsafe static Class5()
	{
		//IL_0004: Unsupported input type for neg.
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		/*Error: starg 0 (out-of-bounds)*/;
		_ = *(IntPtr*)(nint)/*Error near IL_0003: Stack underflow*/;
		_ = 0 - /*Error near IL_0005: Stack underflow*/;
		/*Error near IL_0007: ldarg 2 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static extern byte[] smethod_9(string string_4);

	unsafe static RijndaelManaged smethod_10()
	{
		//Discarded unreachable code: IL_000a, IL_0011, IL_0018, IL_001d, IL_001f, IL_0028, IL_002e, IL_0033
		//IL_0004: Expected native int or pointer, but got F4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		/*OpCode not supported: Ckfinite*/;
		_ = *(int*)(nint)(float)(long)(uint)(*(short*)(nint)/*Error near IL_0002: Stack underflow*/);
		/*Error near IL_0005: Invalid metadata token*/;
	}

	static extern void smethod_11(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern void smethod_12(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern Encoding smethod_13();

	static extern byte[] smethod_14(Encoding encoding_0, string string_4);

	static extern void smethod_15(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_16(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_17(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	static extern void smethod_18(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static extern byte[] smethod_19(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern byte[] smethod_20(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern ICryptoTransform smethod_21(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static extern byte[] smethod_22(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static extern Encoding smethod_23();

	static extern string smethod_24(Encoding encoding_0, byte[] byte_0);

	static extern void smethod_25(IDisposable idisposable_0);

	static extern string smethod_26(string string_4);

	unsafe static WebClient smethod_27()
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Incompatible stack heights: 0 vs 1
		//IL_002a: Expected I, but got I8
		//IL_002f: Invalid comparison between Unknown and F4
		while (true)
		{
			_003F val = checked((ulong)/*Error near IL_0001: Stack underflow*/) % null;
			_003F val2 = checked(/*Error near IL_0006: Stack underflow*/ * val);
			if (/*Error near IL_000b: Stack underflow*/ <= val2)
			{
				continue;
			}
			_ = (double)/*Error near IL_000c: Stack underflow*/;
			if (5852966311387570011L > 5852966311387570011L && (int)/*Error near IL_0028: Stack underflow*/ == 0)
			{
				long num = checked((long)/*Error near IL_0029: Stack underflow*/);
				*(IntPtr*)(nint)/*Error near IL_002a: Stack underflow*/ = (nint)num;
				byte num2 = ((byte[])/*Error near IL_002b: Stack underflow*/)[/*Error near IL_002b: Stack underflow*/];
				if (!((float)/*Error near IL_0034: Stack underflow*/ <= (float)(int)num2))
				{
					/*Error: Could not find block for branch target IL_0034*/;
				}
			}
		}
	}

	unsafe static string smethod_28(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_000a, IL_0010
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Expected I4, but got Unknown
		IntPtr intPtr = *(IntPtr*)(nint)checked(/*Error near IL_0001: Stack underflow*/ - /*Error near IL_0001: Stack underflow*/);
		_003F val = /*Error near IL_0003: Stack underflow*// (nint)intPtr;
		_003F val2 = /*Error near IL_0004: Stack underflow*/* val;
		((int[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (int)val2;
		_ = (int)/*Error near IL_0007: ldarg 2 (out-of-bounds)*/;
		/*Error near IL_0009: Unknown opcode: 0xFA*/;
	}

	unsafe static void smethod_29(WebClient webClient_0, string string_4, string string_5)
	{
		//Discarded unreachable code: IL_001a, IL_0024
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unsupported input type for neg.
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and F4
		float num = *(float*)(nint)/*Error near IL_0001: Stack underflow*/;
		float num2 = *(float*)(nint)(0 - /*Error near IL_0002: Stack underflow*/* num);
		_ = /*Error near IL_0007: Stack underflow*/>> (int)(0f - num2);
		_ = 1;
		_ = ((int[])/*Error near IL_000b: ldloca 0 (out-of-bounds)*/)[(object)""];
		/*Error near IL_0015: Invalid metadata token*/;
	}

	static extern void smethod_30(Component component_0);

	static extern Process smethod_31();

	unsafe static ProcessStartInfo smethod_32()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between F8 and I4
		//IL_001e: Incompatible stack heights: 0 vs 2
		//IL_002a: Invalid comparison between F4 and Unknown
		do
		{
			uint num = checked((uint)(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/));
			_ = ((long[])(ushort)(/*Error near IL_0003: Stack underflow*/ >> (int)num))[3.0069746094866034E+146];
			_ = *(sbyte*)checked((sbyte)uint.MaxValue);
		}
		while ((double)/*Error near IL_0015: ldloc 0 (out-of-bounds)*/ > -164220510.0 || 3.9588727E-12f > (float)/*Error near IL_0028: ldarg 0 (out-of-bounds)*/);
		return (ProcessStartInfo)/*Error near IL_0030: Stack underflow*/;
	}

	static extern void smethod_33(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static extern void smethod_34(ProcessStartInfo processStartInfo_0, string string_4);

	static extern string smethod_35(string string_4, string string_5, string string_6);

	unsafe static void smethod_36(ProcessStartInfo processStartInfo_0, string string_4)
	{
		//Discarded unreachable code: IL_000f, IL_0014, IL_0026, IL_0030
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected I, but got Unknown
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unsupported input type for neg.
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		_003F val = /*Error near IL_0001: Stack underflow*/% /*Error near IL_0001: Stack underflow*/;
		((int[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (int)(nuint)val;
		_003F val2 = checked(/*Error near IL_0006: Stack underflow*/ - /*Error near IL_0006: Stack underflow*/);
		*(IntPtr*)(nint)/*Error near IL_0007: Stack underflow*/ = (IntPtr)val2;
		int num = *(int*)(nint)/*Error near IL_0008: Stack underflow*/;
		_ = /*Error near IL_0009: Stack underflow*/% num;
		/*Error near IL_000a: Invalid metadata token*/;
	}

	static extern void smethod_37(Process process_0, ProcessStartInfo processStartInfo_0);

	static extern bool smethod_38(Process process_0);

	static void smethod_39(int int_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		while (/*Error near IL_0001: Stack underflow*/ >> (int)/*Error near IL_0001: Stack underflow*/ < 5)
		{
		}
		((IntPtr[])/*Error near IL_0009: Stack underflow*/)[/*Error near IL_0009: Stack underflow*/] = (IntPtr)/*Error near IL_0009: Stack underflow*/;
		/*Error near IL_000b: ldarg 1 (out-of-bounds)*/;
		/*Error near IL_000c: Invalid metadata token*/;
	}

	static extern void smethod_40(string string_4);

	unsafe static string smethod_41(string string_4)
	{
		//Discarded unreachable code: IL_0006, IL_000d, IL_0014, IL_001c, IL_0027, IL_002f
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0017: Invalid comparison between Unknown and F8
		//IL_0020: Expected O, but got I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		_ = *(long*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	unsafe static Assembly smethod_42()
	{
		//Discarded unreachable code: IL_0018
		//IL_0009: Expected O, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ != /*Error near IL_0005: Stack underflow*/)
			{
				double num = ((double[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/];
				*(object*)((int[])/*Error near IL_0007: Stack underflow*/)[num] = 2;
				checked
				{
					_ = (ulong)/*Error near IL_000a: Stack underflow*/;
					/*Error near IL_000a: stloc 3 (out-of-bounds)*/;
					if (/*Error near IL_0010: Stack underflow*/ > /*Error near IL_0010: Stack underflow*/)
					{
						break;
					}
				}
			}
		}
		/*OpCode not supported: DebugBreak*/;
		_ = ((float[])/*Error near IL_0012: Stack underflow*/)[/*Error near IL_0012: Stack underflow*/] + /*Error near IL_0014: ldloc 3 (out-of-bounds)*/;
		/*Error near IL_0017: Unknown opcode: 0xFC*/;
	}

	static extern Stream smethod_43(Assembly assembly_0, string string_4);

	static extern FileStream smethod_44(string string_4, FileMode fileMode_0, FileAccess fileAccess_0);

	static extern void smethod_45(Stream stream_0, Stream stream_1);

	static Process smethod_46(string string_4)
	{
		//Discarded unreachable code: IL_000d, IL_0013
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected native int or pointer, but got F4
		_003F val;
		do
		{
			((object[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = null;
			val = /*Error near IL_0002: ldloca 0 (out-of-bounds)*/;
		}
		while (/*Error near IL_0009: Stack underflow*/ != val);
		checked
		{
			_ = /*Error near IL_000c: Stack underflow*/+ /*Error near IL_000c: Stack underflow*/;
			/*Error near IL_000c: Unknown opcode: 0xF9*/;
		}
	}

	static extern string smethod_47(Assembly assembly_0);

	static extern void smethod_48(string string_4, string string_5, bool bool_5);

	static extern RegistryKey smethod_49(RegistryKey registryKey_0, string string_4, bool bool_5);

	static void smethod_50(RegistryKey registryKey_0, string string_4, object object_0)
	{
		//Discarded unreachable code: IL_000b, IL_0014, IL_0019, IL_001f, IL_0024, IL_002a, IL_0039, IL_003f
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0033: Expected native int or pointer, but got F8
		checked
		{
			_ = (int)((long[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/];
			/*Error near IL_0006: Invalid metadata token*/;
		}
	}

	static extern DialogResult smethod_51(string string_4, string string_5, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0);

	static Assembly smethod_52()
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0010
		//IL_0013: Invalid comparison between I4 and Unknown
		_ = 1;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern string smethod_53(string string_4);

	static extern bool smethod_54(string string_4, string string_5);

	static extern Rectangle smethod_55(Point point_0);

	static extern Bitmap smethod_56(int int_0, int int_1);

	static Graphics smethod_57(Image image_0)
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static extern void smethod_58(Graphics graphics_0, Point point_0, Point point_1, Size size_0);

	static extern ImageFormat smethod_59();

	static extern void smethod_60(Image image_0, string string_4, ImageFormat imageFormat_0);

	static bool smethod_61(string string_4)
	{
		//Discarded unreachable code: IL_0006, IL_000e
		//IL_0009: Invalid comparison between I8 and Unknown
		//IL_0011: Expected O, but got I
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern void smethod_62(Process process_0);

	static string[] smethod_63(string string_4, char[] char_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Invalid comparison between Unknown and I4
		do
		{
			_ = (ulong)/*Error near IL_0001: Stack underflow*/;
		}
		while ((/*Error near IL_0003: Stack underflow*/ | /*Error near IL_0003: Stack underflow*/) > 8);
		return (string[])/*OpCode not supported: Nop*/;
	}

	static extern string smethod_64(WebClient webClient_0, string string_4);

	static extern string smethod_65();

	unsafe static string smethod_66()
	{
		//Discarded unreachable code: IL_000e, IL_0013, IL_0015, IL_001a, IL_0026, IL_0031, IL_003b
		//IL_0007: Expected I4, but got I8
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Incompatible stack heights: 0 vs 1
		//IL_003f: Invalid comparison between Unknown and I
		((sbyte[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (sbyte)/*Error near IL_0002: Stack underflow*/;
		ushort num = (ushort)/*Error near IL_0003: Stack underflow*/;
		long num2 = ((long[])/*Error near IL_0005: Stack underflow*/)[num];
		((short[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/] = (short)num2;
		_ = *(sbyte*)(nint)/*Error near IL_0009: Stack underflow*/;
		/*Error near IL_0009: Invalid metadata token*/;
	}

	static string smethod_67(string[] string_4)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		/*Error: Invalid metadata token*/;
	}

	unsafe static void smethod_68(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0006, IL_0010, IL_0019, IL_001c, IL_0029, IL_002a, IL_0031, IL_0036
		//IL_000b: Incompatible stack heights: 0 vs 1
		//IL_0014: Invalid comparison between Unknown and I
		//IL_0024: Invalid comparison between Unknown and I
		_ = *(object*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern Process[] smethod_69();

	static extern string smethod_70(Process process_0);

	static extern void smethod_71(Process process_0);

	static extern Process smethod_72();

	static extern IntPtr smethod_73(Process process_0);

	static extern ManagementObjectSearcher smethod_74(string string_4);

	static extern ManagementObjectCollection smethod_75(ManagementObjectSearcher managementObjectSearcher_0);

	static extern ManagementObjectEnumerator smethod_76(ManagementObjectCollection managementObjectCollection_0);

	static extern ManagementBaseObject smethod_77(ManagementObjectEnumerator managementObjectEnumerator_0);

	static object smethod_78(ManagementBaseObject managementBaseObject_0, string string_4)
	{
		//Discarded unreachable code: IL_000a, IL_0012, IL_0013, IL_001d, IL_0023, IL_0028, IL_0030, IL_0036
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		while (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/)
		{
		}
		/*Error near IL_0005: Invalid metadata token*/;
	}

	static extern string smethod_79(object object_0);

	static extern string smethod_80(string string_4);

	static extern bool smethod_81(string string_4, string string_5);

	static extern string smethod_82(string string_4);

	static extern bool smethod_83(string string_4, string string_5);

	static extern bool smethod_84(ManagementObjectEnumerator managementObjectEnumerator_0);

	static NetworkInterface[] smethod_85()
	{
		//Discarded unreachable code: IL_000a, IL_0013, IL_0019, IL_0022, IL_0028, IL_0031
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got I4
		//IL_0023: Invalid comparison between Unknown and I4
		int num = 7;
		_ = (nuint)checked(/*Error near IL_0005: Stack underflow*/ + num);
		/*Error near IL_0009: Unknown opcode: 0xFC*/;
	}

	static OperationalStatus smethod_86(NetworkInterface networkInterface_0)
	{
		//Discarded unreachable code: IL_0005, IL_000e, IL_0014
		//IL_000a: Expected O, but got I4
		//IL_000f: Invalid comparison between Unknown and I4
		/*Error: Invalid metadata token*/;
	}

	static extern PhysicalAddress smethod_87(NetworkInterface networkInterface_0);

	static extern string smethod_88(string string_4, char[] char_0);
}
