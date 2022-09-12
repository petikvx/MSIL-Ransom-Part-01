using K4os.Compression.LZ4.Internal;

namespace K4os.Compression.LZ4.Engine;

internal class LZ4_xx
{
	internal struct LZ4_stream_t
	{
		public unsafe fixed uint hashTable[4096];

		public uint currentOffset;

		public uint initCheck;

		public unsafe byte* dictionary;

		public uint dictSize;
	}

	internal struct LZ4_streamDecode_t
	{
		public unsafe byte* externalDict;

		public uint extDictSize;

		public unsafe byte* prefixEnd;

		public uint prefixSize;
	}

	public enum limitedOutput_directive
	{
		noLimit,
		limitedOutput,
		limitedDestSize
	}

	public enum tableType_t
	{
		byPtr,
		byU32,
		byU16
	}

	public enum dict_directive
	{
		noDict,
		withPrefix64k,
		usingExtDict
	}

	public enum dictIssue_directive
	{
		noDictIssue,
		dictSmall
	}

	public enum endCondition_directive
	{
		endOnOutputSize,
		endOnInputSize
	}

	public enum earlyEnd_directive
	{
		full,
		partial
	}

	protected const int LZ4_MEMORY_USAGE = 14;

	protected const int LZ4_MAX_INPUT_SIZE = 2113929216;

	protected const int LZ4_HASHLOG = 12;

	protected const int LZ4_HASHTABLESIZE = 16384;

	protected const int LZ4_HASH_SIZE_U32 = 4096;

	protected const int ACCELERATION_DEFAULT = 1;

	protected const int MINMATCH = 4;

	protected const int WILDCOPYLENGTH = 8;

	protected const int LASTLITERALS = 5;

	protected const int MFLIMIT = 12;

	protected const int LZ4_minLength = 13;

	protected const int KB = 1024;

	protected const int MB = 1048576;

	protected const uint GB = 1073741824u;

	protected const int MAXD_LOG = 16;

	protected const int MAX_DISTANCE = 65535;

	protected const int ML_BITS = 4;

	protected const uint ML_MASK = 15u;

	protected const int RUN_BITS = 4;

	protected const uint RUN_MASK = 15u;

	protected const int LZ4_64Klimit = 65547;

	protected const int LZ4_skipTrigger = 6;

	private static readonly uint[] inc32table = new uint[8] { 0u, 1u, 2u, 1u, 0u, 4u, 4u, 4u };

	private static readonly int[] dec64table = new int[8] { 0, 0, 0, -1, -4, 1, 2, 3 };

	internal static int LZ4_compressBound(int isize)
	{
		if (isize <= 2113929216)
		{
			return isize + isize / 255 + 16;
		}
		return 0;
	}

	protected static uint LZ4_hash4(uint sequence, tableType_t tableType)
	{
		int num = ((tableType == tableType_t.byU16) ? 13 : 12);
		return (uint)((int)sequence * -1640531535) >> 32 - num;
	}

	protected static uint LZ4_hash5(ulong sequence, tableType_t tableType)
	{
		int num = ((tableType == tableType_t.byU16) ? 13 : 12);
		return (uint)((sequence << 24) * 889523592379L >> 64 - num);
	}

	protected unsafe static void LZ4_putPositionOnHash(byte* p, uint h, void* tableBase, tableType_t tableType, byte* srcBase)
	{
		switch (tableType)
		{
		default:
			*(ushort*)((byte*)tableBase + (long)h * 2L) = (ushort)(p - srcBase);
			break;
		case tableType_t.byU32:
			*(int*)((byte*)tableBase + (long)h * 4L) = (int)(p - srcBase);
			break;
		case tableType_t.byPtr:
			*(byte**)((byte*)tableBase + h * sizeof(byte*)) = p;
			break;
		}
	}

	protected unsafe static byte* LZ4_getPositionOnHash(uint h, void* tableBase, tableType_t tableType, byte* srcBase)
	{
		return tableType switch
		{
			tableType_t.byU32 => (uint)(*(int*)((byte*)tableBase + (long)h * 4L)) + srcBase, 
			tableType_t.byPtr => *(byte**)((byte*)tableBase + h * sizeof(byte*)), 
			_ => (int)(*(ushort*)((byte*)tableBase + (long)h * 2L)) + srcBase, 
		};
	}

