using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Djb;

internal class Curve25519 : AbstractFpCurve
{
	private class Curve25519LookupTable : ECLookupTable
	{
		private readonly Curve25519 m_outer;

		private readonly uint[] m_table;

		private readonly int m_size;

		public virtual int Size => m_size;

		internal Curve25519LookupTable(Curve25519 outer, uint[] table, int size)
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
			return m_outer.CreateRawPoint(new Curve25519FieldElement(array), new Curve25519FieldElement(array2), withCompression: false);
		}
	}

	private const int Curve25519_DEFAULT_COORDS = 4;

	private const int CURVE25519_FE_INTS = 8;

	public static readonly BigInteger q = Nat256.ToBigInteger(Curve25519Field.P);

	protected readonly Curve25519Point m_infinity;

	public virtual BigInteger Q => q;

	public override ECPoint Infinity => m_infinity;

	public override int FieldSize => q.BitLength;

	public Curve25519()
		: base(q)
	{
		m_infinity = new Curve25519Point(this, null, null);
		m_a = FromBigInteger(new BigInteger(1, Hex.Decode("2AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA984914A144")));
		m_b = FromBigInteger(new BigInteger(1, Hex.Decode("7B425ED097B425ED097B425ED097B425ED097B425ED097B4260B5E9C7710C864")));
		m_order = new BigInteger(1, Hex.Decode("1000000000000000000000000000000014DEF9DEA2F79CD65812631A5CF5D3ED"));
		m_cofactor = BigInteger.ValueOf(8L);
		m_coord = 4;
	}

	protected override ECCurve CloneCurve()
	{
		return new Curve25519();
	}

	public override bool SupportsCoordinateSystem(int coord)
	{
		if (coord == 4)
		{
			return true;
		}
		return false;
	}

	public override ECFieldElement FromBigInteger(BigInteger x)
	{
		return new Curve25519FieldElement(x);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
	{
		return new Curve25519Point(this, x, y, withCompression);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
	{
		return new Curve25519Point(this, x, y, zs, withCompression);
	}

	public override ECLookupTable CreateCacheSafeLookupTable(ECPoint[] points, int off, int len)
	{
		uint[] array = new uint[len * 8 * 2];
		int num = 0;
		for (int i = 0; i < len; i++)
		{
			ECPoint eCPoint = points[off + i];
			Nat256.Copy(((Curve25519FieldElement)eCPoint.RawXCoord).x, 0, array, num);
			num += 8;
			Nat256.Copy(((Curve25519FieldElement)eCPoint.RawYCoord).x, 0, array, num);
			num += 8;
		}
		return new Curve25519LookupTable(this, array, len);
	}
}
