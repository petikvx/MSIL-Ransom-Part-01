using System;
using System.IO;
using K4os.Compression.LZ4.Encoders;

namespace K4os.Compression.LZ4.Streams;

public static class LZ4Stream
{
	public static LZ4EncoderStream Encode(Stream stream, LZ4EncoderSettings settings = null, bool leaveOpen = false)
	{
		settings = settings ?? LZ4EncoderSettings.Default;
		LZ4Descriptor descriptor = new LZ4Descriptor(settings.ContentLength, settings.ContentChecksum, settings.ChainBlocks, settings.BlockChecksum, settings.Dictionary, settings.BlockSize);
		LZ4Level level = settings.CompressionLevel;
		int extraMemory = settings.ExtraMemory;
		return new LZ4EncoderStream(stream, descriptor, (ILZ4Descriptor i) => LZ4Encoder.Create(i.Chaining, level, i.BlockSize, ExtraBlocks(i.BlockSize, extraMemory)), leaveOpen);
	}

	public static LZ4EncoderStream Encode(Stream stream, LZ4Level level, int extraMemory = 0, bool leaveOpen = false)
	{
		LZ4EncoderSettings settings = new LZ4EncoderSettings
		{
			ChainBlocks = true,
			ExtraMemory = extraMemory,
			BlockSize = 65536,
			CompressionLevel = level
		};
		return Encode(stream, settings, leaveOpen);
	}

	public static LZ4DecoderStream Decode(Stream stream, LZ4DecoderSettings settings = null, bool leaveOpen = false)
	{
		settings = settings ?? LZ4DecoderSettings.Default;
		int extraMemory = settings.ExtraMemory;
		return new LZ4DecoderStream(stream, (ILZ4Descriptor i) => LZ4Decoder.Create(i.Chaining, i.BlockSize, ExtraBlocks(i.BlockSize, extraMemory)), leaveOpen);
	}

	public static LZ4DecoderStream Decode(Stream stream, int extraMemory, bool leaveOpen = false)
	{
		LZ4DecoderSettings settings = new LZ4DecoderSettings
		{
			ExtraMemory = extraMemory
		};
		return Decode(stream, settings, leaveOpen);
	}

	private static int ExtraBlocks(int blockSize, int extraMemory)
	{
		return Math.Max((extraMemory > 0) ? blockSize : 0, extraMemory) / blockSize;
	}
}
