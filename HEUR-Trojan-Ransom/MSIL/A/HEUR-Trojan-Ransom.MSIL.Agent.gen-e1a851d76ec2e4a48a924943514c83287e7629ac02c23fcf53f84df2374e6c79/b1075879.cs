using System.Runtime.CompilerServices;

internal class b1075879 : Interface0
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.byte_20;
	}

	public void imethod_0(Class62 class62_0, out Enum1 enum1_0)
	{
		uint num = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
		ebd9b488 ebd9b489 = class62_0.class64_0.method_0(num);
		class62_0.class64_0.method_2(--num);
		class62_0.ebd9b488_0[Class69.byte_4].cf774c3c(num);
		byte b7500187 = class62_0.method_0();
		if ((b7500187 == Class69.byte_4 || b7500187 == Class69.ad8cd76c) && ebd9b489.ec0d6773() is Class61)
		{
			ebd9b488[] ebd9b488_ = class62_0.ebd9b488_0;
			ebd9b488 ebd9b490 = default(ebd9b488);
			ebd9b490.cf774c3c(((Class61)ebd9b489.ec0d6773()).method_0());
			ebd9b488_[b7500187] = ebd9b490;
		}
		else
		{
			class62_0.ebd9b488_0[b7500187] = ebd9b489;
		}
		enum1_0 = (Enum1)0;
	}
}
