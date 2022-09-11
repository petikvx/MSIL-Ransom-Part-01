#define DEBUG
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;
using C3554254475;
using C3904355907;

namespace C1255198513;

public sealed class C4024072794 : global::C3904355907.C2852464175
{
	private new sealed class C3554254475
	{
		public uint C3554254475 = 0u;

		public ulong C3554254475 = 0uL;

		public ulong C3904355907 = 0uL;

		public ulong C1255198513 = 0uL;

		public ulong C1908338681 = 0uL;

		public ulong C1037565863 = 0uL;

		public ulong C112844655 = 0uL;

		public ulong[] C3554254475 = null;
	}

	private new sealed class C3904355907
	{
		public C3554254475 C3554254475 = null;

		public ManualResetEvent C3554254475 = new ManualResetEvent(initialState: false);

		public ulong C3554254475 = 0uL;

		public ulong C3904355907 = 0uL;

		public ulong C1255198513 = 0uL;

		public ulong C1908338681 = 0uL;

		public void C3554254475()
		{
			if (this.C3554254475 != null)
			{
				this.C3554254475.Close();
				this.C3554254475 = null;
			}
			else
			{
				Debug.Assert(condition: false);
			}
		}
	}

	private new const ulong m_C3554254475 = 1024uL;

	private new const ulong m_C3904355907 = 128uL;

	private new const ulong m_C1255198513 = 4uL;

	private new const int m_C3554254475 = 64;

	private new const int m_C3904355907 = 72;

	private new static int[][] m_C3554254475 = null;

	private new static int[][] m_C3904355907 = null;

	private new static readonly global::C3554254475.C3865851505 m_C3554254475 = new global::C3554254475.C3865851505(new byte[16]
	{
		239, 99, 109, 223, 140, 41, 68, 75, 145, 247,
		169, 164, 3, 227, 10, 12
	});

	public new static readonly string C3554254475 = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Ke();

	public new static readonly string C3904355907 = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.KI();

	public new static readonly string C1255198513 = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Ki();

	public static readonly string C1908338681 = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.KJ();

	public static readonly string C1037565863 = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Kj();

	public static readonly string C112844655 = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.KK();

	public static readonly string C2746444292 = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Kk();

	private new const uint m_C3554254475 = 16u;

	private new const uint m_C3904355907 = 19u;

	private new const int m_C1255198513 = 8;

	private const int m_C1908338681 = int.MaxValue;

	internal const ulong C1908338681 = 1uL;

	internal const ulong C1037565863 = 4294967295uL;

	internal const ulong C112844655 = 8192uL;

	internal const ulong C2746444292 = 2147483647uL;

	internal new const uint C1255198513 = 1u;

	internal const uint C1908338681 = 16777215u;

	internal const ulong C2564639436 = 2uL;

	internal const ulong C3568589458 = 1048576uL;

	internal const uint C1037565863 = 2u;

