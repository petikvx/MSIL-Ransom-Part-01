using System;
using System.Reflection;
using ns0;

namespace ns1;

internal sealed class Class11 : IDisposable
{
	internal readonly Type type_0;

	internal readonly object object_0;

	public Class11()
	{
		Assembly assembly = Assembly.Load("mscorlib");
		type_0 = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider");
		object_0 = Activator.CreateInstance(type_0);
	}

	void IDisposable.Dispose()
	{
		Class23.smethod_78(this);
	}
}
