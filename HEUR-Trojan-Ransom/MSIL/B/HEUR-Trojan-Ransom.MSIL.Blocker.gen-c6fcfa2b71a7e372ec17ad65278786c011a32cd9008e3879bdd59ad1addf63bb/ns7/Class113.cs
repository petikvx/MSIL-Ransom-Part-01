using System;
using Newtonsoft.Json.Serialization;
using ns4;

namespace ns7;

internal static class Class113<T> where T : Attribute
{
	private static readonly Class110<object, T?> class110_0 = new Class110<object, T>(JsonTypeReflector.smethod_3<T>);

	public static T? smethod_0(object object_0)
	{
		return class110_0.method_0(object_0);
	}
}
