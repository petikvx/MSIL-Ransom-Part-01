using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecT409R1Curve : AbstractF2mCurve
{
	private class SecT409R1LookupTable : ECLookupTable
	{
		private readonly SecT409R1Curve m_outer;

		private readonly ulong[] m_table;

		private readonly int m_size;

		public virtual int Size => m_size;

		internal SecT409R1LookupTable(SecT409R1Curve outer, ulong[] table, int size)
		{
			m_outer = outer;
			m_table = table;
			m_size = size;
		}

		public virtual ECPoint Lookup(int index)
		{
			ulong[] array = Nat448.Create64();
			ulong[] array2 = Nat448.Create64();
			int num = 0;
			for (int i = 0; i < m_size; i++)
			{
				ulong num2 = (ulong)((i ^ index) - 1 >> 31);
				for (int j = 0; j < 7; j++)
				{
					ulong[] array3;
					ulong[] array4 = (array3 = array);
					int num3 = j;
					nint num4 = num3;
					array4[num3] = array3[num4] ^ (m_table[num + j] & num2);
					ulong[] array5 = (array3 = array2);
					int num5 = j;
					num4 = num5;
					array5[num5] = array3[num4] ^ (m_table[num + 7 + j] & num2);
				}
				num += 14;
			}
			return m_outer.CreateRawPoint(new SecT409FieldElement(array), new SecT409FieldElement(array2), withCompression: false);
		}
	}

	private const int SECT409R1_DEFAULT_COORDS = 6;

	private const int SECT409R1_FE_LONGS = 7;

	protected readonly SecT409R1Point m_infinity;

	public override ECPoint Infinity => m_infinity;

	public override int FieldSize => 409;

	public override bool IsKoblitz => false;

	public virtual int M => 409;

	public virtual bool IsTrinomial => true;

	public virtual int K1 => 87;

	public virtual int K2 => 0;

	public virtual int K3 => 0;

	public SecT409R1Curve()
		: base(409, 87, 0, 0)
	{
		m_infinity = new SecT409R1Point(this, null, null);
		m_a = FromBigInteger(BigInteger.One);
		m_b = FromBigInteger(new BigInteger(1, Hex.Decode("0021A5C2C8EE9FEB5C4B9A753B7B476B7FD6422EF1F3DD674761FA99D6AC27C8A9A197B272822F6CD57A55AA4F50AE317B13545F")));
		m_order = new BigInteger(1, Hex.Decode("010000000000000000000000000000000000000000000000000001E2AAD6A612F33307BE5FA47C3C9E052F838164CD37D9A21173"));
		m_cofactor = BigInteger.Two;
		m_coord = 6;
	}

	protected override ECCurve CloneCurve()
	{
		return new SecT409R1Curve();
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
		return new SecT409FieldElement(x);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
	{
		return new SecT409R1Point(this, x, y, withCompression);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
	{
		return new SecT409R1Point(this, x, y, zs, withCompression);
	}

	public override ECLookupTable CreateCacheSafeLookupTable(ECPoint[] points, int off, int len)
	{
		ulong[] array = new ulong[len * 7 * 2];
		int num = 0;
		for (int i = 0; i < len; i++)
		{
			ECPoint eCPoint = points[off + i];
			Nat448.Copy64(((SecT409FieldElement)eCPoint.RawXCoord).x, 0, array, num);
			num += 7;
			Nat448.Copy64(((SecT409FieldElement)eCPoint.RawYCoord).x, 0, array, num);
			num += 7;
		}
		return new SecT409R1LookupTable(this, array, len);
	}
}
