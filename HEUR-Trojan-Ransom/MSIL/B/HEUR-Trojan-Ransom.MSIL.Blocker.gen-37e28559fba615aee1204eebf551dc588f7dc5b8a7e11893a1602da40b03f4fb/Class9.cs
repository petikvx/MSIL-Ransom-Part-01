using System;
using System.Reflection;

internal class Class9
{
	internal delegate void Delegate2(object o);

	internal static Module module_0;

	internal static void lRQvLucCAqbGR(int typemdt)
	{
		Type type = module_0.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class9()
	{
		Class8.t3hvLuccnmfIO();
		base._002Ector();
	}

	static Class9()
	{
		Class8.t3hvLuccnmfIO();
		module_0 = typeof(Class9).Assembly.ManifestModule;
	}
}
