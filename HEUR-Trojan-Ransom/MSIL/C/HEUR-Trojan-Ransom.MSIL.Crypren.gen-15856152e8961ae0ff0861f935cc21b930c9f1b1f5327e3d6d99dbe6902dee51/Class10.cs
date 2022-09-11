using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
internal class Class10
{
	[MarshalAs(UnmanagedType.I1)]
	public bool bool_0;

	[MarshalAs(UnmanagedType.I1)]
	public bool bool_1;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10240)]
	public string Str;

	public uint uint_0;

	internal static int smethod_0(int int_0)
	{
		return int_0 switch
		{
			94 => -54, 
			96 => -18, 
			98 => -63, 
			73 => -116, 
			79 => -117, 
			80 => -22, 
			82 => -24, 
			83 => -20, 
			84 => -28, 
			85 => -31, 
			86 => -19, 
			88 => -27, 
			90 => -55, 
			_ => -1, 
		};
	}
}
