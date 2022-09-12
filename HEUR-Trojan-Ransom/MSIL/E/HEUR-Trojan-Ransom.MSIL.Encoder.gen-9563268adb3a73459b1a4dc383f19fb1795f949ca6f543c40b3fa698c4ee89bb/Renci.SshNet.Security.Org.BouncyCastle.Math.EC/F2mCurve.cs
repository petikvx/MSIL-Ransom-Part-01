using System;
using Renci.SshNet.Security.Org.BouncyCastle.Math.EC.Multiplier;

namespace Renci.SshNet.Security.Org.BouncyCastle.Math.EC;

internal class F2mCurve : AbstractF2mCurve
{
	private class DefaultF2mLookupTable : ECLookupTable
	{
		private readonly F2mCurve m_outer;

		private readonly long[] m_table;

		private readonly int m_size;

		public virtual int Size => m_size;

		internal DefaultF2mLookupTable(F2mCurve outer, long[] table, int size)
		{
			m_outer = outer;
			m_table = table;
			m_size = size;
		}

		public virtual ECPoint Lookup(int index)
		{
			int m = m_outer.m;
			int[] ks = ((!m_outer.IsTrinomial()) ? new int[3] { m_outer.k1, m_outer.k2, m_outer.k3 } : new int[1] { m_outer.k1 });
			int num = (m_outer.m + 63) / 64;
			long[] array = new long[num];
			long[] array2 = new long[num];
			int num2 = 0;
			for (int i = 0; i < m_size; i++)
			{
				long num3 = (i ^ index) - 1 >> 31;
				for (int j = 0; j < num; j++)
				{
					array[j] ^= m_table[num2 + j] & num3;
					array2[j] ^= m_table[num2 + num + j] & num3;
				}
				num2 += num * 2;
			}
			ECFieldElement x = new F2mFieldElement(m, ks, new LongArray(array));
			ECFieldElement y = new F2mFieldElement(m, ks, new LongArray(array2));
			return m_outer.CreateRawPoint(x, y, withCompression: false);
		}
	}

	private const int F2M_DEFAULT_COORDS = 6;

	private readonly int m;

	private readonly int k1;

	private readonly int k2;

	private readonly int k3;

	protected readonly F2mPoint m_infinity;

	public override int FieldSize => m;

	public override ECPoint Infinity => m_infinity;

	public int M => m;

	public int K1 => k1;

	public int K2 => k2;

	public int K3 => k3;

	[Obsolete("Use constructor taking order/cofactor")]
	public F2mCurve(int m, int k, BigInteger a, BigInteger b)
		: this(m, k, 0, 0, a, b, null, null)
	{
	}

	public F2mCurve(int m, int k, BigInteger a, BigInteger b, BigInteger order, BigInteger cofactor)
		: this(m, k, 0, 0, a, b, order, cofactor)
	{
	}

	[Obsolete("Use constructor taking order/cofactor")]
	public F2mCurve(int m, int k1, int k2, int k3, BigInteger a, BigInteger b)
		: this(m, k1, k2, k3, a, b, null, null)
	{
	}

	public F2mCurve(int m, int k1, int k2, int k3, BigInteger a, BigInteger b, BigInteger order, BigInteger cofactor)
		: base(m, k1, k2, k3)
	{
		this.m = m;
		this.k1 = k1;
		this.k2 = k2;
		this.k3 = k3;
		m_order = order;
		m_cofactor = cofactor;
		m_infinity = new F2mPoint(this, null, null, withCompression: false);
		if (k1 == 0)
		{
			throw new ArgumentException("k1 must be > 0");
		}
		if (k2 == 0)
		{
			if (k3 != 0)
			{
				throw new ArgumentException("k3 must be 0 if k2 == 0");
			}
		}
		else
		{
			if (k2 <= k1)
			{
				throw new ArgumentException("k2 must be > k1");
			}
			if (k3 <= k2)
			{
				throw new ArgumentException("k3 must be > k2");
			}
		}
		m_a = FromBigInteger(a);
		m_b = FromBigInteger(b);
		m_coord = 6;
	}

	protected F2mCurve(int m, int k1, int k2, int k3, ECFieldElement a, ECFieldElement b, BigInteger order, BigInteger cofactor)
		: base(m, k1, k2, k3)
	{
		this.m = m;
		this.k1 = k1;
		this.k2 = k2;
		this.k3 = k3;
		m_order = order;
		m_cofactor = cofactor;
		m_infinity = new F2mPoint(this, null, null, withCompression: false);
		m_a = a;
		m_b = b;
		m_coord = 6;
	}

	protected override ECCurve CloneCurve()
	{
		return new F2mCurve(m, k1, k2, k3, m_a, m_b, m_order, m_cofactor);
	}

	public override bool SupportsCoordinateSystem(int coord)
	{
		if ((uint)coord > 1u && coord != 6)
		{
			return false;
		}
		return true;
	}

	protected override ECMultiplier CreateDefaultMultiplier()
	{
		if (IsKoblitz)
		{
			return new WTauNafMultiplier();
		}
		return base.CreateDefaultMultiplier();
	}

	public override ECFieldElement FromBigInteger(BigInteger x)
	{
		return new F2mFieldElement(m, k1, k2, k3, x);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
	{
		return new F2mPoint(this, x, y, withCompression);
	}

	protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
	{
		return new F2mPoint(this, x, y, zs, withCompression);
	}

	public bool IsTrinomial()
	{
		if (k2 == 0)
		{
			return k3 == 0;
		}
		return false;
	}

	public override ECLookupTable CreateCacheSafeLookupTable(ECPoint[] points, int off, int len)
	{
		int num = (m + 63) / 64;
		long[] array = new long[len * num * 2];
		int num2 = 0;
		for (int i = 0; i < len; i++)
		{
			ECPoint obj = points[off + i];
			((F2mFieldElement)obj.RawXCoord).x.CopyTo(array, num2);
			num2 += num;
			((F2mFieldElement)obj.RawYCoord).x.CopyTo(array, num2);
			num2 += num;
		}
		return new DefaultF2mLookupTable(this, array, len);
	}
}
