using System;
using System.Runtime.CompilerServices;

internal class ba1b63c0 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.byte_61;
	}

	public void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint num = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		Struct2 @struct = class49_0.ec45936d.a59d7f30(num--);
		Struct2 struct2_ = class49_0.ec45936d.a59d7f30(num);
		Type type = (Type)class49_0.class2_0.c73a3276().a9b0159f(@struct.method_2());
		if (Type.GetTypeCode(type) == TypeCode.String && struct2_.method_6() == null)
		{
			struct2_.method_7(class49_0.class2_0.c73a3276().method_3(struct2_.method_2()));
		}
		else
		{
			struct2_.method_7(struct2_.method_8(type));
		}
		class49_0.ec45936d.d1cb88cf(num, struct2_);
		class49_0.ec45936d.method_0(num);
		class49_0.struct2_0[cb1fcba5.byte_8].c85fac38(num);
		enum1_0 = (Enum1)0;
	}
}
