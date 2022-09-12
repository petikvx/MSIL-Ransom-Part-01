namespace Gecko;

public class Properties
{
	private nsIProperties _properties;

	internal Properties(nsIProperties properties)
	{
		_properties = properties;
	}

	public bool Has(string property)
	{
		return _properties.Has(property);
	}

	public bool Undefine(string property)
	{
		bool result;
		if (result = _properties.Has(property))
		{
			_properties.Undefine(property);
		}
		return result;
	}

	public string[] GetKeys()
	{
		uint count = 0u;
		string[] keys = null;
		_properties.GetKeys(ref count, ref keys);
		return keys;
	}
}
