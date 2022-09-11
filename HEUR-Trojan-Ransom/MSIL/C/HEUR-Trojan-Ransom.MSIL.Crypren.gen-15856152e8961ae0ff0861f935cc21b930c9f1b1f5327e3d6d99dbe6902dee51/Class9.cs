using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
internal class Class9
{
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10240)]
	public string string_0;

	[MarshalAs(UnmanagedType.I1)]
	public bool bool_0;

	[MarshalAs(UnmanagedType.I1)]
	public bool bool_1;

	internal static int smethod_0(int int_0)
	{
		return int_0 switch
		{
			104 => -64, 
			106 => -51, 
			108 => -60, 
			87 => -57, 
			89 => -62, 
			91 => -58, 
			92 => -59, 
			93 => -56, 
			97 => -53, 
			99 => -61, 
			101 => -52, 
			_ => -1, 
		};
	}
}
