using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecT113R1Curve : AbstractF2mCurve
{
	private class SecT113R1LookupTable : AbstractECLookupTable
	{
		private readonly SecT113R1Curve m_outer;

		private readonly ulong[] m_table;

		private readonly int m_size;

		public override int Size => m_size;

		internal SecT113R1LookupTable(SecT113R1Curve outer, ulong[] table, int size)
		{
			m_outer = outer;
			m_table = table;
			m_size = size;
		}

		public override ECPoint Lookup(int index)
		{
			ulong[] array = Nat128.Create64();
			ulong[] array2 = Nat128.Create64();
			int num = 0;
			for (int i = 0; i < m_size; i++)
			{
				ulong num2 = (ulong)((i ^ index) - 1 >> 31);
				for (int j = 0; j < 2; j++)
				{
					array[j] ^= m_table[num + j] & num2;
					array2[j] ^= m_table[num + 2 + j] & num2;
				}
				num += 4;
			}
			return CreatePoint(array, array2);
		}

		public override ECPoint LookupVar(int index)
		{
			ulong[] array = Nat128.Create64();
			ulong[] array2 = Nat128.Create64();
			int num = index * 2 * 2;
			for (int i = 0; i < 2; i++)
			{
				array[i] = m_table[num + i];
				array2[i] = m_table[num + 2 + i];
			}
			return CreatePoint(array, array2);
		}

		private ECPoint CreatePoint(ulong[] x, ulong[] y)
		{
			return m_outer.CreateRawPoint(new SecT113FieldElement(x), new SecT113FieldElement(y), SECT113R1_AFFINE_ZS, withCompression: false);
		}
	}

	private const int SECT113R1_DEFAULT_COORDS = 6;

	private const int SECT113R1_FE_LONGS = 2;

	private static readonly ECFieldElement[] SECT113R1_AFFINE_ZS = new ECFieldElement[1]
	{
		new SecT113FieldElement(BigInteger.One)
	};

	protected readonly SecT113R1Point m_infinity;

	public override ECPoint Infinity => m_infinity;

	public override int FieldSize => 113;

	public override bool IsKoblitz => false;

	public virtual int M => 113;

	public virtual bool IsTrinomial => true;

	public virtual int K1 => 9;

	public virtual int K2 => 0;

	public virtual int K3 => 0;

	public SecT113R1Curve()
		: base(113, 9, 0, 0)
	{
		m_infinity = new SecT113R1Point(this, null, null);
		m_a = FromBigInteger(new BigInteger(1, Hex.DecodeStrict("003088250CA6E7C7FE649CE85820F7")));
		m_b = FromBigInteger(new BigInteger(1, Hex.DecodeStrict("00E8BEE4D3E2260744188BE0E9C723")));
		m_order = new BigInteger(1, Hex.DecodeStrict("0100000000000000D9CCEC8A39E56F"));
		m_cofactor = BigInteger.Two;
		m_coord = 6;
	}

	protected override ECCurve CloneCurve()
	{
		return new SecT113R1Curve();
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
		return new SecT113FieldElement(x);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
	{
		return new SecT113R1Point(this, x, y, withCompression);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
	{
		return new SecT113R1Point(this, x, y, zs, withCompression);
	}

	public override ECLookupTable CreateCacheSafeLookupTable(ECPoint[] points, int off, int len)
	{
		ulong[] array = new ulong[len * 2 * 2];
		int num = 0;
		for (int i = 0; i < len; i++)
		{
			ECPoint obj = points[off + i];
			Nat128.Copy64(((SecT113FieldElement)obj.RawXCoord).x, 0, array, num);
			num += 2;
			Nat128.Copy64(((SecT113FieldElement)obj.RawYCoord).x, 0, array, num);
			num += 2;
		}
		return new SecT113R1LookupTable(this, array, len);
	}
}
