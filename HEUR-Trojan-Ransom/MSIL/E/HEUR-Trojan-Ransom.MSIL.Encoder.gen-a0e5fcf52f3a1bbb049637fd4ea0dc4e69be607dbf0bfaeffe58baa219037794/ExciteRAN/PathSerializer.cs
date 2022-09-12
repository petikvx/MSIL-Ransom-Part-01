using System;
using System.Reflection;

namespace ExciteRAN;

internal sealed class PathSerializer
{
	internal static UIntPtr CleanAssistant(ParameterInfo[] windowPosition)
	{
		return (nuint)windowPosition.LongLength;
	}
}
