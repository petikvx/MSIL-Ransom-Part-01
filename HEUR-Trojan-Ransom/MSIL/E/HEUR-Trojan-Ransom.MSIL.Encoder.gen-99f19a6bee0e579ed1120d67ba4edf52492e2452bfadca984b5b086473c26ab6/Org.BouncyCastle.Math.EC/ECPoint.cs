using System;
using System.Collections;
using System.Text;

namespace Org.BouncyCastle.Math.EC;

public abstract class ECPoint
{
	protected static ECFieldElement[] EMPTY_ZS = new ECFieldElement[0];

	protected internal readonly ECCurve m_curve;

	protected internal readonly ECFieldElement m_x;

	protected internal readonly ECFieldElement m_y;

	protected internal readonly ECFieldElement[] m_zs;

	protected internal readonly bool m_withCompression;

	protected internal IDictionary m_preCompTable = null;

	public virtual ECCurve Curve => m_curve;

	protected virtual int CurveCoordinateSystem
	{
		get
		{
			if (m_curve != null)
			{
				return m_curve.CoordinateSystem;
			}
			return 0;
		}
	}

	[Obsolete("Use AffineXCoord, or Normalize() and XCoord, instead")]
	public virtual ECFieldElement X => Normalize().XCoord;

	[Obsolete("Use AffineYCoord, or Normalize() and YCoord, instead")]
	public virtual ECFieldElement Y => Normalize().YCoord;

	public virtual ECFieldElement AffineXCoord
	{
		get
		{
			CheckNormalized();
			return XCoord;
		}
	}

	public virtual ECFieldElement AffineYCoord
	{
		get
		{
			CheckNormalized();
			return YCoord;
		}
	}

	public virtual ECFieldElement XCoord => m_x;

	public virtual ECFieldElement YCoord => m_y;

	protected internal ECFieldElement RawXCoord => m_x;

	protected internal ECFieldElement RawYCoord => m_y;

	protected internal ECFieldElement[] RawZCoords => m_zs;

	public bool IsInfinity
	{
		get
		{
			if (m_x == null)
			{
				return m_y == null;
			}
			return false;
		}
	}

	public bool IsCompressed => m_withCompression;

	protected internal abstract bool CompressionYTilde { get; }

	protected static ECFieldElement[] GetInitialZCoords(ECCurve curve)
	{
		int num = curve?.CoordinateSystem ?? 0;
		int num2 = num;
		if (num2 != 0 && num2 != 5)
		{
			ECFieldElement eCFieldElement = curve.FromBigInteger(BigInteger.One);
			switch (num)
			{
			case 3:
				return new ECFieldElement[3] { eCFieldElement, eCFieldElement, eCFieldElement };
			case 4:
				return new ECFieldElement[2] { eCFieldElement, curve.A };
			default:
				throw new ArgumentException("unknown coordinate system");
			case 1:
			case 2:
			case 6:
				return new ECFieldElement[1] { eCFieldElement };
			}
		}
		return EMPTY_ZS;
	}

	protected ECPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		: this(curve, x, y, GetInitialZCoords(curve), withCompression)
	{
	}

	internal ECPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
	{
		m_curve = curve;
		m_x = x;
		m_y = y;
		m_zs = zs;
		m_withCompression = withCompression;
	}

	protected internal bool SatisfiesCofactor()
	{
		BigInteger cofactor = Curve.Cofactor;
		if (cofactor != null && !cofactor.Equals(BigInteger.One))
		{
			return !ECAlgorithms.ReferenceMultiply(this, cofactor).IsInfinity;
		}
		return true;
	}

	protected abstract bool SatisfiesCurveEquation();

	public ECPoint GetDetachedPoint()
	{
		return Normalize().Detach();
	}

	protected abstract ECPoint Detach();

	public virtual ECFieldElement GetZCoord(int index)
	{
		if (index >= 0 && index < m_zs.Length)
		{
			return m_zs[index];
		}
		return null;
	}

	public virtual ECFieldElement[] GetZCoords()
	{
		int num = m_zs.Length;
		if (num == 0)
		{
			return m_zs;
		}
		ECFieldElement[] array = new ECFieldElement[num];
		Array.Copy(m_zs, 0, array, 0, num);
		return array;
	}

	protected virtual void CheckNormalized()
	{
		if (!IsNormalized())
		{
			throw new InvalidOperationException("point not in normal form");
		}
	}

	public virtual bool IsNormalized()
	{
		int curveCoordinateSystem = CurveCoordinateSystem;
		if (curveCoordinateSystem != 0 && curveCoordinateSystem != 5 && !IsInfinity)
		{
			return RawZCoords[0].IsOne;
		}
		return true;
	}

	public virtual ECPoint Normalize()
	{
		if (IsInfinity)
		{
			return this;
		}
		int curveCoordinateSystem = CurveCoordinateSystem;
		if (curveCoordinateSystem != 0 && curveCoordinateSystem != 5)
		{
			ECFieldElement eCFieldElement = RawZCoords[0];
			if (eCFieldElement.IsOne)
			{
				return this;
			}
			return Normalize(eCFieldElement.Invert());
		}
		return this;
	}

