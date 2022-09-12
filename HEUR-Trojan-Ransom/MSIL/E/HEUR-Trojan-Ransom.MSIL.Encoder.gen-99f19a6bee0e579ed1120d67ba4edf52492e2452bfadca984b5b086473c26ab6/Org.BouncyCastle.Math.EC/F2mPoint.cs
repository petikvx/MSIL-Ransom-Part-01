using System;

namespace Org.BouncyCastle.Math.EC;

public class F2mPoint : AbstractF2mPoint
{
	public override ECFieldElement YCoord
	{
		get
		{
			int curveCoordinateSystem = CurveCoordinateSystem;
			switch (curveCoordinateSystem)
			{
			default:
				return base.RawYCoord;
			case 5:
			case 6:
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
			}
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
			switch (CurveCoordinateSystem)
			{
			default:
				return rawYCoord.Divide(rawXCoord).TestBitZero();
			case 5:
			case 6:
				return rawYCoord.TestBitZero() != rawXCoord.TestBitZero();
			}
		}
	}

	public F2mPoint(ECCurve curve, ECFieldElement x, ECFieldElement y)
		: this(curve, x, y, withCompression: false)
	{
	}

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

	[Obsolete("Use ECCurve.Infinity property")]
	public F2mPoint(ECCurve curve)
		: this(curve, null, null)
	{
	}

