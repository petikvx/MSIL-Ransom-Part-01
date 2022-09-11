#define DEBUG
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;
using C3904355907;

namespace C3554254475;

[DebuggerDisplay("{ReadString()}")]
public sealed class C2181537457
{
	private C3110715001 m_C3554254475 = null;

	private string m_C3554254475 = null;

	private bool m_C3554254475;

	private static readonly C2181537457 m_C3554254475 = new C2181537457();

	private static readonly C2181537457 m_C3904355907 = new C2181537457(bool_0: true, new byte[0]);

	private int m_C3554254475 = -1;

	[SpecialName]
	public static C2181537457 C3554254475()
	{
		return C2181537457.m_C3554254475;
	}

	[SpecialName]
	public static C2181537457 C3904355907()
	{
		return C2181537457.m_C3904355907;
	}

	[SpecialName]
	public bool C1255198513()
	{
		return this.m_C3554254475;
	}

	[SpecialName]
	public bool C1908338681()
	{
		C3110715001 c3554254475 = this.m_C3554254475;
		if (c3554254475 != null)
		{
			return c3554254475.C1908338681() == 0;
		}
		Debug.Assert(this.m_C3554254475 != null);
		return this.m_C3554254475.Length == 0;
	}

	[SpecialName]
	public int C1037565863()
	{
		if (this.m_C3554254475 >= 0)
		{
			return this.m_C3554254475;
		}
		C3110715001 c3554254475 = this.m_C3554254475;
		if (c3554254475 != null)
		{
			byte[] array = c3554254475.C2746444292();
			try
			{
				this.m_C3554254475 = C1130791706.C1255198513().GetCharCount(array);
			}
			finally
			{
				C2137352139.C3904355907(array);
			}
		}
		else
		{
			Debug.Assert(this.m_C3554254475 != null);
			this.m_C3554254475 = this.m_C3554254475.Length;
		}
		return this.m_C3554254475;
	}

	public C2181537457()
	{
		C3554254475(bool_0: false, string.Empty);
	}

	public C2181537457(bool bool_0, string string_0)
	{
		C3554254475(bool_0, string_0);
	}

	public C2181537457(bool bool_0, byte[] byte_0)
	{
		C3554254475(bool_0, byte_0);
	}

