using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class10 : d88be11e
{
	[SpecialName]
	public byte b4b1262()
	{
		return b13312b0.byte_71;
	}

	public unsafe void df3f437a(Class58 class58_0, out Enum0 enum0_0)
	{
		uint uint_ = class58_0.a6890f1d[b13312b0.byte_7].df1ed028();
		facef383 facef384 = class58_0.c73f45d8.a9bb6dff(uint_--);
		facef383 facef385 = class58_0.c73f45d8.a9bb6dff(uint_--);
		facef383 facef386 = class58_0.c73f45d8.a9bb6dff(uint_--);
		FieldInfo fieldInfo = (FieldInfo)class58_0.a3d704e3.method_0().method_2(facef384.df1ed028());
		if (!fieldInfo.IsStatic && facef386.method_8() == null)
		{
			throw new NullReferenceException();
		}
		object value = ((Type.GetTypeCode(fieldInfo.FieldType) != TypeCode.String || facef385.method_8() != null) ? facef385.f3c5123d(fieldInfo.FieldType) : class58_0.a3d704e3.method_0().method_3(facef385.df1ed028()));
		if (fieldInfo.DeclaringType!.IsValueType && facef386.method_8() is Interface0)
		{
			TypedReference obj = default(TypedReference);
			((Interface0)facef386.method_8()).imethod_0(class58_0, Struct0.smethod_0(&obj), fieldInfo.DeclaringType);
			Class63.smethod_0(Struct0.smethod_0(&obj), fieldInfo.DeclaringType);
			fieldInfo.SetValueDirect(obj, value);
		}
		else
		{
			fieldInfo.SetValue(facef386.f3c5123d(fieldInfo.DeclaringType), value);
		}
		class58_0.c73f45d8.a85b6a89(uint_);
		class58_0.a6890f1d[b13312b0.byte_7].method_2(uint_);
		enum0_0 = (Enum0)0;
	}
}
