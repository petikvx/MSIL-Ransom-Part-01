using System;
using System.Reflection;
using System.Security.Cryptography;

namespace ns0;

internal sealed class Class7 : IDisposable
{
	private readonly Type type_0;

	private readonly object object_0;

	public Class7()
	{
		Assembly assembly = Assembly.Load("mscorlib");
		type_0 = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider");
		object_0 = Activator.CreateInstance(type_0);
	}

	public icryptoTransform method_0(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(object_0, new object[1] { byte_0 });
		type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(object_0, new object[1] { byte_1 });
		MethodInfo method = type_0.GetMethod(bool_0 ? "Createdecryptor" : "CreateEncryptor", new Type[0]);
		return (icryptoTransform)method.Invoke(object_0, new object[0]);
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
