using System.Runtime.CompilerServices;

internal class df65a7a : efe82791
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.e63eff8;
	}

	public void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint uint_ = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		Struct2 struct2_ = class49_0.ec45936d.a59d7f30(uint_);
		double num = struct2_.ceea355b();
		struct2_.method_1((ulong)(long)num);
		byte b = (byte)(class49_0.struct2_0[cb1fcba5.c456c371].method_4() & ~cb1fcba5.b3f8ed10);
		if ((b & cb1fcba5.d5710944) != 0)
		{
			if (!(num > -1.0) || !(num < 1.8446744073709552E+19))
			{
				b = (byte)(b | cb1fcba5.b3f8ed10);
			}
			if (!(num < 9.223372036854776E+18))
			{
				struct2_.method_1((ulong)((double)(long)num - 9.223372036854776E+18) + 9223372036854775808uL);
			}
		}
		else if (!(num > -9.223372036854778E+18) || !(num < 9.223372036854776E+18))
		{
			b = (byte)(b | cb1fcba5.b3f8ed10);
		}
		class49_0.struct2_0[cb1fcba5.c456c371].dc0866ec((byte)(b & ~cb1fcba5.d5710944));
		class49_0.ec45936d.d1cb88cf(uint_, struct2_);
		enum1_0 = (Enum1)0;
	}
}
