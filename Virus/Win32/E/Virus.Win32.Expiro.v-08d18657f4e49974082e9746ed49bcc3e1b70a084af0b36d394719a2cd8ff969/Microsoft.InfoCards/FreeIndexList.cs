using System;
using System.Collections.Generic;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class FreeIndexList
{
	private Dictionary<int, int> m_list;

	public FreeIndexList(int size)
	{
		if (size <= 0)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("size", size, SR.GetString("StoreFreeListSizeOutOfRange")));
		}
		m_list = new Dictionary<int, int>(size);
	}

	public bool Contains(int value)
	{
		if (value <= 0)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("value", value, SR.GetString("StoreFreeListValueOutOfRange")));
		}
		return m_list.ContainsKey(value);
	}

	public void Put(int value)
	{
		if (value <= 0)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("value", value, SR.GetString("StoreFreeListValueOutOfRange")));
		}
		m_list.Add(value, value);
	}

	public int GetNext()
	{
		int num = -1;
		if (m_list.Count > 0)
		{
			using (IEnumerator<int> enumerator = (object)m_list.Keys.GetEnumerator())
			{
				enumerator.MoveNext();
				num = enumerator.Current;
			}
			m_list.Remove(num);
		}
		return num;
	}
}
