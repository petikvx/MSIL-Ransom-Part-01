using System.Runtime.CompilerServices;

internal class cfccde1e : Interface0
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.byte_48;
	}

	public void imethod_0(Class62 class62_0, out Enum1 enum1_0)
	{
		uint uint_ = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
		ebd9b488 ebd9b488_ = class62_0.class64_0.method_0(uint_);
		double num = ebd9b488_.b9f576cf();
		ebd9b488_.eca936fa((ulong)(long)num);
		byte b7500187 = (byte)(class62_0.ebd9b488_0[Class69.byte_6].fc52add5() & ~Class69.byte_10);
		if ((b7500187 & Class69.byte_11) != 0)
		{
			if (!(num > -1.0) || !(num < 1.8446744073709552E+19))
			{
				b7500187 = (byte)(b7500187 | Class69.byte_10);
			}
			if (!(num < 9.223372036854776E+18))
			{
				ebd9b488_.eca936fa((ulong)((double)(long)num - 9.223372036854776E+18) + 9223372036854775808uL);
			}
		}
		else if (!(num > -9.223372036854778E+18) || !(num < 9.223372036854776E+18))
		{
			b7500187 = (byte)(b7500187 | Class69.byte_10);
		}
		class62_0.ebd9b488_0[Class69.byte_6].f7b1a530((byte)(b7500187 & ~Class69.byte_11));
		class62_0.class64_0.method_1(uint_, ebd9b488_);
		enum1_0 = (Enum1)0;
	}
}
