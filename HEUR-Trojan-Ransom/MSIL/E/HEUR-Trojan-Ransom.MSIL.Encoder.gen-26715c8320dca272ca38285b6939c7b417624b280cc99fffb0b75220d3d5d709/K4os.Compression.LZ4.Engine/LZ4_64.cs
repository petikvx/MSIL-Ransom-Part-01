using K4os.Compression.LZ4.Internal;

namespace K4os.Compression.LZ4.Engine;

internal class LZ4_64 : LZ4_xx
{
	protected const int ARCH_SIZE = 8;

	protected const int STEPSIZE = 8;

	protected const int HASH_UNIT = 8;

	private static readonly uint[] DeBruijnBytePos = new uint[64]
	{
		0u, 0u, 0u, 0u, 0u, 1u, 1u, 2u, 0u, 3u,
		1u, 3u, 1u, 4u, 2u, 7u, 0u, 2u, 3u, 6u,
		1u, 5u, 3u, 5u, 1u, 3u, 4u, 4u, 2u, 5u,
		6u, 7u, 7u, 0u, 1u, 2u, 3u, 3u, 4u, 6u,
		2u, 6u, 5u, 5u, 3u, 4u, 5u, 6u, 7u, 1u,
		2u, 4u, 6u, 4u, 4u, 5u, 7u, 2u, 6u, 5u,
		7u, 6u, 7u, 7u
	};

	protected unsafe static ulong LZ4_read_ARCH(void* p)
	{
		return *(ulong*)p;
	}

	protected static uint LZ4_NbCommonBytes(ulong val)
	{
		return DeBruijnBytePos[(val & (0L - val)) * 151050438428048703L >> 58];
	}

	private static tableType_t LZ4_tableType(int inputSize)
	{
		if (inputSize >= 65547)
		{
			return tableType_t.byU32;
		}
		return tableType_t.byU16;
	}

	protected unsafe static uint LZ4_count(byte* pIn, byte* pMatch, byte* pInLimit)
	{
		byte* ptr = pIn;
		if (pIn < pInLimit - 7)
		{
			ulong num = LZ4_read_ARCH(pMatch) ^ LZ4_read_ARCH(pIn);
			if (num != 0L)
			{
				return LZ4_NbCommonBytes(num);
			}
			pIn += 8;
			pMatch += 8;
		}
		ulong num2;
		while (true)
		{
			if (pIn < pInLimit - 7)
			{
				num2 = LZ4_read_ARCH(pMatch) ^ LZ4_read_ARCH(pIn);
				if (num2 != 0L)
				{
					break;
				}
				pIn += 8;
				pMatch += 8;
				continue;
			}
			if (pIn < pInLimit - 3 && Mem.Peek32(pMatch) == Mem.Peek32(pIn))
			{
				pIn += 4;
				pMatch += 4;
			}
			if (pIn < pInLimit - 1 && Mem.Peek16(pMatch) == Mem.Peek16(pIn))
			{
				pIn += 2;
				pMatch += 2;
			}
			if (pIn < pInLimit && *pMatch == *pIn)
			{
				pIn++;
			}
			return (uint)(pIn - ptr);
		}
		return (uint)(pIn + LZ4_NbCommonBytes(num2) - ptr);
	}

	private unsafe static uint LZ4_hashPosition(void* p, tableType_t tableType)
	{
		if (tableType != tableType_t.byU16)
		{
			return LZ4_xx.LZ4_hash5(LZ4_read_ARCH(p), tableType);
		}
		return LZ4_xx.LZ4_hash4(Mem.Peek32(p), tableType);
	}

	private unsafe static void LZ4_putPosition(byte* p, void* tableBase, tableType_t tableType, byte* srcBase)
	{
		LZ4_xx.LZ4_putPositionOnHash(p, LZ4_hashPosition(p, tableType), tableBase, tableType, srcBase);
	}

	private unsafe static byte* LZ4_getPosition(byte* p, void* tableBase, tableType_t tableType, byte* srcBase)
	{
		return LZ4_xx.LZ4_getPositionOnHash(LZ4_hashPosition(p, tableType), tableBase, tableType, srcBase);
	}