	private static byte[] C3554254475(byte[] byte_0, byte[] byte_1, uint uint_0, ulong ulong_0, ulong ulong_1, int int_0, uint uint_1, byte[] byte_2, byte[] byte_3)
	{
		byte_2 = byte_2 ?? global::C3554254475.C2137352139.C3554254475;
		byte_3 = byte_3 ?? global::C3554254475.C2137352139.C3554254475;
		C1908338681();
		C3554254475 c3554254475 = new C3554254475();
		c3554254475.C3554254475 = uint_1;
		c3554254475.C3554254475 = uint_0;
		c3554254475.C3904355907 = ulong_1;
		c3554254475.C1255198513 = ulong_0 / 1024uL;
		c3554254475.C1908338681 = Math.Max(c3554254475.C1255198513, 8L * c3554254475.C3554254475);
		c3554254475.C1037565863 = c3554254475.C1908338681 / (c3554254475.C3554254475 * 4L);
		c3554254475.C1908338681 = c3554254475.C1037565863 * c3554254475.C3554254475 * 4L;
		c3554254475.C112844655 = c3554254475.C1037565863 * 4L;
		Debug.Assert(1024L == 128L * Marshal.SizeOf(typeof(ulong)));
		c3554254475.C3554254475 = new ulong[c3554254475.C1908338681 * 128L];
		global::C3904355907.C3707901625 c3707901625 = new global::C3904355907.C3707901625();
		Debug.Assert(c3707901625.HashSize == 512);
		byte[] array = new byte[4];
		global::C3554254475.C2137352139.C3554254475(uint_0, array, 0);
		c3707901625.TransformBlock(array, 0, array.Length, array, 0);
		global::C3554254475.C2137352139.C3554254475((uint)int_0, array, 0);
		c3707901625.TransformBlock(array, 0, array.Length, array, 0);
		global::C3554254475.C2137352139.C3554254475((uint)c3554254475.C1255198513, array, 0);
		c3707901625.TransformBlock(array, 0, array.Length, array, 0);
		global::C3554254475.C2137352139.C3554254475((uint)ulong_1, array, 0);
		c3707901625.TransformBlock(array, 0, array.Length, array, 0);
		global::C3554254475.C2137352139.C3554254475(uint_1, array, 0);
		c3707901625.TransformBlock(array, 0, array.Length, array, 0);
		global::C3554254475.C2137352139.C3554254475(0u, array, 0);
		c3707901625.TransformBlock(array, 0, array.Length, array, 0);
		global::C3554254475.C2137352139.C3554254475((uint)byte_0.Length, array, 0);
		c3707901625.TransformBlock(array, 0, array.Length, array, 0);
		c3707901625.TransformBlock(byte_0, 0, byte_0.Length, byte_0, 0);
		global::C3554254475.C2137352139.C3554254475((uint)byte_1.Length, array, 0);
		c3707901625.TransformBlock(array, 0, array.Length, array, 0);
		c3707901625.TransformBlock(byte_1, 0, byte_1.Length, byte_1, 0);
		global::C3554254475.C2137352139.C3554254475((uint)byte_2.Length, array, 0);
		c3707901625.TransformBlock(array, 0, array.Length, array, 0);
		c3707901625.TransformBlock(byte_2, 0, byte_2.Length, byte_2, 0);
		global::C3554254475.C2137352139.C3554254475((uint)byte_3.Length, array, 0);
		c3707901625.TransformBlock(array, 0, array.Length, array, 0);
		c3707901625.TransformBlock(byte_3, 0, byte_3.Length, byte_3, 0);
		c3707901625.TransformFinalBlock(global::C3554254475.C2137352139.C3554254475, 0, 0);
		byte[] hash = c3707901625.Hash;
		Debug.Assert(hash.Length == 64);
		byte[] array2 = new byte[72];
		Array.Copy(hash, array2, hash.Length);
		global::C3554254475.C2137352139.C3904355907(hash);
		C3554254475(c3554254475, array2, c3707901625);
		global::C3554254475.C2137352139.C3904355907(array2);
		C3554254475(c3554254475);
		byte[] result = C3554254475(c3554254475, int_0, c3707901625);
		c3707901625.Clear();
		global::C3554254475.C2137352139.C3554254475(c3554254475.C3554254475);
		return result;
	}

	private static void C3554254475(ulong[] ulong_0, ulong ulong_1, byte[] byte_0)
	{
		Debug.Assert(ulong_1 + 128L - 1L <= 2147483647L);
		int num = (int)ulong_1;
		for (int i = 0; i < 128; i++)
		{
			ulong_0[num + i] = global::C3554254475.C2137352139.C1255198513(byte_0, i << 3);
		}
	}

	private static void C3554254475(byte[] byte_0, ulong[] ulong_0)
	{
		for (int i = 0; i < 128; i++)
		{
			global::C3554254475.C2137352139.C3554254475(ulong_0[i], byte_0, i << 3);
		}
	}

	private static void C3554254475(ulong[] ulong_0, ulong ulong_1, ulong[] ulong_2, ulong ulong_3)
	{
		Array.Copy(ulong_2, (long)ulong_3, ulong_0, (long)ulong_1, 128L);
	}

	private static void C3904355907(ulong[] ulong_0, ulong ulong_1, ulong[] ulong_2, ulong ulong_3)
	{
		Debug.Assert(ulong_1 + 128L - 1L <= 2147483647L);
		Debug.Assert(ulong_3 + 128L - 1L <= 2147483647L);
		int num = (int)ulong_1;
		int num2 = (int)ulong_3;
		for (int i = 0; i < 128; i++)
		{
			ulong_0[num + i] ^= ulong_2[num2 + i];
		}
	}

