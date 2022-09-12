using System;
using System.Reflection;
using nclou;
using rjrkni;

namespace asjriml;

internal sealed class sapccvb
{
	internal static void f(TypeInfo typeInfo_0)
	{
		((blvoul.grcdh)Delegate.CreateDelegate(typeof(blvoul.grcdh), typeInfo_0, "Main", ignoreCase: false, throwOnBindFailure: true))?.Invoke();
	}

	internal static bool P(byte[] byte_0, int int_0, int int_1, ref int int_2, ref int int_3)
	{
		if (wlqzy.s > 0)
		{
			if (int_1 < wlqzy.L - wlqzy.s)
			{
				Buffer.BlockCopy(byte_0, int_0, wlqzy.X, wlqzy.s, int_1);
				wlqzy.s += int_1;
				return true;
			}
			Buffer.BlockCopy(byte_0, int_0, wlqzy.X, wlqzy.s, wlqzy.L - wlqzy.s);
			int_2 += wlqzy.L - wlqzy.s;
			int_3 -= wlqzy.L - wlqzy.s;
			wlqzy.s = wlqzy.L;
		}
		if (wlqzy.E > 0)
		{
			wlqzy.b.Write(wlqzy.B, 0, wlqzy.E);
			wlqzy.E = 0;
		}
		if (wlqzy.s == wlqzy.L)
		{
			wlqzy.b.Write(wlqzy.B, 0, wlqzy.X.TransformBlock(wlqzy.X, 0, wlqzy.L, wlqzy.B, 0));
			wlqzy.s = 0;
		}
		return false;
	}
}
