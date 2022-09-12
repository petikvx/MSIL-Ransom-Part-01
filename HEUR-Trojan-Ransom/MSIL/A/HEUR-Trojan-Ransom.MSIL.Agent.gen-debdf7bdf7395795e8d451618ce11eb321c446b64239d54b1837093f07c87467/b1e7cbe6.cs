using System.Runtime.CompilerServices;

internal class b1e7cbe6 : efe82791
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.b0713656;
	}

	public void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint uint_ = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		Struct2 struct2_ = class49_0.ec45936d.a59d7f30(uint_);
		byte b = class49_0.struct2_0[cb1fcba5.c456c371].method_4();
		if ((b & cb1fcba5.d5710944) != 0)
		{
			struct2_.method_5(struct2_.method_0());
		}
		else
		{
			struct2_.method_5((long)struct2_.method_0());
		}
		class49_0.struct2_0[cb1fcba5.c456c371].dc0866ec((byte)(b & ~cb1fcba5.d5710944));
		class49_0.ec45936d.d1cb88cf(uint_, struct2_);
		enum1_0 = (Enum1)0;
	}
}
