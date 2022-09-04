using System;
using System.Reflection;

internal class Class51
{
	internal delegate void Delegate3(object o);

	internal static Module module_0;

	internal static void T8xgGmhh7JcWI(int typemdt)
	{
		Type type = module_0.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class51()
	{
		Class52.KPUgGmhz2nAeI();
		base._002Ector();
	}

	static Class51()
	{
		Class52.KPUgGmhz2nAeI();
		module_0 = typeof(Class51).Assembly.ManifestModule;
	}
}
