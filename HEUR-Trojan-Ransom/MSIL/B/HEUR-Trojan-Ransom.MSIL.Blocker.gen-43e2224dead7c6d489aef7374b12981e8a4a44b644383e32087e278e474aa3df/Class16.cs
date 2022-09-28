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

	public static extern GClass32 GClass32_0
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		private set;
	}

	public static extern string smethod_0(string string_0, int int_0 = 2);

	public static extern string smethod_1();

	public static extern string smethod_2();

	public static extern string smethod_3();

	public static extern string smethod_4();

	public static int smethod_5()
	{
		//Discarded unreachable code: IL_0001, IL_0015, IL_001e, IL_0023, IL_0029
		//IL_000a: Expected I4, but got F8
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected I4, but got F4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected I4, but got Unknown
		//IL_0030: Expected O, but got I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Unknown opcode: 0xFA*/;
	}

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

	private static extern string smethod_8(string string_0, string string_1);

	public static extern string smethod_9();

	public extern Class16();

	static extern int smethod_10(string string_0);

	static string smethod_11(string string_0, int int_0)
	{
		//Discarded unreachable code: IL_000b, IL_0012
		//IL_0004: Expected O, but got I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Incompatible stack heights: 0 vs 1
		string_0 = (string)((uint[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		_ = 3;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static string smethod_12()
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_0013, IL_0019
		/*Error: Invalid metadata token*/;
	}

	static extern string smethod_13(string string_0, string string_1, string string_2);

	static extern ManagementObjectSearcher smethod_14(string string_0, string string_1);

	static extern ManagementObjectCollection smethod_15(ManagementObjectSearcher managementObjectSearcher_0);

	static extern ManagementObjectEnumerator smethod_16(ManagementObjectCollection managementObjectCollection_0);

	static extern ManagementBaseObject smethod_17(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern object smethod_18(ManagementBaseObject managementBaseObject_0, string string_0);

	static extern string smethod_19(object object_0);

	static extern bool smethod_20(string string_0, string string_1);

	static extern bool smethod_21(string string_0, string string_1);

	static extern bool smethod_22(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern void smethod_23(IDisposable idisposable_0);

	static ManagementObjectSearcher smethod_24(string string_0)
	{
		//Discarded unreachable code: IL_0007
		_ = (byte)/*Error: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static extern object smethod_25(ManagementBaseObject managementBaseObject_0, string string_0);

	static extern string smethod_26(object object_0, object object_1, object object_2);

	static extern bool smethod_27(string string_0);

	unsafe static double smethod_28(object object_0)
	{
		//Discarded unreachable code: IL_0023
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			int num = *(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
			_003F val = /*Error near IL_0003: Stack underflow*/& num;
			if (/*Error near IL_0008: Stack underflow*/ == val)
			{
				((object[])/*Error near IL_000b: Stack underflow*/)[/*Error near IL_000b: Stack underflow*/] = (object)/*Error near IL_000b: Stack underflow*/;
				bool num2 = /*Error near IL_000f: Stack underflow*/< /*Error near IL_000f: Stack underflow*/;
				if ((int)/*Error near IL_0014: Stack underflow*/ != (num2 ? 1 : 0) && true && /*Error near IL_0020: Stack underflow*/> /*Error near IL_0020: Stack underflow*/)
				{
					break;
				}
			}
		}
		checked
		{
			_ = /*Error near IL_0021: Stack underflow*/- /*Error near IL_0021: Stack underflow*/;
			/*Error near IL_0021: stloc 1 (out-of-bounds)*/;
			/*Error near IL_0022: Unknown opcode: 0xF9*/;
		}
	}

	static Type smethod_29(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		//Discarded unreachable code: IL_0006
		_ = (uint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern DataContractJsonSerializer smethod_30(Type type_0);

	static extern WebRequest smethod_31(string string_0);

	static void smethod_32(HttpWebRequest httpWebRequest_0, string string_0)
	{
		//Discarded unreachable code: IL_0008, IL_0016, IL_001b, IL_0023, IL_002e, IL_0034, IL_0039, IL_003e
		//IL_0001: Invalid comparison between Unknown and I
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0029: Invalid comparison between Unknown and I
		//IL_0043: Incompatible stack heights: 0 vs 1
		nuint num = checked((nuint)/*Error near IL_0001: Stack underflow*/);
		if ((nint)/*Error near IL_0003: Stack underflow*/ <= (nint)num)
		{
			/*Error near IL_0003: Invalid metadata token*/;
		}
		((sbyte[])/*Error near IL_0045: Stack underflow*/)[/*Error near IL_0045: Stack underflow*/] = (sbyte)/*Error near IL_0045: Stack underflow*/;
		/*Error: Unexpected end of block*/;
	}

	static extern void smethod_33(WebRequest webRequest_0, IWebProxy iwebProxy_0);

	static extern void smethod_34(WebRequest webRequest_0, int int_0);

	static extern WebResponse smethod_35(WebRequest webRequest_0);

	static extern Stream smethod_36(WebResponse webResponse_0);

	static extern StreamReader smethod_37(Stream stream_0);

	static extern string smethod_38(TextReader textReader_0);

	static extern Encoding smethod_39();

	static byte[] smethod_40(Encoding encoding_0, string string_0)
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0016, IL_001d, IL_0023
		_ = -746779255;
		/*Error near IL_0005: Unknown opcode: 0xFA*/;
	}

	static extern MemoryStream smethod_41(byte[] byte_0);

	static extern object smethod_42(XmlObjectSerializer xmlObjectSerializer_0, Stream stream_0);

	static RegistryKey smethod_43(RegistryKey registryKey_0, string string_0)
	{
		//Discarded unreachable code: IL_0002, IL_000f, IL_001a
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected O, but got Unknown
		//IL_0005: Unsupported input type for neg.
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected I4, but got I8
		//IL_0018: Expected I8, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected I4, but got Unknown
		/*Error near IL_0001: Unknown opcode: 0xFB*/;
	}

	static extern object smethod_44(RegistryKey registryKey_0, string string_0);

	static extern string smethod_45(string string_0, string string_1);

	static extern string smethod_46(string[] string_0);
}
