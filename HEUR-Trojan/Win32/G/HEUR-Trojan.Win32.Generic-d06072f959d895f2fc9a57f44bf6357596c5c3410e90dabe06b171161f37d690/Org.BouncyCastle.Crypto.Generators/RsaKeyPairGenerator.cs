using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Generators;

public class RsaKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private static readonly int[] SPECIAL_E_VALUES = new int[5] { 3, 5, 17, 257, 65537 };

	private static readonly int SPECIAL_E_HIGHEST = SPECIAL_E_VALUES[SPECIAL_E_VALUES.Length - 1];

	private static readonly int SPECIAL_E_BITS = BigInteger.ValueOf(SPECIAL_E_HIGHEST).BitLength;

	protected static readonly BigInteger One = BigInteger.One;

	protected static readonly BigInteger DefaultPublicExponent = BigInteger.ValueOf(65537L);

	protected const int DefaultTests = 100;

	protected RsaKeyGenerationParameters parameters;

	public virtual void Init(KeyGenerationParameters parameters)
	{
		if (parameters is RsaKeyGenerationParameters)
		{
			this.parameters = (RsaKeyGenerationParameters)parameters;
		}
		else
		{
			this.parameters = new RsaKeyGenerationParameters(DefaultPublicExponent, parameters.Random, parameters.Strength, 100);
		}
	}

	public virtual AsymmetricCipherKeyPair GenerateKeyPair()
	{
		int num2;
		BigInteger publicExponent;
		BigInteger bigInteger;
		BigInteger bigInteger2;
		BigInteger bigInteger3;
		BigInteger bigInteger5;
		BigInteger bigInteger6;
		BigInteger bigInteger7;
		do
		{
			int strength = parameters.Strength;
			int num = (strength + 1) / 2;
			num2 = strength - num;
			int num3 = strength / 3;
			int num4 = strength >> 2;
			publicExponent = parameters.PublicExponent;
			bigInteger = ChooseRandomPrime(num, publicExponent);
			while (true)
			{
				bigInteger2 = ChooseRandomPrime(num2, publicExponent);
				if (bigInteger2.Subtract(bigInteger).Abs().BitLength < num3)
				{
					continue;
				}
				bigInteger3 = bigInteger.Multiply(bigInteger2);
				if (bigInteger3.BitLength != strength)
				{
					bigInteger = bigInteger.Max(bigInteger2);
					continue;
				}
				if (WNafUtilities.GetNafWeight(bigInteger3) >= num4)
				{
					break;
				}
				bigInteger = ChooseRandomPrime(num, publicExponent);
			}
			if (bigInteger.CompareTo(bigInteger2) < 0)
			{
				BigInteger bigInteger4 = bigInteger;
				bigInteger = bigInteger2;
				bigInteger2 = bigInteger4;
			}
			bigInteger5 = bigInteger.Subtract(One);
			bigInteger6 = bigInteger2.Subtract(One);
			BigInteger val = bigInteger5.Gcd(bigInteger6);
			BigInteger m = bigInteger5.Divide(val).Multiply(bigInteger6);
			bigInteger7 = publicExponent.ModInverse(m);
		}
		while (bigInteger7.BitLength <= num2);
		BigInteger dP = bigInteger7.Remainder(bigInteger5);
		BigInteger dQ = bigInteger7.Remainder(bigInteger6);
		BigInteger qInv = BigIntegers.ModOddInverse(bigInteger, bigInteger2);
		return new AsymmetricCipherKeyPair(new RsaKeyParameters(isPrivate: false, bigInteger3, publicExponent), new RsaPrivateCrtKeyParameters(bigInteger3, publicExponent, bigInteger7, bigInteger, bigInteger2, dP, dQ, qInv));
	}

	protected virtual BigInteger ChooseRandomPrime(int bitlength, BigInteger e)
	{
		bool flag = e.BitLength <= SPECIAL_E_BITS && Arrays.Contains(SPECIAL_E_VALUES, e.IntValue);
		BigInteger bigInteger;
		do
		{
			bigInteger = new BigInteger(bitlength, 1, parameters.Random);
		}
		while (bigInteger.Mod(e).Equals(One) || !bigInteger.IsProbablePrime(parameters.Certainty, randomlySelected: true) || (!flag && !e.Gcd(bigInteger.Subtract(One)).Equals(One)));
		return bigInteger;
	}
}
