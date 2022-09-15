namespace Org.BouncyCastle.Tls.Crypto;

public interface TlsVerifier
{
	TlsStreamVerifier GetStreamVerifier(DigitallySigned signature);

	bool VerifyRawSignature(DigitallySigned signature, byte[] hash);
}
