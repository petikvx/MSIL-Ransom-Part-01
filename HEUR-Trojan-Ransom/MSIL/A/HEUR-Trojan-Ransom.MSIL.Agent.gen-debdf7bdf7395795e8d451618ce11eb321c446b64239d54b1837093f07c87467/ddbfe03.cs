using System.Runtime.CompilerServices;

internal class ddbfe03 : efe82791
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.byte_24;
	}

	public void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint num = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		class49_0.ec45936d.method_0(++num);
		class49_0.struct2_0[cb1fcba5.byte_8].c85fac38(num);
		ulong num2 = class49_0.method_0();
		num2 |= (ulong)class49_0.method_0() << 8;
		num2 |= (ulong)class49_0.method_0() << 16;
		num2 |= (ulong)class49_0.method_0() << 24;
		ulong num3 = (((num2 & 0x80000000L) != 0L) ? 18446744069414584320uL : 0uL);
		a5c16fd5 ec45936d = class49_0.ec45936d;
		uint uint_ = num;
		Struct2 struct2_ = default(Struct2);
		struct2_.method_1(num3 | num2);
		ec45936d.d1cb88cf(uint_, struct2_);
		enum1_0 = (Enum1)0;
	}
}
