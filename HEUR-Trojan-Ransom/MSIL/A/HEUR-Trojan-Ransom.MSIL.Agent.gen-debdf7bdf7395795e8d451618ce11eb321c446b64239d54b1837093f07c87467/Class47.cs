using System;
using System.Reflection;

internal class Class47 : da5e0024
{
	private object ab614a2;

	private FieldInfo fieldInfo_0;

	public Class47(object object_0, FieldInfo fieldInfo_1)
	{
		ab614a2 = object_0;
		fieldInfo_0 = fieldInfo_1;
	}

	public Struct2 imethod_0(Class49 class49_0, Enum2 enum2_0)
	{
		object obj = ab614a2;
		if (fieldInfo_0.DeclaringType!.IsValueType && ab614a2 is da5e0024)
		{
			obj = ((da5e0024)ab614a2).imethod_0(class49_0, (Enum2)4).method_8(fieldInfo_0.DeclaringType);
		}
		return Struct2.a5dd3349(fieldInfo_0.GetValue(obj), fieldInfo_0.FieldType);
	}

	public unsafe void bf75e195(Class49 class49_0, Struct2 struct2_0, Enum2 enum2_0)
	{
		if (fieldInfo_0.DeclaringType!.IsValueType && ab614a2 is da5e0024)
		{
			TypedReference obj = default(TypedReference);
			((da5e0024)ab614a2).c4cba08f(class49_0, fe387972.smethod_0(&obj), fieldInfo_0.DeclaringType);
			fieldInfo_0.SetValueDirect(obj, struct2_0.method_8(fieldInfo_0.FieldType));
		}
		else
		{
			fieldInfo_0.SetValue(ab614a2, struct2_0.method_8(fieldInfo_0.FieldType));
		}
	}

	public da5e0024 f4d9c5f0(uint uint_0)
	{
		return this;
	}

	public da5e0024 f4d9c5f0(ulong ulong_0)
	{
		return this;
	}

	public void c4cba08f(Class49 class49_0, fe387972 fe387972_0, Type type_0)
	{
		Class55.c6cb5c2c(class49_0, ab614a2, fieldInfo_0, fe387972_0);
	}
}
