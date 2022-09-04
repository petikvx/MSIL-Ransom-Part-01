using System;
using System.Reflection;
using ns5;

namespace ns3;

internal sealed class Class12 : IDisposable
{
	internal readonly Type type_0;

	internal readonly object object_0;

	public Class12()
	{
		Assembly assembly = Assembly.Load("mscorlib");
		type_0 = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider");
		object_0 = Activator.CreateInstance(type_0);
	}

	void IDisposable.Dispose()
	{
		Class25.smethod_78(this);
	}
}
