using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters;

public class DHPublicKeyParameters : DHKeyParameters
{
	private readonly BigInteger y;

	public virtual BigInteger Y => y;

	private static BigInteger Validate(BigInteger y, DHParameters dhParams)
	{
		if (y == null)
		{
			throw new ArgumentNullException("y");
		}
		if (y.CompareTo(BigInteger.Two) >= 0 && y.CompareTo(dhParams.P.Subtract(BigInteger.Two)) <= 0)
		{
			if (dhParams.Q != null && !y.ModPow(dhParams.Q, dhParams.P).Equals(BigInteger.One))
			{
				throw new ArgumentException("y value does not appear to be in correct group", "y");
			}
			return y;
		}
		throw new ArgumentException("invalid DH public key", "y");
	}

	public DHPublicKeyParameters(BigInteger y, DHParameters parameters)
		: base(isPrivate: false, parameters)
	{
		this.y = Validate(y, parameters);
	}

	public DHPublicKeyParameters(BigInteger y, DHParameters parameters, DerObjectIdentifier algorithmOid)
		: base(isPrivate: false, parameters, algorithmOid)
	{
		this.y = Validate(y, parameters);
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (!(obj is DHPublicKeyParameters other))
		{
			return false;
		}
		return Equals(other);
	}

	protected bool Equals(DHPublicKeyParameters other)
	{
		if (y.Equals(other.y))
		{
			return Equals((DHKeyParameters)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return y.GetHashCode() ^ base.GetHashCode();
	}
}
