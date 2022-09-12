using System.Runtime.CompilerServices;

internal class d3478cb9 : Interface1
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.e82b6357;
	}

	public void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint num = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		feeb32c3 feeb32c4 = class54_0.class55_0.ff4c393f(num - 1);
		feeb32c3 feeb32c5 = class54_0.class55_0.ff4c393f(num);
		num--;
		class54_0.class55_0.method_1(num);
		class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(num);
		byte byte_ = class54_0.feeb32c3_0[c34ccaf0.byte_4].f939861c();
		feeb32c3 feeb32c3_ = default(feeb32c3);
		if ((byte_ & c34ccaf0.byte_9) != 0)
		{
			feeb32c3_.b67abfed(feeb32c4.d9a53946() / feeb32c5.d9a53946());
		}
		else
		{
			feeb32c3_.b67abfed((uint)((int)feeb32c4.d9a53946() / (int)feeb32c5.d9a53946()));
		}
		class54_0.class55_0.method_0(num, feeb32c3_);
		byte byte_2 = (byte)(c34ccaf0.d094b329 | c34ccaf0.byte_8 | c34ccaf0.byte_9);
		b23ec9a0.e2d89109(feeb32c4.d9a53946(), feeb32c5.d9a53946(), feeb32c3_.d9a53946(), feeb32c3_.d9a53946(), ref byte_, byte_2);
		class54_0.feeb32c3_0[c34ccaf0.byte_4].e885eacb(byte_);
		a0aa499b_0 = (a0aa499b)0;
	}
}
