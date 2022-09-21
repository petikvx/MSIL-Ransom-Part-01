using System;
using System.Reflection;

internal class Class10
{
	internal delegate void Delegate0(object o);

	internal static Module module_0;

	internal static void xr9E32yyKVulP(int typemdt)
	{
		Type type = module_0.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class10()
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector();
	}

	static Class10()
	{
		Class11.NQ1E32yzjMukk();
		module_0 = typeof(Class10).Assembly.ManifestModule;
	}
}
