using System.Collections.Generic;
using System.Linq;

namespace Coache.Business;

internal class SessionData
{
	private static Dictionary<string, object> _data = new Dictionary<string, object>();

	public static void Set(string key, object value)
	{
		Remove(key);
		_data.Add(key, value);
	}

	public static T Get<T>(string key)
	{
		return (T)_data[key];
	}

	public static bool Contains(string key)
	{
		return _data.Keys.Contains(key);
	}

	public static void Remove(string key)
	{
		if (_data.Keys.Contains(key))
		{
			_data.Remove(key);
		}
	}
}
