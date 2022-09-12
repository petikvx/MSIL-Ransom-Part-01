using System.Runtime.CompilerServices;

internal class Class40 : Interface0
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.byte_23;
	}

	public void imethod_0(Class62 class62_0, out Enum1 enum1_0)
	{
		uint num = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
		class62_0.class64_0.method_2(++num);
		byte b7500187 = class62_0.method_0();
		ebd9b488 ebd9b489 = class62_0.ebd9b488_0[b7500187];
		if (b7500187 == Class69.byte_4 || b7500187 == Class69.ad8cd76c)
		{
			Class64 class64_ = class62_0.class64_0;
			uint uint_ = num;
			ebd9b488 ebd9b488_ = default(ebd9b488);
			ebd9b488_.aa900636(new Class61(ebd9b489.b585a11()));
			class64_.method_1(uint_, ebd9b488_);
		}
		else
		{
			Class64 class64_2 = class62_0.class64_0;
			uint uint_2 = num;
			ebd9b488 ebd9b488_ = default(ebd9b488);
			ebd9b488_.cf774c3c(ebd9b489.b585a11());
			class64_2.method_1(uint_2, ebd9b488_);
		}
		class62_0.ebd9b488_0[Class69.byte_4].cf774c3c(num);
		enum1_0 = (Enum1)0;
	}
}
