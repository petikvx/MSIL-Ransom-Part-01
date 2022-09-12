using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

internal class Class48 : da5e0024
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private uint uint_0;

	public Class48(uint uint_1)
	{
		method_0(uint_1);
	}

	[SpecialName]
	public uint a4a01217()
	{
		return uint_0;
	}

	[SpecialName]
	public void method_0(uint uint_1)
	{
		uint_0 = uint_1;
	}

	public Struct2 imethod_0(Class49 class49_0, Enum2 enum2_0)
	{
		Struct2 result = class49_0.ec45936d.a59d7f30(a4a01217());
		switch (enum2_0)
		{
		case (Enum2)0:
			result.method_1(result.method_4());
			break;
		case (Enum2)1:
			result.method_1(result.method_3());
			break;
		case (Enum2)2:
			result.method_1(result.method_2());
			break;
		default:
			if (result.method_6() is Interface1)
			{
				result.method_7(((Interface1)result.method_6()).imethod_2());
			}
			break;
		}
		return result;
	}

	public void bf75e195(Class49 class49_0, Struct2 struct2_0, Enum2 enum2_0)
	{
		switch (enum2_0)
		{
		case (Enum2)0:
			struct2_0.method_1(struct2_0.method_4());
			break;
		case (Enum2)1:
			struct2_0.method_1(struct2_0.method_3());
			break;
		case (Enum2)2:
			struct2_0.method_1(struct2_0.method_2());
			break;
		}
		class49_0.ec45936d.d1cb88cf(a4a01217(), struct2_0);
	}

	public da5e0024 f4d9c5f0(uint uint_1)
	{
		return new Class48(a4a01217() + uint_1);
	}

	public da5e0024 f4d9c5f0(ulong ulong_0)
	{
		return new Class48(a4a01217() + (uint)(int)ulong_0);
	}

	public void c4cba08f(Class49 class49_0, fe387972 fe387972_0, Type type_0)
	{
		class49_0.ec45936d.c4cba08f(a4a01217(), fe387972_0, type_0);
	}
}
