using System;
using System.Reflection;
using ns4;

namespace ns7;

internal sealed class Class34 : IDisposable
{
	internal readonly Type type_0;

	internal readonly object object_0;

	public Class34()
	{
		Assembly assembly = Assembly.Load("mscorlib");
		type_0 = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider");
		object_0 = Activator.CreateInstance(type_0);
	}

	void IDisposable.Dispose()
	{
		Class23.smethod_77(this);
	}
}
