namespace Org.BouncyCastle.Tls;

public interface TlsAuthentication
{
	void NotifyServerCertificate(TlsServerCertificate serverCertificate);

	TlsCredentials GetClientCredentials(CertificateRequest certificateRequest);
}
