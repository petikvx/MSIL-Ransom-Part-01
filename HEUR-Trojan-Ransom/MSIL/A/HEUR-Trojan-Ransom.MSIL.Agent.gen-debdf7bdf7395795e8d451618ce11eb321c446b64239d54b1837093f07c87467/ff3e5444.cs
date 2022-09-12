using System.Runtime.CompilerServices;

internal class ff3e5444 : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.f431114d;
	}

	public void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint uint_ = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		uint num = class49_0.ec45936d.a59d7f30(uint_--).method_2();
		class49_0.struct2_0[cb1fcba5.byte_8].c85fac38(uint_);
		if (num == 1)
		{
			enum1_0 = (Enum1)3;
		}
		else
		{
			enum1_0 = (Enum1)2;
		}
	}
}
