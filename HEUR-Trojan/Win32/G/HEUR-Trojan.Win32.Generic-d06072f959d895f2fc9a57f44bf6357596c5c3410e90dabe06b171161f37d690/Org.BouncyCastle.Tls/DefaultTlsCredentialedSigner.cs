using System;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Tls.Crypto.Impl;

namespace Org.BouncyCastle.Tls;

public class DefaultTlsCredentialedSigner : TlsCredentialedSigner, TlsCredentials
{
	protected readonly TlsCryptoParameters m_cryptoParams;

	protected readonly Certificate m_certificate;

	protected readonly SignatureAndHashAlgorithm m_signatureAndHashAlgorithm;

	protected readonly TlsSigner m_signer;

	public virtual Certificate Certificate => m_certificate;

	public virtual SignatureAndHashAlgorithm SignatureAndHashAlgorithm => m_signatureAndHashAlgorithm;

	public DefaultTlsCredentialedSigner(TlsCryptoParameters cryptoParams, TlsSigner signer, Certificate certificate, SignatureAndHashAlgorithm signatureAndHashAlgorithm)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		if (certificate.IsEmpty)
		{
			throw new ArgumentException("cannot be empty", "certificate");
		}
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		m_cryptoParams = cryptoParams;
		m_certificate = certificate;
		m_signatureAndHashAlgorithm = signatureAndHashAlgorithm;
		m_signer = signer;
	}

	public virtual byte[] GenerateRawSignature(byte[] hash)
	{
		return m_signer.GenerateRawSignature(GetEffectiveAlgorithm(), hash);
	}

	public virtual TlsStreamSigner GetStreamSigner()
	{
		return m_signer.GetStreamSigner(GetEffectiveAlgorithm());
	}

	protected virtual SignatureAndHashAlgorithm GetEffectiveAlgorithm()
	{
		SignatureAndHashAlgorithm signatureAndHashAlgorithm = null;
		if (TlsImplUtilities.IsTlsV12(m_cryptoParams))
		{
			signatureAndHashAlgorithm = SignatureAndHashAlgorithm;
			if (signatureAndHashAlgorithm == null)
			{
				throw new InvalidOperationException("'signatureAndHashAlgorithm' cannot be null for (D)TLS 1.2+");
			}
		}
		return signatureAndHashAlgorithm;
	}
}
