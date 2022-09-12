using System;
using System.Runtime.CompilerServices;

internal class b89e3a16 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.byte_62;
	}

	public unsafe void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint num = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		Struct2 @struct = class49_0.ec45936d.a59d7f30(num--);
		Struct2 struct2 = class49_0.ec45936d.a59d7f30(num);
		bool flag = (@struct.method_2() & 0x80000000u) != 0;
		Type type = (Type)class49_0.class2_0.c73a3276().a9b0159f(@struct.method_2() & 0x7FFFFFFFu);
		if (flag)
		{
			TypedReference typedReference_ = default(TypedReference);
			Class55.smethod_0(struct2.method_6(), fe387972.smethod_0(&typedReference_));
			new c53b644c(typedReference_);
			struct2 = Struct2.a5dd3349(struct2.method_6(), type);
			class49_0.ec45936d.d1cb88cf(num, struct2);
		}
		else
		{
			if ((object)type == typeof(object) && struct2.method_6() != null)
			{
				type = struct2.method_6().GetType();
			}
			struct2 = Struct2.a5dd3349(struct2.method_6(), type);
			class49_0.ec45936d.d1cb88cf(num, struct2);
		}
		class49_0.ec45936d.method_0(num);
		class49_0.struct2_0[cb1fcba5.byte_8].c85fac38(num);
		enum1_0 = (Enum1)0;
	}
}
