using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Tls.Crypto;

public interface TlsSrp6Server
{
	BigInteger GenerateServerCredentials();

	BigInteger CalculateSecret(BigInteger clientA);
}
