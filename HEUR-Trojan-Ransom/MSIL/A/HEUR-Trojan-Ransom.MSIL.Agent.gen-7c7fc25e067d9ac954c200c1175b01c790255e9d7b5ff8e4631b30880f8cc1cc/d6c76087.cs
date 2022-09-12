using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

internal class d6c76087 : Interface2
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private uint uint_0;

	public d6c76087(uint uint_1)
	{
		f6276651(uint_1);
	}

	[SpecialName]
	public uint method_0()
	{
		return uint_0;
	}

	[SpecialName]
	public void f6276651(uint uint_1)
	{
		uint_0 = uint_1;
	}

	public feeb32c3 imethod_0(Class54 class54_0, Enum1 enum1_0)
	{
		feeb32c3 result = class54_0.class55_0.ff4c393f(method_0());
		switch (enum1_0)
		{
		case (Enum1)0:
			result.b67abfed(result.f939861c());
			break;
		case (Enum1)1:
			result.b67abfed(result.method_2());
			break;
		case (Enum1)2:
			result.b67abfed(result.method_0());
			break;
		default:
			if (result.cc3408c2() is c8feea0)
			{
				result.method_7(((c8feea0)result.cc3408c2()).df1630d2());
			}
			break;
		}
		return result;
	}

	public void edfcdc20(Class54 class54_0, feeb32c3 feeb32c3_0, Enum1 enum1_0)
	{
		switch (enum1_0)
		{
		case (Enum1)0:
			feeb32c3_0.b67abfed(feeb32c3_0.f939861c());
			break;
		case (Enum1)1:
			feeb32c3_0.b67abfed(feeb32c3_0.method_2());
			break;
		case (Enum1)2:
			feeb32c3_0.b67abfed(feeb32c3_0.method_0());
			break;
		}
		class54_0.class55_0.method_0(method_0(), feeb32c3_0);
	}

	public Interface2 imethod_1(uint uint_1)
	{
		return new d6c76087(method_0() + uint_1);
	}

	public Interface2 imethod_2(ulong ulong_0)
	{
		return new d6c76087(method_0() + (uint)(int)ulong_0);
	}

	public void imethod_3(Class54 class54_0, Struct1 struct1_0, Type type_0)
	{
		class54_0.class55_0.method_4(method_0(), struct1_0, type_0);
	}
}
