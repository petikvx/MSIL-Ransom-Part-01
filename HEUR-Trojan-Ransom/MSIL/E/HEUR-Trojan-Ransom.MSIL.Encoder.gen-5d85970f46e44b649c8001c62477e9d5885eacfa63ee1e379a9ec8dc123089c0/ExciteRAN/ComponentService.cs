using System;

namespace ExciteRAN;

internal sealed class ComponentService
{
	internal static UIntPtr ResolveFile(string[] P_0)
	{
		return (nuint)P_0.LongLength;
	}
}
