using System.Runtime.CompilerServices;

internal class f69eeca8 : efe82791
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.byte_45;
	}

	public void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint num = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		Struct2 @struct = class49_0.ec45936d.a59d7f30(num - 1);
		Struct2 struct2 = class49_0.ec45936d.a59d7f30(num);
		num--;
		class49_0.ec45936d.method_0(num);
		class49_0.struct2_0[cb1fcba5.byte_8].c85fac38(num);
		byte byte_ = class49_0.struct2_0[cb1fcba5.c456c371].method_4();
		Struct2 struct2_ = default(Struct2);
		if ((byte_ & cb1fcba5.d5710944) != 0)
		{
			struct2_.method_1(@struct.method_0() % struct2.method_0());
		}
		else
		{
			struct2_.method_1((ulong)((long)@struct.method_0() % (long)struct2.method_0()));
		}
		class49_0.ec45936d.d1cb88cf(num, struct2_);
		byte byte_2 = (byte)(cb1fcba5.d75668c2 | cb1fcba5.d4819139 | cb1fcba5.d5710944);
		Class1.smethod_2(@struct.method_0(), struct2.method_0(), struct2_.method_0(), struct2_.method_0(), ref byte_, byte_2);
		class49_0.struct2_0[cb1fcba5.c456c371].dc0866ec(byte_);
		enum1_0 = (Enum1)0;
	}
}
