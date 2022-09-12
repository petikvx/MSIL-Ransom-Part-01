using System;
using K4os.Compression.LZ4.Internal;

namespace K4os.Compression.LZ4.Engine;

internal class LZ4_64_HC : LZ4_64
{
	public struct LZ4HC_CCtx_t
	{
		public unsafe fixed uint hashTable[32768];

		public unsafe fixed ushort chainTable[65536];

		public unsafe byte* end;

		public unsafe byte* basep;

		public unsafe byte* dictBase;

		public unsafe byte* inputBuffer;

		public uint dictLimit;

		public uint lowLimit;

		public uint nextToUpdate;

		public int compressionLevel;
	}

	private enum repeat_state_e
	{
		rep_untested,
		rep_not,
		rep_confirmed
	}

	private struct LZ4HC_optimal_t
	{
		public int price;

		public int off;

		public int mlen;

		public int litlen;
	}

	private struct LZ4HC_match_t
	{
		public int off;

		public int len;
	}

	private enum lz4hc_strat_e
	{
		lz4hc,
		lz4opt
	}

	private struct cParams_t
	{
		public readonly lz4hc_strat_e strat;

		public readonly uint nbSearches;

		public readonly uint targetLength;

		public cParams_t(lz4hc_strat_e strat, uint nbSearches, uint targetLength)
		{
			this.strat = strat;
			this.nbSearches = nbSearches;
			this.targetLength = targetLength;
		}
	}

	private const int LZ4HC_CLEVEL_MIN = 3;

	private const int LZ4HC_CLEVEL_DEFAULT = 9;

	private const int LZ4HC_CLEVEL_OPT_MIN = 10;

	private const int LZ4HC_CLEVEL_MAX = 12;

	private const int LZ4HC_DICTIONARY_LOGSIZE = 16;

	private const int LZ4HC_MAXD = 65536;

	private const int LZ4HC_MAXD_MASK = 65535;

	private const int LZ4HC_HASH_LOG = 15;

	private const int LZ4HC_HASHTABLESIZE = 32768;

	private const int LZ4HC_HASH_MASK = 32767;

	private const int OPTIMAL_ML = 18;

	private const int LZ4_OPT_NUM = 4096;

	private static cParams_t[] clTable = new cParams_t[13]
	{
		new cParams_t(lz4hc_strat_e.lz4hc, 2u, 16u),
		new cParams_t(lz4hc_strat_e.lz4hc, 2u, 16u),
		new cParams_t(lz4hc_strat_e.lz4hc, 2u, 16u),
		new cParams_t(lz4hc_strat_e.lz4hc, 4u, 16u),
		new cParams_t(lz4hc_strat_e.lz4hc, 8u, 16u),
		new cParams_t(lz4hc_strat_e.lz4hc, 16u, 16u),
		new cParams_t(lz4hc_strat_e.lz4hc, 32u, 16u),
		new cParams_t(lz4hc_strat_e.lz4hc, 64u, 16u),
		new cParams_t(lz4hc_strat_e.lz4hc, 128u, 16u),
		new cParams_t(lz4hc_strat_e.lz4hc, 256u, 16u),
		new cParams_t(lz4hc_strat_e.lz4opt, 96u, 64u),
		new cParams_t(lz4hc_strat_e.lz4opt, 512u, 128u),
		new cParams_t(lz4hc_strat_e.lz4opt, 8192u, 4096u)
	};

	private unsafe static ushort DELTANEXTU16(ushort* table, ushort pos)
	{
		return table[(int)pos];
	}

	private unsafe static void DELTANEXTU16(ushort* table, ushort pos, ushort value)
	{
		table[(int)pos] = value;
	}

	private unsafe static uint LZ4HC_hashPtr(void* ptr)
	{
		return (uint)((int)Mem.Peek32(ptr) * -1640531535) >> 17;
	}

	public unsafe static void LZ4HC_init(LZ4HC_CCtx_t* hc4, byte* start)
	{
		Mem.Zero((byte*)hc4->hashTable, 131072);
		Mem.Fill((byte*)hc4->chainTable, byte.MaxValue, 131072);
		hc4->nextToUpdate = 65536u;
		hc4->basep = start - 65536;
		hc4->end = start;
		hc4->dictBase = start - 65536;
		hc4->dictLimit = 65536u;
		hc4->lowLimit = 65536u;
	}

	private unsafe static void LZ4HC_insert(LZ4HC_CCtx_t* hc4, byte* ip)
	{
		ushort* table = hc4->chainTable;
		uint* ptr = hc4->hashTable;
		byte* basep = hc4->basep;
		uint num = (uint)(ip - basep);
		for (uint num2 = hc4->nextToUpdate; num2 < num; num2++)
		{
			uint num3 = LZ4HC_hashPtr(basep + num2);
			uint num4 = num2 - ptr[num3];
			if (num4 > 65535)
			{
				num4 = 65535u;
			}
			DELTANEXTU16(table, (ushort)num2, (ushort)num4);
			ptr[num3] = num2;
		}
		hc4->nextToUpdate = num;
	}

