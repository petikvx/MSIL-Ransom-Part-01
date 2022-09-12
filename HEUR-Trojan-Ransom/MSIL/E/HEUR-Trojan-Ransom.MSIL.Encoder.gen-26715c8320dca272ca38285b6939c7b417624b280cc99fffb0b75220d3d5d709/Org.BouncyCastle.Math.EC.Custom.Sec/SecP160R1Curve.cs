using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecP160R1Curve : AbstractFpCurve
{
	private class SecP160R1LookupTable : ECLookupTable
	{
		private readonly SecP160R1Curve m_outer;

		private readonly uint[] m_table;

		private readonly int m_size;

		public virtual int Size => m_size;

		internal SecP160R1LookupTable(SecP160R1Curve outer, uint[] table, int size)
		{
			m_outer = outer;
			m_table = table;
			m_size = size;
		}

		public virtual ECPoint Lookup(int index)
		{
			uint[] array = Nat160.Create();
			uint[] array2 = Nat160.Create();
			int num = 0;
			for (int i = 0; i < m_size; i++)
			{
				uint num2 = (uint)((i ^ index) - 1 >> 31);
				for (int j = 0; j < 5; j++)
				{
					uint[] array3;
					uint[] array4 = (array3 = array);
					int num3 = j;
					nint num4 = num3;
					array4[num3] = array3[num4] ^ (m_table[num + j] & num2);
					uint[] array5 = (array3 = array2);
					int num5 = j;
					num4 = num5;
					array5[num5] = array3[num4] ^ (m_table[num + 5 + j] & num2);
				}
				num += 10;
			}
			return m_outer.CreateRawPoint(new SecP160R1FieldElement(array), new SecP160R1FieldElement(array2), withCompression: false);
		}
	}

	private const int SECP160R1_DEFAULT_COORDS = 2;

	private const int SECP160R1_FE_INTS = 5;

	public static readonly BigInteger q = new BigInteger(1, Hex.Decode("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF7FFFFFFF"));

	protected readonly SecP160R1Point m_infinity;

	public virtual BigInteger Q => q;

	public override ECPoint Infinity => m_infinity;

	public override int FieldSize => q.BitLength;

	public SecP160R1Curve()
		: base(q)
	{
		m_infinity = new SecP160R1Point(this, null, null);
		m_a = FromBigInteger(new BigInteger(1, Hex.Decode("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF7FFFFFFC")));
		m_b = FromBigInteger(new BigInteger(1, Hex.Decode("1C97BEFC54BD7A8B65ACF89F81D4D4ADC565FA45")));
		m_order = new BigInteger(1, Hex.Decode("0100000000000000000001F4C8F927AED3CA752257"));
		m_cofactor = BigInteger.One;
		m_coord = 2;
	}

	protected override ECCurve CloneCurve()
	{
		return new SecP160R1Curve();
	}

	public override bool SupportsCoordinateSystem(int coord)
	{
		if (coord == 2)
		{
			return true;
		}
		return false;
	}

	public override ECFieldElement FromBigInteger(BigInteger x)
	{
		return new SecP160R1FieldElement(x);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
	{
		return new SecP160R1Point(this, x, y, withCompression);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
	{
		return new SecP160R1Point(this, x, y, zs, withCompression);
	}

	public override ECLookupTable CreateCacheSafeLookupTable(ECPoint[] points, int off, int len)
	{
		uint[] array = new uint[len * 5 * 2];
		int num = 0;
		for (int i = 0; i < len; i++)
		{
			ECPoint eCPoint = points[off + i];
			Nat160.Copy(((SecP160R1FieldElement)eCPoint.RawXCoord).x, 0, array, num);
			num += 5;
			Nat160.Copy(((SecP160R1FieldElement)eCPoint.RawYCoord).x, 0, array, num);
			num += 5;
		}
		return new SecP160R1LookupTable(this, array, len);
	}
}
