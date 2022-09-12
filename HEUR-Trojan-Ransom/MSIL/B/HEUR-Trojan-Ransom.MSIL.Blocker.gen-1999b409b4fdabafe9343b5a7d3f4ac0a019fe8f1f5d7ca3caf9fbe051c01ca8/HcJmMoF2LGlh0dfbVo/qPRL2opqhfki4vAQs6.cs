using System;
using System.Reflection;
using FcvbSOcaRYeR1IfM1w;

namespace HcJmMoF2LGlh0dfbVo;

internal class qPRL2opqhfki4vAQs6
{
	internal delegate void W8yRyKS52eKknO7fnR(object o);

	internal static Module XiJDkcI9O;

	internal static void E0DV9iJ2En(int typemdt)
	{
		Type type = XiJDkcI9O.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)XiJDkcI9O.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public qPRL2opqhfki4vAQs6()
	{
		JjpeEV8YkDPSf2ImEC.IvIVs5oiw1();
		base._002Ector();
	}

	static qPRL2opqhfki4vAQs6()
	{
		JjpeEV8YkDPSf2ImEC.IvIVs5oiw1();
		XiJDkcI9O = typeof(qPRL2opqhfki4vAQs6).Assembly.ManifestModule;
	}
}
