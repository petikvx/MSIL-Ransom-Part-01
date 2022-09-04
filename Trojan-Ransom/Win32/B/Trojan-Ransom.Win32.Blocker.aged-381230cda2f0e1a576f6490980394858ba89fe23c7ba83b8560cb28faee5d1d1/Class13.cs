using System;
using System.Reflection;

internal class Class13
{
	internal delegate void Delegate0(object o);

	internal static Module vXijwVswf;

	internal static void bWwt82DD0MqTl(int typemdt)
	{
		Type type = vXijwVswf.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)vXijwVswf.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class13()
	{
		Class14.u5Gt82DzXHpxk();
		base._002Ector();
	}

	static Class13()
	{
		Class14.u5Gt82DzXHpxk();
		vXijwVswf = typeof(Class13).Assembly.ManifestModule;
	}
}
