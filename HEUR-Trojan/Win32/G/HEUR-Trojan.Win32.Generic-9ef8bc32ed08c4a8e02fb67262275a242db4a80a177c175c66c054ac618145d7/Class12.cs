using System;
using System.Reflection;

internal class Class12
{
	internal delegate void Delegate1(object o);

	internal static Module module_0;

	internal static void wEJn6WrrT3ZN7(int typemdt)
	{
		Type type = module_0.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class12()
	{
		Class13.F2pn6WrzFkP6h();
		base._002Ector();
	}

	static Class12()
	{
		Class13.F2pn6WrzFkP6h();
		module_0 = typeof(Class12).Assembly.ManifestModule;
	}
}
