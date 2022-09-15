using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators;

public class X448KeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private SecureRandom random;

	public virtual void Init(KeyGenerationParameters parameters)
	{
		random = parameters.Random;
	}

	public virtual AsymmetricCipherKeyPair GenerateKeyPair()
	{
		X448PrivateKeyParameters x448PrivateKeyParameters = new X448PrivateKeyParameters(random);
		return new AsymmetricCipherKeyPair(x448PrivateKeyParameters.GeneratePublicKey(), x448PrivateKeyParameters);
	}
}
