using System;

namespace G;

internal sealed class F
{
	internal static V c(AppDomain appDomain_0)
	{
		//IL_0002: Expected O, but got I4
		//IL_000e: Expected O, but got I4
		string text = (string)0;
		do
		{
			if (text == null)
			{
				text = (string)1;
			}
		}
		while ((nint)text != 1);
		return (V)appDomain_0.CreateInstanceAndUnwrap(e.I(), e.L());
	}
}
