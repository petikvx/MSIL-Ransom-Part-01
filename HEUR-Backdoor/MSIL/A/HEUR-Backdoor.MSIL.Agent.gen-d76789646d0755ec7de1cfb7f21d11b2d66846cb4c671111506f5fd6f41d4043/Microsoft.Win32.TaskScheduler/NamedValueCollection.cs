using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
public sealed class NamedValueCollection : IDisposable, IEnumerable
{
	private ITaskNamedValueCollection v2Coll;

	private Dictionary<string, string> unboundDict;

	internal bool Bound => v2Coll != null;

	public int Count
	{
		get
		{
			if (v2Coll == null)
			{
				return unboundDict.Count;
			}
			return v2Coll.Count;
		}
	}

	public string this[int index]
	{
		get
		{
			if (v2Coll != null)
			{
				return v2Coll[++index].Value;
			}
			string[] array = new string[unboundDict.Count];
			unboundDict.Keys.CopyTo(array, 0);
			return unboundDict[array[index]];
		}
	}

	public string this[string key]
	{
		get
		{
			if (v2Coll != null)
			{
				foreach (ITaskNamedValuePair item in v2Coll)
				{
					if (string.Compare(item.Name, key, ignoreCase: false) == 0)
					{
						return item.Value;
					}
				}
				return null;
			}
			string value = null;
			unboundDict.TryGetValue(key, out value);
			return value;
		}
	}

	internal NamedValueCollection(ITaskNamedValueCollection iColl)
	{
		v2Coll = iColl;
	}

	internal NamedValueCollection()
	{
		unboundDict = new Dictionary<string, string>(5);
	}

	internal void Bind(ITaskNamedValueCollection iTaskNamedValueCollection)
	{
		v2Coll = iTaskNamedValueCollection;
		v2Coll.Clear();
		foreach (KeyValuePair<string, string> item in unboundDict)
		{
			v2Coll.Create(item.Key, item.Value);
		}
	}

	public void CopyTo(NamedValueCollection destCollection)
	{
		if (v2Coll != null)
		{
			for (int i = 1; i <= Count; i++)
			{
				destCollection.Add(v2Coll[i].Name, v2Coll[i].Value);
			}
			return;
		}
		foreach (KeyValuePair<string, string> item in unboundDict)
		{
			destCollection.Add(item.Key, item.Value);
		}
	}

	public void Dispose()
	{
		if (v2Coll != null)
		{
			Marshal.ReleaseComObject(v2Coll);
		}
	}

	public void Add(string Name, string Value)
	{
		if (v2Coll != null)
		{
			v2Coll.Create(Name, Value);
		}
		else
		{
			unboundDict.Add(Name, Value);
		}
	}

	public void RemoveAt(int index)
	{
		v2Coll.Remove(index);
	}

	public void Clear()
	{
		if (v2Coll != null)
		{
			v2Coll.Clear();
		}
		else
		{
			unboundDict.Clear();
		}
	}

	public IEnumerator GetEnumerator()
	{
		if (v2Coll != null)
		{
			return v2Coll.GetEnumerator();
		}
		return unboundDict.GetEnumerator();
	}
}
