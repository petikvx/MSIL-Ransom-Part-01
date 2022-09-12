using System;
using System.Runtime.CompilerServices;

internal class de9ca024 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.byte_64;
	}

	public void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint num = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		feeb32c3 feeb32c4 = class54_0.class55_0.ff4c393f(num--);
		byte b = class54_0.feeb32c3_0[c34ccaf0.byte_4].f939861c();
		if ((b & c34ccaf0.byte_9) != 0)
		{
			float f = feeb32c4.method_5();
			if (float.IsNaN(f) || float.IsInfinity(f))
			{
				throw new ArithmeticException();
			}
		}
		else
		{
			double d = feeb32c4.method_3();
			if (double.IsNaN(d) || double.IsInfinity(d))
			{
				throw new ArithmeticException();
			}
		}
		class54_0.class55_0.method_1(num);
		class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(num);
		a0aa499b_0 = (a0aa499b)0;
	}
}
