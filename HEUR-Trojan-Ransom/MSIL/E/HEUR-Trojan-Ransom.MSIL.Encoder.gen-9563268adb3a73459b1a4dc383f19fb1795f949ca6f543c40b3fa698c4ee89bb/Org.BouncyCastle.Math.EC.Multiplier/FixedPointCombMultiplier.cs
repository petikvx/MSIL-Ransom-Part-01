using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Multiplier;

public class FixedPointCombMultiplier : AbstractECMultiplier
{
	protected override ECPoint MultiplyPositive(ECPoint p, BigInteger k)
	{
		ECCurve curve = p.Curve;
		int combSize = FixedPointUtilities.GetCombSize(curve);
		if (k.BitLength > combSize)
		{
			throw new InvalidOperationException("fixed-point comb doesn't support scalars larger than the curve order");
		}
		FixedPointPreCompInfo fixedPointPreCompInfo = FixedPointUtilities.Precompute(p);
		ECLookupTable lookupTable = fixedPointPreCompInfo.LookupTable;
		int width = fixedPointPreCompInfo.Width;
		int num = (combSize + width - 1) / width;
		ECPoint eCPoint = curve.Infinity;
		int num2 = num * width;
		uint[] x = Nat.FromBigInteger(num2, k);
		int num3 = num2 - 1;
		for (int i = 0; i < num; i++)
		{
			int num4 = 0;
			for (int num5 = num3 - i; num5 >= 0; num5 -= num)
			{
				num4 <<= 1;
				num4 |= (int)Nat.GetBit(x, num5);
			}
			ECPoint b = lookupTable.Lookup(num4);
			eCPoint = eCPoint.TwicePlus(b);
		}
		return eCPoint.Add(fixedPointPreCompInfo.Offset);
	}
}
