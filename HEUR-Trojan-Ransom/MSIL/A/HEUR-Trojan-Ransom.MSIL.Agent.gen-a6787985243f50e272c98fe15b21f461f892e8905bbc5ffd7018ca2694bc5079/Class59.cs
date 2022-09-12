using System;

internal static class Class59
{
	public static Interface2 smethod_0(object object_0, Type type_0)
	{
		Type type = typeof(global::dc0d8a9<>).MakeGenericType(type_0);
		return (Interface2)Activator.CreateInstance(type, object_0);
	}

	public static object cefadc0d(object object_0)
	{
		if (object_0 is Interface2)
		{
			return ((Interface2)object_0).a421f925();
		}
		return object_0;
	}
}
