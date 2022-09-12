using System;
using Renci.SshNet.Security.Org.BouncyCastle.Math.EC;
using Renci.SshNet.Security.Org.BouncyCastle.Utilities;

namespace Renci.SshNet.Security.Org.BouncyCastle.Asn1.X9;

internal class X9Curve
{
	private readonly ECCurve curve;

	private readonly byte[] seed;

	public ECCurve Curve => curve;

	public X9Curve(ECCurve curve)
		: this(curve, null)
	{
	}

	public X9Curve(ECCurve curve, byte[] seed)
	{
		if (curve == null)
		{
			throw new ArgumentNullException("curve");
		}
		this.curve = curve;
		this.seed = Arrays.Clone(seed);
	}

	public byte[] GetSeed()
	{
		return Arrays.Clone(seed);
	}
}
