using System;
using System.IO;
using System.Reflection;
using ns0;

namespace ns4;

internal sealed class Class7 : IDisposable
{
	internal readonly Type type_0;

	internal readonly object object_0;

	public Class7()
	{
		try
		{
			Assembly assembly = Assembly.Load("System.Core, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e");
			type_0 = assembly.GetType("System.Security.Cryptography.AesManaged");
		}
		catch (FileNotFoundException)
		{
			Assembly assembly = Assembly.Load("mscorlib");
			type_0 = assembly.GetType("System.Security.Cryptography.RijndaelManaged");
		}
		object_0 = Activator.CreateInstance(type_0);
	}

	void IDisposable.Dispose()
	{
		Class1.smethod_34(this);
	}
}
