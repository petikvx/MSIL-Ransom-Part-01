using System;

namespace antlr;

[Serializable]
public class ANTLRPanicException : ANTLRException
{
	public ANTLRPanicException()
	{
	}

	public ANTLRPanicException(string string_0)
	{
	}

	public ANTLRPanicException(string string_0, Exception exception_0)
	{
	}

	internal static int smethod_0(int int_0)
	{
		return int_0 switch
		{
			99 => -61, 
			96 => -63, 
			77 => -11, 
			80 => -20, 
			81 => -26, 
			85 => -23, 
			86 => -22, 
			87 => -17, 
			89 => -31, 
			91 => -19, 
			93 => -62, 
			_ => -1, 
		};
	}
}
