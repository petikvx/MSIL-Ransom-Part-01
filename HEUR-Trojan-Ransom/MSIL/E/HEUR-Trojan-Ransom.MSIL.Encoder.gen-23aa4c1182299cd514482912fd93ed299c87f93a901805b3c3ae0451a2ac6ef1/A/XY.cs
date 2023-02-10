using System;
using System.Reflection;

namespace A;

internal sealed class XY
{
	internal static UIntPtr D(ParameterInfo[] P_0)
	{
		return (nuint)P_0.LongLength;
	}
}
