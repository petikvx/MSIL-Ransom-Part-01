using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;
using ns0;

namespace SmartAssembly.Zip;

public sealed class AESCryptoIndirector : IDisposable
{
	internal Type type_0;

	internal object object_0;

	public AESCryptoIndirector()
	{
		Assembly assembly = default(Assembly);
		try
		{
			try
			{
				assembly = Assembly.Load("System.Core, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e");
				Type type = (type_0 = Class19.smethod_2(assembly, "System.Security.Cryptography.AesManaged", 303, 319));
			}
			catch (FileNotFoundException)
			{
				assembly = Assembly.Load("mscorlib");
				Type type2 = (type_0 = Class19.smethod_2(assembly, "System.Security.Cryptography.RijndaelManaged", 910, 926));
			}
			object obj = (object_0 = Activator.CreateInstance(type_0));
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
		MethodInfo methodInfo = default(MethodInfo);
		try
		{
			MethodInfo methodBase_ = SmartAssembly.SmartExceptionsCore.DoNotObfuscateAttribute.smethod_0(SimpleZip.Stream0.smethod_0(type_0, "Key", 152, 230), 833, 838);
			object obj = object_0;
			array = new object[1] { key };
			Class33.smethod_8(methodBase_, obj, array, 822, 806);
			MethodInfo methodBase_2 = SmartAssembly.SmartExceptionsCore.DoNotObfuscateAttribute.smethod_0(SimpleZip.Stream0.smethod_0(type_0, "IV", 731, 677), 142, 137);
			object obj2 = object_0;
			array = new object[1] { iv };
			Class33.smethod_8(methodBase_2, obj2, array, 367, 383);
			methodInfo = UsageCounts.smethod_0(type_0, decrypt ? "CreateDecryptor" : "CreateEncryptor", new Type[0], 140, 184);
			return (ICryptoTransform)methodInfo.Invoke(object_0, new object[0]);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, methodInfo, array, this, key, iv, decrypt);
			throw;
		}
	}

	public void Clear()
	{
		try
		{
			Class33.smethod_8(Class20.smethod_0(type_0, "Clear", 651, 680), object_0, new object[0], 124, 108);
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

	static AESCryptoIndirector()
	{
		DESCryptoIndirector.smethod_0();
	}
}
