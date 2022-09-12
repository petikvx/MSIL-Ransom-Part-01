using System;
using Renci.SshNet.Security.Org.BouncyCastle.Math;
using Renci.SshNet.Security.Org.BouncyCastle.Math.EC;
using Renci.SshNet.Security.Org.BouncyCastle.Utilities;

namespace Renci.SshNet.Security.Org.BouncyCastle.Crypto.Parameters;

internal class ECDomainParameters
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
