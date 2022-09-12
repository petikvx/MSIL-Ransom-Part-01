using System.Runtime.CompilerServices;

internal class Class26 : efe82791
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.byte_42;
	}

	public void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint num = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		Struct2 @struct = class49_0.ec45936d.a59d7f30(num - 1);
		Struct2 struct2 = class49_0.ec45936d.a59d7f30(num);
		num--;
		class49_0.ec45936d.method_0(num);
		class49_0.struct2_0[cb1fcba5.byte_8].c85fac38(num);
		Struct2 struct2_ = default(Struct2);
		struct2_.method_5(struct2.ceea355b() * @struct.ceea355b());
		class49_0.ec45936d.d1cb88cf(num, struct2_);
		byte b = (byte)(cb1fcba5.d75668c2 | cb1fcba5.d4819139 | cb1fcba5.d5710944);
		byte b2 = (byte)(class49_0.struct2_0[cb1fcba5.c456c371].method_4() & ~b);
		if (struct2_.ceea355b() == 0.0)
		{
			b2 = (byte)(b2 | cb1fcba5.d75668c2);
		}
		else if (struct2_.ceea355b() < 0.0)
		{
			b2 = (byte)(b2 | cb1fcba5.d4819139);
		}
		class49_0.struct2_0[cb1fcba5.c456c371].dc0866ec(b2);
		enum1_0 = (Enum1)0;
	}
}
