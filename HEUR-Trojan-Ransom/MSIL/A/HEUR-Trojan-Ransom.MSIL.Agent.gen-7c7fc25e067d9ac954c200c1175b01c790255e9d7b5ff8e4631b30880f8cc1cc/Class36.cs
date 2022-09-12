using System.Runtime.CompilerServices;

internal class Class36 : Interface1
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.byte_25;
	}

	public void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint num = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		class54_0.class55_0.method_1(++num);
		class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(num);
		ulong num2 = class54_0.method_0();
		num2 |= (ulong)class54_0.method_0() << 8;
		num2 |= (ulong)class54_0.method_0() << 16;
		num2 |= (ulong)class54_0.method_0() << 24;
		ulong num3 = (((num2 & 0x80000000L) != 0L) ? 18446744069414584320uL : 0uL);
		Class55 class55_ = class54_0.class55_0;
		uint uint_ = num;
		feeb32c3 feeb32c3_ = default(feeb32c3);
		feeb32c3_.b67abfed(num3 | num2);
		class55_.method_0(uint_, feeb32c3_);
		a0aa499b_0 = (a0aa499b)0;
	}
}
