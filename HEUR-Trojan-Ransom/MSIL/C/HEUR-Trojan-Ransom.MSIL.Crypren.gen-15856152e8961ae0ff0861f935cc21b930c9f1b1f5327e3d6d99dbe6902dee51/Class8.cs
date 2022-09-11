using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal class Class8
{
	public uint uint_0;

	public uint uint_1;

	public bool bool_0;

	internal static int smethod_0(int int_0)
	{
		return int_0 switch
		{
			37 => -16, 
			38 => -4, 
			39 => -1, 
			41 => -3, 
			42 => -2, 
			47 => -5, 
			48 => -6, 
			50 => -26, 
			51 => -25, 
			53 => -30, 
			57 => -7, 
			58 => -13, 
			_ => -1, 
		};
	}
}
