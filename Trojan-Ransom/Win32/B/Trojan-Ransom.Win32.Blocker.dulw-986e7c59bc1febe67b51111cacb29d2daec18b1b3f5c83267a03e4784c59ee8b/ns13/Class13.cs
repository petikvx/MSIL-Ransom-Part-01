using System;
using System.Reflection;
using ns8;

namespace ns13;

internal sealed class Class13 : IDisposable
{
	internal readonly Type type_0;

	internal readonly object object_0;

	public Class13()
	{
		Assembly assembly = Assembly.Load("mscorlib");
		type_0 = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider");
		object_0 = Activator.CreateInstance(type_0);
	}

	void IDisposable.Dispose()
	{
		Class6.smethod_24(this);
	}
}
