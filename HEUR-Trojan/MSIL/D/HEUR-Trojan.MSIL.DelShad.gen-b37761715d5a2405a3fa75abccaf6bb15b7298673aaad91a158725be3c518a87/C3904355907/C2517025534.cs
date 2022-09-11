#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;
using C3554254475;

namespace C3904355907;

public sealed class C2517025534 : IEquatable<C2517025534>, C453955339<C2517025534>
{
	private bool m_C3554254475 = true;

	private C140662621 m_C3554254475 = C140662621.C3554254475;

	private string m_C3554254475 = string.Empty;

	private List<C2909332022> m_C3554254475 = new List<C2909332022>();

	[SpecialName]
	public bool C3904355907()
	{
		return this.m_C3554254475;
	}

	[SpecialName]
	public void C3554254475(bool bool_0)
	{
		this.m_C3554254475 = bool_0;
	}

	[SpecialName]
	public C140662621 C1255198513()
	{
		return this.m_C3554254475;
	}

	[SpecialName]
	public void C3554254475(C140662621 c140662621_0)
	{
		this.m_C3554254475 = c140662621_0;
	}

	[SpecialName]
	public string C1908338681()
	{
		return this.m_C3554254475;
	}

	[SpecialName]
	public void C3554254475(string string_0)
	{
		Debug.Assert(string_0 != null);
		if (string_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C2517025534());
		}
		this.m_C3554254475 = string_0;
	}

	[SpecialName]
	public IEnumerable<C2909332022> C1037565863()
	{
		return this.m_C3554254475;
	}

	[SpecialName]
	public int C112844655()
	{
		return this.m_C3554254475.Count;
	}

	public void C2746444292()
	{
		this.m_C3554254475.Clear();
	}

	public C2517025534 C3554254475()
	{
		C2517025534 c2517025534 = new C2517025534();
		c2517025534.m_C3554254475 = this.m_C3554254475;
		c2517025534.m_C3554254475 = this.m_C3554254475;
		c2517025534.m_C3554254475 = this.m_C3554254475;
		foreach (C2909332022 item in this.m_C3554254475)
		{
			c2517025534.C3554254475(item.C3554254475());
		}
		return c2517025534;
	}

	public bool Equals(C2517025534 other)
	{
		if (other == null)
		{
			Debug.Assert(condition: false);
			return false;
		}
		if (this.m_C3554254475 != other.m_C3554254475)
		{
			return false;
		}
		if (this.m_C3554254475 != other.m_C3554254475)
		{
			return false;
		}
		if (this.m_C3554254475 != other.m_C3554254475)
		{
			return false;
		}
		if (this.m_C3554254475.Count != other.m_C3554254475.Count)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < this.m_C3554254475.Count)
			{
				if (!this.m_C3554254475[num].Equals(other.m_C3554254475[num]))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public C2909332022 C3554254475(int int_0)
	{
		if (int_0 < 0 || int_0 >= this.m_C3554254475.Count)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cS());
		}
		return this.m_C3554254475[int_0];
	}

	public void C3554254475(C2909332022 c2909332022_0)
	{
		if (c2909332022_0 == null)
		{
			Debug.Assert(condition: false);
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C1505515367());
		}
		this.m_C3554254475.Add(c2909332022_0);
	}

	public void C3554254475(int int_0, C2909332022 c2909332022_0)
	{
		if (int_0 < 0 || int_0 > this.m_C3554254475.Count)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cS());
		}
		if (c2909332022_0 == null)
		{
			Debug.Assert(condition: false);
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C1505515367());
		}
		this.m_C3554254475.Insert(int_0, c2909332022_0);
	}

	public void C3904355907(int int_0)
	{
		if (int_0 < 0 || int_0 >= this.m_C3554254475.Count)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cS());
		}
		this.m_C3554254475.RemoveAt(int_0);
	}
}
