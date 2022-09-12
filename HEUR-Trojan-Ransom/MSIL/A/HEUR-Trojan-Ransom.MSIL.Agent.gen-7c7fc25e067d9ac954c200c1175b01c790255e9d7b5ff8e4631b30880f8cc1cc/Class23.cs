using System.Runtime.CompilerServices;

internal class Class23 : Interface1
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.byte_56;
	}

	public void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint uint_ = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		feeb32c3 feeb32c3_ = class54_0.class55_0.ff4c393f(uint_);
		double num = feeb32c3_.method_3();
		feeb32c3_.b67abfed((ulong)(long)num);
		byte b = (byte)(class54_0.feeb32c3_0[c34ccaf0.byte_4].f939861c() & ~c34ccaf0.b9f4359f);
		if ((b & c34ccaf0.byte_9) != 0)
		{
			if (!(num > -1.0) || !(num < 1.8446744073709552E+19))
			{
				b = (byte)(b | c34ccaf0.b9f4359f);
			}
			if (!(num < 9.223372036854776E+18))
			{
				feeb32c3_.b67abfed((ulong)((double)(long)num - 9.223372036854776E+18) + 9223372036854775808uL);
			}
		}
		else if (!(num > -9.223372036854778E+18) || !(num < 9.223372036854776E+18))
		{
			b = (byte)(b | c34ccaf0.b9f4359f);
		}
		class54_0.feeb32c3_0[c34ccaf0.byte_4].e885eacb((byte)(b & ~c34ccaf0.byte_9));
		class54_0.class55_0.method_0(uint_, feeb32c3_);
		a0aa499b_0 = (a0aa499b)0;
	}
}
