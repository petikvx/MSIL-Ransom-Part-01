using System;

namespace ExciteRAN;

internal sealed class EditorDictionary
{
	internal static RuntimeTypeHandle ResolveFile()
	{
		return typeof(EmulatorInvoker).TypeHandle;
	}
}
