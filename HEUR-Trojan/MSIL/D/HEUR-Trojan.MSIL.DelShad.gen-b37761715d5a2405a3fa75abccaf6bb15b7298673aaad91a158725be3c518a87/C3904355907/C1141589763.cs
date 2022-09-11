#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;
using C1255198513;
using C3554254475;

namespace C3904355907;

[DefaultMember("Item")]
public sealed class C1141589763
{
	private List<C856455061> m_C3554254475 = new List<C856455061>();

	private static C1141589763 m_C3554254475;

	[SpecialName]
	public static C1141589763 C3554254475()
	{
		C1141589763 c = C1141589763.m_C3554254475;
		if (c == null)
		{
			c = new C1141589763();
			c.C3554254475(new global::C1255198513.C2852464175());
			c.C3554254475(new global::C1255198513.C3463352047());
			C1141589763.m_C3554254475 = c;
		}
		return c;
	}

	public void C3904355907()
	{
		this.m_C3554254475.Clear();
	}

	public void C3554254475(C856455061 c856455061_0)
	{
		if (c856455061_0 == null)
		{
			Debug.Assert(condition: false);
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cP());
		}
		foreach (C856455061 item in this.m_C3554254475)
		{
			if (item.C3554254475().Equals(c856455061_0.C3554254475()))
			{
				return;
			}
		}
		this.m_C3554254475.Add(c856455061_0);
	}

	public C856455061 C3554254475(global::C3554254475.C3865851505 c3865851505_0)
	{
		foreach (C856455061 item in this.m_C3554254475)
		{
			if (item.C3554254475().Equals(c3865851505_0))
			{
				return item;
			}
		}
		return null;
	}

	public int C3904355907(global::C3554254475.C3865851505 c3865851505_0)
	{
		int num = 0;
		while (true)
		{
			if (num < this.m_C3554254475.Count)
			{
				if (this.m_C3554254475[num].C3554254475().Equals(c3865851505_0))
				{
					break;
				}
				num++;
				continue;
			}
			Debug.Assert(condition: false);
			return -1;
		}
		return num;
	}

	public int C3554254475(string string_0)
	{
		int num = 0;
		while (true)
		{
			if (num < this.m_C3554254475.Count)
			{
				if (this.m_C3554254475[num].C3904355907() == string_0)
				{
					break;
				}
				num++;
				continue;
			}
			Debug.Assert(condition: false);
			return -1;
		}
		return num;
	}

	[SpecialName]
	public int C1255198513()
	{
		return this.m_C3554254475.Count;
	}

	[SpecialName]
	public C856455061 C3554254475(int int_0)
	{
		if (int_0 < 0 || int_0 >= this.m_C3554254475.Count)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cp());
		}
		return this.m_C3554254475[int_0];
	}
}
