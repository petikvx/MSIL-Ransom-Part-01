using System;
using System.Reflection;
using ns0;

namespace ns5;

internal sealed class Class3 : IDisposable
{
	internal readonly Type type_0;

	internal readonly object object_0;

	public Class3()
	{
		Assembly assembly = Assembly.Load("mscorlib");
		type_0 = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider");
		object_0 = Activator.CreateInstance(type_0);
	}

	void IDisposable.Dispose()
	{
		Class12.smethod_24(this);
	}
}
