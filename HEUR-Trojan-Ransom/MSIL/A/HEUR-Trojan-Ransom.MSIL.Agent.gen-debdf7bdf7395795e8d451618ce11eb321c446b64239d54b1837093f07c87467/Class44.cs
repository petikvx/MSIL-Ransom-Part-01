using System.Runtime.CompilerServices;

internal class Class44 : efe82791
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.c0f74c55;
	}

	public void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint uint_ = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		Struct2 struct2_ = class49_0.ec45936d.a59d7f30(uint_);
		if ((struct2_.method_2() & 0x80000000u) != 0)
		{
			struct2_.method_1(0xFFFFFFFF00000000uL | struct2_.method_2());
		}
		class49_0.ec45936d.d1cb88cf(uint_, struct2_);
		enum1_0 = (Enum1)0;
	}
}
