using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecT233R1Curve : AbstractF2mCurve
{
	private const int SecT233R1_DEFAULT_COORDS = 6;

	protected readonly SecT233R1Point m_infinity;

	public override ECPoint Infinity => m_infinity;

	public override int FieldSize => 233;

	public override bool IsKoblitz => false;

	public virtual int M => 233;

	public virtual bool IsTrinomial => true;

	public virtual int K1 => 74;

	public virtual int K2 => 0;

	public virtual int K3 => 0;

	public SecT233R1Curve()
		: base(233, 74, 0, 0)
	{
		m_infinity = new SecT233R1Point(this, null, null);
		m_a = FromBigInteger(BigInteger.One);
		m_b = FromBigInteger(new BigInteger(1, Hex.Decode("0066647EDE6C332C7F8C0923BB58213B333B20E9CE4281FE115F7D8F90AD")));
		m_order = new BigInteger(1, Hex.Decode("01000000000000000000000000000013E974E72F8A6922031D2603CFE0D7"));
		m_cofactor = BigInteger.Two;
		m_coord = 6;
	}

	protected override ECCurve CloneCurve()
	{
		return new SecT233R1Curve();
	}

	public override bool SupportsCoordinateSystem(int coord)
	{
		if (coord == 6)
		{
			return true;
		}
		return false;
	}

	public override ECFieldElement FromBigInteger(BigInteger x)
	{
		return new SecT233FieldElement(x);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
	{
		return new SecT233R1Point(this, x, y, withCompression);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
	{
		return new SecT233R1Point(this, x, y, zs, withCompression);
	}
}
