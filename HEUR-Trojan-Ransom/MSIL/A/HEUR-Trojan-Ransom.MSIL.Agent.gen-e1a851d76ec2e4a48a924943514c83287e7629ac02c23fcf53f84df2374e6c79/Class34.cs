using System.Runtime.CompilerServices;

internal class Class34 : Interface0
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.ea4e02eb;
	}

	public unsafe void imethod_0(Class62 class62_0, out Enum1 enum1_0)
	{
		uint uint_ = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
		ebd9b488 ebd9b489 = class62_0.class64_0.method_0(uint_);
		ebd9b488 ebd9b488_;
		if (ebd9b489.ec0d6773() is Interface1)
		{
			ebd9b488_ = ((Interface1)ebd9b489.ec0d6773()).imethod_0(class62_0, Class0.e104f21f ? ((Enum2)3) : ((Enum2)2));
		}
		else if (Class0.e104f21f)
		{
			ulong* ptr = (ulong*)ebd9b489.method_0();
			ebd9b488 ebd9b490 = default(ebd9b488);
			ebd9b490.eca936fa(*ptr);
			ebd9b488_ = ebd9b490;
		}
		else
		{
			uint* ptr2 = (uint*)ebd9b489.method_0();
			ebd9b488 ebd9b490 = default(ebd9b488);
			ebd9b490.cf774c3c(*ptr2);
			ebd9b488_ = ebd9b490;
		}
		class62_0.class64_0.method_1(uint_, ebd9b488_);
		enum1_0 = (Enum1)0;
	}
}
