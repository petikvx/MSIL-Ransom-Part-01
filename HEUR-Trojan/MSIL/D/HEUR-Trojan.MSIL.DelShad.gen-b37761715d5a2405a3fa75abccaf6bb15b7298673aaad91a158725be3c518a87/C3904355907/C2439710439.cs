#define DEBUG
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using C1255198513;
using C3554254475;

namespace C3904355907;

public static class C2439710439
{
	private static List<C2852464175> m_C3554254475 = new List<C2852464175>();

	[SpecialName]
	public static IEnumerable<C2852464175> C3554254475()
	{
		C3904355907();
		return C2439710439.m_C3554254475;
	}

	private static void C3904355907()
	{
		if (C2439710439.m_C3554254475.Count <= 0)
		{
			C2439710439.m_C3554254475.Add(new global::C1255198513.C3568589458());
			C2439710439.m_C3554254475.Add(new global::C1255198513.C4024072794());
		}
	}

	internal static global::C1255198513.C1304234792 C1255198513()
	{
		C3904355907();
		return C2439710439.m_C3554254475[0].C1255198513();
	}

	public static C2852464175 C3554254475(global::C3554254475.C3865851505 c3865851505_0)
	{
		if (c3865851505_0 == null)
		{
			Debug.Assert(condition: false);
			return null;
		}
		C3904355907();
		foreach (C2852464175 item in C2439710439.m_C3554254475)
		{
			if (c3865851505_0.Equals(item.C3554254475()))
			{
				return item;
			}
		}
		return null;
	}

	public static C2852464175 C3554254475(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			Debug.Assert(condition: false);
			return null;
		}
		C3904355907();
		foreach (C2852464175 item in C2439710439.m_C3554254475)
		{
			if (string_0.Equals(item.C3904355907(), global::C3554254475.C1130791706.C3554254475))
			{
				return item;
			}
		}
		return null;
	}

	public static void C3554254475(C2852464175 c2852464175_0)
	{
		if (c2852464175_0 == null)
		{
			Debug.Assert(condition: false);
			return;
		}
		C3904355907();
		if (C3554254475(c2852464175_0.C3554254475()) != null)
		{
			Debug.Assert(condition: false);
		}
		else if (C3554254475(c2852464175_0.C3904355907()) != null)
		{
			Debug.Assert(condition: false);
		}
		else
		{
			C2439710439.m_C3554254475.Add(c2852464175_0);
		}
	}
}
