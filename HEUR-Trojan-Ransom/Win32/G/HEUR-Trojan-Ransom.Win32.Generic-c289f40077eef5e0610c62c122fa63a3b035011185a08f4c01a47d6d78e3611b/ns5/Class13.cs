using System;
using System.Reflection;
using ns3;

namespace ns5;

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
		Class8.smethod_21(this);
	}
}
