using System;
using System.Collections;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls;

public sealed class CertificateEntry
{
	private readonly TlsCertificate m_certificate;

	private readonly IDictionary m_extensions;

	public TlsCertificate Certificate => m_certificate;

	public IDictionary Extensions => m_extensions;

	public CertificateEntry(TlsCertificate certificate, IDictionary extensions)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		m_certificate = certificate;
		m_extensions = extensions;
	}
}
