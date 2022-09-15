using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecP192R1Curve : AbstractFpCurve
{
	private class SecP192R1LookupTable : AbstractECLookupTable
	{
		private readonly SecP192R1Curve m_outer;

		private readonly uint[] m_table;

		private readonly int m_size;

		public override int Size => m_size;

		internal SecP192R1LookupTable(SecP192R1Curve outer, uint[] table, int size)
		{
			m_outer = outer;
			m_table = table;
			m_size = size;
		}

		public override ECPoint Lookup(int index)
		{
			uint[] array = Nat192.Create();
			uint[] array2 = Nat192.Create();
			int num = 0;
			for (int i = 0; i < m_size; i++)
			{
				uint num2 = (uint)((i ^ index) - 1 >> 31);
				for (int j = 0; j < 6; j++)
				{
					array[j] ^= m_table[num + j] & num2;
					array2[j] ^= m_table[num + 6 + j] & num2;
				}
				num += 12;
			}
			return CreatePoint(array, array2);
		}

		public override ECPoint LookupVar(int index)
		{
			uint[] array = Nat192.Create();
			uint[] array2 = Nat192.Create();
			int num = index * 6 * 2;
			for (int i = 0; i < 6; i++)
			{
				array[i] = m_table[num + i];
				array2[i] = m_table[num + 6 + i];
			}
			return CreatePoint(array, array2);
		}

		private ECPoint CreatePoint(uint[] x, uint[] y)
		{
			return m_outer.CreateRawPoint(new SecP192R1FieldElement(x), new SecP192R1FieldElement(y), SECP192R1_AFFINE_ZS, withCompression: false);
		}
	}

	public static readonly BigInteger q = SecP192R1FieldElement.Q;

	private const int SECP192R1_DEFAULT_COORDS = 2;

	private const int SECP192R1_FE_INTS = 6;

	private static readonly ECFieldElement[] SECP192R1_AFFINE_ZS = new ECFieldElement[1]
	{
		new SecP192R1FieldElement(BigInteger.One)
	};

	protected readonly SecP192R1Point m_infinity;

	public virtual BigInteger Q => q;

	public override ECPoint Infinity => m_infinity;

	public override int FieldSize => q.BitLength;

	public SecP192R1Curve()
		: base(q)
	{
		m_infinity = new SecP192R1Point(this, null, null);
		m_a = FromBigInteger(new BigInteger(1, Hex.DecodeStrict("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFC")));
		m_b = FromBigInteger(new BigInteger(1, Hex.DecodeStrict("64210519E59C80E70FA7E9AB72243049FEB8DEECC146B9B1")));
		m_order = new BigInteger(1, Hex.DecodeStrict("FFFFFFFFFFFFFFFFFFFFFFFF99DEF836146BC9B1B4D22831"));
		m_cofactor = BigInteger.One;
		m_coord = 2;
	}

	protected override ECCurve CloneCurve()
	{
		return new SecP192R1Curve();
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
		return new SecP192R1FieldElement(x);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
	{
		return new SecP192R1Point(this, x, y, withCompression);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
	{
		return new SecP192R1Point(this, x, y, zs, withCompression);
	}

	public override ECLookupTable CreateCacheSafeLookupTable(ECPoint[] points, int off, int len)
	{
		uint[] array = new uint[len * 6 * 2];
		int num = 0;
		for (int i = 0; i < len; i++)
		{
			ECPoint obj = points[off + i];
			Nat192.Copy(((SecP192R1FieldElement)obj.RawXCoord).x, 0, array, num);
			num += 6;
			Nat192.Copy(((SecP192R1FieldElement)obj.RawYCoord).x, 0, array, num);
			num += 6;
		}
		return new SecP192R1LookupTable(this, array, len);
	}

	public override ECFieldElement RandomFieldElement(SecureRandom r)
	{
		uint[] array = Nat192.Create();
		SecP192R1Field.Random(r, array);
		return new SecP192R1FieldElement(array);
	}

	public override ECFieldElement RandomFieldElementMult(SecureRandom r)
	{
		uint[] array = Nat192.Create();
		SecP192R1Field.RandomMult(r, array);
		return new SecP192R1FieldElement(array);
	}
}
