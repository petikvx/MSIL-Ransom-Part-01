using System;

namespace Orcus.Utilities;

public sealed class Lazy<T>
{
	private readonly Func<T> _createValue;

	private readonly object _padlock = new object();

	private bool _isValueCreated;

	private T _value;

	public T Value
	{
		get
		{
			if (!_isValueCreated)
			{
				lock (_padlock)
				{
					if (!_isValueCreated)
					{
						_value = _createValue();
						_isValueCreated = true;
					}
				}
			}
			return _value;
		}
	}

	public bool IsValueCreated
	{
		get
		{
			lock (_padlock)
			{
				return _isValueCreated;
			}
		}
	}

	public Lazy(Func<T> createValue)
	{
		if (createValue == null)
		{
			throw new ArgumentNullException("createValue");
		}
		_createValue = createValue;
	}

	public override string ToString()
	{
		return Value.ToString();
	}
}
