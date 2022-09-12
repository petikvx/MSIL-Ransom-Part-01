using System;
using System.Runtime.CompilerServices;

internal class dacfe941 : efe82791
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.byte_51;
	}

	public void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint num = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		byte b = class49_0.ec45936d.a59d7f30(num--).method_4();
		Struct0 item = default(Struct0);
		item.byte_0 = b;
		if (b == cb1fcba5.byte_66)
		{
			item.f3e0d07f = (Type)class49_0.class2_0.c73a3276().a9b0159f(class49_0.ec45936d.a59d7f30(num--).method_2());
		}
		else if (b == cb1fcba5.byte_67)
		{
			item.beef1805 = class49_0.ec45936d.a59d7f30(num--).method_0();
		}
		item.ulong_0 = class49_0.ec45936d.a59d7f30(num--).method_0();
		class49_0.ec45936d.method_0(num);
		class49_0.struct2_0[cb1fcba5.byte_8].c85fac38(num);
		item.struct2_0 = class49_0.struct2_0[cb1fcba5.byte_7];
		item.struct2_1 = class49_0.struct2_0[cb1fcba5.byte_8];
		class49_0.list_0.Add(item);
		enum1_0 = (Enum1)0;
	}
}