	public unsafe static int LZ4_decompress_generic(byte* src, byte* dst, int srcSize, int outputSize, endCondition_directive endOnInput, earlyEnd_directive partialDecoding, int targetOutputSize, dict_directive dict, byte* lowPrefix, byte* dictStart, int dictSize)
	{
		byte* ptr = src;
		byte* ptr2 = ptr + srcSize;
		byte* ptr3 = dst;
		byte* ptr4 = ptr3 + outputSize;
		byte* ptr5 = ptr3 + targetOutputSize;
		byte* ptr6 = dictStart + dictSize;
		bool flag;
		bool flag2 = (flag = endOnInput == endCondition_directive.endOnInputSize) && dictSize < 65536;
		if (partialDecoding != 0 && ptr5 > ptr4 - 12)
		{
			ptr5 = ptr4 - 12;
		}
		if (endOnInput == endCondition_directive.endOnInputSize && outputSize == 0)
		{
			if (srcSize == 1 && *ptr == 0)
			{
				return 0;
			}
			return -1;
		}
		if (endOnInput != endCondition_directive.endOnInputSize && outputSize == 0)
		{
			if (*ptr != 0)
			{
				return -1;
			}
			return 1;
		}
		while (true)
		{
			uint num = *(ptr++);
			if (ptr + 14 + 2 <= ptr2 && ptr3 + 14 + 18 <= ptr4 && num < 240 && (num & 0xF) != 15)
			{
				int num2 = (int)(num >> 4);
				int num3 = Mem.Peek16(ptr + num2);
				byte* ptr7 = ptr3 + num2 - num3;
				if (num3 >= 18 && ptr7 >= lowPrefix)
				{
					int num4 = (int)((num & 0xF) + 4);
					Mem.Copy16(ptr3, ptr);
					ptr3 += num2;
					ptr += num2 + 2;
					Mem.Copy18(ptr3, ptr7);
					ptr3 += num4;
					continue;
				}
			}
			int num5;
			if ((num5 = (int)(num >> 4)) == 15L)
			{
				uint num6;
				do
				{
					num6 = *(ptr++);
					num5 += (int)num6;
				}
				while ((endOnInput != endCondition_directive.endOnInputSize || ptr < ptr2 - 15) && num6 == 255);
				if ((flag && ptr3 + num5 < ptr3) || (flag && ptr + num5 < ptr))
				{
					break;
				}
			}
			byte* ptr8 = ptr3 + num5;
			int num7;
			byte* ptr9;
			if ((endOnInput != endCondition_directive.endOnInputSize || (ptr8 <= ((partialDecoding == earlyEnd_directive.partial) ? ptr5 : (ptr4 - 12)) && ptr + num5 <= ptr2 - 8)) && (endOnInput == endCondition_directive.endOnInputSize || ptr8 <= ptr4 - 8))
			{
				Mem.WildCopy(ptr3, ptr, ptr8);
				ptr += num5;
				ptr3 = ptr8;
				num7 = Mem.Peek16(ptr);
				ptr += 2;
				ptr9 = ptr3 - num7;
				if (flag2 && ptr9 + dictSize < lowPrefix)
				{
					break;
				}
				Mem.Poke32(ptr3, (uint)num7);
				num5 = (int)(num & 0xF);
				if (num5 == 15L)
				{
					while (true)
					{
						uint num8 = *(ptr++);
						if (endOnInput == endCondition_directive.endOnInputSize && ptr > ptr2 - 5)
						{
							break;
						}
						num5 += (int)num8;
						if (num8 == 255)
						{
							continue;
						}
						goto IL_0180;
					}
					break;
				}
				goto IL_018e;
			}
			if (partialDecoding == earlyEnd_directive.partial)
			{
				if (ptr8 > ptr4 || (endOnInput == endCondition_directive.endOnInputSize && ptr + num5 > ptr2))
				{
					break;
				}
			}
			else if ((endOnInput != endCondition_directive.endOnInputSize && ptr8 != ptr4) || (endOnInput == endCondition_directive.endOnInputSize && (ptr + num5 != ptr2 || ptr8 > ptr4)))
			{
				break;
			}
			Mem.Copy(ptr3, ptr, num5);
			ptr += num5;
			ptr3 += num5;
			if (endOnInput == endCondition_directive.endOnInputSize)
			{
				return (int)(ptr3 - dst);
			}
			return (int)(ptr - src);
			IL_0180:
			if (flag && ptr3 + num5 < ptr3)
			{
				break;
			}
			goto IL_018e;
			IL_018e:
			num5 += 4;
			if (dict == dict_directive.usingExtDict && ptr9 < lowPrefix)
			{
				if (ptr3 + num5 > ptr4 - 5)
				{
					break;
				}
				if (num5 <= lowPrefix - ptr9)
				{
					Mem.Move(ptr3, ptr6 - (lowPrefix - ptr9), num5);
					ptr3 += num5;
					continue;
				}
				int num9 = (int)(lowPrefix - ptr9);
				int num10 = num5 - num9;
				Mem.Copy(ptr3, ptr6 - num9, num9);
				ptr3 += num9;
				if (num10 > (int)(ptr3 - lowPrefix))
				{
					byte* ptr10 = ptr3 + num10;
					byte* ptr11 = lowPrefix;
					while (ptr3 < ptr10)
					{
						*(ptr3++) = *(ptr11++);
					}
				}
				else
				{
					Mem.Copy(ptr3, lowPrefix, num10);
					ptr3 += num10;
				}
				continue;
			}
			ptr8 = ptr3 + num5;
			if (num7 < 8)
			{
				*ptr3 = *ptr9;
				ptr3[1] = ptr9[1];
				ptr3[2] = ptr9[2];
				ptr3[3] = ptr9[3];
				ptr9 += inc32table[num7];
				Mem.Copy(ptr3 + 4, ptr9, 4);
				ptr9 -= dec64table[num7];
			}
			else
			{
				Mem.Copy8(ptr3, ptr9);
				ptr9 += 8;
			}
			ptr3 += 8;
			if (ptr8 > ptr4 - 12)
			{
				byte* ptr12 = ptr4 - 7;
				if (ptr8 > ptr4 - 5)
				{
					break;
				}
				if (ptr3 < ptr12)
				{
					Mem.WildCopy(ptr3, ptr9, ptr12);
					ptr9 += ptr12 - ptr3;
					ptr3 = ptr12;
				}
				while (ptr3 < ptr8)
				{
					*(ptr3++) = *(ptr9++);
				}
			}
			else
			{
				Mem.Copy8(ptr3, ptr9);
				if (num5 > 16)
				{
					Mem.WildCopy(ptr3 + 8, ptr9 + 8, ptr8);
				}
			}
			ptr3 = ptr8;
		}
		return (int)(-(ptr - src)) - 1;
	}

