namespace Renci.SshNet.Security.Chaos.NaCl.Internal.Ed25519Ref10;

internal static class FieldOperations
{
	internal static void fe_0(out FieldElement h)
	{
		h = default(FieldElement);
	}

	internal static void fe_1(out FieldElement h)
	{
		h = default(FieldElement);
		h.x0 = 1;
	}

	internal static void fe_add(out FieldElement h, ref FieldElement f, ref FieldElement g)
	{
		int x = f.x0;
		int x2 = f.x1;
		int x3 = f.x2;
		int x4 = f.x3;
		int x5 = f.x4;
		int x6 = f.x5;
		int x7 = f.x6;
		int x8 = f.x7;
		int x9 = f.x8;
		int x10 = f.x9;
		int x11 = g.x0;
		int x12 = g.x1;
		int x13 = g.x2;
		int x14 = g.x3;
		int x15 = g.x4;
		int x16 = g.x5;
		int x17 = g.x6;
		int x18 = g.x7;
		int x19 = g.x8;
		int x20 = g.x9;
		int x21 = x + x11;
		int x22 = x2 + x12;
		int x23 = x3 + x13;
		int x24 = x4 + x14;
		int x25 = x5 + x15;
		int x26 = x6 + x16;
		int x27 = x7 + x17;
		int x28 = x8 + x18;
		int x29 = x9 + x19;
		int x30 = x10 + x20;
		h.x0 = x21;
		h.x1 = x22;
		h.x2 = x23;
		h.x3 = x24;
		h.x4 = x25;
		h.x5 = x26;
		h.x6 = x27;
		h.x7 = x28;
		h.x8 = x29;
		h.x9 = x30;
	}

	internal static void fe_cmov(ref FieldElement f, ref FieldElement g, int b)
	{
		int x = f.x0;
		int x2 = f.x1;
		int x3 = f.x2;
		int x4 = f.x3;
		int x5 = f.x4;
		int x6 = f.x5;
		int x7 = f.x6;
		int x8 = f.x7;
		int x9 = f.x8;
		int x10 = f.x9;
		int x11 = g.x0;
		int x12 = g.x1;
		int x13 = g.x2;
		int x14 = g.x3;
		int x15 = g.x4;
		int x16 = g.x5;
		int x17 = g.x6;
		int x18 = g.x7;
		int x19 = g.x8;
		int x20 = g.x9;
		int num = x ^ x11;
		int num2 = x2 ^ x12;
		int num3 = x3 ^ x13;
		int num4 = x4 ^ x14;
		int num5 = x5 ^ x15;
		int num6 = x6 ^ x16;
		int num7 = x7 ^ x17;
		int num8 = x8 ^ x18;
		int num9 = x9 ^ x19;
		int num10 = x10 ^ x20;
		b = -b;
		num &= b;
		num2 &= b;
		num3 &= b;
		num4 &= b;
		num5 &= b;
		num6 &= b;
		num7 &= b;
		num8 &= b;
		num9 &= b;
		num10 &= b;
		f.x0 = x ^ num;
		f.x1 = x2 ^ num2;
		f.x2 = x3 ^ num3;
		f.x3 = x4 ^ num4;
		f.x4 = x5 ^ num5;
		f.x5 = x6 ^ num6;
		f.x6 = x7 ^ num7;
		f.x7 = x8 ^ num8;
		f.x8 = x9 ^ num9;
		f.x9 = x10 ^ num10;
	}

	internal static void fe_cswap(ref FieldElement f, ref FieldElement g, uint b)
	{
		int x = f.x0;
		int x2 = f.x1;
		int x3 = f.x2;
		int x4 = f.x3;
		int x5 = f.x4;
		int x6 = f.x5;
		int x7 = f.x6;
		int x8 = f.x7;
		int x9 = f.x8;
		int x10 = f.x9;
		int x11 = g.x0;
		int x12 = g.x1;
		int x13 = g.x2;
		int x14 = g.x3;
		int x15 = g.x4;
		int x16 = g.x5;
		int x17 = g.x6;
		int x18 = g.x7;
		int x19 = g.x8;
		int x20 = g.x9;
		int num = x ^ x11;
		int num2 = x2 ^ x12;
		int num3 = x3 ^ x13;
		int num4 = x4 ^ x14;
		int num5 = x5 ^ x15;
		int num6 = x6 ^ x16;
		int num7 = x7 ^ x17;
		int num8 = x8 ^ x18;
		int num9 = x9 ^ x19;
		int num10 = x10 ^ x20;
		int num11 = (int)(0L - (long)b);
		num &= num11;
		num2 &= num11;
		num3 &= num11;
		num4 &= num11;
		num5 &= num11;
		num6 &= num11;
		num7 &= num11;
		num8 &= num11;
		num9 &= num11;
		num10 &= num11;
		f.x0 = x ^ num;
		f.x1 = x2 ^ num2;
		f.x2 = x3 ^ num3;
		f.x3 = x4 ^ num4;
		f.x4 = x5 ^ num5;
		f.x5 = x6 ^ num6;
		f.x6 = x7 ^ num7;
		f.x7 = x8 ^ num8;
		f.x8 = x9 ^ num9;
		f.x9 = x10 ^ num10;
		g.x0 = x11 ^ num;
		g.x1 = x12 ^ num2;
		g.x2 = x13 ^ num3;
		g.x3 = x14 ^ num4;
		g.x4 = x15 ^ num5;
		g.x5 = x16 ^ num6;
		g.x6 = x17 ^ num7;
		g.x7 = x18 ^ num8;
		g.x8 = x19 ^ num9;
		g.x9 = x20 ^ num10;
	}

