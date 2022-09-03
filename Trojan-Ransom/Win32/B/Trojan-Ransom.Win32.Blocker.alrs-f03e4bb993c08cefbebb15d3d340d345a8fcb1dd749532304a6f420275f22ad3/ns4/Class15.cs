using System;
using System.Reflection;
using ns3;

namespace ns4;

internal sealed class Class15 : IDisposable
{
	internal readonly Type type_0;

	internal readonly object object_0;

	public Class15()
	{
		Assembly assembly = Assembly.Load("mscorlib");
		type_0 = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider");
		object_0 = Activator.CreateInstance(type_0);
	}

	void IDisposable.Dispose()
	{
		Class27.smethod_44(this);
	}
}
