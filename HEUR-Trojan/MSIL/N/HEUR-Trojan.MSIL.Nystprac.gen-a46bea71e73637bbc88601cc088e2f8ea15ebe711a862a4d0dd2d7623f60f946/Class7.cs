using System;
using System.Reflection;

internal class Class7
{
	internal delegate void Delegate0(object o);

	internal static Module module_0;

	internal static void ft3WKbOOwMX2l(int typemdt)
	{
		Type type = module_0.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class7()
	{
		Class8.lqVWKbOzF3son();
		base._002Ector();
	}

	static Class7()
	{
		Class8.lqVWKbOzF3son();
		module_0 = typeof(Class7).Assembly.ManifestModule;
	}
}
