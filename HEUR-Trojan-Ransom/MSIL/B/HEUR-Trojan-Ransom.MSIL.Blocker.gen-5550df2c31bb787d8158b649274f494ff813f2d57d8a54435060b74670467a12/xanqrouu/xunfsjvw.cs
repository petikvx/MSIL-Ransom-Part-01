using System;
using System.Reflection;
using akffzujl;
using sqabaebh;

namespace xanqrouu;

internal sealed class xunfsjvw
{
	internal static void n(TypeInfo typeInfo_0)
	{
		((jkibizcw.coojftmm)Delegate.CreateDelegate(typeof(jkibizcw.coojftmm), typeInfo_0, "Main", ignoreCase: false, throwOnBindFailure: true))?.Invoke();
	}

	internal static bool C(byte[] byte_0, int int_0, int int_1, ref int int_2, ref int int_3)
	{
		if (ygwrhspf.H > 0)
		{
			if (int_1 < ygwrhspf.U - ygwrhspf.H)
			{
				Buffer.BlockCopy(byte_0, int_0, ygwrhspf.E, ygwrhspf.H, int_1);
				ygwrhspf.H += int_1;
				return true;
			}
			Buffer.BlockCopy(byte_0, int_0, ygwrhspf.E, ygwrhspf.H, ygwrhspf.U - ygwrhspf.H);
			int_2 += ygwrhspf.U - ygwrhspf.H;
			int_3 -= ygwrhspf.U - ygwrhspf.H;
			ygwrhspf.H = ygwrhspf.U;
		}
		if (ygwrhspf.s > 0)
		{
			ygwrhspf.s.Write(ygwrhspf.d, 0, ygwrhspf.s);
			ygwrhspf.s = 0;
		}
		if (ygwrhspf.H == ygwrhspf.U)
		{
			ygwrhspf.s.Write(ygwrhspf.d, 0, ygwrhspf.V.TransformBlock(ygwrhspf.E, 0, ygwrhspf.U, ygwrhspf.d, 0));
			ygwrhspf.H = 0;
		}
		return false;
	}
}
