using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace SmartAssembly.Zip;

public sealed class AESCryptoIndirector : IDisposable
{
	private readonly Type m_AcspType;

	private readonly object m_AESCryptoServiceProvider;

	public AESCryptoIndirector()
	{
		try
		{
			Assembly assembly = Assembly.Load("System.Core, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e");
			m_AcspType = assembly.GetType("System.Security.Cryptography.AesManaged");
		}
		catch (FileNotFoundException)
		{
			Assembly assembly = Assembly.Load("mscorlib");
			m_AcspType = assembly.GetType("System.Security.Cryptography.RijndaelManaged");
		}
		m_AESCryptoServiceProvider = Activator.CreateInstance(m_AcspType);
	}

	public ICryptoTransform GetAESCryptoTransform(byte[] key, byte[] iv, bool decrypt)
	{
		m_AcspType.GetProperty("Key")!.GetSetMethod()!.Invoke(m_AESCryptoServiceProvider, new object[1] { key });
		m_AcspType.GetProperty("IV")!.GetSetMethod()!.Invoke(m_AESCryptoServiceProvider, new object[1] { iv });
		MethodInfo method = m_AcspType.GetMethod(decrypt ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(m_AESCryptoServiceProvider, new object[0]);
	}

	public void Clear()
	{
		m_AcspType.GetMethod("Clear")!.Invoke(m_AESCryptoServiceProvider, new object[0]);
	}

	public void Dispose()
	{
		Clear();
	}
}
