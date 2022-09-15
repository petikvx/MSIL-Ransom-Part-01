using System;

namespace Org.BouncyCastle.Math.EC;

public class F2mPoint : AbstractF2mPoint
{
	public override ECFieldElement YCoord
	{
		get
		{
			int curveCoordinateSystem = CurveCoordinateSystem;
			if ((uint)(curveCoordinateSystem - 5) <= 1u)
			{
				ECFieldElement rawXCoord = base.RawXCoord;
				ECFieldElement rawYCoord = base.RawYCoord;
				if (!base.IsInfinity && !rawXCoord.IsZero)
				{
					ECFieldElement eCFieldElement = rawYCoord.Add(rawXCoord).Multiply(rawXCoord);
					if (6 == curveCoordinateSystem)
					{
						ECFieldElement eCFieldElement2 = base.RawZCoords[0];
						if (!eCFieldElement2.IsOne)
						{
							eCFieldElement = eCFieldElement.Divide(eCFieldElement2);
						}
					}
					return eCFieldElement;
				}
				return rawYCoord;
			}
			return base.RawYCoord;
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
			int curveCoordinateSystem = CurveCoordinateSystem;
			if ((uint)(curveCoordinateSystem - 5) <= 1u)
			{
				return rawYCoord.TestBitZero() != rawXCoord.TestBitZero();
			}
			return rawYCoord.Divide(rawXCoord).TestBitZero();
		}
	}

	[Obsolete("Use ECCurve.CreatePoint to construct points")]
	public F2mPoint(ECCurve curve, ECFieldElement x, ECFieldElement y)
		: this(curve, x, y, withCompression: false)
	{
	}

	[Obsolete("Per-point compression property will be removed, see GetEncoded(bool)")]
	public F2mPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		: base(curve, x, y, withCompression)
	{
		if (x == null != (y == null))
		{
			throw new ArgumentException("Exactly one of the field elements is null");
		}
		if (x != null)
		{
			F2mFieldElement.CheckFieldElements(x, y);
			if (curve != null)
			{
				F2mFieldElement.CheckFieldElements(x, curve.A);
			}
		}
	}

	internal F2mPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		: base(curve, x, y, zs, withCompression)
	{
	}

