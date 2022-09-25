using System;
using System.Reflection;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;
using zlqCXdcKao7YZQAGFe;

namespace oRZtxCaSAYh6EEGEIZ;

internal class Idt5pgryuYoFVQiX6j
{
	internal delegate void SFU4mbT3GMret7THonf(object o);

	internal static Module Kh2o8BSHbd;

	internal static void Ec1F5299AxUyY(int typemdt)
	{
		Type type = Kh2o8BSHbd.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)Kh2o8BSHbd.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Idt5pgryuYoFVQiX6j()
	{
		hHEYokUTtehNq5ji0d.LQgF529zBT6Ox();
		base._002Ector();
	}

	static Idt5pgryuYoFVQiX6j()
	{
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		hHEYokUTtehNq5ji0d.LQgF529zBT6Ox();
		Kh2o8BSHbd = Type.GetTypeFromHandle(kSQlZa9TWrZWUAWTnp.GLmF52oPYUmB1(33554447)).Assembly.ManifestModule;
	}
}
