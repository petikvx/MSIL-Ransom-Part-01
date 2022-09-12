using System.Runtime.CompilerServices;

internal class b87feec9 : efe82791
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.b2d468e7;
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
		struct2_.d22692e0(@struct.e4021645() / struct2.e4021645());
		class49_0.ec45936d.d1cb88cf(num, struct2_);
		byte b = (byte)(cb1fcba5.d75668c2 | cb1fcba5.d4819139);
		byte b2 = (byte)(class49_0.struct2_0[cb1fcba5.c456c371].method_4() & ~b);
		if (struct2_.e4021645() == 0f)
		{
			b2 = (byte)(b2 | cb1fcba5.d75668c2);
		}
		else if (struct2_.e4021645() < 0f)
		{
			b2 = (byte)(b2 | cb1fcba5.d4819139);
		}
		class49_0.struct2_0[cb1fcba5.c456c371].dc0866ec(b2);
		enum1_0 = (Enum1)0;
	}
}
