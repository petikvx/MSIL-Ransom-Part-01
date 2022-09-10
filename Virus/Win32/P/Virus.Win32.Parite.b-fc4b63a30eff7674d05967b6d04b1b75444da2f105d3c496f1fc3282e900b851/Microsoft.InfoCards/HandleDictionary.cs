using System;
using System.Collections.Generic;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class HandleDictionary<TVal>
{
	private const int m_MaxSessionCount = 1073741823;

	private Dictionary<int, TVal> m_internalDictionary;

	private Random m_random;

	public int MaxSize => 1073741823;

	public TVal this[int Key]
	{
		get
		{
			return m_internalDictionary[Key];
		}
		set
		{
			if (!ContainsHandle(Key))
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new KeyNotFoundException());
			}
			m_internalDictionary[Key] = value;
		}
	}

	public HandleDictionary()
	{
		m_internalDictionary = new Dictionary<int, TVal>();
		m_random = new Random();
	}

	public int GetNewHandle()
	{
		if (m_internalDictionary.Count >= 1073741823)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new MaxSessionCountExceededException());
		}
		int num = m_random.Next();
		while (m_internalDictionary.ContainsKey(num) || num == 0)
		{
			num = m_random.Next();
		}
		m_internalDictionary[num] = default(TVal);
		return num;
	}

	public bool Remove(int key)
	{
		return m_internalDictionary.Remove(key);
	}

	public bool ContainsHandle(int key)
	{
		return m_internalDictionary.ContainsKey(key);
	}
}
