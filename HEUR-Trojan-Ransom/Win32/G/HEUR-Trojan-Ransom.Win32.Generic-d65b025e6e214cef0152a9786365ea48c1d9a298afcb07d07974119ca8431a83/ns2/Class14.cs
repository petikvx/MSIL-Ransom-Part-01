using System;
using System.Reflection;
using ns1;

namespace ns2;

internal sealed class Class14 : IDisposable
{
	internal readonly Type type_0;

	internal readonly object object_0;

	public Class14()
	{
		Assembly assembly = Assembly.Load("mscorlib");
		type_0 = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider");
		object_0 = Activator.CreateInstance(type_0);
	}

	void IDisposable.Dispose()
	{
		Class22.smethod_18(this);
	}
}