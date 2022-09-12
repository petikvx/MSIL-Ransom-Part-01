using System;

internal static class a4609aa4
{
	public static Interface1 ba1b63c0(object object_0, Type type_0)
	{
		Type type = typeof(Struct3<>).MakeGenericType(type_0);
		return (Interface1)Activator.CreateInstance(type, object_0);
	}

	public static object b89e3a16(object object_0)
	{
		if (object_0 is Interface1)
		{
			return ((Interface1)object_0).imethod_0();
		}
		return object_0;
	}
}
