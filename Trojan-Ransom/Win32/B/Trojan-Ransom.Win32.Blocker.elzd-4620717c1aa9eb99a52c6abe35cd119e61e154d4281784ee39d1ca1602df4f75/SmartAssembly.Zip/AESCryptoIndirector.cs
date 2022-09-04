using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using SmartAssembly.SmartExceptionsCore;

namespace SmartAssembly.Zip;

public sealed class AESCryptoIndirector : IDisposable
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1218)]
	private struct Struct5
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1300)]
	private struct Struct6
	{
	}

	private readonly object object_0;

	private static readonly object object_1;

	private static readonly object object_2 = new char[609];

	private static readonly Array array_0;

	internal static byte byte_0/* Not supported: data(00) */;

	private static readonly object object_3;

	private static readonly Array array_1;

	private static readonly object object_4;

	internal static byte byte_1/* Not supported: data(00) */;

	internal Type type_0;

	public AESCryptoIndirector()
	{
		Assembly assembly = default(Assembly);
		try
		{
			try
			{
				assembly = Assembly.Load("System.Core, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e");
				Type type = (type_0 = assembly.GetType("System.Security.Cryptography.AesManaged"));
			}
			catch (FileNotFoundException)
			{
				assembly = Assembly.Load("mscorlib");
				Type type2 = (type_0 = assembly.GetType("System.Security.Cryptography.RijndaelManaged"));
			}
			object_0 = Activator.CreateInstance(type_0);
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException2(exception_, assembly, this);
			throw;
		}
	}

	public ICryptoTransform GetAESCryptoTransform(byte[] byte_2, byte[] byte_3, bool bool_0)
	{
		object[] array = default(object[]);
		MethodInfo method = default(MethodInfo);
		try
		{
			MethodInfo? setMethod = type_0.GetProperty("Key")!.GetSetMethod();
			object obj = object_0;
			array = new object[1] { byte_2 };
			setMethod!.Invoke(obj, array);
			MethodInfo? setMethod2 = type_0.GetProperty("IV")!.GetSetMethod();
			object obj2 = object_0;
			array = new object[1] { byte_3 };
			setMethod2!.Invoke(obj2, array);
			method = type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
			return (ICryptoTransform)method.Invoke(object_0, new object[0]);
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException6(exception_, method, array, this, byte_2, byte_3, bool_0);
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

	static AESCryptoIndirector()
	{
		char[] array = new char[8];
		array[3] = '⽮';
		array[7] = '✜';
		array[0] = '┒';
		array[4] = '㡍';
		array[2] = '㪡';
		array[5] = '㼚';
		array[1] = '៰';
		array[6] = '\u10c9';
		array_0 = new string[41];
		object_1 = array;
		array_1 = new char[650];
		char[] array2 = new char[8];
		array2[4] = '㡍';
		array2[5] = '㼚';
		array2[3] = '⽮';
		array2[1] = '៰';
		array2[7] = '✜';
		array2[6] = '\u10c9';
		array2[0] = '┒';
		array2[2] = '㪡';
		object_4 = new string[45];
		object_3 = array2;
	}
}
