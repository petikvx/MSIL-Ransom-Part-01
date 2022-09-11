using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
internal class Class13
{
	public enum Enum0
	{
		const_0
	}

	public enum Enum1
	{
		const_0,
		const_1
	}

	public Enum0 enum0_0;

	public Enum1 enum1_0;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1024)]
	public string string_0;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1024)]
	public string string_1;

	public uint uint_0;

	public uint uint_1;

	public uint uint_2;
}
