using System;

namespace Orcus.Native;

public struct ProcessBasicInformation
{
	internal IntPtr Reserved1;

	internal IntPtr PebBaseAddress;

	internal IntPtr Reserved2_0;

	internal IntPtr Reserved2_1;

	internal IntPtr UniqueProcessId;

	internal IntPtr InheritedFromUniqueProcessId;
}
