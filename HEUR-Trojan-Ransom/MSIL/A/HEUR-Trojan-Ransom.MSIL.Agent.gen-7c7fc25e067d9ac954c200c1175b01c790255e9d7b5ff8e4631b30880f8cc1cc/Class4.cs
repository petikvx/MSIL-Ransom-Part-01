using System;
using System.Runtime.CompilerServices;

internal class Class4 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.bf990a82;
	}

	public void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint num = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		if (class54_0.class55_0.ff4c393f(num--).method_0() != 0)
		{
			throw new OverflowException();
		}
		class54_0.class55_0.method_1(num);
		class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(num);
		a0aa499b_0 = (a0aa499b)0;
	}
}
