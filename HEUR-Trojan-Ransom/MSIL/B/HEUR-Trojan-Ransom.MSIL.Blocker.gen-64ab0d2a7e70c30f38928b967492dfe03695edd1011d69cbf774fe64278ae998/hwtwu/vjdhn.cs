using System;
using System.Reflection;
using earce;
using kwdbo;

namespace hwtwu;

internal sealed class vjdhn
{
	internal static void x(TypeInfo typeInfo_0)
	{
		((jlrht.tutst)Delegate.CreateDelegate(typeof(jlrht.tutst), typeInfo_0, "Main", ignoreCase: false, throwOnBindFailure: true))?.Invoke();
	}

	internal static bool S(byte[] byte_0, int int_0, int int_1, ref int int_2, ref int int_3)
	{
		if (qfnvk.Y > 0)
		{
			if (int_1 < qfnvk.s - qfnvk.Y)
			{
				Buffer.BlockCopy(byte_0, int_0, qfnvk.M, qfnvk.Y, int_1);
				qfnvk.Y += int_1;
				return true;
			}
			Buffer.BlockCopy(byte_0, int_0, qfnvk.M, qfnvk.Y, qfnvk.s - qfnvk.Y);
			int_2 += qfnvk.s - qfnvk.Y;
			int_3 -= qfnvk.s - qfnvk.Y;
			qfnvk.Y = qfnvk.s;
		}
		if (qfnvk.M > 0)
		{
			qfnvk.L.Write(qfnvk.N, 0, qfnvk.M);
			qfnvk.M = 0;
		}
		if (qfnvk.Y == qfnvk.s)
		{
			qfnvk.L.Write(qfnvk.N, 0, qfnvk.F.TransformBlock(qfnvk.M, 0, qfnvk.s, qfnvk.N, 0));
			qfnvk.Y = 0;
		}
		return false;
	}
}
