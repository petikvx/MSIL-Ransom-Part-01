using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

internal class dc3c6d47 : Interface0
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private uint f7c573c;

	public dc3c6d47(uint uint_0)
	{
		ab01d111(uint_0);
	}

	[SpecialName]
	public uint method_0()
	{
		return f7c573c;
	}

	[SpecialName]
	public void ab01d111(uint uint_0)
	{
		f7c573c = uint_0;
	}

	public facef383 b3037b45(Class58 class58_0, Enum1 enum1_0)
	{
		facef383 result = class58_0.c73f45d8.a9bb6dff(method_0());
		switch (enum1_0)
		{
		case (Enum1)0:
			result.method_1(result.a42951dc());
			break;
		case (Enum1)1:
			result.method_1(result.c635f39a());
			break;
		case (Enum1)2:
			result.method_1(result.df1ed028());
			break;
		default:
			if (result.method_8() is ad414660)
			{
				result.method_9(((ad414660)result.method_8()).imethod_0());
			}
			break;
		}
		return result;
	}

	public void c076b3e0(Class58 class58_0, facef383 facef383_0, Enum1 enum1_0)
	{
		switch (enum1_0)
		{
		case (Enum1)0:
			facef383_0.method_1(facef383_0.a42951dc());
			break;
		case (Enum1)1:
			facef383_0.method_1(facef383_0.c635f39a());
			break;
		case (Enum1)2:
			facef383_0.method_1(facef383_0.df1ed028());
			break;
		}
		class58_0.c73f45d8.method_0(method_0(), facef383_0);
	}

	public Interface0 df0155bf(uint uint_0)
	{
		return new dc3c6d47(method_0() + uint_0);
	}

	public Interface0 df0155bf(ulong ulong_0)
	{
		return new dc3c6d47(method_0() + (uint)(int)ulong_0);
	}

	public void imethod_0(Class58 class58_0, Struct0 struct0_0, Type type_0)
	{
		class58_0.c73f45d8.method_3(method_0(), struct0_0, type_0);
	}
}
