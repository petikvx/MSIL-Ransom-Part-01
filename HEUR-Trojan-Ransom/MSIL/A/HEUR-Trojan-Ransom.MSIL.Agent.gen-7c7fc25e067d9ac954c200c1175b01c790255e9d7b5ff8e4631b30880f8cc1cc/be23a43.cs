using System.Runtime.CompilerServices;

internal class be23a43 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.d65c5278;
	}

	public void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint uint_ = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		uint num = class54_0.class55_0.ff4c393f(uint_--).method_0();
		class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(uint_);
		if (num == 1)
		{
			a0aa499b_0 = (a0aa499b)3;
		}
		else
		{
			a0aa499b_0 = (a0aa499b)2;
		}
	}
}
