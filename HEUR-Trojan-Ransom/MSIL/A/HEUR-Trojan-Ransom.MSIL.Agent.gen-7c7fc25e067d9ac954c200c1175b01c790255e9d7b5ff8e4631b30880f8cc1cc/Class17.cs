using System.Runtime.CompilerServices;

internal class Class17 : Interface1
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.byte_31;
	}

	public void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint num = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		feeb32c3 feeb32c4 = class54_0.class55_0.ff4c393f(num - 1);
		feeb32c3 feeb32c5 = class54_0.class55_0.ff4c393f(num);
		num -= 2;
		class54_0.class55_0.method_1(num);
		class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(num);
		int num2 = ((feeb32c4.cc3408c2() != feeb32c5.cc3408c2()) ? (-1) : 0);
		byte b = (byte)(c34ccaf0.d094b329 | c34ccaf0.byte_8 | c34ccaf0.b9f4359f | c34ccaf0.byte_7);
		byte b2 = (byte)(class54_0.feeb32c3_0[c34ccaf0.byte_4].f939861c() & ~b);
		if (num2 == 0)
		{
			b2 = (byte)(b2 | c34ccaf0.d094b329);
		}
		else if (num2 < 0)
		{
			b2 = (byte)(b2 | c34ccaf0.byte_8);
		}
		class54_0.feeb32c3_0[c34ccaf0.byte_4].e885eacb(b2);
		a0aa499b_0 = (a0aa499b)0;
	}
}
