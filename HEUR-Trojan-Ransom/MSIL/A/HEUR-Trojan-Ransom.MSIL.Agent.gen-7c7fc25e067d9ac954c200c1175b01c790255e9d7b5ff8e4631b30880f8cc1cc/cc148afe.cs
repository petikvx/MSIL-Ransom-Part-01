using System.Runtime.CompilerServices;

internal class cc148afe : Interface1
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.byte_34;
	}

	public void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint num = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		feeb32c3 feeb32c4 = class54_0.class55_0.ff4c393f(num);
		feeb32c3 feeb32c5 = class54_0.class55_0.ff4c393f(num - 1);
		num -= 2;
		class54_0.class55_0.method_1(num);
		class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(num);
		if (feeb32c5.d9a53946() == 0L)
		{
			class54_0.feeb32c3_0[c34ccaf0.cb256761].b67abfed(feeb32c4.d9a53946());
		}
		a0aa499b_0 = (a0aa499b)0;
	}
}
