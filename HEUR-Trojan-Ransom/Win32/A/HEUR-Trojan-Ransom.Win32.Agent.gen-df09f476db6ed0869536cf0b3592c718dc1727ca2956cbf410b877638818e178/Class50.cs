using System;
using System.Reflection;

internal class Class50
{
	internal delegate void Delegate0(object o);

	internal static Module module_0;

	internal static void smethod_0(int typemdt)
	{
		Type type = module_0.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class50()
	{
		Class51.smethod_0();
		base._002Ector();
	}

	static Class50()
	{
		Class51.smethod_0();
		module_0 = typeof(Class50).Assembly.ManifestModule;
	}
}
