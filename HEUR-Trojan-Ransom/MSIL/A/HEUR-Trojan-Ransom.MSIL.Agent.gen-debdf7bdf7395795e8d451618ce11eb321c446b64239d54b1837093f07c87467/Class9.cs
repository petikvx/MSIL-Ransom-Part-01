using System.Runtime.CompilerServices;

internal class Class9 : efe82791
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.byte_35;
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
		if (@struct.method_6() is da5e0024)
		{
			struct2_.method_7(((da5e0024)@struct.method_6()).f4d9c5f0(struct2.method_2()));
		}
		else if (struct2.method_6() is da5e0024)
		{
			struct2_.method_7(((da5e0024)struct2.method_6()).f4d9c5f0(@struct.method_2()));
		}
		else
		{
			struct2_.c85fac38(struct2.method_2() + @struct.method_2());
		}
		class49_0.ec45936d.d1cb88cf(num, struct2_);
		byte byte_ = (byte)(cb1fcba5.d75668c2 | cb1fcba5.d4819139 | cb1fcba5.b3f8ed10 | cb1fcba5.b5175d2f);
		byte byte_2 = class49_0.struct2_0[cb1fcba5.c456c371].method_4();
		Class1.smethod_1(@struct.method_2(), struct2.method_2(), struct2_.method_2(), struct2_.method_2(), ref byte_2, byte_);
		class49_0.struct2_0[cb1fcba5.c456c371].dc0866ec(byte_2);
		enum1_0 = (Enum1)0;
	}
}
