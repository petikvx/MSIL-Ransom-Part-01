using System.Runtime.CompilerServices;

internal class b233c867 : Interface1
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.byte_28;
	}

	public void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint uint_ = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		feeb32c3 feeb32c3_ = class54_0.class55_0.ff4c393f(uint_);
		if ((feeb32c3_.method_0() & 0x80000000u) != 0)
		{
			feeb32c3_.b67abfed(0xFFFFFFFF00000000uL | feeb32c3_.method_0());
		}
		class54_0.class55_0.method_0(uint_, feeb32c3_);
		a0aa499b_0 = (a0aa499b)0;
	}
}
