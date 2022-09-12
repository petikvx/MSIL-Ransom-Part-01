using System.Runtime.CompilerServices;

internal class c48263eb : efe82791
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.byte_33;
	}

	public void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint num = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		Struct2 @struct = class49_0.ec45936d.a59d7f30(num);
		Struct2 struct2 = class49_0.ec45936d.a59d7f30(num - 1);
		num -= 2;
		class49_0.ec45936d.method_0(num);
		class49_0.struct2_0[cb1fcba5.byte_8].c85fac38(num);
		if (struct2.method_0() == 0L)
		{
			class49_0.struct2_0[cb1fcba5.byte_9].method_1(@struct.method_0());
		}
		enum1_0 = (Enum1)0;
	}
}