	public unsafe static int LZ4_decompress_safe(byte* source, byte* dest, int compressedSize, int maxDecompressedSize)
	{
		return LZ4_decompress_generic(source, dest, compressedSize, maxDecompressedSize, endCondition_directive.endOnInputSize, earlyEnd_directive.full, 0, dict_directive.noDict, dest, null, 0);
	}

	public unsafe static int LZ4_decompress_safe_partial(byte* source, byte* dest, int compressedSize, int targetOutputSize, int maxDecompressedSize)
	{
		return LZ4_decompress_generic(source, dest, compressedSize, maxDecompressedSize, endCondition_directive.endOnInputSize, earlyEnd_directive.partial, targetOutputSize, dict_directive.noDict, dest, null, 0);
	}

	public unsafe static int LZ4_decompress_fast(byte* source, byte* dest, int originalSize)
	{
		return LZ4_decompress_generic(source, dest, 0, originalSize, endCondition_directive.endOnOutputSize, earlyEnd_directive.full, 0, dict_directive.withPrefix64k, dest - 65536, null, 65536);
	}

	public unsafe static int LZ4_decompress_safe_continue(LZ4_streamDecode_t* lz4sd, byte* source, byte* dest, int compressedSize, int maxOutputSize)
	{
		int num;
		if (lz4sd->prefixEnd == dest)
		{
			num = LZ4_decompress_generic(source, dest, compressedSize, maxOutputSize, endCondition_directive.endOnInputSize, earlyEnd_directive.full, 0, dict_directive.usingExtDict, lz4sd->prefixEnd - lz4sd->prefixSize, lz4sd->externalDict, (int)lz4sd->extDictSize);
			if (num <= 0)
			{
				return num;
			}
			lz4sd->prefixSize += (uint)num;
			lz4sd->prefixEnd += num;
		}
		else
		{
			lz4sd->extDictSize = lz4sd->prefixSize;
			lz4sd->externalDict = lz4sd->prefixEnd - lz4sd->extDictSize;
			num = LZ4_decompress_generic(source, dest, compressedSize, maxOutputSize, endCondition_directive.endOnInputSize, earlyEnd_directive.full, 0, dict_directive.usingExtDict, dest, lz4sd->externalDict, (int)lz4sd->extDictSize);
			if (num <= 0)
			{
				return num;
			}
			lz4sd->prefixSize = (uint)num;
			lz4sd->prefixEnd = dest + num;
		}
		return num;
	}

