using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Generators;

public class DHBasicKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private DHKeyGenerationParameters param;

	public virtual void Init(KeyGenerationParameters parameters)
	{
		param = (DHKeyGenerationParameters)parameters;
	}

	public virtual AsymmetricCipherKeyPair GenerateKeyPair()
	{
		DHKeyGeneratorHelper instance = DHKeyGeneratorHelper.Instance;
		DHParameters parameters = param.Parameters;
		BigInteger x = instance.CalculatePrivate(parameters, param.Random);
		return new AsymmetricCipherKeyPair(new DHPublicKeyParameters(instance.CalculatePublic(parameters, x), parameters), new DHPrivateKeyParameters(x, parameters));
	}
}
