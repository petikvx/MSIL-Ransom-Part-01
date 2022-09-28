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

	public unsafe static string smethod_4()
	{
		//Discarded unreachable code: IL_0008, IL_000d, IL_000e, IL_000f
		//IL_0004: Expected I8, but got I4
		object obj = ((object[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/];
		int num = ((int[])/*Error near IL_0003: Stack underflow*/)[obj];
		*(long*)(nint)/*Error near IL_0004: Stack underflow*/ = num;
		((IntPtr[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (IntPtr)/*Error near IL_0005: Stack underflow*/;
		/*Error near IL_0007: Unknown opcode: 0xFF*/;
	}

	public static int smethod_5()
	{
		//Discarded unreachable code: IL_0019
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
			{
				continue;
			}
			_003F val = checked(/*Error near IL_0006: Stack underflow*/ - /*Error near IL_0006: Stack underflow*/);
			if ((/*Error near IL_0008: Stack underflow*/ & val) == 0)
			{
				short num = ((short[])/*Error near IL_000e: Stack underflow*/)[/*Error near IL_000e: Stack underflow*/];
				_003F val2 = /*Error near IL_000f: Stack underflow*/| num;
				if (/*Error near IL_0014: Stack underflow*/ > val2)
				{
					break;
				}
			}
		}
		/*Error near IL_0014: Invalid metadata token*/;
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

	private static string smethod_8(string string_0, string string_1)
	{
		//Discarded unreachable code: IL_0007
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		((double[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (double)/*Error near IL_0001: Stack underflow*/;
		_ = /*Error near IL_0002: Stack underflow*/<< (int)/*Error near IL_0002: Stack underflow*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	public static extern string smethod_9();

	public extern Class16();

	static extern int smethod_10(string string_0);

	static extern string smethod_11(string string_0, int int_0);

	static extern string smethod_12();

	static extern string smethod_13(string string_0, string string_1, string string_2);

	static ManagementObjectSearcher smethod_14(string string_0, string string_1)
	{
		//Discarded unreachable code: IL_0007, IL_000c, IL_0014, IL_0020
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got I8
		_ = (nint)(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static ManagementObjectCollection smethod_15(ManagementObjectSearcher managementObjectSearcher_0)
	{
		//Discarded unreachable code: IL_0015, IL_001b, IL_0024, IL_002d
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected O, but got I8
		//IL_0011: Expected O, but got F8
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unsupported input type for neg.
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_003F val;
			do
			{
				ulong num = (ulong)unchecked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
				((object[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = num;
				/*OpCode not supported: DebugBreak*/;
				val = /*Error near IL_0006: ldarg 3 (out-of-bounds)*/;
			}
			while (/*Error near IL_000c: Stack underflow*/ > val);
			_ = ((double[])/*Error near IL_000d: Stack underflow*/)[/*Error near IL_000d: Stack underflow*/];
			/*OpCode not supported: DebugBreak*/;
			/*Error near IL_0010: Invalid metadata token*/;
		}
	}

	static extern ManagementObjectEnumerator smethod_16(ManagementObjectCollection managementObjectCollection_0);

	static extern ManagementBaseObject smethod_17(ManagementObjectEnumerator managementObjectEnumerator_0);

	static extern object smethod_18(ManagementBaseObject managementBaseObject_0, string string_0);

	static extern string smethod_19(object object_0);

	static extern bool smethod_20(string string_0, string string_1);

	static extern bool smethod_21(string string_0, string string_1);

	static bool smethod_22(ManagementObjectEnumerator managementObjectEnumerator_0)
	{
		//Discarded unreachable code: IL_0005, IL_0013, IL_0018, IL_001e, IL_0025
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_23(IDisposable idisposable_0);

	static extern ManagementObjectSearcher smethod_24(string string_0);

	static extern object smethod_25(ManagementBaseObject managementBaseObject_0, string string_0);

	static extern string smethod_26(object object_0, object object_1, object object_2);

	static extern bool smethod_27(string string_0);

	unsafe static double smethod_28(object object_0)
	{
		//Discarded unreachable code: IL_001f
		//IL_0006: Expected I8, but got I4
		//IL_0021: Unsupported input type for neg.
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			byte num = (byte)(*unchecked((long*)(-5)));
			((long[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/] = unchecked((int)num);
			ushort num2 = (ushort)unchecked((ulong)checked((long)((double[])/*Error near IL_0010: Stack underflow*/)[8.251571532623993E+122]));
			_ = ((ushort[])/*Error near IL_0016: Stack underflow*/)[num2];
			/*Error near IL_0018: ldarg 3 (out-of-bounds)*/;
			/*Error near IL_0019: ldloc 1 (out-of-bounds)*/;
			_ = 22;
			/*Error near IL_001e: Unknown opcode: 0xFC*/;
		}
	}

	static extern Type smethod_29(RuntimeTypeHandle runtimeTypeHandle_0);

	static extern DataContractJsonSerializer smethod_30(Type type_0);

	static extern WebRequest smethod_31(string string_0);

	static extern void smethod_32(HttpWebRequest httpWebRequest_0, string string_0);

	static extern void smethod_33(WebRequest webRequest_0, IWebProxy iwebProxy_0);

	static extern void smethod_34(WebRequest webRequest_0, int int_0);

	static WebResponse smethod_35(WebRequest webRequest_0)
	{
		switch (((short[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/])
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static extern Stream smethod_36(WebResponse webResponse_0);

	static StreamReader smethod_37(Stream stream_0)
	{
		//Discarded unreachable code: IL_0005
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static extern string smethod_38(TextReader textReader_0);

	static extern Encoding smethod_39();

	static byte[] smethod_40(Encoding encoding_0, string string_0)
	{
		//Discarded unreachable code: IL_0006, IL_001b, IL_0020
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Incompatible stack heights: 0 vs 1
		checked
		{
			_ = (int)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	static extern MemoryStream smethod_41(byte[] byte_0);

	static extern object smethod_42(XmlObjectSerializer xmlObjectSerializer_0, Stream stream_0);

	static extern RegistryKey smethod_43(RegistryKey registryKey_0, string string_0);

	static object smethod_44(RegistryKey registryKey_0, string string_0)
	{
		/*Error: Invalid metadata token*/;
	}

	static extern string smethod_45(string string_0, string string_1);

	static extern string smethod_46(string[] string_0);
}
