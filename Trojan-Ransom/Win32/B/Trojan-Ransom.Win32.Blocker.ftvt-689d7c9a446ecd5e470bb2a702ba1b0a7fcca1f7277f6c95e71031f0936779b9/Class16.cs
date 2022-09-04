using System;
using System.Reflection;

internal class Class16
{
	internal delegate void Delegate1(object o);

	internal static Module module_0 = typeof(Class16).Assembly.ManifestModule;

	internal static void agnt96VVDf6DS(int typemdt)
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