	private unsafe static int LZ4HC_countBack(byte* ip, byte* match, byte* iMin, byte* mMin)
	{
		int num = 0;
		while (ip + num > iMin && match + num > mMin && ip[num - 1] == match[num - 1])
		{
			num--;
		}
		return num;
	}

	private unsafe static uint LZ4HC_countPattern(byte* ip, byte* iEnd, uint pattern32)
	{
		byte* ptr = ip;
		ulong num = pattern32 | ((ulong)pattern32 << 32);
		ulong num2;
		while (true)
		{
			if (ip < iEnd - 7)
			{
				num2 = LZ4_64.LZ4_read_ARCH(ip) ^ num;
				if (num2 != 0L)
				{
					break;
				}
				ip += 8;
				continue;
			}
			ulong num3 = num;
			while (ip < iEnd && *ip == (byte)num3)
			{
				ip++;
				num3 >>= 8;
			}
			return (uint)(ip - ptr);
		}
		ip += LZ4_64.LZ4_NbCommonBytes(num2);
		return (uint)(ip - ptr);
	}

	private unsafe static uint LZ4HC_reverseCountPattern(byte* ip, byte* iLow, uint pattern)
	{
		byte* ptr = ip;
		while (ip >= iLow + 4 && Mem.Peek32(ip - 4) == pattern)
		{
			ip -= 4;
		}
		byte* ptr2 = (byte*)(&pattern) + 3;
		while (ip > iLow && ip[-1] == *ptr2)
		{
			ip--;
			ptr2--;
		}
		return (uint)(ptr - ip);
	}

	private unsafe static int LZ4HC_InsertAndGetWiderMatch(LZ4HC_CCtx_t* hc4, byte* ip, byte* iLowLimit, byte* iHighLimit, int longest, byte** matchpos, byte** startpos, int maxNbAttempts, int patternAnalysis)
	{
		ushort* table = hc4->chainTable;
		uint* num = hc4->hashTable;
		byte* basep = hc4->basep;
		uint dictLimit = hc4->dictLimit;
		byte* ptr = basep + dictLimit;
		uint num2 = ((hc4->lowLimit + 65536 > (uint)(ip - basep)) ? hc4->lowLimit : ((uint)((int)(ip - basep) - 65535)));
		byte* dictBase = hc4->dictBase;
		int num3 = (int)(ip - iLowLimit);
		int num4 = maxNbAttempts;
		uint num5 = Mem.Peek32(ip);
		repeat_state_e repeat_state_e = repeat_state_e.rep_untested;
		int num6 = 0;
		LZ4HC_insert(hc4, ip);
		uint num7 = num[LZ4HC_hashPtr(ip)];
		while (num7 >= num2 && num4 != 0)
		{
			num4--;
			if (num7 >= dictLimit)
			{
				byte* ptr2 = basep + num7;
				if (iLowLimit[longest] == (ptr2 - num3)[longest] && Mem.Peek32(ptr2) == num5)
				{
					int num8 = (int)(4 + LZ4_64.LZ4_count(ip + 4, ptr2 + 4, iHighLimit));
					int num9 = 0;
					while (ip + num9 > iLowLimit && ptr2 + num9 > ptr && ip[num9 - 1] == ptr2[num9 - 1])
					{
						num9--;
					}
					num8 -= num9;
					if (num8 > longest)
					{
						longest = num8;
						*matchpos = ptr2 + num9;
						*startpos = ip + num9;
					}
				}
			}
			else
			{
				byte* ptr3 = dictBase + num7;
				if (Mem.Peek32(ptr3) == num5)
				{
					int num10 = 0;
					byte* ptr4 = ip + (dictLimit - num7);
					if (ptr4 > iHighLimit)
					{
						ptr4 = iHighLimit;
					}
					int num11 = (int)(4 + LZ4_64.LZ4_count(ip + 4, ptr3 + 4, ptr4));
					if (ip + num11 == ptr4 && ptr4 < iHighLimit)
					{
						num11 += (int)LZ4_64.LZ4_count(ip + num11, basep + dictLimit, iHighLimit);
					}
					while (ip + num10 > iLowLimit && num7 + num10 > num2 && ip[num10 - 1] == ptr3[num10 - 1])
					{
						num10--;
					}
					num11 -= num10;
					if (num11 > longest)
					{
						longest = num11;
						*matchpos = basep + num7 + num10;
						*startpos = ip + num10;
					}
				}
			}
			ushort num12 = DELTANEXTU16(table, (ushort)num7);
			num7 -= num12;
			if (patternAnalysis == 0 || num12 != 1)
			{
				continue;
			}
			if (repeat_state_e == repeat_state_e.rep_untested)
			{
				if ((num5 & 0xFFFF) == num5 >> 16 && (num5 & 0xFF) == num5 >> 24)
				{
					repeat_state_e = repeat_state_e.rep_confirmed;
					num6 = (int)(LZ4HC_countPattern(ip + 4, iHighLimit, num5) + 4);
				}
				else
				{
					repeat_state_e = repeat_state_e.rep_not;
				}
			}
			if (repeat_state_e == repeat_state_e.rep_confirmed && num7 >= dictLimit)
			{
				byte* ptr5 = basep + num7;
				if (Mem.Peek32(ptr5) == num5)
				{
					int num13 = (int)(LZ4HC_countPattern(ptr5 + 4, iHighLimit, num5) + 4);
					byte* iLow = ((ptr + 65535 >= ip) ? ptr : (ip - 65535));
					int num14 = (int)LZ4HC_reverseCountPattern(ptr5, iLow, num5);
					num7 = ((num14 + num13 < num6 || num13 > num6) ? (num7 - (uint)num14) : (num7 + (uint)(num13 - num6)));
				}
			}
		}
		return longest;
	}

