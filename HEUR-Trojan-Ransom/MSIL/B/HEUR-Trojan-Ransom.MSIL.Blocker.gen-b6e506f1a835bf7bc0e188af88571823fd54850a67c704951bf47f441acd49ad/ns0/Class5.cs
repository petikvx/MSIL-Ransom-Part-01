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

	public static extern string smethod_0(string string_4);

	private static string smethod_1()
	{
		//Discarded unreachable code: IL_0009, IL_000f, IL_0024, IL_0029, IL_0031
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		long num = ((long[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		_003F val = /*Error near IL_0002: Stack underflow*/+ num;
		_ = /*Error near IL_0004: Stack underflow*/<< (int)val;
		/*Error near IL_0004: Invalid metadata token*/;
	}

	private static extern void smethod_2();

	private static extern void smethod_3(string string_4, string string_5);

	private static extern void Main();

	private static extern void smethod_4();

	private static extern bool smethod_5();

	private static extern bool smethod_6();

	private static extern bool smethod_7();

	private static extern string smethod_8();

	public Class5()
	{
		//Discarded unreachable code: IL_0003, IL_0009, IL_000e
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		ulong num = (ulong)/*Error near IL_0001: Stack underflow*/;
		_ = ((sbyte[])/*Error near IL_0002: Stack underflow*/)[num];
		/*Error near IL_0002: Unknown opcode: 0xFC*/;
	}

	static extern byte[] smethod_9(string string_4);

	static extern RijndaelManaged smethod_10();

	static extern void smethod_11(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	unsafe static void smethod_12(SymmetricAlgorithm symmetricAlgorithm_0, int int_0)
	{
		//Discarded unreachable code: IL_0007, IL_000f, IL_0015, IL_0021
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected F4, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			_003F val = /*Error near IL_0001: Stack underflow*/| /*Error near IL_0001: Stack underflow*/;
			*(float*)(nint)/*Error near IL_0002: Stack underflow*/ = (float)val;
		}
	}

	static extern Encoding smethod_13();

	static extern byte[] smethod_14(Encoding encoding_0, string string_4);

	static void smethod_15(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_0005, IL_0015, IL_001a, IL_0021, IL_0027
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
		}
	}

	static void smethod_16(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_0006, IL_000d, IL_0013
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern void smethod_17(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	static void smethod_18(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0)
	{
		//Discarded unreachable code: IL_000a, IL_0012, IL_001a, IL_001f, IL_0024
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got I4
		ulong num = checked((ulong)/*Error near IL_0001: Stack underflow*/);
		_ = /*Error near IL_0002: Stack underflow*/<< (int)num;
		/*Error near IL_0003: stloc 1 (out-of-bounds)*/;
		_ = /*Error near IL_0005: Stack underflow*/^ /*Error near IL_0005: Stack underflow*/;
		/*Error near IL_0005: Invalid metadata token*/;
	}

	static extern byte[] smethod_19(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern byte[] smethod_20(SymmetricAlgorithm symmetricAlgorithm_0);

	static ICryptoTransform smethod_21(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1)
	{
		//Discarded unreachable code: IL_0005, IL_000b, IL_0012, IL_0013, IL_0018, IL_001d
		//IL_0006: Invalid comparison between Unknown and I4
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected I4, but got F4
		/*Error: Invalid metadata token*/;
	}

	static extern byte[] smethod_22(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static extern Encoding smethod_23();

	static extern string smethod_24(Encoding encoding_0, byte[] byte_0);

	static extern void smethod_25(IDisposable idisposable_0);

	static extern string smethod_26(string string_4);

	static extern WebClient smethod_27();

	static extern string smethod_28(string string_4, string string_5);

	static extern void smethod_29(WebClient webClient_0, string string_4, string string_5);

	static extern void smethod_30(Component component_0);

	static extern Process smethod_31();

	unsafe static ProcessStartInfo smethod_32()
	{
		//Discarded unreachable code: IL_0013
		_ = *(ushort*)3247811242086905136uL;
		checked
		{
			_ = (nint)unchecked((int)checked((byte)/*Error near IL_000a: ldarg 2 (out-of-bounds)*/));
			/*Error near IL_000e: Invalid metadata token*/;
		}
	}

	static extern void smethod_33(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static void smethod_34(ProcessStartInfo processStartInfo_0, string string_4)
	{
		//Discarded unreachable code: IL_0007
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		sbyte num = ((sbyte[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		_ = /*Error near IL_0002: Stack underflow*/>> (int)num;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static extern string smethod_35(string string_4, string string_5, string string_6);

	static extern void smethod_36(ProcessStartInfo processStartInfo_0, string string_4);

	static extern void smethod_37(Process process_0, ProcessStartInfo processStartInfo_0);

	static extern bool smethod_38(Process process_0);

	static void smethod_39(int int_0)
	{
		//Discarded unreachable code: IL_001b, IL_0021, IL_002b, IL_0031, IL_0036, IL_003d
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I8
		//IL_001c: Invalid comparison between Unknown and I
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			short num = checked((short)int_0);
			if ((int)/*Error near IL_000c: Stack underflow*/ < (int)num)
			{
				ulong num2;
				checked
				{
					_003F val = /*Error near IL_000d: Stack underflow*/+ /*Error near IL_000d: Stack underflow*/;
					num2 = (ulong)(/*Error near IL_000e: Stack underflow*/ & val);
				}
				if ((long)/*Error near IL_0014: Stack underflow*/ >= (long)num2)
				{
					break;
				}
			}
		}
		/*Error near IL_0016: Invalid metadata token*/;
	}

	static extern void smethod_40(string string_4);

	static extern string smethod_41(string string_4);

	static extern Assembly smethod_42();

	static Stream smethod_43(Assembly assembly_0, string string_4)
	{
		return (Stream)/*OpCode not supported: Nop*/;
	}

	static extern FileStream smethod_44(string string_4, FileMode fileMode_0, FileAccess fileAccess_0);

	static extern void smethod_45(Stream stream_0, Stream stream_1);

	static extern Process smethod_46(string string_4);

	static string smethod_47(Assembly assembly_0)
	{
		//Discarded unreachable code: IL_0010, IL_0019, IL_001f, IL_0027
		//IL_0014: Invalid comparison between Unknown and I8
		//IL_001a: Invalid comparison between Unknown and I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/&& /*Error near IL_000a: Stack underflow*/<= /*Error near IL_000a: Stack underflow*/)
			{
			}
		}
	}

	unsafe static void smethod_48(string string_4, string string_5, bool bool_5)
	{
		//IL_0003: Invalid comparison between Unknown and I8
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			long num = checked((long)/*Error near IL_0003: Stack underflow*/);
			if ((long)/*Error near IL_0008: Stack underflow*/ > num)
			{
				continue;
			}
			uint num2 = checked((uint)/*Error near IL_0009: Stack underflow*/);
			if ((int)/*Error near IL_000e: Stack underflow*/ == (int)num2)
			{
				_003F val = checked(/*Error near IL_000f: Stack underflow*/ + /*Error near IL_000f: Stack underflow*/);
				if ((nint)/*Error near IL_0016: Stack underflow*/ < (nint)val)
				{
					break;
				}
			}
		}
		_ = /*Error near IL_0018: Stack underflow*/>> (int)/*Error near IL_0018: Stack underflow*/;
		/*Error: Unexpected end of block*/;
	}

	unsafe static RegistryKey smethod_49(RegistryKey registryKey_0, string string_4, bool bool_5)
	{
		//Discarded unreachable code: IL_0008, IL_0011, IL_0016
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		while (true)
		{
			int num = *(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			((sbyte[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (sbyte)num;
		}
	}

	static extern void smethod_50(RegistryKey registryKey_0, string string_4, object object_0);

	static extern DialogResult smethod_51(string string_4, string string_5, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0);

	static extern Assembly smethod_52();

	static extern string smethod_53(string string_4);

	static extern bool smethod_54(string string_4, string string_5);

	static extern Rectangle smethod_55(Point point_0);

	static extern Bitmap smethod_56(int int_0, int int_1);

	static extern Graphics smethod_57(Image image_0);

	static void smethod_58(Graphics graphics_0, Point point_0, Point point_1, Size size_0)
	{
		//Discarded unreachable code: IL_0007, IL_000e, IL_0013
		while (true)
		{
		}
	}

	static extern ImageFormat smethod_59();

	static extern void smethod_60(Image image_0, string string_4, ImageFormat imageFormat_0);

	static extern bool smethod_61(string string_4);

	static extern void smethod_62(Process process_0);

	static extern string[] smethod_63(string string_4, char[] char_0);

	static extern string smethod_64(WebClient webClient_0, string string_4);

	static extern string smethod_65();

	static extern string smethod_66();

	static extern string smethod_67(string[] string_4);

	static extern void smethod_68(string string_4, string string_5);

	static extern Process[] smethod_69();

	static extern string smethod_70(Process process_0);

	static extern void smethod_71(Process process_0);

	static extern Process smethod_72();

	static extern IntPtr smethod_73(Process process_0);

	static extern ManagementObjectSearcher smethod_74(string string_4);

	static extern ManagementObjectCollection smethod_75(ManagementObjectSearcher managementObjectSearcher_0);

	static ManagementObjectEnumerator smethod_76(ManagementObjectCollection managementObjectCollection_0)
	{
		//Discarded unreachable code: IL_001c
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected I4, but got Unknown
		do
		{
			_003F val = checked((short)4613476483137925873L + /*Error near IL_000a: ldloc 1 (out-of-bounds)*/);
			((short[])/*Error near IL_000d: Stack underflow*/)[/*Error near IL_000d: Stack underflow*/] = (short)(int)val;
		}
		while (/*Error near IL_0012: Stack underflow*/ > /*Error near IL_0012: Stack underflow*/|| /*Error near IL_0017: Stack underflow*/< /*Error near IL_0017: Stack underflow*/);
		/*Error near IL_0017: Invalid metadata token*/;
	}

	static ManagementBaseObject smethod_77(ManagementObjectEnumerator managementObjectEnumerator_0)
	{
		//Discarded unreachable code: IL_000c
		while (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
		}
		_ = 8;
		/*Error near IL_0007: Invalid metadata token*/;
	}

	static extern object smethod_78(ManagementBaseObject managementBaseObject_0, string string_4);

	static extern string smethod_79(object object_0);

	static extern string smethod_80(string string_4);

	static extern bool smethod_81(string string_4, string string_5);

	static extern string smethod_82(string string_4);

	static extern bool smethod_83(string string_4, string string_5);

	static extern bool smethod_84(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern NetworkInterface[] smethod_85();

	static extern OperationalStatus smethod_86(NetworkInterface networkInterface_0);

	static PhysicalAddress smethod_87(NetworkInterface networkInterface_0)
	{
		/*OpCode not supported: Ckfinite*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern string smethod_88(string string_4, char[] char_0);
}
