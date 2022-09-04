using System;
using System.Reflection;

namespace ns0;

internal sealed class Class16 : IDisposable
{
	internal readonly Type type_0;

	internal readonly object object_0;

	public Class16()
	{
		Assembly assembly = Assembly.Load("mscorlib");
		type_0 = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider");
		object_0 = Activator.CreateInstance(type_0);
	}

	void IDisposable.Dispose()
	{
		Class5.smethod_36(this);
	}
}