	public unsafe static int LZ4_compress_generic(LZ4_stream_t* cctx, byte* source, byte* dest, int inputSize, int maxOutputSize, limitedOutput_directive outputLimited, tableType_t tableType, dict_directive dict, dictIssue_directive dictIssue, uint acceleration)
	{
		byte* ptr = source;
		byte* ptr2 = ptr - cctx->dictSize;
		byte* dictionary = cctx->dictionary;
		byte* ptr3 = dictionary + cctx->dictSize;
		long num = ptr3 - source;
		byte* ptr4 = source;
		byte* ptr5 = ptr + inputSize;
		byte* ptr6 = ptr5 - 12;
		byte* ptr7 = ptr5 - 5;
		byte* ptr8 = dest;
		byte* ptr9 = ptr8 + maxOutputSize;
		if (inputSize > 2113929216)
		{
			return 0;
		}
		byte* srcBase;
		byte* ptr10;
		switch (dict)
		{
		default:
			srcBase = source;
			ptr10 = source;
			break;
		case dict_directive.usingExtDict:
			srcBase = source - cctx->currentOffset;
			ptr10 = source;
			break;
		case dict_directive.withPrefix64k:
			srcBase = source - cctx->currentOffset;
			ptr10 = source - cctx->dictSize;
			break;
		}
		if (tableType == tableType_t.byU16 && inputSize >= 65547)
		{
			return 0;
		}
		if (inputSize >= 13)
		{
			LZ4_putPosition(ptr, cctx->hashTable, tableType, srcBase);
			ptr++;
			uint num2 = LZ4_hashPosition(ptr, tableType);
			while (true)
			{
				long num3 = 0L;
				byte* ptr11 = ptr;
				uint num4 = 1u;
				uint num5 = acceleration << 6;
				byte* ptr12;
				while (true)
				{
					uint h = num2;
					ptr = ptr11;
					ptr11 += num4;
					num4 = num5++ >> 6;
					if (ptr11 > ptr6)
					{
						break;
					}
					ptr12 = LZ4_xx.LZ4_getPositionOnHash(h, cctx->hashTable, tableType, srcBase);
					if (dict == dict_directive.usingExtDict)
					{
						if (ptr12 < source)
						{
							num3 = num;
							ptr10 = dictionary;
						}
						else
						{
							num3 = 0L;
							ptr10 = source;
						}
					}
					num2 = LZ4_hashPosition(ptr11, tableType);
					LZ4_xx.LZ4_putPositionOnHash(ptr, h, cctx->hashTable, tableType, srcBase);
					if ((dictIssue == dictIssue_directive.dictSmall && ptr12 < ptr2) || (tableType != tableType_t.byU16 && ptr12 + 65535 < ptr) || Mem.Peek32(ptr12 + num3) != Mem.Peek32(ptr))
					{
						continue;
					}
					goto IL_01a0;
				}
				break;
				IL_040c:
				num2 = LZ4_hashPosition(++ptr, tableType);
				continue;
				IL_01a0:
				while (ptr > ptr4 && ptr12 + num3 > ptr10 && ptr[-1] == ptr12[num3 - 1L])
				{
					ptr--;
					ptr12--;
				}
				uint num6 = (uint)(ptr - ptr4);
				byte* ptr13 = ptr8++;
				if (outputLimited != limitedOutput_directive.limitedOutput || ptr8 + num6 + 8 + num6 / 255u <= ptr9)
				{
					if (num6 >= 15)
					{
						int num7 = (int)(num6 - 15);
						*ptr13 = 240;
						while (num7 >= 255)
						{
							*(ptr8++) = byte.MaxValue;
							num7 -= 255;
						}
						*(ptr8++) = (byte)num7;
					}
					else
					{
						*ptr13 = (byte)(num6 << 4);
					}
					Mem.WildCopy(ptr8, ptr4, ptr8 + num6);
					ptr8 += num6;
					while (true)
					{
						Mem.Poke16(ptr8, (ushort)(ptr - ptr12));
						ptr8 += 2;
						uint num8;
						if (dict != dict_directive.usingExtDict || ptr10 != dictionary)
						{
							num8 = LZ4_count(ptr + 4, ptr12 + 4, ptr7);
							ptr += 4 + num8;
						}
						else
						{
							ptr12 += num3;
							byte* ptr14 = ptr + (ptr3 - ptr12);
							if (ptr14 > ptr7)
							{
								ptr14 = ptr7;
							}
							num8 = LZ4_count(ptr + 4, ptr12 + 4, ptr14);
							ptr += 4 + num8;
							if (ptr == ptr14)
							{
								uint num9 = LZ4_count(ptr, source, ptr7);
								num8 += num9;
								ptr += num9;
							}
						}
						if (outputLimited != limitedOutput_directive.limitedOutput || ptr8 + 6 + (num8 >> 8) <= ptr9)
						{
							if (num8 >= 15)
							{
								byte* intPtr = ptr13;
								*intPtr = (byte)(*intPtr + 15);
								num8 -= 15;
								Mem.Poke32(ptr8, uint.MaxValue);
								while (num8 >= 1020)
								{
									ptr8 += 4;
									Mem.Poke32(ptr8, uint.MaxValue);
									num8 -= 1020;
								}
								ptr8 += num8 / 255u;
								*(ptr8++) = (byte)(num8 % 255u);
							}
							else
							{
								byte* intPtr2 = ptr13;
								*intPtr2 = (byte)(*intPtr2 + (byte)num8);
							}
							ptr4 = ptr;
							if (ptr > ptr6)
							{
								break;
							}
							LZ4_putPosition(ptr - 2, cctx->hashTable, tableType, srcBase);
							ptr12 = LZ4_getPosition(ptr, cctx->hashTable, tableType, srcBase);
							if (dict == dict_directive.usingExtDict)
							{
								if (ptr12 < source)
								{
									num3 = num;
									ptr10 = dictionary;
								}
								else
								{
									num3 = 0L;
									ptr10 = source;
								}
							}
							LZ4_putPosition(ptr, cctx->hashTable, tableType, srcBase);
							if ((dictIssue != dictIssue_directive.dictSmall || ptr12 >= ptr2) && ptr12 + 65535 >= ptr && Mem.Peek32(ptr12 + num3) == Mem.Peek32(ptr))
							{
								ptr13 = ptr8++;
								*ptr13 = 0;
								continue;
							}
							goto IL_040c;
						}
						return 0;
					}
					break;
				}
				return 0;
			}
		}
		int num10 = (int)(ptr5 - ptr4);
		if (outputLimited == limitedOutput_directive.limitedOutput && ptr8 - dest + num10 + 1L + (num10 + 255 - 15L) / 255L > (uint)maxOutputSize)
		{
			return 0;
		}
		if (num10 >= 15L)
		{
			int num11 = (int)(num10 - 15L);
			*(ptr8++) = 240;
			while (num11 >= 255)
			{
				*(ptr8++) = byte.MaxValue;
				num11 -= 255;
			}
			*(ptr8++) = (byte)num11;
		}
		else
		{
			*(ptr8++) = (byte)(num10 << 4);
		}
		Mem.Copy(ptr8, ptr4, num10);
		ptr8 += num10;
		return (int)(ptr8 - dest);
	}

