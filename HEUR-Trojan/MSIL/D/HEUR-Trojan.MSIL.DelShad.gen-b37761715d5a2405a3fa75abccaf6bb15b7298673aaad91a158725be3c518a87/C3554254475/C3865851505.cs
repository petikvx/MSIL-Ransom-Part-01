#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;

namespace C3554254475;

public sealed class C3865851505 : IComparable<C3865851505>, IEquatable<C3865851505>
{
	[Serializable]
	[CompilerGenerated]
	private sealed class C3554254475
	{
		public static readonly C3554254475 C3554254475 = new C3554254475();

		public static Predicate<byte> C3554254475;

		internal bool C3554254475(byte byte_0)
		{
			return byte_0 == 0;
		}
	}

	public const uint C3554254475 = 16u;

	public static readonly C3865851505 C3554254475 = new C3865851505(bool_0: false);

	private byte[] m_C3554254475 = null;

	private int m_C3554254475 = 0;

	[SpecialName]
	public byte[] C3554254475()
	{
		return this.m_C3554254475;
	}

	public C3865851505(bool bool_0)
	{
		if (bool_0)
		{
			C3904355907();
		}
		else
		{
			C1255198513();
		}
	}

	public C3865851505(byte[] byte_0)
	{
		C3554254475(byte_0);
	}

	private void C3904355907()
	{
		Debug.Assert(this.m_C3554254475 == null);
		while (true)
		{
			this.m_C3554254475 = Guid.NewGuid().ToByteArray();
			if (this.m_C3554254475 != null && this.m_C3554254475.Length == 16)
			{
				if (Equals(C3865851505.C3554254475))
				{
					Debug.Assert(condition: false);
					continue;
				}
				break;
			}
			Debug.Assert(condition: false);
			throw new InvalidOperationException();
		}
	}

	private void C3554254475(byte[] byte_0)
	{
		Debug.Assert(byte_0 != null && byte_0.Length == 16);
		if (byte_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C3664761504());
		}
		if (byte_0.Length != 16)
		{
			throw new ArgumentException();
		}
		Debug.Assert(this.m_C3554254475 == null);
		this.m_C3554254475 = new byte[16];
		Array.Copy(byte_0, this.m_C3554254475, 16);
	}

	private void C1255198513()
	{
		Debug.Assert(this.m_C3554254475 == null);
		this.m_C3554254475 = new byte[16];
		List<byte> list = new List<byte>(this.m_C3554254475);
		Debug.Assert(list.TrueForAll((byte byte_0) => byte_0 == 0));
	}

	[Obsolete]
	public bool C3554254475(C3865851505 c3865851505_0)
	{
		return Equals(c3865851505_0);
	}

	public override bool Equals(object obj)
	{
		return Equals(obj as C3865851505);
	}

	public bool Equals(C3865851505 other)
	{
		if (other == null)
		{
			Debug.Assert(condition: false);
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < 16)
			{
				if (this.m_C3554254475[num] != other.m_C3554254475[num])
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

	public override int GetHashCode()
	{
		if (this.m_C3554254475 == 0)
		{
			this.m_C3554254475 = (int)C2137352139.C3554254475(this.m_C3554254475, 0, this.m_C3554254475.Length);
		}
		return this.m_C3554254475;
	}

	public int CompareTo(C3865851505 other)
	{
		if (other == null)
		{
			Debug.Assert(condition: false);
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C3775001192());
		}
		int num = 0;
		while (true)
		{
			if (num < 16)
			{
				if (this.m_C3554254475[num] >= other.m_C3554254475[num])
				{
					if (this.m_C3554254475[num] > other.m_C3554254475[num])
					{
						break;
					}
					num++;
					continue;
				}
				return -1;
			}
			return 0;
		}
		return 1;
	}

	public string C1908338681()
	{
		return C2137352139.C3554254475(this.m_C3554254475);
	}

	public override string ToString()
	{
		return C1908338681();
	}
}
