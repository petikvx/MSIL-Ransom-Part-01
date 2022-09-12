using System.Runtime.CompilerServices;

internal class Class34 : Interface1
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.byte_24;
	}

	public void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint num = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		class54_0.class55_0.method_1(++num);
		byte b = class54_0.method_0();
		feeb32c3 feeb32c4 = class54_0.feeb32c3_0[b];
		Class55 class55_ = class54_0.class55_0;
		uint uint_ = num;
		feeb32c3 feeb32c3_ = default(feeb32c3);
		feeb32c3_.b67abfed(feeb32c4.d9a53946());
		class55_.method_0(uint_, feeb32c3_);
		class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(num);
		a0aa499b_0 = (a0aa499b)0;
	}
}