	private static void C3554254475(byte[] byte_0, int int_0, byte[] byte_1, int int_1, global::C3904355907.C3707901625 c3707901625_0)
	{
		Debug.Assert(c3707901625_0 != null && c3707901625_0.HashSize == 512);
		byte[] array = new byte[4];
		global::C3554254475.C2137352139.C3554254475((uint)int_0, array, 0);
		if (int_0 <= 64)
		{
			global::C3904355907.C3707901625 c3707901625 = ((int_0 == 64) ? c3707901625_0 : new global::C3904355907.C3707901625(int_0));
			if (int_0 == 64)
			{
				c3707901625.Initialize();
			}
			c3707901625.TransformBlock(array, 0, array.Length, array, 0);
			c3707901625.TransformBlock(byte_1, 0, int_1, byte_1, 0);
			c3707901625.TransformFinalBlock(global::C3554254475.C2137352139.C3554254475, 0, 0);
			Array.Copy(c3707901625.Hash, byte_0, int_0);
			if (int_0 < 64)
			{
				c3707901625.Clear();
			}
			return;
		}
		c3707901625_0.Initialize();
		c3707901625_0.TransformBlock(array, 0, array.Length, array, 0);
		c3707901625_0.TransformBlock(byte_1, 0, int_1, byte_1, 0);
		c3707901625_0.TransformFinalBlock(global::C3554254475.C2137352139.C3554254475, 0, 0);
		byte[] array2 = new byte[64];
		Array.Copy(c3707901625_0.Hash, array2, array2.Length);
		int num = 32;
		Array.Copy(array2, byte_0, 32);
		int num2 = int_0 - 32;
		c3707901625_0.Initialize();
		while (num2 > 64)
		{
			byte[] array3 = c3707901625_0.ComputeHash(array2);
			Array.Copy(array3, array2, 64);
			Array.Copy(array3, 0, byte_0, num, 32);
			num += 32;
			num2 -= 32;
			global::C3554254475.C2137352139.C3904355907(array3);
		}
		using (global::C3904355907.C3707901625 c37079016252 = new global::C3904355907.C3707901625(num2))
		{
			byte[] array4 = c37079016252.ComputeHash(array2);
			Array.Copy(array4, 0, byte_0, num, num2);
			global::C3554254475.C2137352139.C3904355907(array4);
		}
		global::C3554254475.C2137352139.C3904355907(array2);
	}

	private static void C3554254475(ulong[] ulong_0, int int_0, int int_1, int int_2, int int_3)
	{
		ulong num = ulong_0[int_0];
		ulong num2 = ulong_0[int_1];
		ulong num3 = ulong_0[int_2];
		ulong num4 = ulong_0[int_3];
		ulong num5 = (num & 0xFFFFFFFFL) * (num2 & 0xFFFFFFFFL);
		num += num2 + (num5 << 1);
		num4 = global::C3554254475.C2137352139.C3904355907(num4 ^ num, 32);
		num5 = (num3 & 0xFFFFFFFFL) * (num4 & 0xFFFFFFFFL);
		num3 += num4 + (num5 << 1);
		num2 = global::C3554254475.C2137352139.C3904355907(num2 ^ num3, 24);
		num5 = (num & 0xFFFFFFFFL) * (num2 & 0xFFFFFFFFL);
		num += num2 + (num5 << 1);
		num4 = global::C3554254475.C2137352139.C3904355907(num4 ^ num, 16);
		num5 = (num3 & 0xFFFFFFFFL) * (num4 & 0xFFFFFFFFL);
		num3 += num4 + (num5 << 1);
		num2 = global::C3554254475.C2137352139.C3904355907(num2 ^ num3, 63);
		ulong_0[int_0] = num;
		ulong_0[int_1] = num2;
		ulong_0[int_2] = num3;
		ulong_0[int_3] = num4;
	}

