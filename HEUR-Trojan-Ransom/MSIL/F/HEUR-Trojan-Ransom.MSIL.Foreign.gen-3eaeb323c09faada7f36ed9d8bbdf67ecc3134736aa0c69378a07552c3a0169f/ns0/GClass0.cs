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

	public extern string String_0
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
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

	unsafe static WebClient smethod_0()
	{
		//Discarded unreachable code: IL_0008, IL_0013, IL_0019, IL_001e
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		_ = *(long*)(int)((uint[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0003: Invalid metadata token*/;
	}

	unsafe static void smethod_1(NameValueCollection nameValueCollection_1, string string_2, string string_3)
	{
		//Discarded unreachable code: IL_000e, IL_0014, IL_0019
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected I4, but got Unknown
		//IL_0007: Expected F4, but got I4
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		double num = ((double[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		_003F val = /*Error near IL_0002: Stack underflow*/<< (int)num;
		((int[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (int)val;
		*(float*)(short)/*Error near IL_0004: Stack underflow*/ = 0f;
		_ = ((Array)(/*Error near IL_0008: Stack underflow*/ << (int)/*Error near IL_0008: Stack underflow*/)).LongLength;
		/*Error near IL_0009: Invalid metadata token*/;
	}

	static extern byte[] smethod_2(WebClient webClient_1, string string_2, NameValueCollection nameValueCollection_1);

	static extern void smethod_3(NameValueCollection nameValueCollection_1);

	static byte[] smethod_4(WebClient webClient_1, string string_2, string string_3)
	{
		//Discarded unreachable code: IL_001f, IL_0028
		//IL_0009: Expected I4, but got O
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		short num3;
		do
		{
			int num = ((int[])/*Error near IL_0003: Stack underflow*/)[(object)webClient_1];
			((sbyte[])/*Error near IL_0009: Stack underflow*/)[num] = (sbyte)(int)"";
			sbyte num2 = checked((sbyte)(int)/*Error near IL_000a: Stack underflow*/);
			num3 = (short)(/*Error near IL_000f: Stack underflow*/ - num2);
			_ = 7;
			/*Error near IL_0012: stloc 3 (out-of-bounds)*/;
		}
		while ((uint)num3 > 5u);
		/*Error near IL_001a: Invalid metadata token*/;
	}

	static void smethod_5(Component component_0)
	{
		//Discarded unreachable code: IL_0002, IL_0012, IL_0018, IL_001d
		//IL_000d: Invalid comparison between I and F8
		/*Error near IL_0001: Unknown opcode: 0xFA*/;
	}

	static NameValueCollection smethod_6()
	{
		return (NameValueCollection)/*OpCode not supported: Nop*/;
	}
}
