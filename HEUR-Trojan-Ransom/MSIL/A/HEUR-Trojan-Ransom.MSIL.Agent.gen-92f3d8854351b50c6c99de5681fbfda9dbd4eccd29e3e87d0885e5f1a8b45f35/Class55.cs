using System;
using System.Reflection;

internal class Class55 : Interface0
{
	private object e4ca6849;

	private FieldInfo af645514;

	public Class55(object object_0, FieldInfo fieldInfo_0)
	{
		e4ca6849 = object_0;
		af645514 = fieldInfo_0;
	}

	public facef383 b3037b45(Class58 class58_0, Enum1 enum1_0)
	{
		object obj = e4ca6849;
		if (af645514.DeclaringType!.IsValueType && e4ca6849 is Interface0)
		{
			obj = ((Interface0)e4ca6849).b3037b45(class58_0, (Enum1)4).f3c5123d(af645514.DeclaringType);
		}
		return facef383.b3e8ed04(af645514.GetValue(obj), af645514.FieldType);
	}

	public unsafe void c076b3e0(Class58 class58_0, facef383 facef383_0, Enum1 enum1_0)
	{
		if (af645514.DeclaringType!.IsValueType && e4ca6849 is Interface0)
		{
			TypedReference obj = default(TypedReference);
			((Interface0)e4ca6849).imethod_0(class58_0, Struct0.smethod_0(&obj), af645514.DeclaringType);
			af645514.SetValueDirect(obj, facef383_0.f3c5123d(af645514.FieldType));
		}
		else
		{
			af645514.SetValue(e4ca6849, facef383_0.f3c5123d(af645514.FieldType));
		}
	}

	public Interface0 df0155bf(uint uint_0)
	{
		return this;
	}

	public Interface0 df0155bf(ulong ulong_0)
	{
		return this;
	}

	public void imethod_0(Class58 class58_0, Struct0 struct0_0, Type type_0)
	{
		Class63.c702e7cb(class58_0, e4ca6849, af645514, struct0_0);
	}
}
