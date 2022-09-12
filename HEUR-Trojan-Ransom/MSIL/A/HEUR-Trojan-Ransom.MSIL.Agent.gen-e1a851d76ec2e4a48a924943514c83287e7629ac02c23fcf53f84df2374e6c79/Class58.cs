using System.Runtime.CompilerServices;

internal class Class58 : Interface0
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.ed91cb5f;
	}

	public void imethod_0(Class62 class62_0, out Enum1 enum1_0)
	{
		uint uint_ = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
		ebd9b488 ebd9b488_ = class62_0.class64_0.method_0(uint_);
		if ((ebd9b488_.fc52add5() & 0x80u) != 0)
		{
			ebd9b488_.cf774c3c(ebd9b488_.fc52add5() | 0xFFFFFF00u);
		}
		class62_0.class64_0.method_1(uint_, ebd9b488_);
		enum1_0 = (Enum1)0;
	}
}
