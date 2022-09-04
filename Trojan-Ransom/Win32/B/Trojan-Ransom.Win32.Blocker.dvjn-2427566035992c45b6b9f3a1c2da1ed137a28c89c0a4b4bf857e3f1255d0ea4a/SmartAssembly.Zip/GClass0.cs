using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using SmartAssembly.SmartExceptionsCore;

namespace SmartAssembly.Zip;

public sealed class GClass0 : IDisposable
{
	private readonly Type m_AcspType;

	private readonly object m_AESCryptoServiceProvider;

	public GClass0()
	{
		Class2.l4t8M9wzGUypc();
		base._002Ector();
		Assembly assembly = default(Assembly);
		try
		{
			try
			{
				assembly = Assembly.Load("System.Core, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e");
				m_AcspType = assembly.GetType("System.Security.Cryptography.AesManaged");
			}
			catch (FileNotFoundException)
			{
				assembly = Assembly.Load("mscorlib");
				m_AcspType = assembly.GetType("System.Security.Cryptography.RijndaelManaged");
			}
			m_AESCryptoServiceProvider = Activator.CreateInstance(m_AcspType);
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
			MethodInfo? setMethod = m_AcspType.GetProperty("Key")!.GetSetMethod();
			object aESCryptoServiceProvider = m_AESCryptoServiceProvider;
			array = new object[1] { key };
			setMethod!.Invoke(aESCryptoServiceProvider, array);
			MethodInfo? setMethod2 = m_AcspType.GetProperty("IV")!.GetSetMethod();
			object aESCryptoServiceProvider2 = m_AESCryptoServiceProvider;
			array = new object[1] { iv };
			setMethod2!.Invoke(aESCryptoServiceProvider2, array);
			method = m_AcspType.GetMethod(decrypt ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
			return (ICryptoTransform)method.Invoke(m_AESCryptoServiceProvider, new object[0]);
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
			m_AcspType.GetMethod("Clear")!.Invoke(m_AESCryptoServiceProvider, new object[0]);
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
