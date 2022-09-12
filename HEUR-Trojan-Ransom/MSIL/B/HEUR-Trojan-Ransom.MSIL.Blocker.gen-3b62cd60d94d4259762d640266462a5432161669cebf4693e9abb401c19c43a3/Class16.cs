using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using Microsoft.Win32;

internal class Class16
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static GClass32 gclass32_0;

	public static GClass32 GClass32_0
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		private set
		{
			//Discarded unreachable code: IL_0009, IL_000e, IL_0016, IL_001e, IL_0023, IL_002c, IL_0030
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got I4
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			/*OpCode not supported: DebugBreak*/;
			/*Error near IL_0002: ldloc 0 (out-of-bounds)*/;
			/*Error near IL_0004: Invalid metadata token*/;
		}
	}

	public static string smethod_0(string string_0, int int_0 = 2)
	{
		//Discarded unreachable code: IL_0009
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected O, but got I4
		_ = ((Array)(byte)checked(/*Error near IL_0002: Stack underflow*/ * 8)).LongLength;
		/*Error near IL_0004: Invalid metadata token*/;
	}

	public static extern string smethod_1();

	public static string smethod_2()
	{
		//Discarded unreachable code: IL_0006, IL_000c
		//IL_000e: Expected native int or pointer, but got F4
		//IL_0011: Invalid comparison between Unknown and I
		checked
		{
			_ = (nuint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	public static extern string smethod_3();

	public static string smethod_4()
	{
		//Discarded unreachable code: IL_0011, IL_001f, IL_0024, IL_002a, IL_0031, IL_0039, IL_0043
		//IL_000d: Expected O, but got I8
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected I4, but got Unknown
		//IL_001a: Invalid comparison between Unknown and I4
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		while ((ushort)/*Error near IL_0001: Stack underflow*/ == 0 || /*Error near IL_000b: Stack underflow*/>= /*Error near IL_000b: Stack underflow*/)
		{
		}
		_ = (ulong)/*Error near IL_000c: Stack underflow*/;
		/*Error near IL_000c: Invalid metadata token*/;
	}

	public static extern int smethod_5();

	public static extern void smethod_6();

	[DllImport("kernel32.dll")]
	private static extern bool IsWow64Process(IntPtr intptr_0, out bool bool_0);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetModuleHandle(string string_0);

	[DllImport("kernel32")]
	private static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	public static extern bool smethod_7();

	private static string smethod_8(string string_0, string string_1)
	{
		//Discarded unreachable code: IL_0012, IL_0017, IL_0021, IL_0026
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Incompatible stack heights: 0 vs 3
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Incompatible stack heights: 0 vs 1
		checked
		{
			while (true)
			{
				((double[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (double)/*Error near IL_0001: Stack underflow*/;
				short num = (short)/*Error near IL_0002: Stack underflow*/;
				if (unchecked((int)/*Error near IL_0007: Stack underflow*/ >= (int)num))
				{
					_ = /*Error near IL_0008: Stack underflow*/+ /*Error near IL_0008: Stack underflow*/;
					_ = string_0;
					_ = 3;
				}
			}
		}
	}

	public static extern string smethod_9();

	public extern Class16();

	static extern int smethod_10(string string_0);

	static extern string smethod_11(string string_0, int int_0);

	static string smethod_12()
	{
		//Discarded unreachable code: IL_0007
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0002: Stack underflow*/& /*Error near IL_0002: Stack underflow*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static extern string smethod_13(string string_0, string string_1, string string_2);

	unsafe static ManagementObjectSearcher smethod_14(string string_0, string string_1)
	{
		//Discarded unreachable code: IL_0007
		_ = *(ushort*)(nint)/*Error near IL_0002: Stack underflow*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static extern ManagementObjectCollection smethod_15(ManagementObjectSearcher managementObjectSearcher_0);

	static ManagementObjectEnumerator smethod_16(ManagementObjectCollection managementObjectCollection_0)
	{
		return (ManagementObjectEnumerator)(object)/*OpCode not supported: Nop*/;
	}

	static ManagementBaseObject smethod_17(ManagementObjectEnumerator managementObjectEnumerator_0)
	{
		//IL_0001: Invalid comparison between Unknown and I4
		while ((int)/*Error near IL_0006: Stack underflow*/ >= 7)
		{
		}
		throw ref managementObjectEnumerator_0;
	}

	static object smethod_18(ManagementBaseObject managementBaseObject_0, string string_0)
	{
		//Discarded unreachable code: IL_0008, IL_0011, IL_0016, IL_0023, IL_0029, IL_0030, IL_0036
		//IL_0000: Unsupported input type for neg.
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected I8, but got Unknown
		//IL_0018: Expected O, but got I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		_003F val = 0 - /*Error near IL_0001: Stack underflow*/;
		((long[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (long)val;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static extern string smethod_19(object object_0);

	static bool smethod_20(string string_0, string string_1)
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0011
		while (true)
		{
		}
	}

	static extern bool smethod_21(string string_0, string string_1);

	static extern bool smethod_22(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern void smethod_23(IDisposable idisposable_0);

	static extern ManagementObjectSearcher smethod_24(string string_0);

	static object smethod_25(ManagementBaseObject managementBaseObject_0, string string_0)
	{
		//Discarded unreachable code: IL_0005, IL_000b
		//IL_0011: Expected I4, but got I8
		/*Error: Invalid metadata token*/;
	}

	static extern string smethod_26(object object_0, object object_1, object object_2);

	static extern bool smethod_27(string string_0);

	static double smethod_28(object object_0)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_000f, IL_0010, IL_0016, IL_0017, IL_0019
		/*Error: Invalid metadata token*/;
	}

	unsafe static Type smethod_29(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		//Discarded unreachable code: IL_000b, IL_0010, IL_0018, IL_001d, IL_0022
		//IL_0001: Invalid comparison between Unknown and F4
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			float num = *(float*)(nint)/*Error near IL_0001: Stack underflow*/;
			if ((float)/*Error near IL_0006: Stack underflow*/ > num)
			{
			}
		}
	}

	static extern DataContractJsonSerializer smethod_30(Type type_0);

	static extern WebRequest smethod_31(string string_0);

	static extern void smethod_32(HttpWebRequest httpWebRequest_0, string string_0);

	static extern void smethod_33(WebRequest webRequest_0, IWebProxy iwebProxy_0);

	static void smethod_34(WebRequest webRequest_0, int int_0)
	{
		//Discarded unreachable code: IL_0005, IL_0007, IL_000d, IL_0012, IL_0018
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
		}
	}

	static extern WebResponse smethod_35(WebRequest webRequest_0);

	static extern Stream smethod_36(WebResponse webResponse_0);

	static extern StreamReader smethod_37(Stream stream_0);

	static string smethod_38(TextReader textReader_0)
	{
		//Discarded unreachable code: IL_0005
		//IL_0009: Unsupported input type for neg.
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static Encoding smethod_39()
	{
		//Discarded unreachable code: IL_0006, IL_000e, IL_0013
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between F4 and Unknown
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static byte[] smethod_40(Encoding encoding_0, string string_0)
	{
		//Discarded unreachable code: IL_0006, IL_0014, IL_001a
		//IL_0006: Unsupported input type for neg.
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		/*Error: ldloc 3 (out-of-bounds)*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern MemoryStream smethod_41(byte[] byte_0);

	unsafe static object smethod_42(XmlObjectSerializer xmlObjectSerializer_0, Stream stream_0)
	{
		while (true)
		{
			_003F val = /*Error: ldloc 1 (out-of-bounds)*/;
			if (/*Error near IL_0009: Stack underflow*/ == val)
			{
				uint num = checked((uint)/*Error near IL_0009: ldloc 1 (out-of-bounds)*/);
				*(uint*)(nint)/*Error near IL_000d: Stack underflow*/ = num;
				if (/*Error near IL_0012: Stack underflow*/ > /*Error near IL_0012: Stack underflow*/)
				{
					break;
				}
			}
		}
		checked
		{
			_ = (byte)(-1);
			/*Error near IL_0014: Invalid metadata token*/;
		}
	}

	static extern RegistryKey smethod_43(RegistryKey registryKey_0, string string_0);

	static extern object smethod_44(RegistryKey registryKey_0, string string_0);

	static string smethod_45(string string_0, string string_1)
	{
		//Discarded unreachable code: IL_0005, IL_000c, IL_0016, IL_001d, IL_0023, IL_002d
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected native int or pointer, but got O
		//IL_0012: Expected F4, but got I4
		//IL_0014: Expected I4, but got I8
		//IL_0027: Expected native int or pointer, but got O
		//IL_0033: Expected O, but got I4
		/*Error: Invalid metadata token*/;
	}

	static extern string smethod_46(string[] string_0);
}
