using System;
using System.IdentityModel.Tokens;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class RemoteX509AsymmetricSecurityKey : X509AsymmetricSecurityKey, IDisposable
{
	private X509Certificate2 m_cert;

	private object m_sync;

	private bool m_disposed;

	public RemoteX509AsymmetricSecurityKey(X509Certificate2 cert)
		: base(cert)
	{
		m_cert = cert;
		if (!(m_cert.PrivateKey is RemoteCryptoRsaServiceProvider))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new NotSupportedException());
		}
		m_sync = new object();
	}

	public override AsymmetricAlgorithm GetAsymmetricAlgorithm(string algorithmUri, bool privateKey)
	{
		if (!((SecurityKey)this).IsSupportedAlgorithm(algorithmUri))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new NotSupportedException());
		}
		return ((X509AsymmetricSecurityKey)this).GetAsymmetricAlgorithm(algorithmUri, privateKey);
	}

	public override AsymmetricSignatureDeformatter GetSignatureDeformatter(string algorithmUri)
	{
		if (!((SecurityKey)this).IsSupportedAlgorithm(algorithmUri))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new NotSupportedException());
		}
		return ((X509AsymmetricSecurityKey)this).GetSignatureDeformatter(algorithmUri);
	}

	public override AsymmetricSignatureFormatter GetSignatureFormatter(string algorithmUri)
	{
		if (!((SecurityKey)this).IsSupportedAlgorithm(algorithmUri))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new NotSupportedException());
		}
		RemoteAsymmetricSignatureFormatter remoteAsymmetricSignatureFormatter = new RemoteAsymmetricSignatureFormatter();
		remoteAsymmetricSignatureFormatter.SetKey(m_cert.PrivateKey);
		return remoteAsymmetricSignatureFormatter;
	}

	public override bool IsSupportedAlgorithm(string algorithmUri)
	{
		switch (algorithmUri)
		{
		case "http://www.w3.org/2000/09/xmldsig#rsa-sha1":
		case "http://www.w3.org/2001/04/xmlenc#rsa-1_5":
		case "http://www.w3.org/2001/04/xmlenc#rsa-oaep-mgf1p":
			return ((X509AsymmetricSecurityKey)this).IsSupportedAlgorithm(algorithmUri);
		default:
			return false;
		}
	}

	void IDisposable.Dispose()
	{
		if (m_disposed)
		{
			return;
		}
		lock (m_sync)
		{
			if (!m_disposed)
			{
				m_disposed = true;
				((IDisposable)m_cert.PrivateKey)?.Dispose();
				((IDisposable)m_cert.PublicKey.Key)?.Dispose();
			}
		}
	}
}
