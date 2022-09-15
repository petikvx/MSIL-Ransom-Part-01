namespace Renci.SshNet.Security.Chaos.NaCl.Internal.Ed25519Ref10;

internal static class ScalarOperations
{
	internal static void sc_clamp(byte[] s, int offset)
	{
		s[offset] &= 248;
		s[offset + 31] &= 127;
		s[offset + 31] |= 64;
	}

	private static long load_3(byte[] input, int offset)
	{
		return (long)(input[offset] | ((ulong)input[offset + 1] << 8) | ((ulong)input[offset + 2] << 16));
	}

	private static long load_4(byte[] input, int offset)
	{
		return (long)(input[offset] | ((ulong)input[offset + 1] << 8) | ((ulong)input[offset + 2] << 16) | ((ulong)input[offset + 3] << 24));
	}

	internal static void sc_muladd(byte[] s, byte[] a, byte[] b, byte[] c)
	{
		long num = 0x1FFFFFL & load_3(a, 0);
		long num2 = 0x1FFFFFL & (load_4(a, 2) >> 5);
		long num3 = 0x1FFFFFL & (load_3(a, 5) >> 2);
		long num4 = 0x1FFFFFL & (load_4(a, 7) >> 7);
		long num5 = 0x1FFFFFL & (load_4(a, 10) >> 4);
		long num6 = 0x1FFFFFL & (load_3(a, 13) >> 1);
		long num7 = 0x1FFFFFL & (load_4(a, 15) >> 6);
		long num8 = 0x1FFFFFL & (load_3(a, 18) >> 3);
		long num9 = 0x1FFFFFL & load_3(a, 21);
		long num10 = 0x1FFFFFL & (load_4(a, 23) >> 5);
		long num11 = 0x1FFFFFL & (load_3(a, 26) >> 2);
		long num12 = load_4(a, 28) >> 7;
		long num13 = 0x1FFFFFL & load_3(b, 0);
		long num14 = 0x1FFFFFL & (load_4(b, 2) >> 5);
		long num15 = 0x1FFFFFL & (load_3(b, 5) >> 2);
		long num16 = 0x1FFFFFL & (load_4(b, 7) >> 7);
		long num17 = 0x1FFFFFL & (load_4(b, 10) >> 4);
		long num18 = 0x1FFFFFL & (load_3(b, 13) >> 1);
		long num19 = 0x1FFFFFL & (load_4(b, 15) >> 6);
		long num20 = 0x1FFFFFL & (load_3(b, 18) >> 3);
		long num21 = 0x1FFFFFL & load_3(b, 21);
		long num22 = 0x1FFFFFL & (load_4(b, 23) >> 5);
		long num23 = 0x1FFFFFL & (load_3(b, 26) >> 2);
		long num24 = load_4(b, 28) >> 7;
		long num25 = 0x1FFFFFL & load_3(c, 0);
		long num26 = 0x1FFFFFL & (load_4(c, 2) >> 5);
		long num27 = 0x1FFFFFL & (load_3(c, 5) >> 2);
		long num28 = 0x1FFFFFL & (load_4(c, 7) >> 7);
		long num29 = 0x1FFFFFL & (load_4(c, 10) >> 4);
		long num30 = 0x1FFFFFL & (load_3(c, 13) >> 1);
		long num31 = 0x1FFFFFL & (load_4(c, 15) >> 6);
		long num32 = 0x1FFFFFL & (load_3(c, 18) >> 3);
		long num33 = 0x1FFFFFL & load_3(c, 21);
		long num34 = 0x1FFFFFL & (load_4(c, 23) >> 5);
		long num35 = 0x1FFFFFL & (load_3(c, 26) >> 2);
		long num36 = load_4(c, 28) >> 7;
		long num37 = num25 + num * num13;
		long num38 = num26 + num * num14 + num2 * num13;
		long num39 = num27 + num * num15 + num2 * num14 + num3 * num13;
		long num40 = num28 + num * num16 + num2 * num15 + num3 * num14 + num4 * num13;
		long num41 = num29 + num * num17 + num2 * num16 + num3 * num15 + num4 * num14 + num5 * num13;
		long num42 = num30 + num * num18 + num2 * num17 + num3 * num16 + num4 * num15 + num5 * num14 + num6 * num13;
		long num43 = num31 + num * num19 + num2 * num18 + num3 * num17 + num4 * num16 + num5 * num15 + num6 * num14 + num7 * num13;
		long num44 = num32 + num * num20 + num2 * num19 + num3 * num18 + num4 * num17 + num5 * num16 + num6 * num15 + num7 * num14 + num8 * num13;
		long num45 = num33 + num * num21 + num2 * num20 + num3 * num19 + num4 * num18 + num5 * num17 + num6 * num16 + num7 * num15 + num8 * num14 + num9 * num13;
		long num46 = num34 + num * num22 + num2 * num21 + num3 * num20 + num4 * num19 + num5 * num18 + num6 * num17 + num7 * num16 + num8 * num15 + num9 * num14 + num10 * num13;
		long num47 = num35 + num * num23 + num2 * num22 + num3 * num21 + num4 * num20 + num5 * num19 + num6 * num18 + num7 * num17 + num8 * num16 + num9 * num15 + num10 * num14 + num11 * num13;
		long num48 = num36 + num * num24 + num2 * num23 + num3 * num22 + num4 * num21 + num5 * num20 + num6 * num19 + num7 * num18 + num8 * num17 + num9 * num16 + num10 * num15 + num11 * num14 + num12 * num13;
		long num49 = num2 * num24 + num3 * num23 + num4 * num22 + num5 * num21 + num6 * num20 + num7 * num19 + num8 * num18 + num9 * num17 + num10 * num16 + num11 * num15 + num12 * num14;
		long num50 = num3 * num24 + num4 * num23 + num5 * num22 + num6 * num21 + num7 * num20 + num8 * num19 + num9 * num18 + num10 * num17 + num11 * num16 + num12 * num15;
		long num51 = num4 * num24 + num5 * num23 + num6 * num22 + num7 * num21 + num8 * num20 + num9 * num19 + num10 * num18 + num11 * num17 + num12 * num16;
		long num52 = num5 * num24 + num6 * num23 + num7 * num22 + num8 * num21 + num9 * num20 + num10 * num19 + num11 * num18 + num12 * num17;
		long num53 = num6 * num24 + num7 * num23 + num8 * num22 + num9 * num21 + num10 * num20 + num11 * num19 + num12 * num18;
		long num54 = num7 * num24 + num8 * num23 + num9 * num22 + num10 * num21 + num11 * num20 + num12 * num19;
		long num55 = num8 * num24 + num9 * num23 + num10 * num22 + num11 * num21 + num12 * num20;
		long num56 = num9 * num24 + num10 * num23 + num11 * num22 + num12 * num21;
		long num57 = num10 * num24 + num11 * num23 + num12 * num22;
		long num58 = num11 * num24 + num12 * num23;
		long num59 = num12 * num24;
		long num60 = 0L;
		long num61 = num37 + 1048576L >> 21;
		num38 += num61;
		num37 -= num61 << 21;
		long num62 = num39 + 1048576L >> 21;
		num40 += num62;
		num39 -= num62 << 21;
		long num63 = num41 + 1048576L >> 21;
		num42 += num63;
		num41 -= num63 << 21;
		long num64 = num43 + 1048576L >> 21;
		num44 += num64;
		num43 -= num64 << 21;
		long num65 = num45 + 1048576L >> 21;
		num46 += num65;
		num45 -= num65 << 21;
		long num66 = num47 + 1048576L >> 21;
		num48 += num66;
		num47 -= num66 << 21;
		long num67 = num49 + 1048576L >> 21;
		num50 += num67;
		num49 -= num67 << 21;
		long num68 = num51 + 1048576L >> 21;
		num52 += num68;
		num51 -= num68 << 21;
		long num69 = num53 + 1048576L >> 21;
		num54 += num69;
		num53 -= num69 << 21;
		long num70 = num55 + 1048576L >> 21;
		num56 += num70;
		num55 -= num70 << 21;
		long num71 = num57 + 1048576L >> 21;
		num58 += num71;
		num57 -= num71 << 21;
		long num72 = num59 + 1048576L >> 21;
		num60 = 0L + num72;
		num59 -= num72 << 21;
		long num73 = num38 + 1048576L >> 21;
		num39 += num73;
		num38 -= num73 << 21;
		long num74 = num40 + 1048576L >> 21;
		num41 += num74;
		num40 -= num74 << 21;
		long num75 = num42 + 1048576L >> 21;
		num43 += num75;
		num42 -= num75 << 21;
		long num76 = num44 + 1048576L >> 21;
		num45 += num76;
		num44 -= num76 << 21;
		long num77 = num46 + 1048576L >> 21;
		num47 += num77;
		num46 -= num77 << 21;
		long num78 = num48 + 1048576L >> 21;
		num49 += num78;
		num48 -= num78 << 21;
		long num79 = num50 + 1048576L >> 21;
		num51 += num79;
		num50 -= num79 << 21;
		long num80 = num52 + 1048576L >> 21;
		num53 += num80;
		num52 -= num80 << 21;
		long num81 = num54 + 1048576L >> 21;
		num55 += num81;
		num54 -= num81 << 21;
		long num82 = num56 + 1048576L >> 21;
		num57 += num82;
		num56 -= num82 << 21;
		long num83 = num58 + 1048576L >> 21;
		num59 += num83;
		num58 -= num83 << 21;
		num48 += num60 * 666643L;
		num49 += num60 * 470296L;
		num50 += num60 * 654183L;
		num51 -= num60 * 997805L;
		num52 += num60 * 136657L;
		num53 -= num60 * 683901L;
		num60 = 0L;
		num47 += num59 * 666643L;
		num48 += num59 * 470296L;
		num49 += num59 * 654183L;
		num50 -= num59 * 997805L;
		num51 += num59 * 136657L;
		num52 -= num59 * 683901L;
		num59 = 0L;
		num46 += num58 * 666643L;
		num47 += num58 * 470296L;
		num48 += num58 * 654183L;
		num49 -= num58 * 997805L;
		num50 += num58 * 136657L;
		num51 -= num58 * 683901L;
		num58 = 0L;
		num45 += num57 * 666643L;
		num46 += num57 * 470296L;
		num47 += num57 * 654183L;
		num48 -= num57 * 997805L;
		num49 += num57 * 136657L;
		num50 -= num57 * 683901L;
		num57 = 0L;
		num44 += num56 * 666643L;
		num45 += num56 * 470296L;
		num46 += num56 * 654183L;
		num47 -= num56 * 997805L;
		num48 += num56 * 136657L;
		num49 -= num56 * 683901L;
		num56 = 0L;
		num43 += num55 * 666643L;
		num44 += num55 * 470296L;
		num45 += num55 * 654183L;
		num46 -= num55 * 997805L;
		num47 += num55 * 136657L;
		num48 -= num55 * 683901L;
		num55 = 0L;
		num64 = num43 + 1048576L >> 21;
		num44 += num64;
		num43 -= num64 << 21;
		num65 = num45 + 1048576L >> 21;
		num46 += num65;
		num45 -= num65 << 21;
		num66 = num47 + 1048576L >> 21;
		num48 += num66;
		num47 -= num66 << 21;
		num67 = num49 + 1048576L >> 21;
		num50 += num67;
		num49 -= num67 << 21;
		num68 = num51 + 1048576L >> 21;
		num52 += num68;
		num51 -= num68 << 21;
		num69 = num53 + 1048576L >> 21;
		num54 += num69;
		num53 -= num69 << 21;
		num76 = num44 + 1048576L >> 21;
		num45 += num76;
		num44 -= num76 << 21;
		num77 = num46 + 1048576L >> 21;
		num47 += num77;
		num46 -= num77 << 21;
		num78 = num48 + 1048576L >> 21;
		num49 += num78;
		num48 -= num78 << 21;
		num79 = num50 + 1048576L >> 21;
		num51 += num79;
		num50 -= num79 << 21;
		num80 = num52 + 1048576L >> 21;
		num53 += num80;
		num52 -= num80 << 21;
		num42 += num54 * 666643L;
		num43 += num54 * 470296L;
		num44 += num54 * 654183L;
		num45 -= num54 * 997805L;
		num46 += num54 * 136657L;
		num47 -= num54 * 683901L;
		num54 = 0L;
		num41 += num53 * 666643L;
		num42 += num53 * 470296L;
		num43 += num53 * 654183L;
		num44 -= num53 * 997805L;
		num45 += num53 * 136657L;
		num46 -= num53 * 683901L;
		num53 = 0L;
		num40 += num52 * 666643L;
		num41 += num52 * 470296L;
		num42 += num52 * 654183L;
		num43 -= num52 * 997805L;
		num44 += num52 * 136657L;
		num45 -= num52 * 683901L;
		num52 = 0L;
		num39 += num51 * 666643L;
		num40 += num51 * 470296L;
		num41 += num51 * 654183L;
		num42 -= num51 * 997805L;
		num43 += num51 * 136657L;
		num44 -= num51 * 683901L;
		num51 = 0L;
		num38 += num50 * 666643L;
		num39 += num50 * 470296L;
		num40 += num50 * 654183L;
		num41 -= num50 * 997805L;
		num42 += num50 * 136657L;
		num43 -= num50 * 683901L;
		num50 = 0L;
		num37 += num49 * 666643L;
		num38 += num49 * 470296L;
		num39 += num49 * 654183L;
		num40 -= num49 * 997805L;
		num41 += num49 * 136657L;
		num42 -= num49 * 683901L;
		num49 = 0L;
		num61 = num37 + 1048576L >> 21;
		num38 += num61;
		num37 -= num61 << 21;
		num62 = num39 + 1048576L >> 21;
		num40 += num62;
		num39 -= num62 << 21;
		num63 = num41 + 1048576L >> 21;
		num42 += num63;
		num41 -= num63 << 21;
		num64 = num43 + 1048576L >> 21;
		num44 += num64;
		num43 -= num64 << 21;
		num65 = num45 + 1048576L >> 21;
		num46 += num65;
		num45 -= num65 << 21;
		num66 = num47 + 1048576L >> 21;
		num48 += num66;
		num47 -= num66 << 21;
		num73 = num38 + 1048576L >> 21;
		num39 += num73;
		num38 -= num73 << 21;
		num74 = num40 + 1048576L >> 21;
		num41 += num74;
		num40 -= num74 << 21;
		num75 = num42 + 1048576L >> 21;
		num43 += num75;
		num42 -= num75 << 21;
		num76 = num44 + 1048576L >> 21;
		num45 += num76;
		num44 -= num76 << 21;
		num77 = num46 + 1048576L >> 21;
		num47 += num77;
		num46 -= num77 << 21;
		num78 = num48 + 1048576L >> 21;
		num49 = 0L + num78;
		num48 -= num78 << 21;
		num37 += num49 * 666643L;
		num38 += num49 * 470296L;
		num39 += num49 * 654183L;
		num40 -= num49 * 997805L;
		num41 += num49 * 136657L;
		num42 -= num49 * 683901L;
		num49 = 0L;
		num61 = num37 >> 21;
		num38 += num61;
		num37 -= num61 << 21;
		num73 = num38 >> 21;
		num39 += num73;
		num38 -= num73 << 21;
		num62 = num39 >> 21;
		num40 += num62;
		num39 -= num62 << 21;
		num74 = num40 >> 21;
		num41 += num74;
		num40 -= num74 << 21;
		num63 = num41 >> 21;
		num42 += num63;
		num41 -= num63 << 21;
		num75 = num42 >> 21;
		num43 += num75;
		num42 -= num75 << 21;
		num64 = num43 >> 21;
		num44 += num64;
		num43 -= num64 << 21;
		num76 = num44 >> 21;
		num45 += num76;
		num44 -= num76 << 21;
		num65 = num45 >> 21;
		num46 += num65;
		num45 -= num65 << 21;
		num77 = num46 >> 21;
		num47 += num77;
		num46 -= num77 << 21;
		num66 = num47 >> 21;
		num48 += num66;
		num47 -= num66 << 21;
		num78 = num48 >> 21;
		num49 = 0L + num78;
		num48 -= num78 << 21;
		num37 += num49 * 666643L;
		num38 += num49 * 470296L;
		num39 += num49 * 654183L;
		num40 -= num49 * 997805L;
		num41 += num49 * 136657L;
		num42 -= num49 * 683901L;
		num49 = 0L;
		num61 = num37 >> 21;
		num38 += num61;
		num37 -= num61 << 21;
		num73 = num38 >> 21;
		num39 += num73;
		num38 -= num73 << 21;
		num62 = num39 >> 21;
		num40 += num62;
		num39 -= num62 << 21;
		num74 = num40 >> 21;
		num41 += num74;
		num40 -= num74 << 21;
		num63 = num41 >> 21;
		num42 += num63;
		num41 -= num63 << 21;
		num75 = num42 >> 21;
		num43 += num75;
		num42 -= num75 << 21;
		num64 = num43 >> 21;
		num44 += num64;
		num43 -= num64 << 21;
		num76 = num44 >> 21;
		num45 += num76;
		num44 -= num76 << 21;
		num65 = num45 >> 21;
		num46 += num65;
		num45 -= num65 << 21;
		num77 = num46 >> 21;
		num47 += num77;
		num46 -= num77 << 21;
		num66 = num47 >> 21;
		num48 += num66;
		num47 -= num66 << 21;
		s[0] = (byte)num37;
		s[1] = (byte)(num37 >> 8);
		s[2] = (byte)((num37 >> 16) | (num38 << 5));
		s[3] = (byte)(num38 >> 3);
		s[4] = (byte)(num38 >> 11);
		s[5] = (byte)((num38 >> 19) | (num39 << 2));
		s[6] = (byte)(num39 >> 6);
		s[7] = (byte)((num39 >> 14) | (num40 << 7));
		s[8] = (byte)(num40 >> 1);
		s[9] = (byte)(num40 >> 9);
		s[10] = (byte)((num40 >> 17) | (num41 << 4));
		s[11] = (byte)(num41 >> 4);
		s[12] = (byte)(num41 >> 12);
		s[13] = (byte)((num41 >> 20) | (num42 << 1));
		s[14] = (byte)(num42 >> 7);
		s[15] = (byte)((num42 >> 15) | (num43 << 6));
		s[16] = (byte)(num43 >> 2);
		s[17] = (byte)(num43 >> 10);
		s[18] = (byte)((num43 >> 18) | (num44 << 3));
		s[19] = (byte)(num44 >> 5);
		s[20] = (byte)(num44 >> 13);
		s[21] = (byte)num45;
		s[22] = (byte)(num45 >> 8);
		s[23] = (byte)((num45 >> 16) | (num46 << 5));
		s[24] = (byte)(num46 >> 3);
		s[25] = (byte)(num46 >> 11);
		s[26] = (byte)((num46 >> 19) | (num47 << 2));
		s[27] = (byte)(num47 >> 6);
		s[28] = (byte)((num47 >> 14) | (num48 << 7));
		s[29] = (byte)(num48 >> 1);
		s[30] = (byte)(num48 >> 9);
		s[31] = (byte)(num48 >> 17);
	}

