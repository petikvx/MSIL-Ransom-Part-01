using System;
using System.Reflection;

internal class Class4
{
	internal delegate void Delegate0(object o);

	internal static Module module_0 = typeof(Class4).Assembly.ManifestModule;

	internal static void HJ40tf11vbOEy(int typemdt)
	{
		Type type = module_0.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}
}
