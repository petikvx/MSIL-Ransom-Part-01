using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class11 : f788ae7e
{
	[SpecialName]
	public byte f998adc2()
	{
		return fae0f10.byte_50;
	}

	public unsafe void imethod_0(Class52 class52_0, out a82ced3b a82ced3b_0)
	{
		uint uint_ = class52_0.struct2_0[fae0f10.byte_5].b5683088();
		Struct2 @struct = class52_0.c6a36180_0.f113e6df(uint_--);
		Struct2 struct2 = class52_0.c6a36180_0.f113e6df(uint_--);
		Struct2 struct3 = class52_0.c6a36180_0.f113e6df(uint_--);
		FieldInfo fieldInfo = (FieldInfo)class52_0.c8dafbc3.method_0().d3f1f142(@struct.b5683088());
		if (!fieldInfo.IsStatic && struct3.a90ed1e2() == null)
		{
			throw new NullReferenceException();
		}
		object value = ((Type.GetTypeCode(fieldInfo.FieldType) != TypeCode.String || struct2.a90ed1e2() != null) ? struct2.method_9(fieldInfo.FieldType) : class52_0.c8dafbc3.method_0().f54a7fb9(struct2.b5683088()));
		if (fieldInfo.DeclaringType!.IsValueType && struct3.a90ed1e2() is Interface1)
		{
			TypedReference obj = default(TypedReference);
			((Interface1)struct3.a90ed1e2()).imethod_1(class52_0, Struct1.d9a770c4(&obj), fieldInfo.DeclaringType);
			Class57.c271ba87(Struct1.d9a770c4(&obj), fieldInfo.DeclaringType);
			fieldInfo.SetValueDirect(obj, value);
		}
		else
		{
			fieldInfo.SetValue(struct3.method_9(fieldInfo.DeclaringType), value);
		}
		class52_0.c6a36180_0.method_0(uint_);
		class52_0.struct2_0[fae0f10.byte_5].b3579a47(uint_);
		a82ced3b_0 = (a82ced3b)0;
	}
}