	internal virtual ECPoint Normalize(ECFieldElement zInv)
	{
		switch (CurveCoordinateSystem)
		{
		case 2:
		case 3:
		case 4:
		{
			ECFieldElement eCFieldElement = zInv.Square();
			ECFieldElement sy = eCFieldElement.Multiply(zInv);
			return CreateScaledPoint(eCFieldElement, sy);
		}
		default:
			throw new InvalidOperationException("not a projective coordinate system");
		case 1:
		case 6:
			return CreateScaledPoint(zInv, zInv);
		}
	}

	protected virtual ECPoint CreateScaledPoint(ECFieldElement sx, ECFieldElement sy)
	{
		return Curve.CreateRawPoint(RawXCoord.Multiply(sx), RawYCoord.Multiply(sy), IsCompressed);
	}

	public bool IsValid()
	{
		if (IsInfinity)
		{
			return true;
		}
		ECCurve curve = Curve;
		if (curve != null)
		{
			if (!SatisfiesCurveEquation())
			{
				return false;
			}
			if (!SatisfiesCofactor())
			{
				return false;
			}
		}
		return true;
	}

	public virtual ECPoint ScaleX(ECFieldElement scale)
	{
		if (!IsInfinity)
		{
			return Curve.CreateRawPoint(RawXCoord.Multiply(scale), RawYCoord, RawZCoords, IsCompressed);
		}
		return this;
	}

	public virtual ECPoint ScaleY(ECFieldElement scale)
	{
		if (!IsInfinity)
		{
			return Curve.CreateRawPoint(RawXCoord, RawYCoord.Multiply(scale), RawZCoords, IsCompressed);
		}
		return this;
	}

	public override bool Equals(object obj)
	{
		return Equals(obj as ECPoint);
	}

	public virtual bool Equals(ECPoint other)
	{
		if (this == other)
		{
			return true;
		}
		if (other == null)
		{
			return false;
		}
		ECCurve curve = Curve;
		ECCurve curve2 = other.Curve;
		bool flag = null == curve;
		bool flag2 = null == curve2;
		bool isInfinity = IsInfinity;
		bool isInfinity2 = other.IsInfinity;
		if (!isInfinity && !isInfinity2)
		{
			ECPoint eCPoint = this;
			ECPoint eCPoint2 = other;
			if (!flag || !flag2)
			{
				if (flag)
				{
					eCPoint2 = eCPoint2.Normalize();
				}
				else if (flag2)
				{
					eCPoint = eCPoint.Normalize();
				}
				else
				{
					if (!curve.Equals(curve2))
					{
						return false;
					}
					ECPoint[] array = new ECPoint[2]
					{
						this,
						curve.ImportPoint(eCPoint2)
					};
					curve.NormalizeAll(array);
					eCPoint = array[0];
					eCPoint2 = array[1];
				}
			}
			if (eCPoint.XCoord.Equals(eCPoint2.XCoord))
			{
				return eCPoint.YCoord.Equals(eCPoint2.YCoord);
			}
			return false;
		}
		if (isInfinity && isInfinity2)
		{
			if (!flag && !flag2)
			{
				return curve.Equals(curve2);
			}
			return true;
		}
		return false;
	}

	public override int GetHashCode()
	{
		ECCurve curve = Curve;
		int num = ((curve != null) ? (~curve.GetHashCode()) : 0);
		if (!IsInfinity)
		{
			ECPoint eCPoint = Normalize();
			num ^= eCPoint.XCoord.GetHashCode() * 17;
			num ^= eCPoint.YCoord.GetHashCode() * 257;
		}
		return num;
	}

	public override string ToString()
	{
		if (IsInfinity)
		{
			return "INF";
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append('(');
		stringBuilder.Append(RawXCoord);
		stringBuilder.Append(',');
		stringBuilder.Append(RawYCoord);
		for (int i = 0; i < m_zs.Length; i++)
		{
			stringBuilder.Append(',');
			stringBuilder.Append(m_zs[i]);
		}
		stringBuilder.Append(')');
		return stringBuilder.ToString();
	}

	public virtual byte[] GetEncoded()
	{
		return GetEncoded(m_withCompression);
	}

	public abstract byte[] GetEncoded(bool compressed);

	public abstract ECPoint Add(ECPoint b);

	public abstract ECPoint Subtract(ECPoint b);

	public abstract ECPoint Negate();

	public virtual ECPoint TimesPow2(int e)
	{
		if (e < 0)
		{
			throw new ArgumentException("cannot be negative", "e");
		}
		ECPoint eCPoint = this;
		while (--e >= 0)
		{
			eCPoint = eCPoint.Twice();
		}
		return eCPoint;
	}

	public abstract ECPoint Twice();

	public abstract ECPoint Multiply(BigInteger b);

	public virtual ECPoint TwicePlus(ECPoint b)
	{
		return Twice().Add(b);
	}

	public virtual ECPoint ThreeTimes()
	{
		return TwicePlus(this);
	}
}
