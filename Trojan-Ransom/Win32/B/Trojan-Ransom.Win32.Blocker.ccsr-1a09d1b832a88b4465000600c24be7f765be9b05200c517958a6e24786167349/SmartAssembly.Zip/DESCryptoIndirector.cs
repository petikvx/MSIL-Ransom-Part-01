using System;
using System.Reflection;
using System.Security.Cryptography;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;
using ns0;

namespace SmartAssembly.Zip;

public sealed class DESCryptoIndirector : IDisposable
{
	private static bool bool_0;

	internal Type type_0;

	internal object object_0;

	public DESCryptoIndirector()
	{
		Assembly assembly = default(Assembly);
		try
		{
			assembly = Assembly.Load("mscorlib");
			Type type = (type_0 = Class19.smethod_2(assembly, "System.Security.Cryptography.DESCryptoServiceProvider", 373, 357));
			object obj = (object_0 = FatalExceptionEventArgs.smethod_0(type_0, 576, 582));
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, assembly, this);
			throw;
		}
	}

	public ICryptoTransform GetDESCryptoTransform(byte[] key, byte[] iv, bool decrypt)
	{
		object[] array = default(object[]);
		MethodInfo methodInfo = default(MethodInfo);
		try
		{
			MethodInfo methodBase_ = SmartAssembly.SmartExceptionsCore.DoNotObfuscateAttribute.smethod_0(SimpleZip.Stream0.smethod_0(type_0, "Key", 803, 861), 118, 113);
			object obj = object_0;
			array = new object[1] { key };
			Class33.smethod_8(methodBase_, obj, array, 479, 463);
			MethodInfo methodBase_2 = SmartAssembly.SmartExceptionsCore.DoNotObfuscateAttribute.smethod_0(SimpleZip.Stream0.smethod_0(type_0, "IV", 134, 248), 303, 296);
			object obj2 = object_0;
			array = new object[1] { iv };
			Class33.smethod_8(methodBase_2, obj2, array, 163, 179);
			methodInfo = UsageCounts.smethod_0(type_0, decrypt ? "CreateDecryptor" : "CreateEncryptor", new Type[0], 910, 954);
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
			Class33.smethod_8(Class20.smethod_0(type_0, "Clear", 932, 903), object_0, new object[0], 263, 279);
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

	static DESCryptoIndirector()
	{
		smethod_0();
	}

	internal static void smethod_0()
	{
		if (bool_0)
		{
			return;
		}
		lock (typeof(DESCryptoIndirector))
		{
			if (!bool_0)
			{
				bool_0 = true;
				AppDomain.CurrentDomain.ResourceResolve += SecurityExceptionEventArgs.smethod_0;
			}
		}
	}
}
