using System;

namespace Org.BouncyCastle.Crypto.Tls;

public abstract class AbstractTlsSignerCredentials : AbstractTlsCredentials, TlsCredentials, TlsSignerCredentials
{
	public virtual SignatureAndHashAlgorithm SignatureAndHashAlgorithm
	{
		get
		{
			throw new InvalidOperationException("TlsSignerCredentials implementation does not support (D)TLS 1.2+");
		}
	}

	public abstract byte[] GenerateCertificateSignature(byte[] hash);
}
