using System;

namespace rundll32;

public class functionVariable
{
	private Type _type;

	private object _name;

	private object _value;

	public Type Type => _type;

	public object Name => _name;

	public object Value
	{
		get
		{
			return _value;
		}
		set
		{
			_type = value.GetType();
			_value = value;
		}
	}

	public functionVariable(string Name, object Value)
	{
		_name = Name;
		_value = Value;
		_type = Value.GetType();
	}
}
