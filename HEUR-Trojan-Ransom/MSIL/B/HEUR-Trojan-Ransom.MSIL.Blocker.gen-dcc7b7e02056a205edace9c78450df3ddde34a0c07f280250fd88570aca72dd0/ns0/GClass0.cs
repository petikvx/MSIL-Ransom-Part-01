using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Net;
using System.Runtime.CompilerServices;

namespace ns0;

public class GClass0 : IDisposable
{
	private readonly WebClient webClient_0;

	private static NameValueCollection nameValueCollection_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	public unsafe string String_0
	{
		[CompilerGenerated]
		get
		{
			//Discarded unreachable code: IL_000c, IL_0012, IL_0019, IL_001b, IL_0021, IL_0026, IL_002e
			//IL_0007: Expected F4, but got I4
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got I4
			uint num2;
			checked
			{
				uint num = (uint)(*unchecked((double*)checked((ulong)/*Error near IL_0002: Stack underflow*/)));
				num2 = ((uint[])/*Error near IL_0006: Stack underflow*/)[num];
			}
			((float[])/*Error near IL_0007: Stack underflow*/)[/*Error near IL_0007: Stack underflow*/] = (int)num2;
			/*Error near IL_0007: Invalid metadata token*/;
		}
		[CompilerGenerated]
		set
		{
			//Discarded unreachable code: IL_0005, IL_0007, IL_000d, IL_0012
			//IL_0016: Expected O, but got I4
			/*Error: Invalid metadata token*/;
		}
	}

	public extern string String_1
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern GClass0();

	public extern void method_0(string string_2);

	public extern void method_1(string string_2);

	public extern void Dispose();

	static GClass0()
	{
		//Discarded unreachable code: IL_0001, IL_0009, IL_0010, IL_0017, IL_0022, IL_0029, IL_002f
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_002a: Invalid comparison between Unknown and I
		/*Error: Unknown opcode: 0xF8*/;
	}

	static extern WebClient smethod_0();

	static void smethod_1(NameValueCollection nameValueCollection_1, string string_2, string string_3)
	{
		//Discarded unreachable code: IL_000b, IL_0010
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		while (8u != 0)
		{
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static extern byte[] smethod_2(WebClient webClient_1, string string_2, NameValueCollection nameValueCollection_1);

	unsafe static void smethod_3(NameValueCollection nameValueCollection_1)
	{
		//Discarded unreachable code: IL_000c, IL_0016, IL_001c, IL_0024
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Expected native int or pointer, but got F4
		//IL_000e: Expected F8, but got I4
		//IL_001f: Invalid comparison between Unknown and I4
		long num = checked((long)/*Error near IL_0001: Stack underflow*/);
		long num2 = ((long[])/*Error near IL_0002: Stack underflow*/)[num];
		_ = *(short*)(nint)(float)(/*Error near IL_0003: Stack underflow*/ - num2);
		_ = 8;
		/*Error near IL_0007: Invalid metadata token*/;
	}

	unsafe static byte[] smethod_4(WebClient webClient_1, string string_2, string string_3)
	{
		//Discarded unreachable code: IL_0008, IL_0010, IL_0016, IL_001e
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0021: Expected F4, but got Unknown
		_003F val = /*Error: ldloc 0 (out-of-bounds)*/;
		*(sbyte*)(nint)/*Error near IL_0003: Stack underflow*/ = (sbyte)(nint)val;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static extern void smethod_5(Component component_0);

	static extern NameValueCollection smethod_6();
}
