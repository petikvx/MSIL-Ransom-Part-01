using System.Runtime.CompilerServices;

internal class Class22 : Interface1
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.a7f7f428;
	}

	public void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint uint_ = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		feeb32c3 feeb32c3_ = class54_0.class55_0.ff4c393f(uint_);
		byte b = (byte)(class54_0.feeb32c3_0[c34ccaf0.byte_4].f939861c() & ~c34ccaf0.b9f4359f);
		if (!Class0.bool_0 && feeb32c3_.d9a53946() >> 32 > 0L)
		{
			b = (byte)(b | c34ccaf0.b9f4359f);
		}
		class54_0.feeb32c3_0[c34ccaf0.byte_4].e885eacb(b);
		class54_0.class55_0.method_0(uint_, feeb32c3_);
		a0aa499b_0 = (a0aa499b)0;
	}
}
