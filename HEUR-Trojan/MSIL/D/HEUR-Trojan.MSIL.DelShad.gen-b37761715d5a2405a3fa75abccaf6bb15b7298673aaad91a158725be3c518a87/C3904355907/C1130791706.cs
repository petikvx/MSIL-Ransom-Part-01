#define DEBUG
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;
using C3554254475;

namespace C3904355907;

public sealed class C1130791706 : IEnumerable, C453955339<C1130791706>, IEnumerable<KeyValuePair<string, string>>, IEquatable<C1130791706>
{
	private SortedDictionary<string, string> m_C3554254475 = new SortedDictionary<string, string>();

	[SpecialName]
	public int C3904355907()
	{
		return this.m_C3554254475.Count;
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

	public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
	{
		return this.m_C3554254475.GetEnumerator();
	}

	public C1130791706 C3554254475()
	{
		C1130791706 c = new C1130791706();
		foreach (KeyValuePair<string, string> item in this.m_C3554254475)
		{
			c.m_C3554254475[item.Key] = item.Value;
		}
		return c;
	}

	public bool Equals(C1130791706 other)
	{
		if (other == null)
		{
			Debug.Assert(condition: false);
			return false;
		}
		if (this.m_C3554254475.Count != other.m_C3554254475.Count)
		{
			return false;
		}
		foreach (KeyValuePair<string, string> item in other.m_C3554254475)
		{
			string text = C3554254475(item.Key);
			if (text == null || text != item.Value)
			{
				return false;
			}
		}
		return true;
	}

	public string C3554254475(string string_0)
	{
		if (string_0 == null)
		{
			Debug.Assert(condition: false);
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C2363233923());
		}
		if (this.m_C3554254475.TryGetValue(string_0, out var value))
		{
			return value;
		}
		return null;
	}

	public bool C3904355907(string string_0)
	{
		if (string_0 == null)
		{
			Debug.Assert(condition: false);
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C2363233923());
		}
		return this.m_C3554254475.ContainsKey(string_0);
	}

	public void C3554254475(string string_0, string string_1)
	{
		if (string_0 == null)
		{
			Debug.Assert(condition: false);
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cs());
		}
		if (string_1 == null)
		{
			Debug.Assert(condition: false);
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ct());
		}
		this.m_C3554254475[string_0] = string_1;
	}

	public bool C1255198513(string string_0)
	{
		if (string_0 == null)
		{
			Debug.Assert(condition: false);
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cs());
		}
		return this.m_C3554254475.Remove(string_0);
	}
}
