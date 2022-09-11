using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
internal class Class11
{
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
	public string string_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public uint uint_0;

	[MarshalAs(UnmanagedType.I1)]
	public bool bool_0;
}
