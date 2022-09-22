using System;
using System.Collections.Generic;
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

	private static FileSystemWatcher fileSystemWatcher_0;

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string string_4);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_5);

	public unsafe static string smethod_0(string string_4)
	{
		//Discarded unreachable code: IL_000c, IL_0011, IL_001b, IL_0026, IL_0030
		//IL_0001: Invalid comparison between Unknown and I
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected I, but got O
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		IntPtr intPtr;
		do
		{
			intPtr = *(IntPtr*)(nint)/*Error near IL_0001: Stack underflow*/;
		}
		while ((nint)/*Error near IL_0006: Stack underflow*/ > (nint)intPtr);
		checked
		{
			_ = /*Error near IL_0007: Stack underflow*/- /*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0007: Invalid metadata token*/;
		}
	}

	private static extern void smethod_1(string string_4, string string_5, string string_6);

	private static extern void smethod_2();

	private static extern void smethod_3(string string_4);

	private unsafe static void Main()
	{
		//Discarded unreachable code: IL_000b, IL_0018, IL_001e, IL_0025, IL_002c, IL_0031, IL_0039
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		object obj = *(object*)(nint)/*Error near IL_0001: Stack underflow*/;
		checked
		{
			_ = (sbyte)((ushort[])/*Error near IL_0002: Stack underflow*/)[obj];
			/*Error near IL_0006: Invalid metadata token*/;
		}
	}

	private static extern void smethod_4();

	private unsafe static bool smethod_5()
	{
		//Discarded unreachable code: IL_0019, IL_0024
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and O
		object obj;
		do
		{
			((long[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (long)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 0 (out-of-bounds)*/;
			short num = *(short*)(nint)(2 % /*Error near IL_0005: ldarg 2 (out-of-bounds)*/);
			obj = ((object[])/*Error near IL_0009: Stack underflow*/)[num];
		}
		while (/*Error near IL_000e: Stack underflow*/ < obj || /*Error near IL_0013: Stack underflow*/< /*Error near IL_0013: Stack underflow*/);
		_ = (long)/*Error near IL_0014: Stack underflow*/;
		/*Error near IL_0014: Invalid metadata token*/;
	}

	private static bool smethod_6()
	{
		//Discarded unreachable code: IL_0007, IL_0013, IL_001d
		//IL_0001: Invalid comparison between Unknown and I
		//IL_001f: Expected I4, but got F8
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		nint num;
		do
		{
			num = checked((nint)/*Error near IL_0001: Stack underflow*/);
		}
		while ((nint)/*Error near IL_0006: Stack underflow*/ > num);
		/*Error near IL_0006: Unknown opcode: 0xFB*/;
	}

	private static extern bool smethod_7();

	private static extern string smethod_8();

	private static void smethod_9()
	{
		//Discarded unreachable code: IL_0003, IL_000c, IL_001f
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		sbyte num = (sbyte)/*Error near IL_0001: Stack underflow*/;
		_ = /*Error near IL_0002: Stack underflow*/>> (int)num;
		/*Error near IL_0002: Unknown opcode: 0xFA*/;
	}

	private static extern void smethod_10(object sender, FileSystemEventArgs e);

	private static extern void smethod_11();

	private static extern void smethod_12();

	public unsafe static bool smethod_13(string string_4)
	{
		//Discarded unreachable code: IL_0007, IL_000e
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		_ = (ulong)/*Error near IL_0002: Stack underflow*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	private static extern void smethod_14();

	public extern Class5();

	static extern byte[] smethod_15(string string_4);

	static extern RijndaelManaged smethod_16();

	static extern void smethod_17(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern void smethod_18(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern Encoding smethod_19();

	static byte[] smethod_20(Encoding encoding_0, string string_4)
	{
		//Discarded unreachable code: IL_0001, IL_0007, IL_000d, IL_0012, IL_0017, IL_001d
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0022: Expected O, but got I4
		/*Error: Unknown opcode: 0xFF*/;
	}

	static extern void smethod_21(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_22(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_23(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	static extern void smethod_24(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static extern byte[] smethod_25(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern byte[] smethod_26(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern ICryptoTransform smethod_27(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static extern byte[] smethod_28(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static extern Encoding smethod_29();

	static extern string smethod_30(Encoding encoding_0, byte[] byte_0);

	static extern void smethod_31(IDisposable idisposable_0);

	static extern RegistryKey smethod_32(RegistryKey registryKey_0, string string_4, RegistryKeyPermissionCheck registryKeyPermissionCheck_0);

	static extern RegistryKey smethod_33(RegistryKey registryKey_0, string string_4);

	static extern void smethod_34(RegistryKey registryKey_0, string string_4, object object_0, RegistryValueKind registryValueKind_0);

	unsafe static object smethod_35(RegistryKey registryKey_0, string string_4)
	{
		//Discarded unreachable code: IL_000b, IL_000c, IL_0013, IL_001a, IL_001b, IL_001d
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got O
		//IL_001b: Invalid comparison between Unknown and F4
		//IL_001b: Incompatible stack heights: 1 vs 0
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		int num = *(int*)(nint)/*Error near IL_0001: Stack underflow*/;
		_003F val = /*Error near IL_0002: Stack underflow*/+ num;
		_ = /*Error near IL_0004: Stack underflow*/% val;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static extern Process smethod_36();

	static extern ProcessStartInfo smethod_37();

	static extern void smethod_38(ProcessStartInfo processStartInfo_0, string string_4);

	static extern void smethod_39(ProcessStartInfo processStartInfo_0, string string_4);

	static extern void smethod_40(ProcessStartInfo processStartInfo_0, bool bool_5);

	static extern void smethod_41(ProcessStartInfo processStartInfo_0, bool bool_5);

	static extern void smethod_42(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	unsafe static void smethod_43(ProcessStartInfo processStartInfo_0, bool bool_5)
	{
		//Discarded unreachable code: IL_0005, IL_000d, IL_001f, IL_0028, IL_0030
		//IL_0023: Invalid comparison between Unknown and I
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		_ = 0u >> (int)(&processStartInfo_0);
		/*Error near IL_0004: Unknown opcode: 0xF8*/;
	}

	static extern void smethod_44(Process process_0, ProcessStartInfo processStartInfo_0);

	unsafe static bool smethod_45(Process process_0)
	{
		//Discarded unreachable code: IL_0009, IL_0010, IL_001d, IL_001f
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0023: Expected native int or pointer, but got F4
		_003F val = /*Error: ldloc 1 (out-of-bounds)*/;
		((short[])/*Error near IL_0003: Stack underflow*/)[val] = -1;
		*(_003F*)(nint)/*Error near IL_0004: Stack underflow*/ = /*Error near IL_0004: Stack underflow*/;
		/*Error near IL_0004: Invalid metadata token*/;
	}

	static extern StreamReader smethod_46(Process process_0);

	static string smethod_47(TextReader textReader_0)
	{
		//Discarded unreachable code: IL_0006, IL_0010, IL_0017, IL_001d, IL_0024, IL_0029, IL_002f
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		_ = (ushort)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern bool smethod_48(string string_4, string string_5);

	static extern bool smethod_49(string string_4, string string_5);

	static extern bool smethod_50(StreamReader streamReader_0);

	static extern string smethod_51(string string_4);

	static extern Assembly smethod_52();

	static string smethod_53(Assembly assembly_0)
	{
		//Discarded unreachable code: IL_000a, IL_0011, IL_0017, IL_001e
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		/*Error near IL_0005: Invalid metadata token*/;
	}

	static extern string smethod_54(string string_4, string string_5);

	static extern void smethod_55(string string_4, string string_5, bool bool_5);

	static RegistryKey smethod_56(RegistryKey registryKey_0, string string_4, bool bool_5)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_000f, IL_0011
		/*Error: stloc 0 (out-of-bounds)*/;
		/*Error near IL_0004: Unknown opcode: 0xFA*/;
	}

	static extern void smethod_57(RegistryKey registryKey_0, string string_4, object object_0);

	static extern void smethod_58(string string_4, FileAttributes fileAttributes_0);

	static extern DialogResult smethod_59(string string_4, string string_5, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0);

	static void smethod_60(RegistryKey registryKey_0)
	{
		while (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/|| (int)/*Error near IL_000b: Stack underflow*/ != 0)
		{
		}
		_ = ((object[])/*Error near IL_000c: Stack underflow*/)[/*Error near IL_000c: Stack underflow*/];
		/*Error: Unexpected end of block*/;
	}

	static extern WindowsIdentity smethod_61();

	unsafe static WindowsPrincipal smethod_62(WindowsIdentity windowsIdentity_0)
	{
		//Discarded unreachable code: IL_001f, IL_0025, IL_0035, IL_003b, IL_0040
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected F8, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			while (true)
			{
				/*Error: stloc 0 (out-of-bounds)*/;
				if (/*Error near IL_0006: Stack underflow*/ <= /*Error near IL_0006: Stack underflow*/)
				{
					/*Error near IL_0007: stloc 3 (out-of-bounds)*/;
					_003F val = *unchecked((object*)(nint)/*Error near IL_000b: Stack underflow*/) - 6f;
					((double[])/*Error near IL_0013: Stack underflow*/)[/*Error near IL_0013: Stack underflow*/] = (double)val;
					_003F val2 = /*Error near IL_0014: Stack underflow*/* /*Error near IL_0014: Stack underflow*/;
					if (/*Error near IL_0019: Stack underflow*/ != val2)
					{
						break;
					}
				}
			}
			/*Error near IL_001a: Invalid metadata token*/;
		}
	}

	static bool smethod_63(WindowsPrincipal windowsPrincipal_0, WindowsBuiltInRole windowsBuiltInRole_0)
	{
		//Discarded unreachable code: IL_0018, IL_001e, IL_0023
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		while ((int)/*Error: ldloca 0 (out-of-bounds)*/ <= 8)
		{
		}
		_003F val = ~/*Error near IL_000b: Stack underflow*/;
		_003F val2 = ~(/*Error near IL_000d: Stack underflow*/ << (int)val);
		checked
		{
			sbyte num = (sbyte)/*Error near IL_000e: ldloc 0 (out-of-bounds)*/;
			_ = /*Error near IL_0012: Stack underflow*/+ unchecked(val2 - num);
			/*Error near IL_0013: Invalid metadata token*/;
		}
	}

	static extern Rectangle smethod_64(Point point_0);

	static extern Bitmap smethod_65(int int_0, int int_1);

	static extern Graphics smethod_66(Image image_0);

	static extern void smethod_67(Graphics graphics_0, Point point_0, Point point_1, Size size_0);

	unsafe static ImageFormat smethod_68()
	{
		//Discarded unreachable code: IL_0017, IL_001c, IL_002d, IL_0032
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected I4, but got Unknown
		//IL_0026: Expected O, but got F8
		while (true)
		{
			_003F val = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
			if (/*Error near IL_0008: Stack underflow*/ >= val)
			{
				_003F val2 = /*Error near IL_000a: Stack underflow*/* /*Error near IL_000a: Stack underflow*/;
				_003F val3 = val2 % val2;
				if (/*Error near IL_0011: Stack underflow*/ > val3)
				{
					break;
				}
			}
		}
		_003F val4 = /*Error near IL_0012: ldloc 1 (out-of-bounds)*/;
		_003F val5 = checked(/*Error near IL_0014: Stack underflow*/ * val4);
		*(int*)(nint)/*Error near IL_0015: Stack underflow*/ = (int)val5;
		checked
		{
			_ = (int)/*Error near IL_0016: Stack underflow*/;
			/*Error near IL_0016: Unknown opcode: 0xFF*/;
		}
	}

	static extern void smethod_69(Image image_0, string string_4, ImageFormat imageFormat_0);

	static WebClient smethod_70()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got I8
		while (true)
		{
			if ((int)/*Error near IL_0006: Stack underflow*/ != 0)
			{
				ushort num = ((ushort[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/];
				_003F val = /*Error near IL_0008: Stack underflow*/<< (int)num;
				sbyte num2 = ((sbyte[])/*Error near IL_0009: Stack underflow*/)[val];
				_003F val2 = /*Error near IL_000a: Stack underflow*/& num2;
				checked
				{
					long num3 = unchecked((nint)((IntPtr[])/*Error near IL_000b: Stack underflow*/)[val2]) * (long)unchecked((/*Error near IL_000b: ldarg 2 (out-of-bounds)*/ - /*Error near IL_000c: ldloc 2 (out-of-bounds)*/) / -6);
					long num4 = ((long[])/*Error near IL_0015: Stack underflow*/)[num3];
					ulong num5 = (ulong)unchecked(/*Error near IL_0016: Stack underflow*/ / num4);
					((object[])/*Error near IL_0018: Stack underflow*/)[/*Error near IL_0018: Stack underflow*/] = num5;
					if (/*Error near IL_001d: Stack underflow*/ <= /*Error near IL_001d: Stack underflow*/)
					{
						/*Error: Could not find block for branch target IL_001d*/;
					}
				}
			}
		}
	}

	static extern bool smethod_71(string string_4);

	static extern void smethod_72(string string_4);

	static extern void smethod_73(WebClient webClient_0, string string_4, string string_5);

	static void smethod_74(Process process_0)
	{
		while (process_0 == null)
		{
		}
	}

	unsafe static string smethod_75(string string_4)
	{
		//Discarded unreachable code: IL_0013, IL_0018, IL_002a, IL_0030, IL_003c, IL_0041
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected F4, but got I8
		//IL_0022: Expected O, but got Unknown
		//IL_0025: Incompatible stack heights: 0 vs 2
		//IL_0037: Expected I, but got Unknown
		while (/*Error near IL_0006: Stack underflow*/ >= /*Error near IL_0006: Stack underflow*/)
		{
		}
		_003F val = checked(/*Error near IL_0007: Stack underflow*/ + /*Error near IL_0007: Stack underflow*/);
		long num = /*Error near IL_0008: Stack underflow*/- val;
		((float[])/*Error near IL_000b: Stack underflow*/)[/*Error near IL_000b: Stack underflow*/] = num;
		_ = (sbyte)(*(ushort*)(nint)/*Error near IL_000d: Stack underflow*/);
		/*Error near IL_000e: Invalid metadata token*/;
	}

	static extern string[] smethod_76(string string_4, char[] char_0);

	static extern string smethod_77(WebClient webClient_0, string string_4);

	static extern string smethod_78();

	static extern string smethod_79();

	static extern string smethod_80(string[] string_4);

	static void smethod_81(int int_0)
	{
		//Discarded unreachable code: IL_0005, IL_0009, IL_000a, IL_000f
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and F4
		//IL_0009: Incompatible stack heights: 0 vs 1
		/*Error: Invalid metadata token*/;
	}

	unsafe static Process[] smethod_82()
	{
		//Discarded unreachable code: IL_0008, IL_000d, IL_0013
		//IL_0004: Expected O, but got I4
		//IL_000e: Invalid comparison between Unknown and I4
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		_ = 8;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static extern string smethod_83(Process process_0);

	static extern void smethod_84(Process process_0);

	static extern Process smethod_85();

	static extern IntPtr smethod_86(Process process_0);

	static extern ManagementObjectSearcher smethod_87(string string_4);

	static extern ManagementObjectCollection smethod_88(ManagementObjectSearcher managementObjectSearcher_0);

	static extern ManagementObjectEnumerator smethod_89(ManagementObjectCollection managementObjectCollection_0);

	static extern ManagementBaseObject smethod_90(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern object smethod_91(ManagementBaseObject managementBaseObject_0, string string_4);

	static extern string smethod_92(object object_0);

	static string smethod_93(string string_4)
	{
		//Discarded unreachable code: IL_0007, IL_000f, IL_0014, IL_0020
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0002: Stack underflow*/* /*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	static extern bool smethod_94(string string_4, string string_5);

	static extern string smethod_95(string string_4);

	static bool smethod_96(string string_4, string string_5)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		IntPtr intPtr;
		checked
		{
			sbyte num = (sbyte)unchecked((uint)((int[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/]);
			intPtr = ((IntPtr[])/*Error near IL_0003: Stack underflow*/)[num];
		}
		_ = /*Error near IL_0007: Stack underflow*/^ (nint)intPtr;
		/*Error near IL_0007: Invalid metadata token*/;
	}

	static bool smethod_97(ManagementObjectEnumerator managementObjectEnumerator_0)
	{
		//Discarded unreachable code: IL_0015
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_000a: Invalid comparison between Unknown and I4
		while (true)
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 1 (out-of-bounds)*/;
			if ((int)/*Error near IL_0008: Stack underflow*/ <= 8)
			{
				byte num = (byte)/*Error near IL_000a: Stack underflow*/;
				if ((int)/*Error near IL_000f: Stack underflow*/ >= (int)num)
				{
				}
			}
		}
	}

	static extern NetworkInterface[] smethod_98();

	static extern OperationalStatus smethod_99(NetworkInterface networkInterface_0);

	static extern PhysicalAddress smethod_100(NetworkInterface networkInterface_0);

	static extern string smethod_101(string string_4, string string_5, string string_6);

	static extern string smethod_102(string string_4, char[] char_0);

	static extern FileSystemWatcher smethod_103();

	static extern string smethod_104(Environment.SpecialFolder specialFolder_0);

	static void smethod_105(FileSystemWatcher fileSystemWatcher_1, string string_4)
	{
		//Discarded unreachable code: IL_0005, IL_000f, IL_001a, IL_0020, IL_002b, IL_0030, IL_0038
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
		}
	}

	static extern void smethod_106(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0);

	static extern void smethod_107(FileSystemWatcher fileSystemWatcher_1, string string_4);

	unsafe static void smethod_108(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0)
	{
		//Discarded unreachable code: IL_0004, IL_000d, IL_0012
		//IL_0003: Expected F4, but got I4
		/*Error: stloc 2 (out-of-bounds)*/;
		short num = *(short*)(nint)/*Error near IL_0002: Stack underflow*/;
		*(float*)(nint)/*Error near IL_0003: Stack underflow*/ = num;
		/*Error near IL_0003: Unknown opcode: 0xFB*/;
	}

	static extern void smethod_109(FileSystemWatcher fileSystemWatcher_1, bool bool_5);

	static extern bool smethod_110(string string_4, string string_5);

	static extern bool smethod_111(string string_4);

	static extern string[] smethod_112(string string_4, string string_5);

	static extern Match smethod_113(string string_4, string string_5);

	static extern WebHeaderCollection smethod_114(WebClient webClient_0);

	unsafe static void smethod_115(WebHeaderCollection webHeaderCollection_0, HttpRequestHeader httpRequestHeader_0, string string_4)
	{
		//Discarded unreachable code: IL_000d, IL_0018, IL_0024, IL_002a, IL_0032
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		object obj = *(object*)checked((nint)1.7636781E+35f);
		checked
		{
			_ = /*Error near IL_0008: Stack underflow*/- obj;
			/*Error near IL_0008: Invalid metadata token*/;
		}
	}

	static extern byte[] smethod_116(string string_4);

	static extern Encoding smethod_117();

	static extern int smethod_118(string string_4, string string_5);

	static string smethod_119(string string_4, int int_0, int int_1)
	{
		//Discarded unreachable code: IL_0007, IL_000f, IL_0015, IL_001a, IL_001d
		while (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/)
		{
		}
		((IntPtr[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/] = (IntPtr)/*Error near IL_0006: Stack underflow*/;
		/*Error near IL_0006: Unknown opcode: 0xFF*/;
	}

	static extern string smethod_120(string string_4, int int_0, string string_5);

	static void smethod_121(string string_4, byte[] byte_0)
	{
		//Discarded unreachable code: IL_0001, IL_000a, IL_000f
		/*Error: Unknown opcode: 0xFA*/;
	}
}
