using System.Runtime.CompilerServices;

internal class eb3f1d5c : Interface0
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.byte_50;
	}

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint uint_ = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		Struct3 struct3_ = fdc40966_0.class58_0.method_0(uint_);
		double num = struct3_.ff1d6065();
		struct3_.method_0((ulong)(long)num);
		byte b = (byte)(fdc40966_0.struct3_0[fb3c043f.b15a6feb].method_3() & ~fb3c043f.byte_9);
		if ((b & fb3c043f.byte_12) != 0)
		{
			if (!(num > -1.0) || !(num < 1.8446744073709552E+19))
			{
				b = (byte)(b | fb3c043f.byte_9);
			}
			if (!(num < 9.223372036854776E+18))
			{
				struct3_.method_0((ulong)((double)(long)num - 9.223372036854776E+18) + 9223372036854775808uL);
			}
		}
		else if (!(num > -9.223372036854778E+18) || !(num < 9.223372036854776E+18))
		{
			b = (byte)(b | fb3c043f.byte_9);
		}
		fdc40966_0.struct3_0[fb3c043f.b15a6feb].method_4((byte)(b & ~fb3c043f.byte_12));
		fdc40966_0.class58_0.b53f41f9(uint_, struct3_);
		enum0_0 = (Enum0)0;
	}
}
