using System.Runtime.CompilerServices;

internal class a898ea1d : Interface1
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.e385a65b;
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
		num2 |= (ulong)class54_0.method_0() << 32;
		num2 |= (ulong)class54_0.method_0() << 40;
		num2 |= (ulong)class54_0.method_0() << 48;
		num2 |= (ulong)class54_0.method_0() << 56;
		Class55 class55_ = class54_0.class55_0;
		uint uint_ = num;
		feeb32c3 feeb32c3_ = default(feeb32c3);
		feeb32c3_.b67abfed(num2);
		class55_.method_0(uint_, feeb32c3_);
		a0aa499b_0 = (a0aa499b)0;
	}
}
