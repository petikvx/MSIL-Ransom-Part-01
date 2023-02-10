using System;
using System.Reflection.Emit;

namespace A;

internal sealed class PY
{
	internal static RuntimeTypeHandle D()
	{
		return typeof(OpCodes).TypeHandle;
	}
}
