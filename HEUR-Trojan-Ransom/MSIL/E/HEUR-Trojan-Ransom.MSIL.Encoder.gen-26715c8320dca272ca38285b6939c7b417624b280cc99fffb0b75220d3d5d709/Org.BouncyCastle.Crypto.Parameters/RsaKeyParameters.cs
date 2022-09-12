using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters;

public class RsaKeyParameters : AsymmetricKeyParameter
{
	private static BigInteger SmallPrimesProduct = new BigInteger("8138E8A0FCF3A4E84A771D40FD305D7F4AA59306D7251DE54D98AF8FE95729A1F73D893FA424CD2EDC8636A6C3285E022B0E3866A565AE8108EED8591CD4FE8D2CE86165A978D719EBF647F362D33FCA29CD179FB42401CBAF3DF0C614056F9C8F3CFD51E474AFB6BC6974F78DB8ABA8E9E517FDED658591AB7502BD41849462F", 16);

	private readonly BigInteger modulus;

	private readonly BigInteger exponent;

	public BigInteger Modulus => modulus;

	public BigInteger Exponent => exponent;

	private static BigInteger Validate(BigInteger modulus)
	{
		if ((modulus.IntValue & 1) == 0)
		{
			throw new ArgumentException("RSA modulus is even", "modulus");
		}
		if (!modulus.Gcd(SmallPrimesProduct).Equals(BigInteger.One))
		{
			throw new ArgumentException("RSA modulus has a small prime factor");
		}
		return modulus;
	}

	public RsaKeyParameters(bool isPrivate, BigInteger modulus, BigInteger exponent)
		: base(isPrivate)
	{
		if (modulus == null)
		{
			throw new ArgumentNullException("modulus");
		}
		if (exponent == null)
		{
			throw new ArgumentNullException("exponent");
		}
		if (modulus.SignValue <= 0)
		{
			throw new ArgumentException("Not a valid RSA modulus", "modulus");
		}
		if (exponent.SignValue <= 0)
		{
			throw new ArgumentException("Not a valid RSA exponent", "exponent");
		}
		if (!isPrivate && (exponent.IntValue & 1) == 0)
		{
			throw new ArgumentException("RSA publicExponent is even", "exponent");
		}
		this.modulus = Validate(modulus);
		this.exponent = exponent;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is RsaKeyParameters rsaKeyParameters))
		{
			return false;
		}
		if (rsaKeyParameters.IsPrivate == base.IsPrivate && rsaKeyParameters.Modulus.Equals(modulus))
		{
			return rsaKeyParameters.Exponent.Equals(exponent);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return modulus.GetHashCode() ^ exponent.GetHashCode() ^ base.IsPrivate.GetHashCode();
	}
}
