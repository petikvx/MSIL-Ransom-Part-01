using System;
using System.Reflection.Emit;

namespace ExciteRAN;

internal sealed class SymbolResolver
{
	internal static RuntimeTypeHandle ResolveFile()
	{
		return typeof(OpCodes).TypeHandle;
	}
}
