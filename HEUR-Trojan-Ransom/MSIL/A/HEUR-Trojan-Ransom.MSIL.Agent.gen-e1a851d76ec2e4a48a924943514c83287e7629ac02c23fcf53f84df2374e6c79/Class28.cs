using System.Runtime.CompilerServices;

internal class Class28 : Interface0
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.byte_32;
	}

	public void imethod_0(Class62 class62_0, out Enum1 enum1_0)
	{
		uint num = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
		ebd9b488 ebd9b489 = class62_0.class64_0.method_0(num);
		ebd9b488 ebd9b490 = class62_0.class64_0.method_0(num - 1);
		num -= 2;
		class62_0.class64_0.method_2(num);
		class62_0.ebd9b488_0[Class69.byte_4].cf774c3c(num);
		if (ebd9b490.method_0() == 0L)
		{
			class62_0.ebd9b488_0[Class69.byte_5].eca936fa(ebd9b489.method_0());
		}
		enum1_0 = (Enum1)0;
	}
}
