using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecP128R1Curve : AbstractFpCurve
{
	private class SecP128R1LookupTable : AbstractECLookupTable
	{
		private readonly SecP128R1Curve m_outer;

		private readonly uint[] m_table;

		private readonly int m_size;

		public override int Size => m_size;

		internal SecP128R1LookupTable(SecP128R1Curve outer, uint[] table, int size)
		{
			m_outer = outer;
			m_table = table;
			m_size = size;
		}

		public override ECPoint Lookup(int index)
		{
			uint[] array = Nat128.Create();
			uint[] array2 = Nat128.Create();
			int num = 0;
			for (int i = 0; i < m_size; i++)
			{
				uint num2 = (uint)((i ^ index) - 1 >> 31);
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
			uint[] array = Nat128.Create();
			uint[] array2 = Nat128.Create();
			int num = index * 4 * 2;
			for (int i = 0; i < 4; i++)
			{
				array[i] = m_table[num + i];
				array2[i] = m_table[num + 4 + i];
			}
			return CreatePoint(array, array2);
		}

		private ECPoint CreatePoint(uint[] x, uint[] y)
		{
			return m_outer.CreateRawPoint(new SecP128R1FieldElement(x), new SecP128R1FieldElement(y), SECP128R1_AFFINE_ZS, withCompression: false);
		}
	}

	public static readonly BigInteger q = SecP128R1FieldElement.Q;

	private const int SECP128R1_DEFAULT_COORDS = 2;

	private const int SECP128R1_FE_INTS = 4;

	private static readonly ECFieldElement[] SECP128R1_AFFINE_ZS = new ECFieldElement[1]
	{
		new SecP128R1FieldElement(BigInteger.One)
	};

	protected readonly SecP128R1Point m_infinity;

	public virtual BigInteger Q => q;

	public override ECPoint Infinity => m_infinity;

	public override int FieldSize => q.BitLength;

	public SecP128R1Curve()
		: base(q)
	{
		m_infinity = new SecP128R1Point(this, null, null);
		m_a = FromBigInteger(new BigInteger(1, Hex.DecodeStrict("FFFFFFFDFFFFFFFFFFFFFFFFFFFFFFFC")));
		m_b = FromBigInteger(new BigInteger(1, Hex.DecodeStrict("E87579C11079F43DD824993C2CEE5ED3")));
		m_order = new BigInteger(1, Hex.DecodeStrict("FFFFFFFE0000000075A30D1B9038A115"));
		m_cofactor = BigInteger.One;
		m_coord = 2;
	}

	protected override ECCurve CloneCurve()
	{
		return new SecP128R1Curve();
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
		return new SecP128R1FieldElement(x);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
	{
		return new SecP128R1Point(this, x, y, withCompression);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
	{
		return new SecP128R1Point(this, x, y, zs, withCompression);
	}

	public override ECLookupTable CreateCacheSafeLookupTable(ECPoint[] points, int off, int len)
	{
		uint[] array = new uint[len * 4 * 2];
		int num = 0;
		for (int i = 0; i < len; i++)
		{
			ECPoint obj = points[off + i];
			Nat128.Copy(((SecP128R1FieldElement)obj.RawXCoord).x, 0, array, num);
			num += 4;
			Nat128.Copy(((SecP128R1FieldElement)obj.RawYCoord).x, 0, array, num);
			num += 4;
		}
		return new SecP128R1LookupTable(this, array, len);
	}

	public override ECFieldElement RandomFieldElement(SecureRandom r)
	{
		uint[] array = Nat128.Create();
		SecP128R1Field.Random(r, array);
		return new SecP128R1FieldElement(array);
	}

	public override ECFieldElement RandomFieldElementMult(SecureRandom r)
	{
		uint[] array = Nat128.Create();
		SecP128R1Field.RandomMult(r, array);
		return new SecP128R1FieldElement(array);
	}
}
