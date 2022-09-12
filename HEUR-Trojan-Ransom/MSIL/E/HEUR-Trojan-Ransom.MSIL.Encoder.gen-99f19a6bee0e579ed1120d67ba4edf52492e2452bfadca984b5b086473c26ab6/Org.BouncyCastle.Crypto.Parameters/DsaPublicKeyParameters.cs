using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters;

public class DsaPublicKeyParameters : DsaKeyParameters
{
	private readonly BigInteger y;

	public BigInteger Y => y;

	public DsaPublicKeyParameters(BigInteger y, DsaParameters parameters)
		: base(isPrivate: false, parameters)
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
		if (!(obj is DsaPublicKeyParameters other))
		{
			return false;
		}
		return Equals(other);
	}

	protected bool Equals(DsaPublicKeyParameters other)
	{
		if (y.Equals(other.y))
		{
			return Equals((DsaKeyParameters)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return y.GetHashCode() ^ base.GetHashCode();
	}
}
