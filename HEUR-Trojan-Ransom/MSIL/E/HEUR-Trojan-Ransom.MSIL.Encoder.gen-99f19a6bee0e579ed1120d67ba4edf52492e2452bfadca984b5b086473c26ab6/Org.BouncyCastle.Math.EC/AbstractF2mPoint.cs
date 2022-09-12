using System;

namespace Org.BouncyCastle.Math.EC;

public abstract class AbstractF2mPoint : ECPointBase
{
	protected AbstractF2mPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		: base(curve, x, y, withCompression)
	{
	}

	protected AbstractF2mPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		: base(curve, x, y, zs, withCompression)
	{
	}

	protected override bool SatisfiesCurveEquation()
	{
		ECCurve curve = Curve;
		ECFieldElement rawXCoord = base.RawXCoord;
		ECFieldElement rawYCoord = base.RawYCoord;
		ECFieldElement eCFieldElement = curve.A;
		ECFieldElement eCFieldElement2 = curve.B;
		int coordinateSystem = curve.CoordinateSystem;
		ECFieldElement eCFieldElement5;
		ECFieldElement eCFieldElement4;
		if (coordinateSystem == 6)
		{
			ECFieldElement eCFieldElement3 = base.RawZCoords[0];
			bool isOne = eCFieldElement3.IsOne;
			if (rawXCoord.IsZero)
			{
				eCFieldElement4 = rawYCoord.Square();
				eCFieldElement5 = eCFieldElement2;
				if (!isOne)
				{
					ECFieldElement b = eCFieldElement3.Square();
					eCFieldElement5 = eCFieldElement5.Multiply(b);
				}
			}
			else
			{
				ECFieldElement eCFieldElement6 = rawYCoord;
				ECFieldElement eCFieldElement7 = rawXCoord.Square();
				if (isOne)
				{
					eCFieldElement4 = eCFieldElement6.Square().Add(eCFieldElement6).Add(eCFieldElement);
					eCFieldElement5 = eCFieldElement7.Square().Add(eCFieldElement2);
				}
				else
				{
					ECFieldElement eCFieldElement8 = eCFieldElement3.Square();
					ECFieldElement y = eCFieldElement8.Square();
					eCFieldElement4 = eCFieldElement6.Add(eCFieldElement3).MultiplyPlusProduct(eCFieldElement6, eCFieldElement, eCFieldElement8);
					eCFieldElement5 = eCFieldElement7.SquarePlusProduct(eCFieldElement2, y);
				}
				eCFieldElement4 = eCFieldElement4.Multiply(eCFieldElement7);
			}
		}
		else
		{
			eCFieldElement4 = rawYCoord.Add(rawXCoord).Multiply(rawYCoord);
			switch (coordinateSystem)
			{
			default:
				throw new InvalidOperationException("unsupported coordinate system");
			case 1:
			{
				ECFieldElement eCFieldElement9 = base.RawZCoords[0];
				if (!eCFieldElement9.IsOne)
				{
					ECFieldElement b2 = eCFieldElement9.Square();
					ECFieldElement b3 = eCFieldElement9.Multiply(b2);
					eCFieldElement4 = eCFieldElement4.Multiply(eCFieldElement9);
					eCFieldElement = eCFieldElement.Multiply(eCFieldElement9);
					eCFieldElement2 = eCFieldElement2.Multiply(b3);
				}
				break;
			}
			case 0:
				break;
			}
			eCFieldElement5 = rawXCoord.Add(eCFieldElement).Multiply(rawXCoord.Square()).Add(eCFieldElement2);
		}
		return eCFieldElement4.Equals(eCFieldElement5);
	}

