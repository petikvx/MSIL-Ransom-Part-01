using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
[ComVisible(false)]
internal struct Struct13
{
	public Interface4 interface4_0;

	public Enum4 enum4_0;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
	public string string_0;
}
