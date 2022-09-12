using System;
using Newtonsoft.Json.Serialization;
using ns13;

namespace ns7;

internal static class Class114<T> where T : Attribute
{
	private static readonly Class111<object, T?> class111_0 = new Class111<object, T>(JsonTypeReflector.smethod_3<T>);

	public static T? smethod_0(object object_0)
	{
		return class111_0.method_0(object_0);
	}
}
