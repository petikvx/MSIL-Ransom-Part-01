using System;
using System.Reflection;

namespace ExciteRAN;

internal sealed class ComponentConverter
{
	internal static UIntPtr ResolveFile(ParameterInfo[] P_0)
	{
		return (nuint)P_0.LongLength;
	}
}
