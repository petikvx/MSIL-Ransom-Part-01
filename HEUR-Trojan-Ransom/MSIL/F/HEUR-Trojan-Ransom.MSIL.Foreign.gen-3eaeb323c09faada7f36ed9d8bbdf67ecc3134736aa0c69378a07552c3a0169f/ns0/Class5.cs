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

	private static extern bool smethod_4();

	private static extern bool smethod_5();

	private static extern string smethod_6();

	private static extern void smethod_7();

	private static void smethod_8(object sender, FileSystemEventArgs e)
	{
		//Discarded unreachable code: IL_000c, IL_0012, IL_0018, IL_001f, IL_0024, IL_002d, IL_0034, IL_0039
		//IL_0007: Incompatible stack heights: 0 vs 1
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_0028: Invalid comparison between Unknown and Ref
		//IL_002f: Invalid comparison between Unknown and I4
		//IL_003c: Expected native int or pointer, but got F4
		//IL_003f: Expected I4, but got O
		checked
		{
			while (true)
			{
				if (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/)
				{
					_ = (nint)/*Error near IL_0007: Stack underflow*/;
				}
			}
		}
	}

	private static extern void smethod_9();

	private static extern void smethod_10();

	public static extern bool smethod_11(string string_4);

	public Class5()
	{
		//Discarded unreachable code: IL_0002, IL_0008, IL_0012, IL_0022
		//IL_0003: Expected native int or pointer, but got F8
		//IL_000d: Invalid comparison between I4 and Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		_ = ((uint[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0001: Unknown opcode: 0xF9*/;
	}

	unsafe static string smethod_12(string string_4)
	{
		//IL_0004: Expected O, but got I4
		string_4 = (string)(-(*(byte*)(nint)/*Error near IL_0001: Stack underflow*/));
		switch (/*Error near IL_0009: Stack underflow*/)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	unsafe static WebClient smethod_13()
	{
		//Discarded unreachable code: IL_0008, IL_0013, IL_0019, IL_001e
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		_ = *(long*)(int)((uint[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0003: Invalid metadata token*/;
	}

	unsafe static string smethod_14(string string_4, string string_5)
	{
		_ = ((double[])(*(int*)(nint)/*Error near IL_0001: Stack underflow*/))[/*Error near IL_0001: ldloc 3 (out-of-bounds)*/];
		_ = 3L;
		/*Error near IL_000d: Invalid metadata token*/;
	}

	unsafe static void smethod_15(WebClient webClient_0, string string_4, string string_5)
	{
		//IL_0003: Invalid comparison between Unknown and F4
		float num;
		do
		{
			/*Error: stloc 0 (out-of-bounds)*/;
			num = *(float*)(nint)/*Error near IL_0003: Stack underflow*/;
		}
		while ((float)/*Error near IL_0008: Stack underflow*/ <= num);
		_ = -22;
		/*Error: Unexpected end of block*/;
	}

	static void smethod_16(Component component_0)
	{
		//Discarded unreachable code: IL_0002, IL_0012, IL_0018, IL_001d
		//IL_000d: Invalid comparison between I and F8
		/*Error near IL_0001: Unknown opcode: 0xFA*/;
	}

	static extern Process smethod_17();

	static extern ProcessStartInfo smethod_18();

	static extern void smethod_19(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static extern void smethod_20(ProcessStartInfo processStartInfo_0, string string_4);

	static string smethod_21(string string_4, string string_5, string string_6)
	{
		//Discarded unreachable code: IL_0005, IL_0013
		while (true)
		{
		}
	}

	unsafe static void smethod_22(ProcessStartInfo processStartInfo_0, string string_4)
	{
		//Discarded unreachable code: IL_000f
		//IL_0003: Expected native int or pointer, but got O
		do
		{
			*(short*)(nint)string_4 = -1;
			((float[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (float)/*Error near IL_0005: Stack underflow*/;
		}
		while ((int)/*Error near IL_000a: Stack underflow*/ != 0);
		/*Error near IL_000a: Invalid metadata token*/;
	}

	static void smethod_23(Process process_0, ProcessStartInfo processStartInfo_0)
	{
		//Discarded unreachable code: IL_0007
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected I4, but got Unknown
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static extern bool smethod_24(Process process_0);

	unsafe static void smethod_25(int int_0)
	{
		//Discarded unreachable code: IL_0009, IL_000e, IL_0014, IL_001a, IL_0022, IL_0027
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		while (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0006: Stack underflow*/)
		{
		}
		IntPtr intPtr = *(IntPtr*)(nint)/*Error near IL_0007: Stack underflow*/;
		checked
		{
			_ = /*Error near IL_0008: Stack underflow*/+ unchecked((nuint)(nint)intPtr);
			/*Error near IL_0008: Unknown opcode: 0xFA*/;
		}
	}

	static void smethod_26(string string_4)
	{
		//Discarded unreachable code: IL_000c, IL_0016, IL_0020
		//IL_0007: Incompatible stack heights: 0 vs 2
		//IL_0011: Invalid comparison between Unknown and I4
		//IL_001b: Invalid comparison between Unknown and I4
		while (true)
		{
			/*Error: ldloca 0 (out-of-bounds)*/;
			_ = 0f;
		}
	}

	static extern string smethod_27(string string_4);

	static byte[] smethod_28(string string_4)
	{
		//Discarded unreachable code: IL_0008
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected I4, but got Unknown
		checked
		{
			_ = (byte)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	static extern RijndaelManaged smethod_29();

	static void smethod_30(SymmetricAlgorithm symmetricAlgorithm_0, int int_0)
	{
		//Discarded unreachable code: IL_0005, IL_000c, IL_0012, IL_0019, IL_0021, IL_0027
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static void smethod_31(SymmetricAlgorithm symmetricAlgorithm_0, int int_0)
	{
		//Discarded unreachable code: IL_0005, IL_000d, IL_0013, IL_0016
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static Encoding smethod_32()
	{
		//Discarded unreachable code: IL_0005
		/*Error: Invalid metadata token*/;
	}

	static byte[] smethod_33(Encoding encoding_0, string string_4)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_0011
		//IL_000c: Incompatible stack heights: 0 vs 1
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_34(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_35(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static void smethod_36(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0)
	{
		checked
		{
			_ = (nuint)/*Error near IL_0001: Stack underflow*/;
			_ = 20.177496f;
			/*Error: Unexpected end of block*/;
		}
	}

	static extern void smethod_37(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static extern byte[] smethod_38(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern byte[] smethod_39(SymmetricAlgorithm symmetricAlgorithm_0);

	unsafe static ICryptoTransform smethod_40(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1)
	{
		//Discarded unreachable code: IL_0013, IL_0024, IL_002d, IL_0035
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected I4, but got Unknown
		int num;
		do
		{
			num = *(int*)(nint)/*Error near IL_0001: Stack underflow*/;
		}
		while ((int)/*Error near IL_0007: Stack underflow*/ < num);
		_ = (short)checked((nuint)/*Error near IL_0008: Stack underflow*/);
		_ = -3115093184935355497L;
		/*Error near IL_0012: Unknown opcode: 0xFB*/;
	}

	static byte[] smethod_41(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			nuint num = (nuint)((uint[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			_ = (uint)(/*Error near IL_0003: Stack underflow*/ * num);
			/*Error near IL_0004: Invalid metadata token*/;
		}
	}

	static Encoding smethod_42()
	{
		//IL_0009: Invalid comparison between Unknown and I4
		while (true)
		{
			((IntPtr[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (IntPtr)/*Error near IL_0002: Stack underflow*/;
			int num = checked((int)/*Error near IL_0006: Stack underflow*/);
			if ((int)/*Error near IL_000e: Stack underflow*/ != num)
			{
				/*Error: Could not find block for branch target IL_000e*/;
			}
		}
	}

	static extern string smethod_43(Encoding encoding_0, byte[] byte_0);

	static extern void smethod_44(IDisposable idisposable_0);

	static extern Assembly smethod_45();

	static extern string smethod_46(Assembly assembly_0);

	static extern void smethod_47(string string_4, string string_5, bool bool_5);

	static extern RegistryKey smethod_48(RegistryKey registryKey_0, string string_4, bool bool_5);

	static extern void smethod_49(RegistryKey registryKey_0, string string_4, object object_0);

	static extern void smethod_50(string string_4, FileAttributes fileAttributes_0);

	static extern RegistryKey smethod_51(RegistryKey registryKey_0, string string_4);

	static extern void smethod_52(RegistryKey registryKey_0);

	static extern Rectangle smethod_53(Point point_0);

	static Bitmap smethod_54(int int_0, int int_1)
	{
		//Discarded unreachable code: IL_000e, IL_0013, IL_001b
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		//IL_001e: Expected F8, but got I4
		_ = (nuint)/*Error near IL_0001: Stack underflow*/;
		_ = ((short[])(object)"")[int_1];
		/*Error near IL_0009: Invalid metadata token*/;
	}

	static extern Graphics smethod_55(Image image_0);

	unsafe static void smethod_56(Graphics graphics_0, Point point_0, Point point_1, Size size_0)
	{
		//IL_000a: Expected I, but got I8
		while (true)
		{
			*(IntPtr*)(nint)/*Error near IL_000a: Stack underflow*/ = unchecked((nint)1653399609794243800L);
			sbyte num = *(sbyte*)(nint)/*Error near IL_000c: Stack underflow*/;
			((IntPtr[])/*Error near IL_000e: Stack underflow*/)[/*Error near IL_000e: Stack underflow*/] = (nint)num;
			int num2 = (int)/*Error near IL_0010: Stack underflow*/;
			*(IntPtr*)(nint)/*Error near IL_0011: Stack underflow*/ = (IntPtr)num2;
			if (/*Error near IL_0018: Stack underflow*/ >= /*Error near IL_0018: Stack underflow*/&& /*Error near IL_001d: Stack underflow*/> /*Error near IL_001d: Stack underflow*/)
			{
				/*Error: Could not find block for branch target IL_001d*/;
			}
		}
	}

	static extern ImageFormat smethod_57();

	static extern void smethod_58(Image image_0, string string_4, ImageFormat imageFormat_0);

	static extern bool smethod_59(string string_4);

	unsafe static void smethod_60(Process process_0)
	{
		//Discarded unreachable code: IL_0008
		_ = *(object*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static extern string[] smethod_61(string string_4, char[] char_0);

	static extern string smethod_62(WebClient webClient_0, string string_4);

	static extern string smethod_63();

	static string smethod_64()
	{
		//Discarded unreachable code: IL_0003, IL_0008
		/*Error near IL_0002: Unknown opcode: 0xFB*/;
	}

	static extern string smethod_65(string[] string_4);

	static extern void smethod_66(string string_4, string string_5);

	static extern Process[] smethod_67();

	static extern string smethod_68(Process process_0);

	static extern void smethod_69(Process process_0);

	static extern Process smethod_70();

	static extern IntPtr smethod_71(Process process_0);

	static ManagementObjectSearcher smethod_72(string string_4)
	{
		//Discarded unreachable code: IL_0005, IL_0007, IL_000a, IL_0011, IL_0016, IL_0017
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected I8, but got Unknown
		while (true)
		{
		}
	}

	static extern ManagementObjectCollection smethod_73(ManagementObjectSearcher managementObjectSearcher_0);

	static ManagementObjectEnumerator smethod_74(ManagementObjectCollection managementObjectCollection_0)
	{
		//Discarded unreachable code: IL_0009, IL_0012, IL_0018, IL_001d
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected I8, but got Unknown
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_001d: Incompatible stack heights: 1 vs 0
		managementObjectCollection_0 = (ManagementObjectCollection)/*Error near IL_0002: Stack underflow*/;
		checked
		{
			_ = /*Error near IL_0003: Stack underflow*/+ /*Error near IL_0003: Stack underflow*/;
			/*Error near IL_0004: Invalid metadata token*/;
		}
	}

	static extern ManagementBaseObject smethod_75(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern object smethod_76(ManagementBaseObject managementBaseObject_0, string string_4);

	static extern string smethod_77(object object_0);

	static extern string smethod_78(string string_4);

	static extern bool smethod_79(string string_4, string string_5);

	unsafe static string smethod_80(string string_4)
	{
		//Discarded unreachable code: IL_0006, IL_000e, IL_0014, IL_001b, IL_0022, IL_0027, IL_002d, IL_0032
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected I4, but got I8
		_ = *(byte*)(int)checked((ushort)unchecked((int)((uint[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/]));
		/*Error near IL_0004: ldarg 2 (out-of-bounds)*/;
		/*Error near IL_0005: Unknown opcode: 0xFA*/;
	}

	static extern bool smethod_81(string string_4, string string_5);

	static extern bool smethod_82(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern NetworkInterface[] smethod_83();

	static extern OperationalStatus smethod_84(NetworkInterface networkInterface_0);

	static extern PhysicalAddress smethod_85(NetworkInterface networkInterface_0);

	static extern string smethod_86(string string_4, char[] char_0);

	unsafe static FileSystemWatcher smethod_87()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected F4, but got Unknown
		while (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/)
		{
		}
		_003F val = checked(/*Error near IL_0006: Stack underflow*/ - /*Error near IL_0006: Stack underflow*/);
		*(float*)(nint)/*Error near IL_0007: Stack underflow*/ = (float)val;
		/*Error near IL_0008: Invalid metadata token*/;
	}

	static extern string smethod_88(Environment.SpecialFolder specialFolder_0);

	static extern void smethod_89(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static extern void smethod_90(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0);

	static void smethod_91(FileSystemWatcher fileSystemWatcher_1, string string_4)
	{
		//Discarded unreachable code: IL_0006, IL_000b
		while (true)
		{
		}
	}

	static void smethod_92(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0)
	{
		//Discarded unreachable code: IL_0003, IL_0008, IL_0012, IL_0017
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		((sbyte[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = 6;
		/*Error near IL_0002: Unknown opcode: 0xFC*/;
	}

	unsafe static void smethod_93(FileSystemWatcher fileSystemWatcher_1, bool bool_5)
	{
		//Discarded unreachable code: IL_000a, IL_000f, IL_0018
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected I8, but got I4
		//IL_0026: Invalid comparison between Unknown and I4
		float num = ((float[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/];
		_ = *(long*)checked((short)(/*Error near IL_0003: Stack underflow*/ ^ num));
		/*Error near IL_0005: Invalid metadata token*/;
	}

	static extern bool smethod_94(string string_4, string string_5);

	static extern bool smethod_95(string string_4);

	static extern string[] smethod_96(string string_4, string string_5);

	static Match smethod_97(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0010
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got I4
		//IL_0013: Expected O, but got I
		((long[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (long)/*Error near IL_0001: Stack underflow*/;
		_003F val = /*Error near IL_0007: Stack underflow*/% -1807136422;
		((object[])/*Error near IL_000a: Stack underflow*/)[val] = 8;
		checked
		{
			_ = (uint)/*Error near IL_000b: Stack underflow*/;
			/*Error near IL_000b: Invalid metadata token*/;
		}
	}

	static extern WebHeaderCollection smethod_98(WebClient webClient_0);

	static void smethod_99(WebHeaderCollection webHeaderCollection_0, HttpRequestHeader httpRequestHeader_0, string string_4)
	{
		/*Error: Invalid metadata token*/;
	}
}
