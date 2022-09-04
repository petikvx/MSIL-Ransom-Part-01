using System;
using System.Reflection;

internal class Class9
{
	internal delegate void Delegate0(object o);

	internal static Module JelidVwFv;

	internal static void M0OlJcVV8Jt94(int typemdt)
	{
		Type type = JelidVwFv.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)JelidVwFv.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class9()
	{
		Class10.amQlJcVz0II2r();
		base._002Ector();
	}

	static Class9()
	{
		Class10.amQlJcVz0II2r();
		JelidVwFv = typeof(Class9).Assembly.ManifestModule;
	}
}
