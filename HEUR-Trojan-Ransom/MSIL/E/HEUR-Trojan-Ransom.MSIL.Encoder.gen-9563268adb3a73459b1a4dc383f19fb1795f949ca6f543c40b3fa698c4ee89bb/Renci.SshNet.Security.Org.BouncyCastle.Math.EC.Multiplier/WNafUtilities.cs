using System;
using Renci.SshNet.Security.Org.BouncyCastle.Utilities;

namespace Renci.SshNet.Security.Org.BouncyCastle.Math.EC.Multiplier;

internal abstract class WNafUtilities
{
	private class MapPointCallback : IPreCompCallback
	{
		private readonly WNafPreCompInfo m_wnafPreCompP;

		private readonly bool m_includeNegated;

		private readonly ECPointMap m_pointMap;

		internal MapPointCallback(WNafPreCompInfo wnafPreCompP, bool includeNegated, ECPointMap pointMap)
		{
			m_wnafPreCompP = wnafPreCompP;
			m_includeNegated = includeNegated;
			m_pointMap = pointMap;
		}

		public PreCompInfo Precompute(PreCompInfo existing)
		{
			WNafPreCompInfo wNafPreCompInfo = new WNafPreCompInfo();
			ECPoint twice = m_wnafPreCompP.Twice;
			if (twice != null)
			{
				ECPoint eCPoint2 = (wNafPreCompInfo.Twice = m_pointMap.Map(twice));
			}
			ECPoint[] preComp = m_wnafPreCompP.PreComp;
			ECPoint[] array = new ECPoint[preComp.Length];
			for (int i = 0; i < preComp.Length; i++)
			{
				array[i] = m_pointMap.Map(preComp[i]);
			}
			wNafPreCompInfo.PreComp = array;
			if (m_includeNegated)
			{
				ECPoint[] array2 = new ECPoint[array.Length];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = array[j].Negate();
				}
				wNafPreCompInfo.PreCompNeg = array2;
			}
			return wNafPreCompInfo;
		}
	}

	private class WNafCallback : IPreCompCallback
	{
		private readonly ECPoint m_p;

		private readonly int m_width;

		private readonly bool m_includeNegated;

		internal WNafCallback(ECPoint p, int width, bool includeNegated)
		{
			m_p = p;
			m_width = width;
			m_includeNegated = includeNegated;
		}

		public PreCompInfo Precompute(PreCompInfo existing)
		{
			WNafPreCompInfo wNafPreCompInfo = existing as WNafPreCompInfo;
			int num = 1 << System.Math.Max(0, m_width - 2);
			if (CheckExisting(wNafPreCompInfo, num, m_includeNegated))
			{
				return wNafPreCompInfo;
			}
			ECCurve curve = m_p.Curve;
			ECPoint[] array = null;
			ECPoint[] array2 = null;
			ECPoint eCPoint = null;
			if (wNafPreCompInfo != null)
			{
				array = wNafPreCompInfo.PreComp;
				array2 = wNafPreCompInfo.PreCompNeg;
				eCPoint = wNafPreCompInfo.Twice;
			}
			int num2 = 0;
			if (array == null)
			{
				array = EMPTY_POINTS;
			}
			else
			{
				num2 = array.Length;
			}
			if (num2 < num)
			{
				array = ResizeTable(array, num);
				if (num == 1)
				{
					array[0] = m_p.Normalize();
				}
				else
				{
					int num3 = num2;
					if (num3 == 0)
					{
						array[0] = m_p;
						num3 = 1;
					}
					ECFieldElement eCFieldElement = null;
					if (num == 2)
					{
						array[1] = m_p.ThreeTimes();
					}
					else
					{
						ECPoint eCPoint2 = eCPoint;
						ECPoint eCPoint3 = array[num3 - 1];
						if (eCPoint2 == null)
						{
							eCPoint2 = array[0].Twice();
							eCPoint = eCPoint2;
							if (!eCPoint.IsInfinity && ECAlgorithms.IsFpCurve(curve) && curve.FieldSize >= 64)
							{
								int coordinateSystem = curve.CoordinateSystem;
								if ((uint)(coordinateSystem - 2) <= 2u)
								{
									eCFieldElement = eCPoint.GetZCoord(0);
									eCPoint2 = curve.CreatePoint(eCPoint.XCoord.ToBigInteger(), eCPoint.YCoord.ToBigInteger());
									ECFieldElement eCFieldElement2 = eCFieldElement.Square();
									ECFieldElement scale = eCFieldElement2.Multiply(eCFieldElement);
									eCPoint3 = eCPoint3.ScaleX(eCFieldElement2).ScaleY(scale);
									if (num2 == 0)
									{
										array[0] = eCPoint3;
									}
								}
							}
						}
						while (num3 < num)
						{
							eCPoint3 = (array[num3++] = eCPoint3.Add(eCPoint2));
						}
					}
					curve.NormalizeAll(array, num2, num - num2, eCFieldElement);
				}
			}
			if (m_includeNegated)
			{
				int i;
				if (array2 == null)
				{
					i = 0;
					array2 = new ECPoint[num];
				}
				else
				{
					i = array2.Length;
					if (i < num)
					{
						array2 = ResizeTable(array2, num);
					}
				}
				for (; i < num; i++)
				{
					array2[i] = array[i].Negate();
				}
			}
			return new WNafPreCompInfo
			{
				PreComp = array,
				PreCompNeg = array2,
				Twice = eCPoint
			};
		}

		private bool CheckExisting(WNafPreCompInfo existingWNaf, int reqPreCompLen, bool includeNegated)
		{
			if (existingWNaf != null && CheckTable(existingWNaf.PreComp, reqPreCompLen))
			{
				if (includeNegated)
				{
					return CheckTable(existingWNaf.PreCompNeg, reqPreCompLen);
				}
				return true;
			}
			return false;
		}

		private bool CheckTable(ECPoint[] table, int reqLen)
		{
			if (table != null)
			{
				return table.Length >= reqLen;
			}
			return false;
		}
	}

	public static readonly string PRECOMP_NAME = "bc_wnaf";

	private static readonly int[] DEFAULT_WINDOW_SIZE_CUTOFFS = new int[6] { 13, 41, 121, 337, 897, 2305 };

	private static readonly ECPoint[] EMPTY_POINTS = new ECPoint[0];

	public static int[] GenerateCompactNaf(BigInteger k)
	{
		if (k.BitLength >> 16 != 0)
		{
			throw new ArgumentException("must have bitlength < 2^16", "k");
		}
		if (k.SignValue == 0)
		{
			return Arrays.EmptyInts;
		}
		BigInteger bigInteger = k.ShiftLeft(1).Add(k);
		int bitLength = bigInteger.BitLength;
		int[] array = new int[bitLength >> 1];
		BigInteger bigInteger2 = bigInteger.Xor(k);
		int num = bitLength - 1;
		int num2 = 0;
		int num3 = 0;
		for (int i = 1; i < num; i++)
		{
			if (!bigInteger2.TestBit(i))
			{
				num3++;
				continue;
			}
			int num4 = ((!k.TestBit(i)) ? 1 : (-1));
			array[num2++] = (num4 << 16) | num3;
			num3 = 1;
			i++;
		}
		array[num2++] = 0x10000 | num3;
		if (array.Length > num2)
		{
			array = Trim(array, num2);
		}
		return array;
	}

	public static int[] GenerateCompactWindowNaf(int width, BigInteger k)
	{
		switch (width)
		{
		case 2:
			return GenerateCompactNaf(k);
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
		case 9:
		case 10:
		case 11:
		case 12:
		case 13:
		case 14:
		case 15:
		case 16:
		{
			if (k.BitLength >> 16 != 0)
			{
				throw new ArgumentException("must have bitlength < 2^16", "k");
			}
			if (k.SignValue == 0)
			{
				return Arrays.EmptyInts;
			}
			int[] array = new int[k.BitLength / width + 1];
			int num = 1 << width;
			int num2 = num - 1;
			int num3 = num >> 1;
			bool flag = false;
			int num4 = 0;
			int num5 = 0;
			while (num5 <= k.BitLength)
			{
				if (k.TestBit(num5) == flag)
				{
					num5++;
					continue;
				}
				k = k.ShiftRight(num5);
				int num6 = k.IntValue & num2;
				if (flag)
				{
					num6++;
				}
				if (flag = (num6 & num3) != 0)
				{
					num6 -= num;
				}
				int num7 = ((num4 > 0) ? (num5 - 1) : num5);
				array[num4++] = (num6 << 16) | num7;
				num5 = width;
			}
			if (array.Length > num4)
			{
				array = Trim(array, num4);
			}
			return array;
		}
		default:
			throw new ArgumentException("must be in the range [2, 16]", "width");
		}
	}

	public static byte[] GenerateJsf(BigInteger g, BigInteger h)
	{
		byte[] array = new byte[System.Math.Max(g.BitLength, h.BitLength) + 1];
		BigInteger bigInteger = g;
		BigInteger bigInteger2 = h;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		while ((num2 | num3) != 0 || bigInteger.BitLength > num4 || bigInteger2.BitLength > num4)
		{
			int num5 = ((int)((uint)bigInteger.IntValue >> num4) + num2) & 7;
			int num6 = ((int)((uint)bigInteger2.IntValue >> num4) + num3) & 7;
			int num7 = num5 & 1;
			if (num7 != 0)
			{
				num7 -= num5 & 2;
				if (num5 + num7 == 4 && (num6 & 3) == 2)
				{
					num7 = -num7;
				}
			}
			int num8 = num6 & 1;
			if (num8 != 0)
			{
				num8 -= num6 & 2;
				if (num6 + num8 == 4 && (num5 & 3) == 2)
				{
					num8 = -num8;
				}
			}
			if (num2 << 1 == 1 + num7)
			{
				num2 ^= 1;
			}
			if (num3 << 1 == 1 + num8)
			{
				num3 ^= 1;
			}
			if (++num4 == 30)
			{
				num4 = 0;
				bigInteger = bigInteger.ShiftRight(30);
				bigInteger2 = bigInteger2.ShiftRight(30);
			}
			array[num++] = (byte)((uint)(num7 << 4) | ((uint)num8 & 0xFu));
		}
		if (array.Length > num)
		{
			array = Trim(array, num);
		}
		return array;
	}

	public static byte[] GenerateNaf(BigInteger k)
	{
		if (k.SignValue == 0)
		{
			return Arrays.EmptyBytes;
		}
		BigInteger bigInteger = k.ShiftLeft(1).Add(k);
		int num = bigInteger.BitLength - 1;
		byte[] array = new byte[num];
		BigInteger bigInteger2 = bigInteger.Xor(k);
		for (int i = 1; i < num; i++)
		{
			if (bigInteger2.TestBit(i))
			{
				array[i - 1] = (byte)((!k.TestBit(i)) ? 1u : uint.MaxValue);
				i++;
			}
		}
		array[num - 1] = 1;
		return array;
	}

	public static byte[] GenerateWindowNaf(int width, BigInteger k)
	{
		switch (width)
		{
		case 2:
			return GenerateNaf(k);
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
		{
			if (k.SignValue == 0)
			{
				return Arrays.EmptyBytes;
			}
			byte[] array = new byte[k.BitLength + 1];
			int num = 1 << width;
			int num2 = num - 1;
			int num3 = num >> 1;
			bool flag = false;
			int num4 = 0;
			int num5 = 0;
			while (num5 <= k.BitLength)
			{
				if (k.TestBit(num5) == flag)
				{
					num5++;
					continue;
				}
				k = k.ShiftRight(num5);
				int num6 = k.IntValue & num2;
				if (flag)
				{
					num6++;
				}
				if (flag = (num6 & num3) != 0)
				{
					num6 -= num;
				}
				num4 += ((num4 > 0) ? (num5 - 1) : num5);
				array[num4++] = (byte)num6;
				num5 = width;
			}
			if (array.Length > num4)
			{
				array = Trim(array, num4);
			}
			return array;
		}
		default:
			throw new ArgumentException("must be in the range [2, 8]", "width");
		}
	}

	public static int GetNafWeight(BigInteger k)
	{
		if (k.SignValue == 0)
		{
			return 0;
		}
		return k.ShiftLeft(1).Add(k).Xor(k)
			.BitCount;
	}

	public static WNafPreCompInfo GetWNafPreCompInfo(ECPoint p)
	{
		return GetWNafPreCompInfo(p.Curve.GetPreCompInfo(p, PRECOMP_NAME));
	}

	public static WNafPreCompInfo GetWNafPreCompInfo(PreCompInfo preCompInfo)
	{
		return preCompInfo as WNafPreCompInfo;
	}

	public static int GetWindowSize(int bits)
	{
		return GetWindowSize(bits, DEFAULT_WINDOW_SIZE_CUTOFFS);
	}

	public static int GetWindowSize(int bits, int[] windowSizeCutoffs)
	{
		int i;
		for (i = 0; i < windowSizeCutoffs.Length && bits >= windowSizeCutoffs[i]; i++)
		{
		}
		return i + 2;
	}

	public static ECPoint MapPointWithPrecomp(ECPoint p, int width, bool includeNegated, ECPointMap pointMap)
	{
		ECCurve curve = p.Curve;
		WNafPreCompInfo wnafPreCompP = Precompute(p, width, includeNegated);
		ECPoint eCPoint = pointMap.Map(p);
		curve.Precompute(eCPoint, PRECOMP_NAME, new MapPointCallback(wnafPreCompP, includeNegated, pointMap));
		return eCPoint;
	}

	public static WNafPreCompInfo Precompute(ECPoint p, int width, bool includeNegated)
	{
		return (WNafPreCompInfo)p.Curve.Precompute(p, PRECOMP_NAME, new WNafCallback(p, width, includeNegated));
	}

	private static byte[] Trim(byte[] a, int length)
	{
		byte[] array = new byte[length];
		Array.Copy(a, 0, array, 0, array.Length);
		return array;
	}

	private static int[] Trim(int[] a, int length)
	{
		int[] array = new int[length];
		Array.Copy(a, 0, array, 0, array.Length);
		return array;
	}

	private static ECPoint[] ResizeTable(ECPoint[] a, int length)
	{
		ECPoint[] array = new ECPoint[length];
		Array.Copy(a, 0, array, 0, a.Length);
		return array;
	}
}
