using System.Runtime.CompilerServices;

internal class Class32 : Interface1
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.byte_20;
	}

	public void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint num = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		feeb32c3 feeb32c4 = class54_0.class55_0.ff4c393f(num);
		class54_0.class55_0.method_1(--num);
		class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(num);
		byte b = class54_0.method_0();
		if ((b == c34ccaf0.byte_3 || b == c34ccaf0.d51d7317) && feeb32c4.cc3408c2() is d6c76087)
		{
			feeb32c3[] feeb32c3_ = class54_0.feeb32c3_0;
			feeb32c3 feeb32c5 = default(feeb32c3);
			feeb32c5.method_1(((d6c76087)feeb32c4.cc3408c2()).method_0());
			feeb32c3_[b] = feeb32c5;
		}
		else
		{
			class54_0.feeb32c3_0[b] = feeb32c4;
		}
		a0aa499b_0 = (a0aa499b)0;
	}
}
