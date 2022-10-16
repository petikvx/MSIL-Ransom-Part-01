using System.Runtime.CompilerServices;

internal class Class24 : df7d42ac
{
	[SpecialName]
	public byte b4b1262()
	{
		return b13312b0.byte_57;
	}

	public void df3f437a(Class58 class58_0, out Enum0 enum0_0)
	{
		uint uint_ = class58_0.a6890f1d[b13312b0.byte_7].df1ed028();
		facef383 facef383_ = class58_0.c73f45d8.a9bb6dff(uint_);
		double num = facef383_.method_5();
		facef383_.method_1((ulong)(long)num);
		byte b = (byte)(class58_0.a6890f1d[b13312b0.a048350c].a42951dc() & ~b13312b0.byte_11);
		if ((b & b13312b0.byte_12) != 0)
		{
			if (!(num > -1.0) || !(num < 1.8446744073709552E+19))
			{
				b = (byte)(b | b13312b0.byte_11);
			}
			if (!(num < 9.223372036854776E+18))
			{
				facef383_.method_1((ulong)((double)(long)num - 9.223372036854776E+18) + 9223372036854775808uL);
			}
		}
		else if (!(num > -9.223372036854778E+18) || !(num < 9.223372036854776E+18))
		{
			b = (byte)(b | b13312b0.byte_11);
		}
		class58_0.a6890f1d[b13312b0.a048350c].method_4((byte)(b & ~b13312b0.byte_12));
		class58_0.c73f45d8.method_0(uint_, facef383_);
		enum0_0 = (Enum0)0;
	}
}
