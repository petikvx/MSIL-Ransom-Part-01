using System;
using System.Reflection;
using ns1;

namespace ns0;

internal sealed class Class4 : IDisposable
{
	internal readonly Type type_0;

	internal readonly object object_0;

	public Class4()
	{
		Assembly assembly = Assembly.Load("mscorlib");
		type_0 = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider");
		object_0 = Activator.CreateInstance(type_0);
	}

	void IDisposable.Dispose()
	{
		Class1.smethod_6(this);
	}
}
