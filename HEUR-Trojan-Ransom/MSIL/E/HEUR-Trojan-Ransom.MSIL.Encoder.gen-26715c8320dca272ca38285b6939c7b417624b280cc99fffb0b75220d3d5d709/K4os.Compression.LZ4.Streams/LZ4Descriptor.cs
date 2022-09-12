namespace K4os.Compression.LZ4.Streams;

public class LZ4Descriptor : ILZ4Descriptor
{
	public long? ContentLength { get; }

	public bool ContentChecksum { get; }

	public bool Chaining { get; }

	public bool BlockChecksum { get; }

	public uint? Dictionary { get; }

	public int BlockSize { get; }

	public LZ4Descriptor(long? contentLength, bool contentChecksum, bool chaining, bool blockChecksum, uint? dictionary, int blockSize)
	{
		ContentLength = contentLength;
		ContentChecksum = contentChecksum;
		Chaining = chaining;
		BlockChecksum = blockChecksum;
		Dictionary = dictionary;
		BlockSize = blockSize;
	}
}
