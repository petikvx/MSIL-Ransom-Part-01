using System.Runtime.CompilerServices;

internal class eaebf6fd : Interface1
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.f692b2ad;
	}

	public void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint uint_ = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		feeb32c3 feeb32c3_ = class54_0.class55_0.ff4c393f(uint_);
		byte b = class54_0.feeb32c3_0[c34ccaf0.byte_4].f939861c();
		if ((b & c34ccaf0.byte_9) != 0)
		{
			feeb32c3_.method_4(feeb32c3_.d9a53946());
		}
		else
		{
			feeb32c3_.method_4((long)feeb32c3_.d9a53946());
		}
		class54_0.feeb32c3_0[c34ccaf0.byte_4].e885eacb((byte)(b & ~c34ccaf0.byte_9));
		class54_0.class55_0.method_0(uint_, feeb32c3_);
		a0aa499b_0 = (a0aa499b)0;
	}
}