	private unsafe static int LZ4HC_InsertAndFindBestMatch(LZ4HC_CCtx_t* hc4, byte* ip, byte* iLimit, byte** matchpos, int maxNbAttempts, int patternAnalysis)
	{
		byte* ptr = ip;
		return LZ4HC_InsertAndGetWiderMatch(hc4, ip, ip, iLimit, 3, matchpos, &ptr, maxNbAttempts, patternAnalysis);
	}

	private unsafe static int LZ4HC_encodeSequence(byte** ip, byte** op, byte** anchor, int matchLength, byte* match, limitedOutput_directive limit, byte* oend)
	{
		byte* ptr = (*op)++;
		ulong num = (ulong)(*ip - *anchor);
		if (limit != 0 && *op + (num >> 8) + num + 8 > oend)
		{
			return 1;
		}
		if (num >= 15L)
		{
			ulong num2 = num - 15L;
			*ptr = 240;
			while (num2 >= 255L)
			{
				*((*op)++) = byte.MaxValue;
				num2 -= 255L;
			}
			*((*op)++) = (byte)num2;
		}
		else
		{
			*ptr = (byte)(num << 4);
		}
		Mem.WildCopy(*op, *anchor, *op + num);
		*op += num;
		Mem.Poke16(*op, (ushort)(*ip - match));
		*op += 2;
		num = (ulong)(matchLength - 4);
		if (limit != 0 && *op + (num >> 8) + 6 > oend)
		{
			return 1;
		}
		if (num >= 15L)
		{
			*ptr = (byte)(*ptr + 15);
			for (num -= 15L; num >= 510L; num -= 510L)
			{
				*((*op)++) = byte.MaxValue;
				*((*op)++) = byte.MaxValue;
			}
			if (num >= 255L)
			{
				num -= 255L;
				*((*op)++) = byte.MaxValue;
			}
			*((*op)++) = (byte)num;
		}
		else
		{
			*ptr = (byte)(*ptr + (byte)num);
		}
		*ip += matchLength;
		*anchor = *ip;
		return 0;
	}

	private static int LZ4HC_literalsPrice(int litlen)
	{
		if (litlen < 15)
		{
			return litlen;
		}
		return litlen + (int)(1L + (litlen - 15L) / 255L);
	}

	private static int LZ4HC_sequencePrice(int litlen, int mlen)
	{
		int num = 3 + LZ4HC_literalsPrice(litlen);
		if (mlen < 19)
		{
			return num;
		}
		return num + (int)(1L + (mlen - 19L) / 255L);
	}

	private unsafe static LZ4HC_match_t LZ4HC_FindLongerMatch(LZ4HC_CCtx_t* ctx, byte* ip, byte* iHighLimit, int minLen, int nbSearches)
	{
		LZ4HC_match_t result = default(LZ4HC_match_t);
		Mem.Zero((byte*)(&result), sizeof(LZ4HC_match_t));
		byte* ptr = null;
		int num = LZ4HC_InsertAndGetWiderMatch(ctx, ip, ip, iHighLimit, minLen, &ptr, &ip, nbSearches, 1);
		if (num <= minLen)
		{
			return result;
		}
		result.len = num;
		result.off = (int)(ip - ptr);
		return result;
	}

