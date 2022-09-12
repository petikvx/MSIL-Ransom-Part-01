using System;

namespace ExciteRAN;

internal sealed class NetworkAttribute
{
	internal static RuntimeTypeHandle ResolveFile()
	{
		return typeof(MulticastDelegate).TypeHandle;
	}
}
