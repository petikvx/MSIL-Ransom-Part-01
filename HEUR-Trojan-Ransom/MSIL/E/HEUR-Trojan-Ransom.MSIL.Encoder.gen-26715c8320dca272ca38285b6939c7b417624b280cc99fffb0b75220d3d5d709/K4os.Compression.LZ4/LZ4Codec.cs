using System;
using System.Runtime.InteropServices;
using K4os.Compression.LZ4.Engine;

namespace K4os.Compression.LZ4;

public class LZ4Codec
{
	public static int MaximumOutputSize(int length)
	{
		return LZ4_xx.LZ4_compressBound(length);
	}

	public unsafe static int Encode(byte* source, int sourceLength, byte* target, int targetLength, LZ4Level level = LZ4Level.L00_FAST)
	{
		if (sourceLength <= 0)
		{
			return 0;
		}
		int num = ((level == LZ4Level.L00_FAST) ? LZ4_64.LZ4_compress_default(source, target, sourceLength, targetLength) : LZ4_64_HC.LZ4_compress_HC(source, target, sourceLength, targetLength, (int)level));
		if (num > 0)
		{
			return num;
		}
		return -1;
	}

	public unsafe static int Encode(ReadOnlySpan<byte> source, Span<byte> target, LZ4Level level = LZ4Level.L00_FAST)
	{
		int length = source.Length;
		if (length <= 0)
		{
			return 0;
		}
		int length2 = target.Length;
		fixed (byte* source2 = &MemoryMarshal.GetReference(source))
		{
			fixed (byte* target2 = &MemoryMarshal.GetReference(target))
			{
				return Encode(source2, length, target2, length2, level);
			}
		}
	}

	public unsafe static int Encode(byte[] source, int sourceOffset, int sourceLength, byte[] target, int targetOffset, int targetLength, LZ4Level level = LZ4Level.L00_FAST)
	{
		source.Validate(sourceOffset, sourceLength);
		target.Validate(targetOffset, targetLength);
		fixed (byte* ptr = source)
		{
			fixed (byte* ptr2 = target)
			{
				return Encode(ptr + sourceOffset, sourceLength, ptr2 + targetOffset, targetLength, level);
			}
		}
	}

	public unsafe static int Decode(byte* source, int sourceLength, byte* target, int targetLength)
	{
		if (sourceLength <= 0)
		{
			return 0;
		}
		int num = LZ4_xx.LZ4_decompress_safe(source, target, sourceLength, targetLength);
		if (num > 0)
		{
			return num;
		}
		return -1;
	}

	public unsafe static int Decode(ReadOnlySpan<byte> source, Span<byte> target)
	{
		int length = source.Length;
		if (length <= 0)
		{
			return 0;
		}
		int length2 = target.Length;
		fixed (byte* source2 = &MemoryMarshal.GetReference(source))
		{
			fixed (byte* target2 = &MemoryMarshal.GetReference(target))
			{
				return Decode(source2, length, target2, length2);
			}
		}
	}

	public unsafe static int Decode(byte[] source, int sourceOffset, int sourceLength, byte[] target, int targetOffset, int targetLength)
	{
		source.Validate(sourceOffset, sourceLength);
		target.Validate(targetOffset, targetLength);
		fixed (byte* ptr = source)
		{
			fixed (byte* ptr2 = target)
			{
				return Decode(ptr + sourceOffset, sourceLength, ptr2 + targetOffset, targetLength);
			}
		}
	}
}
