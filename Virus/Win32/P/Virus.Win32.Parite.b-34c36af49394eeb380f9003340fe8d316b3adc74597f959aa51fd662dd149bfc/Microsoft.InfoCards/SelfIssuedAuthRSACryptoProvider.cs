using System;
using System.Security.Cryptography;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class SelfIssuedAuthRSACryptoProvider : RSA
{
	private RSACryptoServiceProvider m_rsa;

	public override string SignatureAlgorithm => m_rsa.SignatureAlgorithm;

	public override string KeyExchangeAlgorithm => m_rsa.KeyExchangeAlgorithm;

	public SelfIssuedAuthRSACryptoProvider(RSACryptoServiceProvider rsa)
	{
		m_rsa = rsa;
	}

	public bool IsPublicOnly()
	{
		return m_rsa.PublicOnly;
	}

	public override byte[] EncryptValue(byte[] rgb)
	{
		throw InfoCardTrace.ThrowHelperError((Exception)new NotSupportedException());
	}

	public override byte[] DecryptValue(byte[] rgb)
	{
		throw InfoCardTrace.ThrowHelperError((Exception)new NotSupportedException());
	}

	public byte[] Decrypt(byte[] inData, bool fAOEP)
	{
		throw InfoCardTrace.ThrowHelperError((Exception)new NotSupportedException());
	}

	public byte[] Encrypt(byte[] inData, bool fAOEP)
	{
		throw InfoCardTrace.ThrowHelperError((Exception)new NotSupportedException());
	}

	public byte[] SignHash(byte[] hash, string hashAlgOid)
	{
		InfoCardTrace.ThrowInvalidArgumentConditional(hash == null || 0 == hash.Length, "hash");
		InfoCardTrace.ThrowInvalidArgumentConditional(string.IsNullOrEmpty(hashAlgOid), "hashAlgOid");
		return m_rsa.SignHash(hash, hashAlgOid);
	}

	public bool VerifyHash(byte[] hash, string hashAlgOid, byte[] sig)
	{
		InfoCardTrace.ThrowInvalidArgumentConditional(hash == null || 0 == hash.Length, "hash");
		InfoCardTrace.ThrowInvalidArgumentConditional(string.IsNullOrEmpty(hashAlgOid), "hashAlgOid");
		InfoCardTrace.ThrowInvalidArgumentConditional(sig == null || 0 == sig.Length, "sig");
		return m_rsa.VerifyHash(hash, hashAlgOid, sig);
	}

	public override RSAParameters ExportParameters(bool includePrivateParameters)
	{
		throw InfoCardTrace.ThrowHelperError((Exception)new NotSupportedException());
	}

	public override string ToXmlString(bool includePrivateParameters)
	{
		throw InfoCardTrace.ThrowHelperError((Exception)new NotSupportedException());
	}

	public override void FromXmlString(string xmlString)
	{
		throw InfoCardTrace.ThrowHelperError((Exception)new NotSupportedException());
	}

	public override void ImportParameters(RSAParameters parameters)
	{
		throw InfoCardTrace.ThrowHelperError((Exception)new NotSupportedException());
	}

	protected override void Dispose(bool disposing)
	{
		if (m_rsa != null)
		{
			((IDisposable)m_rsa).Dispose();
		}
	}
}
