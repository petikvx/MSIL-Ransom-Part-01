using System;
using System.Reflection;
using System.Security.Cryptography;
using SmartAssembly.SmartExceptionsCore;

namespace SmartAssembly.Zip;

public sealed class GClass1 : IDisposable
{
	private readonly Type m_DcspType;

	private readonly object m_DESCryptoServiceProvider;

	public GClass1()
	{
		Assembly assembly = default(Assembly);
		try
		{
			assembly = Assembly.Load("mscorlib");
			m_DcspType = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider");
			m_DESCryptoServiceProvider = Activator.CreateInstance(m_DcspType);
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
			MethodInfo? setMethod = m_DcspType.GetProperty("Key")!.GetSetMethod();
			object dESCryptoServiceProvider = m_DESCryptoServiceProvider;
			array = new object[1] { byte_0 };
			setMethod!.Invoke(dESCryptoServiceProvider, array);
			MethodInfo? setMethod2 = m_DcspType.GetProperty("IV")!.GetSetMethod();
			object dESCryptoServiceProvider2 = m_DESCryptoServiceProvider;
			array = new object[1] { byte_1 };
			setMethod2!.Invoke(dESCryptoServiceProvider2, array);
			method = m_DcspType.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
			return (ICryptoTransform)method.Invoke(m_DESCryptoServiceProvider, new object[0]);
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
			m_DcspType.GetMethod("Clear")!.Invoke(m_DESCryptoServiceProvider, new object[0]);
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