	private static long load_3(byte[] data, int offset)
	{
		return (uint)(data[offset] | (data[offset + 1] << 8) | (data[offset + 2] << 16));
	}

	private static long load_4(byte[] data, int offset)
	{
		return (uint)(data[offset] | (data[offset + 1] << 8) | (data[offset + 2] << 16) | (data[offset + 3] << 24));
	}

	internal static void fe_frombytes(out FieldElement h, byte[] data, int offset)
	{
		long num = load_4(data, offset);
		long num2 = load_3(data, offset + 4) << 6;
		long num3 = load_3(data, offset + 7) << 5;
		long num4 = load_3(data, offset + 10) << 3;
		long num5 = load_3(data, offset + 13) << 2;
		long num6 = load_4(data, offset + 16);
		long num7 = load_3(data, offset + 20) << 7;
		long num8 = load_3(data, offset + 23) << 5;
		long num9 = load_3(data, offset + 26) << 4;
		long num10 = (load_3(data, offset + 29) & 0x7FFFFFL) << 2;
		long num11 = num10 + 16777216L >> 25;
		num += num11 * 19L;
		num10 -= num11 << 25;
		long num12 = num2 + 16777216L >> 25;
		num3 += num12;
		num2 -= num12 << 25;
		long num13 = num4 + 16777216L >> 25;
		num5 += num13;
		num4 -= num13 << 25;
		long num14 = num6 + 16777216L >> 25;
		num7 += num14;
		num6 -= num14 << 25;
		long num15 = num8 + 16777216L >> 25;
		num9 += num15;
		num8 -= num15 << 25;
		long num16 = num + 33554432L >> 26;
		num2 += num16;
		num -= num16 << 26;
		long num17 = num3 + 33554432L >> 26;
		num4 += num17;
		num3 -= num17 << 26;
		long num18 = num5 + 33554432L >> 26;
		num6 += num18;
		num5 -= num18 << 26;
		long num19 = num7 + 33554432L >> 26;
		num8 += num19;
		num7 -= num19 << 26;
		long num20 = num9 + 33554432L >> 26;
		num10 += num20;
		num9 -= num20 << 26;
		h.x0 = (int)num;
		h.x1 = (int)num2;
		h.x2 = (int)num3;
		h.x3 = (int)num4;
		h.x4 = (int)num5;
		h.x5 = (int)num6;
		h.x6 = (int)num7;
		h.x7 = (int)num8;
		h.x8 = (int)num9;
		h.x9 = (int)num10;
	}

	internal static void fe_frombytes2(out FieldElement h, byte[] data, int offset)
	{
		long num = load_4(data, offset);
		long num2 = load_3(data, offset + 4) << 6;
		long num3 = load_3(data, offset + 7) << 5;
		long num4 = load_3(data, offset + 10) << 3;
		long num5 = load_3(data, offset + 13) << 2;
		long num6 = load_4(data, offset + 16);
		long num7 = load_3(data, offset + 20) << 7;
		long num8 = load_3(data, offset + 23) << 5;
		long num9 = load_3(data, offset + 26) << 4;
		long num10 = load_3(data, offset + 29) << 2;
		long num11 = num10 + 16777216L >> 25;
		num += num11 * 19L;
		num10 -= num11 << 25;
		long num12 = num2 + 16777216L >> 25;
		num3 += num12;
		num2 -= num12 << 25;
		long num13 = num4 + 16777216L >> 25;
		num5 += num13;
		num4 -= num13 << 25;
		long num14 = num6 + 16777216L >> 25;
		num7 += num14;
		num6 -= num14 << 25;
		long num15 = num8 + 16777216L >> 25;
		num9 += num15;
		num8 -= num15 << 25;
		long num16 = num + 33554432L >> 26;
		num2 += num16;
		num -= num16 << 26;
		long num17 = num3 + 33554432L >> 26;
		num4 += num17;
		num3 -= num17 << 26;
		long num18 = num5 + 33554432L >> 26;
		num6 += num18;
		num5 -= num18 << 26;
		long num19 = num7 + 33554432L >> 26;
		num8 += num19;
		num7 -= num19 << 26;
		long num20 = num9 + 33554432L >> 26;
		num10 += num20;
		num9 -= num20 << 26;
		h.x0 = (int)num;
		h.x1 = (int)num2;
		h.x2 = (int)num3;
		h.x3 = (int)num4;
		h.x4 = (int)num5;
		h.x5 = (int)num6;
		h.x6 = (int)num7;
		h.x7 = (int)num8;
		h.x8 = (int)num9;
		h.x9 = (int)num10;
	}

