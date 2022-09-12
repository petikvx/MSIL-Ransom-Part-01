using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

internal class a32d2227 : Interface1
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private uint f4865d9c;

	public a32d2227(uint uint_0)
	{
		method_0(uint_0);
	}

	[SpecialName]
	public uint d724395a()
	{
		return f4865d9c;
	}

	[SpecialName]
	public void method_0(uint uint_0)
	{
		f4865d9c = uint_0;
	}

	public Struct2 a421f925(Class52 class52_0, cf6ebfe8 cf6ebfe8_0)
	{
		Struct2 result = class52_0.c6a36180_0.f113e6df(d724395a());
		switch (cf6ebfe8_0)
		{
		case (cf6ebfe8)0:
			result.f6b2288d(result.method_3());
			break;
		case (cf6ebfe8)1:
			result.f6b2288d(result.method_1());
			break;
		case (cf6ebfe8)2:
			result.f6b2288d(result.b5683088());
			break;
		default:
			if (result.a90ed1e2() is Interface2)
			{
				result.method_7(((Interface2)result.a90ed1e2()).imethod_0());
			}
			break;
		}
		return result;
	}

	public void imethod_0(Class52 class52_0, Struct2 struct2_0, cf6ebfe8 cf6ebfe8_0)
	{
		switch (cf6ebfe8_0)
		{
		case (cf6ebfe8)0:
			struct2_0.f6b2288d(struct2_0.method_3());
			break;
		case (cf6ebfe8)1:
			struct2_0.f6b2288d(struct2_0.method_1());
			break;
		case (cf6ebfe8)2:
			struct2_0.f6b2288d(struct2_0.b5683088());
			break;
		}
		class52_0.c6a36180_0.f43586b2(d724395a(), struct2_0);
	}

	public Interface1 aa5eee9f(uint uint_0)
	{
		return new a32d2227(d724395a() + uint_0);
	}

	public Interface1 aa5eee9f(ulong ulong_0)
	{
		return new a32d2227(d724395a() + (uint)(int)ulong_0);
	}

	public void imethod_1(Class52 class52_0, Struct1 struct1_0, Type type_0)
	{
		class52_0.c6a36180_0.method_4(d724395a(), struct1_0, type_0);
	}
}
