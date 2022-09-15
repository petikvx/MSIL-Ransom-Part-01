using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls;

public interface TlsCredentialedAgreement : TlsCredentials
{
	TlsSecret GenerateAgreement(TlsCertificate peerCertificate);
}
