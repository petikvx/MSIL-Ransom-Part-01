using System;
using System.Reflection;
using System.Security.Cryptography;

namespace SmartAssembly.Zip;

public sealed class DESCryptoIndirector : IDisposable
{
	private readonly Type m_DcspType;

	private readonly object m_DESCryptoServiceProvider;

	public DESCryptoIndirector()
	{
		Assembly assembly = Assembly.Load("mscorlib");
		m_DcspType = assembly.GetType("System.Security.Cryptography.DESCryptoServiceProvider");
		m_DESCryptoServiceProvider = Activator.CreateInstance(m_DcspType);
	}

	public ICryptoTransform GetDESCryptoTransform(byte[] key, byte[] iv, bool decrypt)
	{
		m_DcspType.GetProperty("Key")!.GetSetMethod()!.Invoke(m_DESCryptoServiceProvider, new object[1] { key });
		m_DcspType.GetProperty("IV")!.GetSetMethod()!.Invoke(m_DESCryptoServiceProvider, new object[1] { iv });
		MethodInfo method = m_DcspType.GetMethod(decrypt ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(m_DESCryptoServiceProvider, new object[0]);
	}

	public void Clear()
	{
		m_DcspType.GetMethod("Clear")!.Invoke(m_DESCryptoServiceProvider, new object[0]);
	}

	public void Dispose()
	{
		Clear();
	}
}
