#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;

namespace C3904355907;

[DefaultMember("Item")]
public sealed class C30677878
{
	public static readonly string C3554254475 = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ch();

	public static readonly string C3904355907 = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cI();

	public static readonly string C1255198513 = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ci();

	public static readonly string C1908338681 = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cJ();

	public static readonly string C1037565863 = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cj();

	public static readonly string C112844655 = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cK();

	public static readonly string C2746444292 = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ck();

	public static readonly string C2564639436 = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cL();

	public static readonly string C3568589458 = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cl();

	public static readonly string C4024072794 = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cM();

	public static readonly string C1304234792 = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cm();

	public static readonly string C1993550816 = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cN();

	public static readonly string C985283518 = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cn();

	internal static readonly string C30677878 = global::C3904355907.C30677878.C3904355907 + global::C3904355907.C30677878.C1255198513;

	private const int m_C3554254475 = 8192;

	private List<char> m_C3554254475 = new List<char>();

	private byte[] m_C3554254475 = new byte[8192];

	private static string C2852464175 = null;

	private static string C2439710439 = null;

	[SpecialName]
	public static string C3554254475()
	{
		if (C2852464175 == null)
		{
			new C30677878();
		}
		Debug.Assert(C2852464175 != null);
		return C2852464175;
	}

	[SpecialName]
	public static string C3904355907()
	{
		if (C2439710439 == null)
		{
			new C30677878();
		}
		Debug.Assert(C2439710439 != null);
		return C2439710439;
	}

	public C30677878()
	{
		C3554254475(bool_0: true);
	}

	public C30677878(string string_0)
	{
		C3554254475(bool_0: true);
		C3904355907(string_0);
	}

	private C30677878(bool bool_0)
	{
		C3554254475(bool_0);
	}

