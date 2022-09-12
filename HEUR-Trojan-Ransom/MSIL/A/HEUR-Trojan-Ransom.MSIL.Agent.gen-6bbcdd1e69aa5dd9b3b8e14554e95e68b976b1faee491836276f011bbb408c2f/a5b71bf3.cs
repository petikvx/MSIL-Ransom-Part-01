using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class a5b71bf3 : c955c655
{
	[SpecialName]
	public byte imethod_0()
	{
		return fb3c043f.byte_64;
	}

	public unsafe void imethod_1(fdc40966 fdc40966_0, out Enum0 enum0_0)
	{
		uint num = fdc40966_0.struct3_0[fb3c043f.c55b5391].method_1();
		Struct3 @struct = fdc40966_0.class58_0.method_0(num--);
		Struct3 struct2 = fdc40966_0.class58_0.method_0(num--);
		Struct3 struct3 = fdc40966_0.class58_0.method_0(num--);
		FieldInfo fieldInfo = (FieldInfo)fdc40966_0.class2_0.method_0().method_3(@struct.method_1());
		if (!fieldInfo.IsStatic && struct3.c9550f69() == null)
		{
			throw new NullReferenceException();
		}
		object value = ((Type.GetTypeCode(fieldInfo.FieldType) != TypeCode.String || struct2.c9550f69() != null) ? struct2.e3ce4628(fieldInfo.FieldType) : fdc40966_0.class2_0.method_0().method_4(struct2.method_1()));
		if (fieldInfo.DeclaringType!.IsValueType && struct3.c9550f69() is Interface1)
		{
			TypedReference obj = default(TypedReference);
			((Interface1)struct3.c9550f69()).imethod_0(fdc40966_0, Struct2.smethod_0(&obj), fieldInfo.DeclaringType);
			Class61.smethod_0(Struct2.smethod_0(&obj), fieldInfo.DeclaringType);
			fieldInfo.SetValueDirect(obj, value);
		}
		else
		{
			fieldInfo.SetValue(struct3.e3ce4628(fieldInfo.DeclaringType), value);
		}
		fdc40966_0.class58_0.method_1(num);
		fdc40966_0.struct3_0[fb3c043f.c55b5391].e63a4aca(num);
		enum0_0 = (Enum0)0;
	}
}
