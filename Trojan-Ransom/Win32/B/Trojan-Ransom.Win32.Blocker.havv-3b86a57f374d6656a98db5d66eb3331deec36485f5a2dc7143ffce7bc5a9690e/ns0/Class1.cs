using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace ns0;

internal sealed class Class1 : IDisposable
{
	private readonly Type type_0;

	private readonly object object_0;

	public Class1()
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

	public ICryptoTransform method_0(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(object_0, new object[1] { byte_0 });
		type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(object_0, new object[1] { byte_1 });
		MethodInfo method = type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(object_0, new object[0]);
	}

	public void method_1()
	{
		type_0.GetMethod("Clear")!.Invoke(object_0, new object[0]);
	}

	void IDisposable.Dispose()
	{
		method_1();
	}
}
