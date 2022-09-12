using System.Runtime.CompilerServices;

internal class Class31 : efe82791
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.f944677a;
	}

	public void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint num = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		class49_0.ec45936d.method_0(++num);
		byte b = class49_0.method_0();
		Struct2 @struct = class49_0.struct2_0[b];
		a5c16fd5 ec45936d = class49_0.ec45936d;
		uint uint_ = num;
		Struct2 struct2_ = default(Struct2);
		struct2_.method_1(@struct.method_0());
		ec45936d.d1cb88cf(uint_, struct2_);
		class49_0.struct2_0[cb1fcba5.byte_8].c85fac38(num);
		enum1_0 = (Enum1)0;
	}
}
