using System.Runtime.InteropServices;

namespace ManualMapInjection.Injection.Win32;

[StructLayout(LayoutKind.Explicit)]
public struct IMAGE_THUNK_DATA
{
	[FieldOffset(0)]
	public uint ForwarderString;

	[FieldOffset(0)]
	public uint Function;

	[FieldOffset(0)]
	public uint Ordinal;

	[FieldOffset(0)]
	public uint AddressOfData;
}
