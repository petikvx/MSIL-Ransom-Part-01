using System;
using System.Reflection;
using ns0;

namespace ns2;

internal sealed class Class8 : IDisposable
{
	internal readonly Type type_0;

	internal readonly object object_0;

	public Class8()
	{
		Assembly assembly = Assembly.Load("mscorlib");
		type_0 = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider");
		object_0 = Activator.CreateInstance(type_0);
	}

	void IDisposable.Dispose()
	{
		Class1.smethod_13(this);
	}
}
