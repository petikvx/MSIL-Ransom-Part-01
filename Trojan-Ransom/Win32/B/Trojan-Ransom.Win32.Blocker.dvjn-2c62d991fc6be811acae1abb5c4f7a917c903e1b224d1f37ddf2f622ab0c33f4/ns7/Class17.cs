using System;
using System.Reflection;
using System.Security.Cryptography;
using ns3;

namespace ns7;

internal sealed class Class17 : IDisposable
{
	private readonly Type type_0;

	private readonly object object_0;

	public Class17()
	{
		Assembly assembly = default(Assembly);
		try
		{
			assembly = Assembly.Load("mscorlib");
			type_0 = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider");
			object_0 = Activator.CreateInstance(type_0);
		}
		catch (Exception exception_)
		{
			Class38.smethod_2(exception_, assembly, this);
			throw;
		}
	}

	public ICryptoTransform method_0(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		object[] array = default(object[]);
		MethodInfo method = default(MethodInfo);
		try
		{
			MethodInfo? setMethod = type_0.GetProperty("Key")!.GetSetMethod();
			object obj = object_0;
			array = new object[1] { byte_0 };
			setMethod!.Invoke(obj, array);
			MethodInfo? setMethod2 = type_0.GetProperty("IV")!.GetSetMethod();
			object obj2 = object_0;
			array = new object[1] { byte_1 };
			setMethod2!.Invoke(obj2, array);
			method = type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
			return (ICryptoTransform)method.Invoke(object_0, new object[0]);
		}
		catch (Exception exception_)
		{
			Class38.smethod_6(exception_, method, array, this, byte_0, byte_1, bool_0);
			throw;
		}
	}

	public void method_1()
	{
		try
		{
			type_0.GetMethod("Clear")!.Invoke(object_0, new object[0]);
		}
		catch (Exception exception_)
		{
			Class38.smethod_1(exception_, this);
			throw;
		}
	}

	void IDisposable.Dispose()
	{
		try
		{
			method_1();
		}
		catch (Exception exception_)
		{
			Class38.smethod_1(exception_, this);
			throw;
		}
	}
}
