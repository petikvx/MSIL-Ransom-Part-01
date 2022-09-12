using System;
using System.Reflection;

internal class Class23
{
	internal delegate void Delegate0(object o);

	internal static Module module_0;

	internal static void uSQmSIPPt5uyN(int typemdt)
	{
		Type type = module_0.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class23()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}

	static Class23()
	{
		Class24.nhQmSIPz7n4eU();
		module_0 = typeof(Class23).Assembly.ManifestModule;
	}
}
