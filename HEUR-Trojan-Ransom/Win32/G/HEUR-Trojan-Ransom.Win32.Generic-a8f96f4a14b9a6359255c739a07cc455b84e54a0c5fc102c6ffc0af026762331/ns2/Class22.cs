using System;
using System.Reflection;
using ns6;

namespace ns2;

internal sealed class Class22 : IDisposable
{
	internal readonly Type type_0;

	internal readonly object object_0;

	public Class22()
	{
		Assembly assembly = Assembly.Load("mscorlib");
		type_0 = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider");
		object_0 = Activator.CreateInstance(type_0);
	}

	void IDisposable.Dispose()
	{
		Class16.smethod_58(this);
	}
}
