using System;
using System.Reflection;

namespace ExciteRAN;

internal sealed class CommandResolver
{
	internal static UIntPtr ResolveFile(FieldInfo[] P_0)
	{
		return (nuint)P_0.LongLength;
	}
}