	internal static void fe_invert(out FieldElement result, ref FieldElement z)
	{
		fe_sq(out var h, ref z);
		fe_sq(out var h2, ref h);
		for (int i = 1; i < 2; i++)
		{
			fe_sq(out h2, ref h2);
		}
		fe_mul(out h2, ref z, ref h2);
		fe_mul(out h, ref h, ref h2);
		fe_sq(out var h3, ref h);
		fe_mul(out h2, ref h2, ref h3);
		fe_sq(out h3, ref h2);
		for (int i = 1; i < 5; i++)
		{
			fe_sq(out h3, ref h3);
		}
		fe_mul(out h2, ref h3, ref h2);
		fe_sq(out h3, ref h2);
		for (int i = 1; i < 10; i++)
		{
			fe_sq(out h3, ref h3);
		}
		fe_mul(out h3, ref h3, ref h2);
		fe_sq(out var h4, ref h3);
		for (int i = 1; i < 20; i++)
		{
			fe_sq(out h4, ref h4);
		}
		fe_mul(out h3, ref h4, ref h3);
		fe_sq(out h3, ref h3);
		for (int i = 1; i < 10; i++)
		{
			fe_sq(out h3, ref h3);
		}
		fe_mul(out h2, ref h3, ref h2);
		fe_sq(out h3, ref h2);
		for (int i = 1; i < 50; i++)
		{
			fe_sq(out h3, ref h3);
		}
		fe_mul(out h3, ref h3, ref h2);
		fe_sq(out h4, ref h3);
		for (int i = 1; i < 100; i++)
		{
			fe_sq(out h4, ref h4);
		}
		fe_mul(out h3, ref h4, ref h3);
		fe_sq(out h3, ref h3);
		for (int i = 1; i < 50; i++)
		{
			fe_sq(out h3, ref h3);
		}
		fe_mul(out h2, ref h3, ref h2);
		fe_sq(out h2, ref h2);
		for (int i = 1; i < 5; i++)
		{
			fe_sq(out h2, ref h2);
		}
		fe_mul(out result, ref h2, ref h);
	}

	internal static int fe_isnegative(ref FieldElement f)
	{
		fe_reduce(out var hr, ref f);
		return hr.x0 & 1;
	}

	internal static int fe_isnonzero(ref FieldElement f)
	{
		fe_reduce(out var hr, ref f);
		return (int)(((uint)((0 | hr.x0 | hr.x1 | hr.x2 | hr.x3 | hr.x4 | hr.x5 | hr.x6 | hr.x7 | hr.x8 | hr.x9) - 1) >> 31) ^ 1);
	}

