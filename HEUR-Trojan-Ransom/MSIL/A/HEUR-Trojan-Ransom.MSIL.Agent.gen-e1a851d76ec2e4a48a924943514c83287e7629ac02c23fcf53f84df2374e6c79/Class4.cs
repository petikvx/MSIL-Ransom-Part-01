using System;
using System.Runtime.CompilerServices;

internal class Class4 : bae6a63f
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.f6dbb24;
	}

	public void imethod_0(Class62 class62_0, out Enum1 enum1_0)
	{
		uint num = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
		ebd9b488 ebd9b489 = class62_0.class64_0.method_0(num--);
		byte b7500187 = class62_0.ebd9b488_0[Class69.byte_6].fc52add5();
		if ((b7500187 & Class69.byte_11) != 0)
		{
			float f90591 = ebd9b489.d755fbd9();
			if (float.IsNaN(f90591) || float.IsInfinity(f90591))
			{
				throw new ArithmeticException();
			}
		}
		else
		{
			double d4882091 = ebd9b489.b9f576cf();
			if (double.IsNaN(d4882091) || double.IsInfinity(d4882091))
			{
				throw new ArithmeticException();
			}
		}
		class62_0.class64_0.method_2(num);
		class62_0.ebd9b488_0[Class69.byte_4].cf774c3c(num);
		enum1_0 = (Enum1)0;
	}
}
