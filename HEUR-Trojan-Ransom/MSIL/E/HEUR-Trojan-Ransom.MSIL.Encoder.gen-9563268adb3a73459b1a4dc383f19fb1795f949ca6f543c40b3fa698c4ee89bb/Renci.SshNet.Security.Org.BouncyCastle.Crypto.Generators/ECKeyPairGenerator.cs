using System;
using Renci.SshNet.Security.Org.BouncyCastle.Crypto.Parameters;
using Renci.SshNet.Security.Org.BouncyCastle.Math;
using Renci.SshNet.Security.Org.BouncyCastle.Math.EC;
using Renci.SshNet.Security.Org.BouncyCastle.Math.EC.Multiplier;
using Renci.SshNet.Security.Org.BouncyCastle.Security;

namespace Renci.SshNet.Security.Org.BouncyCastle.Crypto.Generators;

internal class ECKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private readonly string algorithm;

	private ECDomainParameters parameters;

	private SecureRandom random;

	public ECKeyPairGenerator()
		: this("EC")
	{
	}

	public ECKeyPairGenerator(string algorithm)
	{
		if (algorithm == null)
		{
			throw new ArgumentNullException("algorithm");
		}
		this.algorithm = ECKeyParameters.VerifyAlgorithmName(algorithm);
	}

	public void Init(KeyGenerationParameters parameters)
	{
		if (parameters is ECKeyGenerationParameters)
		{
			ECKeyGenerationParameters eCKeyGenerationParameters = (ECKeyGenerationParameters)parameters;
			this.parameters = eCKeyGenerationParameters.DomainParameters;
		}
		random = parameters.Random;
		if (random == null)
		{
			random = new SecureRandom();
		}
	}

	public AsymmetricCipherKeyPair GenerateKeyPair()
	{
		BigInteger n = parameters.N;
		int num = n.BitLength >> 2;
		BigInteger bigInteger;
		do
		{
			bigInteger = new BigInteger(n.BitLength, random);
		}
		while (bigInteger.CompareTo(BigInteger.Two) < 0 || bigInteger.CompareTo(n) >= 0 || WNafUtilities.GetNafWeight(bigInteger) < num);
		ECPoint q = CreateBasePointMultiplier().Multiply(parameters.G, bigInteger);
		return new AsymmetricCipherKeyPair(new ECPublicKeyParameters(algorithm, q, parameters), new ECPrivateKeyParameters(algorithm, bigInteger, parameters));
	}

	protected virtual ECMultiplier CreateBasePointMultiplier()
	{
		return new FixedPointCombMultiplier();
	}

	internal static ECPublicKeyParameters GetCorrespondingPublicKey(ECPrivateKeyParameters privKey)
	{
		ECDomainParameters eCDomainParameters = privKey.Parameters;
		ECPoint q = new FixedPointCombMultiplier().Multiply(eCDomainParameters.G, privKey.D);
		return new ECPublicKeyParameters(privKey.AlgorithmName, q, eCDomainParameters);
	}
}
