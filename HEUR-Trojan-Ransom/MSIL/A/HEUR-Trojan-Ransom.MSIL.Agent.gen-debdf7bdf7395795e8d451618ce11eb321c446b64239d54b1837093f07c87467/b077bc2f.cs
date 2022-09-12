using System.Runtime.CompilerServices;

internal class b077bc2f : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.byte_57;
	}

	public void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint num = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		Struct2 struct2_ = class49_0.ec45936d.a59d7f30(num--);
		Struct2 @struct = class49_0.ec45936d.a59d7f30(num--);
		Struct2 struct2 = class49_0.ec45936d.a59d7f30(num);
		struct2_.method_1(((long)struct2_.method_0() > (long)@struct.method_0() || (long)struct2_.method_0() < (long)struct2.method_0()) ? 1u : 0u);
		class49_0.ec45936d.d1cb88cf(num, struct2_);
		class49_0.ec45936d.method_0(num);
		class49_0.struct2_0[cb1fcba5.byte_8].c85fac38(num);
		enum1_0 = (Enum1)0;
	}
}
