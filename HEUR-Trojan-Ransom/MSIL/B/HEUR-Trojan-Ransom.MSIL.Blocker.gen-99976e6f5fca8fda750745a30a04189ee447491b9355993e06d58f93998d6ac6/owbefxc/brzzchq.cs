using System;
using System.Reflection;
using jjnmlvx;
using rgbyxkb;

namespace owbefxc;

internal sealed class brzzchq
{
	internal static void X(TypeInfo typeInfo_0)
	{
		((setfoen.xkvoxjc)Delegate.CreateDelegate(typeof(setfoen.xkvoxjc), typeInfo_0, "Main", ignoreCase: false, throwOnBindFailure: true))?.Invoke();
	}

	internal static bool C(byte[] byte_0, int int_0, int int_1, ref int int_2, ref int int_3)
	{
		if (dfehscp.j > 0)
		{
			if (int_1 < dfehscp.I - dfehscp.j)
			{
				Buffer.BlockCopy(byte_0, int_0, dfehscp.K, dfehscp.j, int_1);
				dfehscp.j += int_1;
				return true;
			}
			Buffer.BlockCopy(byte_0, int_0, dfehscp.K, dfehscp.j, dfehscp.I - dfehscp.j);
			int_2 += dfehscp.I - dfehscp.j;
			int_3 -= dfehscp.I - dfehscp.j;
			dfehscp.j = dfehscp.I;
		}
		if (dfehscp.w > 0)
		{
			dfehscp.U.Write(dfehscp.t, 0, dfehscp.w);
			dfehscp.w = 0;
		}
		if (dfehscp.j == dfehscp.I)
		{
			dfehscp.U.Write(dfehscp.t, 0, dfehscp.W.TransformBlock(dfehscp.K, 0, dfehscp.I, dfehscp.t, 0));
			dfehscp.j = 0;
		}
		return false;
	}
}
