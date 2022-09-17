using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
[ComVisible(false)]
internal struct Struct14
{
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
	public string string_0;

	public Interface9 interface9_0;
}