	public unsafe static int LZ4_compress_fast_extState(LZ4_stream_t* state, byte* source, byte* dest, int inputSize, int maxOutputSize, int acceleration)
	{
		LZ4_resetStream(state);
		if (acceleration < 1)
		{
			acceleration = 1;
		}
		limitedOutput_directive limitedOutput_directive = ((maxOutputSize < LZ4_xx.LZ4_compressBound(inputSize)) ? limitedOutput_directive.limitedOutput : limitedOutput_directive.noLimit);
		return LZ4_compress_generic(state, source, dest, inputSize, (limitedOutput_directive != 0) ? maxOutputSize : 0, limitedOutput_directive, LZ4_tableType(inputSize), dict_directive.noDict, dictIssue_directive.noDictIssue, (uint)acceleration);
	}

	public unsafe static void LZ4_resetStream(LZ4_stream_t* state)
	{
		Mem.Zero((byte*)state, sizeof(LZ4_stream_t));
	}

	public unsafe static int LZ4_compress_fast(byte* source, byte* dest, int inputSize, int maxOutputSize, int acceleration)
	{
		LZ4_stream_t lZ4_stream_t = default(LZ4_stream_t);
		return LZ4_compress_fast_extState(&lZ4_stream_t, source, dest, inputSize, maxOutputSize, acceleration);
	}

	public unsafe static int LZ4_compress_default(byte* source, byte* dest, int inputSize, int maxOutputSize)
	{
		return LZ4_compress_fast(source, dest, inputSize, maxOutputSize, 1);
	}

