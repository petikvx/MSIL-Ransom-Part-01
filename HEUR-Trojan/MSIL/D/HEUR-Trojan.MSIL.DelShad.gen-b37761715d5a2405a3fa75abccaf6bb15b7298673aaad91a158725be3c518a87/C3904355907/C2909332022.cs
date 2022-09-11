#define DEBUG
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;
using C3554254475;

namespace C3904355907;

public sealed class C2909332022 : IEquatable<C2909332022>, C453955339<C2909332022>
{
	private string m_C3554254475 = string.Empty;

	private string m_C3904355907 = string.Empty;

	[SpecialName]
	public string C3904355907()
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
	public string C1255198513()
	{
		return this.m_C3904355907;
	}

	[SpecialName]
	public void C3904355907(string string_0)
	{
		Debug.Assert(string_0 != null);
		if (string_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C2517025534());
		}
		this.m_C3904355907 = string_0;
	}

	public C2909332022()
	{
	}

	public C2909332022(string string_0, string string_1)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cR());
		}
		if (string_1 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cr());
		}
		this.m_C3554254475 = string_0;
		this.m_C3904355907 = string_1;
	}

	public bool Equals(C2909332022 other)
	{
		if (other == null)
		{
			return false;
		}
		if (this.m_C3554254475 != other.m_C3554254475)
		{
			return false;
		}
		if (this.m_C3904355907 != other.m_C3904355907)
		{
			return false;
		}
		return true;
	}

	public C2909332022 C3554254475()
	{
		return (C2909332022)MemberwiseClone();
	}
}
