using System;

internal sealed class Class26 : Interface0
{
	private Delegate delegate_0;

	public Class26(Delegate delegate_1)
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
			56 => -14, 
			57 => -16, 
			52 => -25, 
			_ => -1, 
		};
	}
}
