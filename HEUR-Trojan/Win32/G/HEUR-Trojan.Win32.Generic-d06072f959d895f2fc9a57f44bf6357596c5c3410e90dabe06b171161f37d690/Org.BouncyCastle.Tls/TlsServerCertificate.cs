namespace Org.BouncyCastle.Tls;

public interface TlsServerCertificate
{
	Certificate Certificate { get; }

	CertificateStatus CertificateStatus { get; }
}
