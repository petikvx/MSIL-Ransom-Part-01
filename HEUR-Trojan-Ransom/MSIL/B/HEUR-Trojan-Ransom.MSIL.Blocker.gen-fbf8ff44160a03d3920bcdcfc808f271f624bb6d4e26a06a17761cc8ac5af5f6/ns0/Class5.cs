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

	private static FileSystemWatcher fileSystemWatcher_0;

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

	private static extern bool smethod_5();

	private static extern string smethod_6();

	private static extern void smethod_7();

	private static extern void smethod_8(object sender, FileSystemEventArgs e);

	private static extern void smethod_9();

	private static extern void smethod_10();

	public static bool smethod_11(string string_4)
	{
		//Discarded unreachable code: IL_0015
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got I4
		//IL_001e: Expected I4, but got F8
		/*OpCode not supported: DebugBreak*/;
		double num = ((double[])(/*Error near IL_0003: Stack underflow*/ << 6))[checked((long)/*Error near IL_0004: ldloca 0 (out-of-bounds)*/)];
		sbyte num2 = ((sbyte[])/*Error near IL_000d: Stack underflow*/)[num];
		((object[])/*Error near IL_000e: Stack underflow*/)[/*Error near IL_000e: Stack underflow*/] = num2;
		_ = 3;
		/*Error near IL_0010: Invalid metadata token*/;
	}

	private static extern void smethod_12();

	public extern Class5();

	static Class5()
	{
		//Discarded unreachable code: IL_0004, IL_0009, IL_0011, IL_0019, IL_0021, IL_0031, IL_0036
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_001d: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (long)/*Error near IL_0001: Stack underflow*/;
			_ = 8;
			/*Error near IL_0003: Unknown opcode: 0xFB*/;
		}
	}

	static extern byte[] smethod_13(string string_4);

	static extern RijndaelManaged smethod_14();

	static extern void smethod_15(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern void smethod_16(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern Encoding smethod_17();

	static extern byte[] smethod_18(Encoding encoding_0, string string_4);

	static extern void smethod_19(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_20(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_21(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	static extern void smethod_22(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static extern byte[] smethod_23(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern byte[] smethod_24(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern ICryptoTransform smethod_25(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static extern byte[] smethod_26(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static extern Encoding smethod_27();

	static string smethod_28(Encoding encoding_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_000b, IL_0011
		//IL_0007: Expected O, but got I4
		//IL_000c: Invalid comparison between Unknown and I
		//IL_0015: Expected F4, but got I4
		/*OpCode not supported: Ckfinite*/;
		_ = ((float[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/];
		checked
		{
			_ = (byte)/*Error near IL_0003: ldloc 3 (out-of-bounds)*/;
			/*Error near IL_0006: Invalid metadata token*/;
		}
	}

	static extern void smethod_29(IDisposable idisposable_0);

	static extern string smethod_30(string string_4);

	static WebClient smethod_31()
	{
		//Discarded unreachable code: IL_000e, IL_0013, IL_0014, IL_001c, IL_0021, IL_0026, IL_002e
		while (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/)
		{
		}
		_ = 0;
		/*Error near IL_0007: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0009: Invalid metadata token*/;
	}

	static extern string smethod_32(string string_4, string string_5);

	static extern void smethod_33(WebClient webClient_0, string string_4, string string_5);

	static extern void smethod_34(Component component_0);

	static extern Process smethod_35();

	unsafe static ProcessStartInfo smethod_36()
	{
		//IL_0003: Expected F8, but got I4
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got I4
		byte num = *(byte*)(ulong)/*Error near IL_0001: Stack underflow*/;
		*(double*)(nint)/*Error near IL_0003: Stack underflow*/ = (int)num;
		_003F val = /*Error near IL_0004: ldarg 1 (out-of-bounds)*/;
		_003F val2 = /*Error near IL_0006: Stack underflow*/% val;
		((object[])/*Error near IL_000a: Stack underflow*/)[/*Error near IL_000a: Stack underflow*/] = (short)val2;
		/*Error near IL_000a: Invalid metadata token*/;
	}

	static extern void smethod_37(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static extern void smethod_38(ProcessStartInfo processStartInfo_0, string string_4);

	static extern string smethod_39(string string_4, string string_5, string string_6);

	static extern void smethod_40(ProcessStartInfo processStartInfo_0, string string_4);

	static extern void smethod_41(Process process_0, ProcessStartInfo processStartInfo_0);

	static extern bool smethod_42(Process process_0);

	static extern void smethod_43(int int_0);

	static void smethod_44(string string_4)
	{
		//Discarded unreachable code: IL_0005, IL_000a
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
		}
	}

	static extern string smethod_45(string string_4);

	static extern Assembly smethod_46();

	static extern string smethod_47(Assembly assembly_0);

	static extern void smethod_48(string string_4, string string_5, bool bool_5);

	static RegistryKey smethod_49(RegistryKey registryKey_0, string string_4, bool bool_5)
	{
		//Discarded unreachable code: IL_0009, IL_000e, IL_000f
		_ = ((uint[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/];
		/*Error near IL_0004: Invalid metadata token*/;
	}

	unsafe static void smethod_50(RegistryKey registryKey_0, string string_4, object object_0)
	{
		//Discarded unreachable code: IL_0009, IL_001a, IL_001c, IL_001d
		//IL_0015: Incompatible stack heights: 0 vs 2
		while (true)
		{
			byte num = ((byte[])/*Error near IL_0002: Stack underflow*/)[8];
			*(IntPtr*)(nint)/*Error near IL_0004: Stack underflow*/ = (IntPtr)(int)num;
		}
	}

	static extern DialogResult smethod_51(string string_4, string string_5, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0);

	unsafe static bool smethod_52(string string_4)
	{
		//Discarded unreachable code: IL_0009, IL_000f, IL_0014, IL_0016, IL_001d, IL_002a
		//IL_0005: Expected F8, but got O
		//IL_0008: Expected F4, but got I8
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0025: Invalid comparison between I4 and F4
		//IL_002c: Expected I, but got F8
		_003F val = /*Error: ldloc 0 (out-of-bounds)*/;
		((double[])/*Error near IL_0005: Stack underflow*/)[(float)val] = (double)null;
		long num = *(long*)(nint)/*Error near IL_0005: ldloc 3 (out-of-bounds)*/;
		*(float*)(nint)/*Error near IL_0008: Stack underflow*/ = num;
		/*Error near IL_0008: Unknown opcode: 0xFB*/;
	}

	static extern void smethod_53(Process process_0);

	static extern string[] smethod_54(string string_4, char[] char_0);

	static extern string smethod_55(WebClient webClient_0, string string_4);

	static extern string smethod_56();

	unsafe static string smethod_57()
	{
		//IL_0006: Expected I4, but got I8
		switch (*(long*)(nint)/*Error near IL_0001: Stack underflow*/)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static string smethod_58(string[] string_4)
	{
		//Discarded unreachable code: IL_0006, IL_0015, IL_001d, IL_0025, IL_002d
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		//IL_001f: Expected F4, but got I
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_0028: Invalid comparison between Unknown and I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		checked
		{
			_ = (long)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	static void smethod_59(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0008, IL_0010, IL_0018, IL_001e, IL_0023, IL_0028, IL_002d, IL_0031
		//IL_000a: Expected F4, but got I
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		while (true)
		{
			_ = 7;
			/*Error near IL_0001: stloc 0 (out-of-bounds)*/;
		}
	}

	static extern Process[] smethod_60();

	static extern string smethod_61(Process process_0);

	static extern void smethod_62(Process process_0);

	unsafe static Process smethod_63()
	{
		_ = *(IntPtr*)(nint)/*Error: ldarg 3 (out-of-bounds)*/;
		_ = 1.01783535E+34f;
		/*Error: Unexpected end of block*/;
	}

	static IntPtr smethod_64(Process process_0)
	{
		//Discarded unreachable code: IL_000b, IL_0014, IL_0019, IL_0024, IL_002c, IL_002f
		//IL_000f: Incompatible stack heights: 0 vs 1
		//IL_001c: Expected I4, but got Unknown
		//IL_001f: Invalid comparison between Unknown and I4
		//IL_002e: Expected I, but got Unknown
		while (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/|| /*Error near IL_000a: Stack underflow*/!= /*Error near IL_000a: Stack underflow*/)
		{
		}
		/*Error near IL_000a: Unknown opcode: 0xFB*/;
	}

	unsafe static ManagementObjectSearcher smethod_65(string string_4)
	{
		//Discarded unreachable code: IL_0012, IL_0015
		//IL_0002: Expected I4, but got Unknown
		//IL_0005: Invalid comparison between Unknown and I4
		//IL_0014: Expected I, but got Unknown
		//IL_0017: Invalid comparison between Unknown and I
		sbyte num;
		do
		{
			_003F val = /*Error: ldarg 1 (out-of-bounds)*/;
			((int[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (int)val;
			*(_003F*)(nint)/*Error near IL_0003: Stack underflow*/ = /*Error near IL_0003: Stack underflow*/;
			((object[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (object)/*Error near IL_0004: Stack underflow*/;
			num = checked((sbyte)/*Error near IL_0005: Stack underflow*/);
		}
		while ((int)/*Error near IL_000a: Stack underflow*/ >= (int)num);
		((long[])/*Error near IL_000b: Stack underflow*/)[/*Error near IL_000b: Stack underflow*/] = (long)/*Error near IL_000b: Stack underflow*/;
		_ = ref string_4;
		/*Error near IL_000d: Invalid metadata token*/;
	}

	static extern ManagementObjectCollection smethod_66(ManagementObjectSearcher managementObjectSearcher_0);

	static extern ManagementObjectEnumerator smethod_67(ManagementObjectCollection managementObjectCollection_0);

	static extern ManagementBaseObject smethod_68(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern object smethod_69(ManagementBaseObject managementBaseObject_0, string string_4);

	static string smethod_70(object object_0)
	{
		while (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0006: Stack underflow*/)
		{
		}
		((long[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/] = (long)/*Error near IL_0007: Stack underflow*/;
		return (string)/*OpCode not supported: Nop*/;
	}

	unsafe static string smethod_71(string string_4)
	{
		_ = *(ushort*)5;
		/*Error near IL_0003: stloc 0 (out-of-bounds)*/;
		return (string)/*OpCode not supported: Nop*/;
	}

	static extern bool smethod_72(string string_4, string string_5);

	static string smethod_73(string string_4)
	{
		//Discarded unreachable code: IL_0007, IL_0010
		//IL_000b: Expected O, but got Unknown
		//IL_0013: Expected F4, but got I
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (ulong)(object)null;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	static extern bool smethod_74(string string_4, string string_5);

	static extern bool smethod_75(ManagementObjectEnumerator managementObjectEnumerator_0);

	static NetworkInterface[] smethod_76()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Expected O, but got Unknown
		sbyte num = ((sbyte[])/*Error near IL_0003: Stack underflow*/)[2];
		return (NetworkInterface[])(/*Error near IL_0004: Stack underflow*/ | num);
	}

	static OperationalStatus smethod_77(NetworkInterface networkInterface_0)
	{
		//IL_0004: Invalid comparison between Unknown and F8
		ulong num;
		do
		{
			((sbyte[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (sbyte)/*Error near IL_0002: Stack underflow*/;
			num = (ulong)/*Error near IL_0003: Stack underflow*/;
		}
		while ((double)/*Error near IL_0009: Stack underflow*/ >= (double)(long)num);
		/*Error near IL_0009: Invalid metadata token*/;
	}

	static extern PhysicalAddress smethod_78(NetworkInterface networkInterface_0);

	static extern string smethod_79(string string_4, char[] char_0);

	unsafe static FileSystemWatcher smethod_80()
	{
		//Discarded unreachable code: IL_000a, IL_000b, IL_0012, IL_0028, IL_002f, IL_0038, IL_003d
		//IL_0006: Expected F8, but got I4
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got I8
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: stloc 0 (out-of-bounds)*/;
		ushort num = *(ushort*)(nint)/*Error near IL_0004: Stack underflow*/;
		*(double*)(nint)/*Error near IL_0006: Stack underflow*/ = (int)num;
		int num2 = checked((int)/*Error near IL_0008: Stack underflow*/);
		_ = /*Error near IL_0009: Stack underflow*/>> num2;
		/*Error near IL_0009: Unknown opcode: 0xFF*/;
	}

	unsafe static string smethod_81(Environment.SpecialFolder specialFolder_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got I8
		while (true)
		{
			IntPtr intPtr = *(IntPtr*)(short)/*Error near IL_0001: Stack underflow*/;
			_003F val = /*Error near IL_0005: Stack underflow*/| (nint)intPtr;
			if ((uint)(byte)(/*Error near IL_0006: Stack underflow*/ * val) <= (uint)(*(byte*)(int)(*(ushort*)(nint)/*Error near IL_0007: ldloc 0 (out-of-bounds)*/)) && *(short*)(nint)(/*Error near IL_0012: Stack underflow*/ / /*Error near IL_0012: Stack underflow*/) == 0)
			{
				byte num = checked((byte)/*Error near IL_0019: Stack underflow*/);
				ushort num2 = ((ushort[])/*Error near IL_001a: Stack underflow*/)[num];
				*(object*)(nint)/*Error near IL_001c: Stack underflow*/ = (int)num2;
				if (/*Error near IL_0021: Stack underflow*/ != /*Error near IL_0021: Stack underflow*/&& /*Error near IL_0026: Stack underflow*/<= /*Error near IL_0026: Stack underflow*/)
				{
					break;
				}
			}
		}
		((object[])/*Error near IL_0027: Stack underflow*/)[/*Error near IL_0027: Stack underflow*/] = (object)/*Error near IL_0027: Stack underflow*/;
		/*Error near IL_0027: stloc 1 (out-of-bounds)*/;
		return (string)/*OpCode not supported: Nop*/;
	}

	unsafe static void smethod_82(FileSystemWatcher fileSystemWatcher_1, string string_4)
	{
		//IL_0008: Expected O, but got I8
		while (true)
		{
			byte num = checked((byte)/*Error: ldloca 0 (out-of-bounds)*/);
			ushort num2 = ((ushort[])/*Error near IL_0006: Stack underflow*/)[num];
			*(object*)(nint)/*Error near IL_0008: Stack underflow*/ = (int)num2;
			if (/*Error near IL_000d: Stack underflow*/ != /*Error near IL_000d: Stack underflow*/&& /*Error near IL_0012: Stack underflow*/<= /*Error near IL_0012: Stack underflow*/)
			{
				/*Error: Could not find block for branch target IL_0012*/;
			}
		}
	}

	static extern void smethod_83(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0);

	static extern void smethod_84(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static extern void smethod_85(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0);

	static extern void smethod_86(FileSystemWatcher fileSystemWatcher_1, bool bool_5);

	static extern bool smethod_87(string string_4, string string_5);

	static bool smethod_88(string string_4)
	{
		//Discarded unreachable code: IL_000c, IL_000d, IL_0014, IL_0015
		//IL_0003: Expected F8, but got I4
		((object[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (object)/*Error near IL_0001: Stack underflow*/;
		sbyte num = (sbyte)/*Error near IL_0002: Stack underflow*/;
		((double[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = num;
		/*OpCode not supported: Ckfinite*/;
		/*Error near IL_0007: Invalid metadata token*/;
	}

	static string[] smethod_89(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0001, IL_0009
		//IL_0004: Incompatible stack heights: 0 vs 1
		/*Error: Unknown opcode: 0xF9*/;
	}

	unsafe static Match smethod_90(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_000b, IL_0031
		//IL_0006: Expected F4, but got O
		//IL_0005: Expected native int or pointer, but got O
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected I8, but got I4
		//IL_0020: Expected O, but got F4
		*(_003F*)(nint)/*Error near IL_0002: Stack underflow*/ = /*Error near IL_0002: Stack underflow*/;
		*(float*)(nint)string_4 = (float)string_4;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static extern WebHeaderCollection smethod_91(WebClient webClient_0);

	static extern void smethod_92(WebHeaderCollection webHeaderCollection_0, HttpRequestHeader httpRequestHeader_0, string string_4);

	static extern byte[] smethod_93(string string_4);

	static extern Encoding smethod_94();

	static extern int smethod_95(string string_4, string string_5);

	static extern string smethod_96(string string_4, int int_0, int int_1);

	static extern string smethod_97(string string_4, int int_0, string string_5);

	static extern void smethod_98(string string_4, byte[] byte_0);
}
