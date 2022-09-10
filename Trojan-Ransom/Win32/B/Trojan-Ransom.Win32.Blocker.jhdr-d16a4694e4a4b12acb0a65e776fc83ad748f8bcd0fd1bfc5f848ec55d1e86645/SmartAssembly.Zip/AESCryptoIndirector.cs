using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using SmartAssembly.SmartExceptionsCore;

namespace SmartAssembly.Zip;

public sealed class AESCryptoIndirector : IDisposable
{
	private readonly Type type_0;

	private readonly object object_0;

	public AESCryptoIndirector()
	{
		Assembly assembly = default(Assembly);
		try
		{
			try
			{
				assembly = Assembly.Load("System.Core, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e");
				type_0 = assembly.GetType("System.Security.Cryptography.AesManaged");
			}
			catch (FileNotFoundException)
			{
				assembly = Assembly.Load("mscorlib");
				type_0 = assembly.GetType("System.Security.Cryptography.RijndaelManaged");
			}
			object_0 = Activator.CreateInstance(type_0);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, assembly, this);
			throw;
		}
	}

	public ICryptoTransform GetAESCryptoTransform(byte[] key, byte[] iv, bool decrypt)
	{
		object[] array = default(object[]);
		MethodInfo method = default(MethodInfo);
		try
		{
			MethodInfo? setMethod = type_0.GetProperty("Key")!.GetSetMethod();
			object obj = object_0;
			array = new object[1] { key };
			setMethod!.Invoke(obj, array);
			MethodInfo? setMethod2 = type_0.GetProperty("IV")!.GetSetMethod();
			object obj2 = object_0;
			array = new object[1] { iv };
			setMethod2!.Invoke(obj2, array);
			method = type_0.GetMethod(decrypt ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
			return (ICryptoTransform)method.Invoke(object_0, new object[0]);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, method, array, this, key, iv, decrypt);
			throw;
		}
	}

	public void Clear()
	{
		try
		{
			type_0.GetMethod("Clear")!.Invoke(object_0, new object[0]);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}

	public void Dispose()
	{
		try
		{
			Clear();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}
}
