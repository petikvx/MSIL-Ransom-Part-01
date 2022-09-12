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

	private static void smethod_2()
	{
		//Discarded unreachable code: IL_0006, IL_000b
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		while ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
		}
		/*Error near IL_0005: Unknown opcode: 0xFA*/;
	}

	private static extern bool smethod_3();

	private static extern bool smethod_4();

	private static bool smethod_5()
	{
		//Discarded unreachable code: IL_0015, IL_001b, IL_0021
		//IL_0005: Expected I4, but got Unknown
		//IL_0007: Incompatible stack heights: 0 vs 1
		do
		{
			/*Error near IL_0001: stloc 1 (out-of-bounds)*/;
			_003F val = /*Error near IL_0003: ldarg 1 (out-of-bounds)*/;
			((short[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (short)(int)val;
			_ = 3;
		}
		while (5u != 0);
		_ = -1;
		/*Error near IL_000e: ldarg 2 (out-of-bounds)*/;
		/*Error near IL_0010: Invalid metadata token*/;
	}

	private static extern string smethod_6();

	private static extern void smethod_7();

	private unsafe static void smethod_8(object sender, FileSystemEventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected F8, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got I4
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/&& /*Error near IL_000a: Stack underflow*/<= /*Error near IL_000a: Stack underflow*/)
			{
				_003F val = ~/*Error near IL_000b: Stack underflow*/;
				if (/*Error near IL_0010: Stack underflow*/ >= val)
				{
					break;
				}
			}
		}
		*(double*)(nint)/*Error near IL_0012: Stack underflow*/ = 1.0;
		_003F val2 = ~/*Error near IL_0014: Stack underflow*/;
		byte num = *(byte*)4;
		((object[])/*Error near IL_0018: Stack underflow*/)[val2] = num;
		uint num2 = (uint)(int)/*Error near IL_001a: Stack underflow*/;
		checked
		{
			_ = (ushort)(nint)((IntPtr[])/*Error near IL_001c: Stack underflow*/)[num2];
		}
	}

	public extern Class5();

	static string smethod_9(string string_4)
	{
		//Discarded unreachable code: IL_000d, IL_0027, IL_002c, IL_0031
		sbyte num = (sbyte)/*Error near IL_0001: Stack underflow*/;
		_ = ((ushort[])/*Error near IL_0002: Stack underflow*/)[num];
		_ = -3.975032136048587E+213;
		/*Error near IL_000c: Unknown opcode: 0xFB*/;
	}

	static extern WebClient smethod_10();

	static extern string smethod_11(string string_4, string string_5);

	static extern void smethod_12(WebClient webClient_0, string string_4, string string_5);

	static extern void smethod_13(Component component_0);

	static Process smethod_14()
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_0010, IL_0020, IL_0026
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static extern ProcessStartInfo smethod_15();

	static extern void smethod_16(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static void smethod_17(ProcessStartInfo processStartInfo_0, string string_4)
	{
		//Discarded unreachable code: IL_0009, IL_0019
		//IL_000f: Expected native int or pointer, but got O
		//IL_0014: Invalid comparison between Unknown and O
		_ = 3;
		/*Error near IL_0004: Invalid metadata token*/;
	}

	static string smethod_18(string string_4, string string_5, string string_6)
	{
		//Discarded unreachable code: IL_0011, IL_001c, IL_0035, IL_003d, IL_0044
		//IL_0013: Expected I4, but got I8
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		while (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
		{
		}
		checked
		{
			_ = (nint)unchecked((int)checked((ushort)27199688));
			/*Error near IL_000c: Invalid metadata token*/;
		}
	}

	static extern void smethod_19(ProcessStartInfo processStartInfo_0, string string_4);

	static extern void smethod_20(Process process_0, ProcessStartInfo processStartInfo_0);

	static extern bool smethod_21(Process process_0);

	static extern void smethod_22(int int_0);

	static extern void smethod_23(string string_4);

	static extern string smethod_24(string string_4);

	static extern byte[] smethod_25(string string_4);

	static extern RijndaelManaged smethod_26();

	static extern void smethod_27(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	unsafe static void smethod_28(SymmetricAlgorithm symmetricAlgorithm_0, int int_0)
	{
		//Discarded unreachable code: IL_0009, IL_0011, IL_0017, IL_0021, IL_0026, IL_0028, IL_0037
		//IL_000c: Invalid comparison between I4 and Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Incompatible stack heights: 1 vs 0
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected native int or pointer, but got O
		short num = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		checked
		{
			_ = (nint)unchecked((ulong)((long[])/*Error near IL_0003: Stack underflow*/)[num]);
			/*Error near IL_0004: Invalid metadata token*/;
		}
	}

	static extern Encoding smethod_29();

	static extern byte[] smethod_30(Encoding encoding_0, string string_4);

	static extern void smethod_31(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_32(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static void smethod_33(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0)
	{
		_ = (double)(sbyte)/*Error near IL_0001: Stack underflow*/;
		_ = 4L;
		/*Error: Unexpected end of block*/;
	}

	static void smethod_34(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0001: Stack underflow*/& /*Error near IL_0001: Stack underflow*/;
		_ = 6;
		_ = 2018734080;
		/*Error near IL_0007: ldloc 0 (out-of-bounds)*/;
		_ = 8;
		checked
		{
			_ = (long)cipherMode_0;
			_ = -1.8986013241136863E-137;
			/*Error: Unexpected end of block*/;
		}
	}

	static extern byte[] smethod_35(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern byte[] smethod_36(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern ICryptoTransform smethod_37(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static byte[] smethod_38(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1)
	{
		//Discarded unreachable code: IL_0001, IL_0006, IL_000b, IL_0013, IL_0014, IL_0021, IL_002a
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Incompatible stack heights: 0 vs 1
		//IL_001b: Expected I4, but got O
		//IL_001c: Invalid comparison between Unknown and I4
		/*Error: Unknown opcode: 0xFB*/;
	}

	static Encoding smethod_39()
	{
		//IL_0001: Invalid comparison between Unknown and I4
		while (true)
		{
			ushort num = checked((ushort)/*Error near IL_0001: Stack underflow*/);
			if ((int)/*Error near IL_0006: Stack underflow*/ < (int)num)
			{
				/*Error near IL_0006: stloc 3 (out-of-bounds)*/;
				((IntPtr[])/*Error near IL_000a: Stack underflow*/)[/*Error near IL_000a: Stack underflow*/] = (IntPtr)/*Error near IL_000a: Stack underflow*/;
				if (/*Error near IL_000f: Stack underflow*/ < /*Error near IL_000f: Stack underflow*/)
				{
					break;
				}
			}
		}
		/*Error near IL_000f: Invalid metadata token*/;
	}

	static extern string smethod_40(Encoding encoding_0, byte[] byte_0);

	static extern void smethod_41(IDisposable idisposable_0);

	static extern Assembly smethod_42();

	static extern string smethod_43(Assembly assembly_0);

	static extern void smethod_44(string string_4, string string_5, bool bool_5);

	static RegistryKey smethod_45(RegistryKey registryKey_0, string string_4, bool bool_5)
	{
		_ = (int)/*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static extern void smethod_46(RegistryKey registryKey_0, string string_4, object object_0);

	static Rectangle smethod_47(Point point_0)
	{
		//Discarded unreachable code: IL_000b, IL_0015, IL_0022, IL_002c, IL_0033, IL_0039, IL_0040, IL_0048
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected F8, but got I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		while (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0006: Stack underflow*/)
		{
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static extern Bitmap smethod_48(int int_0, int int_1);

	unsafe static Graphics smethod_49(Image image_0)
	{
		//Discarded unreachable code: IL_000b, IL_0012, IL_001a, IL_0023
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		while (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
		{
		}
		*(_003F*)(nint)/*Error near IL_0006: Stack underflow*/ = /*Error near IL_0006: Stack underflow*/;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static extern void smethod_50(Graphics graphics_0, Point point_0, Point point_1, Size size_0);

	static extern ImageFormat smethod_51();

	static extern void smethod_52(Image image_0, string string_4, ImageFormat imageFormat_0);

	static extern bool smethod_53(string string_4);

	static extern void smethod_54(Process process_0);

	static string[] smethod_55(string string_4, char[] char_0)
	{
		while (/*Error near IL_0006: Stack underflow*/ == /*Error near IL_0006: Stack underflow*/)
		{
		}
		return (string[])/*Error near IL_0007: Stack underflow*/;
	}

	static extern string smethod_56(WebClient webClient_0, string string_4);

	static extern string smethod_57();

	static extern string smethod_58();

	static extern string smethod_59(string[] string_4);

	static extern void smethod_60(string string_4, string string_5);

	static Process[] smethod_61()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		_003F val = /*Error near IL_0003: Stack underflow*/>> 5;
		checked
		{
			_ = /*Error near IL_0004: Stack underflow*/+ val;
			/*Error near IL_0004: stloc 2 (out-of-bounds)*/;
		}
		_ = /*Error near IL_0006: Stack underflow*// /*Error near IL_0006: Stack underflow*/;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static extern string smethod_62(Process process_0);

	static extern void smethod_63(Process process_0);

	static extern Process smethod_64();

	static extern IntPtr smethod_65(Process process_0);

	static extern ManagementObjectSearcher smethod_66(string string_4);

	static extern ManagementObjectCollection smethod_67(ManagementObjectSearcher managementObjectSearcher_0);

	unsafe static ManagementObjectEnumerator smethod_68(ManagementObjectCollection managementObjectCollection_0)
	{
		//Discarded unreachable code: IL_0024, IL_002d, IL_0030, IL_003b
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Incompatible stack heights: 0 vs 1
		//IL_0012: Invalid comparison between Unknown and I
		//IL_001a: Invalid comparison between I4 and Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected I8, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			_003F val = /*Error near IL_0002: Stack underflow*/% /*Error near IL_0002: Stack underflow*/;
			if (/*Error near IL_0007: Stack underflow*/ < val)
			{
				continue;
			}
			_ = (ulong)/*Error near IL_0008: Stack underflow*/;
			if (uint.MaxValue != 0)
			{
				continue;
			}
			IntPtr intPtr = *(IntPtr*)(nint)/*Error near IL_0012: Stack underflow*/;
			if ((nint)/*Error near IL_0017: Stack underflow*/ <= (nint)intPtr)
			{
				*(_003F*)(nint)/*Error near IL_0018: Stack underflow*/ = /*Error near IL_0018: Stack underflow*/;
				if ((byte)/*Error near IL_0019: Stack underflow*/ == (int)/*Error near IL_0019: ldloc 3 (out-of-bounds)*/)
				{
					break;
				}
			}
		}
		/*Error near IL_001f: Invalid metadata token*/;
	}

	static extern ManagementBaseObject smethod_69(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern object smethod_70(ManagementBaseObject managementBaseObject_0, string string_4);

	static extern string smethod_71(object object_0);

	static extern string smethod_72(string string_4);

	static extern bool smethod_73(string string_4, string string_5);

	static string smethod_74(string string_4)
	{
		/*Error: Unexpected end of block*/;
	}

	static bool smethod_75(string string_4, string string_5)
	{
		switch (/*Error near IL_0005: Stack underflow*/)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

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
		checked
		{
			_ = (nint)/*Error near IL_0002: Stack underflow*/;
		}
	}

	static extern void smethod_85(FileSystemWatcher fileSystemWatcher_1, string string_4);

	unsafe static void smethod_86(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0)
	{
		//Discarded unreachable code: IL_0007, IL_0010
		//IL_0003: Expected O, but got I4
		_ = *(short*)(int)(*(ushort*)(nint)/*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static extern void smethod_87(FileSystemWatcher fileSystemWatcher_1, bool bool_5);

	static extern bool smethod_88(string string_4, string string_5);
}
