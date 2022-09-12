using System;
using Renci.SshNet.Security.Org.BouncyCastle.Crypto.Parameters;
using Renci.SshNet.Security.Org.BouncyCastle.Math;
using Renci.SshNet.Security.Org.BouncyCastle.Math.EC;

namespace Renci.SshNet.Security.Org.BouncyCastle.Crypto.Agreement;

internal class ECDHCBasicAgreement
{
	private ECPrivateKeyParameters privKey;

	public virtual void Init(AsymmetricKeyParameter parameters)
	{
		privKey = (ECPrivateKeyParameters)parameters;
	}

	public virtual int GetFieldSize()
	{
		return (privKey.Parameters.Curve.FieldSize + 7) / 8;
	}

	public virtual BigInteger CalculateAgreement(ECPublicKeyParameters pubKey)
	{
		ECDomainParameters parameters = privKey.Parameters;
		if (!parameters.Equals(pubKey.Parameters))
		{
			throw new InvalidOperationException("ECDHC public key has wrong domain parameters");
		}
		BigInteger b = parameters.H.Multiply(privKey.D).Mod(parameters.N);
		ECPoint eCPoint = ECAlgorithms.CleanPoint(parameters.Curve, pubKey.Q);
		if (eCPoint.IsInfinity)
		{
			throw new InvalidOperationException("Infinity is not a valid public key for ECDHC");
		}
		ECPoint eCPoint2 = eCPoint.Multiply(b).Normalize();
		if (eCPoint2.IsInfinity)
		{
			throw new InvalidOperationException("Infinity is not a valid agreement value for ECDHC");
		}
		return eCPoint2.AffineXCoord.ToBigInteger();
	}
}