	public C2181537457(bool bool_0, C3463352047 c3463352047_0)
	{
		if (c3463352047_0 == null)
		{
			Debug.Assert(condition: false);
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Bq());
		}
		byte[] byte_ = c3463352047_0.C3904355907();
		try
		{
			C3554254475(bool_0, byte_);
		}
		finally
		{
			if (bool_0)
			{
				C2137352139.C3904355907(byte_);
			}
		}
	}

	private void C3554254475(bool bool_0, string string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C3081909835());
		}
		this.m_C3554254475 = bool_0;
		this.m_C3554254475 = string_0;
	}

	private void C3554254475(bool bool_0, byte[] byte_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.@as());
		}
		this.m_C3554254475 = bool_0;
		if (bool_0)
		{
			this.m_C3554254475 = new C3110715001(bool_0: true, byte_0);
		}
		else
		{
			this.m_C3554254475 = C1130791706.C1255198513().GetString(byte_0, 0, byte_0.Length);
		}
	}

	public string C112844655()
	{
		if (this.m_C3554254475 != null)
		{
			return this.m_C3554254475;
		}
		byte[] array = C2564639436();
		string result = (this.m_C3554254475 = ((array.Length == 0) ? string.Empty : C1130791706.C1255198513().GetString(array, 0, array.Length)));
		this.m_C3554254475 = null;
		return result;
	}

	public char[] C2746444292()
	{
		if (this.m_C3554254475 != null)
		{
			return this.m_C3554254475.ToCharArray();
		}
		byte[] array = C2564639436();
		char[] chars;
		try
		{
			chars = C1130791706.C1255198513().GetChars(array);
		}
		finally
		{
			C2137352139.C3904355907(array);
		}
		return chars;
	}

	public byte[] C2564639436()
	{
		C3110715001 c3554254475 = this.m_C3554254475;
		if (c3554254475 != null)
		{
			return c3554254475.C2746444292();
		}
		return C1130791706.C1255198513().GetBytes(this.m_C3554254475);
	}

	public byte[] C3554254475(global::C3904355907.C3568589458 c3568589458_0)
	{
		if (c3568589458_0 == null)
		{
			Debug.Assert(condition: false);
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Br());
		}
		byte[] array = C2564639436();
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

	public C2181537457 C3554254475(bool bool_0)
	{
		if (bool_0 == this.m_C3554254475)
		{
			return this;
		}
		byte[] byte_ = C2564639436();
		return new C2181537457(bool_0, byte_);
	}

	public bool C3554254475(C2181537457 c2181537457_0, bool bool_0)
	{
		if (c2181537457_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.BS());
		}
		if (this == c2181537457_0)
		{
			return true;
		}
		bool c3554254475 = this.m_C3554254475;
		bool c35542544752 = c2181537457_0.m_C3554254475;
		if (bool_0 && c3554254475 != c35542544752)
		{
			return false;
		}
		if (!c3554254475 && !c35542544752)
		{
			return C112844655() == c2181537457_0.C112844655();
		}
		byte[] byte_ = C2564639436();
		byte[] array = null;
		bool result;
		try
		{
			array = c2181537457_0.C2564639436();
			result = C2137352139.C3554254475(byte_, array);
		}
		finally
		{
			if (c3554254475)
			{
				C2137352139.C3904355907(byte_);
			}
			if (c35542544752 && array != null)
			{
				C2137352139.C3904355907(array);
			}
		}
		return result;
	}

	public C2181537457 C3554254475(int int_0, string string_0)
	{
		if (int_0 < 0)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Bs());
		}
		if (string_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.BT());
		}
		if (string_0.Length == 0)
		{
			return this;
		}
		if (!this.m_C3554254475)
		{
			return new C2181537457(bool_0: false, C112844655().Insert(int_0, string_0));
		}
		UTF8Encoding uTF8Encoding = C1130791706.C1255198513();
		char[] array = C2746444292();
		char[] array2 = null;
		byte[] array3 = null;
		C2181537457 result;
		try
		{
			if (int_0 > array.Length)
			{
				throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Bs());
			}
			char[] array4 = string_0.ToCharArray();
			array2 = new char[array.Length + array4.Length];
			Array.Copy(array, 0, array2, 0, int_0);
			Array.Copy(array4, 0, array2, int_0, array4.Length);
			Array.Copy(array, int_0, array2, int_0 + array4.Length, array.Length - int_0);
			array3 = uTF8Encoding.GetBytes(array2);
			result = new C2181537457(bool_0: true, array3);
			Debug.Assert(uTF8Encoding.GetString(array3, 0, array3.Length) == C112844655().Insert(int_0, string_0));
		}
		finally
		{
			C2137352139.C3554254475(array);
			if (array2 != null)
			{
				C2137352139.C3554254475(array2);
			}
			if (array3 != null)
			{
				C2137352139.C3904355907(array3);
			}
		}
		return result;
	}

	public C2181537457 C3554254475(int int_0, int int_1)
	{
		if (int_0 < 0)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Bs());
		}
		if (int_1 < 0)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C3187964512());
		}
		if (int_1 == 0)
		{
			return this;
		}
		if (!this.m_C3554254475)
		{
			return new C2181537457(bool_0: false, C112844655().Remove(int_0, int_1));
		}
		UTF8Encoding uTF8Encoding = C1130791706.C1255198513();
		char[] array = C2746444292();
		char[] array2 = null;
		byte[] array3 = null;
		C2181537457 result;
		try
		{
			if (int_0 + int_1 > array.Length)
			{
				throw new ArgumentException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Bt());
			}
			array2 = new char[array.Length - int_1];
			Array.Copy(array, 0, array2, 0, int_0);
			Array.Copy(array, int_0 + int_1, array2, int_0, array.Length - (int_0 + int_1));
			array3 = uTF8Encoding.GetBytes(array2);
			result = new C2181537457(bool_0: true, array3);
			Debug.Assert(uTF8Encoding.GetString(array3, 0, array3.Length) == C112844655().Remove(int_0, int_1));
		}
		finally
		{
			C2137352139.C3554254475(array);
			if (array2 != null)
			{
				C2137352139.C3554254475(array2);
			}
			if (array3 != null)
			{
				C2137352139.C3904355907(array3);
			}
		}
		return result;
	}

	public static C2181537457 operator +(C2181537457 c2181537457_0, C2181537457 c2181537457_1)
	{
		if (c2181537457_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C1505515367());
		}
		if (c2181537457_1 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.BU());
		}
		if (c2181537457_1.C1908338681())
		{
			return c2181537457_0.C3554254475(c2181537457_0.C1255198513() || c2181537457_1.C1255198513());
		}
		if (c2181537457_0.C1908338681())
		{
			return c2181537457_1.C3554254475(c2181537457_0.C1255198513() || c2181537457_1.C1255198513());
		}
		if (!c2181537457_0.C1255198513() && !c2181537457_1.C1255198513())
		{
			return new C2181537457(bool_0: false, c2181537457_0.C112844655() + c2181537457_1.C112844655());
		}
		char[] array = c2181537457_0.C2746444292();
		char[] array2 = null;
		char[] array3 = null;
		byte[] array4 = null;
		C2181537457 result;
		try
		{
			array2 = c2181537457_1.C2746444292();
			array3 = new char[array.Length + array2.Length];
			Array.Copy(array, array3, array.Length);
			Array.Copy(array2, 0, array3, array.Length, array2.Length);
			array4 = C1130791706.C1255198513().GetBytes(array3);
			result = new C2181537457(bool_0: true, array4);
		}
		finally
		{
			C2137352139.C3554254475(array);
			if (array2 != null)
			{
				C2137352139.C3554254475(array2);
			}
			if (array3 != null)
			{
				C2137352139.C3554254475(array3);
			}
			if (array4 != null)
			{
				C2137352139.C3904355907(array4);
			}
		}
		return result;
	}

	public static C2181537457 operator +(C2181537457 c2181537457_0, string string_0)
	{
		C2181537457 c2181537457 = new C2181537457(bool_0: false, string_0);
		return c2181537457_0 + c2181537457;
	}
}
