using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecT193R1Curve : AbstractF2mCurve
{
	private class SecT193R1LookupTable : AbstractECLookupTable
	{
		private readonly SecT193R1Curve m_outer;

		private readonly ulong[] m_table;

		private readonly int m_size;

		public override int Size => m_size;

		internal SecT193R1LookupTable(SecT193R1Curve outer, ulong[] table, int size)
		{
			m_outer = outer;
			m_table = table;
			m_size = size;
		}

		public override ECPoint Lookup(int index)
		{
			ulong[] array = Nat256.Create64();
			ulong[] array2 = Nat256.Create64();
			int num = 0;
			for (int i = 0; i < m_size; i++)
			{
				ulong num2 = (ulong)((i ^ index) - 1 >> 31);
				for (int j = 0; j < 4; j++)
				{
					array[j] ^= m_table[num + j] & num2;
					array2[j] ^= m_table[num + 4 + j] & num2;
				}
				num += 8;
			}
			return CreatePoint(array, array2);
		}

		public override ECPoint LookupVar(int index)
		{
			ulong[] array = Nat256.Create64();
			ulong[] array2 = Nat256.Create64();
			int num = index * 4 * 2;
			for (int i = 0; i < 4; i++)
			{
				array[i] = m_table[num + i];
				array2[i] = m_table[num + 4 + i];
			}
			return CreatePoint(array, array2);
		}

		private ECPoint CreatePoint(ulong[] x, ulong[] y)
		{
			return m_outer.CreateRawPoint(new SecT193FieldElement(x), new SecT193FieldElement(y), SECT193R1_AFFINE_ZS, withCompression: false);
		}
	}

	private const int SECT193R1_DEFAULT_COORDS = 6;

	private const int SECT193R1_FE_LONGS = 4;

	private static readonly ECFieldElement[] SECT193R1_AFFINE_ZS = new ECFieldElement[1]
	{
		new SecT193FieldElement(BigInteger.One)
	};

	protected readonly SecT193R1Point m_infinity;

	public override ECPoint Infinity => m_infinity;

	public override int FieldSize => 193;

	public override bool IsKoblitz => false;

	public virtual int M => 193;

	public virtual bool IsTrinomial => true;

	public virtual int K1 => 15;

	public virtual int K2 => 0;

	public virtual int K3 => 0;

	public SecT193R1Curve()
		: base(193, 15, 0, 0)
	{
		m_infinity = new SecT193R1Point(this, null, null);
		m_a = FromBigInteger(new BigInteger(1, Hex.DecodeStrict("0017858FEB7A98975169E171F77B4087DE098AC8A911DF7B01")));
		m_b = FromBigInteger(new BigInteger(1, Hex.DecodeStrict("00FDFB49BFE6C3A89FACADAA7A1E5BBC7CC1C2E5D831478814")));
		m_order = new BigInteger(1, Hex.DecodeStrict("01000000000000000000000000C7F34A778F443ACC920EBA49"));
		m_cofactor = BigInteger.Two;
		m_coord = 6;
	}

	protected override ECCurve CloneCurve()
	{
		return new SecT193R1Curve();
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
		return new SecT193FieldElement(x);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
	{
		return new SecT193R1Point(this, x, y, withCompression);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
	{
		return new SecT193R1Point(this, x, y, zs, withCompression);
	}

	public override ECLookupTable CreateCacheSafeLookupTable(ECPoint[] points, int off, int len)
	{
		ulong[] array = new ulong[len * 4 * 2];
		int num = 0;
		for (int i = 0; i < len; i++)
		{
			ECPoint obj = points[off + i];
			Nat256.Copy64(((SecT193FieldElement)obj.RawXCoord).x, 0, array, num);
			num += 4;
			Nat256.Copy64(((SecT193FieldElement)obj.RawYCoord).x, 0, array, num);
			num += 4;
		}
		return new SecT193R1LookupTable(this, array, len);
	}
}
