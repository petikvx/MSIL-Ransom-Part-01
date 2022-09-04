using System;
using System.Reflection;

namespace ns1;

internal sealed class Class12 : IDisposable
{
	internal readonly Type type_0;

	internal readonly object object_0;

	public Class12()
	{
		Assembly assembly = Assembly.Load("mscorlib");
		type_0 = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider");
		object_0 = Activator.CreateInstance(type_0);
	}

	void IDisposable.Dispose()
	{
		Class11.smethod_14(this);
	}
}