	private unsafe static int LZ4_compress_destSize_generic(LZ4_stream_t* ctx, byte* src, byte* dst, int* srcSizePtr, int targetDstSize, tableType_t tableType)
	{
		byte* ptr = src;
		byte* ptr2 = ptr;
		byte* ptr3 = ptr + *srcSizePtr;
		byte* ptr4 = ptr3 - 12;
		byte* pInLimit = ptr3 - 5;
		byte* ptr5 = dst;
		byte* ptr6 = ptr5 + targetDstSize;
		byte* ptr7 = ptr5 + targetDstSize - 2 - 8 - 1;
		byte* ptr8 = ptr5 + targetDstSize - 6;
		byte* ptr9 = ptr7 - 1;
		if (targetDstSize < 1)
		{
			return 0;
		}
		if (*srcSizePtr > 2113929216)
		{
			return 0;
		}
		if (tableType == tableType_t.byU16 && *srcSizePtr >= 65547)
		{
			return 0;
		}
		if (*srcSizePtr >= 13)
		{
			*srcSizePtr = 0;
			LZ4_putPosition(ptr, ctx->hashTable, tableType, src);
			ptr++;
			uint num = LZ4_hashPosition(ptr, tableType);
			while (true)
			{
				byte* ptr10 = ptr;
				uint num2 = 1u;
				uint num3 = 64u;
				byte* ptr11;
				while (true)
				{
					uint h = num;
					ptr = ptr10;
					ptr10 += num2;
					num2 = num3++ >> 6;
					if (ptr10 > ptr4)
					{
						break;
					}
					ptr11 = LZ4_xx.LZ4_getPositionOnHash(h, ctx->hashTable, tableType, src);
					num = LZ4_hashPosition(ptr10, tableType);
					LZ4_xx.LZ4_putPositionOnHash(ptr, h, ctx->hashTable, tableType, src);
					if ((tableType != tableType_t.byU16 && ptr11 + 65535 < ptr) || Mem.Peek32(ptr11) != Mem.Peek32(ptr))
					{
						continue;
					}
					goto IL_0133;
				}
				break;
				IL_0310:
				num = LZ4_hashPosition(++ptr, tableType);
				continue;
				IL_0133:
				while (ptr > ptr2 && ptr11 > src && ptr[-1] == ptr11[-1])
				{
					ptr--;
					ptr11--;
				}
				uint num4 = (uint)(ptr - ptr2);
				byte* ptr12 = ptr5++;
				if (ptr5 + (num4 + 240) / 255u + num4 <= ptr7)
				{
					if (num4 >= 15)
					{
						uint num5 = num4 - 15;
						*ptr12 = 240;
						while (num5 >= 255)
						{
							*(ptr5++) = byte.MaxValue;
							num5 -= 255;
						}
						*(ptr5++) = (byte)num5;
					}
					else
					{
						*ptr12 = (byte)(num4 << 4);
					}
					Mem.WildCopy(ptr5, ptr2, ptr5 + num4);
					ptr5 += num4;
					while (true)
					{
						Mem.Poke16(ptr5, (ushort)(ptr - ptr11));
						ptr5 += 2;
						int num6 = (int)LZ4_count(ptr + 4, ptr11 + 4, pInLimit);
						if (ptr5 + (num6 + 240) / 255 > ptr8)
						{
							num6 = (int)(14L + (ptr8 - ptr5) * 255L);
						}
						ptr += 4 + num6;
						if (num6 >= 15L)
						{
							byte* intPtr = ptr12;
							*intPtr = (byte)(*intPtr + 15);
							num6 -= 15;
							while (num6 >= 255)
							{
								num6 -= 255;
								*(ptr5++) = byte.MaxValue;
							}
							*(ptr5++) = (byte)num6;
						}
						else
						{
							byte* intPtr2 = ptr12;
							*intPtr2 = (byte)(*intPtr2 + (byte)num6);
						}
						ptr2 = ptr;
						if (ptr > ptr4 || ptr5 > ptr9)
						{
							break;
						}
						LZ4_putPosition(ptr - 2, ctx->hashTable, tableType, src);
						ptr11 = LZ4_getPosition(ptr, ctx->hashTable, tableType, src);
						LZ4_putPosition(ptr, ctx->hashTable, tableType, src);
						if (ptr11 + 65535 >= ptr && Mem.Peek32(ptr11) == Mem.Peek32(ptr))
						{
							ptr12 = ptr5++;
							*ptr12 = 0;
							continue;
						}
						goto IL_0310;
					}
				}
				else
				{
					ptr5--;
				}
				break;
			}
		}
		int num7 = (int)(ptr3 - ptr2);
		if (ptr5 + 1 + (num7 + 240) / 255 + num7 > ptr6)
		{
			num7 = (int)(ptr6 - ptr5) - 1;
			num7 -= (num7 + 240) / 255;
		}
		ptr = ptr2 + num7;
		if (num7 >= 15L)
		{
			long num8 = num7 - 15L;
			*(ptr5++) = 240;
			while (num8 >= 255L)
			{
				*(ptr5++) = byte.MaxValue;
				num8 -= 255L;
			}
			*(ptr5++) = (byte)num8;
		}
		else
		{
			*(ptr5++) = (byte)(num7 << 4);
		}
		Mem.Copy(ptr5, ptr2, num7);
		ptr5 += num7;
		*srcSizePtr = (int)(ptr - src);
		return (int)(ptr5 - dst);
	}

