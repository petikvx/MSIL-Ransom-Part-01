using System;
using System.Runtime.CompilerServices;

internal class Class3 : c955c655
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.byte_65;
	}

	public void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint num = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		Struct3 @struct = fdc40966_0.class58_0.method_0(num--);
		Struct3 struct3_ = fdc40966_0.class58_0.method_0(num);
		Type type = (Type)fdc40966_0.class2_0.method_0().method_3(@struct.method_1());
		if (Type.GetTypeCode(type) == TypeCode.String && struct3_.c9550f69() == null)
		{
			struct3_.db2591b4(fdc40966_0.class2_0.method_0().method_4(struct3_.method_1()));
		}
		else
		{
			struct3_.db2591b4(struct3_.e3ce4628(type));
		}
		fdc40966_0.class58_0.b53f41f9(num, struct3_);
		fdc40966_0.class58_0.method_1(num);
		fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(num);
		enum0_0 = (Enum0)0;
	}
}
