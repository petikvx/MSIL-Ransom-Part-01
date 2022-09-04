using System;
using System.Reflection;
using System.Security.Cryptography;
using SmartAssembly.SmartExceptionsCore;

namespace SmartAssembly.Zip;

public sealed class DESCryptoIndirector : IDisposable
{
	private readonly Type m_DcspType;

	private readonly object m_DESCryptoServiceProvider;

	public DESCryptoIndirector()
	{
		Assembly assembly = default(Assembly);
		try
		{
			assembly = Assembly.Load("mscorlib");
			m_DcspType = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider");
			m_DESCryptoServiceProvider = Activator.CreateInstance(m_DcspType);
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
		MethodInfo method = default(MethodInfo);
		try
		{
			MethodInfo? setMethod = m_DcspType.GetProperty("Key")!.GetSetMethod();
			object dESCryptoServiceProvider = m_DESCryptoServiceProvider;
			array = new object[1] { key };
			setMethod!.Invoke(dESCryptoServiceProvider, array);
			MethodInfo? setMethod2 = m_DcspType.GetProperty("IV")!.GetSetMethod();
			object dESCryptoServiceProvider2 = m_DESCryptoServiceProvider;
			array = new object[1] { iv };
			setMethod2!.Invoke(dESCryptoServiceProvider2, array);
			method = m_DcspType.GetMethod(decrypt ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
			return (ICryptoTransform)method.Invoke(m_DESCryptoServiceProvider, new object[0]);
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
			m_DcspType.GetMethod("Clear")!.Invoke(m_DESCryptoServiceProvider, new object[0]);
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
