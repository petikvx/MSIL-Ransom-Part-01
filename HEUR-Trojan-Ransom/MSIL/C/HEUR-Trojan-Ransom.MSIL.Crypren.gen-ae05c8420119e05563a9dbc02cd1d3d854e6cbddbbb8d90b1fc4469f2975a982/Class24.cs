using System;

internal sealed class Class24 : Interface0
{
	private Delegate delegate_0;

	public Class24(Delegate delegate_1)
	{
		delegate_0 = delegate_1;
	}

	public object imethod_0(object object_0, object[] object_1)
	{
		return delegate_0.DynamicInvoke(object_1);
	}

	internal static int smethod_0(int int_0)
	{
		return int_0 switch
		{
			72 => -27, 
			46 => -18, 
			47 => -9, 
			48 => -30, 
			50 => -6, 
			51 => -10, 
			52 => -2, 
			53 => -14, 
			55 => -24, 
			56 => -16, 
			57 => -1, 
			59 => -5, 
			_ => -1, 
		};
	}
}
