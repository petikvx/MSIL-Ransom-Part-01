using System;
using System.Runtime.CompilerServices;

internal class Class3 : d88be11e
{
	[SpecialName]
	public byte b4b1262()
	{
		return b13312b0.byte_64;
	}

	public void df3f437a(Class58 class58_0, out Enum0 enum0_0)
	{
		uint uint_ = class58_0.a6890f1d[b13312b0.byte_7].df1ed028();
		facef383 facef384 = class58_0.c73f45d8.a9bb6dff(uint_--);
		byte b = class58_0.a6890f1d[b13312b0.a048350c].a42951dc();
		if ((b & b13312b0.byte_12) != 0)
		{
			float f = facef384.method_6();
			if (float.IsNaN(f) || float.IsInfinity(f))
			{
				throw new ArithmeticException();
			}
		}
		else
		{
			double d = facef384.method_5();
			if (double.IsNaN(d) || double.IsInfinity(d))
			{
				throw new ArithmeticException();
			}
		}
		class58_0.c73f45d8.a85b6a89(uint_);
		class58_0.a6890f1d[b13312b0.byte_7].method_2(uint_);
		enum0_0 = (Enum0)0;
	}
}
