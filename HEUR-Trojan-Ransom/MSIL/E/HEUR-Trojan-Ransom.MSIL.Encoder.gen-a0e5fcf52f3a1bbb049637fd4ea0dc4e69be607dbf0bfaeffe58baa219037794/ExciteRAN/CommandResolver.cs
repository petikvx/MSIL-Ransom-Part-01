using System;
using System.Reflection.Emit;

namespace ExciteRAN;

internal sealed class CommandResolver
{
	internal static RuntimeTypeHandle CleanAssistant()
	{
		return typeof(OpCodes).TypeHandle;
	}
}
