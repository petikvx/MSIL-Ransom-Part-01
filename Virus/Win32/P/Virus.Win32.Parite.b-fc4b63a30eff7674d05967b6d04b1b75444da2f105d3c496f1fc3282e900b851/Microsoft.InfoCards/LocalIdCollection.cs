using System.Collections.Generic;

namespace Microsoft.InfoCards;

internal class LocalIdCollection
{
	private SortedList<int, int> m_inner;

	public int Count => m_inner.Count;

	public IList<int> Keys => m_inner.Keys;

	public LocalIdCollection()
	{
		m_inner = new SortedList<int, int>();
	}

	public void Add(int item)
	{
		if (!m_inner.ContainsKey(item))
		{
			m_inner.Add(item, item);
		}
	}

	public void Clear()
	{
		m_inner.Clear();
	}

	public void Filter(LocalIdCollection itemsToKeep)
	{
		int count = m_inner.Count;
		for (int num = count - 1; num >= 0; num--)
		{
			if (!itemsToKeep.m_inner.ContainsKey(m_inner.Keys[num]))
			{
				m_inner.RemoveAt(num);
			}
		}
	}
}