	internal static void sc_reduce(byte[] s)
	{
		long num = 0x1FFFFFL & load_3(s, 0);
		long num2 = 0x1FFFFFL & (load_4(s, 2) >> 5);
		long num3 = 0x1FFFFFL & (load_3(s, 5) >> 2);
		long num4 = 0x1FFFFFL & (load_4(s, 7) >> 7);
		long num5 = 0x1FFFFFL & (load_4(s, 10) >> 4);
		long num6 = 0x1FFFFFL & (load_3(s, 13) >> 1);
		long num7 = 0x1FFFFFL & (load_4(s, 15) >> 6);
		long num8 = 0x1FFFFFL & (load_3(s, 18) >> 3);
		long num9 = 0x1FFFFFL & load_3(s, 21);
		long num10 = 0x1FFFFFL & (load_4(s, 23) >> 5);
		long num11 = 0x1FFFFFL & (load_3(s, 26) >> 2);
		long num12 = 0x1FFFFFL & (load_4(s, 28) >> 7);
		long num13 = 0x1FFFFFL & (load_4(s, 31) >> 4);
		long num14 = 0x1FFFFFL & (load_3(s, 34) >> 1);
		long num15 = 0x1FFFFFL & (load_4(s, 36) >> 6);
		long num16 = 0x1FFFFFL & (load_3(s, 39) >> 3);
		long num17 = 0x1FFFFFL & load_3(s, 42);
		long num18 = 0x1FFFFFL & (load_4(s, 44) >> 5);
		long num19 = 0x1FFFFFL & (load_3(s, 47) >> 2);
		long num20 = 0x1FFFFFL & (load_4(s, 49) >> 7);
		long num21 = 0x1FFFFFL & (load_4(s, 52) >> 4);
		long num22 = 0x1FFFFFL & (load_3(s, 55) >> 1);
		long num23 = 0x1FFFFFL & (load_4(s, 57) >> 6);
		long num24 = load_4(s, 60) >> 3;
		num12 += num24 * 666643L;
		num13 += num24 * 470296L;
		num14 += num24 * 654183L;
		num15 -= num24 * 997805L;
		num16 += num24 * 136657L;
		num17 -= num24 * 683901L;
		num24 = 0L;
		num11 += num23 * 666643L;
		num12 += num23 * 470296L;
		num13 += num23 * 654183L;
		num14 -= num23 * 997805L;
		num15 += num23 * 136657L;
		num16 -= num23 * 683901L;
		num23 = 0L;
		num10 += num22 * 666643L;
		num11 += num22 * 470296L;
		num12 += num22 * 654183L;
		num13 -= num22 * 997805L;
		num14 += num22 * 136657L;
		num15 -= num22 * 683901L;
		num22 = 0L;
		num9 += num21 * 666643L;
		num10 += num21 * 470296L;
		num11 += num21 * 654183L;
		num12 -= num21 * 997805L;
		num13 += num21 * 136657L;
		num14 -= num21 * 683901L;
		num21 = 0L;
		num8 += num20 * 666643L;
		num9 += num20 * 470296L;
		num10 += num20 * 654183L;
		num11 -= num20 * 997805L;
		num12 += num20 * 136657L;
		num13 -= num20 * 683901L;
		num20 = 0L;
		num7 += num19 * 666643L;
		num8 += num19 * 470296L;
		num9 += num19 * 654183L;
		num10 -= num19 * 997805L;
		num11 += num19 * 136657L;
		num12 -= num19 * 683901L;
		num19 = 0L;
		long num25 = num7 + 1048576L >> 21;
		num8 += num25;
		num7 -= num25 << 21;
		long num26 = num9 + 1048576L >> 21;
		num10 += num26;
		num9 -= num26 << 21;
		long num27 = num11 + 1048576L >> 21;
		num12 += num27;
		num11 -= num27 << 21;
		long num28 = num13 + 1048576L >> 21;
		num14 += num28;
		num13 -= num28 << 21;
		long num29 = num15 + 1048576L >> 21;
		num16 += num29;
		num15 -= num29 << 21;
		long num30 = num17 + 1048576L >> 21;
		num18 += num30;
		num17 -= num30 << 21;
		long num31 = num8 + 1048576L >> 21;
		num9 += num31;
		num8 -= num31 << 21;
		long num32 = num10 + 1048576L >> 21;
		num11 += num32;
		num10 -= num32 << 21;
		long num33 = num12 + 1048576L >> 21;
		num13 += num33;
		num12 -= num33 << 21;
		long num34 = num14 + 1048576L >> 21;
		num15 += num34;
		num14 -= num34 << 21;
		long num35 = num16 + 1048576L >> 21;
		num17 += num35;
		num16 -= num35 << 21;
		num6 += num18 * 666643L;
		num7 += num18 * 470296L;
		num8 += num18 * 654183L;
		num9 -= num18 * 997805L;
		num10 += num18 * 136657L;
		num11 -= num18 * 683901L;
		num18 = 0L;
		num5 += num17 * 666643L;
		num6 += num17 * 470296L;
		num7 += num17 * 654183L;
		num8 -= num17 * 997805L;
		num9 += num17 * 136657L;
		num10 -= num17 * 683901L;
		num17 = 0L;
		num4 += num16 * 666643L;
		num5 += num16 * 470296L;
		num6 += num16 * 654183L;
		num7 -= num16 * 997805L;
		num8 += num16 * 136657L;
		num9 -= num16 * 683901L;
		num16 = 0L;
		num3 += num15 * 666643L;
		num4 += num15 * 470296L;
		num5 += num15 * 654183L;
		num6 -= num15 * 997805L;
		num7 += num15 * 136657L;
		num8 -= num15 * 683901L;
		num15 = 0L;
		num2 += num14 * 666643L;
		num3 += num14 * 470296L;
		num4 += num14 * 654183L;
		num5 -= num14 * 997805L;
		num6 += num14 * 136657L;
		num7 -= num14 * 683901L;
		num14 = 0L;
		num += num13 * 666643L;
		num2 += num13 * 470296L;
		num3 += num13 * 654183L;
		num4 -= num13 * 997805L;
		num5 += num13 * 136657L;
		num6 -= num13 * 683901L;
		num13 = 0L;
		long num36 = num + 1048576L >> 21;
		num2 += num36;
		num -= num36 << 21;
		long num37 = num3 + 1048576L >> 21;
		num4 += num37;
		num3 -= num37 << 21;
		long num38 = num5 + 1048576L >> 21;
		num6 += num38;
		num5 -= num38 << 21;
		num25 = num7 + 1048576L >> 21;
		num8 += num25;
		num7 -= num25 << 21;
		num26 = num9 + 1048576L >> 21;
		num10 += num26;
		num9 -= num26 << 21;
		num27 = num11 + 1048576L >> 21;
		num12 += num27;
		num11 -= num27 << 21;
		long num39 = num2 + 1048576L >> 21;
		num3 += num39;
		num2 -= num39 << 21;
		long num40 = num4 + 1048576L >> 21;
		num5 += num40;
		num4 -= num40 << 21;
		long num41 = num6 + 1048576L >> 21;
		num7 += num41;
		num6 -= num41 << 21;
		num31 = num8 + 1048576L >> 21;
		num9 += num31;
		num8 -= num31 << 21;
		num32 = num10 + 1048576L >> 21;
		num11 += num32;
		num10 -= num32 << 21;
		num33 = num12 + 1048576L >> 21;
		num13 = 0L + num33;
		num12 -= num33 << 21;
		num += num13 * 666643L;
		num2 += num13 * 470296L;
		num3 += num13 * 654183L;
		num4 -= num13 * 997805L;
		num5 += num13 * 136657L;
		num6 -= num13 * 683901L;
		num13 = 0L;
		num36 = num >> 21;
		num2 += num36;
		num -= num36 << 21;
		num39 = num2 >> 21;
		num3 += num39;
		num2 -= num39 << 21;
		num37 = num3 >> 21;
		num4 += num37;
		num3 -= num37 << 21;
		num40 = num4 >> 21;
		num5 += num40;
		num4 -= num40 << 21;
		num38 = num5 >> 21;
		num6 += num38;
		num5 -= num38 << 21;
		num41 = num6 >> 21;
		num7 += num41;
		num6 -= num41 << 21;
		num25 = num7 >> 21;
		num8 += num25;
		num7 -= num25 << 21;
		num31 = num8 >> 21;
		num9 += num31;
		num8 -= num31 << 21;
		num26 = num9 >> 21;
		num10 += num26;
		num9 -= num26 << 21;
		num32 = num10 >> 21;
		num11 += num32;
		num10 -= num32 << 21;
		num27 = num11 >> 21;
		num12 += num27;
		num11 -= num27 << 21;
		num33 = num12 >> 21;
		num13 = 0L + num33;
		num12 -= num33 << 21;
		num += num13 * 666643L;
		num2 += num13 * 470296L;
		num3 += num13 * 654183L;
		num4 -= num13 * 997805L;
		num5 += num13 * 136657L;
		num6 -= num13 * 683901L;
		num13 = 0L;
		num36 = num >> 21;
		num2 += num36;
		num -= num36 << 21;
		num39 = num2 >> 21;
		num3 += num39;
		num2 -= num39 << 21;
		num37 = num3 >> 21;
		num4 += num37;
		num3 -= num37 << 21;
		num40 = num4 >> 21;
		num5 += num40;
		num4 -= num40 << 21;
		num38 = num5 >> 21;
		num6 += num38;
		num5 -= num38 << 21;
		num41 = num6 >> 21;
		num7 += num41;
		num6 -= num41 << 21;
		num25 = num7 >> 21;
		num8 += num25;
		num7 -= num25 << 21;
		num31 = num8 >> 21;
		num9 += num31;
		num8 -= num31 << 21;
		num26 = num9 >> 21;
		num10 += num26;
		num9 -= num26 << 21;
		num32 = num10 >> 21;
		num11 += num32;
		num10 -= num32 << 21;
		num27 = num11 >> 21;
		num12 += num27;
		num11 -= num27 << 21;
		s[0] = (byte)num;
		s[1] = (byte)(num >> 8);
		s[2] = (byte)((num >> 16) | (num2 << 5));
		s[3] = (byte)(num2 >> 3);
		s[4] = (byte)(num2 >> 11);
		s[5] = (byte)((num2 >> 19) | (num3 << 2));
		s[6] = (byte)(num3 >> 6);
		s[7] = (byte)((num3 >> 14) | (num4 << 7));
		s[8] = (byte)(num4 >> 1);
		s[9] = (byte)(num4 >> 9);
		s[10] = (byte)((num4 >> 17) | (num5 << 4));
		s[11] = (byte)(num5 >> 4);
		s[12] = (byte)(num5 >> 12);
		s[13] = (byte)((num5 >> 20) | (num6 << 1));
		s[14] = (byte)(num6 >> 7);
		s[15] = (byte)((num6 >> 15) | (num7 << 6));
		s[16] = (byte)(num7 >> 2);
		s[17] = (byte)(num7 >> 10);
		s[18] = (byte)((num7 >> 18) | (num8 << 3));
		s[19] = (byte)(num8 >> 5);
		s[20] = (byte)(num8 >> 13);
		s[21] = (byte)num9;
		s[22] = (byte)(num9 >> 8);
		s[23] = (byte)((num9 >> 16) | (num10 << 5));
		s[24] = (byte)(num10 >> 3);
		s[25] = (byte)(num10 >> 11);
		s[26] = (byte)((num10 >> 19) | (num11 << 2));
		s[27] = (byte)(num11 >> 6);
		s[28] = (byte)((num11 >> 14) | (num12 << 7));
		s[29] = (byte)(num12 >> 1);
		s[30] = (byte)(num12 >> 9);
		s[31] = (byte)(num12 >> 17);
	}
}