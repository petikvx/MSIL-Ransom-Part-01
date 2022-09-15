using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Tls.Crypto;

public interface TlsSrp6VerifierGenerator
{
	BigInteger GenerateVerifier(byte[] salt, byte[] identity, byte[] password);
}