	internal static void fe_mul(out FieldElement h, ref FieldElement f, ref FieldElement g)
	{
		int x = f.x0;
		int x2 = f.x1;
		int x3 = f.x2;
		int x4 = f.x3;
		int x5 = f.x4;
		int x6 = f.x5;
		int x7 = f.x6;
		int x8 = f.x7;
		int x9 = f.x8;
		int x10 = f.x9;
		int x11 = g.x0;
		int x12 = g.x1;
		int x13 = g.x2;
		int x14 = g.x3;
		int x15 = g.x4;
		int x16 = g.x5;
		int x17 = g.x6;
		int x18 = g.x7;
		int x19 = g.x8;
		int x20 = g.x9;
		int num = 19 * x12;
		int num2 = 19 * x13;
		int num3 = 19 * x14;
		int num4 = 19 * x15;
		int num5 = 19 * x16;
		int num6 = 19 * x17;
		int num7 = 19 * x18;
		int num8 = 19 * x19;
		int num9 = 19 * x20;
		int num10 = 2 * x2;
		int num11 = 2 * x4;
		int num12 = 2 * x6;
		int num13 = 2 * x8;
		int num14 = 2 * x10;
		long num15 = (long)x * (long)x11;
		long num16 = (long)x * (long)x12;
		long num17 = (long)x * (long)x13;
		long num18 = (long)x * (long)x14;
		long num19 = (long)x * (long)x15;
		long num20 = (long)x * (long)x16;
		long num21 = (long)x * (long)x17;
		long num22 = (long)x * (long)x18;
		long num23 = (long)x * (long)x19;
		long num24 = (long)x * (long)x20;
		long num25 = (long)x2 * (long)x11;
		long num26 = (long)num10 * (long)x12;
		long num27 = (long)x2 * (long)x13;
		long num28 = (long)num10 * (long)x14;
		long num29 = (long)x2 * (long)x15;
		long num30 = (long)num10 * (long)x16;
		long num31 = (long)x2 * (long)x17;
		long num32 = (long)num10 * (long)x18;
		long num33 = (long)x2 * (long)x19;
		long num34 = (long)num10 * (long)num9;
		long num35 = (long)x3 * (long)x11;
		long num36 = (long)x3 * (long)x12;
		long num37 = (long)x3 * (long)x13;
		long num38 = (long)x3 * (long)x14;
		long num39 = (long)x3 * (long)x15;
		long num40 = (long)x3 * (long)x16;
		long num41 = (long)x3 * (long)x17;
		long num42 = (long)x3 * (long)x18;
		long num43 = (long)x3 * (long)num8;
		long num44 = (long)x3 * (long)num9;
		long num45 = (long)x4 * (long)x11;
		long num46 = (long)num11 * (long)x12;
		long num47 = (long)x4 * (long)x13;
		long num48 = (long)num11 * (long)x14;
		long num49 = (long)x4 * (long)x15;
		long num50 = (long)num11 * (long)x16;
		long num51 = (long)x4 * (long)x17;
		long num52 = (long)num11 * (long)num7;
		long num53 = (long)x4 * (long)num8;
		long num54 = (long)num11 * (long)num9;
		long num55 = (long)x5 * (long)x11;
		long num56 = (long)x5 * (long)x12;
		long num57 = (long)x5 * (long)x13;
		long num58 = (long)x5 * (long)x14;
		long num59 = (long)x5 * (long)x15;
		long num60 = (long)x5 * (long)x16;
		long num61 = (long)x5 * (long)num6;
		long num62 = (long)x5 * (long)num7;
		long num63 = (long)x5 * (long)num8;
		long num64 = (long)x5 * (long)num9;
		long num65 = (long)x6 * (long)x11;
		long num66 = (long)num12 * (long)x12;
		long num67 = (long)x6 * (long)x13;
		long num68 = (long)num12 * (long)x14;
		long num69 = (long)x6 * (long)x15;
		long num70 = (long)num12 * (long)num5;
		long num71 = (long)x6 * (long)num6;
		long num72 = (long)num12 * (long)num7;
		long num73 = (long)x6 * (long)num8;
		long num74 = (long)num12 * (long)num9;
		long num75 = (long)x7 * (long)x11;
		long num76 = (long)x7 * (long)x12;
		long num77 = (long)x7 * (long)x13;
		long num78 = (long)x7 * (long)x14;
		long num79 = (long)x7 * (long)num4;
		long num80 = (long)x7 * (long)num5;
		long num81 = (long)x7 * (long)num6;
		long num82 = (long)x7 * (long)num7;
		long num83 = (long)x7 * (long)num8;
		long num84 = (long)x7 * (long)num9;
		long num85 = (long)x8 * (long)x11;
		long num86 = (long)num13 * (long)x12;
		long num87 = (long)x8 * (long)x13;
		long num88 = (long)num13 * (long)num3;
		long num89 = (long)x8 * (long)num4;
		long num90 = (long)num13 * (long)num5;
		long num91 = (long)x8 * (long)num6;
		long num92 = (long)num13 * (long)num7;
		long num93 = (long)x8 * (long)num8;
		long num94 = (long)num13 * (long)num9;
		long num95 = (long)x9 * (long)x11;
		long num96 = (long)x9 * (long)x12;
		long num97 = (long)x9 * (long)num2;
		long num98 = (long)x9 * (long)num3;
		long num99 = (long)x9 * (long)num4;
		long num100 = (long)x9 * (long)num5;
		long num101 = (long)x9 * (long)num6;
		long num102 = (long)x9 * (long)num7;
		long num103 = (long)x9 * (long)num8;
		long num104 = (long)x9 * (long)num9;
		long num105 = (long)x10 * (long)x11;
		long num106 = (long)num14 * (long)num;
		long num107 = (long)x10 * (long)num2;
		long num108 = (long)num14 * (long)num3;
		long num109 = (long)x10 * (long)num4;
		long num110 = (long)num14 * (long)num5;
		long num111 = (long)x10 * (long)num6;
		long num112 = (long)num14 * (long)num7;
		long num113 = (long)x10 * (long)num8;
		long num114 = (long)num14 * (long)num9;
		long num115 = num15 + num34 + num43 + num52 + num61 + num70 + num79 + num88 + num97 + num106;
		long num116 = num16 + num25 + num44 + num53 + num62 + num71 + num80 + num89 + num98 + num107;
		long num117 = num17 + num26 + num35 + num54 + num63 + num72 + num81 + num90 + num99 + num108;
		long num118 = num18 + num27 + num36 + num45 + num64 + num73 + num82 + num91 + num100 + num109;
		long num119 = num19 + num28 + num37 + num46 + num55 + num74 + num83 + num92 + num101 + num110;
		long num120 = num20 + num29 + num38 + num47 + num56 + num65 + num84 + num93 + num102 + num111;
		long num121 = num21 + num30 + num39 + num48 + num57 + num66 + num75 + num94 + num103 + num112;
		long num122 = num22 + num31 + num40 + num49 + num58 + num67 + num76 + num85 + num104 + num113;
		long num123 = num23 + num32 + num41 + num50 + num59 + num68 + num77 + num86 + num95 + num114;
		long num124 = num24 + num33 + num42 + num51 + num60 + num69 + num78 + num87 + num96 + num105;
		long num125 = num115 + 33554432L >> 26;
		num116 += num125;
		num115 -= num125 << 26;
		long num126 = num119 + 33554432L >> 26;
		num120 += num126;
		num119 -= num126 << 26;
		long num127 = num116 + 16777216L >> 25;
		num117 += num127;
		num116 -= num127 << 25;
		long num128 = num120 + 16777216L >> 25;
		num121 += num128;
		num120 -= num128 << 25;
		long num129 = num117 + 33554432L >> 26;
		num118 += num129;
		num117 -= num129 << 26;
		long num130 = num121 + 33554432L >> 26;
		num122 += num130;
		num121 -= num130 << 26;
		long num131 = num118 + 16777216L >> 25;
		num119 += num131;
		num118 -= num131 << 25;
		long num132 = num122 + 16777216L >> 25;
		num123 += num132;
		num122 -= num132 << 25;
		num126 = num119 + 33554432L >> 26;
		num120 += num126;
		num119 -= num126 << 26;
		long num133 = num123 + 33554432L >> 26;
		num124 += num133;
		num123 -= num133 << 26;
		long num134 = num124 + 16777216L >> 25;
		num115 += num134 * 19L;
		num124 -= num134 << 25;
		num125 = num115 + 33554432L >> 26;
		num116 += num125;
		num115 -= num125 << 26;
		h.x0 = (int)num115;
		h.x1 = (int)num116;
		h.x2 = (int)num117;
		h.x3 = (int)num118;
		h.x4 = (int)num119;
		h.x5 = (int)num120;
		h.x6 = (int)num121;
		h.x7 = (int)num122;
		h.x8 = (int)num123;
		h.x9 = (int)num124;
	}

