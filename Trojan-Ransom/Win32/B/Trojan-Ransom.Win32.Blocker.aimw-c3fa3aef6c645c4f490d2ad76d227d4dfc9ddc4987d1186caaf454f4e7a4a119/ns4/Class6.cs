using System;
using System.Reflection;
using System.Security.Cryptography;

namespace ns4;

internal sealed class Class6 : IDisposable
{
	private readonly Type type_0;

	private readonly object object_0;

	public Class6()
	{
		Assembly assembly = Assembly.Load("mscorlib");
		type_0 = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider");
		object_0 = Activator.CreateInstance(type_0);
	}

	public ICryptoTransform method_0(byte[] key, byte[] iv, bool decrypt)
	{
		type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(object_0, new object[1] { key });
		type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(object_0, new object[1] { iv });
		MethodInfo method = type_0.GetMethod(decrypt ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
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
