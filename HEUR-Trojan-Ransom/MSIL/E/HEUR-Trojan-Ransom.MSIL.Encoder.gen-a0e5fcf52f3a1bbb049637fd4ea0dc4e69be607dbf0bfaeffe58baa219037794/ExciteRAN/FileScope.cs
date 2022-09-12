using System;
using System.Reflection;

namespace ExciteRAN;

internal sealed class FileScope
{
	internal static UIntPtr CleanAssistant(FieldInfo[] windowPosition)
	{
		return (nuint)windowPosition.LongLength;
	}
}
