using System.Runtime.CompilerServices;

internal class ba9d5d9d : efe82791
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.byte_40;
	}

	public void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint num = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		Struct2 @struct = class49_0.ec45936d.a59d7f30(num - 1);
		Struct2 struct2 = class49_0.ec45936d.a59d7f30(num);
		num--;
		class49_0.ec45936d.method_0(num);
		class49_0.struct2_0[cb1fcba5.byte_8].c85fac38(num);
		byte b = class49_0.struct2_0[cb1fcba5.c456c371].method_4();
		Struct2 struct2_ = default(Struct2);
		ulong num2 = @struct.method_2() * struct2.method_2();
		struct2_.c85fac38((uint)num2);
		class49_0.ec45936d.d1cb88cf(num, struct2_);
		byte byte_ = (byte)(cb1fcba5.d75668c2 | cb1fcba5.d4819139 | cb1fcba5.d5710944);
		byte b2 = (byte)(cb1fcba5.b5175d2f | cb1fcba5.b3f8ed10);
		byte b3 = 0;
		if ((b & cb1fcba5.d5710944) != 0)
		{
			if ((num2 & 0xFFFFFFFFL) > 0L)
			{
				b3 = b2;
			}
		}
		else
		{
			num2 = (ulong)(int)(@struct.method_2() * struct2.method_2());
			if (num2 >> 63 != struct2_.method_2() >> 31)
			{
				b3 = b2;
			}
		}
		b = (byte)((b & ~b2) | b3);
		Class1.smethod_1(@struct.method_2(), struct2.method_2(), struct2_.method_2(), struct2_.method_2(), ref b, byte_);
		class49_0.struct2_0[cb1fcba5.c456c371].dc0866ec(b);
		enum1_0 = (Enum1)0;
	}
}
