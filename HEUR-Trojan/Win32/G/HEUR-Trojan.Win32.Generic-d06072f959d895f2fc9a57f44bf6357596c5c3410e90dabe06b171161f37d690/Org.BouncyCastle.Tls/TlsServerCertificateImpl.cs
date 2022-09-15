namespace Org.BouncyCastle.Tls;

internal sealed class TlsServerCertificateImpl : TlsServerCertificate
{
	private readonly Certificate m_certificate;

	private readonly CertificateStatus m_certificateStatus;

	public Certificate Certificate => m_certificate;

	public CertificateStatus CertificateStatus => m_certificateStatus;

	internal TlsServerCertificateImpl(Certificate certificate, CertificateStatus certificateStatus)
	{
		m_certificate = certificate;
		m_certificateStatus = certificateStatus;
	}
}
