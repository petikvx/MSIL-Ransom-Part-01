using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;

namespace C3554254475;

public static class C1466425173
{
	private static readonly string[] m_C3554254475 = new string[1] { DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Ci() };

	private static string m_C3554254475 = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Ci();

	private static string C3554254475(Dictionary<string, string> dictionary_0, string string_0, string string_1)
	{
		if (dictionary_0.TryGetValue(string_0, out var value))
		{
			return value;
		}
		return string_1;
	}

	public static void C3554254475(Dictionary<string, string> dictionary_0)
	{
		if (dictionary_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Bv());
		}
		C1466425173.m_C3554254475 = C3554254475(dictionary_0, DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Ci(), C1466425173.m_C3554254475);
	}

	public static string[] C3554254475()
	{
		return C1466425173.m_C3554254475;
	}

	[SpecialName]
	public static string C3904355907()
	{
		return C1466425173.m_C3554254475;
	}
}
