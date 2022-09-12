using System.Runtime.CompilerServices;

internal class aa824b56 : Interface0
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.byte_20;
	}

	public void imethod_0(Class52 class52_0, out a82ced3b a82ced3b_0)
	{
		uint num = class52_0.struct2_0[fae0f10.byte_5].b5683088();
		class52_0.c6a36180_0.method_0(++num);
		class52_0.struct2_0[fae0f10.byte_5].b3579a47(num);
		ulong num2 = class52_0.method_0();
		num2 |= (ulong)class52_0.method_0() << 8;
		num2 |= (ulong)class52_0.method_0() << 16;
		num2 |= (ulong)class52_0.method_0() << 24;
		ulong num3 = (((num2 & 0x80000000L) != 0L) ? 18446744069414584320uL : 0uL);
		c6a36180 c6a36180_ = class52_0.c6a36180_0;
		uint uint_ = num;
		Struct2 struct2_ = default(Struct2);
		struct2_.f6b2288d(num3 | num2);
		c6a36180_.f43586b2(uint_, struct2_);
		a82ced3b_0 = (a82ced3b)0;
	}
}
