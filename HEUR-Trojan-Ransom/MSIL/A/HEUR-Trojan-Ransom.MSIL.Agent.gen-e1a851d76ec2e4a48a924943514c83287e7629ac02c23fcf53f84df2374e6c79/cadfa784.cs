using System.Runtime.CompilerServices;

internal class cadfa784 : Interface0
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.byte_21;
	}

	public void imethod_0(Class62 class62_0, out Enum1 enum1_0)
	{
		uint num = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
		class62_0.class64_0.method_2(++num);
		byte b7500187 = class62_0.method_0();
		ebd9b488 ebd9b489 = class62_0.ebd9b488_0[b7500187];
		Class64 class64_ = class62_0.class64_0;
		uint uint_ = num;
		ebd9b488 ebd9b488_ = default(ebd9b488);
		ebd9b488_.f7b1a530(ebd9b489.fc52add5());
		class64_.method_1(uint_, ebd9b488_);
		class62_0.ebd9b488_0[Class69.byte_4].cf774c3c(num);
		enum1_0 = (Enum1)0;
	}
}
