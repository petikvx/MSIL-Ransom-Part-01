using System;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Signers;

public class ECNRSigner : IDsa, IDsaExt
{
	private bool forSigning;

	private ECKeyParameters key;

	private SecureRandom random;

	public virtual string AlgorithmName => "ECNR";

	public virtual BigInteger Order => key.Parameters.N;

	public virtual void Init(bool forSigning, ICipherParameters parameters)
	{
		this.forSigning = forSigning;
		if (forSigning)
		{
			if (parameters is ParametersWithRandom)
			{
				ParametersWithRandom parametersWithRandom = (ParametersWithRandom)parameters;
				random = parametersWithRandom.Random;
				parameters = parametersWithRandom.Parameters;
			}
			else
			{
				random = new SecureRandom();
			}
			if (!(parameters is ECPrivateKeyParameters))
			{
				throw new InvalidKeyException("EC private key required for signing");
			}
			key = (ECPrivateKeyParameters)parameters;
		}
		else
		{
			if (!(parameters is ECPublicKeyParameters))
			{
				throw new InvalidKeyException("EC public key required for verification");
			}
			key = (ECPublicKeyParameters)parameters;
		}
	}

	public virtual BigInteger[] GenerateSignature(byte[] message)
	{
		if (!forSigning)
		{
			throw new InvalidOperationException("not initialised for signing");
		}
		BigInteger order = Order;
		int bitLength = order.BitLength;
		BigInteger bigInteger = new BigInteger(1, message);
		int bitLength2 = bigInteger.BitLength;
		ECPrivateKeyParameters eCPrivateKeyParameters = (ECPrivateKeyParameters)key;
		if (bitLength2 > bitLength)
		{
			throw new DataLengthException("input too large for ECNR key.");
		}
		BigInteger bigInteger2 = null;
		BigInteger bigInteger3 = null;
		AsymmetricCipherKeyPair asymmetricCipherKeyPair;
		do
		{
			ECKeyPairGenerator eCKeyPairGenerator = new ECKeyPairGenerator();
			eCKeyPairGenerator.Init(new ECKeyGenerationParameters(eCPrivateKeyParameters.Parameters, random));
			asymmetricCipherKeyPair = eCKeyPairGenerator.GenerateKeyPair();
			bigInteger2 = ((ECPublicKeyParameters)asymmetricCipherKeyPair.Public).Q.AffineXCoord.ToBigInteger().Add(bigInteger).Mod(order);
		}
		while (bigInteger2.SignValue == 0);
		BigInteger d = eCPrivateKeyParameters.D;
		bigInteger3 = ((ECPrivateKeyParameters)asymmetricCipherKeyPair.Private).D.Subtract(bigInteger2.Multiply(d)).Mod(order);
		return new BigInteger[2] { bigInteger2, bigInteger3 };
	}

	public virtual bool VerifySignature(byte[] message, BigInteger r, BigInteger s)
	{
		if (forSigning)
		{
			throw new InvalidOperationException("not initialised for verifying");
		}
		ECPublicKeyParameters eCPublicKeyParameters = (ECPublicKeyParameters)key;
		BigInteger n = eCPublicKeyParameters.Parameters.N;
		int bitLength = n.BitLength;
		BigInteger bigInteger = new BigInteger(1, message);
		if (bigInteger.BitLength > bitLength)
		{
			throw new DataLengthException("input too large for ECNR key.");
		}
		if (r.CompareTo(BigInteger.One) >= 0 && r.CompareTo(n) < 0)
		{
			if (s.CompareTo(BigInteger.Zero) >= 0 && s.CompareTo(n) < 0)
			{
				ECPoint g = eCPublicKeyParameters.Parameters.G;
				ECPoint q = eCPublicKeyParameters.Q;
				ECPoint eCPoint = ECAlgorithms.SumOfTwoMultiplies(g, s, q, r).Normalize();
				if (eCPoint.IsInfinity)
				{
					return false;
				}
				BigInteger n2 = eCPoint.AffineXCoord.ToBigInteger();
				return r.Subtract(n2).Mod(n).Equals(bigInteger);
			}
			return false;
		}
		return false;
	}
}
