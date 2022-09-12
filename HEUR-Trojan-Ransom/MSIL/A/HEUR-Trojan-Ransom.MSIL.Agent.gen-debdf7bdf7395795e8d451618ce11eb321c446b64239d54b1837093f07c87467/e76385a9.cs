using System;
using System.Runtime.CompilerServices;

internal class e76385a9 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.byte_56;
	}

	public void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint num = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		Struct2 @struct = class49_0.ec45936d.a59d7f30(num--);
		byte b = class49_0.struct2_0[cb1fcba5.c456c371].method_4();
		if ((b & cb1fcba5.d5710944) != 0)
		{
			float f = @struct.e4021645();
			if (float.IsNaN(f) || float.IsInfinity(f))
			{
				throw new ArithmeticException();
			}
		}
		else
		{
			double d7252185 = @struct.ceea355b();
			if (double.IsNaN(d7252185) || double.IsInfinity(d7252185))
			{
				throw new ArithmeticException();
			}
		}
		class49_0.ec45936d.method_0(num);
		class49_0.struct2_0[cb1fcba5.byte_8].c85fac38(num);
		enum1_0 = (Enum1)0;
	}
}
