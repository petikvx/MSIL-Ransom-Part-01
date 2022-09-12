using System;
using System.Runtime.CompilerServices;

internal class Class6 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.e0568248;
	}

	public void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint uint_ = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		class49_0.struct2_0[cb1fcba5.byte_7].method_2();
		Type type_ = (Type)class49_0.class2_0.c73a3276().a9b0159f(class49_0.ec45936d.a59d7f30(uint_).method_2());
		a5c16fd5 ec45936d = class49_0.ec45936d;
		Struct2 struct2_ = default(Struct2);
		struct2_.c85fac38((uint)Class54.smethod_0(type_));
		ec45936d.d1cb88cf(uint_, struct2_);
		enum1_0 = (Enum1)0;
	}
}
