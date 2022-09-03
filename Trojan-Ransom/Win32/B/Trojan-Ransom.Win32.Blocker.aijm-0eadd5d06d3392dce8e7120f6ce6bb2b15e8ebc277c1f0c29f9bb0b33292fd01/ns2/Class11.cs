using System;
using System.Reflection;

namespace ns2;

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
		Class5.smethod_41(this);
	}
}
