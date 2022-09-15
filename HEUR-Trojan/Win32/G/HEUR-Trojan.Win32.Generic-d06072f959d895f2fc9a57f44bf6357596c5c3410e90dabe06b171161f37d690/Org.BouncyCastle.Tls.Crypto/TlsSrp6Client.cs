using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Tls.Crypto;

public interface TlsSrp6Client
{
	BigInteger CalculateSecret(BigInteger serverB);

	BigInteger GenerateClientCredentials(byte[] salt, byte[] identity, byte[] password);
}
