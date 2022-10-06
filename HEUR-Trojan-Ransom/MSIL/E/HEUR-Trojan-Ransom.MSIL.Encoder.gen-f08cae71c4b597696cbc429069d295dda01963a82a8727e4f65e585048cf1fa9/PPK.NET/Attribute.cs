using System;
using System.Reflection;

namespace PPK.NET;

internal class Attribute
{
	internal delegate void Broadcaster(object o);

	internal static Module dic;

	internal static void RestartThread(int typemdt)
	{
		Type type = dic.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)dic.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Attribute()
	{
		Class.SetupThread();
		base._002Ector();
	}

	static Attribute()
	{
		Class.SetupThread();
		dic = typeof(Attribute).Assembly.ManifestModule;
	}
}
