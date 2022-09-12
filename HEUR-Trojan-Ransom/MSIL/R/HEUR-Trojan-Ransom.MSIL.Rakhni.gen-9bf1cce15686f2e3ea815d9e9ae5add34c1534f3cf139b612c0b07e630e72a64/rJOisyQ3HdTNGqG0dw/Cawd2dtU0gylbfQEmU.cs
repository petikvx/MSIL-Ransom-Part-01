using System;
using System.Reflection;
using H5xM9bidBYFZrWjgMk;

namespace rJOisyQ3HdTNGqG0dw;

internal class Cawd2dtU0gylbfQEmU
{
	internal delegate void D0oYsvSp1pcprGcj8n(object o);

	internal static Module UQEimUYJO;

	internal static void mYFBwqYYD1d2u(int typemdt)
	{
		Type type = UQEimUYJO.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)UQEimUYJO.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Cawd2dtU0gylbfQEmU()
	{
		qMB23eUYWYHTl2dWWN.FP1BwqYKalBqv();
		base._002Ector();
	}

	static Cawd2dtU0gylbfQEmU()
	{
		qMB23eUYWYHTl2dWWN.FP1BwqYKalBqv();
		UQEimUYJO = typeof(Cawd2dtU0gylbfQEmU).Assembly.ManifestModule;
	}
}
