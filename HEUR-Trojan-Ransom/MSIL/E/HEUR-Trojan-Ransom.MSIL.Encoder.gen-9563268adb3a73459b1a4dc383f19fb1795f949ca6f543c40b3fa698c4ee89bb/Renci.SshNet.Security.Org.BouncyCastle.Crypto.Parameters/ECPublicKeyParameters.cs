using System;
using Renci.SshNet.Security.Org.BouncyCastle.Math.EC;

namespace Renci.SshNet.Security.Org.BouncyCastle.Crypto.Parameters;

internal class ECPublicKeyParameters : ECKeyParameters
{
	private readonly ECPoint q;

	public ECPoint Q => q;

	public ECPublicKeyParameters(ECPoint q, ECDomainParameters parameters)
		: this("EC", q, parameters)
	{
	}

	public ECPublicKeyParameters(string algorithm, ECPoint q, ECDomainParameters parameters)
		: base(algorithm, isPrivate: false, parameters)
	{
		if (q == null)
		{
			throw new ArgumentNullException("q");
		}
		this.q = ECDomainParameters.Validate(base.Parameters.Curve, q);
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (!(obj is ECPublicKeyParameters other))
		{
			return false;
		}
		return Equals(other);
	}

	protected bool Equals(ECPublicKeyParameters other)
	{
		if (q.Equals(other.q))
		{
			return Equals((ECKeyParameters)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return q.GetHashCode() ^ base.GetHashCode();
	}
}
