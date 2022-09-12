using System.Runtime.CompilerServices;

internal class b027ebf0 : Interface0
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.d728872b;
	}

	public void imethod_0(Class62 class62_0, out Enum1 enum1_0)
	{
		uint num = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
		ebd9b488 ebd9b489 = class62_0.class64_0.method_0(num);
		class62_0.class64_0.method_2(--num);
		class62_0.ebd9b488_0[Class69.byte_4].cf774c3c(num);
		bae6a63f bae6a63f2 = ffe2462e.smethod_0(ebd9b489.fc52add5());
		bae6a63f2.imethod_0(class62_0, out enum1_0);
	}
}
