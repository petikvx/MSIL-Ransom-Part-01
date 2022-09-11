#define DEBUG
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using C3554254475;

namespace C3904355907;

internal sealed class C3775001192 : IEnumerable, IEnumerable<KeyValuePair<int, global::C3554254475.C3110715001>>
{
	private Dictionary<int, global::C3554254475.C3110715001> m_C3554254475 = new Dictionary<int, global::C3554254475.C3110715001>();

	private IEnumerator C3554254475()
	{
		return this.m_C3554254475.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in C3554254475
		return this.C3554254475();
	}

	public IEnumerator<KeyValuePair<int, global::C3554254475.C3110715001>> GetEnumerator()
	{
		return this.m_C3554254475.GetEnumerator();
	}

	public void C3904355907()
	{
		this.m_C3554254475.Clear();
	}

	private int C1255198513()
	{
		int i;
		for (i = this.m_C3554254475.Count; this.m_C3554254475.ContainsKey(i); i++)
		{
		}
		Debug.Assert(i == this.m_C3554254475.Count);
		return i;
	}

	public global::C3554254475.C3110715001 C3554254475(int int_0)
	{
		if (this.m_C3554254475.TryGetValue(int_0, out var value))
		{
			return value;
		}
		return null;
	}

	public int C3554254475(global::C3554254475.C3110715001 c3110715001_0)
	{
		if (c3110715001_0 == null)
		{
			Debug.Assert(condition: false);
			return -1;
		}
		foreach (KeyValuePair<int, global::C3554254475.C3110715001> item in this.m_C3554254475)
		{
			if (c3110715001_0 == item.Value)
			{
				Debug.Assert(c3110715001_0.Equals(item.Value));
				return item.Key;
			}
		}
		foreach (KeyValuePair<int, global::C3554254475.C3110715001> item2 in this.m_C3554254475)
		{
			if (c3110715001_0.Equals(item2.Value))
			{
				return item2.Key;
			}
		}
		return -1;
	}

	public void C3554254475(int int_0, global::C3554254475.C3110715001 c3110715001_0)
	{
		if (int_0 < 0)
		{
			Debug.Assert(condition: false);
		}
		else if (c3110715001_0 == null)
		{
			Debug.Assert(condition: false);
		}
		else
		{
			this.m_C3554254475[int_0] = c3110715001_0;
		}
	}

	public void C3904355907(global::C3554254475.C3110715001 c3110715001_0)
	{
		if (c3110715001_0 == null)
		{
			Debug.Assert(condition: false);
			return;
		}
		int num = C3554254475(c3110715001_0);
		if (num < 0)
		{
			num = C1255198513();
			this.m_C3554254475[num] = c3110715001_0;
		}
	}

	public void C3554254475(C3664761504 c3664761504_0)
	{
		if (c3664761504_0 == null)
		{
			Debug.Assert(condition: false);
			return;
		}
		foreach (KeyValuePair<string, global::C3554254475.C3110715001> item in c3664761504_0)
		{
			C3904355907(item.Value);
		}
	}

	public global::C3554254475.C3110715001[] C1908338681()
	{
		int count = this.m_C3554254475.Count;
		global::C3554254475.C3110715001[] array = new global::C3554254475.C3110715001[count];
		foreach (KeyValuePair<int, global::C3554254475.C3110715001> item in this.m_C3554254475)
		{
			if (item.Key >= 0 && item.Key < count)
			{
				array[item.Key] = item.Value;
				continue;
			}
			Debug.Assert(condition: false);
			throw new InvalidOperationException();
		}
		for (int i = 0; i < count; i++)
		{
			if (array[i] == null)
			{
				Debug.Assert(condition: false);
				throw new InvalidOperationException();
			}
		}
		return array;
	}
}
