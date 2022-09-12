using System;

namespace ExciteRAN;

internal sealed class RegistryLayout
{
	internal static UIntPtr CleanAssistant(byte[] windowPosition)
	{
		return (nuint)windowPosition.LongLength;
	}
}
