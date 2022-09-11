using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace MySql.Data.MySqlClient;

public sealed class GenericConfigurationElementCollection<T> : ConfigurationElementCollection, IEnumerable, IEnumerable<T> where T : ConfigurationElement, new()
{
	[CompilerGenerated]
	private sealed class Class150
	{
		public ConfigurationElement configurationElement_0;

		internal bool method_0(T gparam_0)
		{
			return ((object)gparam_0).Equals((object?)configurationElement_0);
		}
	}

	private List<T> list_0 = new List<T>();

	ConfigurationElement ConfigurationElementCollection.CreateNewElement()
	{
		T val = new T();
		list_0.Add(val);
		return (ConfigurationElement)(object)val;
	}

	object ConfigurationElementCollection.GetElementKey(ConfigurationElement element)
	{
		return list_0.Find((T gparam_0) => ((object)gparam_0).Equals((object?)element));
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return list_0.GetEnumerator();
	}
}
