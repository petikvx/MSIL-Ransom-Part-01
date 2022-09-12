using System;
using System.Runtime.CompilerServices;

internal class Class2 : f788ae7e
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.byte_45;
	}

	public void imethod_0(Class52 class52_0, out a82ced3b a82ced3b_0)
	{
		uint uint_ = class52_0.struct2_0[fae0f10.byte_5].b5683088();
		Struct2 @struct = class52_0.c6a36180_0.f113e6df(uint_--);
		byte b7056385 = class52_0.struct2_0[fae0f10.b4de136c].method_3();
		if ((b7056385 & fae0f10.e2ea52e3) != 0)
		{
			float f = @struct.method_5();
			if (float.IsNaN(f) || float.IsInfinity(f))
			{
				throw new ArithmeticException();
			}
		}
		else
		{
			double d = @struct.d6a6a8ce();
			if (double.IsNaN(d) || double.IsInfinity(d))
			{
				throw new ArithmeticException();
			}
		}
		class52_0.c6a36180_0.method_0(uint_);
		class52_0.struct2_0[fae0f10.byte_5].b3579a47(uint_);
		a82ced3b_0 = (a82ced3b)0;
	}
}
