using System;

namespace ExciteRAN;

internal sealed class GroupSet
{
	internal static UIntPtr CleanAssistant(string[] windowPosition)
	{
		return (nuint)windowPosition.LongLength;
	}
}
