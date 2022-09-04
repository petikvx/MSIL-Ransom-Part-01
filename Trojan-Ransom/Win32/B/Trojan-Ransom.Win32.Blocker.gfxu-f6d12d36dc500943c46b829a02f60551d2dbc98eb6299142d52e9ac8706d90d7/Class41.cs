using System;
using System.Reflection;

internal class Class41
{
	internal delegate void Delegate3(object o);

	internal static Module module_0;

	internal static void xmwjKD00jHAFX(int typemdt)
	{
		Type type = module_0.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class41()
	{
		Class42.hMqjKD0znI7T7();
		base._002Ector();
	}

	static Class41()
	{
		Class42.hMqjKD0znI7T7();
		module_0 = typeof(Class41).Assembly.ManifestModule;
	}
}
