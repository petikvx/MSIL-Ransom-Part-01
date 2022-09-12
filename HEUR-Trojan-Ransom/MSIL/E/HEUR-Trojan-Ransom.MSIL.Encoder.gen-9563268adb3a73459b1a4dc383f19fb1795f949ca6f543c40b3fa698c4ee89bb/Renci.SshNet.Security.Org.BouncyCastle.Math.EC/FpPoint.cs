using System;

namespace Renci.SshNet.Security.Org.BouncyCastle.Math.EC;

internal class FpPoint : AbstractFpPoint
{
	public FpPoint(ECCurve curve, ECFieldElement x, ECFieldElement y)
		: this(curve, x, y, withCompression: false)
	{
	}

	public FpPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		: base(curve, x, y, withCompression)
	{
		if (x == null != (y == null))
		{
			throw new ArgumentException("Exactly one of the field elements is null");
		}
	}

	internal FpPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		: base(curve, x, y, zs, withCompression)
	{
	}

	protected override ECPoint Detach()
	{
		return new FpPoint(null, AffineXCoord, AffineYCoord, withCompression: false);
	}

	public override ECFieldElement GetZCoord(int index)
	{
		if (index == 1 && 4 == CurveCoordinateSystem)
		{
			return GetJacobianModifiedW();
		}
		return base.GetZCoord(index);
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
		if (this == b)
		{
			return Twice();
		}
		ECCurve curve = Curve;
		int coordinateSystem = curve.CoordinateSystem;
		ECFieldElement rawXCoord = base.RawXCoord;
		ECFieldElement rawYCoord = base.RawYCoord;
		ECFieldElement rawXCoord2 = b.RawXCoord;
		ECFieldElement rawYCoord2 = b.RawYCoord;
		switch (coordinateSystem)
		{
		case 0:
		{
			ECFieldElement eCFieldElement19 = rawXCoord2.Subtract(rawXCoord);
			ECFieldElement eCFieldElement20 = rawYCoord2.Subtract(rawYCoord);
			if (eCFieldElement19.IsZero)
			{
				if (eCFieldElement20.IsZero)
				{
					return Twice();
				}
				return Curve.Infinity;
			}
			ECFieldElement eCFieldElement21 = eCFieldElement20.Divide(eCFieldElement19);
			ECFieldElement eCFieldElement22 = eCFieldElement21.Square().Subtract(rawXCoord).Subtract(rawXCoord2);
			ECFieldElement y2 = eCFieldElement21.Multiply(rawXCoord.Subtract(eCFieldElement22)).Subtract(rawYCoord);
			return new FpPoint(Curve, eCFieldElement22, y2, base.IsCompressed);
		}
		case 1:
		{
			ECFieldElement eCFieldElement23 = base.RawZCoords[0];
			ECFieldElement eCFieldElement24 = b.RawZCoords[0];
			bool isOne3 = eCFieldElement23.IsOne;
			bool isOne4 = eCFieldElement24.IsOne;
			ECFieldElement obj = (isOne3 ? rawYCoord2 : rawYCoord2.Multiply(eCFieldElement23));
			ECFieldElement eCFieldElement25 = (isOne4 ? rawYCoord : rawYCoord.Multiply(eCFieldElement24));
			ECFieldElement eCFieldElement26 = obj.Subtract(eCFieldElement25);
			ECFieldElement obj2 = (isOne3 ? rawXCoord2 : rawXCoord2.Multiply(eCFieldElement23));
			ECFieldElement b6 = (isOne4 ? rawXCoord : rawXCoord.Multiply(eCFieldElement24));
			ECFieldElement eCFieldElement27 = obj2.Subtract(b6);
			if (eCFieldElement27.IsZero)
			{
				if (eCFieldElement26.IsZero)
				{
					return Twice();
				}
				return curve.Infinity;
			}
			ECFieldElement b7 = (isOne3 ? eCFieldElement24 : (isOne4 ? eCFieldElement23 : eCFieldElement23.Multiply(eCFieldElement24)));
			ECFieldElement eCFieldElement28 = eCFieldElement27.Square();
			ECFieldElement eCFieldElement29 = eCFieldElement28.Multiply(eCFieldElement27);
			ECFieldElement eCFieldElement30 = eCFieldElement28.Multiply(b6);
			ECFieldElement b8 = eCFieldElement26.Square().Multiply(b7).Subtract(eCFieldElement29)
				.Subtract(Two(eCFieldElement30));
			ECFieldElement x = eCFieldElement27.Multiply(b8);
			ECFieldElement y3 = eCFieldElement30.Subtract(b8).MultiplyMinusProduct(eCFieldElement26, eCFieldElement25, eCFieldElement29);
			ECFieldElement eCFieldElement31 = eCFieldElement29.Multiply(b7);
			return new FpPoint(curve, x, y3, new ECFieldElement[1] { eCFieldElement31 }, base.IsCompressed);
		}
		default:
			throw new InvalidOperationException("unsupported coordinate system");
		case 2:
		case 4:
		{
			ECFieldElement eCFieldElement = base.RawZCoords[0];
			ECFieldElement eCFieldElement2 = b.RawZCoords[0];
			bool isOne = eCFieldElement.IsOne;
			ECFieldElement zSquared = null;
			ECFieldElement eCFieldElement7;
			ECFieldElement y;
			ECFieldElement eCFieldElement8;
			if (!isOne && eCFieldElement.Equals(eCFieldElement2))
			{
				ECFieldElement eCFieldElement3 = rawXCoord.Subtract(rawXCoord2);
				ECFieldElement eCFieldElement4 = rawYCoord.Subtract(rawYCoord2);
				if (eCFieldElement3.IsZero)
				{
					if (eCFieldElement4.IsZero)
					{
						return Twice();
					}
					return curve.Infinity;
				}
				ECFieldElement eCFieldElement5 = eCFieldElement3.Square();
				ECFieldElement eCFieldElement6 = rawXCoord.Multiply(eCFieldElement5);
				ECFieldElement b2 = rawXCoord2.Multiply(eCFieldElement5);
				ECFieldElement b3 = eCFieldElement6.Subtract(b2).Multiply(rawYCoord);
				eCFieldElement7 = eCFieldElement4.Square().Subtract(eCFieldElement6).Subtract(b2);
				y = eCFieldElement6.Subtract(eCFieldElement7).Multiply(eCFieldElement4).Subtract(b3);
				eCFieldElement8 = eCFieldElement3;
				if (isOne)
				{
					zSquared = eCFieldElement5;
				}
				else
				{
					eCFieldElement8 = eCFieldElement8.Multiply(eCFieldElement);
				}
			}
			else
			{
				ECFieldElement b4;
				ECFieldElement b5;
				if (isOne)
				{
					b4 = rawXCoord2;
					b5 = rawYCoord2;
				}
				else
				{
					ECFieldElement eCFieldElement9 = eCFieldElement.Square();
					b4 = eCFieldElement9.Multiply(rawXCoord2);
					b5 = eCFieldElement9.Multiply(eCFieldElement).Multiply(rawYCoord2);
				}
				bool isOne2;
				ECFieldElement eCFieldElement10;
				ECFieldElement eCFieldElement11;
				if (isOne2 = eCFieldElement2.IsOne)
				{
					eCFieldElement10 = rawXCoord;
					eCFieldElement11 = rawYCoord;
				}
				else
				{
					ECFieldElement eCFieldElement12 = eCFieldElement2.Square();
					eCFieldElement10 = eCFieldElement12.Multiply(rawXCoord);
					eCFieldElement11 = eCFieldElement12.Multiply(eCFieldElement2).Multiply(rawYCoord);
				}
				ECFieldElement eCFieldElement13 = eCFieldElement10.Subtract(b4);
				ECFieldElement eCFieldElement14 = eCFieldElement11.Subtract(b5);
				if (eCFieldElement13.IsZero)
				{
					if (eCFieldElement14.IsZero)
					{
						return Twice();
					}
					return curve.Infinity;
				}
				ECFieldElement eCFieldElement15 = eCFieldElement13.Square();
				ECFieldElement eCFieldElement16 = eCFieldElement15.Multiply(eCFieldElement13);
				ECFieldElement eCFieldElement17 = eCFieldElement15.Multiply(eCFieldElement10);
				eCFieldElement7 = eCFieldElement14.Square().Add(eCFieldElement16).Subtract(Two(eCFieldElement17));
				y = eCFieldElement17.Subtract(eCFieldElement7).MultiplyMinusProduct(eCFieldElement14, eCFieldElement16, eCFieldElement11);
				eCFieldElement8 = eCFieldElement13;
				if (!isOne)
				{
					eCFieldElement8 = eCFieldElement8.Multiply(eCFieldElement);
				}
				if (!isOne2)
				{
					eCFieldElement8 = eCFieldElement8.Multiply(eCFieldElement2);
				}
				if (eCFieldElement8 == eCFieldElement13)
				{
					zSquared = eCFieldElement15;
				}
			}
			ECFieldElement[] zs;
			if (coordinateSystem == 4)
			{
				ECFieldElement eCFieldElement18 = CalculateJacobianModifiedW(eCFieldElement8, zSquared);
				zs = new ECFieldElement[2] { eCFieldElement8, eCFieldElement18 };
			}
			else
			{
				zs = new ECFieldElement[1] { eCFieldElement8 };
			}
			return new FpPoint(curve, eCFieldElement7, y, zs, base.IsCompressed);
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
		ECFieldElement rawYCoord = base.RawYCoord;
		if (rawYCoord.IsZero)
		{
			return curve.Infinity;
		}
		int coordinateSystem = curve.CoordinateSystem;
		ECFieldElement rawXCoord = base.RawXCoord;
		switch (coordinateSystem)
		{
		case 0:
		{
			ECFieldElement x3 = rawXCoord.Square();
			ECFieldElement eCFieldElement9 = Three(x3).Add(Curve.A).Divide(Two(rawYCoord));
			ECFieldElement eCFieldElement10 = eCFieldElement9.Square().Subtract(Two(rawXCoord));
			ECFieldElement y2 = eCFieldElement9.Multiply(rawXCoord.Subtract(eCFieldElement10)).Subtract(rawYCoord);
			return new FpPoint(Curve, eCFieldElement10, y2, base.IsCompressed);
		}
		case 1:
		{
			ECFieldElement eCFieldElement11 = base.RawZCoords[0];
			bool isOne2 = eCFieldElement11.IsOne;
			ECFieldElement eCFieldElement12 = curve.A;
			if (!eCFieldElement12.IsZero && !isOne2)
			{
				eCFieldElement12 = eCFieldElement12.Multiply(eCFieldElement11.Square());
			}
			eCFieldElement12 = eCFieldElement12.Add(Three(rawXCoord.Square()));
			ECFieldElement eCFieldElement13 = (isOne2 ? rawYCoord : rawYCoord.Multiply(eCFieldElement11));
			ECFieldElement eCFieldElement14 = (isOne2 ? rawYCoord.Square() : eCFieldElement13.Multiply(rawYCoord));
			ECFieldElement x4 = rawXCoord.Multiply(eCFieldElement14);
			ECFieldElement eCFieldElement15 = Four(x4);
			ECFieldElement eCFieldElement16 = eCFieldElement12.Square().Subtract(Two(eCFieldElement15));
			ECFieldElement eCFieldElement17 = Two(eCFieldElement13);
			ECFieldElement x5 = eCFieldElement16.Multiply(eCFieldElement17);
			ECFieldElement eCFieldElement18 = Two(eCFieldElement14);
			ECFieldElement y3 = eCFieldElement15.Subtract(eCFieldElement16).Multiply(eCFieldElement12).Subtract(Two(eCFieldElement18.Square()));
			ECFieldElement x6 = (isOne2 ? Two(eCFieldElement18) : eCFieldElement17.Square());
			ECFieldElement eCFieldElement19 = Two(x6).Multiply(eCFieldElement13);
			return new FpPoint(curve, x5, y3, new ECFieldElement[1] { eCFieldElement19 }, base.IsCompressed);
		}
		case 2:
		{
			ECFieldElement eCFieldElement = base.RawZCoords[0];
			bool isOne = eCFieldElement.IsOne;
			ECFieldElement eCFieldElement2 = rawYCoord.Square();
			ECFieldElement x = eCFieldElement2.Square();
			ECFieldElement a = curve.A;
			ECFieldElement eCFieldElement3 = a.Negate();
			ECFieldElement eCFieldElement4;
			ECFieldElement eCFieldElement5;
			if (eCFieldElement3.ToBigInteger().Equals(BigInteger.ValueOf(3L)))
			{
				ECFieldElement b = (isOne ? eCFieldElement : eCFieldElement.Square());
				eCFieldElement4 = Three(rawXCoord.Add(b).Multiply(rawXCoord.Subtract(b)));
				eCFieldElement5 = Four(eCFieldElement2.Multiply(rawXCoord));
			}
			else
			{
				ECFieldElement x2 = rawXCoord.Square();
				eCFieldElement4 = Three(x2);
				if (isOne)
				{
					eCFieldElement4 = eCFieldElement4.Add(a);
				}
				else if (!a.IsZero)
				{
					ECFieldElement eCFieldElement6 = (isOne ? eCFieldElement : eCFieldElement.Square()).Square();
					eCFieldElement4 = ((eCFieldElement3.BitLength >= a.BitLength) ? eCFieldElement4.Add(eCFieldElement6.Multiply(a)) : eCFieldElement4.Subtract(eCFieldElement6.Multiply(eCFieldElement3)));
				}
				eCFieldElement5 = Four(rawXCoord.Multiply(eCFieldElement2));
			}
			ECFieldElement eCFieldElement7 = eCFieldElement4.Square().Subtract(Two(eCFieldElement5));
			ECFieldElement y = eCFieldElement5.Subtract(eCFieldElement7).Multiply(eCFieldElement4).Subtract(Eight(x));
			ECFieldElement eCFieldElement8 = Two(rawYCoord);
			if (!isOne)
			{
				eCFieldElement8 = eCFieldElement8.Multiply(eCFieldElement);
			}
			return new FpPoint(curve, eCFieldElement7, y, new ECFieldElement[1] { eCFieldElement8 }, base.IsCompressed);
		}
		default:
			throw new InvalidOperationException("unsupported coordinate system");
		case 4:
			return TwiceJacobianModified(calculateW: true);
		}
	}

	public override ECPoint TwicePlus(ECPoint b)
	{
		if (this == b)
		{
			return ThreeTimes();
		}
		if (base.IsInfinity)
		{
			return b;
		}
		if (b.IsInfinity)
		{
			return Twice();
		}
		ECFieldElement rawYCoord = base.RawYCoord;
		if (rawYCoord.IsZero)
		{
			return b;
		}
		switch (Curve.CoordinateSystem)
		{
		default:
			return Twice().Add(b);
		case 4:
			return TwiceJacobianModified(calculateW: false).Add(b);
		case 0:
		{
			ECFieldElement rawXCoord = base.RawXCoord;
			ECFieldElement rawXCoord2 = b.RawXCoord;
			ECFieldElement rawYCoord2 = b.RawYCoord;
			ECFieldElement eCFieldElement = rawXCoord2.Subtract(rawXCoord);
			ECFieldElement eCFieldElement2 = rawYCoord2.Subtract(rawYCoord);
			if (eCFieldElement.IsZero)
			{
				if (eCFieldElement2.IsZero)
				{
					return ThreeTimes();
				}
				return this;
			}
			ECFieldElement eCFieldElement3 = eCFieldElement.Square();
			ECFieldElement b2 = eCFieldElement2.Square();
			ECFieldElement eCFieldElement4 = eCFieldElement3.Multiply(Two(rawXCoord).Add(rawXCoord2)).Subtract(b2);
			if (eCFieldElement4.IsZero)
			{
				return Curve.Infinity;
			}
			ECFieldElement b3 = eCFieldElement4.Multiply(eCFieldElement).Invert();
			ECFieldElement eCFieldElement5 = eCFieldElement4.Multiply(b3).Multiply(eCFieldElement2);
			ECFieldElement eCFieldElement6 = Two(rawYCoord).Multiply(eCFieldElement3).Multiply(eCFieldElement).Multiply(b3)
				.Subtract(eCFieldElement5);
			ECFieldElement eCFieldElement7 = eCFieldElement6.Subtract(eCFieldElement5).Multiply(eCFieldElement5.Add(eCFieldElement6)).Add(rawXCoord2);
			ECFieldElement y = rawXCoord.Subtract(eCFieldElement7).Multiply(eCFieldElement6).Subtract(rawYCoord);
			return new FpPoint(Curve, eCFieldElement7, y, base.IsCompressed);
		}
		}
	}

	public override ECPoint ThreeTimes()
	{
		if (base.IsInfinity)
		{
			return this;
		}
		ECFieldElement rawYCoord = base.RawYCoord;
		if (rawYCoord.IsZero)
		{
			return this;
		}
		switch (Curve.CoordinateSystem)
		{
		default:
			return Twice().Add(this);
		case 4:
			return TwiceJacobianModified(calculateW: false).Add(this);
		case 0:
		{
			ECFieldElement rawXCoord = base.RawXCoord;
			ECFieldElement eCFieldElement = Two(rawYCoord);
			ECFieldElement eCFieldElement2 = eCFieldElement.Square();
			ECFieldElement eCFieldElement3 = Three(rawXCoord.Square()).Add(Curve.A);
			ECFieldElement b = eCFieldElement3.Square();
			ECFieldElement eCFieldElement4 = Three(rawXCoord).Multiply(eCFieldElement2).Subtract(b);
			if (eCFieldElement4.IsZero)
			{
				return Curve.Infinity;
			}
			ECFieldElement b2 = eCFieldElement4.Multiply(eCFieldElement).Invert();
			ECFieldElement eCFieldElement5 = eCFieldElement4.Multiply(b2).Multiply(eCFieldElement3);
			ECFieldElement eCFieldElement6 = eCFieldElement2.Square().Multiply(b2).Subtract(eCFieldElement5);
			ECFieldElement eCFieldElement7 = eCFieldElement6.Subtract(eCFieldElement5).Multiply(eCFieldElement5.Add(eCFieldElement6)).Add(rawXCoord);
			ECFieldElement y = rawXCoord.Subtract(eCFieldElement7).Multiply(eCFieldElement6).Subtract(rawYCoord);
			return new FpPoint(Curve, eCFieldElement7, y, base.IsCompressed);
		}
		}
	}

	public override ECPoint TimesPow2(int e)
	{
		if (e < 0)
		{
			throw new ArgumentException("cannot be negative", "e");
		}
		if (e != 0 && !base.IsInfinity)
		{
			if (e == 1)
			{
				return Twice();
			}
			ECCurve curve = Curve;
			ECFieldElement eCFieldElement = base.RawYCoord;
			if (eCFieldElement.IsZero)
			{
				return curve.Infinity;
			}
			int coordinateSystem = curve.CoordinateSystem;
			ECFieldElement eCFieldElement2 = curve.A;
			ECFieldElement eCFieldElement3 = base.RawXCoord;
			ECFieldElement eCFieldElement4 = ((base.RawZCoords.Length < 1) ? curve.FromBigInteger(BigInteger.One) : base.RawZCoords[0]);
			if (!eCFieldElement4.IsOne)
			{
				switch (coordinateSystem)
				{
				case 1:
				{
					ECFieldElement eCFieldElement5 = eCFieldElement4.Square();
					eCFieldElement3 = eCFieldElement3.Multiply(eCFieldElement4);
					eCFieldElement = eCFieldElement.Multiply(eCFieldElement5);
					eCFieldElement2 = CalculateJacobianModifiedW(eCFieldElement4, eCFieldElement5);
					break;
				}
				case 2:
					eCFieldElement2 = CalculateJacobianModifiedW(eCFieldElement4, null);
					break;
				case 4:
					eCFieldElement2 = GetJacobianModifiedW();
					break;
				}
			}
			int num = 0;
			while (true)
			{
				if (num < e)
				{
					if (eCFieldElement.IsZero)
					{
						break;
					}
					ECFieldElement x = eCFieldElement3.Square();
					ECFieldElement eCFieldElement6 = Three(x);
					ECFieldElement eCFieldElement7 = Two(eCFieldElement);
					ECFieldElement eCFieldElement8 = eCFieldElement7.Multiply(eCFieldElement);
					ECFieldElement eCFieldElement9 = Two(eCFieldElement3.Multiply(eCFieldElement8));
					ECFieldElement x2 = eCFieldElement8.Square();
					ECFieldElement eCFieldElement10 = Two(x2);
					if (!eCFieldElement2.IsZero)
					{
						eCFieldElement6 = eCFieldElement6.Add(eCFieldElement2);
						eCFieldElement2 = Two(eCFieldElement10.Multiply(eCFieldElement2));
					}
					eCFieldElement3 = eCFieldElement6.Square().Subtract(Two(eCFieldElement9));
					eCFieldElement = eCFieldElement6.Multiply(eCFieldElement9.Subtract(eCFieldElement3)).Subtract(eCFieldElement10);
					eCFieldElement4 = (eCFieldElement4.IsOne ? eCFieldElement7 : eCFieldElement7.Multiply(eCFieldElement4));
					num++;
					continue;
				}
				switch (coordinateSystem)
				{
				case 0:
				{
					ECFieldElement eCFieldElement11 = eCFieldElement4.Invert();
					ECFieldElement eCFieldElement12 = eCFieldElement11.Square();
					ECFieldElement b = eCFieldElement12.Multiply(eCFieldElement11);
					return new FpPoint(curve, eCFieldElement3.Multiply(eCFieldElement12), eCFieldElement.Multiply(b), base.IsCompressed);
				}
				case 1:
					eCFieldElement3 = eCFieldElement3.Multiply(eCFieldElement4);
					eCFieldElement4 = eCFieldElement4.Multiply(eCFieldElement4.Square());
					return new FpPoint(curve, eCFieldElement3, eCFieldElement, new ECFieldElement[1] { eCFieldElement4 }, base.IsCompressed);
				case 2:
					return new FpPoint(curve, eCFieldElement3, eCFieldElement, new ECFieldElement[1] { eCFieldElement4 }, base.IsCompressed);
				default:
					throw new InvalidOperationException("unsupported coordinate system");
				case 4:
					return new FpPoint(curve, eCFieldElement3, eCFieldElement, new ECFieldElement[2] { eCFieldElement4, eCFieldElement2 }, base.IsCompressed);
				}
			}
			return curve.Infinity;
		}
		return this;
	}

	protected virtual ECFieldElement Two(ECFieldElement x)
	{
		return x.Add(x);
	}

	protected virtual ECFieldElement Three(ECFieldElement x)
	{
		return Two(x).Add(x);
	}

	protected virtual ECFieldElement Four(ECFieldElement x)
	{
		return Two(Two(x));
	}

	protected virtual ECFieldElement Eight(ECFieldElement x)
	{
		return Four(Two(x));
	}

	protected virtual ECFieldElement DoubleProductFromSquares(ECFieldElement a, ECFieldElement b, ECFieldElement aSquared, ECFieldElement bSquared)
	{
		return a.Add(b).Square().Subtract(aSquared)
			.Subtract(bSquared);
	}

	public override ECPoint Negate()
	{
		if (base.IsInfinity)
		{
			return this;
		}
		ECCurve curve = Curve;
		if (curve.CoordinateSystem != 0)
		{
			return new FpPoint(curve, base.RawXCoord, base.RawYCoord.Negate(), base.RawZCoords, base.IsCompressed);
		}
		return new FpPoint(curve, base.RawXCoord, base.RawYCoord.Negate(), base.IsCompressed);
	}

	protected virtual ECFieldElement CalculateJacobianModifiedW(ECFieldElement Z, ECFieldElement ZSquared)
	{
		ECFieldElement a = Curve.A;
		if (!a.IsZero && !Z.IsOne)
		{
			if (ZSquared == null)
			{
				ZSquared = Z.Square();
			}
			ECFieldElement eCFieldElement = ZSquared.Square();
			ECFieldElement eCFieldElement2 = a.Negate();
			if (eCFieldElement2.BitLength < a.BitLength)
			{
				return eCFieldElement.Multiply(eCFieldElement2).Negate();
			}
			return eCFieldElement.Multiply(a);
		}
		return a;
	}

	protected virtual ECFieldElement GetJacobianModifiedW()
	{
		ECFieldElement[] rawZCoords = base.RawZCoords;
		ECFieldElement eCFieldElement = rawZCoords[1];
		if (eCFieldElement == null)
		{
			eCFieldElement = (rawZCoords[1] = CalculateJacobianModifiedW(rawZCoords[0], null));
		}
		return eCFieldElement;
	}

	protected virtual FpPoint TwiceJacobianModified(bool calculateW)
	{
		ECFieldElement rawXCoord = base.RawXCoord;
		ECFieldElement rawYCoord = base.RawYCoord;
		ECFieldElement eCFieldElement = base.RawZCoords[0];
		ECFieldElement jacobianModifiedW = GetJacobianModifiedW();
		ECFieldElement x = rawXCoord.Square();
		ECFieldElement eCFieldElement2 = Three(x).Add(jacobianModifiedW);
		ECFieldElement eCFieldElement3 = Two(rawYCoord);
		ECFieldElement eCFieldElement4 = eCFieldElement3.Multiply(rawYCoord);
		ECFieldElement eCFieldElement5 = Two(rawXCoord.Multiply(eCFieldElement4));
		ECFieldElement eCFieldElement6 = eCFieldElement2.Square().Subtract(Two(eCFieldElement5));
		ECFieldElement x2 = eCFieldElement4.Square();
		ECFieldElement eCFieldElement7 = Two(x2);
		ECFieldElement y = eCFieldElement2.Multiply(eCFieldElement5.Subtract(eCFieldElement6)).Subtract(eCFieldElement7);
		ECFieldElement eCFieldElement8 = (calculateW ? Two(eCFieldElement7.Multiply(jacobianModifiedW)) : null);
		ECFieldElement eCFieldElement9 = (eCFieldElement.IsOne ? eCFieldElement3 : eCFieldElement3.Multiply(eCFieldElement));
		return new FpPoint(Curve, eCFieldElement6, y, new ECFieldElement[2] { eCFieldElement9, eCFieldElement8 }, base.IsCompressed);
	}
}
