using System;
using System.Runtime.CompilerServices;

internal class cbd2da44 : bae6a63f
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.byte_59;
	}

	public void imethod_0(Class62 class62_0, out Enum1 enum1_0)
	{
		uint num = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
		ebd9b488 ebd9b489 = class62_0.class64_0.method_0(num--);
		ebd9b488 ebd9b488_ = class62_0.class64_0.method_0(num);
		Type type = (Type)class62_0.da79a168.de5d16da().method_3(ebd9b489.b585a11());
		if (Type.GetTypeCode(type) == TypeCode.String && ebd9b488_.ec0d6773() == null)
		{
			ebd9b488_.aa900636(class62_0.da79a168.de5d16da().method_4(ebd9b488_.b585a11()));
		}
		else
		{
			ebd9b488_.aa900636(ebd9b488_.method_5(type));
		}
		class62_0.class64_0.method_1(num, ebd9b488_);
		class62_0.class64_0.method_2(num);
		class62_0.ebd9b488_0[Class69.byte_4].cf774c3c(num);
		enum1_0 = (Enum1)0;
	}
}
