using System;
using System.IO;
using System.Reflection;
using ns1;

namespace ns0;

internal sealed class Class6 : IDisposable
{
	internal readonly Type type_0;

	internal readonly object object_0;

	public Class6()
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
		Class15.smethod_37(this);
	}
}