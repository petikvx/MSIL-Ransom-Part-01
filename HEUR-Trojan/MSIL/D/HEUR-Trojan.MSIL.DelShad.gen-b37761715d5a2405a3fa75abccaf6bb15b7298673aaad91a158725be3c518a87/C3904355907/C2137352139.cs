#define DEBUG
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;
using C3554254475;

namespace C3904355907;

public abstract class C2137352139 : IDisposable
{
	private bool m_C3554254475 = false;

	private byte[] m_C3554254475;

	private int m_C3554254475;

	[SpecialName]
	public abstract int C3554254475();

	public C2137352139()
	{
		int num = C3554254475();
		if (num <= 0)
		{
			throw new InvalidOperationException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cQ());
		}
		this.m_C3554254475 = new byte[num];
		this.m_C3554254475 = num;
	}

	public void Dispose()
	{
		C3554254475(bool_0: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void C3554254475(bool bool_0)
	{
		if (bool_0)
		{
			global::C3554254475.C2137352139.C3904355907(this.m_C3554254475);
			this.m_C3554254475 = this.m_C3554254475.Length;
			this.m_C3554254475 = true;
		}
	}

	protected void C3904355907()
	{
		this.m_C3554254475 = this.m_C3554254475.Length;
	}

	protected abstract void C3554254475(byte[] byte_0);

	public void C3554254475(byte[] byte_0, int int_0, int int_1)
	{
		if (this.m_C3554254475)
		{
			throw new ObjectDisposedException(null);
		}
		if (byte_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cq());
		}
		if (int_0 < 0)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C252678980());
		}
		if (int_1 < 0)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C1466425173());
		}
		if (int_0 > byte_0.Length - int_1)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C1466425173());
		}
		int num = this.m_C3554254475.Length;
		while (int_1 > 0)
		{
			Debug.Assert(this.m_C3554254475 <= num);
			if (this.m_C3554254475 == num)
			{
				C3554254475(this.m_C3554254475);
				this.m_C3554254475 = 0;
			}
			int num2 = Math.Min(num - this.m_C3554254475, int_1);
			Debug.Assert(num2 > 0);
			global::C3554254475.C2137352139.C3554254475(this.m_C3554254475, this.m_C3554254475, byte_0, int_0, num2);
			this.m_C3554254475 += num2;
			int_0 += num2;
			int_1 -= num2;
		}
	}

	public void C3904355907(byte[] byte_0, int int_0, int int_1)
	{
		C3554254475(byte_0, int_0, int_1);
	}
}
