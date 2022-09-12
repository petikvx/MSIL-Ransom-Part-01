using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecP160K1Curve : AbstractFpCurve
{
	private class SecP160K1LookupTable : ECLookupTable
	{
		private readonly SecP160K1Curve m_outer;

		private readonly uint[] m_table;

		private readonly int m_size;

		public virtual int Size => m_size;

		internal SecP160K1LookupTable(SecP160K1Curve outer, uint[] table, int size)
		{
			m_outer = outer;
			m_table = table;
			m_size = size;
		}

		public virtual ECPoint Lookup(int index)
		{
			uint[] array = Nat256.Create();
			uint[] array2 = Nat256.Create();
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
			return m_outer.CreateRawPoint(new SecP160R2FieldElement(array), new SecP160R2FieldElement(array2), withCompression: false);
		}
	}

	private const int SECP160K1_DEFAULT_COORDS = 2;

	private const int SECP160K1_FE_INTS = 5;

	public static readonly BigInteger q = SecP160R2Curve.q;

	protected readonly SecP160K1Point m_infinity;

	public virtual BigInteger Q => q;

	public override ECPoint Infinity => m_infinity;

	public override int FieldSize => q.BitLength;

	public SecP160K1Curve()
		: base(q)
	{
		m_infinity = new SecP160K1Point(this, null, null);
		m_a = FromBigInteger(BigInteger.Zero);
		m_b = FromBigInteger(BigInteger.ValueOf(7L));
		m_order = new BigInteger(1, Hex.Decode("0100000000000000000001B8FA16DFAB9ACA16B6B3"));
		m_cofactor = BigInteger.One;
		m_coord = 2;
	}

	protected override ECCurve CloneCurve()
	{
		return new SecP160K1Curve();
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
		return new SecP160R2FieldElement(x);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
	{
		return new SecP160K1Point(this, x, y, withCompression);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
	{
		return new SecP160K1Point(this, x, y, zs, withCompression);
	}

	public override ECLookupTable CreateCacheSafeLookupTable(ECPoint[] points, int off, int len)
	{
		uint[] array = new uint[len * 5 * 2];
		int num = 0;
		for (int i = 0; i < len; i++)
		{
			ECPoint eCPoint = points[off + i];
			Nat160.Copy(((SecP160R2FieldElement)eCPoint.RawXCoord).x, 0, array, num);
			num += 5;
			Nat160.Copy(((SecP160R2FieldElement)eCPoint.RawYCoord).x, 0, array, num);
			num += 5;
		}
		return new SecP160K1LookupTable(this, array, len);
	}
}
