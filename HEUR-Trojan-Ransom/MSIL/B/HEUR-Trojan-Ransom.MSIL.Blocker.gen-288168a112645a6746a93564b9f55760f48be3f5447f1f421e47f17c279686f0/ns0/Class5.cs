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
using System.Security.Principal;
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0002: Stack underflow*// -1;
		/*Error near IL_0003: stloc 0 (out-of-bounds)*/;
		_ = ((float[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/];
		/*Error near IL_0007: Invalid metadata token*/;
	}

	private static string smethod_1()
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0012, IL_0017, IL_001c, IL_0021, IL_0027, IL_002a
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got I4
		/*Error near IL_0001: Invalid metadata token*/;
	}

	private static extern void smethod_2(string string_4, string string_5, string string_6);

	private static extern void smethod_3();

	private static extern void smethod_4(string string_4);

	private static extern void Main();

	private static extern void smethod_5();

	private static bool smethod_6()
	{
		//Discarded unreachable code: IL_0005, IL_000a
		//IL_0013: Expected I4, but got Unknown
		while (true)
		{
		}
	}

	private static extern bool smethod_7();

	private static extern bool smethod_8();

	private static string smethod_9()
	{
		//IL_0004: Expected I8, but got Unknown
		_003F val = /*Error: ldarg 0 (out-of-bounds)*/;
		((long[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (long)val;
		_ = ((uint[])/*Error near IL_0009: Stack underflow*/)[5];
		/*Error near IL_0009: Invalid metadata token*/;
	}

	public extern Class5();

	static extern byte[] smethod_10(string string_4);

	static extern RijndaelManaged smethod_11();

	static extern void smethod_12(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern void smethod_13(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern Encoding smethod_14();

	static byte[] smethod_15(Encoding encoding_0, string string_4)
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0013, IL_0018, IL_0020, IL_0025, IL_002b
		//IL_001b: Expected I8, but got I4
		//IL_0030: Expected native int or pointer, but got O
		//IL_0033: Expected O, but got I4
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern void smethod_16(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_17(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_18(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	static extern void smethod_19(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static extern byte[] smethod_20(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern byte[] smethod_21(SymmetricAlgorithm symmetricAlgorithm_0);

	static ICryptoTransform smethod_22(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1)
	{
		//Discarded unreachable code: IL_0010
		//IL_0005: Expected O, but got I
		//IL_0006: Invalid comparison between Unknown and I
		//IL_001a: Expected O, but got I8
		IntPtr intPtr;
		do
		{
			/*Error: stloc 3 (out-of-bounds)*/;
			sbyte num = checked((sbyte)/*Error near IL_0002: Stack underflow*/);
			((sbyte[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = num;
			intPtr = (nint)((Array)checked((nint)/*Error near IL_0004: Stack underflow*/)).LongLength;
		}
		while ((nint)/*Error near IL_000b: Stack underflow*/ < (nint)intPtr);
		/*Error near IL_000b: Invalid metadata token*/;
	}

	static byte[] smethod_23(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1)
	{
		//Discarded unreachable code: IL_0007, IL_000e, IL_0017, IL_0032, IL_0037
		//IL_0012: Incompatible stack heights: 0 vs 1
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (long)(ushort)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	static extern Encoding smethod_24();

	static string smethod_25(Encoding encoding_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_0007, IL_000c, IL_0017, IL_0018, IL_001d, IL_0028, IL_002e, IL_0033, IL_003d, IL_0041
		//IL_0002: Expected F8, but got I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between Unknown and O
		byte num = checked((byte)/*Error near IL_0001: Stack underflow*/);
		((double[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (int)num;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static extern void smethod_26(IDisposable idisposable_0);

	static extern string smethod_27(string string_4);

	static extern WebClient smethod_28();

	static extern string smethod_29(string string_4, string string_5);

	static extern void smethod_30(WebClient webClient_0, string string_4, string string_5);

	static extern void smethod_31(Component component_0);

	static Process smethod_32()
	{
		/*Error: Invalid metadata token*/;
	}

	static extern ProcessStartInfo smethod_33();

	static extern void smethod_34(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static extern void smethod_35(ProcessStartInfo processStartInfo_0, string string_4);

	static extern string smethod_36(string string_4, string string_5, string string_6);

	static extern void smethod_37(ProcessStartInfo processStartInfo_0, string string_4);

	static void smethod_38(Process process_0, ProcessStartInfo processStartInfo_0)
	{
		//Discarded unreachable code: IL_0008
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ = checked((byte)/*Error near IL_0001: Stack underflow*/) & 2;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static bool smethod_39(Process process_0)
	{
		do
		{
			/*OpCode not supported: Ckfinite*/;
		}
		while (/*Error near IL_0007: Stack underflow*/ >= /*Error near IL_0007: Stack underflow*/);
		return (byte)/*Error near IL_0008: Stack underflow*/ != 0;
	}

	static extern void smethod_40(int int_0);

	static extern void smethod_41(string string_4);

	unsafe static string smethod_42(string string_4)
	{
		//Discarded unreachable code: IL_0010
		//IL_0009: Expected I8, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			/*Error: stloc 1 (out-of-bounds)*/;
			*(_003F*)(nint)/*Error near IL_0004: Stack underflow*/ = /*Error near IL_0004: Stack underflow*/;
			nint num = (nint)/*Error near IL_0006: Stack underflow*/;
			((sbyte[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/] = (sbyte)num;
			int num2 = ((int[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/];
			((long[])/*Error near IL_0009: Stack underflow*/)[/*Error near IL_0009: Stack underflow*/] = num2;
		}
		while ((int)/*Error near IL_000e: Stack underflow*/ != 0);
		_ = /*Error near IL_000f: Stack underflow*/| /*Error near IL_000f: Stack underflow*/;
		/*Error near IL_000f: Unknown opcode: 0xFB*/;
	}

	static extern RegistryKey smethod_43(RegistryKey registryKey_0, string string_4, RegistryKeyPermissionCheck registryKeyPermissionCheck_0);

	static RegistryKey smethod_44(RegistryKey registryKey_0, string string_4)
	{
		//Discarded unreachable code: IL_0001, IL_0007, IL_000c, IL_0010, IL_001a
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Unknown opcode: 0xFC*/;
	}

	static extern void smethod_45(RegistryKey registryKey_0, string string_4, object object_0, RegistryValueKind registryValueKind_0);

	static extern object smethod_46(RegistryKey registryKey_0, string string_4);

	static extern void smethod_47(ProcessStartInfo processStartInfo_0, bool bool_5);

	static void smethod_48(ProcessStartInfo processStartInfo_0, bool bool_5)
	{
		//IL_0001: Invalid comparison between Unknown and I4
		while ((int)/*Error near IL_0006: Stack underflow*/ >= 6)
		{
		}
		checked
		{
			_ = (uint)/*Error near IL_0007: Stack underflow*/;
			/*Error: Unexpected end of block*/;
		}
	}

	static extern void smethod_49(ProcessStartInfo processStartInfo_0, bool bool_5);

	static extern StreamReader smethod_50(Process process_0);

	static extern string smethod_51(TextReader textReader_0);

	static bool smethod_52(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0008, IL_000f, IL_0014, IL_001f, IL_0027, IL_002d, IL_0032, IL_0037
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Incompatible stack heights: 0 vs 1
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			while (true)
			{
				_003F val = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
				((int[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = unchecked((int)val);
				_ = /*Error near IL_0003: Stack underflow*/- /*Error near IL_0003: Stack underflow*/;
			}
		}
	}

	static bool smethod_53(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0008, IL_0010
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		/*Error: ldloc 1 (out-of-bounds)*/;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static extern bool smethod_54(StreamReader streamReader_0);

	static extern Assembly smethod_55();

	static extern string smethod_56(Assembly assembly_0);

	static void smethod_57(string string_4, string string_5, bool bool_5)
	{
		//Discarded unreachable code: IL_0005, IL_000b, IL_0016, IL_0021, IL_0024
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got I4
		//IL_001c: Incompatible stack heights: 0 vs 1
		//IL_002d: Expected I, but got O
		//IL_002c: Expected native int or pointer, but got F4
		//IL_0033: Expected I4, but got O
		/*Error: Invalid metadata token*/;
	}

	static extern RegistryKey smethod_58(RegistryKey registryKey_0, string string_4, bool bool_5);

	static void smethod_59(RegistryKey registryKey_0, string string_4, object object_0)
	{
		//Discarded unreachable code: IL_0014, IL_0019, IL_0020, IL_0025
		//IL_000f: Expected native int or pointer, but got O
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		_ = (sbyte)/*Error near IL_0001: Stack underflow*/;
		_ = -5.769370617066471E+72;
		/*Error near IL_000f: Invalid metadata token*/;
	}

	static extern void smethod_60(string string_4, FileAttributes fileAttributes_0);

	static extern DialogResult smethod_61(string string_4, string string_5, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0);

	static extern void smethod_62(RegistryKey registryKey_0);

	static extern WindowsIdentity smethod_63();

	static extern WindowsPrincipal smethod_64(WindowsIdentity windowsIdentity_0);

	static extern bool smethod_65(WindowsPrincipal windowsPrincipal_0, WindowsBuiltInRole windowsBuiltInRole_0);

	static extern Rectangle smethod_66(Point point_0);

	static extern Bitmap smethod_67(int int_0, int int_1);

	static Graphics smethod_68(Image image_0)
	{
		//Discarded unreachable code: IL_0007, IL_000a, IL_000f, IL_0016
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		_003F val;
		checked
		{
			nint num = (nint)(nuint)/*Error near IL_0001: Stack underflow*/;
			val = /*Error near IL_0004: Stack underflow*/* num;
		}
		_ = val - val;
		/*Error near IL_0006: Unknown opcode: 0xF9*/;
	}

	static extern void smethod_69(Graphics graphics_0, Point point_0, Point point_1, Size size_0);

	static extern ImageFormat smethod_70();

	static extern void smethod_71(Image image_0, string string_4, ImageFormat imageFormat_0);

	static extern bool smethod_72(string string_4);

	static extern void smethod_73(Process process_0);

	static string[] smethod_74(string string_4, char[] char_0)
	{
		//Discarded unreachable code: IL_0002, IL_0004, IL_000b, IL_000d, IL_001a, IL_001f, IL_0020
		//IL_0007: Expected O, but got F8
		//IL_000f: Expected I, but got I8
		/*Error near IL_0001: Unknown opcode: 0xFF*/;
	}

	static string smethod_75(WebClient webClient_0, string string_4)
	{
		while (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
		}
		_ = -1.4746301928723748E+305;
		/*Error: Unexpected end of block*/;
	}

	static string smethod_76()
	{
		//Discarded unreachable code: IL_0005, IL_000e
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
		}
	}

	static extern string smethod_77();

	static string smethod_78(string[] string_4)
	{
		//Discarded unreachable code: IL_0006, IL_0018, IL_0028, IL_002e
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between I4 and Unknown
		//IL_003a: Expected O, but got F8
		//IL_003a: Unsupported input type for neg.
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected I8, but got Unknown
		((object[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (object)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern void smethod_79(string string_4, string string_5);

	static extern Process[] smethod_80();

	static extern string smethod_81(Process process_0);

	static void smethod_82(Process process_0)
	{
		//Discarded unreachable code: IL_0011
		//IL_0001: Invalid comparison between Unknown and I4
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		byte num;
		do
		{
			num = (byte)/*Error near IL_0001: Stack underflow*/;
		}
		while ((int)/*Error near IL_0006: Stack underflow*/ != num || /*Error near IL_000c: Stack underflow*/< /*Error near IL_000c: Stack underflow*/);
		/*Error near IL_000c: Invalid metadata token*/;
	}

	static extern Process smethod_83();

	static extern IntPtr smethod_84(Process process_0);

	static extern ManagementObjectSearcher smethod_85(string string_4);

	static extern ManagementObjectCollection smethod_86(ManagementObjectSearcher managementObjectSearcher_0);

	unsafe static ManagementObjectEnumerator smethod_87(ManagementObjectCollection managementObjectCollection_0)
	{
		//Discarded unreachable code: IL_0009, IL_0010, IL_0011, IL_0026
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Incompatible stack heights: 0 vs 1
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		uint num;
		checked
		{
			num = (uint)(*unchecked((double*)(nint)/*Error near IL_0001: Stack underflow*/));
		}
		_003F val = /*Error near IL_0003: Stack underflow*// num;
		_ = /*Error near IL_0004: Stack underflow*/>> (int)val;
		/*Error near IL_0004: Invalid metadata token*/;
	}

	static extern ManagementBaseObject smethod_88(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern object smethod_89(ManagementBaseObject managementBaseObject_0, string string_4);

	static extern string smethod_90(object object_0);

	static extern string smethod_91(string string_4);

	unsafe static bool smethod_92(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0010, IL_0017, IL_0018
		//IL_001b: Expected I4, but got Unknown
		_ = (byte)(*(ushort*)(nint)/*Error: ldloca 0 (out-of-bounds)*/);
		_ = 6;
		_ = 3;
		_ = 3;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	static extern string smethod_93(string string_4);

	unsafe static bool smethod_94(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0016, IL_001c, IL_0023, IL_0029, IL_002b, IL_0031, IL_0035
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unsupported input type for neg.
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected native int or pointer, but got F8
		//IL_001a: Invalid comparison between Unknown and I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected I, but got Unknown
		_ = -checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		_ = *(ushort*)(nint)(double)(*(ulong*)(&string_4));
		_ = 1.4569447259498064E+292;
		/*Error near IL_0011: Invalid metadata token*/;
	}

	static bool smethod_95(ManagementObjectEnumerator managementObjectEnumerator_0)
	{
		checked
		{
			_ = (nint)/*Error near IL_0001: Stack underflow*/;
			_ = 6;
			/*Error: Unexpected end of block*/;
		}
	}

	unsafe static NetworkInterface[] smethod_96()
	{
		//Discarded unreachable code: IL_0011
		//IL_0002: Expected O, but got I
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected I4, but got Unknown
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			IntPtr intPtr = (nint)((Array)((Array)/*Error near IL_0001: Stack underflow*/).LongLength).LongLength;
			_003F val = /*Error near IL_0003: Stack underflow*/>> (int)(nint)intPtr;
			((short[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (short)(int)val;
		}
		while ((int)/*Error near IL_0009: Stack underflow*/ != 0);
		_ = *(byte*)(nint)checked(/*Error near IL_000a: Stack underflow*/ + /*Error near IL_000a: Stack underflow*/);
		/*Error near IL_000c: Invalid metadata token*/;
	}

	static extern OperationalStatus smethod_97(NetworkInterface networkInterface_0);

	static PhysicalAddress smethod_98(NetworkInterface networkInterface_0)
	{
		//Discarded unreachable code: IL_0005
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_ = (uint)/*Error near IL_0002: Stack underflow*/;
		/*Error near IL_0004: Unknown opcode: 0xFC*/;
	}

	static extern string smethod_99(string string_4, char[] char_0);
}
