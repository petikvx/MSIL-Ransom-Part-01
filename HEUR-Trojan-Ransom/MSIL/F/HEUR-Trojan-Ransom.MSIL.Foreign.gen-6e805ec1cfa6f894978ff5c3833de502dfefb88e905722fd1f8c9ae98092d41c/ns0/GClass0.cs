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

	public string String_1
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set
		{
			//Discarded unreachable code: IL_0003
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			ulong num = checked((ulong)/*Error near IL_0001: Stack underflow*/);
			_ = /*Error near IL_0002: Stack underflow*/| num;
			/*Error near IL_0002: Unknown opcode: 0xFC*/;
		}
	}

	public extern GClass0();

	public void method_0(string string_2)
	{
		//Discarded unreachable code: IL_0007, IL_000d, IL_0012, IL_0019, IL_001f
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		/*Error: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	public extern void method_1(string string_2);

	public extern void Dispose();

	unsafe static WebClient smethod_0()
	{
		//Discarded unreachable code: IL_001b, IL_0020, IL_0026, IL_002d
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		int num2;
		checked
		{
			byte num;
			do
			{
				/*Error: stloc 2 (out-of-bounds)*/;
				num = (byte)unchecked((uint)(*(sbyte*)(nint)/*Error near IL_0003: Stack underflow*/));
			}
			while (unchecked((int)/*Error near IL_0009: Stack underflow*/) == num || 7u != 0);
			num2 = (sbyte)unchecked((uint)(int)/*Error near IL_0010: Stack underflow*/);
		}
		_ = /*Error near IL_0015: Stack underflow*/% num2;
		/*Error near IL_0016: Invalid metadata token*/;
	}

	static extern void smethod_1(NameValueCollection nameValueCollection_1, string string_2, string string_3);

	static extern byte[] smethod_2(WebClient webClient_1, string string_2, NameValueCollection nameValueCollection_1);

	static extern void smethod_3(NameValueCollection nameValueCollection_1);

	static extern byte[] smethod_4(WebClient webClient_1, string string_2, string string_3);

	static void smethod_5(Component component_0)
	{
		//Discarded unreachable code: IL_000d, IL_0016
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected F4, but got I
		//IL_0018: Expected O, but got I4
		checked
		{
			short num = (short)unchecked(/*Error near IL_0003: Stack underflow*/ / /*Error near IL_0003: Stack underflow*/);
			_ = (short)((float[])/*Error near IL_0006: Stack underflow*/)[num];
			/*Error near IL_0008: Invalid metadata token*/;
		}
	}

	unsafe static NameValueCollection smethod_6()
	{
		//IL_0005: Expected O, but got I4
		//IL_000f: Expected O, but got I4
		IntPtr intPtr = (nint)((Array)checked((uint)(ulong)(*unchecked((int*)(nint)/*Error near IL_0001: Stack underflow*/)))).LongLength;
		ushort num = ((ushort[])/*Error near IL_0006: Stack underflow*/)[(nint)intPtr];
		ulong num2 = checked((ulong)(object)null);
		((short[])/*Error near IL_000d: Stack underflow*/)[/*Error near IL_000d: Stack underflow*/] = (short)(num << (int)num2);
		return (NameValueCollection)(-1);
	}
}