	protected override ECPoint Detach()
	{
		return new F2mPoint(null, AffineXCoord, AffineYCoord, withCompression: false);
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
		int coordinateSystem = curve.CoordinateSystem;
		ECFieldElement rawXCoord = base.RawXCoord;
		ECFieldElement rawXCoord2 = b.RawXCoord;
		switch (coordinateSystem)
		{
		default:
			throw new InvalidOperationException("unsupported coordinate system");
		case 6:
		{
			if (rawXCoord.IsZero)
			{
				if (rawXCoord2.IsZero)
				{
					return curve.Infinity;
				}
				return b.Add(this);
			}
			ECFieldElement rawYCoord5 = base.RawYCoord;
			ECFieldElement eCFieldElement18 = base.RawZCoords[0];
			ECFieldElement rawYCoord6 = b.RawYCoord;
			ECFieldElement eCFieldElement19 = b.RawZCoords[0];
			bool isOne3 = eCFieldElement18.IsOne;
			ECFieldElement eCFieldElement20 = rawXCoord2;
			ECFieldElement eCFieldElement21 = rawYCoord6;
			if (!isOne3)
			{
				eCFieldElement20 = eCFieldElement20.Multiply(eCFieldElement18);
				eCFieldElement21 = eCFieldElement21.Multiply(eCFieldElement18);
			}
			bool isOne4 = eCFieldElement19.IsOne;
			ECFieldElement eCFieldElement22 = rawXCoord;
			ECFieldElement eCFieldElement23 = rawYCoord5;
			if (!isOne4)
			{
				eCFieldElement22 = eCFieldElement22.Multiply(eCFieldElement19);
				eCFieldElement23 = eCFieldElement23.Multiply(eCFieldElement19);
			}
			ECFieldElement eCFieldElement24 = eCFieldElement23.Add(eCFieldElement21);
			ECFieldElement eCFieldElement25 = eCFieldElement22.Add(eCFieldElement20);
			if (eCFieldElement25.IsZero)
			{
				if (eCFieldElement24.IsZero)
				{
					return Twice();
				}
				return curve.Infinity;
			}
			ECFieldElement eCFieldElement27;
			ECFieldElement y3;
			ECFieldElement eCFieldElement28;
			if (rawXCoord2.IsZero)
			{
				ECPoint eCPoint = Normalize();
				rawXCoord = eCPoint.RawXCoord;
				ECFieldElement yCoord = eCPoint.YCoord;
				ECFieldElement b4 = rawYCoord6;
				ECFieldElement eCFieldElement26 = yCoord.Add(b4).Divide(rawXCoord);
				eCFieldElement27 = eCFieldElement26.Square().Add(eCFieldElement26).Add(rawXCoord)
					.Add(curve.A);
				if (eCFieldElement27.IsZero)
				{
					return new F2mPoint(curve, eCFieldElement27, curve.B.Sqrt(), base.IsCompressed);
				}
				y3 = eCFieldElement26.Multiply(rawXCoord.Add(eCFieldElement27)).Add(eCFieldElement27).Add(yCoord)
					.Divide(eCFieldElement27)
					.Add(eCFieldElement27);
				eCFieldElement28 = curve.FromBigInteger(BigInteger.One);
			}
			else
			{
				eCFieldElement25 = eCFieldElement25.Square();
				ECFieldElement eCFieldElement29 = eCFieldElement24.Multiply(eCFieldElement22);
				ECFieldElement eCFieldElement30 = eCFieldElement24.Multiply(eCFieldElement20);
				eCFieldElement27 = eCFieldElement29.Multiply(eCFieldElement30);
				if (eCFieldElement27.IsZero)
				{
					return new F2mPoint(curve, eCFieldElement27, curve.B.Sqrt(), base.IsCompressed);
				}
				ECFieldElement eCFieldElement31 = eCFieldElement24.Multiply(eCFieldElement25);
				if (!isOne4)
				{
					eCFieldElement31 = eCFieldElement31.Multiply(eCFieldElement19);
				}
				y3 = eCFieldElement30.Add(eCFieldElement25).SquarePlusProduct(eCFieldElement31, rawYCoord5.Add(eCFieldElement18));
				eCFieldElement28 = eCFieldElement31;
				if (!isOne3)
				{
					eCFieldElement28 = eCFieldElement28.Multiply(eCFieldElement18);
				}
			}
			return new F2mPoint(curve, eCFieldElement27, y3, new ECFieldElement[1] { eCFieldElement28 }, base.IsCompressed);
		}
		case 1:
		{
			ECFieldElement rawYCoord3 = base.RawYCoord;
			ECFieldElement eCFieldElement5 = base.RawZCoords[0];
			ECFieldElement rawYCoord4 = b.RawYCoord;
			ECFieldElement eCFieldElement6 = b.RawZCoords[0];
			bool isOne = eCFieldElement5.IsOne;
			ECFieldElement eCFieldElement7 = rawYCoord4;
			ECFieldElement eCFieldElement8 = rawXCoord2;
			if (!isOne)
			{
				eCFieldElement7 = eCFieldElement7.Multiply(eCFieldElement5);
				eCFieldElement8 = eCFieldElement8.Multiply(eCFieldElement5);
			}
			bool isOne2 = eCFieldElement6.IsOne;
			ECFieldElement eCFieldElement9 = rawYCoord3;
			ECFieldElement eCFieldElement10 = rawXCoord;
			if (!isOne2)
			{
				eCFieldElement9 = eCFieldElement9.Multiply(eCFieldElement6);
				eCFieldElement10 = eCFieldElement10.Multiply(eCFieldElement6);
			}
			ECFieldElement eCFieldElement11 = eCFieldElement7.Add(eCFieldElement9);
			ECFieldElement eCFieldElement12 = eCFieldElement8.Add(eCFieldElement10);
			if (eCFieldElement12.IsZero)
			{
				if (eCFieldElement11.IsZero)
				{
					return Twice();
				}
				return curve.Infinity;
			}
			ECFieldElement eCFieldElement13 = eCFieldElement12.Square();
			ECFieldElement eCFieldElement14 = eCFieldElement13.Multiply(eCFieldElement12);
			ECFieldElement b2 = (isOne ? eCFieldElement6 : (isOne2 ? eCFieldElement5 : eCFieldElement5.Multiply(eCFieldElement6)));
			ECFieldElement eCFieldElement15 = eCFieldElement11.Add(eCFieldElement12);
			ECFieldElement eCFieldElement16 = eCFieldElement15.MultiplyPlusProduct(eCFieldElement11, eCFieldElement13, curve.A).Multiply(b2).Add(eCFieldElement14);
			ECFieldElement x = eCFieldElement12.Multiply(eCFieldElement16);
			ECFieldElement b3 = (isOne2 ? eCFieldElement13 : eCFieldElement13.Multiply(eCFieldElement6));
			ECFieldElement y2 = eCFieldElement11.MultiplyPlusProduct(rawXCoord, eCFieldElement12, rawYCoord3).MultiplyPlusProduct(b3, eCFieldElement15, eCFieldElement16);
			ECFieldElement eCFieldElement17 = eCFieldElement14.Multiply(b2);
			return new F2mPoint(curve, x, y2, new ECFieldElement[1] { eCFieldElement17 }, base.IsCompressed);
		}
		case 0:
		{
			ECFieldElement rawYCoord = base.RawYCoord;
			ECFieldElement rawYCoord2 = b.RawYCoord;
			ECFieldElement eCFieldElement = rawXCoord.Add(rawXCoord2);
			ECFieldElement eCFieldElement2 = rawYCoord.Add(rawYCoord2);
			if (eCFieldElement.IsZero)
			{
				if (eCFieldElement2.IsZero)
				{
					return Twice();
				}
				return curve.Infinity;
			}
			ECFieldElement eCFieldElement3 = eCFieldElement2.Divide(eCFieldElement);
			ECFieldElement eCFieldElement4 = eCFieldElement3.Square().Add(eCFieldElement3).Add(eCFieldElement)
				.Add(curve.A);
			ECFieldElement y = eCFieldElement3.Multiply(rawXCoord.Add(eCFieldElement4)).Add(eCFieldElement4).Add(rawYCoord);
			return new F2mPoint(curve, eCFieldElement4, y, base.IsCompressed);
		}
		}
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
		switch (curve.CoordinateSystem)
		{
		default:
			throw new InvalidOperationException("unsupported coordinate system");
		case 6:
		{
			ECFieldElement rawYCoord2 = base.RawYCoord;
			ECFieldElement eCFieldElement11 = base.RawZCoords[0];
			bool isOne2;
			ECFieldElement eCFieldElement12 = ((isOne2 = eCFieldElement11.IsOne) ? rawYCoord2 : rawYCoord2.Multiply(eCFieldElement11));
			ECFieldElement eCFieldElement13 = (isOne2 ? eCFieldElement11 : eCFieldElement11.Square());
			ECFieldElement a = curve.A;
			ECFieldElement eCFieldElement14 = (isOne2 ? a : a.Multiply(eCFieldElement13));
			ECFieldElement eCFieldElement15 = rawYCoord2.Square().Add(eCFieldElement12).Add(eCFieldElement14);
			if (eCFieldElement15.IsZero)
			{
				return new F2mPoint(curve, eCFieldElement15, curve.B.Sqrt(), base.IsCompressed);
			}
			ECFieldElement eCFieldElement16 = eCFieldElement15.Square();
			ECFieldElement eCFieldElement17 = (isOne2 ? eCFieldElement15 : eCFieldElement15.Multiply(eCFieldElement13));
			ECFieldElement b2 = curve.B;
			ECFieldElement eCFieldElement19;
			if (b2.BitLength < curve.FieldSize >> 1)
			{
				ECFieldElement eCFieldElement18 = rawYCoord2.Add(rawXCoord).Square();
				ECFieldElement b3 = ((!b2.IsOne) ? eCFieldElement14.SquarePlusProduct(b2, eCFieldElement13.Square()) : eCFieldElement14.Add(eCFieldElement13).Square());
				eCFieldElement19 = eCFieldElement18.Add(eCFieldElement15).Add(eCFieldElement13).Multiply(eCFieldElement18)
					.Add(b3)
					.Add(eCFieldElement16);
				if (a.IsZero)
				{
					eCFieldElement19 = eCFieldElement19.Add(eCFieldElement17);
				}
				else if (!a.IsOne)
				{
					eCFieldElement19 = eCFieldElement19.Add(a.AddOne().Multiply(eCFieldElement17));
				}
			}
			else
			{
				eCFieldElement19 = (isOne2 ? rawXCoord : rawXCoord.Multiply(eCFieldElement11)).SquarePlusProduct(eCFieldElement15, eCFieldElement12).Add(eCFieldElement16).Add(eCFieldElement17);
			}
			return new F2mPoint(curve, eCFieldElement16, eCFieldElement19, new ECFieldElement[1] { eCFieldElement17 }, base.IsCompressed);
		}
		case 1:
		{
			ECFieldElement rawYCoord = base.RawYCoord;
			ECFieldElement eCFieldElement2 = base.RawZCoords[0];
			bool isOne = eCFieldElement2.IsOne;
			ECFieldElement eCFieldElement3 = (isOne ? rawXCoord : rawXCoord.Multiply(eCFieldElement2));
			ECFieldElement b = (isOne ? rawYCoord : rawYCoord.Multiply(eCFieldElement2));
			ECFieldElement eCFieldElement4 = rawXCoord.Square();
			ECFieldElement eCFieldElement5 = eCFieldElement4.Add(b);
			ECFieldElement eCFieldElement6 = eCFieldElement3;
			ECFieldElement eCFieldElement7 = eCFieldElement6.Square();
			ECFieldElement eCFieldElement8 = eCFieldElement5.Add(eCFieldElement6);
			ECFieldElement eCFieldElement9 = eCFieldElement8.MultiplyPlusProduct(eCFieldElement5, eCFieldElement7, curve.A);
			ECFieldElement x2 = eCFieldElement6.Multiply(eCFieldElement9);
			ECFieldElement y2 = eCFieldElement4.Square().MultiplyPlusProduct(eCFieldElement6, eCFieldElement9, eCFieldElement8);
			ECFieldElement eCFieldElement10 = eCFieldElement6.Multiply(eCFieldElement7);
			return new F2mPoint(curve, x2, y2, new ECFieldElement[1] { eCFieldElement10 }, base.IsCompressed);
		}
		case 0:
		{
			ECFieldElement eCFieldElement = base.RawYCoord.Divide(rawXCoord).Add(rawXCoord);
			ECFieldElement x = eCFieldElement.Square().Add(eCFieldElement).Add(curve.A);
			ECFieldElement y = rawXCoord.SquarePlusProduct(x, eCFieldElement.AddOne());
			return new F2mPoint(curve, x, y, base.IsCompressed);
		}
		}
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
		if (curve.CoordinateSystem == 6)
		{
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
				ECFieldElement b4 = curve.A.Multiply(eCFieldElement3).Add(b2).Add(b3);
				ECFieldElement eCFieldElement4 = rawYCoord2.AddOne();
				ECFieldElement eCFieldElement5 = curve.A.Add(eCFieldElement4).Multiply(eCFieldElement3).Add(b2)
					.MultiplyPlusProduct(b4, x, eCFieldElement3);
				ECFieldElement eCFieldElement6 = rawXCoord2.Multiply(eCFieldElement3);
				ECFieldElement eCFieldElement7 = eCFieldElement6.Add(b4).Square();
				if (eCFieldElement7.IsZero)
				{
					if (eCFieldElement5.IsZero)
					{
						return b.Twice();
					}
					return curve.Infinity;
				}
				if (eCFieldElement5.IsZero)
				{
					return new F2mPoint(curve, eCFieldElement5, curve.B.Sqrt(), base.IsCompressed);
				}
				ECFieldElement x2 = eCFieldElement5.Square().Multiply(eCFieldElement6);
				ECFieldElement eCFieldElement8 = eCFieldElement5.Multiply(eCFieldElement7).Multiply(eCFieldElement3);
				ECFieldElement y = eCFieldElement5.Add(eCFieldElement7).Square().MultiplyPlusProduct(b4, eCFieldElement4, eCFieldElement8);
				return new F2mPoint(curve, x2, y, new ECFieldElement[1] { eCFieldElement8 }, base.IsCompressed);
			}
			return Twice().Add(b);
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
		ECCurve curve = Curve;
		switch (curve.CoordinateSystem)
		{
		case 0:
		{
			ECFieldElement rawYCoord4 = base.RawYCoord;
			return new F2mPoint(curve, rawXCoord, rawYCoord4.Add(rawXCoord), base.IsCompressed);
		}
		case 1:
		{
			ECFieldElement rawYCoord3 = base.RawYCoord;
			ECFieldElement eCFieldElement2 = base.RawZCoords[0];
			return new F2mPoint(curve, rawXCoord, rawYCoord3.Add(rawXCoord), new ECFieldElement[1] { eCFieldElement2 }, base.IsCompressed);
		}
		default:
			throw new InvalidOperationException("unsupported coordinate system");
		case 5:
		{
			ECFieldElement rawYCoord2 = base.RawYCoord;
			return new F2mPoint(curve, rawXCoord, rawYCoord2.AddOne(), base.IsCompressed);
		}
		case 6:
		{
			ECFieldElement rawYCoord = base.RawYCoord;
			ECFieldElement eCFieldElement = base.RawZCoords[0];
			return new F2mPoint(curve, rawXCoord, rawYCoord.Add(eCFieldElement), new ECFieldElement[1] { eCFieldElement }, base.IsCompressed);
		}
		}
	}
}
