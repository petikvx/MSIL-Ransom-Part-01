using System;

namespace ManualMapInjection.Injection.Win32;

public struct UNICODE_STRING
{
	public ushort Length;

	public ushort MaximumLength;

	public IntPtr Buffer;
}
