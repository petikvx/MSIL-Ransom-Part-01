using System;

internal static class e6c45616
{
	public static Interface2 smethod_0(object object_0, Type type_0)
	{
		Type type = typeof(Struct4<>).MakeGenericType(type_0);
		return (Interface2)Activator.CreateInstance(type, object_0);
	}

	public static object smethod_1(object object_0)
	{
		if (object_0 is Interface2)
		{
			return ((Interface2)object_0).bb331190();
		}
		return object_0;
	}
}
