using System;
using System.Reflection;

internal class Class3
{
	internal delegate void Delegate0(object o);

	internal static Module module_0;

	internal static void SOCswkMMcDflR(int typemdt)
	{
		Type type = module_0.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class3()
	{
		Class4.mmSswkMzXYVws();
		base._002Ector();
	}

	static Class3()
	{
		Class4.mmSswkMzXYVws();
		module_0 = typeof(Class3).Assembly.ManifestModule;
	}
}
