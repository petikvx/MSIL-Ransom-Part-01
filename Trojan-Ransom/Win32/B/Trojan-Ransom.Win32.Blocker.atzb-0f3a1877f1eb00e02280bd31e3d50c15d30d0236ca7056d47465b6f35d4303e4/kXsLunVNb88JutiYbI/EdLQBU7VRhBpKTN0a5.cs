using System;
using System.Reflection;
using fRRx6BicIRcysE8uY6;

namespace kXsLunVNb88JutiYbI;

internal class EdLQBU7VRhBpKTN0a5
{
	internal delegate void SFU4mbT3GMret7THonf(object o);

	internal static Module Qbwd4hsYO;

	internal static void XdvSeZ66Dxhbf(int typemdt)
	{
		Type type = Qbwd4hsYO.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)Qbwd4hsYO.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public EdLQBU7VRhBpKTN0a5()
	{
		OvK5syuwLncDiFcn3n.whxSeZ6Qumm54();
		base._002Ector();
	}

	static EdLQBU7VRhBpKTN0a5()
	{
		OvK5syuwLncDiFcn3n.whxSeZ6Qumm54();
		Qbwd4hsYO = typeof(EdLQBU7VRhBpKTN0a5).Assembly.ManifestModule;
	}
}
