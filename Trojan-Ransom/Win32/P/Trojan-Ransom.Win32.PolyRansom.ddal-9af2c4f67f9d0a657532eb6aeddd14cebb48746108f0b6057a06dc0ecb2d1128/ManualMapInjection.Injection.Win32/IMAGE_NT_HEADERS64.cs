using System.Runtime.InteropServices;

namespace ManualMapInjection.Injection.Win32;

[StructLayout(LayoutKind.Explicit)]
public struct IMAGE_NT_HEADERS64
{
	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
	public char[] Signature;

	[FieldOffset(4)]
	public IMAGE_FILE_HEADER FileHeader;

	[FieldOffset(24)]
	public IMAGE_OPTIONAL_HEADER64 OptionalHeader;

	private string _Signature => new string(Signature);

	public bool isValid => _Signature == "PE\0\0";
}
