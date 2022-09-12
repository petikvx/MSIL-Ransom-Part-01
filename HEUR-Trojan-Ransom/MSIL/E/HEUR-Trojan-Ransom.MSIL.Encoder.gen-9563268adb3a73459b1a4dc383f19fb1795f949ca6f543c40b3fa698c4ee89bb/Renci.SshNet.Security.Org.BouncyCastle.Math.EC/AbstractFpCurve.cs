using System;
using Renci.SshNet.Security.Org.BouncyCastle.Math.Field;

namespace Renci.SshNet.Security.Org.BouncyCastle.Math.EC;

internal abstract class AbstractFpCurve : ECCurve
{
	protected AbstractFpCurve(BigInteger q)
		: base(FiniteFields.GetPrimeField(q))
	{
	}

	public override bool IsValidFieldElement(BigInteger x)
	{
		if (x != null && x.SignValue >= 0)
		{
			return x.CompareTo(Field.Characteristic) < 0;
		}
		return false;
	}

	protected override ECPoint DecompressPoint(int yTilde, BigInteger X1)
	{
		ECFieldElement eCFieldElement = FromBigInteger(X1);
		ECFieldElement eCFieldElement2 = eCFieldElement.Square().Add(A).Multiply(eCFieldElement)
			.Add(B)
			.Sqrt();
		if (eCFieldElement2 == null)
		{
			throw new ArgumentException("Invalid point compression");
		}
		if (eCFieldElement2.TestBitZero() != (yTilde == 1))
		{
			eCFieldElement2 = eCFieldElement2.Negate();
		}
		return CreateRawPoint(eCFieldElement, eCFieldElement2, withCompression: true);
	}
}
