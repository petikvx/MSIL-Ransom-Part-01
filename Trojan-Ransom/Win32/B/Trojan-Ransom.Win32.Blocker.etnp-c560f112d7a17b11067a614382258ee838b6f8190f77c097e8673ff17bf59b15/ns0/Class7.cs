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
		Assembly assembly = default(Assembly);
		try
		{
			assembly = Assembly.Load("mscorlib");
			type_0 = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider");
			object_0 = Activator.CreateInstance(type_0);
		}
		catch (Exception cO_)
		{
			Class29.smethod_2(cO_, assembly, this);
			throw;
		}
	}

	public ICryptoTransform method_0(byte[] CO_, byte[] CO_, bool CO_)
	{
		object[] array = default(object[]);
		MethodInfo method = default(MethodInfo);
		try
		{
			MethodInfo? setMethod = type_0.GetProperty("Key")!.GetSetMethod();
			object obj = object_0;
			array = new object[1] { CO_ };
			setMethod!.Invoke(obj, array);
			MethodInfo? setMethod2 = type_0.GetProperty("IV")!.GetSetMethod();
			object obj2 = object_0;
			array = new object[1] { CO_ };
			setMethod2!.Invoke(obj2, array);
			method = type_0.GetMethod(CO_ ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
			return (ICryptoTransform)method.Invoke(object_0, new object[0]);
		}
		catch (Exception cO_)
		{
			Class29.smethod_6(cO_, method, array, this, CO_, CO_, CO_);
			throw;
		}
	}

	public void method_1()
	{
		try
		{
			type_0.GetMethod("Clear")!.Invoke(object_0, new object[0]);
		}
		catch (Exception cO_)
		{
			Class29.smethod_1(cO_, this);
			throw;
		}
	}

	public void Dispose()
	{
		try
		{
			method_1();
		}
		catch (Exception cO_)
		{
			Class29.smethod_1(cO_, this);
			throw;
		}
	}
}