	private unsafe static int LZ4HC_compress_optimal(LZ4HC_CCtx_t* ctx, byte* source, byte* dst, int* srcSizePtr, int dstCapacity, int nbSearches, ulong sufficient_len, limitedOutput_directive limit, int fullUpdate)
	{
		LZ4HC_optimal_t* ptr = stackalloc LZ4HC_optimal_t[4099];
		byte* ptr2 = source;
		byte* ptr3 = ptr2;
		byte* ptr4 = ptr2 + *srcSizePtr;
		byte* ptr5 = ptr4 - 12;
		byte* iHighLimit = ptr4 - 5;
		byte* ptr6 = dst;
		byte* ptr7 = ptr6 + dstCapacity;
		*srcSizePtr = 0;
		if (limit == limitedOutput_directive.limitedDestSize)
		{
			ptr7 -= 5;
		}
		if (sufficient_len >= 4096L)
		{
			sufficient_len = 4095uL;
		}
		while (ptr2 < ptr5)
		{
			int num = (int)(ptr2 - ptr3);
			LZ4HC_match_t lZ4HC_match_t = LZ4HC_FindLongerMatch(ctx, ptr2, iHighLimit, 3, nbSearches);
			if (lZ4HC_match_t.len == 0)
			{
				ptr2++;
				continue;
			}
			byte* ptr8;
			if ((ulong)lZ4HC_match_t.len > sufficient_len)
			{
				int len = lZ4HC_match_t.len;
				byte* match = ptr2 - lZ4HC_match_t.off;
				ptr8 = ptr6;
				if (LZ4HC_encodeSequence(&ptr2, &ptr6, &ptr3, len, match, limit, ptr7) == 0)
				{
					continue;
				}
				goto IL_0695;
			}
			for (int i = 0; i < 4; i++)
			{
				int price = LZ4HC_literalsPrice(num + i);
				ptr[i].mlen = 1;
				ptr[i].off = 0;
				ptr[i].litlen = num + i;
				ptr[i].price = price;
			}
			int j = 4;
			int len2 = lZ4HC_match_t.len;
			int off = lZ4HC_match_t.off;
			for (; j <= len2; j++)
			{
				int price2 = LZ4HC_sequencePrice(num, j);
				ptr[j].mlen = j;
				ptr[j].off = off;
				ptr[j].litlen = num;
				ptr[j].price = price2;
			}
			int num2 = lZ4HC_match_t.len;
			for (int k = 1; k <= 3; k++)
			{
				ptr[num2 + k].mlen = 1;
				ptr[num2 + k].off = 0;
				ptr[num2 + k].litlen = k;
				ptr[num2 + k].price = ptr[num2].price + LZ4HC_literalsPrice(k);
			}
			int num3 = 1;
			int num4;
			int off2;
			while (true)
			{
				if (num3 < num2)
				{
					byte* ptr9 = ptr2 + num3;
					if (ptr9 < ptr5)
					{
						if (fullUpdate != 0)
						{
							if (ptr[num3 + 1].price <= ptr[num3].price && ptr[num3 + 4].price < ptr[num3].price + 3)
							{
								goto IL_0561;
							}
						}
						else if (ptr[num3 + 1].price <= ptr[num3].price)
						{
							goto IL_0561;
						}
						LZ4HC_match_t lZ4HC_match_t2 = LZ4HC_FindLongerMatch(ctx, ptr9, iHighLimit, (fullUpdate != 0) ? 3 : (num2 - num3), nbSearches);
						if (lZ4HC_match_t2.len != 0)
						{
							if ((ulong)lZ4HC_match_t2.len > sufficient_len || lZ4HC_match_t2.len + num3 >= 4096)
							{
								num4 = lZ4HC_match_t2.len;
								off2 = lZ4HC_match_t2.off;
								num2 = num3 + 1;
								break;
							}
							int litlen = ptr[num3].litlen;
							for (int l = 1; l < 4; l++)
							{
								int num5 = ptr[num3].price - LZ4HC_literalsPrice(litlen) + LZ4HC_literalsPrice(litlen + l);
								int num6 = num3 + l;
								if (num5 < ptr[num6].price)
								{
									ptr[num6].mlen = 1;
									ptr[num6].off = 0;
									ptr[num6].litlen = litlen + l;
									ptr[num6].price = num5;
								}
							}
							int len3 = lZ4HC_match_t2.len;
							for (int m = 4; m <= len3; m++)
							{
								int num7 = num3 + m;
								int off3 = lZ4HC_match_t2.off;
								int num8;
								int num9;
								if (ptr[num3].mlen == 1)
								{
									num8 = ptr[num3].litlen;
									num9 = ((num3 > num8) ? ptr[num3 - num8].price : 0) + LZ4HC_sequencePrice(num8, m);
								}
								else
								{
									num8 = 0;
									num9 = ptr[num3].price + LZ4HC_sequencePrice(0, m);
								}
								if (num7 > num2 + 3 || num9 <= ptr[num7].price)
								{
									if (m == len3 && num2 < num7)
									{
										num2 = num7;
									}
									ptr[num7].mlen = m;
									ptr[num7].off = off3;
									ptr[num7].litlen = num8;
									ptr[num7].price = num9;
								}
							}
							for (int n = 1; n <= 3; n++)
							{
								ptr[num2 + n].mlen = 1;
								ptr[num2 + n].off = 0;
								ptr[num2 + n].litlen = n;
								ptr[num2 + n].price = ptr[num2].price + LZ4HC_literalsPrice(n);
							}
						}
						goto IL_0561;
					}
				}
				num4 = ptr[num2].mlen;
				off2 = ptr[num2].off;
				num3 = num2 - num4;
				break;
				IL_0561:
				num3++;
			}
			int num10 = num3;
			int mlen = num4;
			int off4 = off2;
			while (true)
			{
				int mlen2 = ptr[num10].mlen;
				int off5 = ptr[num10].off;
				ptr[num10].mlen = mlen;
				ptr[num10].off = off4;
				mlen = mlen2;
				off4 = off5;
				if (mlen2 > num10)
				{
					break;
				}
				num10 -= mlen2;
			}
			int num11 = 0;
			while (num11 < num2)
			{
				int mlen3 = ptr[num11].mlen;
				int off6 = ptr[num11].off;
				if (mlen3 == 1)
				{
					ptr2++;
					num11++;
					continue;
				}
				num11 += mlen3;
				ptr8 = ptr6;
				if (LZ4HC_encodeSequence(&ptr2, &ptr6, &ptr3, mlen3, ptr2 - off6, limit, ptr7) == 0)
				{
					continue;
				}
				goto IL_0695;
			}
			continue;
			IL_0695:
			if (limit != limitedOutput_directive.limitedDestSize)
			{
				return 0;
			}
			ptr6 = ptr8;
			break;
		}
		ulong num12 = (ulong)(ptr4 - ptr3);
		ulong num13 = (num12 + 255L - 15L) / 255uL;
		ulong num14 = 1L + num13 + num12;
		if (limit == limitedOutput_directive.limitedDestSize)
		{
			ptr7 += 5;
		}
		if (limit != 0 && ptr6 + num14 > ptr7)
		{
			if (limit == limitedOutput_directive.limitedOutput)
			{
				return 0;
			}
			num12 = (ulong)(ptr7 - ptr6 - 1L);
			num13 = (num12 + 255L - 15L) / 255uL;
			num12 -= num13;
		}
		ptr2 = ptr3 + num12;
		if (num12 >= 15L)
		{
			ulong num15 = num12 - 15L;
			*(ptr6++) = 240;
			while (num15 >= 255L)
			{
				*(ptr6++) = byte.MaxValue;
				num15 -= 255L;
			}
			*(ptr6++) = (byte)num15;
		}
		else
		{
			*(ptr6++) = (byte)(num12 << 4);
		}
		Mem.Copy(ptr6, ptr3, (int)num12);
		ptr6 += num12;
		*srcSizePtr = (int)(ptr2 - source);
		return (int)(ptr6 - dst);
	}

