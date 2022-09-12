using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters;

public class DHPublicKeyParameters : DHKeyParameters
{
	private readonly BigInteger y;

	public BigInteger Y => y;

	public DHPublicKeyParameters(BigInteger y, DHParameters parameters)
		: base(isPrivate: false, parameters)
	{
		if (y == null)
		{
			throw new ArgumentNullException("y");
		}
		this.y = y;
	}

	public DHPublicKeyParameters(BigInteger y, DHParameters parameters, DerObjectIdentifier algorithmOid)
		: base(isPrivate: false, parameters, algorithmOid)
	{
		if (y == null)
		{
			throw new ArgumentNullException("y");
		}
		this.y = y;
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
