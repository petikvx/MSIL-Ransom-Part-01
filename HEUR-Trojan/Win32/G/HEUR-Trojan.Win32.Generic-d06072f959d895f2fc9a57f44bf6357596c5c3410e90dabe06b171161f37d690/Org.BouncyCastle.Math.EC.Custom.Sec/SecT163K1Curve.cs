using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecT163K1Curve : AbstractF2mCurve
{
	private class SecT163K1LookupTable : AbstractECLookupTable
	{
		private readonly SecT163K1Curve m_outer;

		private readonly ulong[] m_table;

		private readonly int m_size;

		public override int Size => m_size;

		internal SecT163K1LookupTable(SecT163K1Curve outer, ulong[] table, int size)
		{
			m_outer = outer;
			m_table = table;
			m_size = size;
		}

		public override ECPoint Lookup(int index)
		{
			ulong[] array = Nat192.Create64();
			ulong[] array2 = Nat192.Create64();
			int num = 0;
			for (int i = 0; i < m_size; i++)
			{
				ulong num2 = (ulong)((i ^ index) - 1 >> 31);
				for (int j = 0; j < 3; j++)
				{
					array[j] ^= m_table[num + j] & num2;
					array2[j] ^= m_table[num + 3 + j] & num2;
				}
				num += 6;
			}
			return CreatePoint(array, array2);
		}

		public override ECPoint LookupVar(int index)
		{
			ulong[] array = Nat192.Create64();
			ulong[] array2 = Nat192.Create64();
			int num = index * 3 * 2;
			for (int i = 0; i < 3; i++)
			{
				array[i] = m_table[num + i];
				array2[i] = m_table[num + 3 + i];
			}
			return CreatePoint(array, array2);
		}

		private ECPoint CreatePoint(ulong[] x, ulong[] y)
		{
			return m_outer.CreateRawPoint(new SecT163FieldElement(x), new SecT163FieldElement(y), SECT163K1_AFFINE_ZS, withCompression: false);
		}
	}

	private const int SECT163K1_DEFAULT_COORDS = 6;

	private const int SECT163K1_FE_LONGS = 3;

	private static readonly ECFieldElement[] SECT163K1_AFFINE_ZS = new ECFieldElement[1]
	{
		new SecT163FieldElement(BigInteger.One)
	};

	protected readonly SecT163K1Point m_infinity;

	public override ECPoint Infinity => m_infinity;

	public override int FieldSize => 163;

	public override bool IsKoblitz => true;

	public virtual int M => 163;

	public virtual bool IsTrinomial => false;

	public virtual int K1 => 3;

	public virtual int K2 => 6;

	public virtual int K3 => 7;

	public SecT163K1Curve()
		: base(163, 3, 6, 7)
	{
		m_infinity = new SecT163K1Point(this, null, null);
		m_a = FromBigInteger(BigInteger.One);
		m_b = m_a;
		m_order = new BigInteger(1, Hex.DecodeStrict("04000000000000000000020108A2E0CC0D99F8A5EF"));
		m_cofactor = BigInteger.Two;
		m_coord = 6;
	}

	protected override ECCurve CloneCurve()
	{
		return new SecT163K1Curve();
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
		return new SecT163FieldElement(x);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
	{
		return new SecT163K1Point(this, x, y, withCompression);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
	{
		return new SecT163K1Point(this, x, y, zs, withCompression);
	}

	public override ECLookupTable CreateCacheSafeLookupTable(ECPoint[] points, int off, int len)
	{
		ulong[] array = new ulong[len * 3 * 2];
		int num = 0;
		for (int i = 0; i < len; i++)
		{
			ECPoint obj = points[off + i];
			Nat192.Copy64(((SecT163FieldElement)obj.RawXCoord).x, 0, array, num);
			num += 3;
			Nat192.Copy64(((SecT163FieldElement)obj.RawYCoord).x, 0, array, num);
			num += 3;
		}
		return new SecT163K1LookupTable(this, array, len);
	}
}
