using ns6;

namespace ns15;

internal class Class80
{
	private readonly object? object_0;

	private readonly Delegate1<object?, object> delegate1_0;

	public Class80(object? object_1, Delegate1<object?, object> delegate1_1)
	{
		object_0 = object_1;
		delegate1_0 = delegate1_1;
	}

	public object method_0(params object[] object_1)
	{
		return delegate1_0(object_0, object_1);
	}
}
