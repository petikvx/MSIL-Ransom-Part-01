#define DEBUG
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;
using C3554254475;
using C3904355907;

namespace C1255198513;

public sealed class C1304234792 : global::C3904355907.C2013832146
{
	private new const string m_C3554254475 = "$UUID";

	private new readonly global::C3554254475.C3865851505 m_C3554254475;

	[SpecialName]
	public new global::C3554254475.C3865851505 C3554254475()
	{
		return this.m_C3554254475;
	}

	public C1304234792(global::C3554254475.C3865851505 c3865851505_0)
	{
		if (c3865851505_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.KL());
		}
		this.m_C3554254475 = c3865851505_0;
		C3554254475(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Kl(), c3865851505_0.C3554254475());
	}

	public override object Clone()
	{
		throw new NotSupportedException();
	}

	public static byte[] C3554254475(C1304234792 c1304234792_0)
	{
		return global::C3904355907.C2013832146.C3904355907(c1304234792_0);
	}

	public new static C1304234792 C3554254475(byte[] byte_0)
	{
		global::C3904355907.C2013832146 c = global::C3904355907.C2013832146.C3554254475(byte_0);
		if (c == null)
		{
			Debug.Assert(condition: false);
			return null;
		}
		byte[] array = c.C1908338681(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Kl());
		if (array == null || array.Length != 16)
		{
			Debug.Assert(condition: false);
			return null;
		}
		global::C3554254475.C3865851505 c3865851505_ = new global::C3554254475.C3865851505(array);
		C1304234792 c2 = new C1304234792(c3865851505_);
		c.C3554254475(c2);
		return c2;
	}
}
