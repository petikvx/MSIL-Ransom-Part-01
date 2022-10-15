using System;
using System.Reflection;

internal class Class13
{
	internal delegate void Delegate4(object o);

	internal static Module module_0;

	internal static void gl8VHkee0wf87(int typemdt)
	{
		Type type = module_0.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class13()
	{
		Class14.vPNVHkezq0oMI();
		base._002Ector();
	}

	static Class13()
	{
		Class14.vPNVHkezq0oMI();
		module_0 = typeof(Class13).Assembly.ManifestModule;
	}
}
