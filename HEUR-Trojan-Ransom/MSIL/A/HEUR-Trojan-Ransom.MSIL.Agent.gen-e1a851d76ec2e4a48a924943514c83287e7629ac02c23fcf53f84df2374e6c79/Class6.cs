using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

internal class Class6 : bae6a63f
{
	[SpecialName]
	public byte e9bf20d3()
	{
		return Class69.f3e4add;
	}

	public void imethod_0(Class62 class62_0, out Enum1 enum1_0)
	{
		uint num = class62_0.ebd9b488_0[Class69.byte_4].b585a11();
		ebd9b488 ebd9b489 = class62_0.class64_0.method_0(num--);
		ebd9b488 ebd9b490 = class62_0.class64_0.method_0(num--);
		Type type = (Type)class62_0.da79a168.de5d16da().method_3(ebd9b489.b585a11());
		if (ebd9b490.ec0d6773() is Interface1)
		{
			Interface1 @interface = (Interface1)ebd9b490.ec0d6773();
			ebd9b488 ebd9b488_ = default(ebd9b488);
			if (type.IsValueType)
			{
				object object_ = null;
				if ((object)Nullable.GetUnderlyingType(type) == null)
				{
					object_ = FormatterServices.GetUninitializedObject(type);
				}
				ebd9b488_.aa900636(Class68.cbd2da44(object_, type));
			}
			else
			{
				ebd9b488_.aa900636(null);
			}
			@interface.e44a2829(class62_0, ebd9b488_, (Enum2)4);
			class62_0.class64_0.method_2(num);
			class62_0.ebd9b488_0[Class69.byte_4].cf774c3c(num);
			enum1_0 = (Enum1)0;
			return;
		}
		throw new NotSupportedException();
	}
}