	internal static void fe_mul121666(out FieldElement h, ref FieldElement f)
	{
		int x = f.x0;
		int x2 = f.x1;
		int x3 = f.x2;
		int x4 = f.x3;
		int x5 = f.x4;
		int x6 = f.x5;
		int x7 = f.x6;
		int x8 = f.x7;
		int x9 = f.x8;
		int x10 = f.x9;
		long num = x * 121666L;
		long num2 = x2 * 121666L;
		long num3 = x3 * 121666L;
		long num4 = x4 * 121666L;
		long num5 = x5 * 121666L;
		long num6 = x6 * 121666L;
		long num7 = x7 * 121666L;
		long num8 = x8 * 121666L;
		long num9 = x9 * 121666L;
		long num10 = x10 * 121666L;
		long num11 = num10 + 16777216L >> 25;
		num += num11 * 19L;
		num10 -= num11 << 25;
		long num12 = num2 + 16777216L >> 25;
		num3 += num12;
		num2 -= num12 << 25;
		long num13 = num4 + 16777216L >> 25;
		num5 += num13;
		num4 -= num13 << 25;
		long num14 = num6 + 16777216L >> 25;
		num7 += num14;
		num6 -= num14 << 25;
		long num15 = num8 + 16777216L >> 25;
		num9 += num15;
		num8 -= num15 << 25;
		long num16 = num + 33554432L >> 26;
		num2 += num16;
		num -= num16 << 26;
		long num17 = num3 + 33554432L >> 26;
		num4 += num17;
		num3 -= num17 << 26;
		long num18 = num5 + 33554432L >> 26;
		num6 += num18;
		num5 -= num18 << 26;
		long num19 = num7 + 33554432L >> 26;
		num8 += num19;
		num7 -= num19 << 26;
		long num20 = num9 + 33554432L >> 26;
		num10 += num20;
		num9 -= num20 << 26;
		h.x0 = (int)num;
		h.x1 = (int)num2;
		h.x2 = (int)num3;
		h.x3 = (int)num4;
		h.x4 = (int)num5;
		h.x5 = (int)num6;
		h.x6 = (int)num7;
		h.x7 = (int)num8;
		h.x8 = (int)num9;
		h.x9 = (int)num10;
	}

	internal static void fe_neg(out FieldElement h, ref FieldElement f)
	{
		int x = f.x0;
		int x2 = f.x1;
		int x3 = f.x2;
		int x4 = f.x3;
		int x5 = f.x4;
		int x6 = f.x5;
		int x7 = f.x6;
		int x8 = f.x7;
		int x9 = f.x8;
		int x10 = f.x9;
		int x11 = -x;
		int x12 = -x2;
		int x13 = -x3;
		int x14 = -x4;
		int x15 = -x5;
		int x16 = -x6;
		int x17 = -x7;
		int x18 = -x8;
		int x19 = -x9;
		int x20 = -x10;
		h.x0 = x11;
		h.x1 = x12;
		h.x2 = x13;
		h.x3 = x14;
		h.x4 = x15;
		h.x5 = x16;
		h.x6 = x17;
		h.x7 = x18;
		h.x8 = x19;
		h.x9 = x20;
	}

	internal static void fe_pow22523(out FieldElement result, ref FieldElement z)
	{
		fe_sq(out var h, ref z);
		fe_sq(out var h2, ref h);
		for (int i = 1; i < 2; i++)
		{
			fe_sq(out h2, ref h2);
		}
		fe_mul(out h2, ref z, ref h2);
		fe_mul(out h, ref h, ref h2);
		fe_sq(out h, ref h);
		fe_mul(out h, ref h2, ref h);
		fe_sq(out h2, ref h);
		for (int i = 1; i < 5; i++)
		{
			fe_sq(out h2, ref h2);
		}
		fe_mul(out h, ref h2, ref h);
		fe_sq(out h2, ref h);
		for (int i = 1; i < 10; i++)
		{
			fe_sq(out h2, ref h2);
		}
		fe_mul(out h2, ref h2, ref h);
		fe_sq(out var h3, ref h2);
		for (int i = 1; i < 20; i++)
		{
			fe_sq(out h3, ref h3);
		}
		fe_mul(out h2, ref h3, ref h2);
		fe_sq(out h2, ref h2);
		for (int i = 1; i < 10; i++)
		{
			fe_sq(out h2, ref h2);
		}
		fe_mul(out h, ref h2, ref h);
		fe_sq(out h2, ref h);
		for (int i = 1; i < 50; i++)
		{
			fe_sq(out h2, ref h2);
		}
		fe_mul(out h2, ref h2, ref h);
		fe_sq(out h3, ref h2);
		for (int i = 1; i < 100; i++)
		{
			fe_sq(out h3, ref h3);
		}
		fe_mul(out h2, ref h3, ref h2);
		fe_sq(out h2, ref h2);
		for (int i = 1; i < 50; i++)
		{
			fe_sq(out h2, ref h2);
		}
		fe_mul(out h, ref h2, ref h);
		fe_sq(out h, ref h);
		for (int i = 1; i < 2; i++)
		{
			fe_sq(out h, ref h);
		}
		fe_mul(out result, ref h, ref z);
	}

