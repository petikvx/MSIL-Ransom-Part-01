using System;
using System.Reflection;
using ns0;

namespace ns3;

internal sealed class Class29 : IDisposable
{
	internal readonly Type type_0;

	internal readonly object object_0;

	public Class29()
	{
		Assembly assembly = Assembly.Load("mscorlib");
		type_0 = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider");
		object_0 = Activator.CreateInstance(type_0);
	}

	void IDisposable.Dispose()
	{
		Class42.smethod_13(this);
	}
}
