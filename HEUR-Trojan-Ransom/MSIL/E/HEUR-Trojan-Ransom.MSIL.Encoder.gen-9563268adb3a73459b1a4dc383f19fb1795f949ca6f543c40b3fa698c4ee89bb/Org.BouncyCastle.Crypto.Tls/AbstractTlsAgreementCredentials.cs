namespace Org.BouncyCastle.Crypto.Tls;

public abstract class AbstractTlsAgreementCredentials : AbstractTlsCredentials, TlsCredentials, TlsAgreementCredentials
{
	public abstract byte[] GenerateAgreement(AsymmetricKeyParameter peerPublicKey);
}
