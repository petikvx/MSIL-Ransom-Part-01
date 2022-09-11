#define DEBUG
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;

namespace C3554254475;

public sealed class C2517025534
{
	private readonly string m_C3554254475;

	private int m_C3554254475 = 0;

	[SpecialName]
	public long C3554254475()
	{
		return this.m_C3554254475;
	}

	[SpecialName]
	public void C3554254475(long long_0)
	{
		if (long_0 < 0L || long_0 > 2147483647L)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C2517025534());
		}
		this.m_C3554254475 = (int)long_0;
	}

	public C2517025534(string string_0)
	{
		if (string_0 == null)
		{
			Debug.Assert(condition: false);
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C3081909835());
		}
		this.m_C3554254475 = string_0;
	}

	public char C3904355907()
	{
		if (this.m_C3554254475 >= this.m_C3554254475.Length)
		{
			return '\0';
		}
		return this.m_C3554254475[this.m_C3554254475++];
	}

	public char C3554254475(bool bool_0)
	{
		if (!bool_0)
		{
			return C3904355907();
		}
		char c;
		do
		{
			c = C3904355907();
		}
		while (c == ' ' || c == '\t' || c == '\r' || c == '\n');
		return c;
	}

	public char C1255198513()
	{
		if (this.m_C3554254475 >= this.m_C3554254475.Length)
		{
			return '\0';
		}
		return this.m_C3554254475[this.m_C3554254475];
	}

	public char C3904355907(bool bool_0)
	{
		if (!bool_0)
		{
			return C1255198513();
		}
		int num = this.m_C3554254475;
		char c;
		while (true)
		{
			if (num < this.m_C3554254475.Length)
			{
				c = this.m_C3554254475[num];
				if (c != ' ' && c != '\t' && c != '\r' && c != '\n')
				{
					break;
				}
				num++;
				continue;
			}
			return '\0';
		}
		return c;
	}
}
