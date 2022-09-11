#define DEBUG
using System;
using System.Diagnostics;
using System.Security.Cryptography;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;
using C3554254475;

namespace C3904355907;

public sealed class C3707901625 : HashAlgorithm
{
	private const int m_C3554254475 = 12;

	private const int C3904355907 = 128;

	private const int C1255198513 = 64;

	private static readonly ulong[] m_C3554254475 = new ulong[8] { 7640891576956012808uL, 13503953896175478587uL, 4354685564936845355uL, 11912009170470909681uL, 5840696475078001361uL, 11170449401992604703uL, 2270897969802886507uL, 6620516959819538809uL };

	private static readonly int[] m_C3554254475 = new int[192]
	{
		0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
		10, 11, 12, 13, 14, 15, 14, 10, 4, 8,
		9, 15, 13, 6, 1, 12, 0, 2, 11, 7,
		5, 3, 11, 8, 12, 0, 5, 2, 15, 13,
		10, 14, 3, 6, 7, 1, 9, 4, 7, 9,
		3, 1, 13, 12, 11, 14, 2, 6, 5, 10,
		4, 0, 15, 8, 9, 0, 5, 7, 2, 4,
		10, 15, 14, 1, 11, 12, 6, 8, 3, 13,
		2, 12, 6, 10, 0, 11, 8, 3, 4, 13,
		7, 5, 15, 14, 1, 9, 12, 5, 1, 15,
		14, 13, 4, 10, 0, 7, 6, 3, 9, 2,
		8, 11, 13, 11, 7, 14, 12, 1, 3, 9,
		5, 0, 15, 4, 8, 6, 2, 10, 6, 15,
		14, 9, 11, 3, 0, 8, 12, 2, 13, 7,
		1, 4, 10, 5, 10, 2, 8, 4, 7, 6,
		1, 5, 15, 11, 9, 14, 3, 12, 13, 0,
		0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
		10, 11, 12, 13, 14, 15, 14, 10, 4, 8,
		9, 15, 13, 6, 1, 12, 0, 2, 11, 7,
		5, 3
	};

	private readonly int C1908338681;

	private ulong[] C3904355907 = new ulong[8];

	private ulong[] C1255198513 = new ulong[2];

	private ulong[] C1908338681 = new ulong[2];

	private byte[] m_C3554254475 = new byte[128];

	private int C1037565863 = 0;

	private ulong[] C1037565863 = new ulong[16];

	private ulong[] C112844655 = new ulong[16];

	public C3707901625()
	{
		this.C1908338681 = 64;
		HashSizeValue = 512;
		Initialize();
	}

