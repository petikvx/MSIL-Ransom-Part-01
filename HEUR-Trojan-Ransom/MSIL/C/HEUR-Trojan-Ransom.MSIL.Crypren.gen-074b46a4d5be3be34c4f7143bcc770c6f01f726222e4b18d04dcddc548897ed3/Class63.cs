using System;

internal sealed class Class63 : Interface0
{
	private Delegate delegate_0;

	public Class63(Delegate delegate_1)
	{
		delegate_0 = delegate_1;
	}

	public object imethod_0(object object_0, object[] object_1)
	{
		return delegate_0.DynamicInvoke(object_1);
	}
}
