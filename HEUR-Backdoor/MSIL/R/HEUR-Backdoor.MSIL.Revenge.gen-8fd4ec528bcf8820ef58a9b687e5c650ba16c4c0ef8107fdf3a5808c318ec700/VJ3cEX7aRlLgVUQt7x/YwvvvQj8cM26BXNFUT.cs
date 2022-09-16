using System;
using System.Reflection;
using CIsnTIXy9sPh8UU7vK;

namespace VJ3cEX7aRlLgVUQt7x;

internal class YwvvvQj8cM26BXNFUT
{
	internal delegate void wR3OLBFZeselfplv1Q(object o);

	internal static Module QlLdgVUQt;

	internal static void LLEjPRff17TYv(int typemdt)
	{
		Type type = QlLdgVUQt.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)QlLdgVUQt.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public YwvvvQj8cM26BXNFUT()
	{
		FwnbpF40QRXGKbD08B.TpLjPRfzSfIkW();
		base._002Ector();
	}

	static YwvvvQj8cM26BXNFUT()
	{
		FwnbpF40QRXGKbD08B.TpLjPRfzSfIkW();
		QlLdgVUQt = typeof(YwvvvQj8cM26BXNFUT).Assembly.ManifestModule;
	}
}