	private static void C3554254475(ulong[] ulong_0, int[] int_0)
	{
		C3554254475(ulong_0, int_0[0], int_0[4], int_0[8], int_0[12]);
		C3554254475(ulong_0, int_0[1], int_0[5], int_0[9], int_0[13]);
		C3554254475(ulong_0, int_0[2], int_0[6], int_0[10], int_0[14]);
		C3554254475(ulong_0, int_0[3], int_0[7], int_0[11], int_0[15]);
		C3554254475(ulong_0, int_0[0], int_0[5], int_0[10], int_0[15]);
		C3554254475(ulong_0, int_0[1], int_0[6], int_0[11], int_0[12]);
		C3554254475(ulong_0, int_0[2], int_0[7], int_0[8], int_0[13]);
		C3554254475(ulong_0, int_0[3], int_0[4], int_0[9], int_0[14]);
	}

	private static void C3554254475(C3554254475 c3554254475_0, byte[] byte_0, global::C3904355907.C3707901625 c3707901625_0)
	{
		byte[] byte_ = new byte[1024L];
		for (ulong num = 0uL; num < c3554254475_0.C3554254475; num++)
		{
			global::C3554254475.C2137352139.C3554254475(0u, byte_0, 64);
			global::C3554254475.C2137352139.C3554254475((uint)num, byte_0, 68);
			C3554254475(byte_, 1024, byte_0, 72, c3707901625_0);
			C3554254475(c3554254475_0.C3554254475, num * c3554254475_0.C112844655 * 128L, byte_);
			global::C3554254475.C2137352139.C3554254475(1u, byte_0, 64);
			C3554254475(byte_, 1024, byte_0, 72, c3707901625_0);
			C3554254475(c3554254475_0.C3554254475, (num * c3554254475_0.C112844655 + 1L) * 128L, byte_);
		}
		global::C3554254475.C2137352139.C3904355907(byte_);
	}

	private static ulong C3554254475(C3554254475 c3554254475_0, C3904355907 c3904355907_0, uint uint_0, bool bool_0)
	{
		ulong num;
		if (c3904355907_0.C3554254475 != 0L)
		{
			num = ((!bool_0) ? (c3554254475_0.C112844655 - c3554254475_0.C1037565863 - (ulong)((c3904355907_0.C1908338681 == 0L) ? 1L : 0L)) : (c3554254475_0.C112844655 - c3554254475_0.C1037565863 + c3904355907_0.C1908338681 - 1L));
		}
		else if (c3904355907_0.C1255198513 != 0L)
		{
			num = ((!bool_0) ? (c3904355907_0.C1255198513 * c3554254475_0.C1037565863 - (ulong)((c3904355907_0.C1908338681 == 0L) ? 1L : 0L)) : (c3904355907_0.C1255198513 * c3554254475_0.C1037565863 + c3904355907_0.C1908338681 - 1L));
		}
		else
		{
			Debug.Assert(c3904355907_0.C1908338681 > 0L);
			num = c3904355907_0.C1908338681 - 1L;
		}
		Debug.Assert(num <= 4294967295L);
		ulong num2 = uint_0;
		num2 = num2 * num2 >> 32;
		num2 = num - 1L - (num * num2 >> 32);
		ulong num3 = 0uL;
		if (c3904355907_0.C3554254475 > 0L)
		{
			num3 = ((c3904355907_0.C1255198513 + 1L == 4L) ? 0uL : ((c3904355907_0.C1255198513 + 1L) * c3554254475_0.C1037565863));
		}
		Debug.Assert(num3 <= 4294967295L);
		Debug.Assert(c3554254475_0.C112844655 <= 4294967295L);
		return (num3 + num2) % c3554254475_0.C112844655;
	}

	private static void C3554254475(C3554254475 c3554254475_0)
	{
		int num = (int)c3554254475_0.C3554254475;
		C3904355907[] array = new C3904355907[num];
		for (ulong num2 = 0uL; num2 < c3554254475_0.C3904355907; num2++)
		{
			for (ulong num3 = 0uL; num3 < 4L; num3++)
			{
				for (int i = 0; i < num; i++)
				{
					C3904355907 c3904355907 = new C3904355907();
					c3904355907.C3554254475 = c3554254475_0;
					c3904355907.C3554254475 = num2;
					c3904355907.C3904355907 = (ulong)i;
					c3904355907.C1255198513 = num3;
					if (ThreadPool.QueueUserWorkItem(C3554254475, c3904355907))
					{
						array[i] = c3904355907;
						continue;
					}
					Debug.Assert(condition: false);
					throw new OutOfMemoryException();
				}
				for (int j = 0; j < num; j++)
				{
					array[j].C3554254475.WaitOne();
					array[j].C3554254475();
				}
			}
		}
	}

