using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NanoCore;

public sealed class GClass8 : IClientReadOnlyNameObjectCollection
{
	private Dictionary<string, object> dictionary_0;

	public GClass8(Dictionary<string, object> dictionary_1)
	{
		dictionary_0 = dictionary_1;
	}

	public object GetValue(string string_0, object object_0)
	{
		lock (dictionary_0)
		{
			if (dictionary_0.ContainsKey(string_0))
			{
				return dictionary_0[string_0];
			}
			return object_0;
		}
	}

	public void method_0(string string_0, object object_0)
	{
		lock (dictionary_0)
		{
			if (dictionary_0.ContainsKey(string_0))
			{
				if (!dictionary_0[string_0].Equals(RuntimeHelpers.GetObjectValue(object_0)))
				{
					dictionary_0[string_0] = RuntimeHelpers.GetObjectValue(object_0);
				}
			}
			else
			{
				dictionary_0.Add(string_0, RuntimeHelpers.GetObjectValue(object_0));
			}
		}
	}

	public bool EntryExists(string string_0)
	{
		lock (dictionary_0)
		{
			return dictionary_0.ContainsKey(string_0);
		}
	}

	public KeyValuePair<string, object>[] GetEntries()
	{
		lock (dictionary_0)
		{
			List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();
			Dictionary<string, object>.Enumerator enumerator = dictionary_0.GetEnumerator();
			while (enumerator.MoveNext())
			{
				KeyValuePair<string, object> item = new KeyValuePair<string, object>(enumerator.Current.Key, RuntimeHelpers.GetObjectValue(enumerator.Current.Value));
				list.Add(item);
			}
			return list.ToArray();
		}
	}
}
