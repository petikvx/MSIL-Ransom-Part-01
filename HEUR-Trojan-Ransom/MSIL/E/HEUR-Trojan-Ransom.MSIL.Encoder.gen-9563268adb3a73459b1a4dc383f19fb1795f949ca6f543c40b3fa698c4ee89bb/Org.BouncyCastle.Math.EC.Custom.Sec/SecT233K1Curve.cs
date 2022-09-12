using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecT233K1Curve : AbstractF2mCurve
{
	private class SecT233K1LookupTable : ECLookupTable
	{
		private readonly SecT233K1Curve m_outer;

		private readonly ulong[] m_table;

		private readonly int m_size;

		public virtual int Size => m_size;

		internal SecT233K1LookupTable(SecT233K1Curve outer, ulong[] table, int size)
		{
			m_outer = outer;
			m_table = table;
			m_size = size;
		}

		public virtual ECPoint Lookup(int index)
		{
			ulong[] array = Nat256.Create64();
			ulong[] array2 = Nat256.Create64();
			int num = 0;
			for (int i = 0; i < m_size; i++)
			{
				ulong num2 = (ulong)((i ^ index) - 1 >> 31);
				for (int j = 0; j < 4; j++)
				{
					ulong[] array3;
					ulong[] array4 = (array3 = array);
					int num3 = j;
					nint num4 = num3;
					array4[num3] = array3[num4] ^ (m_table[num + j] & num2);
					ulong[] array5 = (array3 = array2);
					int num5 = j;
					num4 = num5;
					array5[num5] = array3[num4] ^ (m_table[num + 4 + j] & num2);
				}
				num += 8;
			}
			return m_outer.CreateRawPoint(new SecT233FieldElement(array), new SecT233FieldElement(array2), withCompression: false);
		}
	}

	private const int SECT233K1_DEFAULT_COORDS = 6;

	private const int SECT233K1_FE_LONGS = 4;

	protected readonly SecT233K1Point m_infinity;

	public override int FieldSize => 233;

	public override ECPoint Infinity => m_infinity;

	public override bool IsKoblitz => true;

	public virtual int M => 233;

	public virtual bool IsTrinomial => true;

	public virtual int K1 => 74;

	public virtual int K2 => 0;

	public virtual int K3 => 0;

	public SecT233K1Curve()
		: base(233, 74, 0, 0)
	{
		m_infinity = new SecT233K1Point(this, null, null);
		m_a = FromBigInteger(BigInteger.Zero);
		m_b = FromBigInteger(BigInteger.One);
		m_order = new BigInteger(1, Hex.Decode("8000000000000000000000000000069D5BB915BCD46EFB1AD5F173ABDF"));
		m_cofactor = BigInteger.ValueOf(4L);
		m_coord = 6;
	}

	protected override ECCurve CloneCurve()
	{
		return new SecT233K1Curve();
	}

	public override bool SupportsCoordinateSystem(int coord)
	{
		if (coord == 6)
		{
			return true;
		}
		return false;
	}

	protected override ECMultiplier CreateDefaultMultiplier()
	{
		return new WTauNafMultiplier();
	}

	public override ECFieldElement FromBigInteger(BigInteger x)
	{
		return new SecT233FieldElement(x);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
	{
		return new SecT233K1Point(this, x, y, withCompression);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
	{
		return new SecT233K1Point(this, x, y, zs, withCompression);
	}

	public override ECLookupTable CreateCacheSafeLookupTable(ECPoint[] points, int off, int len)
	{
		ulong[] array = new ulong[len * 4 * 2];
		int num = 0;
		for (int i = 0; i < len; i++)
		{
			ECPoint eCPoint = points[off + i];
			Nat256.Copy64(((SecT233FieldElement)eCPoint.RawXCoord).x, 0, array, num);
			num += 4;
			Nat256.Copy64(((SecT233FieldElement)eCPoint.RawYCoord).x, 0, array, num);
			num += 4;
		}
		return new SecT233K1LookupTable(this, array, len);
	}
}