	internal static void fe_sq(out FieldElement h, ref FieldElement f)
	{
		int x = f.x0;
		int x2 = f.x1;
		int x3 = f.x2;
		int x4 = f.x3;
		int x5 = f.x4;
		int x6 = f.x5;
		int x7 = f.x6;
		int x8 = f.x7;
		int x9 = f.x8;
		int x10 = f.x9;
		int num = 2 * x;
		int num2 = 2 * x2;
		int num3 = 2 * x3;
		int num4 = 2 * x4;
		int num5 = 2 * x5;
		int num6 = 2 * x6;
		int num7 = 2 * x7;
		int num8 = 2 * x8;
		int num9 = 38 * x6;
		int num10 = 19 * x7;
		int num11 = 38 * x8;
		int num12 = 19 * x9;
		int num13 = 38 * x10;
		long num14 = (long)x * (long)x;
		long num15 = (long)num * (long)x2;
		long num16 = (long)num * (long)x3;
		long num17 = (long)num * (long)x4;
		long num18 = (long)num * (long)x5;
		long num19 = (long)num * (long)x6;
		long num20 = (long)num * (long)x7;
		long num21 = (long)num * (long)x8;
		long num22 = (long)num * (long)x9;
		long num23 = (long)num * (long)x10;
		long num24 = (long)num2 * (long)x2;
		long num25 = (long)num2 * (long)x3;
		long num26 = (long)num2 * (long)num4;
		long num27 = (long)num2 * (long)x5;
		long num28 = (long)num2 * (long)num6;
		long num29 = (long)num2 * (long)x7;
		long num30 = (long)num2 * (long)num8;
		long num31 = (long)num2 * (long)x9;
		long num32 = (long)num2 * (long)num13;
		long num33 = (long)x3 * (long)x3;
		long num34 = (long)num3 * (long)x4;
		long num35 = (long)num3 * (long)x5;
		long num36 = (long)num3 * (long)x6;
		long num37 = (long)num3 * (long)x7;
		long num38 = (long)num3 * (long)x8;
		long num39 = (long)num3 * (long)num12;
		long num40 = (long)x3 * (long)num13;
		long num41 = (long)num4 * (long)x4;
		long num42 = (long)num4 * (long)x5;
		long num43 = (long)num4 * (long)num6;
		long num44 = (long)num4 * (long)x7;
		long num45 = (long)num4 * (long)num11;
		long num46 = (long)num4 * (long)num12;
		long num47 = (long)num4 * (long)num13;
		long num48 = (long)x5 * (long)x5;
		long num49 = (long)num5 * (long)x6;
		long num50 = (long)num5 * (long)num10;
		long num51 = (long)x5 * (long)num11;
		long num52 = (long)num5 * (long)num12;
		long num53 = (long)x5 * (long)num13;
		long num54 = (long)x6 * (long)num9;
		long num55 = (long)num6 * (long)num10;
		long num56 = (long)num6 * (long)num11;
		long num57 = (long)num6 * (long)num12;
		long num58 = (long)num6 * (long)num13;
		long num59 = (long)x7 * (long)num10;
		long num60 = (long)x7 * (long)num11;
		long num61 = (long)num7 * (long)num12;
		long num62 = (long)x7 * (long)num13;
		long num63 = (long)x8 * (long)num11;
		long num64 = (long)num8 * (long)num12;
		long num65 = (long)num8 * (long)num13;
		long num66 = (long)x9 * (long)num12;
		long num67 = (long)x9 * (long)num13;
		long num68 = (long)x10 * (long)num13;
		long num69 = num14 + num32 + num39 + num45 + num50 + num54;
		long num70 = num15 + num40 + num46 + num51 + num55;
		long num71 = num16 + num24 + num47 + num52 + num56 + num59;
		long num72 = num17 + num25 + num53 + num57 + num60;
		long num73 = num18 + num26 + num33 + num58 + num61 + num63;
		long num74 = num19 + num27 + num34 + num62 + num64;
		long num75 = num20 + num28 + num35 + num41 + num65 + num66;
		long num76 = num21 + num29 + num36 + num42 + num67;
		long num77 = num22 + num30 + num37 + num43 + num48 + num68;
		long num78 = num23 + num31 + num38 + num44 + num49;
		long num79 = num69 + 33554432L >> 26;
		num70 += num79;
		num69 -= num79 << 26;
		long num80 = num73 + 33554432L >> 26;
		num74 += num80;
		num73 -= num80 << 26;
		long num81 = num70 + 16777216L >> 25;
		num71 += num81;
		num70 -= num81 << 25;
		long num82 = num74 + 16777216L >> 25;
		num75 += num82;
		num74 -= num82 << 25;
		long num83 = num71 + 33554432L >> 26;
		num72 += num83;
		num71 -= num83 << 26;
		long num84 = num75 + 33554432L >> 26;
		num76 += num84;
		num75 -= num84 << 26;
		long num85 = num72 + 16777216L >> 25;
		num73 += num85;
		num72 -= num85 << 25;
		long num86 = num76 + 16777216L >> 25;
		num77 += num86;
		num76 -= num86 << 25;
		num80 = num73 + 33554432L >> 26;
		num74 += num80;
		num73 -= num80 << 26;
		long num87 = num77 + 33554432L >> 26;
		num78 += num87;
		num77 -= num87 << 26;
		long num88 = num78 + 16777216L >> 25;
		num69 += num88 * 19L;
		num78 -= num88 << 25;
		num79 = num69 + 33554432L >> 26;
		num70 += num79;
		num69 -= num79 << 26;
		h.x0 = (int)num69;
		h.x1 = (int)num70;
		h.x2 = (int)num71;
		h.x3 = (int)num72;
		h.x4 = (int)num73;
		h.x5 = (int)num74;
		h.x6 = (int)num75;
		h.x7 = (int)num76;
		h.x8 = (int)num77;
		h.x9 = (int)num78;
	}

