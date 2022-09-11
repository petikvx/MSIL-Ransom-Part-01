#define DEBUG
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;
using C3554254475;

namespace C3904355907;

public sealed class C3664761504 : IEnumerable, C453955339<C3664761504>, IEnumerable<KeyValuePair<string, global::C3554254475.C3110715001>>
{
	private SortedDictionary<string, global::C3554254475.C3110715001> m_C3554254475 = new SortedDictionary<string, global::C3554254475.C3110715001>();

	[SpecialName]
	public uint C3904355907()
	{
		return (uint)this.m_C3554254475.Count;
	}

	private IEnumerator C1255198513()
	{
		return this.m_C3554254475.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in C1255198513
		return this.C1255198513();
	}

	public IEnumerator<KeyValuePair<string, global::C3554254475.C3110715001>> GetEnumerator()
	{
		return this.m_C3554254475.GetEnumerator();
	}

	public void C1908338681()
	{
		this.m_C3554254475.Clear();
	}

	public C3664761504 C3554254475()
	{
		C3664761504 c3664761504 = new C3664761504();
		foreach (KeyValuePair<string, global::C3554254475.C3110715001> item in this.m_C3554254475)
		{
			c3664761504.C3554254475(item.Key, item.Value);
		}
		return c3664761504;
	}

	public bool C3554254475(C3664761504 c3664761504_0)
	{
		if (c3664761504_0 == null)
		{
			Debug.Assert(condition: false);
			return false;
		}
		if (this.m_C3554254475.Count != c3664761504_0.m_C3554254475.Count)
		{
			return false;
		}
		foreach (KeyValuePair<string, global::C3554254475.C3110715001> item in this.m_C3554254475)
		{
			global::C3554254475.C3110715001 c3110715001 = c3664761504_0.C3554254475(item.Key);
			if (c3110715001 != null)
			{
				if (!c3110715001.Equals(item.Value))
				{
					return false;
				}
				continue;
			}
			return false;
		}
		return true;
	}

	public global::C3554254475.C3110715001 C3554254475(string string_0)
	{
		Debug.Assert(string_0 != null);
		if (string_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C2363233923());
		}
		if (this.m_C3554254475.TryGetValue(string_0, out var value))
		{
			return value;
		}
		return null;
	}

	public void C3554254475(string string_0, global::C3554254475.C3110715001 c3110715001_0)
	{
		Debug.Assert(string_0 != null);
		if (string_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cs());
		}
		Debug.Assert(c3110715001_0 != null);
		if (c3110715001_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cT());
		}
		this.m_C3554254475[string_0] = c3110715001_0;
	}

	public bool C3904355907(string string_0)
	{
		Debug.Assert(string_0 != null);
		if (string_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cs());
		}
		return this.m_C3554254475.Remove(string_0);
	}

	public string C1037565863()
	{
		if (this.m_C3554254475.Count == 0)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (KeyValuePair<string, global::C3554254475.C3110715001> item in this.m_C3554254475)
		{
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.BD());
			}
			stringBuilder.Append(item.Key);
		}
		return stringBuilder.ToString();
	}
}