	private unsafe static int LZ4HC_compress_hashChain(LZ4HC_CCtx_t* ctx, byte* source, byte* dest, int* srcSizePtr, int maxOutputSize, uint maxNbAttempts, limitedOutput_directive limit)
	{
		int num = *srcSizePtr;
		int patternAnalysis = ((maxNbAttempts > 64) ? 1 : 0);
		byte* ptr = source;
		byte* ptr2 = ptr;
		byte* ptr3 = ptr + num;
		byte* ptr4 = ptr3 - 12;
		byte* ptr5 = ptr3 - 5;
		byte* ptr6 = dest;
		byte* ptr7 = ptr6 + maxOutputSize;
		byte* ptr8 = null;
		byte* ptr9 = null;
		byte* ptr10 = null;
		byte* ptr11 = null;
		byte* ptr12 = null;
		*srcSizePtr = 0;
		if (limit == limitedOutput_directive.limitedDestSize)
		{
			ptr7 -= 5;
		}
		if (num >= 13)
		{
			while (ptr < ptr4)
			{
				int num2 = LZ4HC_InsertAndFindBestMatch(ctx, ptr, ptr5, &ptr8, (int)maxNbAttempts, patternAnalysis);
				if (num2 < 4)
				{
					ptr++;
					continue;
				}
				byte* ptr13 = ptr;
				byte* ptr14 = ptr8;
				int num3 = num2;
				byte* ptr15;
				while (true)
				{
					int num4 = ((ptr + num2 < ptr4) ? LZ4HC_InsertAndGetWiderMatch(ctx, ptr + num2 - 2, ptr, ptr5, num2, &ptr10, &ptr9, (int)maxNbAttempts, patternAnalysis) : num2);
					int num7;
					if (num4 != num2)
					{
						if (ptr13 < ptr && ptr9 < ptr + num3)
						{
							ptr = ptr13;
							ptr8 = ptr14;
							num2 = num3;
						}
						if (ptr9 - ptr < 3L)
						{
							num2 = num4;
							ptr = ptr9;
							ptr8 = ptr10;
							continue;
						}
						while (true)
						{
							if (ptr9 - ptr < 18L)
							{
								int num5 = num2;
								if (num5 > 18)
								{
									num5 = 18;
								}
								if (ptr + num5 > ptr9 + num4 - 4)
								{
									num5 = (int)(ptr9 - ptr) + num4 - 4;
								}
								int num6 = num5 - (int)(ptr9 - ptr);
								if (num6 > 0)
								{
									ptr9 += num6;
									ptr10 += num6;
									num4 -= num6;
								}
							}
							num7 = ((ptr9 + num4 >= ptr4) ? num4 : LZ4HC_InsertAndGetWiderMatch(ctx, ptr9 + num4 - 3, ptr9, ptr5, num4, &ptr12, &ptr11, (int)maxNbAttempts, patternAnalysis));
							if (num7 == num4)
							{
								break;
							}
							if (ptr11 < ptr + num2 + 3)
							{
								if (ptr11 < ptr + num2)
								{
									ptr9 = ptr11;
									ptr10 = ptr12;
									num4 = num7;
									continue;
								}
								goto IL_0251;
							}
							if (ptr9 < ptr + num2)
							{
								if (ptr9 - ptr < 15L)
								{
									if (num2 > 18)
									{
										num2 = 18;
									}
									if (ptr + num2 > ptr9 + num4 - 4)
									{
										num2 = (int)(ptr9 - ptr) + num4 - 4;
									}
									int num8 = num2 - (int)(ptr9 - ptr);
									if (num8 > 0)
									{
										ptr9 += num8;
										ptr10 += num8;
										num4 -= num8;
									}
								}
								else
								{
									num2 = (int)(ptr9 - ptr);
								}
							}
							ptr15 = ptr6;
							if (LZ4HC_encodeSequence(&ptr, &ptr6, &ptr2, num2, ptr8, limit, ptr7) == 0)
							{
								ptr = ptr9;
								ptr8 = ptr10;
								num2 = num4;
								ptr9 = ptr11;
								ptr10 = ptr12;
								num4 = num7;
								continue;
							}
							goto IL_0367;
						}
						if (ptr9 < ptr + num2)
						{
							num2 = (int)(ptr9 - ptr);
						}
						ptr15 = ptr6;
						if (LZ4HC_encodeSequence(&ptr, &ptr6, &ptr2, num2, ptr8, limit, ptr7) == 0)
						{
							ptr = ptr9;
							ptr15 = ptr6;
							if (LZ4HC_encodeSequence(&ptr, &ptr6, &ptr2, num4, ptr10, limit, ptr7) == 0)
							{
								break;
							}
						}
					}
					else
					{
						ptr15 = ptr6;
						if (LZ4HC_encodeSequence(&ptr, &ptr6, &ptr2, num2, ptr8, limit, ptr7) == 0)
						{
							break;
						}
					}
					goto IL_0367;
					IL_0367:
					if (limit != limitedOutput_directive.limitedDestSize)
					{
						return 0;
					}
					goto IL_036e;
					IL_0251:
					if (ptr9 < ptr + num2)
					{
						int num9 = (int)(ptr + num2 - ptr9);
						ptr9 += num9;
						ptr10 += num9;
						num4 -= num9;
						if (num4 < 4)
						{
							ptr9 = ptr11;
							ptr10 = ptr12;
							num4 = num7;
						}
					}
					ptr15 = ptr6;
					if (LZ4HC_encodeSequence(&ptr, &ptr6, &ptr2, num2, ptr8, limit, ptr7) == 0)
					{
						ptr = ptr11;
						ptr8 = ptr12;
						num2 = num7;
						ptr13 = ptr9;
						ptr14 = ptr10;
						num3 = num4;
						continue;
					}
					goto IL_0367;
				}
				continue;
				IL_036e:
				ptr6 = ptr15;
				break;
			}
		}
		ulong num10 = (ulong)(ptr3 - ptr2);
		ulong num11 = (num10 + 255L - 15L) / 255uL;
		ulong num12 = 1L + num11 + num10;
		if (limit == limitedOutput_directive.limitedDestSize)
		{
			ptr7 += 5;
		}
		if (limit != 0 && ptr6 + num12 > ptr7)
		{
			if (limit == limitedOutput_directive.limitedOutput)
			{
				return 0;
			}
			num10 = (ulong)(ptr7 - ptr6 - 1L);
			num11 = (num10 + 255L - 15L) / 255uL;
			num10 -= num11;
		}
		ptr = ptr2 + num10;
		if (num10 >= 15L)
		{
			ulong num13 = num10 - 15L;
			*(ptr6++) = 240;
			while (num13 >= 255L)
			{
				*(ptr6++) = byte.MaxValue;
				num13 -= 255L;
			}
			*(ptr6++) = (byte)num13;
		}
		else
		{
			*(ptr6++) = (byte)(num10 << 4);
		}
		Mem.Copy(ptr6, ptr2, (int)num10);
		ptr6 += num10;
		*srcSizePtr = (int)(ptr - source);
		return (int)(ptr6 - dest);
	}

