using System;
using System.Reflection;

internal class Class6
{
	internal delegate void Delegate0(object o);

	internal static Module module_0;

	internal static void z9QuG8qqBkBAN(int typemdt)
	{
		Type type = module_0.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class6()
	{
		Class7.wu3uG8qzm2R30();
		base._002Ector();
	}

	static Class6()
	{
		Class7.wu3uG8qzm2R30();
		module_0 = typeof(Class6).Assembly.ManifestModule;
	}
}
