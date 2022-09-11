using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NanoCore;

public sealed class GClass6 : IClientNameObjectCollection
{
	private GDelegate0 gdelegate0_0;

	private Dictionary<string, object> dictionary_0;

	public GClass6(GDelegate0 gdelegate0_1)
	{
		gdelegate0_0 = gdelegate0_1;
		dictionary_0 = new Dictionary<string, object>();
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

	public void SetValue(string string_0, object object_0)
	{
		lock (dictionary_0)
		{
			if (dictionary_0.ContainsKey(string_0))
			{
				if (dictionary_0[string_0].Equals(RuntimeHelpers.GetObjectValue(object_0)))
				{
					return;
				}
				dictionary_0[string_0] = RuntimeHelpers.GetObjectValue(object_0);
			}
			else
			{
				dictionary_0.Add(string_0, RuntimeHelpers.GetObjectValue(object_0));
			}
		}
		if (gdelegate0_0 != null)
		{
			gdelegate0_0(string_0);
		}
	}

	public void RemoveValue(string string_0)
	{
		bool flag = default(bool);
		lock (dictionary_0)
		{
			if (dictionary_0.ContainsKey(string_0))
			{
				flag = true;
				dictionary_0.Remove(string_0);
			}
		}
		if (flag && gdelegate0_0 != null)
		{
			gdelegate0_0(string_0);
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

	public int method_0()
	{
		int count = dictionary_0.Count;
		dictionary_0.Clear();
		return count;
	}
}
