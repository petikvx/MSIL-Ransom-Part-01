using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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

	private static FileSystemWatcher fileSystemWatcher_0;

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string string_4);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_5);

	private static extern string smethod_0();

	public static extern string smethod_1(string string_4);

	private static extern void Main();

	private static extern void smethod_2();

	private static extern bool smethod_3();

	private static extern bool smethod_4();

	private static bool smethod_5()
	{
		checked
		{
			_ = (nint)/*Error near IL_0001: Stack underflow*/;
			/*Error: Unexpected end of block*/;
		}
	}

	private static extern string smethod_6();

	private static extern void smethod_7();

	private static extern void smethod_8(object sender, FileSystemEventArgs e);

	private static extern void smethod_9();

	private static extern void smethod_10();

	public static extern bool smethod_11(string string_4);

	public extern Class5();

	static string smethod_12(string string_4)
	{
		while (/*Error near IL_0006: Stack underflow*/ <= /*Error near IL_0006: Stack underflow*/)
		{
		}
		_ = ((object[])/*Error near IL_000a: Stack underflow*/)[(object)string_4];
		_ = 7;
		_ = 105L;
		/*Error: Unexpected end of block*/;
	}

	unsafe static WebClient smethod_13()
	{
		//Discarded unreachable code: IL_001b, IL_0020, IL_0026, IL_002d
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		int num2;
		checked
		{
			byte num;
			do
			{
				/*Error: stloc 2 (out-of-bounds)*/;
				num = (byte)unchecked((uint)(*(sbyte*)(nint)/*Error near IL_0003: Stack underflow*/));
			}
			while (unchecked((int)/*Error near IL_0009: Stack underflow*/) == num || 7u != 0);
			num2 = (sbyte)unchecked((uint)(int)/*Error near IL_0010: Stack underflow*/);
		}
		_ = /*Error near IL_0015: Stack underflow*/% num2;
		/*Error near IL_0016: Invalid metadata token*/;
	}

	static extern string smethod_14(string string_4, string string_5);

	static void smethod_15(WebClient webClient_0, string string_4, string string_5)
	{
		//IL_0006: Invalid comparison between Unknown and F8
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		short num2;
		do
		{
			long num = checked((long)/*Error near IL_0001: Stack underflow*/);
			num2 = ((short[])/*Error near IL_0004: Stack underflow*/)[(short)(double)num];
		}
		while ((double)/*Error near IL_000b: Stack underflow*/ >= (double)num2);
		_ = /*Error near IL_0015: Stack underflow*/% 1L;
		/*Error: Unexpected end of block*/;
	}

	static void smethod_16(Component component_0)
	{
		//Discarded unreachable code: IL_000d, IL_0016
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected F4, but got I
		//IL_0018: Expected O, but got I4
		checked
		{
			short num = (short)unchecked(/*Error near IL_0003: Stack underflow*/ / /*Error near IL_0003: Stack underflow*/);
			_ = (short)((float[])/*Error near IL_0006: Stack underflow*/)[num];
			/*Error near IL_0008: Invalid metadata token*/;
		}
	}

	static Process smethod_17()
	{
		_ = 0uL;
		/*Error near IL_000a: Invalid metadata token*/;
	}

	static extern ProcessStartInfo smethod_18();

	static extern void smethod_19(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static extern void smethod_20(ProcessStartInfo processStartInfo_0, string string_4);

	static extern string smethod_21(string string_4, string string_5, string string_6);

	static void smethod_22(ProcessStartInfo processStartInfo_0, string string_4)
	{
		//Discarded unreachable code: IL_0018, IL_001f
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		_003F val;
		do
		{
			checked
			{
				byte num = (byte)(/*Error near IL_0002: Stack underflow*/ - /*Error near IL_0002: Stack underflow*/);
				val = /*Error near IL_0008: Stack underflow*/+ unchecked((sbyte)num);
			}
		}
		while ((int)/*Error near IL_000e: Stack underflow*/ > (int)(sbyte)val || /*Error near IL_0013: Stack underflow*/< /*Error near IL_0013: Stack underflow*/);
		/*Error near IL_0013: Invalid metadata token*/;
	}

	static extern void smethod_23(Process process_0, ProcessStartInfo processStartInfo_0);

	static bool smethod_24(Process process_0)
	{
		checked
		{
			_ = (nint)(byte)/*Error near IL_0001: ldloc 1 (out-of-bounds)*/;
			/*Error: Unexpected end of block*/;
		}
	}

	static extern void smethod_25(int int_0);

	static void smethod_26(string string_4)
	{
		//Discarded unreachable code: IL_0002, IL_0014, IL_001e, IL_002a, IL_0030, IL_0036, IL_003b
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Incompatible stack heights: 0 vs 1
		((object[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (object)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xFA*/;
	}

	unsafe static string smethod_27(string string_4)
	{
		//Discarded unreachable code: IL_0016, IL_001c, IL_0022, IL_0027, IL_002c, IL_002f
		//IL_0005: Invalid comparison between Unknown and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Incompatible stack heights: 0 vs 1
		uint num;
		do
		{
			num = ((uint[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/];
		}
		while ((int)/*Error near IL_000a: Stack underflow*/ >= (int)(sbyte)num);
		byte num2 = checked((byte)(/*Error near IL_000b: Stack underflow*/ - /*Error near IL_000b: Stack underflow*/));
		_ = *(double*)(nint)(/*Error near IL_000f: Stack underflow*/ / num2);
		/*Error near IL_0010: ldloc 2 (out-of-bounds)*/;
		/*Error near IL_0011: Invalid metadata token*/;
	}

	static extern byte[] smethod_28(string string_4);

	static extern RijndaelManaged smethod_29();

	static void smethod_30(SymmetricAlgorithm symmetricAlgorithm_0, int int_0)
	{
		//Discarded unreachable code: IL_000e, IL_0013
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (uint)/*Error near IL_0001: Stack underflow*/;
			_ = 5 & 3.5895364792652717E-87;
			/*Error near IL_000d: Unknown opcode: 0xF8*/;
		}
	}

	static extern void smethod_31(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern Encoding smethod_32();

	static byte[] smethod_33(Encoding encoding_0, string string_4)
	{
		//Discarded unreachable code: IL_0008, IL_0009
		_003F val = /*Error: ldloca 0 (out-of-bounds)*/;
		_ = ((short[])/*Error near IL_0003: Stack underflow*/)[val];
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static extern void smethod_34(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_35(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_36(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	static void smethod_37(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0)
	{
		/*Error: Invalid metadata token*/;
	}

	static extern byte[] smethod_38(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern byte[] smethod_39(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern ICryptoTransform smethod_40(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static byte[] smethod_41(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0006: Stack underflow*/* "";
			_ = 1.7116195E+31f;
			/*Error: Unexpected end of block*/;
		}
	}

	static extern Encoding smethod_42();

	static extern string smethod_43(Encoding encoding_0, byte[] byte_0);

	static extern void smethod_44(IDisposable idisposable_0);

	static extern Assembly smethod_45();

	static extern string smethod_46(Assembly assembly_0);

	static void smethod_47(string string_4, string string_5, bool bool_5)
	{
		//Discarded unreachable code: IL_0013, IL_001c, IL_0021, IL_0023, IL_0028, IL_002d, IL_0034, IL_003b
		//IL_0006: Invalid comparison between Unknown and I4
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected native int or pointer, but got O
		//IL_002f: Invalid comparison between Unknown and I4
		//IL_0035: Incompatible stack heights: 0 vs 1
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ == /*Error near IL_0005: Stack underflow*/)
			{
				byte num = (byte)/*Error near IL_0006: Stack underflow*/;
				if ((int)/*Error near IL_000b: Stack underflow*/ < (int)num)
				{
					break;
				}
			}
		}
		checked
		{
			if (/*Error near IL_000d: Stack underflow*/ >= /*Error near IL_000d: Stack underflow*/)
			{
				_ = /*Error near IL_000e: Stack underflow*/+ /*Error near IL_000e: Stack underflow*/;
				/*Error near IL_000e: Invalid metadata token*/;
			}
			/*Error near IL_0036: Invalid metadata token*/;
		}
	}

	static extern RegistryKey smethod_48(RegistryKey registryKey_0, string string_4, bool bool_5);

	static extern void smethod_49(RegistryKey registryKey_0, string string_4, object object_0);

	static extern void smethod_50(string string_4, FileAttributes fileAttributes_0);

	static RegistryKey smethod_51(RegistryKey registryKey_0, string string_4)
	{
		_ = ((ushort[])2)[(object)registryKey_0];
		_ = -1;
		/*Error: Unexpected end of block*/;
	}

	static void smethod_52(RegistryKey registryKey_0)
	{
		_ = (nuint)/*Error near IL_0001: Stack underflow*/;
		/*Error: Unexpected end of block*/;
	}

	static extern bool smethod_53(string string_4);

	unsafe static void smethod_54(Process process_0)
	{
		//Discarded unreachable code: IL_0017, IL_001e
		//IL_000f: Expected native int or pointer, but got F8
		//IL_0011: Expected I8, but got I4
		while (((uint[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] != 0)
		{
		}
		short num = *(short*)unchecked((nint)8.701427752698334E+176);
		((long[])/*Error near IL_0011: Stack underflow*/)[/*Error near IL_0011: Stack underflow*/] = num;
		checked
		{
			_ = (ulong)/*Error near IL_0011: ldloc 0 (out-of-bounds)*/;
			/*Error near IL_0016: Unknown opcode: 0xFB*/;
		}
	}

	static string[] smethod_55(string string_4, char[] char_0)
	{
		//Discarded unreachable code: IL_0003, IL_000a, IL_000f, IL_0014, IL_001c, IL_001d, IL_0037
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (ulong)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Unknown opcode: 0xFB*/;
		}
	}

	static extern string smethod_56(WebClient webClient_0, string string_4);

	static extern string smethod_57();

	static string smethod_58()
	{
		//Discarded unreachable code: IL_0003
		/*Error near IL_0002: Unknown opcode: 0xFD*/;
	}

	static extern string smethod_59(string[] string_4);

	static extern void smethod_60(string string_4, string string_5);

	static extern Process[] smethod_61();

	static extern string smethod_62(Process process_0);

	static extern void smethod_63(Process process_0);

	static extern Process smethod_64();

	static extern IntPtr smethod_65(Process process_0);

	static extern ManagementObjectSearcher smethod_66(string string_4);

	unsafe static ManagementObjectCollection smethod_67(ManagementObjectSearcher managementObjectSearcher_0)
	{
		//IL_0003: Unsupported input type for neg.
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		*(_003F*)(nint)/*Error near IL_0003: Stack underflow*/ = /*Error near IL_0003: Stack underflow*/;
		switch ((short)(0 - /*Error near IL_0004: Stack underflow*/))
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static extern ManagementObjectEnumerator smethod_68(ManagementObjectCollection managementObjectCollection_0);

	static ManagementBaseObject smethod_69(ManagementObjectEnumerator managementObjectEnumerator_0)
	{
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern object smethod_70(ManagementBaseObject managementBaseObject_0, string string_4);

	static extern string smethod_71(object object_0);

	static extern string smethod_72(string string_4);

	static extern bool smethod_73(string string_4, string string_5);

	static string smethod_74(string string_4)
	{
		//Discarded unreachable code: IL_0005
		/*Error: Invalid metadata token*/;
	}

	static extern bool smethod_75(string string_4, string string_5);

	static extern bool smethod_76(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern NetworkInterface[] smethod_77();

	static extern OperationalStatus smethod_78(NetworkInterface networkInterface_0);

	static extern PhysicalAddress smethod_79(NetworkInterface networkInterface_0);

	static extern string smethod_80(string string_4, char[] char_0);

	static extern FileSystemWatcher smethod_81();

	static extern string smethod_82(Environment.SpecialFolder specialFolder_0);

	static extern void smethod_83(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static void smethod_84(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0)
	{
		//Discarded unreachable code: IL_000f, IL_0019, IL_001f, IL_0027, IL_002e
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unsupported input type for neg.
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got I4
		//IL_0022: Incompatible stack heights: 0 vs 2
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		((int[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (int)/*Error near IL_0002: Stack underflow*/;
		ulong num = (ulong)/*Error near IL_0003: Stack underflow*/;
		_003F val = checked(/*Error near IL_0004: Stack underflow*/ - num);
		_003F val2 = /*Error near IL_0005: Stack underflow*/^ val;
		_ = ((short[])/*Error near IL_000a: Stack underflow*/)[0 - val2];
		/*Error near IL_000a: Invalid metadata token*/;
	}

	static extern void smethod_85(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static extern void smethod_86(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0);

	static extern void smethod_87(FileSystemWatcher fileSystemWatcher_1, bool bool_5);

	static extern bool smethod_88(string string_4, string string_5);

	static extern bool smethod_89(string string_4);

	static extern string[] smethod_90(string string_4, string string_5);

	static Match smethod_91(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0006, IL_000e, IL_0013, IL_001b, IL_0021, IL_0030
		//IL_0009: Invalid comparison between Unknown and Ref
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected F8, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_ = (double)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern WebHeaderCollection smethod_92(WebClient webClient_0);

	static extern void smethod_93(WebHeaderCollection webHeaderCollection_0, HttpRequestHeader httpRequestHeader_0, string string_4);
}