	private static void C3554254475(object object_0)
	{
		if (!(object_0 is C3904355907 c3904355907))
		{
			Debug.Assert(condition: false);
			return;
		}
		try
		{
			C3554254475 c3554254475 = c3904355907.C3554254475;
			if (c3554254475 == null)
			{
				Debug.Assert(condition: false);
				return;
			}
			Debug.Assert(c3554254475.C3554254475 >= 16);
			bool flag = c3554254475.C3554254475 >= 19;
			ulong num = 0uL;
			if (c3904355907.C3554254475 == 0L && c3904355907.C1255198513 == 0L)
			{
				num = 2uL;
			}
			ulong num2 = c3904355907.C3904355907 * c3554254475.C112844655 + c3904355907.C1255198513 * c3554254475.C1037565863 + num;
			ulong num3 = ((num2 % c3554254475.C112844655 == 0L) ? (num2 + c3554254475.C112844655 - 1L) : (num2 - 1L));
			ulong[] array = new ulong[128L];
			ulong[] array2 = new ulong[128L];
			for (ulong num4 = num; num4 < c3554254475.C1037565863; num4++)
			{
				if (num2 % c3554254475.C112844655 == 1L)
				{
					num3 = num2 - 1L;
				}
				ulong num5 = c3554254475.C3554254475[num3 * 128L];
				ulong num6 = (num5 >> 32) % c3554254475.C3554254475;
				if (c3904355907.C3554254475 == 0L && c3904355907.C1255198513 == 0L)
				{
					num6 = c3904355907.C3904355907;
				}
				c3904355907.C1908338681 = num4;
				ulong num7 = C3554254475(c3554254475, c3904355907, (uint)num5, num6 == c3904355907.C3904355907);
				ulong ulong_ = (c3554254475.C112844655 * num6 + num7) * 128L;
				ulong ulong_2 = num2 * 128L;
				C3554254475(c3554254475.C3554254475, num3 * 128L, ulong_, ulong_2, c3904355907.C3554254475 > 0L && flag, array, array2);
				num2++;
				num3++;
			}
			global::C3554254475.C2137352139.C3554254475(array);
			global::C3554254475.C2137352139.C3554254475(array2);
		}
		catch (Exception)
		{
			Debug.Assert(condition: false);
		}
		try
		{
			c3904355907.C3554254475.Set();
		}
		catch (Exception)
		{
			Debug.Assert(condition: false);
		}
	}

	private static void C1908338681()
	{
		int[][] c3554254475 = C4024072794.m_C3554254475;
		if (c3554254475 == null)
		{
			c3554254475 = new int[8][];
			Debug.Assert(c3554254475.Length == 8);
			int num = 0;
			for (int i = 0; i < 8; i++)
			{
				c3554254475[i] = new int[16];
				for (int j = 0; j < 16; j++)
				{
					c3554254475[i][j] = num;
					num++;
				}
			}
			C4024072794.m_C3554254475 = c3554254475;
		}
		int[][] c3904355907 = C4024072794.m_C3904355907;
		if (c3904355907 != null)
		{
			return;
		}
		c3904355907 = new int[8][];
		for (int k = 0; k < 8; k++)
		{
			c3904355907[k] = new int[16];
			for (int l = 0; l < 16; l++)
			{
				int num2 = l / 2;
				c3904355907[k][l] = 2 * k + 16 * num2 + (l & 1);
			}
		}
		C4024072794.m_C3904355907 = c3904355907;
	}

	private static void C3554254475(ulong[] ulong_0, ulong ulong_1, ulong ulong_2, ulong ulong_3, bool bool_0, ulong[] ulong_4, ulong[] ulong_5)
	{
		C3554254475(ulong_4, 0uL, ulong_0, ulong_2);
		C3904355907(ulong_4, 0uL, ulong_0, ulong_1);
		C3554254475(ulong_5, 0uL, ulong_4, 0uL);
		if (bool_0)
		{
			C3904355907(ulong_5, 0uL, ulong_0, ulong_3);
		}
		int[][] c3554254475 = C4024072794.m_C3554254475;
		int[][] c3904355907 = C4024072794.m_C3904355907;
		for (int i = 0; i < 8; i++)
		{
			C3554254475(ulong_4, c3554254475[i]);
		}
		for (int j = 0; j < 8; j++)
		{
			C3554254475(ulong_4, c3904355907[j]);
		}
		C3554254475(ulong_0, ulong_3, ulong_5, 0uL);
		C3904355907(ulong_0, ulong_3, ulong_4, 0uL);
	}