	internal static void fe_sq2(out FieldElement h, ref FieldElement f)
	{
		int x = f.x0;
		int x2 = f.x1;
		int x3 = f.x2;
		int x4 = f.x3;
		int x5 = f.x4;
		int x6 = f.x5;
		int x7 = f.x6;
		int x8 = f.x7;
		int x9 = f.x8;
		int x10 = f.x9;
		int num = 2 * x;
		int num2 = 2 * x2;
		int num3 = 2 * x3;
		int num4 = 2 * x4;
		int num5 = 2 * x5;
		int num6 = 2 * x6;
		int num7 = 2 * x7;
		int num8 = 2 * x8;
		int num9 = 38 * x6;
		int num10 = 19 * x7;
		int num11 = 38 * x8;
		int num12 = 19 * x9;
		int num13 = 38 * x10;
		long num14 = (long)x * (long)x;
		long num15 = (long)num * (long)x2;
		long num16 = (long)num * (long)x3;
		long num17 = (long)num * (long)x4;
		long num18 = (long)num * (long)x5;
		long num19 = (long)num * (long)x6;
		long num20 = (long)num * (long)x7;
		long num21 = (long)num * (long)x8;
		long num22 = (long)num * (long)x9;
		long num23 = (long)num * (long)x10;
		long num24 = (long)num2 * (long)x2;
		long num25 = (long)num2 * (long)x3;
		long num26 = (long)num2 * (long)num4;
		long num27 = (long)num2 * (long)x5;
		long num28 = (long)num2 * (long)num6;
		long num29 = (long)num2 * (long)x7;
		long num30 = (long)num2 * (long)num8;
		long num31 = (long)num2 * (long)x9;
		long num32 = (long)num2 * (long)num13;
		long num33 = (long)x3 * (long)x3;
		long num34 = (long)num3 * (long)x4;
		long num35 = (long)num3 * (long)x5;
		long num36 = (long)num3 * (long)x6;
		long num37 = (long)num3 * (long)x7;
		long num38 = (long)num3 * (long)x8;
		long num39 = (long)num3 * (long)num12;
		long num40 = (long)x3 * (long)num13;
		long num41 = (long)num4 * (long)x4;
		long num42 = (long)num4 * (long)x5;
		long num43 = (long)num4 * (long)num6;
		long num44 = (long)num4 * (long)x7;
		long num45 = (long)num4 * (long)num11;
		long num46 = (long)num4 * (long)num12;
		long num47 = (long)num4 * (long)num13;
		long num48 = (long)x5 * (long)x5;
		long num49 = (long)num5 * (long)x6;
		long num50 = (long)num5 * (long)num10;
		long num51 = (long)x5 * (long)num11;
		long num52 = (long)num5 * (long)num12;
		long num53 = (long)x5 * (long)num13;
		long num54 = (long)x6 * (long)num9;
		long num55 = (long)num6 * (long)num10;
		long num56 = (long)num6 * (long)num11;
		long num57 = (long)num6 * (long)num12;
		long num58 = (long)num6 * (long)num13;
		long num59 = (long)x7 * (long)num10;
		long num60 = (long)x7 * (long)num11;
		long num61 = (long)num7 * (long)num12;
		long num62 = (long)x7 * (long)num13;
		long num63 = (long)x8 * (long)num11;
		long num64 = (long)num8 * (long)num12;
		long num65 = (long)num8 * (long)num13;
		long num66 = (long)x9 * (long)num12;
		long num67 = (long)x9 * (long)num13;
		long num68 = (long)x10 * (long)num13;
		long num69 = num14 + num32 + num39 + num45 + num50 + num54;
		long num70 = num15 + num40 + num46 + num51 + num55;
		long num71 = num16 + num24 + num47 + num52 + num56 + num59;
		long num72 = num17 + num25 + num53 + num57 + num60;
		long num73 = num18 + num26 + num33 + num58 + num61 + num63;
		long num74 = num19 + num27 + num34 + num62 + num64;
		long num75 = num20 + num28 + num35 + num41 + num65 + num66;
		long num76 = num21 + num29 + num36 + num42 + num67;
		long num77 = num22 + num30 + num37 + num43 + num48 + num68;
		long num78 = num23 + num31 + num38 + num44 + num49;
		num69 += num69;
		num70 += num70;
		num71 += num71;
		num72 += num72;
		num73 += num73;
		num74 += num74;
		num75 += num75;
		num76 += num76;
		num77 += num77;
		num78 += num78;
		long num79 = num69 + 33554432L >> 26;
		num70 += num79;
		num69 -= num79 << 26;
		long num80 = num73 + 33554432L >> 26;
		num74 += num80;
		num73 -= num80 << 26;
		long num81 = num70 + 16777216L >> 25;
		num71 += num81;
		num70 -= num81 << 25;
		long num82 = num74 + 16777216L >> 25;
		num75 += num82;
		num74 -= num82 << 25;
		long num83 = num71 + 33554432L >> 26;
		num72 += num83;
		num71 -= num83 << 26;
		long num84 = num75 + 33554432L >> 26;
		num76 += num84;
		num75 -= num84 << 26;
		long num85 = num72 + 16777216L >> 25;
		num73 += num85;
		num72 -= num85 << 25;
		long num86 = num76 + 16777216L >> 25;
		num77 += num86;
		num76 -= num86 << 25;
		num80 = num73 + 33554432L >> 26;
		num74 += num80;
		num73 -= num80 << 26;
		long num87 = num77 + 33554432L >> 26;
		num78 += num87;
		num77 -= num87 << 26;
		long num88 = num78 + 16777216L >> 25;
		num69 += num88 * 19L;
		num78 -= num88 << 25;
		num79 = num69 + 33554432L >> 26;
		num70 += num79;
		num69 -= num79 << 26;
		h.x0 = (int)num69;
		h.x1 = (int)num70;
		h.x2 = (int)num71;
		h.x3 = (int)num72;
		h.x4 = (int)num73;
		h.x5 = (int)num74;
		h.x6 = (int)num75;
		h.x7 = (int)num76;
		h.x8 = (int)num77;
		h.x9 = (int)num78;
	}

