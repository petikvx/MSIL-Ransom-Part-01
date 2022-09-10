using System;
using System.Security.Cryptography;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal sealed class RemoteCryptoRsaServiceProvider : RSA, ICspAsymmetricAlgorithm
{
	private const int CRYPT_OAEP = 64;

	private X509CertificateTokenFactoryCredential m_credential;

	private RpcCryptoContext m_context;

	private CspKeyContainerInfo m_cspInfo;

	private UIAgentRequest m_request;

	private object m_sync = new object();

	private bool m_disposed;

	CspKeyContainerInfo ICspAsymmetricAlgorithm.CspKeyContainerInfo => m_cspInfo;

	public override string KeyExchangeAlgorithm
	{
		get
		{
			if (m_credential != null && m_credential.Certificate != null && m_credential.Certificate.PublicKey != null && m_credential.Certificate.PublicKey.Key != null)
			{
				return m_credential.Certificate.PublicKey.Key.KeyExchangeAlgorithm;
			}
			return null;
		}
	}

	public override string SignatureAlgorithm
	{
		get
		{
			if (m_credential != null && m_credential.Certificate != null && m_credential.Certificate.PublicKey != null && m_credential.Certificate.PublicKey.Key != null)
			{
				return m_credential.Certificate.PublicKey.Key.SignatureAlgorithm;
			}
			return null;
		}
	}

	public override int KeySize
	{
		get
		{
			if (m_credential != null && m_credential.Certificate != null && m_credential.Certificate.PublicKey != null && m_credential.Certificate.PublicKey.Key != null)
			{
				return m_credential.Certificate.PublicKey.Key.KeySize;
			}
			return 0;
		}
		set
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new NotSupportedException());
		}
	}

	public override KeySizes[] LegalKeySizes => new KeySizes[1]
	{
		new KeySizes(KeySize, KeySize, 0)
	};

	public RemoteCryptoRsaServiceProvider(X509CertificateTokenFactoryCredential credential, UIAgentRequest request)
	{
		m_credential = credential;
		m_context = new RpcCryptoContext(m_credential.PortName, m_credential.ContextKey);
		m_cspInfo = new CspKeyContainerInfo(new CspParameters
		{
			KeyContainerName = "RpcCrypto",
			ProviderName = "RpcCrypto",
			ProviderType = 0,
			KeyNumber = 1
		});
		m_request = request;
	}

	byte[] ICspAsymmetricAlgorithm.ExportCspBlob(bool includePrivateParameters)
	{
		if (!(m_credential.Certificate.PublicKey.Key is ICspAsymmetricAlgorithm cspAsymmetricAlgorithm))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new NotSupportedException());
		}
		if (includePrivateParameters)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new NotSupportedException());
		}
		return cspAsymmetricAlgorithm.ExportCspBlob(includePrivateParameters: false);
	}

	void ICspAsymmetricAlgorithm.ImportCspBlob(byte[] rawData)
	{
		throw InfoCardTrace.ThrowHelperError((Exception)new NotSupportedException());
	}

	public byte[] SignHash(int hashAlg, byte[] hash)
	{
		ThrowIfRemoteProcessDied();
		RemoteCryptoSignHashRequest remoteCryptoSignHashRequest = new RemoteCryptoSignHashRequest(GetContext(), hashAlg, 0, hash);
		remoteCryptoSignHashRequest.Process();
		byte[] signature = remoteCryptoSignHashRequest.GetSignature();
		ThrowIfRemoteProcessDied();
		return signature;
	}

	public override byte[] DecryptValue(byte[] rgb)
	{
		ThrowIfRemoteProcessDied();
		byte[] array = new byte[rgb.Length];
		Array.Copy(rgb, 0, array, 0, rgb.Length);
		RemoteCryptoDecryptRequest remoteCryptoDecryptRequest = new RemoteCryptoDecryptRequest(GetContext(), 0, final: true, array, 0, array.Length, 0, null);
		remoteCryptoDecryptRequest.Process();
		byte[] array2 = new byte[remoteCryptoDecryptRequest.Length];
		Array.Copy(remoteCryptoDecryptRequest.GetBuffer(), remoteCryptoDecryptRequest.Index, array2, 0, remoteCryptoDecryptRequest.Length);
		ThrowIfRemoteProcessDied();
		return array2;
	}

	public override byte[] EncryptValue(byte[] rgb)
	{
		return ((RSA)m_credential.Certificate.PublicKey.Key).EncryptValue(rgb);
	}

	public override RSAParameters ExportParameters(bool includePrivateParameters)
	{
		if (!includePrivateParameters && m_credential.Certificate.PublicKey != null)
		{
			if (!(m_credential.Certificate.PublicKey.Key is RSA))
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new CryptographicException(SR.GetString("ServiceCanNotExportCertIdentityPrivateKey")));
			}
			return ((RSA)m_credential.Certificate.PublicKey.Key).ExportParameters(includePrivateParameters: false);
		}
		throw InfoCardTrace.ThrowHelperError((Exception)new CryptographicException(SR.GetString("ServiceCanNotExportCertIdentityPrivateKey")));
	}

	public override void ImportParameters(RSAParameters parameters)
	{
		throw InfoCardTrace.ThrowHelperError((Exception)new NotSupportedException());
	}

	protected override void Dispose(bool disposing)
	{
		if (m_disposed)
		{
			return;
		}
		lock (m_sync)
		{
			if (!m_disposed)
			{
				((IDisposable)m_context).Dispose();
				m_disposed = true;
			}
		}
	}

	private RpcCryptoContext GetContext()
	{
		if (!m_context.IsOpen)
		{
			m_context.Open();
		}
		return m_context;
	}

	private void ThrowIfRemoteProcessDied()
	{
		if (!m_request.ParentRequest.UIAgentActive)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new CryptographicException(SR.GetString("RemoteCryptoSessionUnavailable")));
		}
	}
}
