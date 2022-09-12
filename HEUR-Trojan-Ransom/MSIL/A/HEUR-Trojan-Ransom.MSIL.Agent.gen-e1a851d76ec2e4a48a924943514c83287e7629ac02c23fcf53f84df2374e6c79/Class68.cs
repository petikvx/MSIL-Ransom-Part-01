using System;

internal static class Class68
{
	public static Interface2 cbd2da44(object object_0, Type type_0)
	{
		Type type = typeof(Struct2<>).MakeGenericType(type_0);
		return (Interface2)Activator.CreateInstance(type, object_0);
	}

	public static object smethod_0(object object_0)
	{
		if (object_0 is Interface2)
		{
			return ((Interface2)object_0).imethod_0();
		}
		return object_0;
	}
}
