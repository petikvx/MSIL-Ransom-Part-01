namespace Renci.SshNet.Security.Chaos.NaCl.Internal;

internal class Poly1305Donna
{
	internal static void poly1305_auth(byte[] output, int outputOffset, byte[] m, int mStart, int mLength, ref Array8<uint> key)
	{
		uint x = key.x0;
		uint x2 = key.x1;
		uint x3 = key.x2;
		uint x4 = key.x3;
		uint num = x & 0x3FFFFFFu;
		x >>= 26;
		x |= x2 << 6;
		uint num2 = x & 0x3FFFF03u;
		x2 >>= 20;
		x2 |= x3 << 12;
		uint num3 = x2 & 0x3FFC0FFu;
		x3 >>= 14;
		x3 |= x4 << 18;
		uint num4 = x3 & 0x3F03FFFu;
		x4 >>= 8;
		uint num5 = x4 & 0xFFFFFu;
		uint num6 = num2 * 5;
		uint num7 = num3 * 5;
		uint num8 = num4 * 5;
		uint num9 = num5 * 5;
		uint num10 = 0u;
		uint num11 = 0u;
		uint num12 = 0u;
		uint num13 = 0u;
		uint num14 = 0u;
		if (mLength >= 16)
		{
			goto IL_0186;
		}
		goto IL_037b;
		IL_037b:
		if (mLength != 0)
		{
			byte[] array = new byte[16];
			int i;
			for (i = 0; i < mLength; i++)
			{
				array[i] = m[mStart + i];
			}
			array[i++] = 1;
			for (; i < 16; i++)
			{
				array[i] = 0;
			}
			mLength = 0;
			x = ByteIntegerConverter.LoadLittleEndian32(array, 0);
			x2 = ByteIntegerConverter.LoadLittleEndian32(array, 4);
			x3 = ByteIntegerConverter.LoadLittleEndian32(array, 8);
			x4 = ByteIntegerConverter.LoadLittleEndian32(array, 12);
			CryptoBytes.Wipe(array);
			num10 += x & 0x3FFFFFF;
			num11 += (uint)(int)(((((ulong)x2 << 32) | x) >> 26) & 0x3FFFFFFL);
			num12 += (uint)(int)(((((ulong)x3 << 32) | x2) >> 20) & 0x3FFFFFFL);
			num13 += (uint)(int)(((((ulong)x4 << 32) | x3) >> 14) & 0x3FFFFFFL);
			num14 += x4 >> 8;
			goto IL_0228;
		}
		uint num15 = num10 >> 26;
		num10 &= 0x3FFFFFFu;
		num11 += num15;
		num15 = num11 >> 26;
		num11 &= 0x3FFFFFFu;
		num12 += num15;
		num15 = num12 >> 26;
		num12 &= 0x3FFFFFFu;
		num13 += num15;
		num15 = num13 >> 26;
		num13 &= 0x3FFFFFFu;
		num14 += num15;
		num15 = num14 >> 26;
		num14 &= 0x3FFFFFFu;
		num10 += num15 * 5;
		uint num16 = num10 + 5;
		num15 = num16 >> 26;
		num16 &= 0x3FFFFFFu;
		uint num17 = num11 + num15;
		num15 = num17 >> 26;
		num17 &= 0x3FFFFFFu;
		uint num18 = num12 + num15;
		num15 = num18 >> 26;
		num18 &= 0x3FFFFFFu;
		uint num19 = num13 + num15;
		num15 = num19 >> 26;
		num19 &= 0x3FFFFFFu;
		uint num20 = num14 + num15 - 67108864;
		num15 = (num20 >> 31) - 1;
		uint num21 = ~num15;
		num10 = (num10 & num21) | (num16 & num15);
		num11 = (num11 & num21) | (num17 & num15);
		num12 = (num12 & num21) | (num18 & num15);
		num13 = (num13 & num21) | (num19 & num15);
		num14 = (num14 & num21) | (num20 & num15);
		ulong num22 = (ulong)(num10 | (num11 << 26)) + (ulong)key.x4;
		ulong num23 = (ulong)((num11 >> 6) | (num12 << 20)) + (ulong)key.x5;
		ulong num24 = (ulong)((num12 >> 12) | (num13 << 14)) + (ulong)key.x6;
		ulong num25 = (ulong)((num13 >> 18) | (num14 << 8)) + (ulong)key.x7;
		ByteIntegerConverter.StoreLittleEndian32(output, outputOffset, (uint)num22);
		num23 += num22 >> 32;
		ByteIntegerConverter.StoreLittleEndian32(output, outputOffset + 4, (uint)num23);
		num24 += num23 >> 32;
		ByteIntegerConverter.StoreLittleEndian32(output, outputOffset + 8, (uint)num24);
		num25 += num24 >> 32;
		ByteIntegerConverter.StoreLittleEndian32(output, outputOffset + 12, (uint)num25);
		return;
		IL_0228:
		ulong num26 = (ulong)((long)num10 * (long)num + (long)num11 * (long)num9 + (long)num12 * (long)num8 + (long)num13 * (long)num7 + (long)num14 * (long)num6);
		ulong num27 = (ulong)((long)num10 * (long)num2 + (long)num11 * (long)num + (long)num12 * (long)num9 + (long)num13 * (long)num8 + (long)num14 * (long)num7);
		ulong num28 = (ulong)((long)num10 * (long)num3 + (long)num11 * (long)num2 + (long)num12 * (long)num + (long)num13 * (long)num9 + (long)num14 * (long)num8);
		ulong num29 = (ulong)((long)num10 * (long)num4 + (long)num11 * (long)num3 + (long)num12 * (long)num2 + (long)num13 * (long)num + (long)num14 * (long)num9);
		long num30 = (long)num10 * (long)num5 + (long)num11 * (long)num4 + (long)num12 * (long)num3 + (long)num13 * (long)num2 + (long)num14 * (long)num;
		num10 = (uint)(int)num26 & 0x3FFFFFFu;
		ulong num31 = num26 >> 26;
		num27 += num31;
		num11 = (uint)(int)num27 & 0x3FFFFFFu;
		num15 = (uint)(num27 >> 26);
		num28 += num15;
		num12 = (uint)(int)num28 & 0x3FFFFFFu;
		num15 = (uint)(num28 >> 26);
		num29 += num15;
		num13 = (uint)(int)num29 & 0x3FFFFFFu;
		num15 = (uint)(num29 >> 26);
		long num32 = num30 + num15;
		num14 = (uint)(int)num32 & 0x3FFFFFFu;
		num15 = (uint)((ulong)num32 >> 26);
		num10 += num15 * 5;
		if (mLength >= 16)
		{
			goto IL_0186;
		}
		goto IL_037b;
		IL_0186:
		mStart += 16;
		mLength -= 16;
		x = ByteIntegerConverter.LoadLittleEndian32(m, mStart - 16);
		x2 = ByteIntegerConverter.LoadLittleEndian32(m, mStart - 12);
		x3 = ByteIntegerConverter.LoadLittleEndian32(m, mStart - 8);
		x4 = ByteIntegerConverter.LoadLittleEndian32(m, mStart - 4);
		num10 += x & 0x3FFFFFF;
		num11 += (uint)(int)(((((ulong)x2 << 32) | x) >> 26) & 0x3FFFFFFL);
		num12 += (uint)(int)(((((ulong)x3 << 32) | x2) >> 20) & 0x3FFFFFFL);
		num13 += (uint)(int)(((((ulong)x4 << 32) | x3) >> 14) & 0x3FFFFFFL);
		num14 += (x4 >> 8) | 0x1000000;
		goto IL_0228;
	}
}
