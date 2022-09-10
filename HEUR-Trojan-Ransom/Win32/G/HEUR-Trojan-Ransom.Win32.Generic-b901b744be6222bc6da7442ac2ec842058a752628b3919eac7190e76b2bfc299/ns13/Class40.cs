using System;
using System.Reflection;
using ns2;

namespace ns13;

internal sealed class Class40 : IDisposable
{
	internal readonly Type type_0;

	internal readonly object object_0;

	public Class40()
	{
		Assembly assembly = Assembly.Load("mscorlib");
		type_0 = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider");
		object_0 = Activator.CreateInstance(type_0);
	}

	void IDisposable.Dispose()
	{
		Class34.smethod_18(this);
	}
}