	private static byte[] C3554254475(C3554254475 c3554254475_0, int int_0, global::C3904355907.C3707901625 c3707901625_0)
	{
		ulong[] array = new ulong[128L];
		C3554254475(array, 0uL, c3554254475_0.C3554254475, (c3554254475_0.C112844655 - 1L) * 128L);
		for (ulong num = 1uL; num < c3554254475_0.C3554254475; num++)
		{
			C3904355907(array, 0uL, c3554254475_0.C3554254475, (num * c3554254475_0.C112844655 + c3554254475_0.C112844655 - 1L) * 128L);
		}
		byte[] array2 = new byte[1024L];
		C3554254475(array2, array);
		byte[] array3 = new byte[int_0];
		C3554254475(array3, int_0, array2, 1024, c3707901625_0);
		global::C3554254475.C2137352139.C3554254475(array);
		global::C3554254475.C2137352139.C3904355907(array2);
		return array3;
	}

	[SpecialName]
	public override global::C3554254475.C3865851505 C3554254475()
	{
		return C4024072794.m_C3554254475;
	}

	[SpecialName]
	public override string C3904355907()
	{
		return DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.KF();
	}

	public override C1304234792 C1255198513()
	{
		C1304234792 c = base.C1255198513();
		c.C3904355907(C4024072794.C1037565863, 19u);
		c.C3904355907(C4024072794.C1908338681, 2uL);
		c.C3904355907(C4024072794.C1255198513, 1048576uL);
		c.C3904355907(C4024072794.C3904355907, 2u);
		return c;
	}

	public override void C3554254475(C1304234792 c1304234792_0)
	{
		if (c1304234792_0 == null)
		{
			Debug.Assert(condition: false);
			return;
		}
		Debug.Assert(C4024072794.m_C3554254475.Equals(c1304234792_0.C3554254475()));
		byte[] byte_ = global::C3904355907.C2746444292.C3554254475().C3554254475(32u);
		c1304234792_0.C3554254475(C4024072794.C3554254475, byte_);
	}

	public override byte[] C3554254475(byte[] byte_0, C1304234792 c1304234792_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Kb());
		}
		if (c1304234792_0 == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.JC());
		}
		byte[] array = c1304234792_0.C1908338681(C4024072794.C3554254475);
		if (array == null)
		{
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Kf());
		}
		if (array.Length < 8 || array.Length > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Kf());
		}
		uint num = c1304234792_0.C3554254475(C4024072794.C3904355907, 0u);
		if (num < 1 || num > 16777215)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.KG());
		}
		ulong num2 = c1304234792_0.C3554254475(C4024072794.C1255198513, 0uL);
		if (num2 < 8192L || num2 > 2147483647L)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Kg());
		}
		ulong num3 = c1304234792_0.C3554254475(C4024072794.C1908338681, 0uL);
		if (num3 < 1L || num3 > 4294967295L)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.KH());
		}
		uint num4 = c1304234792_0.C3554254475(C4024072794.C1037565863, 0u);
		if (num4 < 16 || num4 > 19)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Kh());
		}
		byte[] byte_ = c1304234792_0.C1908338681(C4024072794.C112844655);
		byte[] byte_2 = c1304234792_0.C1908338681(C4024072794.C2746444292);
		byte[] result = C3554254475(byte_0, array, num, num2, num3, 32, num4, byte_, byte_2);
		if (num2 > 104857600L)
		{
			GC.Collect();
		}
		return result;
	}

	public override C1304234792 C3554254475(uint uint_0)
	{
		C1304234792 c = C1255198513();
		((global::C3904355907.C2852464175)this).C3554254475(c);
		C3554254475(c, C4024072794.C1908338681, 1uL, 4294967295uL, uint_0, bool_0: true);
		return c;
	}
}
