using System;
using System.Reflection;
using betcmswos;
using tifudnadt;

namespace zndtztukj;

internal sealed class fxrfsgqmx
{
	internal static void g(TypeInfo typeInfo_0)
	{
		((phqzbkarf.iokfrxesr)Delegate.CreateDelegate(typeof(phqzbkarf.iokfrxesr), typeInfo_0, "Main", ignoreCase: false, throwOnBindFailure: true))?.Invoke();
	}

	internal static bool e(byte[] byte_0, int int_0, int int_1, ref int int_2, ref int int_3)
	{
		if (ldwqswnax.y > 0)
		{
			if (int_1 < ldwqswnax.K - ldwqswnax.y)
			{
				Buffer.BlockCopy(byte_0, int_0, ldwqswnax.w, ldwqswnax.y, int_1);
				ldwqswnax.y += int_1;
				return true;
			}
			Buffer.BlockCopy(byte_0, int_0, ldwqswnax.w, ldwqswnax.y, ldwqswnax.K - ldwqswnax.y);
			int_2 += ldwqswnax.K - ldwqswnax.y;
			int_3 -= ldwqswnax.K - ldwqswnax.y;
			ldwqswnax.y = ldwqswnax.K;
		}
		if (ldwqswnax.t > 0)
		{
			ldwqswnax.B.Write(ldwqswnax.j, 0, ldwqswnax.t);
			ldwqswnax.t = 0;
		}
		if (ldwqswnax.y == ldwqswnax.K)
		{
			ldwqswnax.B.Write(ldwqswnax.j, 0, ldwqswnax.o.TransformBlock(ldwqswnax.w, 0, ldwqswnax.K, ldwqswnax.j, 0));
			ldwqswnax.y = 0;
		}
		return false;
	}
}
