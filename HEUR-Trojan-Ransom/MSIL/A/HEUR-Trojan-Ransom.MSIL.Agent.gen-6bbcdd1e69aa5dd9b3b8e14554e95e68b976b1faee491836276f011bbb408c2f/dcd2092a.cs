using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

internal class dcd2092a : Interface1
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private uint df61f05b;

	public dcd2092a(uint uint_0)
	{
		method_1(uint_0);
	}

	[SpecialName]
	public uint method_0()
	{
		return df61f05b;
	}

	[SpecialName]
	public void method_1(uint uint_0)
	{
		df61f05b = uint_0;
	}

	public Struct3 bb331190(fdc40966 fdc40966_0, f75d8d37 f75d8d37_0)
	{
		Struct3 result = fdc40966_0.class58_0.method_0(method_0());
		switch (f75d8d37_0)
		{
		case (f75d8d37)0:
			result.method_0(result.method_3());
			break;
		case (f75d8d37)1:
			result.method_0(result.method_2());
			break;
		case (f75d8d37)2:
			result.method_0(result.method_1());
			break;
		default:
			if (result.c9550f69() is Interface2)
			{
				result.db2591b4(((Interface2)result.c9550f69()).imethod_1());
			}
			break;
		}
		return result;
	}

	public void ce1637af(fdc40966 fdc40966_0, Struct3 struct3_0, f75d8d37 f75d8d37_0)
	{
		switch (f75d8d37_0)
		{
		case (f75d8d37)0:
			struct3_0.method_0(struct3_0.method_3());
			break;
		case (f75d8d37)1:
			struct3_0.method_0(struct3_0.method_2());
			break;
		case (f75d8d37)2:
			struct3_0.method_0(struct3_0.method_1());
			break;
		}
		fdc40966_0.class58_0.b53f41f9(method_0(), struct3_0);
	}

	public Interface1 fdd68142(uint uint_0)
	{
		return new dcd2092a(method_0() + uint_0);
	}

	public Interface1 fdd68142(ulong ulong_0)
	{
		return new dcd2092a(method_0() + (uint)(int)ulong_0);
	}

	public void imethod_0(fdc40966 fdc40966_0, Struct2 struct2_0, Type type_0)
	{
		fdc40966_0.class58_0.method_4(method_0(), struct2_0, type_0);
	}
}
