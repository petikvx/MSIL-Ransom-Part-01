using System.Runtime.CompilerServices;

internal class bf9b2858 : Interface0
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.e76896be;
	}

	public void imethod_0(Class62 class62_0, out Enum1 enum1_0)
	{
		uint num = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
		ebd9b488 ebd9b489 = class62_0.class64_0.method_0(num - 1);
		ebd9b488 ebd9b490 = class62_0.class64_0.method_0(num);
		num--;
		class62_0.class64_0.method_2(num);
		class62_0.ebd9b488_0[Class69.byte_4].cf774c3c(num);
		ebd9b488 ebd9b488_ = default(ebd9b488);
		ebd9b488_.method_2(ebd9b489.b9f576cf() / ebd9b490.b9f576cf());
		class62_0.class64_0.method_1(num, ebd9b488_);
		byte b7500187 = (byte)(Class69.cf427ee6 | Class69.a5d5090d);
		byte b7500188 = (byte)(class62_0.ebd9b488_0[Class69.byte_6].fc52add5() & ~b7500187);
		if (ebd9b488_.b9f576cf() == 0.0)
		{
			b7500188 = (byte)(b7500188 | Class69.cf427ee6);
		}
		else if (ebd9b488_.b9f576cf() < 0.0)
		{
			b7500188 = (byte)(b7500188 | Class69.a5d5090d);
		}
		class62_0.ebd9b488_0[Class69.byte_6].f7b1a530(b7500188);
		enum1_0 = (Enum1)0;
	}
}