	public override ECPoint ScaleX(ECFieldElement scale)
	{
		if (base.IsInfinity)
		{
			return this;
		}
		switch (CurveCoordinateSystem)
		{
		default:
			return base.ScaleX(scale);
		case 5:
		{
			ECFieldElement rawXCoord2 = base.RawXCoord;
			ECFieldElement rawYCoord2 = base.RawYCoord;
			ECFieldElement b2 = rawXCoord2.Multiply(scale);
			ECFieldElement y2 = rawYCoord2.Add(rawXCoord2).Divide(scale).Add(b2);
			return Curve.CreateRawPoint(rawXCoord2, y2, base.RawZCoords, base.IsCompressed);
		}
		case 6:
		{
			ECFieldElement rawXCoord = base.RawXCoord;
			ECFieldElement rawYCoord = base.RawYCoord;
			ECFieldElement eCFieldElement = base.RawZCoords[0];
			ECFieldElement b = rawXCoord.Multiply(scale.Square());
			ECFieldElement y = rawYCoord.Add(rawXCoord).Add(b);
			ECFieldElement eCFieldElement2 = eCFieldElement.Multiply(scale);
			return Curve.CreateRawPoint(rawXCoord, y, new ECFieldElement[1] { eCFieldElement2 }, base.IsCompressed);
		}
		}
	}

	public override ECPoint ScaleY(ECFieldElement scale)
	{
		if (base.IsInfinity)
		{
			return this;
		}
		switch (CurveCoordinateSystem)
		{
		default:
			return base.ScaleY(scale);
		case 5:
		case 6:
		{
			ECFieldElement rawXCoord = base.RawXCoord;
			ECFieldElement rawYCoord = base.RawYCoord;
			ECFieldElement y = rawYCoord.Add(rawXCoord).Multiply(scale).Add(rawXCoord);
			return Curve.CreateRawPoint(rawXCoord, y, base.RawZCoords, base.IsCompressed);
		}
		}
	}

	public override ECPoint Subtract(ECPoint b)
	{
		if (b.IsInfinity)
		{
			return this;
		}
		return Add(b.Negate());
	}

	public virtual AbstractF2mPoint Tau()
	{
		if (base.IsInfinity)
		{
			return this;
		}
		ECCurve curve = Curve;
		int coordinateSystem = curve.CoordinateSystem;
		ECFieldElement rawXCoord = base.RawXCoord;
		switch (coordinateSystem)
		{
		default:
			throw new InvalidOperationException("unsupported coordinate system");
		case 0:
		case 5:
		{
			ECFieldElement rawYCoord2 = base.RawYCoord;
			return (AbstractF2mPoint)curve.CreateRawPoint(rawXCoord.Square(), rawYCoord2.Square(), base.IsCompressed);
		}
		case 1:
		case 6:
		{
			ECFieldElement rawYCoord = base.RawYCoord;
			ECFieldElement eCFieldElement = base.RawZCoords[0];
			return (AbstractF2mPoint)curve.CreateRawPoint(rawXCoord.Square(), rawYCoord.Square(), new ECFieldElement[1] { eCFieldElement.Square() }, base.IsCompressed);
		}
		}
	}

	public virtual AbstractF2mPoint TauPow(int pow)
	{
		if (base.IsInfinity)
		{
			return this;
		}
		ECCurve curve = Curve;
		int coordinateSystem = curve.CoordinateSystem;
		ECFieldElement rawXCoord = base.RawXCoord;
		switch (coordinateSystem)
		{
		default:
			throw new InvalidOperationException("unsupported coordinate system");
		case 0:
		case 5:
		{
			ECFieldElement rawYCoord2 = base.RawYCoord;
			return (AbstractF2mPoint)curve.CreateRawPoint(rawXCoord.SquarePow(pow), rawYCoord2.SquarePow(pow), base.IsCompressed);
		}
		case 1:
		case 6:
		{
			ECFieldElement rawYCoord = base.RawYCoord;
			ECFieldElement eCFieldElement = base.RawZCoords[0];
			return (AbstractF2mPoint)curve.CreateRawPoint(rawXCoord.SquarePow(pow), rawYCoord.SquarePow(pow), new ECFieldElement[1] { eCFieldElement.SquarePow(pow) }, base.IsCompressed);
		}
		}
	}
}
