using System;

internal static class Class60
{
	public static c8feea0 smethod_0(object object_0, Type type_0)
	{
		Type type = typeof(Struct2<>).MakeGenericType(type_0);
		return (c8feea0)Activator.CreateInstance(type, object_0);
	}

	public static object smethod_1(object object_0)
	{
		if (object_0 is c8feea0)
		{
			return ((c8feea0)object_0).imethod_0();
		}
		return object_0;
	}
}
