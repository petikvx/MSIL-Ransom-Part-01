using System.Runtime.CompilerServices;

internal class a427a8cf : Interface1
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.byte_21;
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
		feeb32c3_.e885eacb(feeb32c4.f939861c());
		class55_.method_0(uint_, feeb32c3_);
		class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(num);
		a0aa499b_0 = (a0aa499b)0;
	}
}