	public unsafe static int LZ4_decompress_fast_continue(LZ4_streamDecode_t* lz4sd, byte* source, byte* dest, int originalSize)
	{
		int num;
		if (lz4sd->prefixEnd == dest)
		{
			num = LZ4_decompress_generic(source, dest, 0, originalSize, endCondition_directive.endOnOutputSize, earlyEnd_directive.full, 0, dict_directive.usingExtDict, lz4sd->prefixEnd - lz4sd->prefixSize, lz4sd->externalDict, (int)lz4sd->extDictSize);
			if (num <= 0)
			{
				return num;
			}
			lz4sd->prefixSize += (uint)originalSize;
			lz4sd->prefixEnd += originalSize;
		}
		else
		{
			lz4sd->extDictSize = lz4sd->prefixSize;
			lz4sd->externalDict = lz4sd->prefixEnd - lz4sd->extDictSize;
			num = LZ4_decompress_generic(source, dest, 0, originalSize, endCondition_directive.endOnOutputSize, earlyEnd_directive.full, 0, dict_directive.usingExtDict, dest, lz4sd->externalDict, (int)lz4sd->extDictSize);
			if (num <= 0)
			{
				return num;
			}
			lz4sd->prefixSize = (uint)originalSize;
			lz4sd->prefixEnd = dest + originalSize;
		}
		return num;
	}

	public unsafe static int LZ4_decompress_usingDict_generic(byte* source, byte* dest, int compressedSize, int maxOutputSize, int safe, byte* dictStart, int dictSize)
	{
		if (dictSize == 0)
		{
			return LZ4_decompress_generic(source, dest, compressedSize, maxOutputSize, (endCondition_directive)safe, earlyEnd_directive.full, 0, dict_directive.noDict, dest, null, 0);
		}
		if (dictStart + dictSize != dest)
		{
			return LZ4_decompress_generic(source, dest, compressedSize, maxOutputSize, (endCondition_directive)safe, earlyEnd_directive.full, 0, dict_directive.usingExtDict, dest, dictStart, dictSize);
		}
		if (dictSize >= 65535)
		{
			return LZ4_decompress_generic(source, dest, compressedSize, maxOutputSize, (endCondition_directive)safe, earlyEnd_directive.full, 0, dict_directive.withPrefix64k, dest - 65536, null, 0);
		}
		return LZ4_decompress_generic(source, dest, compressedSize, maxOutputSize, (endCondition_directive)safe, earlyEnd_directive.full, 0, dict_directive.noDict, dest - dictSize, null, 0);
	}

	public unsafe static int LZ4_decompress_safe_usingDict(byte* source, byte* dest, int compressedSize, int maxOutputSize, byte* dictStart, int dictSize)
	{
		return LZ4_decompress_usingDict_generic(source, dest, compressedSize, maxOutputSize, 1, dictStart, dictSize);
	}

	public unsafe static int LZ4_decompress_fast_usingDict(byte* source, byte* dest, int originalSize, byte* dictStart, int dictSize)
	{
		return LZ4_decompress_usingDict_generic(source, dest, 0, originalSize, 0, dictStart, dictSize);
	}

	public unsafe static int LZ4_decompress_safe_forceExtDict(byte* source, byte* dest, int compressedSize, int maxOutputSize, byte* dictStart, int dictSize)
	{
		return LZ4_decompress_generic(source, dest, compressedSize, maxOutputSize, endCondition_directive.endOnInputSize, earlyEnd_directive.full, 0, dict_directive.usingExtDict, dest, dictStart, dictSize);
	}

	public unsafe static void LZ4_renormDictT(LZ4_stream_t* dict, byte* src)
	{
		if (dict->currentOffset <= 2147483648u && (ulong)dict->currentOffset <= (ulong)src)
		{
			return;
		}
		uint num = dict->currentOffset - 65536;
		byte* ptr = dict->dictionary + dict->dictSize;
		for (int i = 0; i < 4096; i++)
		{
			if (dict->hashTable[i] < num)
			{
				dict->hashTable[i] = 0u;
			}
			else
			{
				dict->hashTable[i] -= num;
			}
		}
		dict->currentOffset = 65536u;
		if (dict->dictSize > 65536)
		{
			dict->dictSize = 65536u;
		}
		dict->dictionary = ptr - dict->dictSize;
	}

	public unsafe static int LZ4_saveDict(LZ4_stream_t* dict, byte* safeBuffer, int dictSize)
	{
		byte* ptr = dict->dictionary + dict->dictSize;
		if ((uint)dictSize > 65536u)
		{
			dictSize = 65536;
		}
		if ((uint)dictSize > dict->dictSize)
		{
			dictSize = (int)dict->dictSize;
		}
		Mem.Move(safeBuffer, ptr - dictSize, dictSize);
		dict->dictionary = safeBuffer;
		dict->dictSize = (uint)dictSize;
		return dictSize;
	}

	public unsafe static void LZ4_setStreamDecode(LZ4_streamDecode_t* lz4sd, byte* dictionary, int dictSize)
	{
		lz4sd->prefixSize = (uint)dictSize;
		lz4sd->prefixEnd = dictionary + dictSize;
		lz4sd->externalDict = null;
		lz4sd->extDictSize = 0u;
	}
}
