using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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

	public static string string_2;

	public static string string_3;

	private static FileSystemWatcher fileSystemWatcher_0;

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_5);

	public static extern string smethod_0(string string_4);

	private static extern string smethod_1();

	private static extern void Main();

	private static extern bool smethod_2();

	private unsafe static string smethod_3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		//IL_0015: Invalid comparison between Unknown and I4
		while (true)
		{
			if ((nint)checked((nuint)unchecked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/)) > (long)/*Error near IL_0003: ldloc 1 (out-of-bounds)*/)
			{
				continue;
			}
			*(_003F*)(nint)/*Error near IL_000c: Stack underflow*/ = /*Error near IL_000c: Stack underflow*/;
			if ((int)/*Error near IL_0014: Stack underflow*/ != 32)
			{
				byte num = *(byte*)(nint)/*Error near IL_0015: Stack underflow*/;
				if ((int)/*Error near IL_001a: Stack underflow*/ > (int)num)
				{
					/*Error: Could not find block for branch target IL_001a*/;
				}
			}
		}
	}

	private static extern void smethod_4();

	private static extern void smethod_5(object sender, FileSystemEventArgs e);

	private static extern void smethod_6();

	private unsafe static void smethod_7()
	{
		//Discarded unreachable code: IL_0033, IL_0037, IL_003d, IL_0040
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected I4, but got Unknown
		//IL_0035: Invalid comparison between Unknown and I4
		//IL_0038: Invalid comparison between Unknown and I4
		//IL_003f: Incompatible stack heights: 0 vs 1
		while (true)
		{
			if ((uint)(*(float*)(int)(ushort)(*(short*)(nint)/*Error near IL_0001: Stack underflow*/)) == 0)
			{
				continue;
			}
			long num = *(long*)(int)(ushort)/*Error near IL_000e: Stack underflow*/;
			short num2 = ((short[])/*Error near IL_0010: Stack underflow*/)[num];
			ulong num3;
			checked
			{
				num3 = (byte)(/*Error near IL_0011: Stack underflow*/ << unchecked((int)num2));
			}
			*(_003F*)(nint)(/*Error near IL_0017: Stack underflow*/ | num3) = /*Error near IL_0017: ldloc 0 (out-of-bounds)*/;
			if (/*Error near IL_0020: Stack underflow*/ <= /*Error near IL_0020: Stack underflow*/)
			{
				_003F val = /*Error near IL_0023: Stack underflow*// /*Error near IL_0023: Stack underflow*/;
				((sbyte[])/*Error near IL_0024: Stack underflow*/)[/*Error near IL_0024: Stack underflow*/] = (sbyte)(int)val;
				_003F val2 = /*Error near IL_0024: ldarga 0 (out-of-bounds)*/;
				if (/*Error near IL_002b: Stack underflow*/ == val2)
				{
					break;
				}
			}
		}
		_ = *(short*)(nint)/*Error near IL_002c: Stack underflow*/;
		/*Error near IL_002c: ldarg 3 (out-of-bounds)*/;
		_ = null;
		/*Error near IL_002e: Invalid metadata token*/;
	}

	public static extern bool smethod_8(string string_4);

	public extern Class5();

	static extern byte[] smethod_9(string string_4);

	static extern RijndaelManaged smethod_10();

	unsafe static void smethod_11(SymmetricAlgorithm symmetricAlgorithm_0, int int_0)
	{
		//Discarded unreachable code: IL_001a, IL_0029, IL_0031, IL_0038, IL_003d
		//IL_0003: Expected O, but got I
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and F8
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got I4
		//IL_0024: Invalid comparison between Unknown and F8
		//IL_0033: Invalid comparison between Unknown and F8
		while (true)
		{
			nint num = (nint)3;
			((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = num;
			_003F val = checked(/*Error near IL_0005: Stack underflow*/ - /*Error near IL_0005: Stack underflow*/);
			if (!((double)/*Error near IL_000c: Stack underflow*/ <= (double)val))
			{
				*(_003F*)(nint)/*Error near IL_000d: Stack underflow*/ = /*Error near IL_000d: Stack underflow*/;
				if (/*Error near IL_0012: Stack underflow*/ >= /*Error near IL_0012: Stack underflow*/)
				{
					break;
				}
			}
		}
		_ = (uint)(*(object*)(nint)(/*Error near IL_0013: Stack underflow*/ << (int)/*Error near IL_0013: Stack underflow*/));
		/*Error near IL_0015: Invalid metadata token*/;
	}

	static extern void smethod_12(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static Encoding smethod_13()
	{
		//Discarded unreachable code: IL_000c, IL_0011, IL_0018, IL_001d, IL_0023, IL_0029, IL_002a, IL_0031
		//IL_0002: Invalid comparison between Unknown and F8
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		double num;
		do
		{
			num = (double)/*Error near IL_0001: Stack underflow*/;
		}
		while ((double)/*Error near IL_0007: Stack underflow*/ >= num);
		/*Error near IL_0007: Invalid metadata token*/;
	}

	static extern byte[] smethod_14(Encoding encoding_0, string string_4);

	static extern void smethod_15(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_16(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_17(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	static extern void smethod_18(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static extern byte[] smethod_19(SymmetricAlgorithm symmetricAlgorithm_0);

	unsafe static byte[] smethod_20(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		//IL_0002: Expected F4, but got Unknown
		_003F val = /*Error: ldloc 1 (out-of-bounds)*/;
		*(float*)(nint)/*Error near IL_0002: Stack underflow*/ = (float)val;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static extern ICryptoTransform smethod_21(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static extern byte[] smethod_22(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static extern Encoding smethod_23();

	static extern string smethod_24(Encoding encoding_0, byte[] byte_0);

	static extern void smethod_25(IDisposable idisposable_0);

	static extern string smethod_26(string string_4);

	unsafe static WebClient smethod_27()
	{
		//IL_0004: Expected F8, but got I
		ulong num = checked((ulong)/*Error near IL_0002: Stack underflow*/);
		*(double*)(nint)/*Error near IL_0004: Stack underflow*/ = (nint)num;
		/*Error near IL_0006: ldarga 0 (out-of-bounds)*/;
		_ = 52;
		/*Error near IL_000a: stloc 3 (out-of-bounds)*/;
		/*Error near IL_000b: ldloc 1 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static extern string smethod_28(string string_4, string string_5);

	static extern void smethod_29(WebClient webClient_0, string string_4, string string_5);

	static void smethod_30(Component component_0)
	{
		while ((int)/*Error near IL_0005: Stack underflow*/ == 0 || /*Error near IL_000c: Stack underflow*/<= /*Error near IL_000c: Stack underflow*/)
		{
		}
		sbyte num = (sbyte)/*Error near IL_000d: Stack underflow*/;
		((int[])/*Error near IL_000e: Stack underflow*/)[/*Error near IL_000e: Stack underflow*/] = num;
		((double[])/*Error near IL_0012: Stack underflow*/)[/*Error near IL_0012: Stack underflow*/] = (double)/*Error near IL_0012: Stack underflow*/;
		/*Error near IL_0012: stloc 2 (out-of-bounds)*/;
		((double[])/*Error near IL_0015: Stack underflow*/)[/*Error near IL_0015: Stack underflow*/] = (double)/*Error near IL_0015: Stack underflow*/;
		throw /*Error near IL_0016: Stack underflow*/;
	}

	static extern Process smethod_31();

	static extern ProcessStartInfo smethod_32();

	static extern void smethod_33(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static extern void smethod_34(ProcessStartInfo processStartInfo_0, string string_4);

	static extern string smethod_35(string string_4, string string_5, string string_6);

	static extern void smethod_36(ProcessStartInfo processStartInfo_0, string string_4);

	static extern void smethod_37(Process process_0, ProcessStartInfo processStartInfo_0);

	static extern bool smethod_38(Process process_0);

	static extern void smethod_39(int int_0);

	static extern void smethod_40(string string_4);

	static string smethod_41(string string_4)
	{
		//Discarded unreachable code: IL_0005, IL_000e
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		/*Error: Invalid metadata token*/;
	}

	static extern Assembly smethod_42();

	static extern string smethod_43(Assembly assembly_0);

	static extern void smethod_44(string string_4, string string_5, bool bool_5);

	unsafe static RegistryKey smethod_45(RegistryKey registryKey_0, string string_4, bool bool_5)
	{
		//Discarded unreachable code: IL_000f, IL_001f, IL_0026, IL_002e
		//IL_000a: Incompatible stack heights: 0 vs 1
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got I4
		while (true)
		{
			*(_003F*)(nint)/*Error near IL_0002: Stack underflow*/ = /*Error near IL_0002: Stack underflow*/;
			checked
			{
				if (/*Error near IL_0009: Stack underflow*/ > /*Error near IL_0009: Stack underflow*/)
				{
					_ = (ulong)/*Error near IL_000a: Stack underflow*/;
				}
			}
		}
	}

	static extern void smethod_46(RegistryKey registryKey_0, string string_4, object object_0);

	static extern void smethod_47(string string_4, FileAttributes fileAttributes_0);

	static extern DialogResult smethod_48(string string_4, string string_5, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0);

	static extern Rectangle smethod_49(Point point_0);

	static extern Bitmap smethod_50(int int_0, int int_1);

	unsafe static Graphics smethod_51(Image image_0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected I4, but got Unknown
		while (/*Error near IL_0007: Stack underflow*/ > /*Error near IL_0007: Stack underflow*/)
		{
		}
		_003F val = ~/*Error near IL_0008: Stack underflow*/;
		*(sbyte*)(nint)/*Error near IL_000a: Stack underflow*/ = (sbyte)(int)val;
		_ = *(int*)(nint)/*Error near IL_000b: Stack underflow*/;
		/*Error: Unexpected end of block*/;
	}

	static extern void smethod_52(Graphics graphics_0, Point point_0, Point point_1, Size size_0);

	static extern ImageFormat smethod_53();

	static extern void smethod_54(Image image_0, string string_4, ImageFormat imageFormat_0);

	static extern bool smethod_55(string string_4);

	static extern void smethod_56(Process process_0);

	static string[] smethod_57(string string_4, char[] char_0)
	{
		//IL_0002: Expected O, but got I4
		return (string[])1;
	}

	static extern string smethod_58(WebClient webClient_0, string string_4);

	static extern string smethod_59();

	unsafe static string smethod_60(string[] string_4)
	{
		//Discarded unreachable code: IL_000d
		while (true)
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			((IntPtr[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (IntPtr)(-448828379);
		}
	}

	static extern void smethod_61(string string_4, string string_5);

	static extern Process smethod_62();

	static extern IntPtr smethod_63(Process process_0);

	static extern NetworkInterface[] smethod_64();

	static extern OperationalStatus smethod_65(NetworkInterface networkInterface_0);

	static extern PhysicalAddress smethod_66(NetworkInterface networkInterface_0);

	static extern string smethod_67(object object_0);

	static extern string smethod_68(string string_4, char[] char_0);

	static extern FileSystemWatcher smethod_69();

	static extern string smethod_70(Environment.SpecialFolder specialFolder_0);

	static extern void smethod_71(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static void smethod_72(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0)
	{
		//Discarded unreachable code: IL_0005, IL_000b, IL_0012, IL_0013, IL_0018
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected I4, but got Unknown
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_73(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static extern void smethod_74(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0);

	static extern void smethod_75(FileSystemWatcher fileSystemWatcher_1, bool bool_5);

	static extern bool smethod_76(string string_4, string string_5);

	static extern bool smethod_77(string string_4);

	static extern string[] smethod_78(string string_4, string string_5);

	static bool smethod_79(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0009, IL_0010, IL_0015
		//IL_000b: Invalid comparison between Unknown and F8
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
		}
	}

	static extern Match smethod_80(string string_4, string string_5);

	static extern WebHeaderCollection smethod_81(WebClient webClient_0);

	static extern void smethod_82(WebHeaderCollection webHeaderCollection_0, HttpRequestHeader httpRequestHeader_0, string string_4);
}
