using System;
using System.Runtime.CompilerServices;

internal class b13f12f4 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.b33db17f;
	}

	public void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint num = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		if (class49_0.ec45936d.a59d7f30(num--).method_2() != 0)
		{
			throw new OverflowException();
		}
		class49_0.ec45936d.method_0(num);
		class49_0.struct2_0[cb1fcba5.byte_8].c85fac38(num);
		enum1_0 = (Enum1)0;
	}
}
