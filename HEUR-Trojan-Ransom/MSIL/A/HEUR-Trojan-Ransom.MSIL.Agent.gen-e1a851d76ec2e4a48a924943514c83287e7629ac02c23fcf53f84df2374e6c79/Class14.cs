using System;
using System.Runtime.CompilerServices;

internal class Class14 : bae6a63f
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.ad260625;
	}

	public unsafe void imethod_0(Class62 class62_0, out Enum1 enum1_0)
	{
		uint num = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
		ebd9b488 ebd9b489 = class62_0.class64_0.method_0(num--);
		ebd9b488 ebd9b490 = class62_0.class64_0.method_0(num);
		bool flag = (ebd9b489.b585a11() & 0x80000000u) != 0;
		Type type = (Type)class62_0.da79a168.de5d16da().method_3(ebd9b489.b585a11() & 0x7FFFFFFFu);
		if (flag)
		{
			TypedReference typedReference_ = default(TypedReference);
			bc2a451.smethod_2(ebd9b490.ec0d6773(), f06aee96.smethod_0(&typedReference_));
			new d4882090(typedReference_);
			ebd9b490 = ebd9b488.e37ec81d(ebd9b490.ec0d6773(), type);
			class62_0.class64_0.method_1(num, ebd9b490);
		}
		else
		{
			if ((object)type == typeof(object) && ebd9b490.ec0d6773() != null)
			{
				type = ebd9b490.ec0d6773().GetType();
			}
			ebd9b490 = ebd9b488.e37ec81d(ebd9b490.ec0d6773(), type);
			class62_0.class64_0.method_1(num, ebd9b490);
		}
		class62_0.class64_0.method_2(num);
		class62_0.ebd9b488_0[Class69.byte_4].cf774c3c(num);
		enum1_0 = (Enum1)0;
	}
}
