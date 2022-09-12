using System;
using System.Reflection;

internal class Class9
{
	internal delegate void Delegate0(object o);

	internal static Module TjWkuxmri;

	internal static void O8boa2wwclEZg(int typemdt)
	{
		Type type = TjWkuxmri.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)TjWkuxmri.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class9()
	{
		Class10.tgfoa2wzNAwc9();
		base._002Ector();
	}

	static Class9()
	{
		Class10.tgfoa2wzNAwc9();
		TjWkuxmri = typeof(Class9).Assembly.ManifestModule;
	}
}
