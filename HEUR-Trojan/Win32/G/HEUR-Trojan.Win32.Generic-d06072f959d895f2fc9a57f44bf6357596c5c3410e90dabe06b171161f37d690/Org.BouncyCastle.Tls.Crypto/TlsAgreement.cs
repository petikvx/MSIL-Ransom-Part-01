namespace Org.BouncyCastle.Tls.Crypto;

public interface TlsAgreement
{
	byte[] GenerateEphemeral();

	void ReceivePeerValue(byte[] peerValue);

	TlsSecret CalculateSecret();
}
