using System;
using Renci.SshNet.Security.Org.BouncyCastle.Math;

namespace Renci.SshNet.Security.Org.BouncyCastle.Crypto.Parameters;

internal class ECPrivateKeyParameters : ECKeyParameters
{
	private readonly BigInteger d;

	public BigInteger D => d;

	public ECPrivateKeyParameters(BigInteger d, ECDomainParameters parameters)
		: this("EC", d, parameters)
	{
	}

	public ECPrivateKeyParameters(string algorithm, BigInteger d, ECDomainParameters parameters)
		: base(algorithm, isPrivate: true, parameters)
	{
		if (d == null)
		{
			throw new ArgumentNullException("d");
		}
		this.d = d;
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (!(obj is ECPrivateKeyParameters other))
		{
			return false;
		}
		return Equals(other);
	}

	protected bool Equals(ECPrivateKeyParameters other)
	{
		if (d.Equals(other.d))
		{
			return Equals((ECKeyParameters)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return d.GetHashCode() ^ base.GetHashCode();
	}
}