	private void C3554254475(bool bool_0)
	{
		C1908338681();
		if (!bool_0)
		{
			return;
		}
		if (C2852464175 == null)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (char c = '¡'; c <= '¬'; c = (char)(c + 1))
			{
				stringBuilder.Append(c);
			}
			for (char c2 = '®'; c2 < 'ÿ'; c2 = (char)(c2 + 1))
			{
				stringBuilder.Append(c2);
			}
			stringBuilder.Append('ÿ');
			C2852464175 = stringBuilder.ToString();
		}
		if (C2439710439 == null)
		{
			C30677878 c3 = new C30677878(bool_0: false);
			c3.C3554254475('!', '/');
			c3.C3554254475(':', '@');
			c3.C3554254475('[', '`');
			c3.C3904355907(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cE());
			c3.C1255198513(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ce());
			c3.C1255198513(C3568589458);
			C2439710439 = c3.ToString();
		}
	}

	[SpecialName]
	public uint C1255198513()
	{
		return (uint)this.m_C3554254475.Count;
	}

	[SpecialName]
	public char C3554254475(uint uint_0)
	{
		if (uint_0 >= (uint)this.m_C3554254475.Count)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cF());
		}
		return this.m_C3554254475[(int)uint_0];
	}

	public void C1908338681()
	{
		this.m_C3554254475.Clear();
		Array.Clear(this.m_C3554254475, 0, this.m_C3554254475.Length);
	}

	public bool C3554254475(char char_0)
	{
		return ((this.m_C3554254475[(int)char_0 / 8] >> (int)char_0 % 8) & 1) != 0;
	}

	public bool C3554254475(string string_0)
	{
		Debug.Assert(string_0 != null);
		if (string_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cf());
		}
		int num = 0;
		while (true)
		{
			if (num < string_0.Length)
			{
				char char_ = string_0[num];
				if (!C3554254475(char_))
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

	public void C3904355907(char char_0)
	{
		if (char_0 == '\0')
		{
			Debug.Assert(condition: false);
		}
		else if (!C3554254475(char_0))
		{
			this.m_C3554254475.Add(char_0);
			this.m_C3554254475[(int)char_0 / 8] |= (byte)(1 << (int)char_0 % 8);
		}
	}

	public void C3904355907(string string_0)
	{
		Debug.Assert(string_0 != null);
		if (string_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cG());
		}
		this.m_C3554254475.Capacity = this.m_C3554254475.Count + string_0.Length;
		foreach (char char_ in string_0)
		{
			C3904355907(char_);
		}
	}

	public void C3554254475(string string_0, string string_1)
	{
		C3904355907(string_0);
		C3904355907(string_1);
	}

	public void C3554254475(string string_0, string string_1, string string_2)
	{
		C3904355907(string_0);
		C3904355907(string_1);
		C3904355907(string_2);
	}

	public void C3554254475(char char_0, char char_1)
	{
		this.m_C3554254475.Capacity = this.m_C3554254475.Count + (char_1 - char_0) + 1;
		for (char c = char_0; c < char_1; c = (char)(c + 1))
		{
			C3904355907(c);
		}
		C3904355907(char_1);
	}

	public bool C1255198513(char char_0)
	{
		bool result = true;
		switch (char_0)
		{
		case 'C':
			C3554254475(global::C3904355907.C30677878.C1037565863, global::C3904355907.C30677878.C1908338681);
			break;
		case 'A':
			C3554254475(global::C3904355907.C30677878.C3904355907, global::C3904355907.C30677878.C3554254475, global::C3904355907.C30677878.C1255198513);
			break;
		case 'L':
			C3554254475(global::C3904355907.C30677878.C3904355907, global::C3904355907.C30677878.C3554254475);
			break;
		case 'H':
			C3904355907(C1304234792);
			break;
		case 'Z':
			C3904355907(C112844655);
			break;
		case 'S':
			C3554254475(global::C3904355907.C30677878.C3554254475, global::C3904355907.C30677878.C3904355907);
			C3554254475(global::C3904355907.C30677878.C1255198513, C4024072794);
			break;
		case 'U':
			C3554254475(global::C3904355907.C30677878.C3554254475, global::C3904355907.C30677878.C1255198513);
			break;
		case 'V':
			C3554254475(C2746444292, C112844655);
			break;
		case 'p':
			C3904355907(C2564639436);
			break;
		case 's':
			C3904355907(C4024072794);
			break;
		case 'u':
			C3904355907(global::C3904355907.C30677878.C3554254475);
			break;
		case 'v':
			C3904355907(C2746444292);
			break;
		case 'x':
			C3904355907(C2852464175);
			break;
		case 'z':
			C3904355907(global::C3904355907.C30677878.C1908338681);
			break;
		case 'l':
			C3904355907(global::C3904355907.C30677878.C3904355907);
			break;
		case 'a':
			C3554254475(global::C3904355907.C30677878.C3904355907, global::C3904355907.C30677878.C1255198513);
			break;
		case 'b':
			C3904355907(C3568589458);
			break;
		case 'c':
			C3904355907(global::C3904355907.C30677878.C1037565863);
			break;
		case 'd':
			C3904355907(global::C3904355907.C30677878.C1255198513);
			break;
		default:
			result = false;
			break;
		case 'h':
			C3904355907(C1993550816);
			break;
		}
		return result;
	}

	public bool C1908338681(char char_0)
	{
		this.m_C3554254475[(int)char_0 / 8] &= (byte)(~(1 << (int)char_0 % 8));
		return this.m_C3554254475.Remove(char_0);
	}

	public bool C1255198513(string string_0)
	{
		Debug.Assert(string_0 != null);
		if (string_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cf());
		}
		bool result = true;
		foreach (char char_ in string_0)
		{
			if (!C1908338681(char_))
			{
				result = false;
			}
		}
		return result;
	}

	public bool C1908338681(string string_0)
	{
		Debug.Assert(string_0 != null);
		if (string_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cf());
		}
		if (!C3554254475(string_0))
		{
			return false;
		}
		return C1255198513(string_0);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char item in this.m_C3554254475)
		{
			stringBuilder.Append(item);
		}
		return stringBuilder.ToString();
	}

	public string C1037565863()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(C1908338681(global::C3904355907.C30677878.C3554254475) ? 'U' : '_');
		stringBuilder.Append(C1908338681(global::C3904355907.C30677878.C3904355907) ? 'L' : '_');
		stringBuilder.Append(C1908338681(global::C3904355907.C30677878.C1255198513) ? 'D' : '_');
		stringBuilder.Append(C1908338681(C2439710439) ? 'S' : '_');
		stringBuilder.Append(C1908338681(C2564639436) ? 'P' : '_');
		stringBuilder.Append(C1908338681(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cg()) ? 'm' : '_');
		stringBuilder.Append(C1908338681(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cH()) ? 'u' : '_');
		stringBuilder.Append(C1908338681(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.aj()) ? 's' : '_');
		stringBuilder.Append(C1908338681(C3568589458) ? 'B' : '_');
		stringBuilder.Append(C1908338681(C2852464175) ? 'H' : '_');
		return stringBuilder.ToString();
	}

	public void C1037565863(string string_0)
	{
		if (string_0 == null)
		{
			Debug.Assert(condition: false);
			return;
		}
		if (string_0.Length < 10)
		{
			Debug.Assert(condition: false);
			return;
		}
		if (string_0[0] != '_')
		{
			C3904355907(global::C3904355907.C30677878.C3554254475);
		}
		if (string_0[1] != '_')
		{
			C3904355907(global::C3904355907.C30677878.C3904355907);
		}
		if (string_0[2] != '_')
		{
			C3904355907(global::C3904355907.C30677878.C1255198513);
		}
		if (string_0[3] != '_')
		{
			C3904355907(C2439710439);
		}
		if (string_0[4] != '_')
		{
			C3904355907(C2564639436);
		}
		if (string_0[5] != '_')
		{
			C3904355907('-');
		}
		if (string_0[6] != '_')
		{
			C3904355907('_');
		}
		if (string_0[7] != '_')
		{
			C3904355907(' ');
		}
		if (string_0[8] != '_')
		{
			C3904355907(C3568589458);
		}
		if (string_0[9] != '_')
		{
			C3904355907(C2852464175);
		}
	}
}
