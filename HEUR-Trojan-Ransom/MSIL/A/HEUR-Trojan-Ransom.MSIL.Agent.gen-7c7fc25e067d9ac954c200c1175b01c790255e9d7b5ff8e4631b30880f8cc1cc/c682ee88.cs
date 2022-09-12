using System.Runtime.CompilerServices;

internal class c682ee88 : Interface1
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.byte_40;
	}

	public void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint num = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		feeb32c3 feeb32c4 = class54_0.class55_0.ff4c393f(num - 1);
		feeb32c3 feeb32c5 = class54_0.class55_0.ff4c393f(num);
		num--;
		class54_0.class55_0.method_1(num);
		class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(num);
		byte b = class54_0.feeb32c3_0[c34ccaf0.byte_4].f939861c();
		feeb32c3 feeb32c3_ = default(feeb32c3);
		ulong num2 = feeb32c4.method_0() * feeb32c5.method_0();
		feeb32c3_.method_1((uint)num2);
		class54_0.class55_0.method_0(num, feeb32c3_);
		byte byte_ = (byte)(c34ccaf0.d094b329 | c34ccaf0.byte_8 | c34ccaf0.byte_9);
		byte b2 = (byte)(c34ccaf0.byte_7 | c34ccaf0.b9f4359f);
		byte b3 = 0;
		if ((b & c34ccaf0.byte_9) != 0)
		{
			if ((num2 & 0xFFFFFFFFL) > 0L)
			{
				b3 = b2;
			}
		}
		else
		{
			num2 = (ulong)(int)(feeb32c4.method_0() * feeb32c5.method_0());
			if (num2 >> 63 != feeb32c3_.method_0() >> 31)
			{
				b3 = b2;
			}
		}
		b = (byte)((b & ~b2) | b3);
		b23ec9a0.e2d89109(feeb32c4.method_0(), feeb32c5.method_0(), feeb32c3_.method_0(), feeb32c3_.method_0(), ref b, byte_);
		class54_0.feeb32c3_0[c34ccaf0.byte_4].e885eacb(b);
		a0aa499b_0 = (a0aa499b)0;
	}
}
