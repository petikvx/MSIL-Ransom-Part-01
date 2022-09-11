using System;
using System.Reflection;
using essrx;
using xcpho;

namespace fswwcv;

internal sealed class lbyxre
{
	internal static void L(TypeInfo typeInfo_0)
	{
		((kpbkz.tuwws)Delegate.CreateDelegate(typeof(kpbkz.tuwws), typeInfo_0, "Main", ignoreCase: false, throwOnBindFailure: true))?.Invoke();
	}

	internal static bool V(byte[] byte_0, int int_0, int int_1, ref int int_2, ref int int_3)
	{
		if (czltw.J > 0)
		{
			if (int_1 < czltw.i - czltw.J)
			{
				Buffer.BlockCopy(byte_0, int_0, czltw.c, czltw.J, int_1);
				czltw.J += int_1;
				return true;
			}
			Buffer.BlockCopy(byte_0, int_0, czltw.c, czltw.J, czltw.i - czltw.J);
			int_2 += czltw.i - czltw.J;
			int_3 -= czltw.i - czltw.J;
			czltw.J = czltw.i;
		}
		if (czltw.B > 0)
		{
			czltw.m.Write(czltw.w, 0, czltw.B);
			czltw.B = 0;
		}
		if (czltw.J == czltw.i)
		{
			czltw.m.Write(czltw.w, 0, czltw.A.TransformBlock(czltw.c, 0, czltw.i, czltw.w, 0));
			czltw.J = 0;
		}
		return false;
	}
}
