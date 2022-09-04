using System;
using System.Reflection;
using System.Security.Cryptography;
using SmartAssembly.SmartExceptionsCore;

namespace SmartAssembly.Zip;

public sealed class DESCryptoIndirector : IDisposable
{
	internal Type type_0;

	internal object object_0;

	public DESCryptoIndirector()
	{
		Assembly assembly = default(Assembly);
		try
		{
			assembly = Assembly.Load("mscorlib");
			Type type = (type_0 = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider"));
			object obj = (object_0 = Activator.CreateInstance(type_0));
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException2(exception_, assembly, this);
			throw;
		}
	}

	public ICryptoTransform GetDESCryptoTransform(byte[] byte_0, byte[] byte_1, bool bool_0)
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
			StackFrameHelper.CreateException6(exception_, method, array, this, byte_0, byte_1, bool_0);
			throw;
		}
	}

	public void Clear()
	{
		try
		{
			type_0.GetMethod("Clear")!.Invoke(object_0, new object[0]);
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException1(exception_, this);
			throw;
		}
	}

	public void Dispose()
	{
		try
		{
			Clear();
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException1(exception_, this);
			throw;
		}
	}
}
