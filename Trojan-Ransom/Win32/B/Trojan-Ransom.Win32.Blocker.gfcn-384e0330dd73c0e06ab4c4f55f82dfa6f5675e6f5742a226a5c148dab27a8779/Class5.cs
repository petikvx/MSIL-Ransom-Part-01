using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

internal sealed class Class5 : IDisposable
{
	private readonly Type type_0;

	private readonly object object_0;

	public Class5()
	{
		Class52.KPUgGmhz2nAeI();
		base._002Ector();
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
		catch (Exception exception_)
		{
			Class25.smethod_2(exception_, assembly, this);
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
			Class25.smethod_6(exception_, method, array, this, byte_0, byte_1, bool_0);
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
			Class25.smethod_1(exception_, this);
			throw;
		}
	}

	public void Dispose()
	{
		try
		{
			method_1();
		}
		catch (Exception exception_)
		{
			Class25.smethod_1(exception_, this);
			throw;
		}
	}
}
