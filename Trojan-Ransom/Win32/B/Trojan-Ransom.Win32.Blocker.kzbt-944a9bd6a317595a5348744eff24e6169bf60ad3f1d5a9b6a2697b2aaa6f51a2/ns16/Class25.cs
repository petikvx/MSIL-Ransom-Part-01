using System;
using System.Reflection;

namespace ns16;

internal sealed class Class25 : IDisposable
{
	internal readonly Type type_0;

	internal readonly object object_0;

	public Class25()
	{
		Assembly assembly = Assembly.Load("mscorlib");
		type_0 = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider");
		object_0 = Activator.CreateInstance(type_0);
	}

	void IDisposable.Dispose()
	{
		Class33.smethod_10(this);
	}
}