	public C3707901625(int int_0)
	{
		if (int_0 < 0 || int_0 > 64)
		{
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cO());
		}
		this.C1908338681 = int_0;
		HashSizeValue = int_0 * 8;
		Initialize();
	}

	public override void Initialize()
	{
		Debug.Assert(C3904355907.Length == C3707901625.m_C3554254475.Length);
		Array.Copy(C3707901625.m_C3554254475, C3904355907, C3904355907.Length);
		C3904355907[0] ^= (ulong)(0x1010000L ^ this.C1908338681);
		Array.Clear(C1255198513, 0, C1255198513.Length);
		Array.Clear(C1908338681, 0, C1908338681.Length);
		Array.Clear(this.m_C3554254475, 0, this.m_C3554254475.Length);
		this.C1037565863 = 0;
		Array.Clear(C1037565863, 0, C1037565863.Length);
		Array.Clear(C112844655, 0, C112844655.Length);
	}

	private static void C3554254475(ulong[] ulong_0, ulong[] ulong_1, int int_0, int int_1, int int_2, int int_3, int int_4, int int_5)
	{
		int num = int_0 + int_1;
		ulong_0[int_2] += ulong_0[int_3] + ulong_1[C3707901625.m_C3554254475[num]];
		ulong_0[int_5] = global::C3554254475.C2137352139.C3904355907(ulong_0[int_5] ^ ulong_0[int_2], 32);
		ulong_0[int_4] += ulong_0[int_5];
		ulong_0[int_3] = global::C3554254475.C2137352139.C3904355907(ulong_0[int_3] ^ ulong_0[int_4], 24);
		ulong_0[int_2] += ulong_0[int_3] + ulong_1[C3707901625.m_C3554254475[num + 1]];
		ulong_0[int_5] = global::C3554254475.C2137352139.C3904355907(ulong_0[int_5] ^ ulong_0[int_2], 16);
		ulong_0[int_4] += ulong_0[int_5];
		ulong_0[int_3] = global::C3554254475.C2137352139.C3904355907(ulong_0[int_3] ^ ulong_0[int_4], 63);
	}

	private void C3554254475(byte[] byte_0, int int_0)
	{
		ulong[] c = C112844655;
		ulong[] c2 = C1037565863;
		ulong[] c3904355907 = C3904355907;
		for (int i = 0; i < 16; i++)
		{
			c2[i] = global::C3554254475.C2137352139.C1255198513(byte_0, int_0 + (i << 3));
		}
		Array.Copy(c3904355907, c, 8);
		c[8] = C3707901625.m_C3554254475[0];
		c[9] = C3707901625.m_C3554254475[1];
		c[10] = C3707901625.m_C3554254475[2];
		c[11] = C3707901625.m_C3554254475[3];
		c[12] = C3707901625.m_C3554254475[4] ^ C1255198513[0];
		c[13] = C3707901625.m_C3554254475[5] ^ C1255198513[1];
		c[14] = C3707901625.m_C3554254475[6] ^ C1908338681[0];
		c[15] = C3707901625.m_C3554254475[7] ^ C1908338681[1];
		for (int j = 0; j < 12; j++)
		{
			int int_ = j << 4;
			C3554254475(c, c2, int_, 0, 0, 4, 8, 12);
			C3554254475(c, c2, int_, 2, 1, 5, 9, 13);
			C3554254475(c, c2, int_, 4, 2, 6, 10, 14);
			C3554254475(c, c2, int_, 6, 3, 7, 11, 15);
			C3554254475(c, c2, int_, 8, 0, 5, 10, 15);
			C3554254475(c, c2, int_, 10, 1, 6, 11, 12);
			C3554254475(c, c2, int_, 12, 2, 7, 8, 13);
			C3554254475(c, c2, int_, 14, 3, 4, 9, 14);
		}
		for (int k = 0; k < 8; k++)
		{
			c3904355907[k] ^= c[k] ^ c[k + 8];
		}
	}

	private void C3554254475(ulong ulong_0)
	{
		C1255198513[0] += ulong_0;
		if (C1255198513[0] < ulong_0)
		{
			C1255198513[1]++;
		}
	}

	protected override void HashCore(byte[] array, int ibStart, int cbSize)
	{
		Debug.Assert(C1908338681[0] == 0L);
		if (this.C1037565863 + cbSize > 128)
		{
			int num = 128 - this.C1037565863;
			if (num > 0)
			{
				Array.Copy(array, ibStart, this.m_C3554254475, this.C1037565863, num);
			}
			C3554254475(128uL);
			C3554254475(this.m_C3554254475, 0);
			this.C1037565863 = 0;
			cbSize -= num;
			ibStart += num;
			while (cbSize > 128)
			{
				C3554254475(128uL);
				C3554254475(array, ibStart);
				cbSize -= 128;
				ibStart += 128;
			}
		}
		if (cbSize > 0)
		{
			Debug.Assert(this.C1037565863 + cbSize <= 128);
			Array.Copy(array, ibStart, this.m_C3554254475, this.C1037565863, cbSize);
			this.C1037565863 += cbSize;
		}
	}

	protected override byte[] HashFinal()
	{
		if (C1908338681[0] > 0L)
		{
			Debug.Assert(condition: false);
			throw new InvalidOperationException();
		}
		Debug.Assert((C1255198513[1] == 0L && C1255198513[0] == 0L) || this.C1037565863 > 0);
		C1908338681[0] = ulong.MaxValue;
		int num = 128 - this.C1037565863;
		if (num > 0)
		{
			Array.Clear(this.m_C3554254475, this.C1037565863, num);
		}
		C3554254475((ulong)this.C1037565863);
		C3554254475(this.m_C3554254475, 0);
		byte[] array = new byte[64];
		for (int i = 0; i < C3904355907.Length; i++)
		{
			global::C3554254475.C2137352139.C3554254475(C3904355907[i], array, i << 3);
		}
		if (this.C1908338681 == 64)
		{
			return array;
		}
		Debug.Assert(this.C1908338681 < 64);
		byte[] array2 = new byte[this.C1908338681];
		if (this.C1908338681 > 0)
		{
			Array.Copy(array, array2, this.C1908338681);
		}
		global::C3554254475.C2137352139.C3904355907(array);
		return array2;
	}
}
