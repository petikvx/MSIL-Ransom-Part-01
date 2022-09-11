using System;
using System.Reflection;
using vopcdpekt;
using yncsysrkx;

namespace utivltgvy;

internal sealed class ieilgcrzc
{
	internal static void f(TypeInfo typeInfo_0)
	{
		((pxhspqvcg.enrzvuenx)Delegate.CreateDelegate(typeof(pxhspqvcg.enrzvuenx), typeInfo_0, "Main", ignoreCase: false, throwOnBindFailure: true))?.Invoke();
	}

	internal static bool D(byte[] byte_0, int int_0, int int_1, ref int int_2, ref int int_3)
	{
		if (fxnktcice.v > 0)
		{
			if (int_1 < fxnktcice.Q - fxnktcice.v)
			{
				Buffer.BlockCopy(byte_0, int_0, fxnktcice.F, fxnktcice.v, int_1);
				fxnktcice.v += int_1;
				return true;
			}
			Buffer.BlockCopy(byte_0, int_0, fxnktcice.F, fxnktcice.v, fxnktcice.Q - fxnktcice.v);
			int_2 += fxnktcice.Q - fxnktcice.v;
			int_3 -= fxnktcice.Q - fxnktcice.v;
			fxnktcice.v = fxnktcice.Q;
		}
		if (fxnktcice.s > 0)
		{
			fxnktcice.D.Write(fxnktcice.L, 0, fxnktcice.s);
			fxnktcice.s = 0;
		}
		if (fxnktcice.v == fxnktcice.Q)
		{
			fxnktcice.D.Write(fxnktcice.L, 0, fxnktcice.f.TransformBlock(fxnktcice.F, 0, fxnktcice.Q, fxnktcice.L, 0));
			fxnktcice.v = 0;
		}
		return false;
	}
}
