using System;
using System.Runtime.InteropServices;
using CoreAudioApi.Interfaces;

namespace CoreAudioApi;

public class PropertyStore
{
	private IPropertyStore _Store;

	public int Count
	{
		get
		{
			Marshal.ThrowExceptionForHR(_Store.GetCount(out var count));
			return count;
		}
	}

	public PropertyStoreProperty this[int index]
	{
		get
		{
			PropertyKey key = Get(index);
			Marshal.ThrowExceptionForHR(_Store.GetValue(ref key, out var pv));
			return new PropertyStoreProperty(key, pv);
		}
	}

	public PropertyStoreProperty this[Guid guid]
	{
		get
		{
			int num = 0;
			PropertyKey key;
			while (true)
			{
				if (num < Count)
				{
					key = Get(num);
					if (key.fmtid == guid)
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			Marshal.ThrowExceptionForHR(_Store.GetValue(ref key, out var pv));
			return new PropertyStoreProperty(key, pv);
		}
	}

	public bool Contains(Guid guid)
	{
		int num = 0;
		while (true)
		{
			if (num < Count)
			{
				if (Get(num).fmtid == guid)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public PropertyKey Get(int index)
	{
		Marshal.ThrowExceptionForHR(_Store.GetAt(index, out var pkey));
		return pkey;
	}

	public PropVariant GetValue(int index)
	{
		PropertyKey key = Get(index);
		Marshal.ThrowExceptionForHR(_Store.GetValue(ref key, out var pv));
		return pv;
	}

	internal PropertyStore(IPropertyStore store)
	{
		_Store = store;
	}
}
