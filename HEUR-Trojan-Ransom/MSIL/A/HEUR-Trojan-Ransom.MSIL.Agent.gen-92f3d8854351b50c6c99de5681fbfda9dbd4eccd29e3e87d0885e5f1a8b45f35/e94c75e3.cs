using System;

internal static class e94c75e3
{
	public static ad414660 f6ace54f(object object_0, Type type_0)
	{
		Type type = typeof(global::e6eaacc9<>).MakeGenericType(type_0);
		return (ad414660)Activator.CreateInstance(type, object_0);
	}

	public static object smethod_0(object object_0)
	{
		if (object_0 is ad414660)
		{
			return ((ad414660)object_0).b3037b45();
		}
		return object_0;
	}
}