	internal static void fe_sub(out FieldElement h, ref FieldElement f, ref FieldElement g)
	{
		int x = f.x0;
		int x2 = f.x1;
		int x3 = f.x2;
		int x4 = f.x3;
		int x5 = f.x4;
		int x6 = f.x5;
		int x7 = f.x6;
		int x8 = f.x7;
		int x9 = f.x8;
		int x10 = f.x9;
		int x11 = g.x0;
		int x12 = g.x1;
		int x13 = g.x2;
		int x14 = g.x3;
		int x15 = g.x4;
		int x16 = g.x5;
		int x17 = g.x6;
		int x18 = g.x7;
		int x19 = g.x8;
		int x20 = g.x9;
		int x21 = x - x11;
		int x22 = x2 - x12;
		int x23 = x3 - x13;
		int x24 = x4 - x14;
		int x25 = x5 - x15;
		int x26 = x6 - x16;
		int x27 = x7 - x17;
		int x28 = x8 - x18;
		int x29 = x9 - x19;
		int x30 = x10 - x20;
		h.x0 = x21;
		h.x1 = x22;
		h.x2 = x23;
		h.x3 = x24;
		h.x4 = x25;
		h.x5 = x26;
		h.x6 = x27;
		h.x7 = x28;
		h.x8 = x29;
		h.x9 = x30;
	}

	internal static void fe_tobytes(byte[] s, int offset, ref FieldElement h)
	{
		fe_reduce(out var hr, ref h);
		int x = hr.x0;
		int x2 = hr.x1;
		int x3 = hr.x2;
		int x4 = hr.x3;
		int x5 = hr.x4;
		int x6 = hr.x5;
		int x7 = hr.x6;
		int x8 = hr.x7;
		int x9 = hr.x8;
		int x10 = hr.x9;
		s[offset] = (byte)x;
		s[offset + 1] = (byte)(x >> 8);
		s[offset + 2] = (byte)(x >> 16);
		s[offset + 3] = (byte)((x >> 24) | (x2 << 2));
		s[offset + 4] = (byte)(x2 >> 6);
		s[offset + 5] = (byte)(x2 >> 14);
		s[offset + 6] = (byte)((x2 >> 22) | (x3 << 3));
		s[offset + 7] = (byte)(x3 >> 5);
		s[offset + 8] = (byte)(x3 >> 13);
		s[offset + 9] = (byte)((x3 >> 21) | (x4 << 5));
		s[offset + 10] = (byte)(x4 >> 3);
		s[offset + 11] = (byte)(x4 >> 11);
		s[offset + 12] = (byte)((x4 >> 19) | (x5 << 6));
		s[offset + 13] = (byte)(x5 >> 2);
		s[offset + 14] = (byte)(x5 >> 10);
		s[offset + 15] = (byte)(x5 >> 18);
		s[offset + 16] = (byte)x6;
		s[offset + 17] = (byte)(x6 >> 8);
		s[offset + 18] = (byte)(x6 >> 16);
		s[offset + 19] = (byte)((x6 >> 24) | (x7 << 1));
		s[offset + 20] = (byte)(x7 >> 7);
		s[offset + 21] = (byte)(x7 >> 15);
		s[offset + 22] = (byte)((x7 >> 23) | (x8 << 3));
		s[offset + 23] = (byte)(x8 >> 5);
		s[offset + 24] = (byte)(x8 >> 13);
		s[offset + 25] = (byte)((x8 >> 21) | (x9 << 4));
		s[offset + 26] = (byte)(x9 >> 4);
		s[offset + 27] = (byte)(x9 >> 12);
		s[offset + 28] = (byte)((x9 >> 20) | (x10 << 6));
		s[offset + 29] = (byte)(x10 >> 2);
		s[offset + 30] = (byte)(x10 >> 10);
		s[offset + 31] = (byte)(x10 >> 18);
	}

	internal static void fe_reduce(out FieldElement hr, ref FieldElement h)
	{
		int x = h.x0;
		int x2 = h.x1;
		int x3 = h.x2;
		int x4 = h.x3;
		int x5 = h.x4;
		int x6 = h.x5;
		int x7 = h.x6;
		int x8 = h.x7;
		int x9 = h.x8;
		int x10 = h.x9;
		int num = 19 * x10 + 16777216 >> 25;
		num = x + num >> 26;
		num = x2 + num >> 25;
		num = x3 + num >> 26;
		num = x4 + num >> 25;
		num = x5 + num >> 26;
		num = x6 + num >> 25;
		num = x7 + num >> 26;
		num = x8 + num >> 25;
		num = x9 + num >> 26;
		num = x10 + num >> 25;
		x += 19 * num;
		int num2 = x >> 26;
		x2 += num2;
		x -= num2 << 26;
		int num3 = x2 >> 25;
		x3 += num3;
		x2 -= num3 << 25;
		int num4 = x3 >> 26;
		x4 += num4;
		x3 -= num4 << 26;
		int num5 = x4 >> 25;
		x5 += num5;
		x4 -= num5 << 25;
		int num6 = x5 >> 26;
		x6 += num6;
		x5 -= num6 << 26;
		int num7 = x6 >> 25;
		x7 += num7;
		x6 -= num7 << 25;
		int num8 = x7 >> 26;
		x8 += num8;
		x7 -= num8 << 26;
		int num9 = x8 >> 25;
		x9 += num9;
		x8 -= num9 << 25;
		int num10 = x9 >> 26;
		x10 += num10;
		x9 -= num10 << 26;
		int num11 = x10 >> 25;
		x10 -= num11 << 25;
		hr.x0 = x;
		hr.x1 = x2;
		hr.x2 = x3;
		hr.x3 = x4;
		hr.x4 = x5;
		hr.x5 = x6;
		hr.x6 = x7;
		hr.x7 = x8;
		hr.x8 = x9;
		hr.x9 = x10;
	}
}
