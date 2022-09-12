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

	public static extern string smethod_0(string string_4);

	private unsafe static string smethod_1()
	{
		//Discarded unreachable code: IL_001d, IL_0024, IL_002c
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Invalid comparison between Unknown and I
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between F8 and Unknown
		//IL_0019: Expected O, but got I
		nuint num2;
		do
		{
			checked
			{
				short num = (short)(*unchecked((object*)(nint)/*Error near IL_0001: Stack underflow*/));
				num2 = (nuint)unchecked(/*Error near IL_0004: Stack underflow*/ / num);
			}
		}
		while ((nint)/*Error near IL_000a: Stack underflow*/ <= (nint)num2 || (double)(/*Error near IL_000b: Stack underflow*/ % /*Error near IL_000b: Stack underflow*/) <= (double)/*Error near IL_000e: ldloc 3 (out-of-bounds)*/);
		short num3 = ((short[])/*Error near IL_0015: Stack underflow*/)[/*Error near IL_0015: Stack underflow*/];
		_ = ((IntPtr[])/*Error near IL_0018: Stack underflow*/)[num3];
		/*Error near IL_0018: Invalid metadata token*/;
	}

	private static extern void Main();

	private static extern void smethod_2();

	private static extern bool smethod_3();

	private static bool smethod_4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		_003F val = /*Error near IL_0001: Stack underflow*/% /*Error near IL_0001: Stack underflow*/;
		_ = ((long[])/*Error near IL_0002: Stack underflow*/)[val];
		/*Error near IL_0002: starg 0 (out-of-bounds)*/;
		_ = /*Error near IL_0005: Stack underflow*/| /*Error near IL_0005: Stack underflow*/;
		/*Error near IL_0007: Invalid metadata token*/;
	}

	private static extern bool smethod_5();

	private static extern string smethod_6();

	public extern Class5();

	unsafe static Class5()
	{
		//Discarded unreachable code: IL_001b, IL_0025
		//IL_0013: Expected F4, but got I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected I4, but got O
		/*Error near IL_0003: stloc 0 (out-of-bounds)*/;
		*(float*)(nint)/*Error near IL_0013: Stack underflow*/ = 1536f;
		_ = (uint)checked((int)/*Error near IL_0014: Stack underflow*/);
		/*Error near IL_0016: Invalid metadata token*/;
	}

	static byte[] smethod_7(string string_4)
	{
		//Discarded unreachable code: IL_000a
		_ = 1625261143;
		/*Error near IL_0005: Invalid metadata token*/;
	}

	static extern RijndaelManaged smethod_8();

	static extern void smethod_9(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern void smethod_10(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern Encoding smethod_11();

	static extern byte[] smethod_12(Encoding encoding_0, string string_4);

	static extern void smethod_13(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_14(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_15(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	static extern void smethod_16(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static extern byte[] smethod_17(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern byte[] smethod_18(SymmetricAlgorithm symmetricAlgorithm_0);

	unsafe static ICryptoTransform smethod_19(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1)
	{
		//IL_0004: Expected native int or pointer, but got F8
		_ = *(short*)(nint)(*(double*)2);
		/*Error near IL_0005: Invalid metadata token*/;
	}

	static extern byte[] smethod_20(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static extern Encoding smethod_21();

	static extern string smethod_22(Encoding encoding_0, byte[] byte_0);

	static extern void smethod_23(IDisposable idisposable_0);

	static extern string smethod_24(string string_4);

	static extern WebClient smethod_25();

	static extern string smethod_26(string string_4, string string_5);

	static extern void smethod_27(WebClient webClient_0, string string_4, string string_5);

	static void smethod_28(Component component_0)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
			{
				_003F val = /*Error near IL_0006: Stack underflow*/<< (int)/*Error near IL_0006: Stack underflow*/;
				byte num = ((byte[])/*Error near IL_0007: Stack underflow*/)[val];
				if ((int)/*Error near IL_000c: Stack underflow*/ < (int)num && /*Error near IL_0012: Stack underflow*/>= /*Error near IL_0012: Stack underflow*/)
				{
					/*Error: Could not find block for branch target IL_0012*/;
				}
			}
		}
	}

	static extern Process smethod_29();

	static ProcessStartInfo smethod_30()
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_000d, IL_0019, IL_001b, IL_0029
		//IL_0001: Incompatible stack heights: 0 vs 1
		//IL_0011: Expected F4, but got I4
		//IL_0014: Expected F8, but got I
		//IL_0019: Unsupported input type for neg.
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and O
		//IL_002f: Invalid comparison between Unknown and F4
		while (true)
		{
			_ = (sbyte)/*Error near IL_0001: Stack underflow*/;
		}
	}

	static extern void smethod_31(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	unsafe static void smethod_32(ProcessStartInfo processStartInfo_0, string string_4)
	{
		//Discarded unreachable code: IL_0012, IL_001e
		//IL_0002: Expected F4, but got I4
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Invalid comparison between Unknown and O
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected I, but got Unknown
		//IL_0031: Expected I, but got Unknown
		do
		{
			int num = *(int*)(nint)/*Error near IL_0001: Stack underflow*/;
			*(float*)(nint)/*Error near IL_0002: Stack underflow*/ = num;
		}
		while ((object)(/*Error near IL_0003: Stack underflow*/ | /*Error near IL_0003: Stack underflow*/) > processStartInfo_0);
		_ = *(float*)(nint)checked(/*Error near IL_000c: Stack underflow*/ - /*Error near IL_000c: Stack underflow*/);
		/*Error near IL_000d: Invalid metadata token*/;
	}

	static string smethod_33(string string_4, string string_5, string string_6)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		ushort num = checked((ushort)/*Error near IL_0002: Stack underflow*/);
		_ = /*Error near IL_0003: Stack underflow*/+ num;
		/*Error near IL_0004: Invalid metadata token*/;
	}

	static extern void smethod_34(ProcessStartInfo processStartInfo_0, string string_4);

	static extern void smethod_35(Process process_0, ProcessStartInfo processStartInfo_0);

	static extern bool smethod_36(Process process_0);

	static extern void smethod_37(int int_0);

	static extern void smethod_38(string string_4);

	static extern string smethod_39(string string_4);

	static extern Assembly smethod_40();

	static extern string smethod_41(Assembly assembly_0);

	static void smethod_42(string string_4, string string_5, bool bool_5)
	{
		//Discarded unreachable code: IL_0005, IL_000e, IL_0010
		/*Error: Invalid metadata token*/;
	}

	static extern RegistryKey smethod_43(RegistryKey registryKey_0, string string_4, bool bool_5);

	static extern void smethod_44(RegistryKey registryKey_0, string string_4, object object_0);

	static extern DialogResult smethod_45(string string_4, string string_5, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0);

	static Rectangle smethod_46(Point point_0)
	{
		/*Error: Unexpected end of block*/;
	}

	static extern Bitmap smethod_47(int int_0, int int_1);

	static Graphics smethod_48(Image image_0)
	{
		//Discarded unreachable code: IL_0002
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I
		checked
		{
			_ = (short)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xF8*/;
		}
	}

	static void smethod_49(Graphics graphics_0, Point point_0, Point point_1, Size size_0)
	{
		//Discarded unreachable code: IL_0005, IL_000c, IL_000e, IL_0011, IL_0016, IL_001c
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static extern ImageFormat smethod_50();

	static extern void smethod_51(Image image_0, string string_4, ImageFormat imageFormat_0);

	static extern bool smethod_52(string string_4);

	static extern void smethod_53(Process process_0);

	static string[] smethod_54(string string_4, char[] char_0)
	{
		//Discarded unreachable code: IL_0006, IL_0012, IL_001a
		//IL_000b: Expected I8, but got F8
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern string smethod_55(WebClient webClient_0, string string_4);

	static string smethod_56()
	{
		//Discarded unreachable code: IL_0016, IL_001b, IL_0020, IL_0025, IL_002b, IL_0030
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		short num;
		do
		{
			checked
			{
				_ = (uint)/*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0001: stloc 1 (out-of-bounds)*/;
				num = ((short[])((double[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/])[/*Error near IL_0003: ldloc 2 (out-of-bounds)*/ + 5];
			}
		}
		while ((int)/*Error near IL_000d: Stack underflow*/ == num);
		_ = (sbyte)/*Error near IL_000e: Stack underflow*/;
		/*Error near IL_000e: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0011: Invalid metadata token*/;
	}

	static extern string smethod_57();

	static extern string smethod_58(string[] string_4);

	static void smethod_59(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0004, IL_000a
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		_ = (short)/*Error near IL_0002: Stack underflow*/;
		/*Error near IL_0003: Unknown opcode: 0xFF*/;
	}

	unsafe static Process[] smethod_60()
	{
		//Discarded unreachable code: IL_000c
		//IL_0004: Expected F4, but got Unknown
		//IL_0003: Expected native int or pointer, but got F8
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		*(float*)(nint)(double)checked((nuint)/*Error near IL_0001: Stack underflow*/) = (float)/*Error near IL_0002: ldarg 2 (out-of-bounds)*/;
		*(_003F*)(nint)/*Error near IL_0007: Stack underflow*/ = /*Error near IL_0007: Stack underflow*/;
		/*Error near IL_0007: Invalid metadata token*/;
	}

	static extern string smethod_61(Process process_0);

	static extern void smethod_62(Process process_0);

	static extern Process smethod_63();

	static extern IntPtr smethod_64(Process process_0);

	static extern ManagementObjectSearcher smethod_65(string string_4);

	static extern ManagementObjectCollection smethod_66(ManagementObjectSearcher managementObjectSearcher_0);

	unsafe static ManagementObjectEnumerator smethod_67(ManagementObjectCollection managementObjectCollection_0)
	{
		//IL_000d: Incompatible stack heights: 0 vs 1
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			checked
			{
				_ = (nuint)unchecked((int)(uint)/*Error near IL_0001: Stack underflow*/);
				if (1uL < 931239487uL)
				{
					continue;
				}
			}
			sbyte num = *(sbyte*)(nint)/*Error near IL_0013: Stack underflow*/;
			if ((int)/*Error near IL_0018: Stack underflow*/ != num)
			{
				managementObjectCollection_0 = (ManagementObjectCollection)/*Error near IL_001a: Stack underflow*/;
				if (/*Error near IL_0020: Stack underflow*/ > /*Error near IL_0020: Stack underflow*/)
				{
					break;
				}
			}
		}
		_ = /*Error near IL_0021: Stack underflow*// /*Error near IL_0021: Stack underflow*/;
		return (ManagementObjectEnumerator)(object)/*OpCode not supported: Nop*/;
	}

	static extern ManagementBaseObject smethod_68(ManagementObjectEnumerator managementObjectEnumerator_0);

	static object smethod_69(ManagementBaseObject managementBaseObject_0, string string_4)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_0019, IL_001e, IL_0024, IL_0026
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got I8
		//IL_001f: Invalid comparison between Unknown and I4
		/*Error: Invalid metadata token*/;
	}

	static extern string smethod_70(object object_0);

	static extern string smethod_71(string string_4);

	static extern bool smethod_72(string string_4, string string_5);

	static extern string smethod_73(string string_4);

	static extern bool smethod_74(string string_4, string string_5);

	static extern bool smethod_75(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern NetworkInterface[] smethod_76();

	static OperationalStatus smethod_77(NetworkInterface networkInterface_0)
	{
		_ = ((IntPtr[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern PhysicalAddress smethod_78(NetworkInterface networkInterface_0);

	static extern string smethod_79(string string_4, char[] char_0);
}