	protected override ECPoint Detach()
	{
		return new F2mPoint(null, AffineXCoord, AffineYCoord);
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
			ECFieldElement rawYCoord3 = base.RawYCoord;
			ECFieldElement eCFieldElement14 = base.RawZCoords[0];
			ECFieldElement rawYCoord4 = b.RawYCoord;
			ECFieldElement eCFieldElement15 = b.RawZCoords[0];
			bool isOne3 = eCFieldElement14.IsOne;
			ECFieldElement eCFieldElement16 = rawXCoord2;
			ECFieldElement eCFieldElement17 = rawYCoord4;
			if (!isOne3)
			{
				eCFieldElement16 = eCFieldElement16.Multiply(eCFieldElement14);
				eCFieldElement17 = eCFieldElement17.Multiply(eCFieldElement14);
			}
			bool isOne4 = eCFieldElement15.IsOne;
			ECFieldElement eCFieldElement18 = rawXCoord;
			ECFieldElement eCFieldElement19 = rawYCoord3;
			if (!isOne4)
			{
				eCFieldElement18 = eCFieldElement18.Multiply(eCFieldElement15);
				eCFieldElement19 = eCFieldElement19.Multiply(eCFieldElement15);
			}
			ECFieldElement eCFieldElement20 = eCFieldElement19.Add(eCFieldElement17);
			ECFieldElement eCFieldElement21 = eCFieldElement18.Add(eCFieldElement16);
			if (eCFieldElement21.IsZero)
			{
				if (eCFieldElement20.IsZero)
				{
					return Twice();
				}
				return curve.Infinity;
			}
			ECFieldElement eCFieldElement23;
			ECFieldElement y2;
			ECFieldElement eCFieldElement25;
			if (rawXCoord2.IsZero)
			{
				ECPoint eCPoint = Normalize();
				rawXCoord = eCPoint.RawXCoord;
				ECFieldElement yCoord = eCPoint.YCoord;
				ECFieldElement b4 = rawYCoord4;
				ECFieldElement eCFieldElement22 = yCoord.Add(b4).Divide(rawXCoord);
				eCFieldElement23 = eCFieldElement22.Square().Add(eCFieldElement22).Add(rawXCoord)
					.Add(curve.A);
				if (eCFieldElement23.IsZero)
				{
					return new F2mPoint(curve, eCFieldElement23, curve.B.Sqrt(), base.IsCompressed);
				}
				ECFieldElement eCFieldElement24 = eCFieldElement22.Multiply(rawXCoord.Add(eCFieldElement23)).Add(eCFieldElement23).Add(yCoord);
				y2 = eCFieldElement24.Divide(eCFieldElement23).Add(eCFieldElement23);
				eCFieldElement25 = curve.FromBigInteger(BigInteger.One);
			}
			else
			{
				eCFieldElement21 = eCFieldElement21.Square();
				ECFieldElement eCFieldElement26 = eCFieldElement20.Multiply(eCFieldElement18);
				ECFieldElement eCFieldElement27 = eCFieldElement20.Multiply(eCFieldElement16);
				eCFieldElement23 = eCFieldElement26.Multiply(eCFieldElement27);
				if (eCFieldElement23.IsZero)
				{
					return new F2mPoint(curve, eCFieldElement23, curve.B.Sqrt(), base.IsCompressed);
				}
				ECFieldElement eCFieldElement28 = eCFieldElement20.Multiply(eCFieldElement21);
				if (!isOne4)
				{
					eCFieldElement28 = eCFieldElement28.Multiply(eCFieldElement15);
				}
				y2 = eCFieldElement27.Add(eCFieldElement21).SquarePlusProduct(eCFieldElement28, rawYCoord3.Add(eCFieldElement14));
				eCFieldElement25 = eCFieldElement28;
				if (!isOne3)
				{
					eCFieldElement25 = eCFieldElement25.Multiply(eCFieldElement14);
				}
			}
			return new F2mPoint(curve, eCFieldElement23, y2, new ECFieldElement[1] { eCFieldElement25 }, base.IsCompressed);
		}
		case 0:
		{
			ECFieldElement rawYCoord5 = base.RawYCoord;
			ECFieldElement rawYCoord6 = b.RawYCoord;
			ECFieldElement eCFieldElement29 = rawXCoord.Add(rawXCoord2);
			ECFieldElement eCFieldElement30 = rawYCoord5.Add(rawYCoord6);
			if (eCFieldElement29.IsZero)
			{
				if (eCFieldElement30.IsZero)
				{
					return Twice();
				}
				return curve.Infinity;
			}
			ECFieldElement eCFieldElement31 = eCFieldElement30.Divide(eCFieldElement29);
			ECFieldElement eCFieldElement32 = eCFieldElement31.Square().Add(eCFieldElement31).Add(eCFieldElement29)
				.Add(curve.A);
			ECFieldElement y3 = eCFieldElement31.Multiply(rawXCoord.Add(eCFieldElement32)).Add(eCFieldElement32).Add(rawYCoord5);
			return new F2mPoint(curve, eCFieldElement32, y3, base.IsCompressed);
		}
		case 1:
		{
			ECFieldElement rawYCoord = base.RawYCoord;
			ECFieldElement eCFieldElement = base.RawZCoords[0];
			ECFieldElement rawYCoord2 = b.RawYCoord;
			ECFieldElement eCFieldElement2 = b.RawZCoords[0];
			bool isOne = eCFieldElement.IsOne;
			ECFieldElement eCFieldElement3 = rawYCoord2;
			ECFieldElement eCFieldElement4 = rawXCoord2;
			if (!isOne)
			{
				eCFieldElement3 = eCFieldElement3.Multiply(eCFieldElement);
				eCFieldElement4 = eCFieldElement4.Multiply(eCFieldElement);
			}
			bool isOne2 = eCFieldElement2.IsOne;
			ECFieldElement eCFieldElement5 = rawYCoord;
			ECFieldElement eCFieldElement6 = rawXCoord;
			if (!isOne2)
			{
				eCFieldElement5 = eCFieldElement5.Multiply(eCFieldElement2);
				eCFieldElement6 = eCFieldElement6.Multiply(eCFieldElement2);
			}
			ECFieldElement eCFieldElement7 = eCFieldElement3.Add(eCFieldElement5);
			ECFieldElement eCFieldElement8 = eCFieldElement4.Add(eCFieldElement6);
			if (eCFieldElement8.IsZero)
			{
				if (eCFieldElement7.IsZero)
				{
					return Twice();
				}
				return curve.Infinity;
			}
			ECFieldElement eCFieldElement9 = eCFieldElement8.Square();
			ECFieldElement eCFieldElement10 = eCFieldElement9.Multiply(eCFieldElement8);
			ECFieldElement b2 = (isOne ? eCFieldElement2 : (isOne2 ? eCFieldElement : eCFieldElement.Multiply(eCFieldElement2)));
			ECFieldElement eCFieldElement11 = eCFieldElement7.Add(eCFieldElement8);
			ECFieldElement eCFieldElement12 = eCFieldElement11.MultiplyPlusProduct(eCFieldElement7, eCFieldElement9, curve.A).Multiply(b2).Add(eCFieldElement10);
			ECFieldElement x = eCFieldElement8.Multiply(eCFieldElement12);
			ECFieldElement b3 = (isOne2 ? eCFieldElement9 : eCFieldElement9.Multiply(eCFieldElement2));
			ECFieldElement y = eCFieldElement7.MultiplyPlusProduct(rawXCoord, eCFieldElement8, rawYCoord).MultiplyPlusProduct(b3, eCFieldElement11, eCFieldElement12);
			ECFieldElement eCFieldElement13 = eCFieldElement10.Multiply(b2);
			return new F2mPoint(curve, x, y, new ECFieldElement[1] { eCFieldElement13 }, base.IsCompressed);
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
			ECFieldElement rawYCoord3 = base.RawYCoord;
			ECFieldElement eCFieldElement11 = base.RawZCoords[0];
			bool isOne2;
			ECFieldElement eCFieldElement12 = ((isOne2 = eCFieldElement11.IsOne) ? rawYCoord3 : rawYCoord3.Multiply(eCFieldElement11));
			ECFieldElement eCFieldElement13 = (isOne2 ? eCFieldElement11 : eCFieldElement11.Square());
			ECFieldElement a = curve.A;
			ECFieldElement eCFieldElement14 = (isOne2 ? a : a.Multiply(eCFieldElement13));
			ECFieldElement eCFieldElement15 = rawYCoord3.Square().Add(eCFieldElement12).Add(eCFieldElement14);
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
				ECFieldElement eCFieldElement18 = rawYCoord3.Add(rawXCoord).Square();
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
				ECFieldElement eCFieldElement20 = (isOne2 ? rawXCoord : rawXCoord.Multiply(eCFieldElement11));
				eCFieldElement19 = eCFieldElement20.SquarePlusProduct(eCFieldElement15, eCFieldElement12).Add(eCFieldElement16).Add(eCFieldElement17);
			}
			return new F2mPoint(curve, eCFieldElement16, eCFieldElement19, new ECFieldElement[1] { eCFieldElement17 }, base.IsCompressed);
		}
		case 0:
		{
			ECFieldElement rawYCoord2 = base.RawYCoord;
			ECFieldElement eCFieldElement10 = rawYCoord2.Divide(rawXCoord).Add(rawXCoord);
			ECFieldElement x2 = eCFieldElement10.Square().Add(eCFieldElement10).Add(curve.A);
			ECFieldElement y2 = rawXCoord.SquarePlusProduct(x2, eCFieldElement10.AddOne());
			return new F2mPoint(curve, x2, y2, base.IsCompressed);
		}
		case 1:
		{
			ECFieldElement rawYCoord = base.RawYCoord;
			ECFieldElement eCFieldElement = base.RawZCoords[0];
			bool isOne;
			ECFieldElement eCFieldElement2 = ((isOne = eCFieldElement.IsOne) ? rawXCoord : rawXCoord.Multiply(eCFieldElement));
			ECFieldElement b = (isOne ? rawYCoord : rawYCoord.Multiply(eCFieldElement));
			ECFieldElement eCFieldElement3 = rawXCoord.Square();
			ECFieldElement eCFieldElement4 = eCFieldElement3.Add(b);
			ECFieldElement eCFieldElement5 = eCFieldElement2;
			ECFieldElement eCFieldElement6 = eCFieldElement5.Square();
			ECFieldElement eCFieldElement7 = eCFieldElement4.Add(eCFieldElement5);
			ECFieldElement eCFieldElement8 = eCFieldElement7.MultiplyPlusProduct(eCFieldElement4, eCFieldElement6, curve.A);
			ECFieldElement x = eCFieldElement5.Multiply(eCFieldElement8);
			ECFieldElement y = eCFieldElement3.Square().MultiplyPlusProduct(eCFieldElement5, eCFieldElement8, eCFieldElement7);
			ECFieldElement eCFieldElement9 = eCFieldElement5.Multiply(eCFieldElement6);
			return new F2mPoint(curve, x, y, new ECFieldElement[1] { eCFieldElement9 }, base.IsCompressed);
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
		int coordinateSystem = curve.CoordinateSystem;
		int num = coordinateSystem;
		if (num == 6)
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
