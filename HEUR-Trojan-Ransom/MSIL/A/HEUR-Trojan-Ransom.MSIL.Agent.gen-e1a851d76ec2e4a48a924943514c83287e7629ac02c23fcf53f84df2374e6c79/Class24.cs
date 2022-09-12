using System.Runtime.CompilerServices;

internal class Class24 : Interface0
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.ca8a60ba;
	}

	public void imethod_0(Class62 class62_0, out Enum1 enum1_0)
	{
		uint uint_ = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
		ebd9b488 ebd9b488_ = class62_0.class64_0.method_0(uint_);
		byte b7500187 = class62_0.ebd9b488_0[Class69.byte_6].fc52add5();
		if ((b7500187 & Class69.byte_11) != 0)
		{
			ebd9b488_.method_2(ebd9b488_.method_0());
		}
		else
		{
			ebd9b488_.method_2((long)ebd9b488_.method_0());
		}
		class62_0.ebd9b488_0[Class69.byte_6].f7b1a530((byte)(b7500187 & ~Class69.byte_11));
		class62_0.class64_0.method_1(uint_, ebd9b488_);
		enum1_0 = (Enum1)0;
	}
}
