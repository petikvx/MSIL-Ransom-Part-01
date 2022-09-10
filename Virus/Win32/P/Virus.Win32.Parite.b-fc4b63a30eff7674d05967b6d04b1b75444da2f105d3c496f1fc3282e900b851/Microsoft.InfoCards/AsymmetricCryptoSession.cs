using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Security.Principal;

namespace Microsoft.InfoCards;

internal class AsymmetricCryptoSession : CryptoSession
{
	private RSACryptoServiceProvider m_provider;

	public AsymmetricCryptoSession(Process process, DateTime expirationTime, WindowsIdentity identity, RSACryptoServiceProvider key)
		: base(process, expirationTime, identity, key, SessionType.Asymmetric)
	{
		m_provider = key;
	}

	protected override void OnWrite(BinaryWriter bwriter)
	{
		bwriter.Write(m_provider.KeySize);
		Utility.SerializeString(bwriter, m_provider.KeyExchangeAlgorithm);
		Utility.SerializeString(bwriter, m_provider.SignatureAlgorithm);
	}

	protected override void OnDispose()
	{
		m_provider.Clear();
		((IDisposable)m_provider).Dispose();
		m_provider = null;
	}

	public byte[] Encrypt(bool fOAEP, byte[] inData)
	{
		ThrowIfDisposed();
		return m_provider.Encrypt(inData, fOAEP);
	}

	public byte[] Decrypt(bool fOAEP, byte[] inData)
	{
		ThrowIfDisposed();
		return m_provider.Decrypt(inData, fOAEP);
	}

	public byte[] SignHash(byte[] hash, string hashAlgOid)
	{
		ThrowIfDisposed();
		return m_provider.SignHash(hash, hashAlgOid);
	}

	public bool VerifyHash(byte[] hash, string hashAlgOid, byte[] sig)
	{
		ThrowIfDisposed();
		return m_provider.VerifyHash(hash, hashAlgOid, sig);
	}
}
