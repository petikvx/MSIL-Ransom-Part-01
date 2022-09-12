using System.Collections;
using System.Collections.Generic;
using System.Configuration;

namespace MySql.Data.MySqlClient;

public sealed class GenericConfigurationElementCollection<T> : ConfigurationElementCollection, IEnumerable<T>, IEnumerable where T : ConfigurationElement, new()
{
	private List<T> _elements = new List<T>();

	protected override ConfigurationElement CreateNewElement()
	{
		T val = new T();
		_elements.Add(val);
		return (ConfigurationElement)(object)val;
	}

	protected override object GetElementKey(ConfigurationElement element)
	{
		return _elements.Find((T e) => ((object)e).Equals((object?)element));
	}

	public IEnumerator<T> GetEnumerator()
	{
		return _elements.GetEnumerator();
	}
}
