using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.GM;

internal class SM2P256V1Curve : AbstractFpCurve
{
	private class SM2P256V1LookupTable : ECLookupTable
	{
		private readonly SM2P256V1Curve m_outer;

		private readonly uint[] m_table;

		private readonly int m_size;

		public virtual int Size => m_size;

		internal SM2P256V1LookupTable(SM2P256V1Curve outer, uint[] table, int size)
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
				for (int j = 0; j < 8; j++)
				{
					uint[] array3;
					uint[] array4 = (array3 = array);
					int num3 = j;
					nint num4 = num3;
					array4[num3] = array3[num4] ^ (m_table[num + j] & num2);
					uint[] array5 = (array3 = array2);
					int num5 = j;
					num4 = num5;
					array5[num5] = array3[num4] ^ (m_table[num + 8 + j] & num2);
				}
				num += 16;
			}
			return m_outer.CreateRawPoint(new SM2P256V1FieldElement(array), new SM2P256V1FieldElement(array2), withCompression: false);
		}
	}

	private const int SM2P256V1_DEFAULT_COORDS = 2;

	private const int SM2P256V1_FE_INTS = 8;

	public static readonly BigInteger q = new BigInteger(1, Hex.Decode("FFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF00000000FFFFFFFFFFFFFFFF"));

	protected readonly SM2P256V1Point m_infinity;

	public virtual BigInteger Q => q;

	public override ECPoint Infinity => m_infinity;

	public override int FieldSize => q.BitLength;

	public SM2P256V1Curve()
		: base(q)
	{
		m_infinity = new SM2P256V1Point(this, null, null);
		m_a = FromBigInteger(new BigInteger(1, Hex.Decode("FFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF00000000FFFFFFFFFFFFFFFC")));
		m_b = FromBigInteger(new BigInteger(1, Hex.Decode("28E9FA9E9D9F5E344D5A9E4BCF6509A7F39789F515AB8F92DDBCBD414D940E93")));
		m_order = new BigInteger(1, Hex.Decode("FFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFF7203DF6B21C6052B53BBF40939D54123"));
		m_cofactor = BigInteger.One;
		m_coord = 2;
	}

	protected override ECCurve CloneCurve()
	{
		return new SM2P256V1Curve();
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
		return new SM2P256V1FieldElement(x);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
	{
		return new SM2P256V1Point(this, x, y, withCompression);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
	{
		return new SM2P256V1Point(this, x, y, zs, withCompression);
	}

	public override ECLookupTable CreateCacheSafeLookupTable(ECPoint[] points, int off, int len)
	{
		uint[] array = new uint[len * 8 * 2];
		int num = 0;
		for (int i = 0; i < len; i++)
		{
			ECPoint eCPoint = points[off + i];
			Nat256.Copy(((SM2P256V1FieldElement)eCPoint.RawXCoord).x, 0, array, num);
			num += 8;
			Nat256.Copy(((SM2P256V1FieldElement)eCPoint.RawYCoord).x, 0, array, num);
			num += 8;
		}
		return new SM2P256V1LookupTable(this, array, len);
	}
}
