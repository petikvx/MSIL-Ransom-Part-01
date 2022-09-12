using System;
using System.Runtime.CompilerServices;

internal class ee7e4fb8 : bae6a63f
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.byte_55;
	}

	public void imethod_0(Class62 class62_0, out Enum1 enum1_0)
	{
		uint num = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
		if (class62_0.class64_0.method_0(num--).b585a11() != 0)
		{
			throw new OverflowException();
		}
		class62_0.class64_0.method_2(num);
		class62_0.ebd9b488_0[Class69.byte_4].cf774c3c(num);
		enum1_0 = (Enum1)0;
	}
}
