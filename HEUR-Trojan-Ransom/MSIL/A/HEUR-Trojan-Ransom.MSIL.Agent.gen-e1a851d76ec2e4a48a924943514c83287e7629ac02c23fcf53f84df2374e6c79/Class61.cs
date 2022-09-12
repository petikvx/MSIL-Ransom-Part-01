using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

internal class Class61 : Interface1
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private uint dbc89eb5;

	public Class61(uint uint_0)
	{
		b226692e(uint_0);
	}

	[SpecialName]
	public uint method_0()
	{
		return dbc89eb5;
	}

	[SpecialName]
	public void b226692e(uint uint_0)
	{
		dbc89eb5 = uint_0;
	}

	public ebd9b488 imethod_0(Class62 class62_0, Enum2 enum2_0)
	{
		ebd9b488 result = class62_0.class64_0.method_0(method_0());
		switch (enum2_0)
		{
		case (Enum2)0:
			result.eca936fa(result.fc52add5());
			break;
		case (Enum2)1:
			result.eca936fa(result.bfb9ba6b());
			break;
		case (Enum2)2:
			result.eca936fa(result.b585a11());
			break;
		default:
			if (result.ec0d6773() is Interface2)
			{
				result.aa900636(((Interface2)result.ec0d6773()).imethod_2());
			}
			break;
		}
		return result;
	}

	public void e44a2829(Class62 class62_0, ebd9b488 ebd9b488_0, Enum2 enum2_0)
	{
		switch (enum2_0)
		{
		case (Enum2)0:
			ebd9b488_0.eca936fa(ebd9b488_0.fc52add5());
			break;
		case (Enum2)1:
			ebd9b488_0.eca936fa(ebd9b488_0.bfb9ba6b());
			break;
		case (Enum2)2:
			ebd9b488_0.eca936fa(ebd9b488_0.b585a11());
			break;
		}
		class62_0.class64_0.method_1(method_0(), ebd9b488_0);
	}

	public Interface1 imethod_1(uint uint_0)
	{
		return new Class61(method_0() + uint_0);
	}

	public Interface1 imethod_2(ulong ulong_0)
	{
		return new Class61(method_0() + (uint)(int)ulong_0);
	}

	public void imethod_3(Class62 class62_0, f06aee96 f06aee96_0, Type type_0)
	{
		class62_0.class64_0.method_5(method_0(), f06aee96_0, type_0);
	}
}
