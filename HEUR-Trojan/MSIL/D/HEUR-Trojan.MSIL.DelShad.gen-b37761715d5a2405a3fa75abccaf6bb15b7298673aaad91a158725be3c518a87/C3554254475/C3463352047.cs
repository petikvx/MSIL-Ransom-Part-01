#define DEBUG
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;

namespace C3554254475;

public sealed class C3463352047 : IDisposable
{
	private byte[] m_C3554254475;

	private byte[] m_C3904355907;

	[SpecialName]
	public uint C3554254475()
	{
		if (this.m_C3554254475 == null)
		{
			Debug.Assert(condition: false);
			throw new ObjectDisposedException(null);
		}
		return (uint)this.m_C3554254475.Length;
	}

	public C3463352047(byte[] byte_0, byte[] byte_1)
	{
		if (byte_0 == null)
		{
			Debug.Assert(condition: false);
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Bu());
		}
		if (byte_1 == null)
		{
			Debug.Assert(condition: false);
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.BV());
		}
		if (byte_0.Length != byte_1.Length)
		{
			Debug.Assert(condition: false);
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.BV());
		}
		this.m_C3554254475 = byte_0;
		this.m_C3904355907 = byte_1;
	}

	~C3463352047()
	{
		Debug.Assert(this.m_C3554254475 == null && this.m_C3904355907 == null);
	}

	public void Dispose()
	{
		if (this.m_C3554254475 != null)
		{
			C2137352139.C3904355907(this.m_C3554254475);
			this.m_C3554254475 = null;
			C2137352139.C3904355907(this.m_C3904355907);
			this.m_C3904355907 = null;
		}
	}

	public byte[] C3904355907()
	{
		byte[] c3554254475 = this.m_C3554254475;
		byte[] c3904355907 = this.m_C3904355907;
		if (c3554254475 == null || c3904355907 == null || c3554254475.Length != c3904355907.Length)
		{
			Debug.Assert(condition: false);
			throw new ObjectDisposedException(null);
		}
		byte[] array = new byte[c3554254475.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (byte)(c3554254475[i] ^ c3904355907[i]);
		}
		return array;
	}
}
