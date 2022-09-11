using System;

namespace ns0;

internal sealed class Class0
{
	internal static Class10 smethod_0(AppDomain appDomain_0)
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
		return (Class10)appDomain_0.CreateInstanceAndUnwrap(Class6.smethod_0(), Class6.smethod_1());
	}
}