	private unsafe static int LZ4HC_compress_generic(LZ4HC_CCtx_t* ctx, byte* src, byte* dst, int* srcSizePtr, int dstCapacity, int cLevel, limitedOutput_directive limit)
	{
		if (limit == limitedOutput_directive.limitedDestSize && dstCapacity < 1)
		{
			return 0;
		}
		if (*srcSizePtr > 2113929216)
		{
			return 0;
		}
		ctx->end += *srcSizePtr;
		if (cLevel < 1)
		{
			cLevel = 9;
		}
		cLevel = Math.Min(12, cLevel);
		cParams_t cParams_t = clTable[cLevel];
		if (cParams_t.strat == lz4hc_strat_e.lz4hc)
		{
			return LZ4HC_compress_hashChain(ctx, src, dst, srcSizePtr, dstCapacity, cParams_t.nbSearches, limit);
		}
		return LZ4HC_compress_optimal(ctx, src, dst, srcSizePtr, dstCapacity, (int)cParams_t.nbSearches, cParams_t.targetLength, limit, (cLevel == 12) ? 1 : 0);
	}

	private unsafe static int LZ4_compress_HC_extStateHC(LZ4HC_CCtx_t* ctx, byte* src, byte* dst, int srcSize, int dstCapacity, int compressionLevel)
	{
		if (((ulong)ctx & (ulong)(sizeof(void*) - 1)) != 0L)
		{
			return 0;
		}
		LZ4HC_init(ctx, src);
		return LZ4HC_compress_generic(ctx, src, dst, &srcSize, dstCapacity, compressionLevel, (dstCapacity < LZ4_xx.LZ4_compressBound(srcSize)) ? limitedOutput_directive.limitedOutput : limitedOutput_directive.noLimit);
	}

