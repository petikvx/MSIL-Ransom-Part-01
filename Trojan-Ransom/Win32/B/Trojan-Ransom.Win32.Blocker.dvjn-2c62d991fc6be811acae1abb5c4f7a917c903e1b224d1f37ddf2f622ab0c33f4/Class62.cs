using System;
using System.Reflection;

internal class Class62
{
	internal delegate void Delegate13(object o);

	internal static Module enoTneXda = typeof(Class62).Assembly.ManifestModule;

	internal static void EqZUukppNw9wK(int typemdt)
	{
		Type type = enoTneXda.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)enoTneXda.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}
}
