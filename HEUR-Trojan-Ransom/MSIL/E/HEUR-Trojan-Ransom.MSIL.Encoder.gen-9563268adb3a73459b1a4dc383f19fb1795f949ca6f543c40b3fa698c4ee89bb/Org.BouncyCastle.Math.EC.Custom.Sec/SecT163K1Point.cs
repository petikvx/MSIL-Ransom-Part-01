using System;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecT163K1Point : AbstractF2mPoint
{
	public override ECFieldElement YCoord
	{
		get
		{
			ECFieldElement rawXCoord = base.RawXCoord;
			ECFieldElement rawYCoord = base.RawYCoord;
			if (!base.IsInfinity && !rawXCoord.IsZero)
			{
				ECFieldElement eCFieldElement = rawYCoord.Add(rawXCoord).Multiply(rawXCoord);
				ECFieldElement eCFieldElement2 = base.RawZCoords[0];
				if (!eCFieldElement2.IsOne)
				{
					eCFieldElement = eCFieldElement.Divide(eCFieldElement2);
				}
				return eCFieldElement;
			}
			return rawYCoord;
		}
	}

	protected internal override bool CompressionYTilde
	{
		get
		{
			ECFieldElement rawXCoord = base.RawXCoord;
			if (rawXCoord.IsZero)
			{
				return false;
			}
			ECFieldElement rawYCoord = base.RawYCoord;
			return rawYCoord.TestBitZero() != rawXCoord.TestBitZero();
		}
	}

	public SecT163K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		: this(curve, x, y, withCompression: false)
	{
	}

	public SecT163K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		: base(curve, x, y, withCompression)
	{
		if (x == null != (y == null))
		{
			throw new ArgumentException("Exactly one of the field elements is null");
		}
	}

	internal SecT163K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		: base(curve, x, y, zs, withCompression)
	{
	}

	protected override ECPoint Detach()
	{
		return new SecT163K1Point(null, AffineXCoord, AffineYCoord);
	}

	public override ECPoint Add(ECPoint b)
	{
		if (base.IsInfinity)
		{
			return b;
		}
		if (b.IsInfinity)
		{
			return this;
		}
		ECCurve curve = Curve;
		ECFieldElement rawXCoord = base.RawXCoord;
		ECFieldElement rawXCoord2 = b.RawXCoord;
		if (rawXCoord.IsZero)
		{
			if (rawXCoord2.IsZero)
			{
				return curve.Infinity;
			}
			return b.Add(this);
		}
		ECFieldElement rawYCoord = base.RawYCoord;
		ECFieldElement eCFieldElement = base.RawZCoords[0];
		ECFieldElement rawYCoord2 = b.RawYCoord;
		ECFieldElement eCFieldElement2 = b.RawZCoords[0];
		bool isOne = eCFieldElement.IsOne;
		ECFieldElement eCFieldElement3 = rawXCoord2;
		ECFieldElement eCFieldElement4 = rawYCoord2;
		if (!isOne)
		{
			eCFieldElement3 = eCFieldElement3.Multiply(eCFieldElement);
			eCFieldElement4 = eCFieldElement4.Multiply(eCFieldElement);
		}
		bool isOne2 = eCFieldElement2.IsOne;
		ECFieldElement eCFieldElement5 = rawXCoord;
		ECFieldElement eCFieldElement6 = rawYCoord;
		if (!isOne2)
		{
			eCFieldElement5 = eCFieldElement5.Multiply(eCFieldElement2);
			eCFieldElement6 = eCFieldElement6.Multiply(eCFieldElement2);
		}
		ECFieldElement eCFieldElement7 = eCFieldElement6.Add(eCFieldElement4);
		ECFieldElement eCFieldElement8 = eCFieldElement5.Add(eCFieldElement3);
		if (eCFieldElement8.IsZero)
		{
			if (eCFieldElement7.IsZero)
			{
				return Twice();
			}
			return curve.Infinity;
		}
		ECFieldElement eCFieldElement10;
		ECFieldElement y;
		ECFieldElement eCFieldElement12;
		if (rawXCoord2.IsZero)
		{
			ECPoint eCPoint = Normalize();
			rawXCoord = eCPoint.XCoord;
			ECFieldElement yCoord = eCPoint.YCoord;
			ECFieldElement b2 = rawYCoord2;
			ECFieldElement eCFieldElement9 = yCoord.Add(b2).Divide(rawXCoord);
			eCFieldElement10 = eCFieldElement9.Square().Add(eCFieldElement9).Add(rawXCoord)
				.AddOne();
			if (eCFieldElement10.IsZero)
			{
				return new SecT163K1Point(curve, eCFieldElement10, curve.B, base.IsCompressed);
			}
			ECFieldElement eCFieldElement11 = eCFieldElement9.Multiply(rawXCoord.Add(eCFieldElement10)).Add(eCFieldElement10).Add(yCoord);
			y = eCFieldElement11.Divide(eCFieldElement10).Add(eCFieldElement10);
			eCFieldElement12 = curve.FromBigInteger(BigInteger.One);
		}
		else
		{
			eCFieldElement8 = eCFieldElement8.Square();
			ECFieldElement eCFieldElement13 = eCFieldElement7.Multiply(eCFieldElement5);
			ECFieldElement eCFieldElement14 = eCFieldElement7.Multiply(eCFieldElement3);
			eCFieldElement10 = eCFieldElement13.Multiply(eCFieldElement14);
			if (eCFieldElement10.IsZero)
			{
				return new SecT163K1Point(curve, eCFieldElement10, curve.B, base.IsCompressed);
			}
			ECFieldElement eCFieldElement15 = eCFieldElement7.Multiply(eCFieldElement8);
			if (!isOne2)
			{
				eCFieldElement15 = eCFieldElement15.Multiply(eCFieldElement2);
			}
			y = eCFieldElement14.Add(eCFieldElement8).SquarePlusProduct(eCFieldElement15, rawYCoord.Add(eCFieldElement));
			eCFieldElement12 = eCFieldElement15;
			if (!isOne)
			{
				eCFieldElement12 = eCFieldElement12.Multiply(eCFieldElement);
			}
		}
		return new SecT163K1Point(curve, eCFieldElement10, y, new ECFieldElement[1] { eCFieldElement12 }, base.IsCompressed);
	}

	public override ECPoint Twice()
	{
		if (base.IsInfinity)
		{
			return this;
		}
		ECCurve curve = Curve;
		ECFieldElement rawXCoord = base.RawXCoord;
		if (rawXCoord.IsZero)
		{
			return curve.Infinity;
		}
		ECFieldElement rawYCoord = base.RawYCoord;
		ECFieldElement eCFieldElement = base.RawZCoords[0];
		bool isOne;
		ECFieldElement b = ((isOne = eCFieldElement.IsOne) ? rawYCoord : rawYCoord.Multiply(eCFieldElement));
		ECFieldElement b2 = (isOne ? eCFieldElement : eCFieldElement.Square());
		ECFieldElement eCFieldElement2 = rawYCoord.Square().Add(b).Add(b2);
		if (eCFieldElement2.IsZero)
		{
			return new SecT163K1Point(curve, eCFieldElement2, curve.B, base.IsCompressed);
		}
		ECFieldElement eCFieldElement3 = eCFieldElement2.Square();
		ECFieldElement eCFieldElement4 = (isOne ? eCFieldElement2 : eCFieldElement2.Multiply(b2));
		ECFieldElement eCFieldElement5 = rawYCoord.Add(rawXCoord).Square();
		ECFieldElement y = eCFieldElement5.Add(eCFieldElement2).Add(b2).Multiply(eCFieldElement5)
			.Add(eCFieldElement3);
		return new SecT163K1Point(curve, eCFieldElement3, y, new ECFieldElement[1] { eCFieldElement4 }, base.IsCompressed);
	}

	public override ECPoint TwicePlus(ECPoint b)
	{
		if (base.IsInfinity)
		{
			return b;
		}
		if (b.IsInfinity)
		{
			return Twice();
		}
		ECCurve curve = Curve;
		ECFieldElement rawXCoord = base.RawXCoord;
		if (rawXCoord.IsZero)
		{
			return b;
		}
		ECFieldElement rawXCoord2 = b.RawXCoord;
		ECFieldElement eCFieldElement = b.RawZCoords[0];
		if (!rawXCoord2.IsZero && eCFieldElement.IsOne)
		{
			ECFieldElement rawYCoord = base.RawYCoord;
			ECFieldElement eCFieldElement2 = base.RawZCoords[0];
			ECFieldElement rawYCoord2 = b.RawYCoord;
			ECFieldElement x = rawXCoord.Square();
			ECFieldElement b2 = rawYCoord.Square();
			ECFieldElement eCFieldElement3 = eCFieldElement2.Square();
			ECFieldElement b3 = rawYCoord.Multiply(eCFieldElement2);
			ECFieldElement b4 = eCFieldElement3.Add(b2).Add(b3);
			ECFieldElement eCFieldElement4 = rawYCoord2.Multiply(eCFieldElement3).Add(b2).MultiplyPlusProduct(b4, x, eCFieldElement3);
			ECFieldElement eCFieldElement5 = rawXCoord2.Multiply(eCFieldElement3);
			ECFieldElement eCFieldElement6 = eCFieldElement5.Add(b4).Square();
			if (eCFieldElement6.IsZero)
			{
				if (eCFieldElement4.IsZero)
				{
					return b.Twice();
				}
				return curve.Infinity;
			}
			if (eCFieldElement4.IsZero)
			{
				return new SecT163K1Point(curve, eCFieldElement4, curve.B, base.IsCompressed);
			}
			ECFieldElement x2 = eCFieldElement4.Square().Multiply(eCFieldElement5);
			ECFieldElement eCFieldElement7 = eCFieldElement4.Multiply(eCFieldElement6).Multiply(eCFieldElement3);
			ECFieldElement y = eCFieldElement4.Add(eCFieldElement6).Square().MultiplyPlusProduct(b4, rawYCoord2.AddOne(), eCFieldElement7);
			return new SecT163K1Point(curve, x2, y, new ECFieldElement[1] { eCFieldElement7 }, base.IsCompressed);
		}
		return Twice().Add(b);
	}

	public override ECPoint Negate()
	{
		if (base.IsInfinity)
		{
			return this;
		}
		ECFieldElement rawXCoord = base.RawXCoord;
		if (rawXCoord.IsZero)
		{
			return this;
		}
		ECFieldElement rawYCoord = base.RawYCoord;
		ECFieldElement eCFieldElement = base.RawZCoords[0];
		return new SecT163K1Point(Curve, rawXCoord, rawYCoord.Add(eCFieldElement), new ECFieldElement[1] { eCFieldElement }, base.IsCompressed);
	}
}
