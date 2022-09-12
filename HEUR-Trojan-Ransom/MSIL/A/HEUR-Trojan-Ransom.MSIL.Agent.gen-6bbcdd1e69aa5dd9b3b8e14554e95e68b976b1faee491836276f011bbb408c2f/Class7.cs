using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

internal class Class7 : c955c655
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.cf24a643;
	}

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint num = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		Struct3 @struct = fdc40966_0.class58_0.method_0(num--);
		Struct3 struct2 = fdc40966_0.class58_0.method_0(num--);
		Type type = (Type)fdc40966_0.class2_0.method_0().method_3(@struct.method_1());
		if (struct2.c9550f69() is Interface1)
		{
			Interface1 @interface = (Interface1)struct2.c9550f69();
			Struct3 struct3_ = default(Struct3);
			if (type.IsValueType)
			{
				object object_ = null;
				if ((object)Nullable.GetUnderlyingType(type) == null)
				{
					object_ = FormatterServices.GetUninitializedObject(type);
				}
				struct3_.db2591b4(e6c45616.smethod_0(object_, type));
			}
			else
			{
				struct3_.db2591b4(null);
			}
			@interface.ce1637af(fdc40966_0, struct3_, (f75d8d37)4);
			fdc40966_0.class58_0.method_1(num);
			fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(num);
			enum0_0 = (Enum0)0;
			return;
		}
		throw new NotSupportedException();
	}
}