	public unsafe static int LZ4_compress_destSize_extState(LZ4_stream_t* state, byte* src, byte* dst, int* srcSizePtr, int targetDstSize)
	{
		LZ4_resetStream(state);
		if (targetDstSize < LZ4_xx.LZ4_compressBound(*srcSizePtr))
		{
			return LZ4_compress_destSize_generic(state, src, dst, srcSizePtr, targetDstSize, LZ4_tableType(*srcSizePtr));
		}
		return LZ4_compress_fast_extState(state, src, dst, *srcSizePtr, targetDstSize, 1);
	}

	public unsafe static int LZ4_compress_destSize(byte* src, byte* dst, int* srcSizePtr, int targetDstSize)
	{
		LZ4_stream_t lZ4_stream_t = default(LZ4_stream_t);
		return LZ4_compress_destSize_extState(&lZ4_stream_t, src, dst, srcSizePtr, targetDstSize);
	}

	public unsafe static int LZ4_loadDict(LZ4_stream_t* LZ4_dict, byte* dictionary, int dictSize)
	{
		byte* ptr = dictionary;
		byte* ptr2 = ptr + dictSize;
		if (LZ4_dict->initCheck != 0 || LZ4_dict->currentOffset > 1073741824)
		{
			LZ4_resetStream(LZ4_dict);
		}
		if (dictSize < 8)
		{
			LZ4_dict->dictionary = null;
			LZ4_dict->dictSize = 0u;
			return 0;
		}
		if (ptr2 - ptr > 65536L)
		{
			ptr = ptr2 - 65536;
		}
		LZ4_dict->currentOffset += 65536u;
		byte* srcBase = ptr - LZ4_dict->currentOffset;
		LZ4_dict->dictionary = ptr;
		LZ4_dict->dictSize = (uint)(ptr2 - ptr);
		LZ4_dict->currentOffset += LZ4_dict->dictSize;
		for (; ptr <= ptr2 - 8; ptr += 3)
		{
			LZ4_putPosition(ptr, LZ4_dict->hashTable, tableType_t.byU32, srcBase);
		}
		return (int)LZ4_dict->dictSize;
	}

	public unsafe static int LZ4_compress_fast_continue(LZ4_stream_t* streamPtr, byte* source, byte* dest, int inputSize, int maxOutputSize, int acceleration)
	{
		byte* ptr = streamPtr->dictionary + streamPtr->dictSize;
		byte* ptr2 = source;
		if (streamPtr->initCheck != 0)
		{
			return 0;
		}
		if (streamPtr->dictSize != 0 && ptr2 > ptr)
		{
			ptr2 = ptr;
		}
		LZ4_xx.LZ4_renormDictT(streamPtr, ptr2);
		if (acceleration < 1)
		{
			acceleration = 1;
		}
		byte* ptr3 = source + inputSize;
		if (ptr3 > streamPtr->dictionary && ptr3 < ptr)
		{
			streamPtr->dictSize = (uint)(ptr - ptr3);
			if (streamPtr->dictSize > 65536)
			{
				streamPtr->dictSize = 65536u;
			}
			if (streamPtr->dictSize < 4)
			{
				streamPtr->dictSize = 0u;
			}
			streamPtr->dictionary = ptr - streamPtr->dictSize;
		}
		dictIssue_directive dictIssue = ((streamPtr->dictSize < 65536 && streamPtr->dictSize < streamPtr->currentOffset) ? dictIssue_directive.dictSmall : dictIssue_directive.noDictIssue);
		dict_directive dict_directive = ((ptr == source) ? dict_directive.withPrefix64k : dict_directive.usingExtDict);
		int result = LZ4_compress_generic(streamPtr, source, dest, inputSize, maxOutputSize, limitedOutput_directive.limitedOutput, tableType_t.byU32, dict_directive, dictIssue, (uint)acceleration);
		if (dict_directive == dict_directive.withPrefix64k)
		{
			streamPtr->dictSize += (uint)inputSize;
			streamPtr->currentOffset += (uint)inputSize;
			return result;
		}
		streamPtr->dictionary = source;
		streamPtr->dictSize = (uint)inputSize;
		streamPtr->currentOffset += (uint)inputSize;
		return result;
	}
}
