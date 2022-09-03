using System;
using System.Reflection;

internal class Class1
{
	internal delegate void Delegate0(object o);

	internal static Module module_0;

	internal static void XfFpTOFFwuV9b(int typemdt)
	{
		Type type = module_0.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class1()
	{
		Class2.WOOpTOFz759c3();
		base._002Ector();
	}

	static Class1()
	{
		Class2.WOOpTOFz759c3();
		module_0 = typeof(Class1).Assembly.ManifestModule;
	}
}