	private unsafe static LZ4HC_CCtx_t* AllocCtx()
	{
		return (LZ4HC_CCtx_t*)Mem.Alloc(sizeof(LZ4HC_CCtx_t));
	}

	private unsafe static void FreeCtx(LZ4HC_CCtx_t* context)
	{
		Mem.Free(context);
	}

	internal unsafe static int LZ4_compress_HC(byte* src, byte* dst, int srcSize, int dstCapacity, int compressionLevel)
	{
		LZ4HC_CCtx_t* ptr = AllocCtx();
		try
		{
			return LZ4_compress_HC_extStateHC(ptr, src, dst, srcSize, dstCapacity, compressionLevel);
		}
		finally
		{
			FreeCtx(ptr);
		}
	}

	private unsafe static int LZ4_compress_HC_destSize(LZ4HC_CCtx_t* ctx, byte* source, byte* dest, int* sourceSizePtr, int targetDestSize, int cLevel)
	{
		LZ4HC_init(ctx, source);
		return LZ4HC_compress_generic(ctx, source, dest, sourceSizePtr, targetDestSize, cLevel, limitedOutput_directive.limitedDestSize);
	}

	public unsafe static void LZ4_resetStreamHC(LZ4HC_CCtx_t* ctxPtr, int compressionLevel)
	{
		ctxPtr->basep = null;
		LZ4_setCompressionLevel(ctxPtr, compressionLevel);
	}

	public unsafe static void LZ4_setCompressionLevel(LZ4HC_CCtx_t* ctxPtr, int compressionLevel)
	{
		if (compressionLevel < 1)
		{
			compressionLevel = 1;
		}
		if (compressionLevel > 12)
		{
			compressionLevel = 12;
		}
		ctxPtr->compressionLevel = compressionLevel;
	}

	private unsafe static int LZ4_loadDictHC(LZ4HC_CCtx_t* ctxPtr, byte* dictionary, int dictSize)
	{
		if (dictSize > 65536)
		{
			dictionary += dictSize - 65536;
			dictSize = 65536;
		}
		LZ4HC_init(ctxPtr, dictionary);
		ctxPtr->end = dictionary + dictSize;
		if (dictSize >= 4)
		{
			LZ4HC_insert(ctxPtr, ctxPtr->end - 3);
		}
		return dictSize;
	}

