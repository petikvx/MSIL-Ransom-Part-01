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

	public static string smethod_0(string string_4)
	{
		//Discarded unreachable code: IL_0008, IL_0010, IL_0016, IL_001d, IL_0025, IL_002b
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		_ = (long)/*Error near IL_0003: Stack underflow*/;
		_ = null;
		checked
		{
			_ = (short)4294967174u;
			/*Error near IL_0007: Unknown opcode: 0xFB*/;
		}
	}

	private static extern string smethod_1();

	private static void Main()
	{
		//Discarded unreachable code: IL_0006, IL_0009, IL_0020, IL_0032, IL_0037
		//IL_001b: Expected F8, but got I4
		//IL_0028: Expected F4, but got Unknown
		//IL_002b: Expected F8, but got I
		/*Error near IL_0001: Invalid metadata token*/;
	}

	private static extern void smethod_2();

	private static bool smethod_3()
	{
		//Discarded unreachable code: IL_0006
		while (true)
		{
		}
	}

	private static extern bool smethod_4();

	private static extern bool smethod_5();

	private static extern string smethod_6();

	public extern Class5();

	static Class5()
	{
		//Discarded unreachable code: IL_0001, IL_0008, IL_000a, IL_000f, IL_001b
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0008: Unsupported input type for neg.
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected I4, but got Unknown
		/*Error: Unknown opcode: 0xFD*/;
	}

	static extern byte[] smethod_7(string string_4);

	static extern RijndaelManaged smethod_8();

	static extern void smethod_9(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern void smethod_10(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern Encoding smethod_11();

	static extern byte[] smethod_12(Encoding encoding_0, string string_4);

	static void smethod_13(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_0006, IL_000c
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		while (true)
		{
		}
	}

	static extern void smethod_14(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_15(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	static extern void smethod_16(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static byte[] smethod_17(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		//Discarded unreachable code: IL_0006, IL_000d, IL_0011, IL_001a, IL_0028
		//IL_0015: Invalid comparison between F8 and Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static byte[] smethod_18(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		//IL_0001: Invalid comparison between Unknown and F4
		float num;
		do
		{
			num = ((float[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		}
		while ((float)/*Error near IL_0006: Stack underflow*/ <= num);
		_ = 5;
		/*Error: Unexpected end of block*/;
	}

	static extern ICryptoTransform smethod_19(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static extern byte[] smethod_20(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static extern Encoding smethod_21();

	static extern string smethod_22(Encoding encoding_0, byte[] byte_0);

	static void smethod_23(IDisposable idisposable_0)
	{
		//Discarded unreachable code: IL_0005, IL_000c, IL_0011, IL_0017
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_0012: Invalid comparison between Unknown and O
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected I4, but got Unknown
		/*Error: Invalid metadata token*/;
	}

	static extern string smethod_24(string string_4);

	static extern WebClient smethod_25();

	static extern string smethod_26(string string_4, string string_5);

	static extern void smethod_27(WebClient webClient_0, string string_4, string string_5);

	static void smethod_28(Component component_0)
	{
		_ = ((ushort[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		_ = 2;
		/*Error near IL_0003: ldloca 0 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static extern Process smethod_29();

	static extern ProcessStartInfo smethod_30();

	unsafe static void smethod_31(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0)
	{
		//Discarded unreachable code: IL_0017, IL_0018
		//IL_0012: Incompatible stack heights: 0 vs 3
		while (true)
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			checked
			{
				if (/*Error near IL_0006: Stack underflow*/ == /*Error near IL_0006: Stack underflow*/)
				{
					_ = (ulong)4.059993378935184E+117;
					_ = 4;
					_ = -1;
				}
			}
		}
	}

	static extern void smethod_32(ProcessStartInfo processStartInfo_0, string string_4);

	static extern string smethod_33(string string_4, string string_5, string string_6);

	static extern void smethod_34(ProcessStartInfo processStartInfo_0, string string_4);

	unsafe static void smethod_35(Process process_0, ProcessStartInfo processStartInfo_0)
	{
		//Discarded unreachable code: IL_000d, IL_000e, IL_0013, IL_0018, IL_0021, IL_0027, IL_0029, IL_002e, IL_0035, IL_003a
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected F4, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I
		_003F val = /*Error near IL_0001: Stack underflow*/<< (int)/*Error near IL_0001: Stack underflow*/;
		*(float*)(nint)/*Error near IL_0002: Stack underflow*/ = (float)val;
		_ = ((Array)/*Error near IL_0003: Stack underflow*/).LongLength;
		_ = 4.0617774E-24f;
		/*Error near IL_0008: Invalid metadata token*/;
	}

	static extern bool smethod_36(Process process_0);

	static extern void smethod_37(int int_0);

	static extern void smethod_38(string string_4);

	static string smethod_39(string string_4)
	{
		//Discarded unreachable code: IL_0011
		//IL_0007: Incompatible stack heights: 0 vs 1
		do
		{
			checked
			{
				_ = (nuint)/*Error near IL_0003: ldarg 2 (out-of-bounds)*/;
			}
		}
		while ((int)/*Error near IL_0005: ldloc 0 (out-of-bounds)*/ != 0);
		/*Error near IL_000c: Invalid metadata token*/;
	}

	static extern Assembly smethod_40();

	static extern string smethod_41(Assembly assembly_0);

	unsafe static void smethod_42(string string_4, string string_5, bool bool_5)
	{
		//IL_000b: Invalid comparison between Unknown and I8
		//IL_0014: Expected O, but got I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if ((long)/*Error near IL_0010: Stack underflow*/ < 4294967223L)
			{
				continue;
			}
			*(object*)6 = 2;
			if (/*Error near IL_0019: Stack underflow*/ > /*Error near IL_0019: Stack underflow*/)
			{
				_003F val = /*Error near IL_0024: Stack underflow*// 814445230649947939L;
				if (checked(/*Error near IL_0025: Stack underflow*/ - val) == 0)
				{
					break;
				}
			}
		}
		*(sbyte*)(nint)/*Error near IL_002d: Stack underflow*/ = 4;
		((object[])/*Error near IL_002f: Stack underflow*/)[/*Error near IL_002f: Stack underflow*/] = (object)/*Error near IL_002f: Stack underflow*/;
		ushort num = checked((ushort)/*Error near IL_0031: Stack underflow*/);
		_003F val2 = /*Error near IL_0032: Stack underflow*/<< (int)num;
		_ = ((short[])/*Error near IL_0034: Stack underflow*/)[val2];
		/*Error near IL_0034: stloc 3 (out-of-bounds)*/;
		/*Error near IL_0037: Invalid metadata token*/;
	}

	static extern RegistryKey smethod_43(RegistryKey registryKey_0, string string_4, bool bool_5);

	static extern void smethod_44(RegistryKey registryKey_0, string string_4, object object_0);

	static DialogResult smethod_45(string string_4, string string_5, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		//Discarded unreachable code: IL_0006
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern RegistryKey smethod_46(RegistryKey registryKey_0, string string_4);

	static extern void smethod_47(RegistryKey registryKey_0);

	static extern Rectangle smethod_48(Point point_0);

	static extern Bitmap smethod_49(int int_0, int int_1);

	static extern Graphics smethod_50(Image image_0);

	static extern void smethod_51(Graphics graphics_0, Point point_0, Point point_1, Size size_0);

	static extern ImageFormat smethod_52();

	static extern void smethod_53(Image image_0, string string_4, ImageFormat imageFormat_0);

	static extern bool smethod_54(string string_4);

	static extern void smethod_55(Process process_0);

	static extern string[] smethod_56(string string_4, char[] char_0);

	static extern string smethod_57(WebClient webClient_0, string string_4);

	static extern string smethod_58();

	static extern string smethod_59();

	static extern string smethod_60(string[] string_4);

	static extern void smethod_61(string string_4, string string_5);

	static extern Process[] smethod_62();

	static extern string smethod_63(Process process_0);

	static extern void smethod_64(Process process_0);

	static extern Process smethod_65();

	static extern IntPtr smethod_66(Process process_0);

	unsafe static ManagementObjectSearcher smethod_67(string string_4)
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0004: stloc 3 (out-of-bounds)*/;
		/*Error near IL_0005: stloc 0 (out-of-bounds)*/;
		checked
		{
			_ = (nint)/*Error near IL_0007: Stack underflow*/;
			/*Error: Unexpected end of block*/;
		}
	}

	static extern ManagementObjectCollection smethod_68(ManagementObjectSearcher managementObjectSearcher_0);

	static extern ManagementObjectEnumerator smethod_69(ManagementObjectCollection managementObjectCollection_0);

	unsafe static ManagementBaseObject smethod_70(ManagementObjectEnumerator managementObjectEnumerator_0)
	{
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
			{
				*(_003F*)(nint)/*Error near IL_0006: Stack underflow*/ = /*Error near IL_0006: Stack underflow*/;
				if (/*Error near IL_000b: Stack underflow*/ <= /*Error near IL_000b: Stack underflow*/)
				{
					/*Error: Could not find block for branch target IL_000b*/;
				}
			}
		}
	}

	static extern object smethod_71(ManagementBaseObject managementBaseObject_0, string string_4);

	static extern string smethod_72(object object_0);

	static extern string smethod_73(string string_4);

	static extern bool smethod_74(string string_4, string string_5);

	static string smethod_75(string string_4)
	{
		//Discarded unreachable code: IL_0004, IL_000b
		/*Error near IL_0003: Unknown opcode: 0xFB*/;
	}

	static extern bool smethod_76(string string_4, string string_5);

	static extern bool smethod_77(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern NetworkInterface[] smethod_78();

	static extern OperationalStatus smethod_79(NetworkInterface networkInterface_0);

	static PhysicalAddress smethod_80(NetworkInterface networkInterface_0)
	{
		//Discarded unreachable code: IL_0002, IL_0009, IL_0010, IL_0016, IL_001d, IL_0027, IL_002d, IL_0031
		//IL_000b: Invalid comparison between Unknown and O
		//IL_0016: Unsupported input type for neg.
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		_ = 7;
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	static extern string smethod_81(string string_4, char[] char_0);
}
