using System.Runtime.CompilerServices;

internal class a7ee1972 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.f81647f9;
	}

	public void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint num = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		feeb32c3 feeb32c3_ = class54_0.class55_0.ff4c393f(num--);
		feeb32c3 feeb32c4 = class54_0.class55_0.ff4c393f(num--);
		feeb32c3 feeb32c5 = class54_0.class55_0.ff4c393f(num);
		feeb32c3_.b67abfed(((long)feeb32c3_.d9a53946() > (long)feeb32c4.d9a53946() || (long)feeb32c3_.d9a53946() < (long)feeb32c5.d9a53946()) ? 1u : 0u);
		class54_0.class55_0.method_0(num, feeb32c3_);
		class54_0.class55_0.method_1(num);
		class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(num);
		a0aa499b_0 = (a0aa499b)0;
	}
}