	private unsafe static void LZ4HC_setExternalDict(LZ4HC_CCtx_t* ctxPtr, byte* newBlock)
	{
		if (ctxPtr->end >= ctxPtr->basep + 4)
		{
			LZ4HC_insert(ctxPtr, ctxPtr->end - 3);
		}
		ctxPtr->lowLimit = ctxPtr->dictLimit;
		ctxPtr->dictLimit = (uint)(ctxPtr->end - ctxPtr->basep);
		ctxPtr->dictBase = ctxPtr->basep;
		ctxPtr->basep = newBlock - ctxPtr->dictLimit;
		ctxPtr->end = newBlock;
		ctxPtr->nextToUpdate = ctxPtr->dictLimit;
	}

	private unsafe static int LZ4_compressHC_continue_generic(LZ4HC_CCtx_t* ctxPtr, byte* src, byte* dst, int* srcSizePtr, int dstCapacity, limitedOutput_directive limit)
	{
		if (ctxPtr->basep == null)
		{
			LZ4HC_init(ctxPtr, src);
		}
		if ((ulong)(ctxPtr->end - ctxPtr->basep) > 2147483648uL)
		{
			ulong num = (ulong)(ctxPtr->end - ctxPtr->basep - ctxPtr->dictLimit);
			if (num > 65536L)
			{
				num = 65536uL;
			}
			LZ4_loadDictHC(ctxPtr, ctxPtr->end - num, (int)num);
		}
		if (src != ctxPtr->end)
		{
			LZ4HC_setExternalDict(ctxPtr, src);
		}
		byte* ptr = src + *srcSizePtr;
		byte* ptr2 = ctxPtr->dictBase + ctxPtr->lowLimit;
		byte* ptr3 = ctxPtr->dictBase + ctxPtr->dictLimit;
		if (ptr > ptr2 && src < ptr3)
		{
			if (ptr > ptr3)
			{
				ptr = ptr3;
			}
			ctxPtr->lowLimit = (uint)(ptr - ctxPtr->dictBase);
			if (ctxPtr->dictLimit - ctxPtr->lowLimit < 4)
			{
				ctxPtr->lowLimit = ctxPtr->dictLimit;
			}
		}
		return LZ4HC_compress_generic(ctxPtr, src, dst, srcSizePtr, dstCapacity, ctxPtr->compressionLevel, limit);
	}

	public unsafe static int LZ4_compress_HC_continue(LZ4HC_CCtx_t* ctxPtr, byte* src, byte* dst, int srcSize, int dstCapacity)
	{
		return LZ4_compressHC_continue_generic(ctxPtr, src, dst, &srcSize, dstCapacity, (dstCapacity < LZ4_xx.LZ4_compressBound(srcSize)) ? limitedOutput_directive.limitedOutput : limitedOutput_directive.noLimit);
	}

	private unsafe static int LZ4_compress_HC_continue_destSize(LZ4HC_CCtx_t* ctxPtr, byte* src, byte* dst, int* srcSizePtr, int targetDestSize)
	{
		return LZ4_compressHC_continue_generic(ctxPtr, src, dst, srcSizePtr, targetDestSize, limitedOutput_directive.limitedDestSize);
	}

	public unsafe static int LZ4_saveDictHC(LZ4HC_CCtx_t* LZ4_streamHCPtr, byte* safeBuffer, int dictSize)
	{
		int num = (int)(LZ4_streamHCPtr->end - (LZ4_streamHCPtr->basep + LZ4_streamHCPtr->dictLimit));
		if (dictSize > 65536)
		{
			dictSize = 65536;
		}
		if (dictSize < 4)
		{
			dictSize = 0;
		}
		if (dictSize > num)
		{
			dictSize = num;
		}
		Mem.Move(safeBuffer, LZ4_streamHCPtr->end - dictSize, dictSize);
		uint num2 = (uint)(LZ4_streamHCPtr->end - LZ4_streamHCPtr->basep);
		LZ4_streamHCPtr->end = safeBuffer + dictSize;
		LZ4_streamHCPtr->basep = LZ4_streamHCPtr->end - num2;
		LZ4_streamHCPtr->dictLimit = num2 - (uint)dictSize;
		LZ4_streamHCPtr->lowLimit = num2 - (uint)dictSize;
		if (LZ4_streamHCPtr->nextToUpdate < LZ4_streamHCPtr->dictLimit)
		{
			LZ4_streamHCPtr->nextToUpdate = LZ4_streamHCPtr->dictLimit;
		}
		return dictSize;
	}
}
