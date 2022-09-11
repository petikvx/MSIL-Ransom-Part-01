#define DEBUG
using System;
using System.Diagnostics;
using System.Security.Cryptography;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;
using C1255198513;
using C3554254475;

namespace C3904355907;

public sealed class C3568589458 : IDisposable
{
	private readonly C2564639436 m_C3554254475;

	private bool m_C3554254475 = false;

	private byte[] m_C3554254475 = null;

	private byte m_C3554254475 = 0;

	private byte C3904355907 = 0;

	private C1255198513.C30677878 m_C3554254475 = null;

	private C1255198513.C1993550816 m_C3554254475 = null;

	public C3568589458(C2564639436 c2564639436_0, byte[] byte_0)
	{
		if (byte_0 == null)
		{
			Debug.Assert(condition: false);
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cA());
		}
		int num = byte_0.Length;
		if (num <= 0)
		{
			Debug.Assert(condition: false);
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cA());
		}
		this.m_C3554254475 = c2564639436_0;
		switch (c2564639436_0)
		{
		case C2564639436.C1908338681:
		{
			byte[] array = new byte[32];
			byte[] array2 = new byte[12];
			using (SHA512Managed sHA512Managed = new SHA512Managed())
			{
				byte[] array3 = sHA512Managed.ComputeHash(byte_0);
				Array.Copy(array3, array, 32);
				Array.Copy(array3, 32, array2, 0, 12);
				global::C3554254475.C2137352139.C3904355907(array3);
			}
			this.m_C3554254475 = new C1255198513.C1993550816(array, array2, bool_0: true);
			break;
		}
		case C2564639436.C1255198513:
		{
			byte[] byte_ = C1304234792.C3554254475(byte_0);
			byte[] byte_2 = new byte[8] { 232, 48, 9, 75, 151, 32, 93, 42 };
			this.m_C3554254475 = new C1255198513.C30677878(byte_, byte_2);
			break;
		}
		case C2564639436.C3904355907:
		{
			this.m_C3554254475 = new byte[256];
			for (int i = 0; i < 256; i++)
			{
				this.m_C3554254475[i] = (byte)i;
			}
			byte b = 0;
			int num2 = 0;
			for (int j = 0; j < 256; j++)
			{
				b = (byte)(b + (byte)(this.m_C3554254475[j] + byte_0[num2]));
				byte b2 = this.m_C3554254475[0];
				this.m_C3554254475[0] = this.m_C3554254475[b];
				this.m_C3554254475[b] = b2;
				num2++;
				if (num2 >= num)
				{
					num2 = 0;
				}
			}
			C3554254475(512u);
			break;
		}
		default:
			Debug.Assert(condition: false);
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C1505515367());
		}
	}

	public void Dispose()
	{
		C3554254475(bool_0: true);
		GC.SuppressFinalize(this);
	}

	private void C3554254475(bool bool_0)
	{
		if (bool_0)
		{
			if (this.m_C3554254475 == C2564639436.C1908338681)
			{
				this.m_C3554254475.Dispose();
			}
			else if (this.m_C3554254475 == C2564639436.C1255198513)
			{
				this.m_C3554254475.Dispose();
			}
			else if (this.m_C3554254475 == C2564639436.C3904355907)
			{
				global::C3554254475.C2137352139.C3904355907(this.m_C3554254475);
				this.m_C3554254475 = 0;
				C3904355907 = 0;
			}
			else
			{
				Debug.Assert(condition: false);
			}
			this.m_C3554254475 = true;
		}
	}

	public byte[] C3554254475(uint uint_0)
	{
		if (this.m_C3554254475)
		{
			throw new ObjectDisposedException(null);
		}
		if (uint_0 == 0)
		{
			return global::C3554254475.C2137352139.C3554254475;
		}
		if (uint_0 > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.ca());
		}
		byte[] array = new byte[uint_0];
		if (this.m_C3554254475 == C2564639436.C1908338681)
		{
			this.m_C3554254475.C3554254475(array, 0, (int)uint_0);
		}
		else if (this.m_C3554254475 == C2564639436.C1255198513)
		{
			this.m_C3554254475.C3554254475(array, 0, (int)uint_0);
		}
		else if (this.m_C3554254475 == C2564639436.C3904355907)
		{
			for (int i = 0; i < (int)uint_0; i++)
			{
				this.m_C3554254475++;
				C3904355907 += this.m_C3554254475[this.m_C3554254475];
				byte b = this.m_C3554254475[this.m_C3554254475];
				this.m_C3554254475[this.m_C3554254475] = this.m_C3554254475[C3904355907];
				this.m_C3554254475[C3904355907] = b;
				b = (byte)(this.m_C3554254475[this.m_C3554254475] + this.m_C3554254475[C3904355907]);
				array[i] = this.m_C3554254475[b];
			}
		}
		else
		{
			Debug.Assert(condition: false);
		}
		return array;
	}

	public ulong C3554254475()
	{
		byte[] byte_ = C3554254475(8u);
		return global::C3554254475.C2137352139.C1037565863(byte_);
	}

	internal ulong C3554254475(ulong ulong_0)
	{
		if (ulong_0 == 0L)
		{
			Debug.Assert(condition: false);
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cB());
		}
		ulong num;
		ulong num2;
		do
		{
			num = C3554254475();
			num2 = num % ulong_0;
		}
		while (num - num2 > (ulong)(-1L - (long)(ulong_0 - 1L)));
		return num2;
	}
}
