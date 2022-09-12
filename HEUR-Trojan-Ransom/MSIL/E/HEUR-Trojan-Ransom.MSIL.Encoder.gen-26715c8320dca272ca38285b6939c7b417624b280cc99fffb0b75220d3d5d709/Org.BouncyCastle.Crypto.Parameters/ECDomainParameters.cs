using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Parameters;

public class ECDomainParameters
{
	internal ECCurve curve;

	internal byte[] seed;

	internal ECPoint g;

	internal BigInteger n;

	internal BigInteger h;

	internal BigInteger hInv;

	public ECCurve Curve => curve;

	public ECPoint G => g;

	public BigInteger N => n;

	public BigInteger H => h;

	public BigInteger HInv
	{
		get
		{
			lock (this)
			{
				if (hInv == null)
				{
					hInv = h.ModInverse(n);
				}
				return hInv;
			}
		}
	}

	public ECDomainParameters(ECCurve curve, ECPoint g, BigInteger n)
		: this(curve, g, n, BigInteger.One, null)
	{
	}

	public ECDomainParameters(ECCurve curve, ECPoint g, BigInteger n, BigInteger h)
		: this(curve, g, n, h, null)
	{
	}

	public ECDomainParameters(ECCurve curve, ECPoint g, BigInteger n, BigInteger h, byte[] seed)
	{
		if (curve == null)
		{
			throw new ArgumentNullException("curve");
		}
		if (g == null)
		{
			throw new ArgumentNullException("g");
		}
		if (n == null)
		{
			throw new ArgumentNullException("n");
		}
		this.curve = curve;
		this.g = Validate(curve, g);
		this.n = n;
		this.h = h;
		this.seed = Arrays.Clone(seed);
	}

	public byte[] GetSeed()
	{
		return Arrays.Clone(seed);
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (!(obj is ECDomainParameters other))
		{
			return false;
		}
		return Equals(other);
	}

	protected virtual bool Equals(ECDomainParameters other)
	{
		if (curve.Equals(other.curve) && g.Equals(other.g) && n.Equals(other.n))
		{
			return h.Equals(other.h);
		}
		return false;
	}

	public override int GetHashCode()
	{
		int hashCode = curve.GetHashCode();
		hashCode *= 37;
		hashCode ^= g.GetHashCode();
		hashCode *= 37;
		hashCode ^= n.GetHashCode();
		hashCode *= 37;
		return hashCode ^ h.GetHashCode();
	}

	internal static ECPoint Validate(ECCurve c, ECPoint q)
	{
		if (q == null)
		{
			throw new ArgumentException("Point has null value", "q");
		}
		q = ECAlgorithms.ImportPoint(c, q).Normalize();
		if (q.IsInfinity)
		{
			throw new ArgumentException("Point at infinity", "q");
		}
		if (!q.IsValid())
		{
			throw new ArgumentException("Point not on curve", "q");
		}
		return q;
	}
}
