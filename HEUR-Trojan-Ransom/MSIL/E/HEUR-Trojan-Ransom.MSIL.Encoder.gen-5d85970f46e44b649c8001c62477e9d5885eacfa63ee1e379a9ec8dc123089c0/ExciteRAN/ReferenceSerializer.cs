using System;

namespace ExciteRAN;

internal sealed class ReferenceSerializer
{
	internal static UIntPtr ResolveFile(byte[] P_0)
	{
		return (nuint)P_0.LongLength;
	}
}
