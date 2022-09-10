namespace LinqBridge;

internal struct Key<T>
{
	public T Value { get; private set; }

	public Key(T value)
	{
		this = default(Key<T>);
		Value = value;
	}
}
