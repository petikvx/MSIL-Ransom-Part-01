using System;

namespace K4os.Compression.LZ4.Encoders;

public static class LZ4EncoderExtensions
{
	public unsafe static bool Topup(this ILZ4Encoder encoder, ref byte* source, int length)
	{
		int num = encoder.Topup(source, length);
		source += num;
		return num != 0;
	}

	public unsafe static int Topup(this ILZ4Encoder encoder, byte[] source, int offset, int length)
	{
		fixed (byte* ptr = source)
		{
			return encoder.Topup(ptr + offset, length);
		}
	}

	public static bool Topup(this ILZ4Encoder encoder, byte[] source, ref int offset, int length)
	{
		int num = encoder.Topup(source, offset, length);
		offset += num;
		return num != 0;
	}

	public unsafe static int Encode(this ILZ4Encoder encoder, byte[] target, int offset, int length, bool allowCopy)
	{
		fixed (byte* ptr = target)
		{
			return encoder.Encode(ptr + offset, length, allowCopy);
		}
	}

	public static EncoderAction Encode(this ILZ4Encoder encoder, byte[] target, ref int offset, int length, bool allowCopy)
	{
		int num = encoder.Encode(target, offset, length, allowCopy);
		offset += Math.Abs(num);
		if (num != 0)
		{
			if (num >= 0)
			{
				return EncoderAction.Encoded;
			}
			return EncoderAction.Copied;
		}
		return EncoderAction.None;
	}

	public unsafe static EncoderAction Encode(this ILZ4Encoder encoder, ref byte* target, int length, bool allowCopy)
	{
		int num = encoder.Encode(target, length, allowCopy);
		target += Math.Abs(num);
		if (num != 0)
		{
			if (num >= 0)
			{
				return EncoderAction.Encoded;
			}
			return EncoderAction.Copied;
		}
		return EncoderAction.None;
	}

	public unsafe static EncoderAction TopupAndEncode(this ILZ4Encoder encoder, byte* source, int sourceLength, byte* target, int targetLength, bool forceEncode, bool allowCopy, out int loaded, out int encoded)
	{
		loaded = 0;
		encoded = 0;
		if (sourceLength > 0)
		{
			loaded = encoder.Topup(source, sourceLength);
		}
		return encoder.FlushAndEncode(target, targetLength, forceEncode, allowCopy, loaded, out encoded);
	}

	public unsafe static EncoderAction TopupAndEncode(this ILZ4Encoder encoder, byte[] source, int sourceOffset, int sourceLength, byte[] target, int targetOffset, int targetLength, bool forceEncode, bool allowCopy, out int loaded, out int encoded)
	{
		fixed (byte* ptr = source)
		{
			fixed (byte* ptr2 = target)
			{
				return encoder.TopupAndEncode(ptr + sourceOffset, sourceLength, ptr2 + targetOffset, targetLength, forceEncode, allowCopy, out loaded, out encoded);
			}
		}
	}

	private unsafe static EncoderAction FlushAndEncode(this ILZ4Encoder encoder, byte* target, int targetLength, bool forceEncode, bool allowCopy, int loaded, out int encoded)
	{
		encoded = 0;
		int blockSize = encoder.BlockSize;
		if (encoder.BytesReady < (forceEncode ? 1 : blockSize))
		{
			if (loaded <= 0)
			{
				return EncoderAction.None;
			}
			return EncoderAction.Loaded;
		}
		encoded = encoder.Encode(target, targetLength, allowCopy);
		if (allowCopy && encoded < 0)
		{
			encoded = -encoded;
			return EncoderAction.Copied;
		}
		return EncoderAction.Encoded;
	}

	public unsafe static EncoderAction FlushAndEncode(this ILZ4Encoder encoder, byte* target, int targetLength, bool allowCopy, out int encoded)
	{
		return encoder.FlushAndEncode(target, targetLength, forceEncode: true, allowCopy, 0, out encoded);
	}

	public unsafe static EncoderAction FlushAndEncode(this ILZ4Encoder encoder, byte[] target, int targetOffset, int targetLength, bool allowCopy, out int encoded)
	{
		fixed (byte* ptr = target)
		{
			return encoder.FlushAndEncode(ptr + targetOffset, targetLength, forceEncode: true, allowCopy, 0, out encoded);
		}
	}

	public unsafe static void Drain(this ILZ4Decoder decoder, byte[] target, int targetOffset, int offset, int length)
	{
		fixed (byte* ptr = target)
		{
			decoder.Drain(ptr + targetOffset, offset, length);
		}
	}

	public unsafe static bool DecodeAndDrain(this ILZ4Decoder decoder, byte* source, int sourceLength, byte* target, int targetLength, out int decoded)
	{
		decoded = 0;
		if (sourceLength <= 0)
		{
			return false;
		}
		decoded = decoder.Decode(source, sourceLength);
		if (decoded > 0 && targetLength >= decoded)
		{
			decoder.Drain(target, -decoded, decoded);
			return true;
		}
		return false;
	}

	public unsafe static bool DecodeAndDrain(this ILZ4Decoder decoder, byte[] source, int sourceOffset, int sourceLength, byte[] target, int targetOffset, int targetLength, out int decoded)
	{
		fixed (byte* ptr = source)
		{
			fixed (byte* ptr2 = target)
			{
				return decoder.DecodeAndDrain(ptr + sourceOffset, sourceLength, ptr2 + targetOffset, targetLength, out decoded);
			}
		}
	}
}
