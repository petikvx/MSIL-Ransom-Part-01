using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecP224K1Curve : AbstractFpCurve
{
	private class SecP224K1LookupTable : AbstractECLookupTable
	{
		private readonly SecP224K1Curve m_outer;

		private readonly uint[] m_table;

		private readonly int m_size;

		public override int Size => m_size;

		internal SecP224K1LookupTable(SecP224K1Curve outer, uint[] table, int size)
		{
			m_outer = outer;
			m_table = table;
			m_size = size;
		}

		public override ECPoint Lookup(int index)
		{
			uint[] array = Nat224.Create();
			uint[] array2 = Nat224.Create();
			int num = 0;
			for (int i = 0; i < m_size; i++)
			{
				uint num2 = (uint)((i ^ index) - 1 >> 31);
				for (int j = 0; j < 7; j++)
				{
					array[j] ^= m_table[num + j] & num2;
					array2[j] ^= m_table[num + 7 + j] & num2;
				}
				num += 14;
			}
			return CreatePoint(array, array2);
		}

		public override ECPoint LookupVar(int index)
		{
			uint[] array = Nat224.Create();
			uint[] array2 = Nat224.Create();
			int num = index * 7 * 2;
			for (int i = 0; i < 7; i++)
			{
				array[i] = m_table[num + i];
				array2[i] = m_table[num + 7 + i];
			}
			return CreatePoint(array, array2);
		}

		private ECPoint CreatePoint(uint[] x, uint[] y)
		{
			return m_outer.CreateRawPoint(new SecP224K1FieldElement(x), new SecP224K1FieldElement(y), SECP224K1_AFFINE_ZS, withCompression: false);
		}
	}

	public static readonly BigInteger q = SecP224K1FieldElement.Q;

	private const int SECP224K1_DEFAULT_COORDS = 2;

	private const int SECP224K1_FE_INTS = 7;

	private static readonly ECFieldElement[] SECP224K1_AFFINE_ZS = new ECFieldElement[1]
	{
		new SecP224K1FieldElement(BigInteger.One)
	};

	protected readonly SecP224K1Point m_infinity;

	public virtual BigInteger Q => q;

	public override ECPoint Infinity => m_infinity;

	public override int FieldSize => q.BitLength;

	public SecP224K1Curve()
		: base(q)
	{
		m_infinity = new SecP224K1Point(this, null, null);
		m_a = FromBigInteger(BigInteger.Zero);
		m_b = FromBigInteger(BigInteger.ValueOf(5L));
		m_order = new BigInteger(1, Hex.DecodeStrict("010000000000000000000000000001DCE8D2EC6184CAF0A971769FB1F7"));
		m_cofactor = BigInteger.One;
		m_coord = 2;
	}

	protected override ECCurve CloneCurve()
	{
		return new SecP224K1Curve();
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
		return new SecP224K1FieldElement(x);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
	{
		return new SecP224K1Point(this, x, y, withCompression);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
	{
		return new SecP224K1Point(this, x, y, zs, withCompression);
	}

	public override ECLookupTable CreateCacheSafeLookupTable(ECPoint[] points, int off, int len)
	{
		uint[] array = new uint[len * 7 * 2];
		int num = 0;
		for (int i = 0; i < len; i++)
		{
			ECPoint obj = points[off + i];
			Nat224.Copy(((SecP224K1FieldElement)obj.RawXCoord).x, 0, array, num);
			num += 7;
			Nat224.Copy(((SecP224K1FieldElement)obj.RawYCoord).x, 0, array, num);
			num += 7;
		}
		return new SecP224K1LookupTable(this, array, len);
	}

	public override ECFieldElement RandomFieldElement(SecureRandom r)
	{
		uint[] array = Nat224.Create();
		SecP224K1Field.Random(r, array);
		return new SecP224K1FieldElement(array);
	}

	public override ECFieldElement RandomFieldElementMult(SecureRandom r)
	{
		uint[] array = Nat224.Create();
		SecP224K1Field.RandomMult(r, array);
		return new SecP224K1FieldElement(array);
	}
}
