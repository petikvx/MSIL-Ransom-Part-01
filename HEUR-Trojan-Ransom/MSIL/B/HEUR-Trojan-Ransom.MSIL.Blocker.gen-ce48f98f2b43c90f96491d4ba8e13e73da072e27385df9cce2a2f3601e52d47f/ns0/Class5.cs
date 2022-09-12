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

	private static extern void smethod_2();

	private static extern void smethod_3(string string_4, string string_5);

	private static extern void Main();

	private static extern void smethod_4();

	private static bool smethod_5()
	{
		_ = ((uint[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/];
		_ = 8;
		/*Error: Unexpected end of block*/;
	}

	private static extern bool smethod_6();

	private static extern bool smethod_7();

	private static extern string smethod_8();

	private static extern void smethod_9();

	private static extern void smethod_10(object sender, FileSystemEventArgs e);

	private static extern void smethod_11();

	private static extern void smethod_12();

	public static extern bool smethod_13(string string_4);

	public extern Class5();

	static Class5()
	{
		//Discarded unreachable code: IL_0007, IL_000f
		_ = 6;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static extern string smethod_14(string string_4);

	static extern WebClient smethod_15();

	static string smethod_16(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0001, IL_000a, IL_0012, IL_0017, IL_001c
		//IL_0022: Expected I4, but got O
		/*Error: Unknown opcode: 0xFC*/;
	}

	static extern void smethod_17(WebClient webClient_0, string string_4, string string_5);

	static void smethod_18(Component component_0)
	{
		//Discarded unreachable code: IL_0006
		while (true)
		{
		}
	}

	static extern Process smethod_19();

	unsafe static ProcessStartInfo smethod_20()
	{
		//Discarded unreachable code: IL_0015
		//IL_0002: Expected I8, but got I4
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got I
		double num;
		do
		{
			*(long*)(nint)/*Error near IL_0002: Stack underflow*/ = 8L;
			object obj = *(object*)(nint)/*Error near IL_0004: Stack underflow*/;
			num = ((double[])/*Error near IL_0005: Stack underflow*/)[obj];
		}
		while (checked((short)(/*Error near IL_0007: Stack underflow*/ << unchecked((int)num))) >= unchecked((nint)""));
		IntPtr intPtr = ((IntPtr[])/*Error near IL_0013: Stack underflow*/)[/*Error near IL_0013: Stack underflow*/];
		((object[])/*Error near IL_0014: Stack underflow*/)[/*Error near IL_0014: Stack underflow*/] = (nint)intPtr;
		/*Error near IL_0014: Unknown opcode: 0xF9*/;
	}

	static void smethod_21(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0)
	{
		//Discarded unreachable code: IL_0007, IL_0011, IL_0028
		//IL_000c: Expected O, but got F4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got I4
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static extern void smethod_22(ProcessStartInfo processStartInfo_0, string string_4);

	unsafe static string smethod_23(string string_4, string string_5, string string_6)
	{
		//IL_0004: Expected native int or pointer, but got O
		//IL_0007: Expected O, but got I4
		string_4 = (string)(*(sbyte*)(nint)string_6);
		_ = (short)/*Error near IL_0008: Stack underflow*/;
		/*Error near IL_0009: Invalid metadata token*/;
	}

	static extern void smethod_24(ProcessStartInfo processStartInfo_0, string string_4);

	static extern void smethod_25(Process process_0, ProcessStartInfo processStartInfo_0);

	static extern bool smethod_26(Process process_0);

	static extern void smethod_27(int int_0);

	static extern void smethod_28(string string_4);

	static extern string smethod_29(string string_4);

	static extern byte[] smethod_30(string string_4);

	static extern RijndaelManaged smethod_31();

	static extern void smethod_32(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern void smethod_33(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static Encoding smethod_34()
	{
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
			{
				/*Error: Could not find block for branch target IL_0005*/;
			}
		}
	}

	static byte[] smethod_35(Encoding encoding_0, string string_4)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		checked
		{
			while (true)
			{
				_003F val = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
				if (/*Error near IL_0002: Stack underflow*/ * val != 3)
				{
					/*Error: Could not find block for branch target IL_0009*/;
				}
			}
		}
	}

	static extern void smethod_36(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static void smethod_37(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_000b, IL_0011, IL_0017, IL_001e, IL_0025, IL_0038
		//IL_0033: Invalid comparison between Unknown and I4
		while (true)
		{
			if (checked((long)/*Error near IL_0001: Stack underflow*/) == 0L)
			{
			}
		}
	}

	static extern void smethod_38(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	static extern void smethod_39(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static byte[] smethod_40(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		while (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
		}
		switch (/*Error near IL_000c: Stack underflow*/)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static byte[] smethod_41(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_0014
		while (true)
		{
		}
	}

	static extern ICryptoTransform smethod_42(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static extern byte[] smethod_43(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static extern Encoding smethod_44();

	unsafe static string smethod_45(Encoding encoding_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_0012, IL_001d, IL_0023, IL_002c
		//IL_000d: Expected F4, but got Unknown
		//IL_0018: Incompatible stack heights: 0 vs 1
		do
		{
			_ = 6;
			/*Error near IL_0001: stloc 2 (out-of-bounds)*/;
		}
		while (/*Error near IL_0007: Stack underflow*/ >= /*Error near IL_0007: Stack underflow*/);
		_003F val = /*Error near IL_0007: ldloca 0 (out-of-bounds)*/;
		*(float*)(nint)/*Error near IL_000d: Stack underflow*/ = (float)val;
		/*Error near IL_000d: Invalid metadata token*/;
	}

	unsafe static void smethod_46(IDisposable idisposable_0)
	{
		//Discarded unreachable code: IL_000f
		//IL_0004: Incompatible stack heights: 0 vs 1
		do
		{
			_ = *(long*)(nint)/*Error near IL_0001: Stack underflow*/;
		}
		while ((nint)(&idisposable_0) < (nint)5);
		_ = *(int*)(nint)/*Error near IL_000a: Stack underflow*/;
		/*Error near IL_000a: Invalid metadata token*/;
	}

	static extern Assembly smethod_47();

	static extern Stream smethod_48(Assembly assembly_0, string string_4);

	static extern FileStream smethod_49(string string_4, FileMode fileMode_0, FileAccess fileAccess_0);

	static extern void smethod_50(Stream stream_0, Stream stream_1);

	static Process smethod_51(string string_4)
	{
		//Discarded unreachable code: IL_0006, IL_000c
		((IntPtr[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (IntPtr)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static string smethod_52(Assembly assembly_0)
	{
		//Discarded unreachable code: IL_0007, IL_0008, IL_000f
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_000d: Incompatible stack heights: 1 vs 0
		_ = 6;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static extern void smethod_53(string string_4, string string_5, bool bool_5);

	static extern RegistryKey smethod_54(RegistryKey registryKey_0, string string_4, bool bool_5);

	static void smethod_55(RegistryKey registryKey_0, string string_4, object object_0)
	{
		switch (/*Error near IL_0006: Stack underflow*/)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static void smethod_56(string string_4, FileAttributes fileAttributes_0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		_ = ((float[])checked((short)(/*Error near IL_0004: Stack underflow*/ * string_4)))[3];
		_ = 59L;
		/*Error: Unexpected end of block*/;
	}

	static extern DialogResult smethod_57(string string_4, string string_5, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0);

	static extern Assembly smethod_58();

	static extern string smethod_59(string string_4);

	static extern bool smethod_60(string string_4, string string_5);

	static extern Rectangle smethod_61(Point point_0);

	static extern Bitmap smethod_62(int int_0, int int_1);

	static extern Graphics smethod_63(Image image_0);

	static extern void smethod_64(Graphics graphics_0, Point point_0, Point point_1, Size size_0);

	static extern ImageFormat smethod_65();

	static void smethod_66(Image image_0, string string_4, ImageFormat imageFormat_0)
	{
		//Discarded unreachable code: IL_0002, IL_0007, IL_000d, IL_0017, IL_0024
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I
		//IL_001f: Expected O, but got I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xFF*/;
	}

	static bool smethod_67(string string_4)
	{
		//Discarded unreachable code: IL_000d, IL_001b, IL_001e, IL_001f, IL_0024, IL_0029, IL_0035, IL_003b
		//IL_0001: Invalid comparison between Unknown and I
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Incompatible stack heights: 0 vs 1
		IntPtr intPtr;
		do
		{
			intPtr = (nint)((Array)/*Error near IL_0001: Stack underflow*/).LongLength;
		}
		while ((nint)/*Error near IL_0006: Stack underflow*/ <= (nint)intPtr);
		_ = /*Error near IL_0008: Stack underflow*/* /*Error near IL_0008: Stack underflow*/;
		/*Error near IL_0008: Invalid metadata token*/;
	}

	static extern void smethod_68(Process process_0);

	static extern string[] smethod_69(string string_4, char[] char_0);

	static extern string smethod_70(WebClient webClient_0, string string_4);

	static extern string smethod_71();

	static extern string smethod_72();

	unsafe static string smethod_73(string[] string_4)
	{
		//Discarded unreachable code: IL_0012, IL_001d
		//IL_0017: Expected native int or pointer, but got F4
		nint num = (nint)((Array)/*Error near IL_0001: Stack underflow*/).LongLength;
		/*Error near IL_0001: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0003: stloc 0 (out-of-bounds)*/;
		_ = num >> (int)/*Error near IL_0004: ldloca 0 (out-of-bounds)*/;
		/*Error near IL_0007: stloc 3 (out-of-bounds)*/;
		*(_003F*)(nint)/*Error near IL_0009: Stack underflow*/ = /*Error near IL_0009: Stack underflow*/;
		checked
		{
			_ = (sbyte)/*Error near IL_000d: Stack underflow*/;
			/*Error near IL_000d: Invalid metadata token*/;
		}
	}

	static extern void smethod_74(string string_4, string string_5);

	static extern Process[] smethod_75();

	static extern string smethod_76(Process process_0);

	static extern void smethod_77(Process process_0);

	unsafe static Process smethod_78()
	{
		//IL_0008: Invalid comparison between Unknown and I8
		long num;
		do
		{
			_ = null;
			/*Error near IL_0002: stloc 1 (out-of-bounds)*/;
			num = *(long*)(nint)/*Error near IL_0005: ldloca 0 (out-of-bounds)*/;
		}
		while ((long)/*Error near IL_000d: Stack underflow*/ != num || /*Error near IL_0012: Stack underflow*/== /*Error near IL_0012: Stack underflow*/|| /*Error near IL_0019: Stack underflow*/< /*Error near IL_0019: Stack underflow*/);
		_ = ((float[])/*Error near IL_0020: Stack underflow*/)[-1168820494];
		/*Error near IL_0020: Invalid metadata token*/;
	}

	unsafe static IntPtr smethod_79(Process process_0)
	{
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		ulong num = checked((ulong)/*Error near IL_0002: Stack underflow*/);
		_ = ((float[])/*Error near IL_0003: Stack underflow*/)[num];
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static extern ManagementObjectSearcher smethod_80(string string_4);

	static extern ManagementObjectCollection smethod_81(ManagementObjectSearcher managementObjectSearcher_0);

	static ManagementObjectEnumerator smethod_82(ManagementObjectCollection managementObjectCollection_0)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_0013
		//IL_000f: Expected O, but got I4
		while (true)
		{
		}
	}

	static extern ManagementBaseObject smethod_83(ManagementObjectEnumerator managementObjectEnumerator_0);

	unsafe static object smethod_84(ManagementBaseObject managementBaseObject_0, string string_4)
	{
		//Discarded unreachable code: IL_000c
		//IL_0002: Invalid comparison between Unknown and I4
		while ((int)/*Error near IL_0007: Stack underflow*/ <= 0)
		{
		}
		_ = ((IntPtr[])checked((nint)/*Error near IL_0008: Stack underflow*/))[ref *(_003F*)(&managementBaseObject_0)];
		/*Error near IL_000b: Unknown opcode: 0xFF*/;
	}

	static extern string smethod_85(object object_0);

	static extern string smethod_86(string string_4);

	static extern bool smethod_87(string string_4, string string_5);

	static extern string smethod_88(string string_4);

	static extern bool smethod_89(string string_4, string string_5);

	static bool smethod_90(ManagementObjectEnumerator managementObjectEnumerator_0)
	{
		//Discarded unreachable code: IL_0008, IL_000d, IL_0013, IL_0020
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		byte num = checked((byte)/*Error near IL_0001: Stack underflow*/);
		_ = /*Error near IL_0002: Stack underflow*/^ num;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static NetworkInterface[] smethod_91()
	{
		//Discarded unreachable code: IL_0009, IL_0017, IL_0024, IL_002a, IL_0030, IL_0036, IL_003b, IL_0040
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		/*Error near IL_0001: stloc 0 (out-of-bounds)*/;
		_ = ((IntPtr[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/];
		/*Error near IL_0004: Invalid metadata token*/;
	}

	static extern OperationalStatus smethod_92(NetworkInterface networkInterface_0);

	static PhysicalAddress smethod_93(NetworkInterface networkInterface_0)
	{
		switch (/*Error near IL_0006: Stack underflow*/)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static extern string smethod_94(string string_4, char[] char_0);

	static extern FileSystemWatcher smethod_95();

	unsafe static string smethod_96(Environment.SpecialFolder specialFolder_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected O, but got Unknown
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			short num = checked((short)/*Error near IL_0001: Stack underflow*/);
			_003F val = /*Error near IL_0002: Stack underflow*// num;
			*(_003F*)(nint)/*Error near IL_0003: Stack underflow*/ = val;
		}
		while (/*Error near IL_0008: Stack underflow*/ >= /*Error near IL_0008: Stack underflow*/);
		_003F val2 = /*Error near IL_0008: ldarg 2 (out-of-bounds)*/;
		checked
		{
			_ = /*Error near IL_000a: Stack underflow*/* val2;
			/*Error near IL_000a: Invalid metadata token*/;
		}
	}

	static void smethod_97(FileSystemWatcher fileSystemWatcher_1, string string_4)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (ulong)(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		}
	}

	static extern void smethod_98(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0);

	static extern void smethod_99(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static void smethod_100(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0)
	{
		//Discarded unreachable code: IL_0007
		//IL_0003: Expected O, but got I4
		//IL_000b: Invalid comparison between Unknown and I4
		((double[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (double)/*Error near IL_0001: Stack underflow*/;
		_ = 5;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static extern void smethod_101(FileSystemWatcher fileSystemWatcher_1, bool bool_5);

	static extern bool smethod_102(string string_4);

	static extern string[] smethod_103(string string_4, string string_5);

	static extern Match smethod_104(string string_4, string string_5);

	static extern WebHeaderCollection smethod_105(WebClient webClient_0);

	static void smethod_106(WebHeaderCollection webHeaderCollection_0, HttpRequestHeader httpRequestHeader_0, string string_4)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected O, but got Unknown
		ushort num = checked((ushort)/*Error near IL_0001: Stack underflow*/);
		_ = /*Error near IL_0002: Stack underflow*/% num;
		/*Error near IL_0002: Invalid metadata token*/;
	}
}
