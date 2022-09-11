#define DEBUG
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;
using C1255198513;
using C3904355907;

namespace C3554254475;

public sealed class C3110715001 : IEquatable<C3110715001>
{
	private enum C3554254475
	{
		C3554254475,
		C3904355907,
		C1255198513,
		C1908338681
	}

	private const int m_C3554254475 = 16;

	private static C252678980 m_C3554254475;

	private C252678980 m_C3904355907 = null;

	private static bool? m_C3554254475;

	private static long m_C3554254475;

	private long m_C3904355907;

	private byte[] m_C3554254475;

	private uint m_C3554254475;

	private bool m_C3554254475;

	private C3554254475 m_C3554254475 = C3110715001.C3554254475.C3554254475;

	private readonly object m_C3554254475 = new object();

	private static byte[] m_C3904355907;

	private int? m_C3554254475 = null;

	[SpecialName]
	public static C252678980 C3554254475()
	{
		return C3110715001.m_C3554254475;
	}

	[SpecialName]
	public static void C3554254475(C252678980 c252678980_0)
	{
		C3110715001.m_C3554254475 = c252678980_0;
	}

	[SpecialName]
	private static bool C3904355907()
	{
		bool? c3554254475 = C3110715001.m_C3554254475;
		if (c3554254475.HasValue)
		{
			return c3554254475.Value;
		}
		if (C1812594589.C1908338681())
		{
			C3110715001.m_C3554254475 = false;
			return false;
		}
		c3554254475 = false;
		try
		{
			byte[] array = new byte[48];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (byte)i;
			}
			ProtectedMemory.Protect(array, (MemoryProtectionScope)0);
			for (int j = 0; j < array.Length; j++)
			{
				if (array[j] != (byte)j)
				{
					c3554254475 = true;
					break;
				}
			}
		}
		catch (Exception)
		{
		}
		C3110715001.m_C3554254475 = c3554254475;
		return c3554254475.Value;
	}

	[SpecialName]
	public bool C1255198513()
	{
		return this.m_C3554254475;
	}

	[SpecialName]
	public uint C1908338681()
	{
		return this.m_C3554254475;
	}

	public C3110715001()
	{
		C3554254475(bool_0: false, C2137352139.C3554254475, 0, 0);
	}

	public C3110715001(bool bool_0, byte[] byte_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C2238339752());
		}
		C3554254475(bool_0, byte_0, 0, byte_0.Length);
	}

	public C3110715001(bool bool_0, byte[] byte_0, int int_0, int int_1)
	{
		C3554254475(bool_0, byte_0, int_0, int_1);
	}

	public C3110715001(bool bool_0, C3463352047 c3463352047_0)
	{
		if (c3463352047_0 == null)
		{
			Debug.Assert(condition: false);
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Bq());
		}
		byte[] array = c3463352047_0.C3904355907();
		try
		{
			C3554254475(bool_0, array, 0, array.Length);
		}
		finally
		{
			if (bool_0)
			{
				C2137352139.C3904355907(array);
			}
		}
	}

	private void C3554254475(bool bool_0, byte[] byte_0, int int_0, int int_1)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C2238339752());
		}
		if (int_0 < 0)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C252678980());
		}
		if (int_1 < 0)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.BR());
		}
		if (int_0 > byte_0.Length - int_1)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.BR());
		}
		this.m_C3904355907 = Interlocked.Increment(ref C3110715001.m_C3554254475);
		this.m_C3554254475 = bool_0;
		this.m_C3554254475 = (uint)int_1;
		int num = int_1 / 16;
		if (num * 16 < int_1)
		{
			num++;
		}
		Debug.Assert(num * 16 >= int_1);
		this.m_C3554254475 = new byte[num * 16];
		Array.Copy(byte_0, int_0, this.m_C3554254475, 0, int_1);
		C1037565863();
	}

	private void C1037565863()
	{
		Debug.Assert(this.m_C3554254475 == C3110715001.C3554254475.C3554254475);
		if (!this.m_C3554254475 || this.m_C3554254475.Length == 0)
		{
			return;
		}
		C252678980 c3554254475 = C3110715001.m_C3554254475;
		if (c3554254475 != null)
		{
			c3554254475(this.m_C3554254475, C878818188.C3904355907, this.m_C3904355907);
			this.m_C3904355907 = c3554254475;
			this.m_C3554254475 = C3110715001.C3554254475.C1908338681;
			return;
		}
		if (C3904355907())
		{
			ProtectedMemory.Protect(this.m_C3554254475, (MemoryProtectionScope)0);
			this.m_C3554254475 = C3110715001.C3554254475.C3904355907;
			return;
		}
		byte[] array = C3110715001.m_C3904355907;
		if (array == null)
		{
			array = C2564639436();
			byte[] array2 = Interlocked.Exchange(ref C3110715001.m_C3904355907, array);
			if (array2 != null)
			{
				array = array2;
			}
		}
		byte[] array3 = new byte[12];
		C2137352139.C3554254475((ulong)this.m_C3904355907, array3, 4);
		using (global::C1255198513.C1993550816 c = new global::C1255198513.C1993550816(array, array3, bool_0: true))
		{
			c.C3554254475(this.m_C3554254475, 0, this.m_C3554254475.Length);
		}
		this.m_C3554254475 = C3110715001.C3554254475.C1255198513;
	}

	private void C112844655()
	{
		if (this.m_C3554254475.Length == 0)
		{
			return;
		}
		if (this.m_C3554254475 == C3110715001.C3554254475.C3904355907)
		{
			ProtectedMemory.Unprotect(this.m_C3554254475, (MemoryProtectionScope)0);
		}
		else if (this.m_C3554254475 == C3110715001.C3554254475.C1255198513)
		{
			byte[] array = new byte[12];
			C2137352139.C3554254475((ulong)this.m_C3904355907, array, 4);
			using global::C1255198513.C1993550816 c = new global::C1255198513.C1993550816(C3110715001.m_C3904355907, array, bool_0: true);
			c.C3904355907(this.m_C3554254475, 0, this.m_C3554254475.Length);
		}
		else if (this.m_C3554254475 == C3110715001.C3554254475.C1908338681)
		{
			this.m_C3904355907(this.m_C3554254475, C878818188.C1255198513, this.m_C3904355907);
		}
		else
		{
			Debug.Assert(this.m_C3554254475 == C3110715001.C3554254475.C3554254475);
		}
		this.m_C3554254475 = C3110715001.C3554254475.C3554254475;
	}

	public byte[] C2746444292()
	{
		if (this.m_C3554254475 == 0)
		{
			return C2137352139.C3554254475;
		}
		byte[] array = new byte[this.m_C3554254475];
		lock (this.m_C3554254475)
		{
			C112844655();
			Array.Copy(this.m_C3554254475, array, (int)this.m_C3554254475);
			C1037565863();
		}
		return array;
	}

	public byte[] C3554254475(global::C3904355907.C3568589458 c3568589458_0)
	{
		if (c3568589458_0 == null)
		{
			Debug.Assert(condition: false);
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Br());
		}
		byte[] array = C2746444292();
		int num = array.Length;
		byte[] array2 = c3568589458_0.C3554254475((uint)num);
		Debug.Assert(array2.Length == num);
		for (int i = 0; i < num; i++)
		{
			array[i] ^= array2[i];
		}
		C2137352139.C3904355907(array2);
		return array;
	}

	public override int GetHashCode()
	{
		if (this.m_C3554254475.HasValue)
		{
			return this.m_C3554254475.Value;
		}
		int num = (this.m_C3554254475 ? 2064765577 : 0);
		byte[] array = C2746444292();
		for (int i = 0; i < array.Length; i++)
		{
			num = (num << 3) + num + array[i];
		}
		if (this.m_C3554254475)
		{
			C2137352139.C3904355907(array);
		}
		this.m_C3554254475 = num;
		return num;
	}

	public override bool Equals(object obj)
	{
		return C3554254475(obj as C3110715001, bool_0: true);
	}

	public bool Equals(C3110715001 other)
	{
		return C3554254475(other, bool_0: true);
	}

	public bool C3554254475(C3110715001 c3110715001_0, bool bool_0)
	{
		if (c3110715001_0 == null)
		{
			return false;
		}
		if (this == c3110715001_0)
		{
			return true;
		}
		if (bool_0 && this.m_C3554254475 != c3110715001_0.m_C3554254475)
		{
			return false;
		}
		if (this.m_C3554254475 != c3110715001_0.m_C3554254475)
		{
			return false;
		}
		byte[] byte_ = C2746444292();
		byte[] array = null;
		bool result;
		try
		{
			array = c3110715001_0.C2746444292();
			result = C2137352139.C3554254475(byte_, array);
		}
		finally
		{
			if (this.m_C3554254475)
			{
				C2137352139.C3904355907(byte_);
			}
			if (c3110715001_0.m_C3554254475 && array != null)
			{
				C2137352139.C3904355907(array);
			}
		}
		return result;
	}

	private static byte[] C2564639436()
	{
		byte[] array = new byte[60];
		int num = 0;
		try
		{
			RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
			byte[] array2 = new byte[32];
			rNGCryptoServiceProvider.GetBytes(array2);
			Array.Copy(array2, 0, array, num, 32);
			num += 32;
			C2137352139.C3904355907(array2);
			C2137352139.C3554254475(rNGCryptoServiceProvider);
		}
		catch (Exception)
		{
			Debug.Assert(condition: false);
		}
		try
		{
			byte[] sourceArray = Guid.NewGuid().ToByteArray();
			Array.Copy(sourceArray, 0, array, num, 16);
			num += 16;
			C2137352139.C3554254475(DateTime.UtcNow.ToBinary(), array, num);
			num += 8;
			C2137352139.C3554254475(Environment.TickCount, array, num);
			num += 4;
		}
		catch (Exception)
		{
			Debug.Assert(condition: false);
		}
		Debug.Assert(num == array.Length);
		byte[] result = global::C3904355907.C1304234792.C3554254475(array);
		C2137352139.C3904355907(array);
		return result;
	}
}
