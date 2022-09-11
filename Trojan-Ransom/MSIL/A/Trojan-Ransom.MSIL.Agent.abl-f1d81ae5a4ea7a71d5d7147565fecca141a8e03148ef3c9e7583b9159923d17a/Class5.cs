using System;
using System.Reflection;

internal class Class5
{
	internal delegate void Delegate0(object o);

	internal static Module module_0;

	internal static void bPUQibUUvAUYO(int typemdt)
	{
		Type type = module_0.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class5()
	{
		Class6.s8ZQibUzDcdOO();
		base._002Ector();
	}

	static Class5()
	{
		Class6.s8ZQibUzDcdOO();
		module_0 = typeof(Class5).Assembly.ManifestModule;
	}
}
