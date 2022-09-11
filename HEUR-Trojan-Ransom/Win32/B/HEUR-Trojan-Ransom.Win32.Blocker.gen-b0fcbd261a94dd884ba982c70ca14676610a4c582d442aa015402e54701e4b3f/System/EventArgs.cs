namespace System;

public class EventArgs<T> : EventArgs
{
	private T _value;

	public T Value => _value;

	public EventArgs(T value)
	{
		_value = value;
	}
}
