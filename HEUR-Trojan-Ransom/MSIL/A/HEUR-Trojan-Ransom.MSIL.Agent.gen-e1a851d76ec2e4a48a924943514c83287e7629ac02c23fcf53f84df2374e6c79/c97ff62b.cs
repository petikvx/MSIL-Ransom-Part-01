using System.Runtime.CompilerServices;

internal class c97ff62b : Interface0
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.byte_26;
	}

	public void imethod_0(Class62 class62_0, out Enum1 enum1_0)
	{
		uint uint_ = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
		ebd9b488 ebd9b488_ = class62_0.class64_0.method_0(uint_);
		if ((ebd9b488_.bfb9ba6b() & 0x8000u) != 0)
		{
			ebd9b488_.cf774c3c(ebd9b488_.bfb9ba6b() | 0xFFFF0000u);
		}
		class62_0.class64_0.method_1(uint_, ebd9b488_);
		enum1_0 = (Enum1)0;
	}
}
