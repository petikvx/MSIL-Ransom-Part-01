using System.Runtime.CompilerServices;

internal class ccd68591 : Interface0
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.byte_35;
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
		if (ebd9b489.ec0d6773() is Interface1)
		{
			ebd9b488_.aa900636(((Interface1)ebd9b489.ec0d6773()).imethod_1(ebd9b490.b585a11()));
		}
		else if (ebd9b490.ec0d6773() is Interface1)
		{
			ebd9b488_.aa900636(((Interface1)ebd9b490.ec0d6773()).imethod_1(ebd9b489.b585a11()));
		}
		else
		{
			ebd9b488_.cf774c3c(ebd9b490.b585a11() + ebd9b489.b585a11());
		}
		class62_0.class64_0.method_1(num, ebd9b488_);
		byte byte_ = (byte)(Class69.cf427ee6 | Class69.a5d5090d | Class69.byte_10 | Class69.bce0c6e3);
		byte byte_2 = class62_0.ebd9b488_0[Class69.byte_6].fc52add5();
		Class1.d4c25246(ebd9b489.b585a11(), ebd9b490.b585a11(), ebd9b488_.b585a11(), ebd9b488_.b585a11(), ref byte_2, byte_);
		class62_0.ebd9b488_0[Class69.byte_6].f7b1a530(byte_2);
		enum1_0 = (Enum1)0;
	}
}
