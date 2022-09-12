using System.Runtime.CompilerServices;

internal class Class54 : Interface0
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.a7cb6059;
	}

	public unsafe void imethod_0(Class62 class62_0, out Enum1 enum1_0)
	{
		uint num = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
		ebd9b488 ebd9b489 = class62_0.class64_0.method_0(num--);
		ebd9b488 ebd9b488_ = class62_0.class64_0.method_0(num--);
		class62_0.class64_0.method_2(num);
		class62_0.ebd9b488_0[Class69.byte_4].cf774c3c(num);
		if (ebd9b489.ec0d6773() is Interface1)
		{
			((Interface1)ebd9b489.ec0d6773()).e44a2829(class62_0, ebd9b488_, Class0.e104f21f ? ((Enum2)3) : ((Enum2)2));
		}
		else if (Class0.e104f21f)
		{
			ulong* ptr = (ulong*)ebd9b489.method_0();
			*ptr = ebd9b488_.method_0();
		}
		else
		{
			uint* ptr2 = (uint*)ebd9b489.method_0();
			*ptr2 = ebd9b488_.b585a11();
		}
		enum1_0 = (Enum1)0;
	}
}
