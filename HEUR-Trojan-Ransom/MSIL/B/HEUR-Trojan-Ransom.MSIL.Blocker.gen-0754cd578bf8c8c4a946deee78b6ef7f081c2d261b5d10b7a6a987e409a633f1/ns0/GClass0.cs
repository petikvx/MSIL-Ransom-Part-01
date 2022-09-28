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

	public unsafe void method_0(string string_2)
	{
		//Discarded unreachable code: IL_0022
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Expected O, but got Unknown
		//IL_0005: Unsupported input type for neg.
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected F4, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and Ref
		while (true)
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			_003F val = /*Error near IL_0002: Stack underflow*/| /*Error near IL_0002: Stack underflow*/;
			((object[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (object)val;
			_003F val2 = 0 - /*Error near IL_0006: Stack underflow*/;
			*(float*)(nint)/*Error near IL_0007: Stack underflow*/ = (float)val2;
			if (/*Error near IL_000c: Stack underflow*/ == /*Error near IL_000c: Stack underflow*/)
			{
				int num;
				checked
				{
					_ = (nint)unchecked((int)((ushort[])/*Error near IL_000d: Stack underflow*/)[/*Error near IL_000d: Stack underflow*/]);
					/*Error near IL_000e: stloc 3 (out-of-bounds)*/;
					num = (int)/*Error near IL_0011: Stack underflow*/;
				}
				_003F val3 = /*Error near IL_0012: Stack underflow*// num;
				/*OpCode not supported: DebugBreak*/;
				if (!System.Runtime.CompilerServices.Unsafe.IsAddressGreaterThan(ref *(byte*)val3, ref *(byte*)(&this)))
				{
					break;
				}
			}
		}
		checked
		{
			_ = (nuint)/*Error near IL_001d: Stack underflow*/;
			/*Error near IL_001d: Invalid metadata token*/;
		}
	}

	public extern void method_1(string string_2);

	public extern void Dispose();

	static WebClient smethod_0()
	{
		_003F val;
		do
		{
			val = /*Error: ldarg 1 (out-of-bounds)*/;
		}
		while (/*Error near IL_0006: Stack underflow*/ <= val || /*Error near IL_000b: Stack underflow*/< /*Error near IL_000b: Stack underflow*/);
		checked
		{
			_ = (uint)/*Error near IL_000c: Stack underflow*/;
			/*Error near IL_000c: ldloc 1 (out-of-bounds)*/;
			/*Error: Unexpected end of block*/;
		}
	}

	static extern void smethod_1(NameValueCollection nameValueCollection_1, string string_2, string string_3);

	static extern byte[] smethod_2(WebClient webClient_1, string string_2, NameValueCollection nameValueCollection_1);

	static extern void smethod_3(NameValueCollection nameValueCollection_1);

	static extern byte[] smethod_4(WebClient webClient_1, string string_2, string string_3);

	static extern void smethod_5(Component component_0);

	static extern NameValueCollection smethod_6();
}
