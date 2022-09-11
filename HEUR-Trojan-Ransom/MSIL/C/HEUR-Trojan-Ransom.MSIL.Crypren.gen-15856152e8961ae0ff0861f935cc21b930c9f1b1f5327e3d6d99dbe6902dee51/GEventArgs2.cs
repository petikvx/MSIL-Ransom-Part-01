using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[ComVisible(true)]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[Guid("4D79C4F7-0FE2-428D-9908-AB2D38E96C53")]
public class GEventArgs2 : EventArgs
{
	[CompilerGenerated]
	private GException2 gexception2_0;

	public GException2 GException2_0
	{
		[CompilerGenerated]
		get
		{
			return gexception2_0;
		}
		[CompilerGenerated]
		internal set
		{
			gexception2_0 = value;
		}
	}

	internal GEventArgs2()
	{
	}

	internal static int smethod_0(int int_0)
	{
		return int_0 switch
		{
			49 => -10, 
			40 => -11, 
			43 => -8, 
			44 => -14, 
			46 => -9, 
			_ => -1, 
		};
	}

	internal static int smethod_1(int int_0)
	{
		return int_0 switch
		{
			56 => -21, 
			59 => -32, 
			60 => -121, 
			52 => -23, 
			68 => -29, 
			63 => -122, 
			_ => -1, 
		};
	}
}
